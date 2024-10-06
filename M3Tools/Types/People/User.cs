using System;
using System.ComponentModel;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	[TypeConverter(typeof(Converters.M3AppConvert<User>))]
	[Newtonsoft.Json.JsonObject]
	public class User : Person
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Newtonsoft.Json.JsonProperty("userID")]
		public override int Id => base.Id;

		/// <summary>
		/// The login information for the user
		/// </summary>
		[Newtonsoft.Json.JsonProperty("login")]
		public Auth Login { get; set; }

		/// <summary>
		/// Whether the user is an admin
		/// </summary>
		[Newtonsoft.Json.JsonIgnore]
		public bool IsAdmin => Login.Role == AccountRole.Admin;

		/// <summary>
		/// The string representation of the user
		/// </summary>
		[Newtonsoft.Json.JsonIgnore]
		public new string ToString => string.Join(";", Id, Name, Login.Username, Email, Login.Salt, (int)Login.Role);

		/// <summary>
		/// Creates an empty user object
		/// </summary>
		public static new User None { get; } = new User();

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public User() : this(-1)
		{
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="userID">The ID of the user</param>
		/// <param name="fName">The user's first name</param>
		/// <param name="lName">The user's last name</param>
		/// <param name="email">The user's email address</param>
		/// <param name="username">The user's username</param>
		/// <param name="password">The user's password</param>
		/// <param name="salt">The user's salt value</param>
		/// <param name="accountRole">The user's account role</param>
		[Newtonsoft.Json.JsonConstructor]
		public User(int userID, string fName = "John", string lName = "Doe", string email = null, string username = "JohnDoe123", string password = null, Guid salt = default, AccountRole accountRole = AccountRole.User) : this(userID, $"{fName} {lName}", email, new Auth(username, password, salt, accountRole))
		{
		}

		private User(int id, string name, string email, Auth login) : base(id, name, email) => Login = login;
	}
}
