using System;

using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Holds the information for login credentials
	/// </summary>
	[Newtonsoft.Json.JsonObject]
	public class Auth
	{
		/// <summary>
		/// The username for the login
		/// </summary>
		[Newtonsoft.Json.JsonProperty("username")]
		public string Username { get; set; }

		/// <summary>
		/// The password for the login
		/// </summary>
		// <Text.Json.Serialization.JsonIgnore>
		[Newtonsoft.Json.JsonProperty("password")]
		public string Password { get; set; }

		/// <summary>
		/// The salt used for hashing the password
		/// </summary>
		[Newtonsoft.Json.JsonProperty("salt")]
		public Guid Salt { get; set; }

		/// <summary>
		/// The role the user has in the application
		/// </summary>
		[Newtonsoft.Json.JsonProperty("role")]
		public AccountRole Role { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="salt"></param>
		/// <param name="role"></param>
		[Newtonsoft.Json.JsonConstructor]
		public Auth(string username = "", string password = "", Guid salt = default, AccountRole role = AccountRole.User)
		{
			Username = username;
			Password = password.ToBase64String();
			Salt = salt;
			Role = role;
		}
	}
}
