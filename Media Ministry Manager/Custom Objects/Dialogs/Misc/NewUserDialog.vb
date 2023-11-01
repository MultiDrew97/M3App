Option Strict On

Imports System.Data.SqlClient

Public Class NewUserDialog

	Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
		Try
			If Not PasswordCheck() Then
				Throw New PasswordMismatchException(String.Format("Password: {0}\nConfirm{1}", txt_Password.Text, txt_ConfirmPassword.Text))
			End If

			'If AdminInfoDialog.ShowDialog = DialogResult.OK Then

			'	_connection.UserID = AdminInfoDialog.Username
			'	_connection.Password = AdminInfoDialog.Password

			'	Using db As New Database(_connection)
			'		'TODO: Reimplement later after learning how to assign roles
			'		'db.CreateUser(txt_Username.Text, txt_Password.Text)
			'	End Using

			'	AdminInfoDialog.Clear()

			'	DialogResult = DialogResult.OK
			'	Me.Close()
			'End If
		Catch exception As SqlException
			Console.WriteLine("Could not create user: " & exception.Message)
		Catch passException As PasswordMisMatchException
			tss_UserFeedback.Text = "Passwords did not match try again"
			tss_UserFeedback.ForeColor = Color.Red
			Console.WriteLine("Passwords didn't match: " & passException.Message)
		End Try
	End Sub

	Private Function PasswordCheck() As Boolean
		Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
	End Function

End Class
