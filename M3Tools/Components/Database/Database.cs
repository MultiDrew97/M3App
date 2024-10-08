using System;

using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types.Extensions;

// FIXME: Convert Database on here and API to use a non-relational (i.e MongoDB)
namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// All the pathing information for the API
	/// </summary>
	public struct Paths
	{
		// MAYBE: Move to a resource or settings file?
		private static readonly string Base = "/api";

		/// <summary>
		/// The character to separate the path sections
		/// </summary>
		// MAYBE: Move to a resource or settings file?
		public static readonly string Separator = "/";

		#region Routes
		/// <summary>
		/// User based path
		/// </summary>
		public static string Users = string.Join(Separator, Base, "users");

		/// <summary>
		/// Customer based path
		/// </summary>
		public static string Customers = string.Join(Separator, Base, "customers");

		/// <summary>
		/// Listener based path
		/// </summary>
		public static string Listeners = string.Join(Separator, Base, "listeners");

		/// <summary>
		/// Inventory based path
		/// </summary>
		public static string Inventory = string.Join(Separator, Base, "inventory");

		/// <summary>
		/// Order based path
		/// </summary>
		public static string Orders = string.Join(Separator, Base, "orders");
		#endregion
	}

	/// <summary>
	/// The parent object for managing database connection and integrations
	/// </summary>
	public abstract partial class Database
	{
		private readonly System.Net.Http.HttpClient client;

		/// <summary>
		/// The username to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("username")]
		[Description("The username to use with the API calls")]
		[Category("Connection")]
		public string Username { private get; set; }

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
		[PasswordPropertyText(true)]
		[SettingsBindable(true)]
		[DefaultValue("password")]
		[Description("The password to use with the API calls")]
		[Category("Connection")]
		public string Password { private get; set; }

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("http://localhost:3000")]
		[Description("The URL value to use for API calls")]
		[Category("Connection")]
		public string BaseUrl { private get; set; }

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[PasswordPropertyText(true)]
		private string Auth => $"{Username}:{Password}".ToBase64String();

		/// <summary>
		/// 
		/// </summary>
		protected Database() => InitializeComponent();

		internal async Task<bool> ExecuteAsync(System.Net.Http.HttpMethod method, string path, string payload, System.Threading.CancellationToken cancellationToken = default)
			=> await ExecuteAsync(method, path, new System.Net.Http.StringContent(payload), cancellationToken);

		private async Task<bool> ExecuteAsync(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, System.Threading.CancellationToken ct)
			=> await ExecuteWithResultAsync<bool>(method, path, payload, ct);

		/// <summary>
		/// Calls the API, using the async/await functionality
		/// </summary>
		/// <typeparam name="R"></typeparam>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="body"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		protected async Task<R> ExecuteWithResultAsync<R>(System.Net.Http.HttpMethod method, string path, string body, System.Threading.CancellationToken ct)
			=> await ExecuteWithResultAsync<R>(method, path, new System.Net.Http.StringContent(body ?? string.Empty, System.Text.Encoding.UTF8, "application/json"), ct);

		private async Task<R> ExecuteWithResultAsync<R>(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, System.Threading.CancellationToken ct)
		{
			Console.WriteLine("Starting API call...");
			Debug.WriteLine($"Base URL: {BaseUrl}", "API");
			try
			{
				Console.WriteLine("Configuring HTTP client");
				using System.Net.Http.HttpClient client = new()
				{
					BaseAddress = new(BaseUrl),
					Timeout = TimeSpan.FromSeconds(30),
				};

				Console.WriteLine("Setting up client headers...");
				client.DefaultRequestHeaders.Authorization = new("Basic", Auth);
				client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

				Console.WriteLine($"Making {method.Method} call to API...");
				System.Net.Http.HttpResponseMessage res = await (method.Method.ToUpper() switch
				{
					"GET" => client.GetAsync(path, ct),
					"POST" => client.PostAsync(path, payload, ct),
					"PUT" => client.PutAsync(path, payload, ct),
					"DELETE" => client.DeleteAsync(path, ct),
					_ => throw new ArgumentException($"{method.Method} is not a valid method type")
				});

				Console.WriteLine("API call complete. Parsing response body...");
				string body = await res.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
				Debug.WriteLine(body, "API");

				// TODO: Make this look and feel better
				return !res.IsSuccessStatusCode
					? throw res.StatusCode switch
					{
						System.Net.HttpStatusCode.Unauthorized => new Exceptions.AuthorizationException(body),
						System.Net.HttpStatusCode.NotFound => new Exceptions.NotFoundException(body),
						System.Net.HttpStatusCode.Forbidden => new Exceptions.ApiException(body),
						System.Net.HttpStatusCode.InternalServerError => new Exceptions.ApiException(body),
						_ => new Exceptions.ApiException("Unknown API error")
					}
					: typeof(R) != typeof(bool) ? JSON.ConvertFromJSON<R>(body) : default;
			}
			catch (AggregateException agg)
			{
				Console.Error.WriteLine("Error occurred in database API call...");
				Console.Error.WriteLine(agg.StackTrace);
				Debug.WriteLine($"Base Exception Type: {agg.GetBaseException().GetType()}", "API");
				Debug.WriteLine($"Base Exception Message: {agg.GetBaseException().Message}", "API");
				throw new Exceptions.ApiException(agg.GetBaseException().Message);
			}
		}
	}
}