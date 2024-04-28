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

    internal enum ColumnSelection
    {
        ID,
        Email,
        Stock,
        Price
    }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public partial class Database<T> where T : Types.IDbEntry, new()
    {
		/// <summary>
		/// The username to use for the API calls
		/// </summary>
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The username to use with the API calls")]
        public string Username { protected get; set; }

		/// <summary>
		/// The password to use for the API calls
		/// </summary>
        [PasswordPropertyText(true)]
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The password to use with the API calls")]
        public string Password { protected get; set; }

		/// <summary>
		/// The URL to use for the API calls
		/// </summary>
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The URL value to use for API calls")]
        public string BaseUrl { get; set; }

        private string Auth
        {
            get
            {
                return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));
            }
        }

		internal void Execute(Method @method, string path, string payload = null)
		{
			ExecuteWithResult<object>(@method, path, payload);
		}
	
		/*private void Execute(Method @method, string path, byte[] payload = null)
		{
			System.Net.HttpWebRequest req;

			req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(BaseUrl + path);
			req.Method = @method.ToString().ToUpper();
			req.Accept = "application/json";
			req.Headers.Add(System.Net.HttpRequestHeader.Authorization, $"Basic {Auth}");

			if (payload is not null)
			{
				req.ContentType = "application/json";
				using var stream = req.GetRequestStream();
				stream.Write(payload, 0, payload.Count());
			}

			VerifyResponse((System.Net.HttpWebResponse)req.GetResponseAsync().Result);
		}*/

		internal Task<T> ExecuteWithResult<T>(Method @method, string path, string payload = null)
        {
            return ExecuteWithResult<T>(@method, path, !string.IsNullOrWhiteSpace(payload) ? System.Text.Encoding.UTF8.GetBytes(payload) : null);
        }

        private Task<T> ExecuteWithResult<T>(Method @method, string path, byte[] payload = null)
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
			return Task.FromResult(JSON.ConvertFromJSON<T>(new System.IO.StreamReader(res.GetResponseStream()).ReadToEnd()));
		}

        private System.Net.HttpWebResponse VerifyResponse(System.Net.HttpWebResponse res)
        {
            switch (res.StatusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized:
                    throw new Exceptions.AuthorizationException(res.StatusDescription);
                case System.Net.HttpStatusCode.NotFound:
                    throw new Exceptions.NotFoundException(res.StatusDescription);
                case System.Net.HttpStatusCode.Forbidden:
                    throw new Exceptions.ApiException(res.StatusDescription);
                default:
                    return res;
            }
        }
    }
}
