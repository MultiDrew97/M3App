using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
    public sealed partial class UserDatabase
    {
        private const string path = "users";

        [Description("The username to use for the database connection")]
        [SettingsBindable(true)]
        public string Username
        {
            get
            {
                return dbConnection.Username;
            }
            set
            {
                dbConnection.Username = value;
            }
        }

        [PasswordPropertyText(true)]
        [SettingsBindable(true)]
        [Description("The password to use for the database connection")]
        public string Password
        {
            get
            {
                return dbConnection.Password;
            }
            set
            {
                dbConnection.Password = value;
            }
        }

        [Bindable(true)]
        [Description("The initial catalog to use for the database connection")]
        [SettingsBindable(true)]
        public string BaseUrl
        {
            get
            {
                return dbConnection.BaseUrl;
            }
            set
            {
                dbConnection.BaseUrl = value;
            }
        }

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

        public void CreateUser(User user)
        {
            dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(user));
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException("ChangePassword");
        }

        public void CloseAccount(int userID)
        {
            dbConnection.Consume(Method.Delete, $"/{path}/{userID}");
        }

        public User Login(string username, string password)
        {
            return Login(new Auth(username, password));
        }

        /// <summary>
		/// 		''' Attempt to login a user provided their username and password
		/// 		''' </summary>
		/// 		''' <param name="auth">The credentials to use for logging in the user</param>
		/// 		''' <returns>The user if successful, otherwise Nothing</returns>
        public User Login(Auth auth)
        {
            return Login(JSON.ConvertToJSON(auth));
        }

        private User Login(string auth)
        {
            return dbConnection.Consume<User>(Method.Post, $"/{path}/login", auth).Result;
        }

        public User GetUser(int userID)
        {
            return dbConnection.Consume<User>(Method.Get, $"/{path}/{userID}").Result;
        }

        public DBEntryCollection<User> GetUsers()
        {
            return dbConnection.Consume<DBEntryCollection<User>>(Method.Get, $"/{path}").Result;
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