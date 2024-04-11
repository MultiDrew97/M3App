using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
    [TypeConverter(typeof(Converters.UserConverter))]
    public class User : Person
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("userID")]
        public override int Id { get => base.Id; }

		/// <summary>
		/// The login information for the user
		/// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("login")]
        public Auth Login { get; set; }

		/// <summary>
		/// Whether the user is an admin
		/// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsAdmin
        {
            get
            {
                return Login.Role == AccountRole.Admin;
            }
        }

		/// <summary>
		/// The string representation of the user
		/// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public new string ToString
        {
            get
            {
                return string.Join(";", Id, Name, Login.Username, Email, Login.Salt, (int)Login.Role);
            }
        }

		/// <summary>
		/// Creates an empty user object
		/// </summary>
		public new static User None { get; } = new User();

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
        public User(int userID, string fName = "John", string lName = "Doe", string email = null, string username = "JohnDoe123", string password = null, Guid salt = default, AccountRole accountRole = AccountRole.User) : this(userID, $"{fName} {lName}", email, new Auth(username, password, salt, accountRole))
        {
        }

        // Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As String, accountRole As AccountRole)
        // Me.New(id, name, username, email, password, If(String.IsNullOrWhiteSpace(salt), Guid.NewGuid(), Guid.Parse(salt)), accountRole)
        // End Sub

        // Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As Guid, accountRole As AccountRole)
        // Me.New(id, name, email, )
        // End Sub

        private User(int id, string name, string email, Auth login) : base(id, name, email)
        {
            Login = login;
        }

        // Public Overrides Sub UpdateID(newID As Integer)
        // If newID = Id Then
        // Return
        // End If

        // Using conn As New Database.ProductDatabase
        // ' TODO: Finish implementing updates
        // End Using
        // End Sub
    }
}

namespace SPPBC.M3Tools.Types.Converters
{
    internal class UserConverter : TypeConverter
    {
        // ReadOnly fields As New Dictionary(Of String, Integer) From {
        // {"ID", 0}, {"FirstName", 1}, {"LastName", 2},
        // {"Email", 3}, {"Username", 4}, {"Password", 5},
        // {"Salt", 6}, {"Role", 7}
        // }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string value)
        {
            // If Not value.GetType = GetType(String) Then
            // Return MyBase.ConvertFrom(context, culture, value)
            // 'Dim parts() As String = CStr(value).Split(";"c)
            // 'Dim guid As Guid

            // 'Dim success = Guid.TryParse(parts(4), guid)

            // '' FIXME: Determine better way to parse a user from string after refactoring User constructors
            // 'Dim user As New User(CInt(parts(fields("ID"))), parts(fields("FirstName")), parts(fields("LastName")), parts(fields("Email")),
            // '					 parts(fields("Username")), parts(fields("Password")), Guid.Parse(parts(fields("Salt"))),
            // '					 CType(CInt(parts(fields("Role"))), AccountRole))

            // 'Return user
            // End If

            return JSON.ConvertFromJSON<User>(value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!(destinationType == typeof(string)))
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }

            return JSON.ConvertToJSON(value);
        }
    }
}
