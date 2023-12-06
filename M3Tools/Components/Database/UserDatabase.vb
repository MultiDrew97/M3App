Imports System.ComponentModel
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class UserDatabase
		Private Const path As String = "users"

		<Description("The username to use for the database connection")>
		<SettingsBindable(True)>
		Public Property Username As String
			Get
				Return dbConnection.Username
			End Get
			Set(value As String)
				dbConnection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return dbConnection.Password
			End Get
			Set(value As String)
				dbConnection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property

		Public Sub CreateUser(fName As String, lName As String, email As String, username As String, password As String, Optional role As AccountRole = AccountRole.User)
			CreateUser(New User With {
				.FirstName = fName,
				.LastName = lName,
				.Email = email,
				.Login = New Auth(username, password) With {
					.Role = role
				}
			})
		End Sub

		Public Sub CreateUser(user As User)
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(user))
		End Sub

		Public Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean
			Throw New NotImplementedException("ChangePassword")
		End Function

		Public Sub CloseAccount(userID As Integer)
			dbConnection.Consume(Method.Delete, $"/{path}/{userID}")
		End Sub

		Public Function Login(username As String, password As String) As User
			'Return Login($"{{username: '{username}', password: '{password.ToBase64String()}'}}")
			Return Login(New Auth(username, password))
		End Function

		Public Function Login(auth As String) As User
			Return dbConnection.Consume(Of User)(Method.Post, $"/{path}/login", auth).Result
		End Function

		''' <summary>
		''' Attempt to login a user provided their username and password
		''' </summary>
		''' <param name="auth">The credentials to use for logging in the user</param>
		''' <returns>The user if successful, otherwise Nothing</returns>
		Public Function Login(auth As Auth) As User
			Return dbConnection.Consume(Of User)(Method.Post, $"/{path}/login", JSON.ConvertToJSON(auth)).Result
		End Function

		Public Function GetUser(userID As Integer) As User
			Return dbConnection.Consume(Of User)(Method.Get, $"/{path}/{userID}").Result
		End Function

		Function GetUsers() As DBEntryCollection(Of User)
			Return dbConnection.Consume(Of DBEntryCollection(Of User))(Method.Get, $"/{path}").Result
		End Function

		'Private Structure ColumnNames
		'	Shared ReadOnly Property ID As String = "UserID"
		'	Shared ReadOnly Property FirstName As String = "FirstName"
		'	Shared ReadOnly Property LastName As String = "LastName"
		'	Shared ReadOnly Property Email As String = "Email"
		'	Shared ReadOnly Property Username As String = "Username"
		'	Shared ReadOnly Property Password As String = "Password"
		'	Shared ReadOnly Property Role As String = "AccountRole"
		'	Shared ReadOnly Property Salt As String = "Salt"
		'	Shared ReadOnly Property LastLogin As String = "LastLogin"
		'	Shared ReadOnly Property Joined As String = "Joined"

		'	Shared ReadOnly Property Message As String = "Message"
		'End Structure
	End Class
End Namespace
