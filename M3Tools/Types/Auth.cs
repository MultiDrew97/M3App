using System;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Holds the information for login credentials
	/// </summary>
    public class Auth
    {
		/// <summary>
		/// The username for the login
		/// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; }

		/// <summary>
		/// The password for the login
		/// </summary>
        // <Text.Json.Serialization.JsonIgnore>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string Password { get; set; }

		/// <summary>
		/// The salt used for hashing the password
		/// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("salt")]
        public Guid Salt { get; set; }

		/// <summary>
		/// The role the user has in the application
		/// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public AccountRole Role { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public Auth() : this("", "")
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="salt"></param>
		/// <param name="role"></param>
        public Auth(string username = default, string password = default, Guid salt = default, AccountRole role = AccountRole.User)
        {
            Username = username;
            Password = password.ToBase64String();
			Salt = salt;
            Role = role;
        }
    }
}
