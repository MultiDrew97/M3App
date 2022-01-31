Imports System.Windows.Forms

Public Class UsernameField
    Public Event UsernameLostFocus As EventHandler
    Public Event UsernameTextChanged As EventHandler
    ''' <summary>
    ''' Gets the length of text in the username control
    ''' </summary>
    ''' <returns>The number of characters contained in the text of the control</returns>
    Public ReadOnly Property TextLength As Integer
        Get
            Return txt_Username.TextLength
        End Get
    End Property

	''' <summary>
	''' Gets or sets the username entered into the text box
	''' </summary>
	''' <returns></returns>
	Public Property Username As String
		Get
			Return txt_Username.Text
		End Get
		Set(value As String)
			txt_Username.Text = value
		End Set
	End Property

	''' <summary>
	''' Gets whether the username field has focus
	''' </summary>
	''' <returns></returns>
	Public Overrides ReadOnly Property Focused As Boolean
        Get
            Return txt_Username.Focused
        End Get
    End Property

    Public ReadOnly Property ConfirmField As TextBox
        Get
            Return txt_Username
        End Get
    End Property

    ''' <summary>
    ''' Clears all text from the username text box
    ''' </summary>
    Public Sub Clear()
        txt_Username.Clear()
    End Sub

    ''' <summary>
    ''' Selects a range of text in the username text box
    ''' </summary>
    ''' <param name="start"></param>
    ''' <param name="length"></param>
    ''' <exception cref="ArgumentOutOfRangeException"></exception>
    Public Shadows Sub [Select](start As Integer, length As Integer)
        txt_Username.Select(start, length)
    End Sub

    ''' <summary>
    ''' Selects all text in the username text box
    ''' </summary>
    Public Sub SelectAll()
        txt_Username.SelectAll()
    End Sub

    Private Sub Txt_UsernameLostFocus(sender As Object, e As EventArgs) Handles txt_Username.LostFocus
        RaiseEvent UsernameLostFocus(Me, e)
    End Sub

    ''' <summary>
    ''' Sets input focus to the username text box
    ''' </summary>
    ''' <returns>true if the input focus request was successful; otherwise false</returns>
    Shadows Function Focus() As Boolean
        Return txt_Username.Focus()
    End Function

    Private Sub Txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged
        RaiseEvent UsernameTextChanged(Me, e)
    End Sub
End Class
