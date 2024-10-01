using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class UserDatabase : Database
	{
		public UserDatabase() : base() => InitializeComponent();

		/// <summary>
		/// Create a new user for the application
		/// </summary>
		/// <param name="user"></param>
		/// <param name="ct"></param>
		public async void CreateUser(User user, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Post, Paths.Users, JSON.ConvertToJSON(user), ct);

		/// <summary>
		/// Change the password of the specified user
		/// </summary>
		/// <param name="username"></param>
		/// <param name="oldPassword"></param>
		/// <param name="newPassword"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool ChangePassword(string username, string oldPassword, string newPassword, System.Threading.CancellationToken ct = default)
			=> throw new NotImplementedException("ChangePassword");

		/// <summary>
		/// Completely delete the specified user's account
		/// </summary>
		/// <param name="userID"></param>
		/// <param name="ct"></param>
		public async void CloseAccount(int userID, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Delete, string.Join("/", Paths.Users, userID)/*$"{Paths.Users}/{userID}"*/, string.Empty, ct);

		/// <summary>
		/// Login a user using the provided login info
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public async Task<User> Login(string username, string password, System.Threading.CancellationToken ct = default)
			=> await Login(new Auth(username, password), ct);

		/// <summary>
		/// Attempt to login a user provided their username and password
		/// </summary>
		/// <param name="auth">The credentials to use for logging in the user</param>
		/// <param name="ct"></param>
		/// <returns>The user if successful, otherwise Nothing</returns>
		private async Task<User> Login(Auth auth, System.Threading.CancellationToken ct)
		{
			try
			{
				Console.WriteLine($"Logging in user with username {auth.Username}...");
				return await ExecuteWithResultAsync<User>(System.Net.Http.HttpMethod.Post, $"{Paths.Users}/login", JSON.ConvertToJSON(auth), ct);
			}
			catch (Exception ex)
			{
				Exception baseEx = ex.GetBaseException();

				throw baseEx.Message switch
				{
					var username when Regex.IsMatch(username, @".*username.*", RegexOptions.IgnoreCase) => new Exceptions.UsernameException(),
					var password when Regex.IsMatch(password, @".*password.*", RegexOptions.IgnoreCase) => new Exceptions.PasswordException(),
					_ => baseEx
				};
			}
		}
	}
}
