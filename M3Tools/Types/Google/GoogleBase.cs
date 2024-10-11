using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SPPBC.M3Tools.API.GTools
{

	/// <summary>
	/// Class used to store data about the Google API connection
	/// </summary>
	public class GoogleBase : ApiBase
	{
		/// <summary>
		/// The scopes to use for the API calls
		/// </summary>
		protected string[] __scopes;

		/// <summary>
		/// The user type to use for the API calls
		/// </summary>
		protected string __user;

		internal BaseClientService.Initializer __init = new() { ApplicationName = Application.ProductName, };

		private FileDataStore SaveLocation =>
				// TODO: Figure out best saving folder for tokens
				new(System.IO.Path.Combine(Utils.UserLocation, "Tokens"));/*

		private System.IO.Stream Credentials
		{
			get
			{
				if (__credsStream == null)
				{
					*//*using HttpClient client = new()
					{
						BaseAddress = new(Environment.GetEnvironmentVariable("api_base_url").Decrypt()),
						Timeout = TimeSpan.FromSeconds(30)
					};
					string username = Environment.GetEnvironmentVariable("api_username").Decrypt();
					string password = Environment.GetEnvironmentVariable("api_password").Decrypt();
					string auth = $"{username}:{password}".ToBase64String();

					client.DefaultRequestHeaders.Authorization = new("Basic", auth);*//*

					_ = base.
					HttpResponseMessage res = client.GetAsync(CREDS_LOCATION, HttpCompletionOption.ResponseContentRead).Result;

					__credsStream = res.EnsureSuccessStatusCode().Content.ReadAsStreamAsync().Result;
				}

				return __credsStream;
			}
			set => __credsStream = value;
		}*/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="user"></param>
		/// <param name="scopes"></param>
		protected GoogleBase(string user, string[] scopes)
		{
			__user = user;
			__scopes = scopes;
		}

		private async Task<UserCredential> LoadCreds(System.Threading.CancellationToken ct)
		{
			ct.ThrowIfCancellationRequested();

			GoogleClientSecrets res = ParseResponse<GoogleClientSecrets>(await ExecuteWithResultAsync(System.Net.Http.HttpMethod.Get, $"{Paths.Google}/creds"));

			UserCredential creds = await GoogleWebAuthorizationBroker.AuthorizeAsync(res.Secrets, __scopes, __user, ct, SaveLocation);

			Debug.WriteLine($"{__user} Creds Stale? {creds.Token.IsStale}");

			return creds.Token.IsStale && !await creds.RefreshTokenAsync(ct) ? throw new Exceptions.AuthorizationException("Credentials are stale") : creds;
		}

		/// <summary>
		/// Authorize with Google API on behalf of the specified user
		/// </summary>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		public virtual async Task<bool> Authorize(System.Threading.CancellationToken ct = default)
		{
			// Place general authorization logic here
			try
			{
				ct.ThrowIfCancellationRequested();

				__init.HttpClientInitializer = await LoadCreds(ct);

				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
			}

			return false;
		}
	}
}