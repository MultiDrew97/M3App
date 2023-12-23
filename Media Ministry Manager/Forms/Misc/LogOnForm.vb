Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class LogOnForm
	Private Event BeginLogin()
	Private Event EndLogin()

	Private Property Username As String
		Get
			Return lf_Login.Username
		End Get
		Set(value As String)
			lf_Login.Username = value
		End Set
	End Property

	Private Property Password As String
		Get
			Return lf_Login.Password
		End Get
		Set(value As String)
			lf_Login.Password = value
		End Set
	End Property

	Private Property KeepLoggedIn As Boolean
		Get
			Return chk_KeepLoggedIn.Checked
		End Get
		Set(value As Boolean)
			chk_KeepLoggedIn.Checked = value
		End Set
	End Property

	' TODO: Potentially consolidate these function
	' TODO: Figure out more secure way to store login info
	Private Sub Showing(sender As Object, e As EventArgs) Handles Me.Shown
		Username = My.Settings.Username

		If Not My.Settings.KeepLoggedIn Then
			Reset()
			Return
		End If

		btn_Login.PerformClick()
	End Sub

	Private Sub TimerTicking(sender As Object, e As EventArgs) Handles tmr_LoginTimer.Tick
		lsd_LoadScreen.LoadText = "Failed to connect to server in time. Please try again or contact system support."
		lsd_LoadScreen.Closable = True
		lf_Login.PasswordField.Clear()
	End Sub

	Private Sub Reset()
		KeepLoggedIn = False
		lf_Login.Clear()
		tss_UserFeedback.Text = "Please enter your log-in information"
		tss_UserFeedback.ForeColor = Color.Black
		lf_Login.UsernameField.Focus()
	End Sub

	Private Sub SaveSettings(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
		' TODO: Determine better way to handle this
		My.Settings.KeepLoggedIn = If(Not KeepLoggedIn, My.Settings.KeepLoggedIn, KeepLoggedIn)
		My.Settings.Username = If(lf_Login.Username, My.Settings.Username)
		' FIXME: Prevent this from saving password as plain text
		My.Settings.Password = If(lf_Login.Password, My.Settings.Password)
		My.Settings.Save()
	End Sub

	Private Sub SettingsSaved(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
		UseWaitCursor = False
		Me.Close()
	End Sub

	Private Sub NewUser(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_SignUp.LinkClicked
		Using create = New CreateAccountDialog()
			If create.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	Private Sub TryLogin(Optional username As String = Nothing, Optional password As String = Nothing)
		Try
			RaiseEvent BeginLogin()
			My.Settings.User = dbUsers.Login(If(username, My.Settings.Username), If(password, My.Settings.Password))
		Catch ex As Exception
			Select Case ex.GetType()
				Case GetType(RoleException)
					Throw New RoleException("Only admins can use this application. If this is an error, please contact support", ex)
				Case GetType(UsernameException)
					Throw New UserException("We couldn't find an account with that username", ex)
				Case GetType(PasswordException)
					Throw New PasswordException("Incorrect password. Please try again or reset your password", ex)
				Case GetType(DatabaseException)
					Throw New DatabaseException("Unknown Error", ex)
				Case GetType(ArgumentException), GetType(SqlException)
					Throw New ConnectionException(ex.Message, ex)
				Case Else
					Throw New NotImplementedException(ex.Message, ex)
			End Select
		End Try
	End Sub

	Private Sub PerformLogin(sender As Object, e As EventArgs) Handles btn_Login.Click
		Try
			'TryLogin(If(Username, Nothing), If(Password, Nothing))
			RaiseEvent BeginLogin()
			My.Settings.User = dbUsers.Login(If(Username, My.Settings.Username), If(Password, My.Settings.Password))

			bw_SaveSettings.RunWorkerAsync()
			MainForm.Show()
		Catch role As RoleException
			lsd_LoadScreen.ShowError("Only admins can use this application. If this is an error, please contact support")
			lf_Login.ClearPassword()
			lf_Login.Focus("p")
		Catch username As UsernameException
			lsd_LoadScreen.ShowError("We couldn't find an account with that username. Please try again or contact support.")
			lf_Login.Clear()
			lf_Login.Focus()
		Catch password As PasswordException
			lf_Login.ClearPassword()
			lsd_LoadScreen.ShowError("Incorrect password provided. Please try again or reset your password")
			lf_Login.Focus("p")
		Catch database As DatabaseException
			lsd_LoadScreen.ShowError("Unknown database error. Please try again or contact support.")
			lf_Login.ClearPassword()
			lf_Login.Focus("p")
		Catch ex As Exception
			lsd_LoadScreen.ShowError("Unknown error occurred. Please try again or contact support.")
			lf_Login.ClearPassword()
			lf_Login.Focus("p")
		Finally
			RaiseEvent EndLogin()
		End Try
	End Sub

	Private Sub ForgotPassword(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_ForgotPassword.LinkClicked
		Using forgot = New ChangePasswordDialog()
			If forgot.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	Private Sub CreateAccount(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_SignUp.LinkClicked
		Using create = New CreateAccountDialog()
			If create.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	Private Sub LoginClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		lsd_LoadScreen.Dispose()
	End Sub

	Private Sub LoginBegin() Handles Me.BeginLogin
		lsd_LoadScreen.LoadText = "Attempting to login..."
		lsd_LoadScreen.ShowDialog()
		UseWaitCursor = True
		Enabled = False
		Opacity = 50
		tmr_LoginTimer.Start()
	End Sub

	Private Sub LoginEnd() Handles Me.EndLogin
		tmr_LoginTimer.Stop()
		Opacity = 100
		Enabled = True
		UseWaitCursor = False
		lsd_LoadScreen.Closable = True
	End Sub
End Class
