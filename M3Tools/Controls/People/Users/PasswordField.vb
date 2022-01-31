Imports System.ComponentModel
Imports System.Windows.Forms

Public Class PasswordField
	Public Event PasswordGotFocus As EventHandler
	Public Event PasswordLostFocus As EventHandler
	Public Event PasswordTextChanged As EventHandler

	''' <summary>
	''' Gets or sets the password field
	''' </summary>
	''' <returns></returns>
	Public Shadows Property Password As String
		Get
			Return txt_Password.Text
		End Get
		Set(value As String)
			txt_Password.Text = value
		End Set
	End Property

	''' <summary>
	''' Gets the length of text in text control.
	''' </summary>
	''' <returns>The number of characters contained in the text of the control.</returns>
	Public ReadOnly Property TextLength As Integer
		Get
			Return txt_Password.TextLength
		End Get
	End Property

	''' <summary>
	''' Gets whether the field has input focus
	''' </summary>
	''' <returns></returns>
	Public Overrides ReadOnly Property Focused As Boolean
		Get
			Return txt_Password.Focused
		End Get
	End Property

	''' <summary>
	''' Gets the field for the password control
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property PasswordField As TextBox
		Get
			Return txt_Password
		End Get
	End Property

	Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
		'Invert the use system password char property
		txt_Password.UseSystemPasswordChar = Not txt_Password.UseSystemPasswordChar
		'Switch between password icon image for the button
		btn_Show.Image = If(txt_Password.UseSystemPasswordChar, My.Resources.ShowPasswordIcon, My.Resources.HidePasswordIcon)
	End Sub

	''' <summary>
	''' Clears all text from the text box control.
	''' </summary>
	Public Sub Clear()
		txt_Password.Clear()
	End Sub

	''' <summary>
	''' Selects a range of text in the text box.
	''' </summary>
	''' <param name="start"></param>
	''' <param name="length"></param>
	''' <exception cref="ArgumentOutOfRangeException"></exception>
	Public Shadows Sub [Select](start As Integer, length As Integer)
		txt_Password.Select(start, length)
	End Sub

	''' <summary>
	''' Selects all text in the text box.
	''' </summary>
	Public Shadows Sub SelectAll()
		'txt_Password.SelectAll()
		[Select](0, TextLength)
	End Sub

	Public Overloads Function Focus() As Boolean
		Return txt_Password.Focus()
	End Function

	Private Sub LostPasswordFocus(sender As Object, e As EventArgs) Handles txt_Password.LostFocus
		RaiseEvent PasswordLostFocus(Me, e)
	End Sub

	Private Sub PasswordChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
		RaiseEvent PasswordTextChanged(Me, e)
	End Sub

	Private Sub PasswordFocused(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
		RaiseEvent PasswordGotFocus(Me, New EventArgs)
	End Sub
End Class
