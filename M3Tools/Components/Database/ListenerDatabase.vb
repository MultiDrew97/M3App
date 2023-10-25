Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Events
Imports SPPBC.M3Tools.Types
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
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property

		Public Sub AddListener(listener As Types.Listener)
			AddListener(listener.Name, listener.Email)
		End Sub

		Public Sub AddListener(name As String, email As String)
			AddListener(New SqlParameter("Name", name), New SqlParameter("Email", email))
		End Sub

		Private Sub AddListener(ParamArray params As SqlParameter())
			Throw New NotImplementedException("AddListener")
		End Sub

		Public Sub RemoveListener(listenerID As Integer)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			RemoveListener(New SqlParameter("ListenerID", listenerID))
		End Sub

		Private Sub RemoveListener(ParamArray param As SqlParameter())
			Throw New NotImplementedException("RemoveListener")
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
			Throw New NotImplementedException("UpdateListener")
		End Sub

		Public Function GetListeners() As Types.ListenerCollection
			Return dbConnection.Consume(Of ListenerCollection)(M3API.Method.Get, $"/listeners").Result
		End Function

		Public Function GetListener(listenerID As Integer) As Listener
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Return dbConnection.Consume(Of Listener)(M3API.Method.Get, $"/listeners/{listenerID}").Result
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