Imports System.Windows.Forms

Public Class CustomEmailDialog
	Public ReadOnly Property Email As CustomEmail
		Get
			Return ce_Email
		End Get
	End Property

	Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

End Class
