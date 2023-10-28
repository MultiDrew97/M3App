Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Frm_Login
	Private Event BeginLogin()
	Private Event EndLogin()

	' TODO: Potentially consolidate these function
	Private Sub Showing(sender As Object, e As EventArgs) Handles Me.Shown
		' TODO: Use PerformLogin sub instead
		chk_KeepLoggedIn.Checked = My.Settings.KeepLoggedIn

		If Not chk_KeepLoggedIn.Checked Then
			Reset()
			Return
		End If

		PerformLogin(sender, e)
	End Sub



	Private Sub TimerTicking(sender As Object, e As EventArgs) Handles tmr_LoginTimer.Tick
		lsd_LoadScreen.LoadText = "Failed to connect to server in time. Please try again or contact system support."
		lsd_LoadScreen.Closable = True
		lf_Login.PasswordField.Clear()
	End Sub

	Private Sub Reset()
		chk_KeepLoggedIn.Checked = False
		lf_Login.Clear()
		tss_UserFeedback.Text = "Please enter your log-in information"
		tss_UserFeedback.ForeColor = Color.Black
		lf_Login.UsernameField.Focus()
	End Sub

	Private Sub SaveSettings(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
		My.Settings.KeepLoggedIn = chk_KeepLoggedIn.Checked
		My.Settings.Username = If(lf_Login.Username, My.Settings.Username)
		My.Settings.Password = If(lf_Login.Password, My.Settings.Password)
		My.Settings.Save()

		'M3ToolsSettings.CurrentUser = My.Settings.Username
		'M3ToolsSettings.Save()
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
			Dim user = dbUsers.Login(If(username, My.Settings.Username), If(password, My.Settings.Password))

			If user Is Nothing Then
				Throw New Exception("Unable to login. Please try again or contact system support.")
			End If

			My.Settings.User = user
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
					Throw New Exception(ex.Message, ex)
			End Select
		End Try
	End Sub

	Private Sub PerformLogin(sender As Object, e As EventArgs) Handles btn_Login.Click
		Try
			TryLogin(If(lf_Login.Username, Nothing), If(lf_Login.Password, Nothing))

			bw_SaveSettings.RunWorkerAsync()
			Frm_Main.Show()
		Catch ex As Exception
			' TODO: Clear this up
			Dim message As String

			Select Case ex.GetType()
				Case GetType(RoleException)
					message = "Only admins can use this application. If this is an error, please contact support"
				Case GetType(UsernameException)
					message = "We couldn't find an account with that username. Please try again or contact support."
				Case GetType(PasswordException)
					message = "Incorrect password. Please try again or reset your password"
				Case GetType(DatabaseException)
					message = "Unknown database error. Please try again or contact support."
				Case Else
					message = ex.Message
			End Select

			If message.ToLower().Contains("username") Then
				lf_Login.Clear()
				lf_Login.Focus()
			Else
				lf_Login.ClearPassword()
				lf_Login.Focus("p")
			End If

			'lsd_LoadScreen.Image = My.Resources.ErrorImage
			lsd_LoadScreen.ShowError(message)
		Finally
			RaiseEvent EndLogin()
		End Try
	End Sub

	Private Sub ForgotPassword(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_ForgotPassword.LinkClicked
		Using forgot = New SPPBC.M3Tools.ChangePasswordDialog()
			If forgot.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	Private Sub CreateAccount(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_SignUp.LinkClicked
		Using create = New SPPBC.M3Tools.Dialogs.CreateAccountDialog()
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