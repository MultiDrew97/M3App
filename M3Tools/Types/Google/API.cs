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
    public class API : Component
    {
		// MAYBE: Might not need to have public if at all after refactoring?
		/// <summary>
		/// The username of the current user using the app itself
		/// </summary>
		[Category("User")]
        [SettingsBindable(true)]
        [Description("The username of the currently logged in user")]
        public string Username { get; set; }

        internal BaseClientService.Initializer __init = new() { ApplicationName = "Media Ministry Manager" };

        internal FileDataStore SaveLocation
        {
            get
            {
                // TODO: Change saving folder. Requires admin permissions to save here
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string path = System.IO.Path.Combine(folder, $@"SPPBC\{Username}\Tokens");

                return new FileDataStore(path);
            }
        }

        internal void LoadCreds(string user, string[] scopes, System.Threading.CancellationToken ct)
        {
            var stream = new System.IO.MemoryStream(My.Resources.Resources.credentials);

            __init.HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, scopes, user, ct, SaveLocation).Result;
        }

		/// <summary>
		/// 	Authorize with Google Drive based on the username passed
		/// </summary>
		/// <param name="username">The username of the current user using the app itself</param>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		public virtual void Authorize(string username, System.Threading.CancellationToken ct = default)
        {
            // Place general authorization logic here
            Username = username;
        }
    }
}
