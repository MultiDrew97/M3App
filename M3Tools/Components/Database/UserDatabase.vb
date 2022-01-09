Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class UserDatabase
		<Description("The username to use for the database connection")>
		<SettingsBindable(True)>
		Public Property Username As String
			Get
				Return db_Connection.Username
			End Get
			Set(value As String)
				db_Connection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return db_Connection.Password
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
				db_Connection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property InitialCatalog As String
			Get
				Return db_Connection.InitialCatalog
			End Get
			Set(value As String)
				db_Connection.InitialCatalog = value
			End Set
		End Property
		Public Function CreateUser(username As String, password As String, Optional role As AccountRole = AccountRole.User) As Boolean
			Return CreateUser({
				New SqlParameter("Username", username) With {.Direction = ParameterDirection.Input},
				New SqlParameter("Password", password) With {.Direction = ParameterDirection.Input},
				New SqlParameter("AccountRole", role) With {.Direction = ParameterDirection.Input}
			})
			'myCmd.Parameters.AddRange({New SqlParameter("Username", username), New SqlParameter("Password", password)})

			'myCmd.CommandText = "CREATE USER @Username WITH PASSWORD = @Password"

			'myCmd.ExecuteNonQuery()
		End Function

		Public Function CreateUser(params As SqlParameter()) As Boolean
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(params)
				_cmd.CommandText = "sp_AddM3Login"
				_cmd.CommandType = CommandType.StoredProcedure

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						If reader.GetBoolean(reader.GetOrdinal("Success")) Then
							Return True
						Else
							Throw New Exceptions.UserException(reader.GetString(reader.GetOrdinal("Message")))
						End If
					Loop

					Throw New Exceptions.UserException("Unable to create")
				End Using

				' Return CBool(_cmd.Parameters("Success").Value)
			End Using
		End Function

		Public Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean
			Dim parameters() As SqlParameter = {
				New SqlParameter("Username", username) With {.Direction = ParameterDirection.Input},
				New SqlParameter("OldPassword", oldPassword) With {.Direction = ParameterDirection.Input},
				New SqlParameter("NewPassword", newPassword) With {.Direction = ParameterDirection.Input}
			}

			Return ChangePassword(parameters)
		End Function

		Public Function ChangePassword(params As SqlParameter()) As Boolean
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(params)
				_cmd.CommandText = "sp_ChangePassword"
				_cmd.CommandType = CommandType.StoredProcedure

				_cmd.ExecuteNonQueryAsync()

				Return CBool(_cmd.Parameters("Success").Value)
			End Using
		End Function

		Public Sub CloseAccount(username As String)
			CloseAccount(New SqlParameter("Username", username))
		End Sub

		Private Sub CloseAccount(param As SqlParameter)
			Using _cmd = db_Connection.Connect
				_cmd.Parameters.Add(param)
				_cmd.CommandText = "sp_DeactivateAccount"
				_cmd.CommandType = CommandType.StoredProcedure

				_cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Function Login(username As String, password As String) As User
			Return Login({
				New SqlParameter("Username", username) With {.Direction = ParameterDirection.Input},
				New SqlParameter("Password", password) With {.Direction = ParameterDirection.Input}
			})
		End Function

		Private Function Login(params As SqlParameter()) As User
			Using _con = db_Connection.Connect()
				_con.CommandText = "SELECT * FROM tf_M3Login(@Username, @Password)"
				_con.Parameters.AddRange(params)

				Using reader = _con.ExecuteReaderAsync().Result
					If reader.Read() Then
						If reader.GetInt32(reader.GetOrdinal("UserID")) > -1 Then
							Dim user = GetUser(reader.GetInt32(reader.GetOrdinal("UserID")))

							If Not user.AccountRole = AccountRole.Admin Then
								' User's account is not an admin account
								Throw New Exceptions.RoleException("Unathorized Account Type")
							End If

							Return user
						Else
							If reader.GetString(reader.GetOrdinal("Message")).ToLower().Contains("username") Then
								Throw New Exceptions.UsernameException(reader.GetString(reader.GetOrdinal("Message")))
							ElseIf reader.GetString(reader.GetOrdinal("Message")).ToLower().Contains("password") Then
								Throw New Exceptions.PasswordException(reader.GetString(reader.GetOrdinal("Message")))
							Else
								Throw New Exceptions.DatabaseException("Unknown Error")
							End If
						End If
					Else
						Throw New Exceptions.LoginException("Unable to Login at this time.")
					End If
				End Using
			End Using
		End Function

		Function GetUser(userID As Integer) As User
			If userID < 0 Then
				Throw New Exceptions.InvalidIdException()
			End If

			Using _con = db_Connection.Connect()
				_con.Parameters.AddWithValue("UserID", userID)
				_con.CommandText = "SELECT * FROM m3_Users WHERE UserID = @UserID"

				Using reader = _con.ExecuteReaderAsync().Result
					Do While reader.Read()
						Dim buffer(64) As Byte
						reader.GetBytes(reader.GetOrdinal("Password"), 0, buffer, 0, 64)

						Return New User() With {
								.Id = reader.GetInt32(reader.GetOrdinal("UserID")),
								.Username = reader.GetString(reader.GetOrdinal("Username")),
								.Password = buffer,
								.Salt = reader.GetGuid(reader.GetOrdinal("Salt")),
								.AccountRole = CType(reader.GetInt32(reader.GetOrdinal("AccountRole")), AccountRole)
							}
					Loop

					Throw New Exceptions.UserException("Invalid UserID")
				End Using
			End Using
		End Function

		Function GetUser(username As String) As User
			If String.IsNullOrWhiteSpace(username) Then
				Throw New Exceptions.UsernameException("Empty Username")
			End If

			Using _con = db_Connection.Connect()
				_con.Parameters.AddWithValue("Username", username)
				_con.CommandText = "SELECT * FROM m3_Users WHERE Username = @Username"

				Using reader = _con.ExecuteReaderAsync().Result
					Dim buffer(100) As Byte

					Do While reader.Read()
						reader.GetBytes(reader.GetOrdinal("Password"), 0, buffer, 0, 64)

						Return New User() With {
							.Id = reader.GetInt32(reader.GetOrdinal("UserID")),
							.Username = reader.GetString(reader.GetOrdinal("Username")),
							.Password = buffer,
							.Salt = reader.GetGuid(reader.GetOrdinal("Salt")),
							.AccountRole = CType(reader.GetInt32(reader.GetOrdinal("AccountRole")), AccountRole)
						}
					Loop

					Throw New Exceptions.UserException("Invalid username")
				End Using
			End Using
		End Function

		Function GetUsers() As Collection(Of User)
			Using _con = db_Connection.Connect()
				_con.CommandText = "SELECT * FROM m3_Users"

				Using reader = _con.ExecuteReaderAsync().Result
					Dim users As New Collection(Of User)
					Dim buffer(64) As Byte

					Do While reader.Read()
						reader.GetBytes(reader.GetOrdinal("Password"), 0, buffer, 0, 64)
						users.Append(New User() With {
								.Id = reader.GetInt32(reader.GetOrdinal("UserID")),
								.Username = reader.GetString(reader.GetOrdinal("Username")),
								.Password = buffer,
								.Salt = reader.GetGuid(reader.GetOrdinal("Salt")),
								.AccountRole = CType(reader.GetInt32(reader.GetOrdinal("AccountRole")), AccountRole)
						})
					Loop

					Return users
				End Using
			End Using
		End Function
	End Class
End Namespace