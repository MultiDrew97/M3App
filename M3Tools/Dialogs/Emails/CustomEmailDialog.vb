Imports System.Windows.Forms

Public Class CustomEmailDialog
	Public ReadOnly Property Email As CustomEmail
		Get
			Return ce_Email
		End Get
	End Property

	ReadOnly Property Subject As String
		Get
			Return Email.Subject
		End Get
	End Property

	ReadOnly Property Body As String
		Get
			Return Email.Body
		End Get
	End Property

	ReadOnly Property RTBody As String
		Get
			Return Email.RichTextBody
		End Get
	End Property

	Private Sub FinishedCustom(sender As Object, e As EventArgs) Handles btn_Done.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub CancelCustom(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

End Class
