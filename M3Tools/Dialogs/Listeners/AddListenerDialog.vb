Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events

Namespace Dialogs
	Public Class AddListenerDialog

		Public Event ListenerAdded As Listeners.ListenerEventHandler

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

		ReadOnly Property Listener As Types.Listener
			Get
				Return New Types.Listener(-1, ListenerName, ListenerEmail)
			End Get
		End Property

		Private Sub AddListener(sender As Object, e As EventArgs) Handles btn_Create.Click
			If Not ValidInputs() Then
				Return
			End If

			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Dim res = MessageBox.Show("Are you sure you want to cancel listener creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If Not res = DialogResult.Yes Then
				Return
			End If

			DialogResult = DialogResult.Cancel
			Close()
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
