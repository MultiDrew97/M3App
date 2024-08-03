using System;
using System.Text.RegularExpressions;

using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class UserDatabase
	{
		private const string path = "users";

		/// <summary>
		/// Create a new user in the database for the app
		/// </summary>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="email"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="role"></param>
		/// <param name="ct"></param>
		public void CreateUser(string fName, string lName, string email, string username, string password, AccountRole role = AccountRole.User, System.Threading.CancellationToken ct = default)
			=> CreateUser(new(-1, fName: fName, lName: lName, email: email, username: username, password: password, accountRole: role), ct);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="user"></param>
		/// <param name="ct"></param>
		public void CreateUser(User user, System.Threading.CancellationToken ct = default) => Execute(System.Net.Http.HttpMethod.Post, $"/{path}", JSON.ConvertToJSON(user), ct);

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
		/// Completly delete the specified user's account
		/// </summary>
		/// <param name="userID"></param>
		/// <param name="ct"></param>
		public void CloseAccount(int userID, System.Threading.CancellationToken ct = default) => Execute(System.Net.Http.HttpMethod.Delete, $"/{path}/{userID}", ct: ct);

		/// <summary>
		/// Login a user using the provided login info
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public User Login(string username, string password, System.Threading.CancellationToken ct = default) => Login(new Auth(username, password), ct);

		/// <summary>
		/// Attempt to login a user provided their username and password
		/// </summary>
		/// <param name="auth">The credentials to use for logging in the user</param>
		/// <param name="ct"></param>
		/// <returns>The user if successful, otherwise Nothing</returns>
		public User Login(Auth auth, System.Threading.CancellationToken ct) => Login(JSON.ConvertToJSON(auth), ct);

		private User Login(string auth, System.Threading.CancellationToken ct)
		{
			try
			{
				System.Threading.Tasks.Task<User> task = ExecuteWithResult<User>(System.Net.Http.HttpMethod.Post, $"{path}/login", (auth, System.Text.Encoding.UTF8, "application/json"), ct);

				task.Wait();

				return !task.IsCanceled ? task.Result : throw new OperationCanceledException();

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
