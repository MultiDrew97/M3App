Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class ListenerDatabase

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
			AddListener(listener.Name, listener.EmailAddress.Address)
		End Sub

		Public Sub AddListener(name As String, email As String)
			AddListener({New SqlParameter("Name", name), New SqlParameter("Email", email)})
		End Sub

		Private Sub AddListener(params As SqlParameter())
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(params)

				_cmd.CommandType = CommandType.StoredProcedure
				_cmd.CommandText = "AddListener"

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub RemoveListener(listenerID As Integer)
			RemoveListener(New SqlParameter("ListenerID", listenerID))
		End Sub

		Public Sub RemoveListener(param As SqlParameter)
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.Add(param)

				_cmd.CommandType = CommandType.StoredProcedure
				_cmd.CommandText = "RemoveListener"

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub UpdateListener(listenerID As Integer, column As String, value As String)
			UpdateListener(New SqlParameter("ListenerID", listenerID), column, value)
		End Sub

		Private Sub UpdateListener(param As SqlParameter, column As String, value As String)
			Using _cmd = db_Connection.Connect()
				Dim command As String = String.Format("{0} = '{1}'", column, value)
				_cmd.Parameters.Add(param)

				_cmd.CommandText = String.Format("UPDATE EmailListeners SET {0} WHERE ListenerID = @ListenerID", command)

				_cmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Function GetListeners() As ListenerCollection
			Dim listeners As New ListenerCollection

			Using _cmd = db_Connection.Connect()
				_cmd.CommandText = "SELECT * FROM EmailListeners"

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						listeners.Add(New Listener() With {
							.Id = reader.GetInt32(0),
							.Name = reader.GetString(1),
							.EmailAddress = New MimeKit.MailboxAddress(.Name, reader.GetString(2))
						})
					Loop
				End Using
			End Using

			Return listeners
		End Function

		Public Function GetListener(emailAddress As String) As Listener
			Return GetListener(New SqlParameter("EmailAddress", emailAddress), "Email")
		End Function

		Public Function GetListener(listenerID As Integer) As Listener
			Return GetListener(New SqlParameter("ListenerID", listenerID), "ID")
		End Function

		Public Function GetListener(param As SqlParameter, column As String) As Listener
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.Add(param)
				Dim cmdText As String = ""

				Select Case column
					Case "Email"
						cmdText = "WHERE EmailAddress = @EmailAddress"
					Case "ID"
						cmdText = "WHERE ListenerID = @ListenerID"
				End Select

				_cmd.CommandText = String.Format("SELECT * FROM EmailListeners {0}", cmdText)

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						Return New Listener() With {
							.Id = reader.GetInt32(0),
							.Name = reader.GetString(1),
							.EmailAddress = New MimeKit.MailboxAddress(.Name, reader.GetString(2))
						}
					Loop
				End Using
			End Using

			Return Nothing
		End Function
	End Class
End Namespace