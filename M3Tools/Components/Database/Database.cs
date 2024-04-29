using System;

// needed for database work
// got the database set up information from here
// https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SPPBC.M3Tools.M3API;

// TODO: Go through all functions and make sure that all schema values are present in database

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// 
	/// </summary>
    public partial class Database
    {
		/// <summary>
		/// The username to use for the API calls
		/// </summary>
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The username to use with the API calls")]
        public string Username { protected internal get; set; }

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
        [PasswordPropertyText(true)]
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The password to use with the API calls")]
        public string Password { protected internal get; set; }

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The URL value to use for API calls")]
        public string BaseUrl { get; set; }

		private string Auth => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));

		internal void Execute(Method @method, string path, string payload = null)
		{
			ExecuteWithResult<object>(@method, path, payload);
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
				using var stream = req.GetRequestStream();
				stream.Write(payload, 0, payload.Count());
			}

			using var res = VerifyResponse((System.Net.HttpWebResponse)req.GetResponseAsync().Result);
			return Task.FromResult(JSON.ConvertFromJSON<R>(new System.IO.StreamReader(res.GetResponseStream()).ReadToEnd()));
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
