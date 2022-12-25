Imports System.Windows.Forms

Namespace Dialogs
	Public Class EditListenerDialog
		Private Event ListenerChanged()
		Private _listener As Types.Listener
		Private _newInfo As Types.Listener

		Private Property Listener As Types.Listener
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

		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles btn_Save.Click
			If Not ChangeDetected() Then
				Return
			End If

			db_Listeners.UpdateListener(Listener.Id, _newInfo.Name, _newInfo.Email)

			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ListenerUpdated() Handles Me.ListenerChanged
			ListenerName = Listener.Name
			ListenerEmail = Listener.Email
			_newInfo = Listener.Clone()
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