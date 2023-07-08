Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class UserDatabase
		Private Const TableName As String = "Users"

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
		Public Property InitialCatalog As String
			Get
				Return dbConnection.InitialCatalog
			End Get
			Set(value As String)
				dbConnection.InitialCatalog = value
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
			Using cmd = dbConnection.Connect()
				cmd.Parameters.AddRange(params)
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddM3Login]"
				cmd.CommandType = CommandType.StoredProcedure

				Using reader = cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						If reader.GetBoolean(reader.GetOrdinal("Success")) Then
							Return True
						Else
							Throw New Exceptions.UserException(CStr(reader("Message")))
						End If
					Loop

					Throw New Exceptions.UserException("Unable to create")
				End Using

				' Return CBool(cmd.Parameters("Success").Value)
			End Using
		End Function

		Public Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean
			Return ChangePassword(New SqlParameter("Username", username), New SqlParameter("OldPassword", oldPassword), New SqlParameter("NewPassword", newPassword))
		End Function

		Public Function ChangePassword(ParamArray params As SqlParameter()) As Boolean
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_ChangePassword]"
				cmd.CommandType = CommandType.StoredProcedure

				cmd.ExecuteNonQueryAsync()
				' TODO: Test this
				Return CBool(cmd.Parameters("Success").Value)
			End Using
		End Function

		Public Sub CloseAccount(username As String)
			CloseAccount(New SqlParameter("Username", username))
		End Sub

		Private Sub CloseAccount(param As SqlParameter)
			Using cmd = dbConnection.Connect
				cmd.Parameters.Add(param)
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_DeactivateAccount]"
				cmd.CommandType = CommandType.StoredProcedure

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Function Login(username As String, password As String) As User
			If username = String.Empty OrElse password = String.Empty Then
				Throw New ArgumentException("No credentials present")
			End If

			Return Login(New SqlParameter("Username", username), New SqlParameter("Password", password))
		End Function

		Private Function Login(ParamArray params As SqlParameter()) As User
			Using cmd = dbConnection.Connect()
				' TODO: Convert to a stored procedure to clean this up
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[tf_Login](@Username, @Password)"
				cmd.Parameters.AddRange(params)

				Using reader = cmd.ExecuteReader
					If reader.Read() Then
						If Not Utils.ValidID(CInt(reader(ColumnNames.ID))) Then
							If CStr(reader(ColumnNames.Message)).ToLower().Contains("username") Then
								Throw New Exceptions.UsernameException(CStr(reader(ColumnNames.Message)))
							ElseIf CStr(reader(ColumnNames.Message)).ToLower().Contains("password") Then
								Throw New Exceptions.PasswordException(CStr(reader(ColumnNames.Message)))
								Throw New Exceptions.LoginException("Unable to Login at this time.")
							End If
						End If
					End If

					Try
						Dim user = GetUser(CInt(reader(ColumnNames.ID)))
						cmd.CommandText = $"[{My.Settings.Schema}].[sp_UpdateLastLogin]"
						cmd.CommandType = CommandType.StoredProcedure
						cmd.ExecuteNonQueryAsync()
						Return user
					Catch ex As Exception
						Throw New Exceptions.DatabaseException($"Unable to find user with ID {CInt(reader("UserID"))}", ex)
					End Try
				End Using
			End Using
		End Function

		Public Function GetUser(userID As Integer) As User
			Using _con = dbConnection.Connect()
				_con.Parameters.AddWithValue("UserID", userID)
				_con.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{TableName}] WHERE UserID=@UserID"

				Using reader = _con.ExecuteReader()
					Do While reader.Read()
						Dim buffer(64) As Byte
						reader.GetBytes(reader.GetOrdinal(ColumnNames.Password), 0, buffer, 0, 64)

						Return New User(CInt(reader(ColumnNames.ID)), CStr(reader(ColumnNames.FirstName)), CStr(ColumnNames.LastName),
								CStr(reader(ColumnNames.Username)), TryCast(reader(ColumnNames.Email), String), buffer,
								reader.GetGuid(reader.GetOrdinal(ColumnNames.Salt)), CType(reader(ColumnNames.Role), AccountRole)
							)
					Loop

					Throw New Exceptions.UserException("Invalid UserID")
				End Using
			End Using
		End Function

		Function GetUser(username As String) As User
			If String.IsNullOrWhiteSpace(username) Then
				Throw New Exceptions.UsernameException("Empty Username")
			End If

			Using cmd = dbConnection.Connect()
				cmd.Parameters.AddWithValue("Username", username)
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{TableName}] WHERE Username=@Username"
				Using reader = cmd.ExecuteReader
					Do While reader.Read()
						Dim buffer(64) As Byte
						reader.GetBytes(reader.GetOrdinal(ColumnNames.Password), 0, buffer, 0, 64)

						Return New User(CInt(reader(ColumnNames.ID)), CStr(reader(ColumnNames.FirstName)), CStr(ColumnNames.LastName),
								CStr(reader(ColumnNames.Username)), TryCast(reader(ColumnNames.Email), String), buffer,
								reader.GetGuid(reader.GetOrdinal(ColumnNames.Salt)), CType(reader(ColumnNames.Role), AccountRole)
							)
					Loop

					Throw New Exceptions.UserException("Invalid username")
				End Using
			End Using
		End Function

		Function GetUsers() As UserCollection
			Dim users As New UserCollection()

			Using _con = dbConnection.Connect()
				_con.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{TableName}]"

				Using reader = _con.ExecuteReader()

					Do While reader.Read()
						Dim buffer(64) As Byte
						reader.GetBytes(reader.GetOrdinal(ColumnNames.Password), 0, buffer, 0, 64)

						users.Append(New User(CInt(reader(ColumnNames.ID)), CStr(reader(ColumnNames.FirstName)), CStr(ColumnNames.LastName),
								CStr(reader(ColumnNames.Username)), TryCast(reader(ColumnNames.Email), String), buffer,
								CStr(reader(ColumnNames.Salt)), CType(reader(ColumnNames.Role), AccountRole)
							)
						)
					Loop
				End Using
			End Using

			Return users
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