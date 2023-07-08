Public Class LoginFields
    ''' <summary>
    ''' Gets or sets the username
    ''' </summary>
    ''' <returns></returns>
    Property Username As String
        Get
			Return If(String.IsNullOrWhiteSpace(uf_Username.Username), Nothing, uf_Username.Username)
		End Get
        Set(value As String)
            uf_Username.Username = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the password
    ''' </summary>
    ''' <returns></returns>
    Property Password As String
        Get
			Return If(String.IsNullOrWhiteSpace(pf_Password.Password), Nothing, pf_Password.Password)
		End Get
        Set(value As String)
            pf_Password.Password = value
        End Set
    End Property

    ReadOnly Property UsernameField As UsernameField
        Get
            Return uf_Username
        End Get
    End Property

	ReadOnly Property PasswordField As PasswordField
		Get
			Return pf_Password
		End Get
	End Property

	''' <summary>
	''' Clears all text from the username and password fields
	''' </summary>
	Public Sub Clear()
		ClearUsername()
		ClearPassword()
	End Sub

	Public Sub ClearUsername()
		uf_Username.Clear()
	End Sub

	Public Sub ClearPassword()
		pf_Password.Clear()
	End Sub

	Public Shadows Function Focus(Optional field As String = "u") As Boolean
		Select Case field
			Case "u"
				Return UsernameField.Focus()
			Case "p"
				Return PasswordField.Focus()
		End Select
	End Function

	Private Sub PasswordGotFocus(sender As Object, e As EventArgs) Handles pf_Password.PasswordGotFocus
		PasswordField.SelectAll()
	End Sub
End Class
