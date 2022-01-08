Imports System.Windows.Forms

Public Class LoginDialog
	''' <summary>
	''' Gets or sets the username
	''' </summary>
	''' <returns></returns>
	Public Property Username As String
		Get
			Return LoginFields1.Username
		End Get
		Set(value As String)
			LoginFields1.Username = value
		End Set
	End Property

	''' <summary>
	''' Gets or sets the password
	''' </summary>
	''' <returns></returns>
	Public Property Password As String
		Get
			Return LoginFields1.Password
		End Get
		Set(value As String)
			LoginFields1.Password = value
		End Set
	End Property

	Private Sub SubmitCredentials(sender As Object, e As EventArgs) Handles btn_Submit.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub CancelRequest(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub
End Class
