Imports System.Windows.Forms

Namespace Dialogs
	Public Class EditListenerDialog
		Private Event ListenerChanged()
		Private _listener As Types.Listener
		'Private _newInfo As Types.Listener

		Public Property Listener As Types.Listener
			Get
				Return _listener
			End Get
			Set(value As Types.Listener)
				_listener = value
				RaiseEvent ListenerChanged()
			End Set
		End Property

		Public Property ListenerName As String
			Get
				Return gi_Name.Text
			End Get
			Set(value As String)
				gi_Name.Text = value
			End Set
		End Property

		Public Property ListenerEmail As String
			Get
				Return gi_Email.Text
			End Get
			Set(value As String)
				gi_Email.Text = value
			End Set
		End Property

		Sub New(listener As Types.Listener)
			' This call is required by the designer.
			InitializeComponent()

			' Add any initialization after the InitializeComponent() call.
			Me.Listener = listener
		End Sub

		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles btn_Save.Click
			If Not ChangeDetected() Then
				Return
			End If

			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ListenerUpdated() Handles Me.ListenerChanged
			'_newInfo = Listener.Clone()
			ListenerName = Listener.Name
			ListenerEmail = Listener.Email
		End Sub

		Private Function ChangeDetected() As Boolean
			If ListenerName <> Listener.Name Then
				Return True
			End If

			If ListenerEmail <> Listener.Email Then
				Return True
			End If

			Return False
		End Function
	End Class
End Namespace