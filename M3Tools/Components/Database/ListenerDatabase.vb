Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	' TODO: Revamp this area as well
	Public NotInheritable Class ListenerDatabase
		Private ReadOnly tableName As String = "Listeners"
		<EditorBrowsable()>
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
			End Get
			Set(value As String)
				db_Connection.Password = value
			End Set
		End Property

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
		Public Sub AddListener(listener As Listener)
			AddListener(listener.Name, listener.Email)
		End Sub

		Public Sub AddListener(name As String, email As String)
			AddListener(New SqlParameter("Name", name), New SqlParameter("Email", email))
		End Sub

		Private Sub AddListener(ParamArray params As SqlParameter())
			Using _cmd = db_Connection.Connect()
				_cmd.CommandType = CommandType.StoredProcedure
				_cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddListener]"
				_cmd.Parameters.AddRange(params)

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub RemoveListener(listenerID As Integer)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			RemoveListener(New SqlParameter("ListenerID", listenerID))
		End Sub

		Public Sub RemoveListener(ParamArray param As SqlParameter())
			Using _cmd = db_Connection.Connect()
				_cmd.CommandType = CommandType.StoredProcedure
				_cmd.CommandText = $"[{My.Settings.Schema}].[sp_RemoveListener]"
				_cmd.Parameters.AddRange(param)

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub UpdateListener(listenerID As Integer, column As String, value As String)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			UpdateListener(column, value, New SqlParameter("ListenerID", listenerID))
		End Sub

		Private Sub UpdateListener(column As String, value As String, ParamArray params As SqlParameter())
			Using _cmd = db_Connection.Connect()
				Dim command As String = $"{column} = '{value}'"

				_cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[{tableName}] SET {command} WHERE ListenerID = @ListenerID"
				_cmd.Parameters.AddRange(params)

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Function GetListeners() As DBEntryCollection(Of Listener)
			Dim listeners As New DBEntryCollection(Of Listener)

			Using _cmd = db_Connection.Connect()
				_cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						listeners.Add(New Listener(
							CInt(reader("ListenerID")),
							CStr(reader("Name")),
							CStr(reader("Email"))
						))
					Loop
				End Using
			End Using

			Return listeners
		End Function

		Public Function GetListener(emailAddress As String) As Listener
			Return GetListener("Email", New SqlParameter("EmailAddress", emailAddress))
		End Function

		Public Function GetListener(listenerID As Integer) As Listener
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Return GetListener("ID", New SqlParameter("ListenerID", listenerID))
		End Function

		Public Function GetListener(column As String, ParamArray params As SqlParameter()) As Listener
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(params)
				Dim cmdText As String = ""

				Select Case column
					Case "Email"
						cmdText = "WHERE {column}=@EmailAddress"
					Case "ID"
						cmdText = "WHERE {column}=@ListenerID"
				End Select

				_cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] {cmdText}"

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						Return New Listener(
							CInt(reader("ListenerID")),
							CStr(reader("Name")),
							CStr(reader("Email"))
						)
					Loop
				End Using
			End Using

			Return Nothing
		End Function
	End Class
End Namespace