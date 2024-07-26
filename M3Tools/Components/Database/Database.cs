using System;

using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SPPBC.M3Tools.M3API;

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

		internal void Execute(Method @method, string path, string payload = null)
		{
			Task<object> result = ExecuteWithResult<object>(@method, path, payload);

			if (result.IsFaulted)
			{
				throw result.Exception;
			}

			if (result.IsCanceled)
			{
				throw new TaskCanceledException("API Call was canceled");
			}

			if (!result.IsCompleted)
			{
				throw new Exception("API Call not finihsed yet");
			}
		}

		/// <summary>
		/// Calls the API, returning the type specified in generic parameter
		/// </summary>
		/// <typeparam name="R">Expected return type</typeparam>
		/// <param name="method"></param>
		/// <param name="path"></param>
		/// <param name="payload"></param>
		/// <returns></returns>
		protected Task<R> ExecuteWithResult<R>(Method @method, string path, string payload = null)
		{
			return ExecuteWithResult<R>(@method, path, !string.IsNullOrWhiteSpace(payload) ? System.Text.Encoding.UTF8.GetBytes(payload) : null);
		}

		private Task<R> ExecuteWithResult<R>(Method @method, string path, byte[] payload = null)
		{
			System.Net.HttpWebRequest req;

			req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create($"{BaseUrl}/{path}");
			req.Method = @method.ToString().ToUpper();
			req.Accept = "application/json";
			req.Headers.Add(System.Net.HttpRequestHeader.Authorization, $"Basic {Auth}");

			if (payload is not null)
			{
				req.ContentType = "application/json";
				using System.IO.Stream stream = req.GetRequestStream();
				stream.Write(payload, 0, payload.Count());
			}

			try
			{
				using System.Net.HttpWebResponse res = VerifyResponse((System.Net.HttpWebResponse)req.GetResponseAsync().Result);

				return Task.FromResult(JSON.ConvertFromJSON<R>(new System.IO.StreamReader(res.GetResponseStream()).ReadToEnd()));
			}
			catch (System.Text.Json.JsonException json)
			{
				Console.Error.WriteLine(json.Message);
				return Task.FromException<R>(json);
			}
			catch (Exceptions.AuthorizationException auth)
			{
				Console.Error.WriteLine(auth.Message);
				return Task.FromException<R>(auth);
			}
			catch (Exceptions.ApiException api)
			{
				Console.Error.WriteLine(api.Message);
				return Task.FromException<R>(api);
			}
			catch (Exceptions.NotFoundException notfound)
			{
				Console.Error.WriteLine(notfound.Message);
				return Task.FromException<R>(notfound);
			}
			catch (AggregateException ex)
			{
				Console.Error.WriteLine(ex.InnerException.Message);
				return Task.FromException<R>(ex.InnerException);
			}
		}

		private System.Net.HttpWebResponse VerifyResponse(System.Net.HttpWebResponse res)
		{
			return res.StatusCode switch
			{
				System.Net.HttpStatusCode.Unauthorized => throw new Exceptions.AuthorizationException(res.StatusDescription),
				System.Net.HttpStatusCode.NotFound => throw new Exceptions.NotFoundException(res.StatusDescription),
				System.Net.HttpStatusCode.Forbidden => throw new Exceptions.ApiException(res.StatusDescription),
				_ => res,
			};
		}
	}
}
