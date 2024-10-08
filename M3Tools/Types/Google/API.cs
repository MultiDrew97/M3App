using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using SPPBC.M3Tools.Types.Extensions;

// FIXME: Consolidate this with the database component so that all API calls are handled in one place

namespace SPPBC.M3Tools.Types.GTools
{

	/// <summary>
	/// Class used to store data about the Google API connection
	/// </summary>
	public class API : Component, IDisposable
	{
		private readonly string CREDS_LOCATION = "/api/google/creds";
		private System.IO.Stream __credsStream;

		/// <summary>
		/// The username of the current user using the app itself
		/// </summary>
		[Category("User")]
		[SettingsBindable(true)]
		[Description("The username of the currently logged in user")]
		public string Username { get; set; }

		/// <summary>
		/// The scopes to use for the API calls
		/// </summary>
		protected string[] __scopes;

		/// <summary>
		/// The user type to use for the API calls
		/// </summary>
		protected string __user;

		internal BaseClientService.Initializer __init = new() { ApplicationName = Application.ProductName, };

		void IDisposable.Dispose() => Close();

		/// <summary>
		/// Closes the connection to Google Drive
		/// </summary>
		public virtual void Close()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private FileDataStore SaveLocation =>
				// TODO: Figure out best saving folder for tokens
				new(System.IO.Path.Combine(Utils.UserLocation, "Tokens"));

		private System.IO.Stream Credentials
		{
			get
			{
				if (__credsStream == null)
				{
					using HttpClient client = new()
					{
						BaseAddress = new(Environment.GetEnvironmentVariable("api_base_url").Decrypt()),
						Timeout = TimeSpan.FromSeconds(30)
					};
					string username = Environment.GetEnvironmentVariable("api_username").Decrypt();
					string password = Environment.GetEnvironmentVariable("api_password").Decrypt();
					string auth = $"{username}:{password}".ToBase64String();

					client.DefaultRequestHeaders.Authorization = new("Basic", auth);
					HttpResponseMessage res = client.GetAsync(CREDS_LOCATION, HttpCompletionOption.ResponseContentRead).Result;

					__credsStream = res.EnsureSuccessStatusCode().Content.ReadAsStreamAsync().Result;
				}

				return __credsStream;
			}
			set => __credsStream = value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="user"></param>
		/// <param name="scopes"></param>
		protected API(string user, string[] scopes)
		{
			__user = user;
			__scopes = scopes;
		}

		private async Task<UserCredential> LoadCreds(System.Threading.CancellationToken ct)
		{
			try
			{
				ct.ThrowIfCancellationRequested();

				UserCredential creds = await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(Credentials).Secrets, __scopes, __user, ct, SaveLocation);

				return creds == null
					? throw new Exception("No creds were found")
					: creds.Token.IsStale && !await creds.RefreshTokenAsync(ct) ? throw new Exception("Credentials are stale") : creds;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Authorize with Google API on behalf of the specified user
		/// </summary>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		public virtual async void Authorize(System.Threading.CancellationToken ct = default)
		{
			// Place general authorization logic here
			ct.ThrowIfCancellationRequested();

			__init.HttpClientInitializer = await LoadCreds(ct);
		}
	}
}
