Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.M3API
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class UserDatabase
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
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
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

		Public Function CreateUser(username As String, password As String, Optional role As AccountRole = AccountRole.User) As Boolean
			Return CreateUser({
				New SqlParameter("Username", username) With {.Direction = ParameterDirection.Input},
				New SqlParameter("Password", password) With {.Direction = ParameterDirection.Input},
				New SqlParameter("AccountRole", role) With {.Direction = ParameterDirection.Input}
			})
		End Function

		Public Function CreateUser(params As SqlParameter()) As Boolean
			Throw New NotImplementedException("CreateUser")
		End Function

		Public Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean
			Return ChangePassword(New SqlParameter("Username", username), New SqlParameter("OldPassword", oldPassword), New SqlParameter("NewPassword", newPassword))
		End Function

		Public Function ChangePassword(ParamArray params As SqlParameter()) As Boolean
			Throw New NotImplementedException("ChangePassword")
		End Function

		Public Sub CloseAccount(username As String)
			CloseAccount(New SqlParameter("Username", username))
		End Sub

		Private Sub CloseAccount(param As SqlParameter)
			Throw New NotImplementedException("CloseAccount")
		End Sub

		Public Function Login(username As String, password As String) As User
			Return Me.Login(New Auth(username, password))
		End Function

		''' <summary>
		''' Attempt to login a user provided their username and password
		''' </summary>
		''' <param name="auth">The credentials to use for logging in the user</param>
		''' <returns>The user if successful, otherwise Nothing</returns>
		Public Function Login(auth As Auth) As User
			Return dbConnection.Consume(Of User)(Method.Post, "/users/login", JSON.ConvertToJSON(auth)).Result
		End Function

		Public Function GetUser(userID As Integer) As User
			Return dbConnection.Consume(Of User)(M3API.Method.Get, $"/users/{userID}").Result
		End Function

		Function GetUsers() As UserCollection
			Return dbConnection.Consume(Of UserCollection)(M3API.Method.Get, $"/users").Result
		End Function

		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "UserID"
			Shared ReadOnly Property FirstName As String = "FirstName"
			Shared ReadOnly Property LastName As String = "LastName"
			Shared ReadOnly Property Email As String = "Email"
			Shared ReadOnly Property Username As String = "Username"
			Shared ReadOnly Property Password As String = "Password"
			Shared ReadOnly Property Role As String = "AccountRole"
			Shared ReadOnly Property Salt As String = "Salt"
			Shared ReadOnly Property LastLogin As String = "LastLogin"
			Shared ReadOnly Property Joined As String = "Joined"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace