Imports System.ComponentModel
Imports System.Data.SqlClient
'Imports SPPBC.M3Tools.Types

Namespace Database
	' TODO: Revamp this area as well
	Public NotInheritable Class ListenerDatabase
		Private ReadOnly tableName As String = "Listeners"
		<EditorBrowsable()>
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

		Public Sub AddListener(listener As Types.Listener)
			AddListener(listener.Name, listener.Email)
		End Sub

		Public Sub AddListener(name As String, email As String)
			AddListener(New SqlParameter("Name", name), New SqlParameter("Email", email))
		End Sub

		Private Sub AddListener(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddListener]"
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub RemoveListener(listenerID As Integer)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			RemoveListener(New SqlParameter("ListenerID", listenerID))
		End Sub

		Private Sub RemoveListener(ParamArray param As SqlParameter())
			Using cmd = dbConnection.Connect()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_RemoveListener]"
				cmd.Parameters.AddRange(param)

				cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub UpdateListener(listenerID As Integer, fName As String, lName As String, email As String)
			UpdateListener(listenerID, $"{fName} {lName}", email)
		End Sub

		Public Sub UpdateListener(listenerID As Integer, name As String, email As String)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			UpdateListener(New Types.Listener(listenerID, name, email))
		End Sub

		Public Sub UpdateListener(listener As Types.Listener)
			UpdateListener(New SqlParameter("ListenerID", listener.Id), New SqlParameter("Name", listener.Name), New SqlParameter("Email", listener.Email))
		End Sub

		Private Sub UpdateListener(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect()
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_UpdateListener]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Function GetListeners() As Types.ListenerCollection
			Dim listeners As New Types.ListenerCollection

			Using cmd = dbConnection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

				Using reader = cmd.ExecuteReader
					Do While reader.Read()
						listeners.Add(New Types.Listener(
							CInt(reader(ColumnNames.ID)),
							CStr(reader(ColumnNames.Name)),
							CStr(reader(ColumnNames.Email))
						))
					Loop
				End Using
			End Using

			Return listeners
		End Function

		Public Function GetListener(emailAddress As String) As Types.Listener
			Return GetListener(ColumnSelection.Email, New SqlParameter("EmailAddress", emailAddress))
		End Function

		Public Function GetListener(listenerID As Integer) As Types.Listener
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Return GetListener(ColumnSelection.ID, New SqlParameter("ListenerID", listenerID))
		End Function

		Private Function GetListener(column As ColumnSelection, ParamArray params As SqlParameter()) As Types.Listener
			Using cmd = dbConnection.Connect()
				Dim cmdText As String = "WHERE {0}={1}"

				Select Case column
					Case ColumnSelection.Email
						cmdText = "WHERE Email=@EmailAddress"
					Case ColumnSelection.ID
						cmdText = "WHERE ListenerID=@ListenerID"
					Case Else
						Throw New ArgumentException()
				End Select

				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] {cmdText}"
				cmd.Parameters.AddRange(params)

				Using reader = cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						Return New Types.Listener(
							CInt(reader(ColumnNames.ID)),
							CStr(reader(ColumnNames.Name)),
							CStr(reader(ColumnNames.Email))
						)
					Loop
				End Using
			End Using

			Return Nothing
		End Function

		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "ListenerID"
			Shared ReadOnly Property Name As String = "Name"
			Shared ReadOnly Property Email As String = "Email"
			Shared ReadOnly Property Joined As String = "Joined"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace