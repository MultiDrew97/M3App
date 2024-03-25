using System;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
    public class Auth
    {
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; }

        // <Text.Json.Serialization.JsonIgnore>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string Password { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("salt")]
        public Guid Salt { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public AccountRole Role { get; set; }

        public Auth() : this("JohnDoe123", "WelcomeJohnDoe123!")
        {
        }

        public Auth(string username = "JohnDoe123", string password = null, Guid salt = default, AccountRole role = AccountRole.User)
        {
            Username = username;
            Password = password is not null ? password.ToBase64String() : null;
            Salt = !(salt == null) ? salt : Guid.Empty;
            Role = role;
            // Me.New(username, Text.Encoding.UTF8.GetBytes(If(password, $"Welcome{username}!")), If(salt = Nothing, Guid.Empty, salt), role)
        }

        // Public Sub New(username As String, password As Byte(), Optional salt As Guid = Nothing, Optional role As AccountRole = AccountRole.User)
        // Me.Username = username
        // Me.Password = password
        // Me.Salt = salt
        // Me.Role = role
        // End Sub
    }
}