﻿Imports System.ComponentModel

Namespace Database
	' TODO: Revamp this area as well
	Public NotInheritable Class ListenerDatabase
		Private Const path As String = "listeners"

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

		Public Sub AddListener(firstName As String, lastName As String, email As String)
			AddListener(New Types.Listener(-1, firstName, lastName, email))
		End Sub

		Public Sub AddListener(name As String, email As String)
			AddListener(New Types.Listener(-1, name, email))
		End Sub

		Public Sub AddListener(listener As Types.Listener)
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(listener))
		End Sub

		Public Sub RemoveListener(listenerID As Integer)
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			dbConnection.Consume(Method.Delete, $"/{path}/{listenerID}")
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
			Throw New NotImplementedException("UpdateListener")
		End Sub

		Public Function GetListeners() As Types.DBEntryCollection(Of Types.Listener)
			Return dbConnection.Consume(Of Types.DBEntryCollection(Of Types.Listener))(Method.Get, $"/{path}").Result
		End Function

		Public Function GetListener(listenerID As Integer) As Types.Listener
			If Not Utils.ValidID(listenerID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			Return dbConnection.Consume(Of Types.Listener)(Method.Get, $"/{path}/{listenerID}").Result
		End Function
	End Class
End Namespace
