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
	public abstract partial class Database : Component
	{
		/// <summary>
		/// The username to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("username")]
		[Description("The username to use with the API calls")]
		[Category("Connection")]
		public string Username { get; set; }

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
		[PasswordPropertyText(true)]
		[SettingsBindable(true)]
		[DefaultValue("password")]
		[Description("The password to use with the API calls")]
		[Category("Connection")]
		public string Password { get; set; }

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("http://localhost:3000")]
		[Description("The URL value to use for API calls")]
		[Category("Connection")]
		public string BaseUrl { get; set; }

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[PasswordPropertyText(true)]
		private string Auth => $"{Username}:{Password}".ToBase64String();

		internal async Task<bool> ExecuteAsync(System.Net.Http.HttpMethod method, string path, string payload, System.Threading.CancellationToken cancellationToken = default)
		=> await ExecuteAsync(method, path, new System.Net.Http.StringContent(payload), cancellationToken);

		private async Task<bool> ExecuteAsync(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, System.Threading.CancellationToken ct) => await ExecuteWithResultAsync<bool>(method, path, payload, ct);

		/// <summary>
		/// Calls the API, using the async/await functionality
		/// </summary>
		/// <typeparam name="R"></typeparam>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="body"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		protected internal Task<R> ExecuteWithResultAsync<R>(System.Net.Http.HttpMethod method, string path, string body, System.Threading.CancellationToken ct = default)
			=> ExecuteWithResultAsync<R>(method, path, new System.Net.Http.StringContent(body ?? string.Empty, System.Text.Encoding.UTF8, "application/json"), ct);

		private async Task<R> ExecuteWithResultAsync<R>(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, System.Threading.CancellationToken ct)
		{
			try
			{
				Debug.WriteLine($"Base URL: {BaseUrl}", "API");

				using System.Net.Http.HttpClient client = new()
				{
					BaseAddress = new(BaseUrl),
					Timeout = TimeSpan.FromSeconds(30),
				};

				client.DefaultRequestHeaders.Authorization = new("Basic", Auth);
				client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

				System.Net.Http.HttpResponseMessage res = await (method switch
				{
					var get when get == System.Net.Http.HttpMethod.Get => client.GetAsync(path, ct),
					var post when post == System.Net.Http.HttpMethod.Post => client.PostAsync(path, payload, ct),
					var put when put == System.Net.Http.HttpMethod.Put => client.PutAsync(path, payload, ct),
					var delete when delete == System.Net.Http.HttpMethod.Delete => client.DeleteAsync(path, ct),
					_ => throw new ArgumentException($"{method.Method} is not a valid method type")
				});

				string body = await res.Content.ReadAsStringAsync();

				// TODO: Make this look and feel better
				return !res.IsSuccessStatusCode
					? res.StatusCode switch
					{
						System.Net.HttpStatusCode.Unauthorized => throw new Exceptions.AuthorizationException(body),
						System.Net.HttpStatusCode.NotFound => throw new Exceptions.NotFoundException(body),
						System.Net.HttpStatusCode.Forbidden => throw new Exceptions.ApiException(body),
						System.Net.HttpStatusCode.InternalServerError => throw new Exceptions.ApiException(body),
						_ => throw new Exceptions.ApiException("Unknown API error")
					}
					: typeof(R) != typeof(bool)
					? JSON.ConvertFromJSON<R>(body) : default;
			}
			catch (AggregateException agg)
			{
				Debug.WriteLine($"Base Exception Type: {agg.GetBaseException().GetType()}", "API");
				Debug.WriteLine($"Base Exception Message: {agg.GetBaseException().Message}", "API");
				throw new Exceptions.ApiException(agg.GetBaseException().Message);
			}
		}
	}
}