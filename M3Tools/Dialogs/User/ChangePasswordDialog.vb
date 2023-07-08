Imports System.Windows.Forms

Public Class ChangePasswordDialog

	Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
		'Reset the user's password
		Using login As New LoginDialog()
			If login.ShowDialog() = DialogResult.OK Then
				db_Users.ChangePassword(login.Username, login.Password, pf_Password.Password)
			End If
		End Using

		'TODO: How to ensure you don't reset someone else's password
		'TODO: Create a token system; Create a 2FA type deal
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub
End Class
