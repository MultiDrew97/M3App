using System;
using System.ComponentModel;
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

		internal BaseClientService.Initializer __init = new() { ApplicationName = "Media Ministry Manager", };

		void IDisposable.Dispose()
		{
			Close();
		}

		/// <summary>
		/// Closes the connection to Google Drive
		/// </summary>
		public virtual void Close()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private FileDataStore SaveLocation
		{
			get
			{
				// TODO: Figure out best saving folder for tokens
				string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string path = System.IO.Path.Combine(folder, $@"SPPBC\{Username}\Tokens");

				return new FileDataStore(path);
			}
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

		private System.Threading.Tasks.Task<UserCredential> LoadCreds(System.Threading.CancellationToken ct)
		{
			if (ct.IsCancellationRequested)
			{
				return (System.Threading.Tasks.Task<UserCredential>)System.Threading.Tasks.Task.FromCanceled(ct);
			}

			System.IO.MemoryStream stream = new(Properties.Resources.credentials);

			return GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, __scopes, __user, ct, SaveLocation);
		}

		/// <summary>
		/// Authorize with Google API on behalf of the specified user
		/// </summary>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		public virtual void Authorize(System.Threading.CancellationToken ct = default)
		{
			// Place general authorization logic here
			if (ct.IsCancellationRequested)
			{
				return;
			}

			using System.Threading.Tasks.Task<UserCredential> creds = LoadCreds(ct);

			if (creds == null)
			{
				throw new Exception("Creds is null");
			}

			creds.Wait(ct);
			if (creds.IsCanceled)
			{
				throw new Exception("Canceled");
			}

			if (creds.IsFaulted)
			{
				throw new Exception("Faulted");
			}

			if (creds.Result.Token.IsStale)
			{
				_ = creds.Result.RefreshTokenAsync(ct);
			}

			__init.HttpClientInitializer = creds.Result;
		}
	}
}
