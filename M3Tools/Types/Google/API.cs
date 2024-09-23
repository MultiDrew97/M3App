using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SPPBC.M3Tools.Types.GTools
{

	/// <summary>
	/// Class used to store data about the Google API connection
	/// </summary>
	public class API : Component, IDisposable
	{
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

				System.IO.MemoryStream stream = new(Properties.Resources.credentials);

				UserCredential creds = await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, __scopes, __user, ct, SaveLocation);

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
