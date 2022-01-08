Imports System.Windows.Forms

Public Class ConfirmPasswordField
    Public Event ConfirmLostFocus As EventHandler
    Public Event ConfirmTextChanged As EventHandler
    Public Shadows Property Text As String
        Get
            Return txt_ConfirmPassword.Text
        End Get
        Set(value As String)
            txt_ConfirmPassword.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the length of text in text control.
    ''' </summary>
    ''' <returns>The number of characters contained in the text of the control.</returns>
    Public ReadOnly Property TextLength As Integer
        Get
            Return txt_ConfirmPassword.TextLength
        End Get
    End Property

    Public Overrides ReadOnly Property Focused As Boolean
        Get
            Return txt_ConfirmPassword.Focused
        End Get
    End Property

    Public ReadOnly Property ConfirmField As TextBox
        Get
            Return txt_ConfirmPassword
        End Get
    End Property


	Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
		'Switch between password icon image for the button
		btn_Show.Image = If(txt_ConfirmPassword.UseSystemPasswordChar, My.Resources.HidePasswordIcon, My.Resources.ShowPasswordIcon)

		'Invert the use system password char property
		txt_ConfirmPassword.UseSystemPasswordChar = Not txt_ConfirmPassword.UseSystemPasswordChar
	End Sub

	''' <summary>
	''' Clears all text from the text box control.
	''' </summary>
	Public Sub Clear()
		txt_ConfirmPassword.Clear()
	End Sub

	''' <summary>
	''' Selects a range of text in the text box.
	''' </summary>
	''' <param name="start"></param>
	''' <param name="length"></param>
	''' <exception cref="ArgumentOutOfRangeException"></exception>
	Public Shadows Sub [Select](start As Integer, length As Integer)
		txt_ConfirmPassword.Select(start, length)
	End Sub

	''' <summary>
	''' Selects all text in the text box.
	''' </summary>
	Public Shadows Sub SelectAll()
		txt_ConfirmPassword.SelectAll()
		'txtPassword.Select(0, TextLength)
	End Sub

	Public Overloads Function Focus() As Boolean
		Return txt_ConfirmPassword.Focus()
	End Function

	Private Sub Txt_ConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles txt_ConfirmPassword.LostFocus
		RaiseEvent ConfirmLostFocus(Me, e)
	End Sub

	Private Sub Txt_ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_ConfirmPassword.TextChanged
		RaiseEvent ConfirmTextChanged(Me, e)
	End Sub
End Class
