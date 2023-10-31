Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports SPPBC.M3Tools.Exceptions

Namespace Dialogs
    Public Class CreateAccountDialog

        ReadOnly __passwordPattern As New Regex(My.Resources.PasswordRegex)
        ReadOnly __usernameEmptyError As String = "A username is required"
        ReadOnly __passwordPatternError As String = "Password must contain:\n At least 1 capital letter\n At least 1 lowercase letter\n At least 1 number\n at least 1 special character"
        ReadOnly __passwordMisMatchError As String = "Passwords must match to proceed"

        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create.Click
            CheckValues()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub CheckValues()
            Try
                If ValidUsername() And ValidPassword() And PasswordMatch() Then
                    TryCreateAccount()
                End If
            Catch ex As PasswordMisMatchException
                cpf_Confirm.Clear()
                cpf_Confirm.Focus()
            Catch ex As PasswordException
                pf_Password.Clear()
                pf_Password.Focus()
            Catch ex As CreationException
                uf_Username.Focus()
            End Try
        End Sub

        Private Function ValidUsername() As Boolean
            Return Not String.IsNullOrWhiteSpace(uf_Username.Username)
        End Function

        Private Function ValidPassword() As Boolean
            If Not __passwordPattern.IsMatch(pf_Password.Password) Then
                'Throw New PasswordException("Invalid Password")
                Return False
            End If

            Return True
        End Function

        Private Function PasswordMatch() As Boolean
            If Not pf_Password.Password.Equals(cpf_Confirm.Text) Then
                'Throw New PasswordMisMatchException("Password Mismatch")
                Return False
            End If

            Return True
        End Function

        Private Sub TryCreateAccount()
            Try
				'db_Users.CreateUser(uf_Username.Username, pf_Password.Password)
			Catch ex As CreationException
                Throw New CreationException("Creation Failed", ex)
            End Try
        End Sub

        Private Sub Uf_Username_UsernameLostFocus(sender As Object, e As EventArgs) Handles uf_Username.UsernameLostFocus
            If Not ValidUsername() Then
                ep_FieldError.SetError(uf_Username, __usernameEmptyError)
            Else
                ep_FieldError.SetError(uf_Username, "")
            End If
        End Sub

		Private Sub Pf_Password_PasswordLostFocus(sender As Object, e As EventArgs) Handles pf_Password.PasswordLostFocus
			If Not ValidPassword() Then
				ep_FieldError.SetError(pf_Password, __passwordPatternError)
			Else
				ep_FieldError.SetError(pf_Password, "")
			End If
		End Sub

		Private Sub Cpf_Confirm_ConfirmLostFocus(sender As Object, e As EventArgs) Handles cpf_Confirm.ConfirmLostFocus
            If Not PasswordMatch() Then
                ep_FieldError.SetError(cpf_Confirm, __passwordMisMatchError)
            Else
                ep_FieldError.SetError(cpf_Confirm, "")
            End If
        End Sub

        Private Sub Uf_Username_TextChanged(sender As Object, e As EventArgs) Handles uf_Username.UsernameTextChanged
            If Not ValidUsername() Then
                ep_FieldError.SetError(uf_Username, __usernameEmptyError)
            Else
                ep_FieldError.SetError(uf_Username, "")
            End If
        End Sub

        Private Sub Pf_Password_PasswordTextChanged(sender As Object, e As EventArgs) Handles pf_Password.PasswordTextChanged
            If Not ValidPassword() Then
                ep_FieldError.SetError(pf_Password, __passwordPatternError)
            Else
                ep_FieldError.SetError(pf_Password, "")
            End If
        End Sub

        Private Sub Cpf_Confirm_ConfirmTextChanged(sender As Object, e As EventArgs) Handles cpf_Confirm.ConfirmTextChanged
            If Not PasswordMatch() Then
                ep_FieldError.SetError(cpf_Confirm, __passwordMisMatchError)
            Else
                ep_FieldError.SetError(cpf_Confirm, "")
            End If
        End Sub
    End Class
End Namespace
