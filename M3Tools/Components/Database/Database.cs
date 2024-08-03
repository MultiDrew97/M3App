using System;

using System.ComponentModel;
using System.Threading.Tasks;

using SPPBC.M3Tools.M3API;

// FIXME: Convert Database on here and API to use a non-relational (i.e MongoDB)
namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The parent object for managing database connection and integrations
	/// </summary>
	public abstract partial class Database
	{
		/// <summary>
		/// The username to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("")]
		[Description("The username to use with the API calls")]
		[Category("Connection")]
		public string Username { get; set; }

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
		[PasswordPropertyText(true)]
		[SettingsBindable(true)]
		[DefaultValue("")]
		[Description("The password to use with the API calls")]
		[Category("Connection")]
		public string Password { get; set; }

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
		[SettingsBindable(true)]
		[DefaultValue("")]
		[Description("The URL value to use for API calls")]
		[Category("Connection")]
		public string BaseUrl { get; set; }

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		private string Auth => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));

		internal bool Execute(System.Net.Http.HttpMethod method, string path, string payload, System.Threading.CancellationToken ct)
		{
			Task<object> task = ExecuteWithResult<object>(method, path, payload, ct);

			task.Wait();

			return true switch
			{
				var faulted when faulted == task.IsFaulted => throw task.Exception,
				var canceled when canceled == task.IsCanceled => throw new TaskCanceledException("API Call was canceled"),
				_ => true
			};
		}

		/// <summary>
		/// Calls the API, returning the type specified in generic parameter
		/// </summary>
		/// <typeparam name="R">Expected return type</typeparam>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="body"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		protected internal Task<R> ExecuteWithResult<R>(System.Net.Http.HttpMethod method, string path, string body, System.Threading.CancellationToken ct = default)
			=> ExecuteWithResultAsync<R>(@method, path, new System.Net.Http.StringContent(body ?? string.Empty, System.Text.Encoding.UTF8, "application/json"), ct);

		private async Task<R> ExecuteWithResultAsync<R>(System.Net.Http.HttpMethod method, string path, System.Net.Http.HttpContent payload, System.Threading.CancellationToken ct)
		{
			try
			{
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
				}).ConfigureAwait(false);

				string body = await res.Content.ReadAsStringAsync();

				return !res.IsSuccessStatusCode
					? res.StatusCode switch
					{
						System.Net.HttpStatusCode.Unauthorized => throw new Exceptions.AuthorizationException(body),
						System.Net.HttpStatusCode.NotFound => throw new Exceptions.NotFoundException(body),
						System.Net.HttpStatusCode.Forbidden => throw new Exceptions.ApiException(body),
						System.Net.HttpStatusCode.InternalServerError => throw new Exceptions.ApiException(body),
						_ => throw new Exceptions.ApiException("Unknown API error")
					}
					: JSON.ConvertFromJSON<R>(body);
			}
			catch (AggregateException agg)
			{
				Console.WriteLine(agg.GetBaseException().GetType());
				Console.WriteLine(agg.GetBaseException().Message);
				throw new Exceptions.ApiException(agg.GetBaseException().Message);
			}
		}
	}
}