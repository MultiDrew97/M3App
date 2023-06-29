Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Dialogs
	Public Class AddListenerDialog

		Public Event ListenerAdded As Events.Listeners.ListenerAddedEventHandler

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

		Private Sub AddListener(sender As Object, e As EventArgs) Handles btn_Create.Click
			If Not ValidInputs() Then
				Return
			End If

			db_Listeners.AddListener(Me.ListenerName, Me.ListenerEmail)
			RaiseEvent ListenerAdded(Me, New Events.Listeners.ListenerAddedEventArgs(Me.ListenerName, Me.ListenerEmail))
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Function ValidInputs() As Boolean
			If String.IsNullOrWhiteSpace(Me.ListenerName) Then
				Return False
			End If

			If String.IsNullOrWhiteSpace(Me.ListenerEmail) OrElse Not Regex.IsMatch(Me.ListenerEmail, My.Resources.EmailRegex2) Then
				Return False
			End If

			Return True
		End Function
	End Class
End Namespace