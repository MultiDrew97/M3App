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

    internal partial class Database
    {
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The username to use with the API calls")]
        internal string Username { get; set; }

        [PasswordPropertyText(true)]
        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The password to use with the API calls")]
        internal string Password { get; set; }

        [SettingsBindable(true)]
        [DefaultValue("")]
        [Description("The URL value to use for API calls")]
        internal string BaseUrl { get; set; }

        private string Auth
        {
            get
            {
                return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));
            }
        }

        // Sub New(username As String, password As String, Optional baseUrl As String = Nothing)
        // Me.Username = username
        // Me.Password = password
        // Me.BaseUrl = baseUrl
        // End Sub

        internal void Consume(Method @method, string path, string payload = null)
        {
            Consume(@method, path, !string.IsNullOrWhiteSpace(payload) ? System.Text.Encoding.UTF8.GetBytes(payload) : null);
        }

        private void Consume(Method @method, string path, byte[] payload = null)
        {
            System.Net.HttpWebRequest req;

            req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(BaseUrl + path);
            req.Method = @method.ToString().ToUpper();
            req.Accept = "application/json";
            req.Headers.Add(System.Net.HttpRequestHeader.Authorization, $"Basic {Auth}");

            if (payload is not null)
            {
                req.ContentType = "application/json";
                using (var stream = req.GetRequestStream())
                {
                    stream.Write(payload, 0, payload.Count());
                }
            }

            VerifyResponse((System.Net.HttpWebResponse)req.GetResponseAsync().Result);
        }

        internal Task<T> Consume<T>(Method @method, string path, string payload = null)
        {
            return Consume<T>(@method, path, !string.IsNullOrWhiteSpace(payload) ? System.Text.Encoding.UTF8.GetBytes(payload) : null);
        }

        private Task<T> Consume<T>(Method @method, string path, byte[] payload = null)
        {
            System.Net.HttpWebRequest req;

            req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(BaseUrl + path);
            req.Method = @method.ToString().ToUpper();
            req.Accept = "application/json";
            req.Headers.Add(System.Net.HttpRequestHeader.Authorization, $"Basic {Auth}");

            if (payload is not null)
            {
                req.ContentType = "application/json";
                using (var stream = req.GetRequestStream())
                {
                    stream.Write(payload, 0, payload.Count());
                }
            }

            using (var res = VerifyResponse((System.Net.HttpWebResponse)req.GetResponseAsync().Result))
            {
                return Task.FromResult(JSON.ConvertFromJSON<T>(new System.IO.StreamReader(res.GetResponseStream()).ReadToEnd()));
            }
        }

        private System.Net.HttpWebResponse VerifyResponse(System.Net.HttpWebResponse res)
        {
            switch (res.StatusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized:
                    {
                        throw new Exceptions.AuthorizationException(res.StatusDescription);
                    }
                case System.Net.HttpStatusCode.NotFound:
                    {
                        throw new Exceptions.PathNotFoundException(res.StatusDescription);
                    }
                case System.Net.HttpStatusCode.Forbidden:
                    {
                        throw new Exceptions.ApiException(res.StatusDescription);
                    }

                default:
                    {
                        return res;
                    }
            }
        }
    }
}