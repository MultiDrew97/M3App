Option Strict On

Imports System.Data.SqlClient

Public Class ChangePasswordDialog
	Private Sub UpdatePassword(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
		Try
			If Not PasswordCheck() Then
				Throw New FormatException($"Password: {txt_Password.Text} \n Confirm: {txt_ConfirmPassword.Text}")
			End If


			'If AdminInfoDialog.ShowDialog = DialogResult.OK Then
			'    _connection.UserID = AdminInfoDialog.Username
			'    _connection.Password = AdminInfoDialog.Password

			'    Using db As New Database(_connection)
			'        db.ChangePassword(txt_Username.Text, txt_Password.Text)
			'    End Using

			'    AdminInfoDialog.Clear()

			'    DialogResult = DialogResult.OK
			'    Me.Close()
			'End If
		Catch ex As SqlException
			Console.WriteLine("Failed to update user password: " & ex.Message)
		Catch passEx As PasswordMismatchException
			tss_UserFeedback.Text = "Passwords did not match try again"
			tss_UserFeedback.ForeColor = Color.Red
			Console.WriteLine("Passwords did not match: " & passEx.Message)
		End Try
	End Sub

	Private Function PasswordCheck() As Boolean
		Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
	End Function

	Private Sub CancelPasswordChange(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub ChangePasswordLoaded(sender As Object, e As EventArgs) Handles Me.Load

	End Sub
End Class
