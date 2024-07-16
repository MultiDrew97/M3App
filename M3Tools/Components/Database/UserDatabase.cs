using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
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
        public void CreateUser(string fName, string lName, string email, string username, string password, AccountRole role = AccountRole.User)
        {
            CreateUser(new User()
            {
                FirstName = fName,
                LastName = lName,
                Email = email,
                Login = new Auth(username, password) { Role = role }
            });
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="user"></param>
        public void CreateUser(User user)
        {
            Execute(Method.Post, $"/{path}", JSON.ConvertToJSON(user));
        }

		/// <summary>
		/// Change the password of the specified user
		/// </summary>
		/// <param name="username"></param>
		/// <param name="oldPassword"></param>
		/// <param name="newPassword"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException("ChangePassword");
        }

		/// <summary>
		/// Completly delete the specified user's account
		/// </summary>
		/// <param name="userID"></param>
        public void CloseAccount(int userID)
        {
            Execute(Method.Delete, $"/{path}/{userID}");
        }

		/// <summary>
		/// Login a user using the provided login info
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
        public User Login(string username, string password)
        {
            return Login(new Auth(username, password));
        }

        /// <summary>
		/// Attempt to login a user provided their username and password
		/// </summary>
		/// <param name="auth">The credentials to use for logging in the user</param>
		/// <returns>The user if successful, otherwise Nothing</returns>
        public User Login(Auth auth)
        {
            return Login(JSON.ConvertToJSON(auth));
        }

        private User Login(string auth)
        {
            return ExecuteWithResult<User>(Method.Post, $"{path}/login", auth).Result;
        }

		/// <summary>
		/// Retrieve a user based on the provided user ID
		/// </summary>
		/// <param name="userID"></param>
		/// <returns></returns>
        public User GetUser(int userID)
        {
            return ExecuteWithResult<User>(Method.Get, $"/{path}/{userID}").Result;
        }

		/// <summary>
		/// Retrieve the complete list of users in the database
		/// </summary>
		/// <returns></returns>
        private DbEntryCollection<User> GetUsers()
        {
            return ExecuteWithResult<DbEntryCollection<User>>(Method.Get, $"/{path}").Result;
        }

        // Private Structure ColumnNames
        // Shared ReadOnly Property ID As String = "UserID"
        // Shared ReadOnly Property FirstName As String = "FirstName"
        // Shared ReadOnly Property LastName As String = "LastName"
        // Shared ReadOnly Property Email As String = "Email"
        // Shared ReadOnly Property Username As String = "Username"
        // Shared ReadOnly Property Password As String = "Password"
        // Shared ReadOnly Property Role As String = "AccountRole"
        // Shared ReadOnly Property Salt As String = "Salt"
        // Shared ReadOnly Property LastLogin As String = "LastLogin"
        // Shared ReadOnly Property Joined As String = "Joined"

        // Shared ReadOnly Property Message As String = "Message"
        // End Structure
    }
}
