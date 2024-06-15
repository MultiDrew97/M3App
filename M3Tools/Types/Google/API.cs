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

		void IDisposable.Dispose() => Close();

		/// <summary>
		/// 	Closes the connection to Google Drive
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
				// TODO: Change saving folder. Requires admin permissions to save here
				string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string path = System.IO.Path.Combine(folder, $@"SPPBC\{Username}\Tokens");

				return new FileDataStore(path);
			}
		}

		protected API(string user, string[] scopes)
		{
			InitializeComponent();
			__user = user;
			__scopes = scopes;
		}

        protected internal virtual System.Threading.Tasks.Task<UserCredential> LoadCreds(System.Threading.CancellationToken ct)
        {
			if (ct.IsCancellationRequested) return (System.Threading.Tasks.Task<UserCredential>)System.Threading.Tasks.Task.FromCanceled(ct);

            var stream = new System.IO.MemoryStream(My.Resources.Resources.credentials);

            return GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, __scopes, __user, ct, SaveLocation);
        }

		/// <summary>
		/// Authorize with Google API on behalf of the specified user
		/// </summary>
		/// <param name="username">The username of the current user using the app itself</param>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		public virtual void Authorize(System.Threading.CancellationToken ct = default)
        {
			// Place general authorization logic here
			if (ct.IsCancellationRequested)
				ct.ThrowIfCancellationRequested();

			using var creds = LoadCreds(ct);

			if (creds == null) throw new Exception("Creds is null");

			creds.Wait(ct);
			if (creds.IsCanceled) throw new Exception("Canceled");
			if (creds.IsFaulted) throw new Exception("Faulted");

			__init.HttpClientInitializer = creds.Result;
		}
    }
}
