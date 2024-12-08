using System;

using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Types.Extensions;

// FIXME: Convert Database on here and API to use a non-relational (i.e MongoDB)
namespace SPPBC.M3Tools.API
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

		/// <summary>
		/// Google based path
		/// </summary>
		public static string Google = string.Join(Separator, Base, "google");
		#endregion
	}

	/// <summary>
	/// The parent object for managing database connection and integrations
	/// </summary>
	public abstract partial class ApiBase
	{
		private readonly CancellationTokenSource _tokenSource = new();

		/// <summary>
		/// The username to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("username")]
		[Description("The username to use with the API calls")]
		[Category("Connection")]
		public string Username => Environment.GetEnvironmentVariable("api_username", EnvironmentVariableTarget.Process).Decrypt();

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
		[PasswordPropertyText(true)]
		[SettingsBindable(true)]
		[DefaultValue("password")]
		[Description("The password to use with the API calls")]
		[Category("Connection")]
		public string Password => Environment.GetEnvironmentVariable("api_password", EnvironmentVariableTarget.Process).Decrypt();

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("http://localhost:3000")]
		[Description("The URL value to use for API calls")]
		[Category("Connection")]
		public string BaseUrl => Environment.GetEnvironmentVariable("api_base_url", EnvironmentVariableTarget.Process).Decrypt();

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[PasswordPropertyText(true)]
		private string Auth => $"{Username}:{Password}".ToBase64String();

		/// <summary>
		/// 
		/// </summary>
		protected ApiBase()
		{
			InitializeComponent();

			Disposed += new EventHandler(Cleanup);

		}

		/// <summary>
		/// Performs cleanup functions of the API base
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Cleanup(object sender, EventArgs e) => _tokenSource.Cancel();

		/// <summary>
		/// Make a call to the API without using 
		/// </summary>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="payload"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		protected internal async Task<bool> ExecuteAsync(System.Net.Http.HttpMethod method, string path, string payload, CancellationToken ct = default)
		{
			_ = await ExecuteWithResultAsync<IDbEntry>(method, path, payload, ct);

			return true;
		}

		/// <summary>
		/// Calls the API, using the async/await functionality
		/// </summary>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="body"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		protected internal async Task<T> ExecuteWithResultAsync<T>(System.Net.Http.HttpMethod method, string path, string body = default, CancellationToken ct = default)
			=> await ExecuteWithResultAsync<T>(method, path, new System.Net.Http.StringContent(body ?? string.Empty, System.Text.Encoding.UTF8, "application/json"), ct);

		private async Task<T> ExecuteWithResultAsync<T>(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, CancellationToken ct)
		{
			Console.WriteLine("Starting API call...");
			Debug.WriteLine($"Base URL - {BaseUrl}", "API");
			try
			{
				Console.WriteLine("Configuring HTTP client");
				using System.Net.Http.HttpClient client = new()
				{
					BaseAddress = new(BaseUrl),
					Timeout = TimeSpan.FromSeconds(30),
					DefaultRequestHeaders = {
						Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Auth),
					}
				};

				Console.WriteLine("Setting up client headers...");
				client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

				Console.WriteLine($"Making {method.Method} call to API at path {path}...");
				System.Net.Http.HttpResponseMessage res = await (method.Method switch
				{
					"GET" => client.GetAsync(path, ct),
					"POST" => client.PostAsync(path, payload, ct),
					"PUT" => client.PutAsync(path, payload, ct),
					"DELETE" => client.DeleteAsync(path, ct),
					_ => throw new ArgumentException($"{method.Method} is not a valid method type")
				});

				Console.WriteLine("API call complete. Parsing response body...");
				string body = await res.Content.ReadAsStringAsync();
				Console.WriteLine(body);
				Debug.WriteLine(body, "API");

				return res.IsSuccessStatusCode
					? JSON.ConvertFromJSON<T>(body)
					: throw res.StatusCode switch
					{
						System.Net.HttpStatusCode.Unauthorized => new Exceptions.AuthorizationException(body),
						System.Net.HttpStatusCode.NotFound => new Exceptions.NotFoundException(body),
						System.Net.HttpStatusCode.Forbidden => new Exceptions.ApiException(body),
						System.Net.HttpStatusCode.InternalServerError => new Exceptions.ApiException(body),
						_ => new Exceptions.ApiException("Unknown API error")
					};
			}
			catch (AggregateException agg)
			{
				Exception baseEx = agg.GetBaseException();
				Console.Error.WriteLine("Error occurred in database API call...");
				Console.Error.WriteLine(agg.StackTrace);
				Debug.WriteLine($"Base Exception Type: {baseEx.GetType()}", "API Error");
				Debug.WriteLine($"Base Exception Message: {baseEx.Message}", "API Error");
				throw new Exceptions.ApiException(baseEx.Message);
			}
		}
	}
}