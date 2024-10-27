using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SPPBC.M3Tools.API.GTools
{
	/// <summary>
	/// How the user should be referenced in the GoogleAPI
	/// </summary>
	public readonly struct GoogleUserType
	{
		/// <summary>
		/// Value used for Google Drive
		/// </summary>
		public static readonly string DRIVE = "user";

		/// <summary>
		/// Value used for GMail
		/// </summary>
		public static readonly string MAIL = "me";
	}

	/// <summary>
	/// Class used to store data about the Google API connection
	/// </summary>
	public abstract class GoogleBase : ApiBase
	{
		/// <summary>
		/// The scopes to use for the API calls
		/// </summary>
		protected string[] __scopes;

		/// <summary>
		/// The user type to use for the API calls
		/// </summary>
		protected string __user;

		internal BaseClientService.Initializer __init = new() { ApplicationName = Application.ProductName };

		/// <summary>
		/// The location the token is stored
		/// </summary>
		protected string SaveLocation =>
				// TODO: Figure out best saving location for user's tokens
				System.IO.Path.Combine(Utils.UserLocation, "Tokens");

		/// <summary>
		/// 
		/// </summary>
		protected UserCredential Credentials;

		/// <summary>
		/// Contains the core logic for everything that has to do with the GoogleAPI
		/// </summary>
		/// <param name="user"></param>
		/// <param name="scopes"></param>
		protected GoogleBase(string user, string[] scopes)
		{
			__user = user;
			__scopes = scopes;
		}

		private async Task<UserCredential> LoadCreds(CancellationToken ct = default)
		{
			ct.ThrowIfCancellationRequested();
			Debug.WriteLine("Loading credentials...");

			Debug.WriteLine("Getting google secrets...");
			GoogleClientSecrets credRes = await ExecuteWithResultAsync<GoogleClientSecrets>(System.Net.Http.HttpMethod.Get, $"{Paths.Google}/creds", ct: ct);

			Debug.WriteLine($"Checking credentials: {__user}");
			UserCredential creds = await GoogleWebAuthorizationBroker.AuthorizeAsync(credRes.Secrets, __scopes, __user, ct, new FileDataStore(SaveLocation, true));

			Debug.WriteLine($"{__user} Creds Stale? {creds.Token.IsStale}");

			return creds.Token.IsStale && !await creds.RefreshTokenAsync(ct) ? throw new Exceptions.AuthorizationException("Credentials are stale") : creds;
		}

		/// <summary>
		/// Authorize with Google API on behalf of the specified user
		/// </summary>
		/// <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		protected virtual async Task Authorize(CancellationToken ct = default)
		{
			// Place general authorization logic here
			try
			{
				ct.ThrowIfCancellationRequested();

				Credentials ??= await LoadCreds(ct);

				if (Credentials.Token.IsStale && !await Credentials.RefreshTokenAsync(ct))
					throw new Exceptions.AuthorizationException("Token is stale");

				__init.HttpClientInitializer = Credentials;
			}
			catch (OperationCanceledException)
			{ }
			catch (TokenResponseException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}