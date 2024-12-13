Public Class PasswordField
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtPassword.UseSystemPasswordChar Then
            btnShow.Image = My.Resources.HidePasswordIcon
        Else
            btnShow.Image = My.Resources.ShowPasswordIcon
        End If

        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub
End Class
