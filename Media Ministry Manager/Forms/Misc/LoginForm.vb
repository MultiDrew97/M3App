Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Exceptions

Public Class Frm_Login
	Private loginFailed As Boolean = False
	Private reason As String = ""
	Private Event BeginLogin As EventHandler
	Private Event EndLogin As EventHandler

	Private Sub Frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		If loginFailed Then
			While True
				Try
					If MessageBox.Show(reason, "Login Failed", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
						PerformLogin()
						Exit While
					Else
						Exit While
					End If
				Catch
					Continue While
				End Try
			End While
		End If

		'Me.Hide()
		'' TODO: Implement this folder path for settings file to prevent overwriting
		'Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
		'If My.Settings.KeepLoggedIn Then
		'	lf_UserPass.Username = My.Settings.Username
		'	lf_UserPass.Password = My.Settings.Password
		'	chk_KeepLoggedIn.Checked = True

		'	Login(sender, e)
		'Else
		'	Reset()
		'	Me.Show()
		'End If
	End Sub

	Private Sub TimerTicking(sender As Object, e As EventArgs) Handles tmr_LoginTimer.Tick
		lsd_LoadScreen.LoadText = "Failed to connect to server in time. Please try again or contact system support."
		lsd_LoadScreen.Closable = True
		lf_Login.PasswordField.Clear()
	End Sub

	Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
		If My.Settings.KeepLoggedIn Then
			'lf_UserPass.Username = My.Settings.Username
			'lf_UserPass.Password = My.Settings.Password
			'chk_KeepLoggedIn.Checked = True

			'Login(sender, e)
			Try
				PerformLogin()
			Catch ex As Exception
				loginFailed = True
				reason = ex.Message
				Reset()
			End Try
		Else
			Reset()
		End If
	End Sub

	Private Sub Login(sender As Object, e As EventArgs) Handles btn_Login.Click
		Try
			RaiseEvent BeginLogin(sender, e)
			PerformLogin(If(lf_Login.Username, ""), If(lf_Login.Password, ""))
		Catch ex As Exception
			tss_UserFeedback.ForeColor = Color.Red

			Select Case ex.GetType()
				Case GetType(RoleException), GetType(PasswordException), GetType(ConnectionException)
					lsd_LoadScreen.LoadText = ex.Message
				Case Else
					lsd_LoadScreen.LoadText = String.Format("{0}. Please try again or Contact support.", ex.Message)
			End Select

			If ex.Message.ToLower().Contains("username") Then
				lf_Login.Clear()
				lf_Login.UsernameField.Focus()
			Else
				lf_Login.PasswordField.Clear()
				lf_Login.PasswordField.Focus()
			End If

			RaiseEvent EndLogin(sender, e)
		End Try

		'If TryLogin(lf_UserPass.Username, lf_UserPass.Password) Then
		'    Try
		'        Frm_Main.Show()
		'        'Dim mainForm = New Frm_Main
		'        'mainForm.Show()
		'        bw_SaveSettings.RunWorkerAsync()
		'    Catch exception As SqlException
		'        tss_UserFeedback.Text = "Unknown Error. Please try again."
		'        tss_UserFeedback.ForeColor = Color.Red
		'        Console.WriteLine("Failed to connect to database: " & Exception.Message)
		'        lf_UserPass.PasswordField.Clear()
		'        lf_UserPass.PasswordField.Focus()
		'    End Try
		'End If
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
	End Sub

	Private Sub Bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
		UseWaitCursor = False
		Me.Close()
	End Sub

	Private Sub Btn_CreateUser_Click(sender As Object, e As EventArgs)
		If NewUserDialog.ShowDialog = DialogResult.OK Then
			Reset()
		End If
	End Sub

	Private Sub Btn_ChangePassword_Click(sender As Object, e As EventArgs)
		If ChangePasswordDialog.ShowDialog = DialogResult.OK Then
			Reset()
		End If
	End Sub

	Private Sub TryLogin(username As String, password As String)
		Try
			db_Users.Login(username, password)
		Catch ex As Exception
			Select Case ex.GetType()
				Case GetType(RoleException)
					Throw New RoleException("Only admins can use this application. If this is an error, please contact support", ex)
				Case GetType(UsernameException)
					Throw New UserException("We couldn't find an account with that username", ex)
				Case GetType(PasswordException)
					Throw New PasswordException("Incorrect password. Please try again or reset your password")
				Case GetType(DatabaseException)
					Throw New DatabaseException("Unknown Error", ex)
				Case GetType(ArgumentException), GetType(SqlException)
					Throw New ConnectionException(ex.Message, ex)
				Case Else
					Throw New Exception(ex.Message, ex)
			End Select
		End Try
		'Try
		'    Dim user = db_Users.Login(username, password)

		'    If Not user.AccountType = AccountType.Admin Then
		'        Throw New UserException("Only admins can use this application. If this is an error, please contact support")
		'    End If

		'    Return user IsNot Nothing
		'Catch e As SqlException
		'    tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
		'    tss_UserFeedback.ForeColor = Color.Red
		'    Console.WriteLine(e.Message)
		'    lf_UserPass.PasswordField.Clear()
		'    lf_UserPass.PasswordField.Focus()
		'    Return False
		'Catch e As UserException
		'    tss_UserFeedback.Text = e.Message
		'    tss_UserFeedback.ForeColor = Color.Red
		'    lf_UserPass.PasswordField.Clear()
		'    lf_UserPass.PasswordField.Focus()
		'    Return False
		'End Try
	End Sub

	Private Sub Llb_ForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_ForgotPassword.LinkClicked
		If ChangePasswordDialog.ShowDialog = DialogResult.OK Then
			Reset()
		End If
	End Sub

	Private Sub Llb_SignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_SignUp.LinkClicked
		Using create = New SPPBC.M3Tools.Dialogs.CreateAccountDialog()
			If create.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	Private Sub SaveSettingsDone(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
		Me.Close()
	End Sub

	Private Sub PerformLogin(Optional username As String = Nothing, Optional password As String = Nothing)
		UseWaitCursor = True
		Enabled = False
		Opacity = 50

		Try
			RaiseEvent BeginLogin(Me, New EventArgs)
			My.Settings.User = db_Users.Login(If(username, My.Settings.Username), If(password, My.Settings.Password))

			If Not IsNothing(My.Settings.User) Then
				bw_SaveSettings.RunWorkerAsync()
				Frm_Main.Show()
			Else
				RaiseEvent EndLogin(Me, New EventArgs)
				lsd_LoadScreen.LoadText = "Unable to login. Please try again or contact system support."
				lsd_LoadScreen.Image = My.Resources.ErrorImage
			End If
		Catch ex As Exception
			' TODO: Clear this up
			Select Case ex.GetType()
				Case GetType(RoleException)
					lsd_LoadScreen.LoadText = "Only admins can use this application. If this is an error, please contact support"
				Case GetType(UsernameException)
					lsd_LoadScreen.LoadText = "We couldn't find an account with that username. Please try again or Contact support."
				Case GetType(PasswordException)
					lsd_LoadScreen.LoadText = "Incorrect password. Please try again or reset your password"
				Case GetType(DatabaseException)
					lsd_LoadScreen.LoadText = "Unknown Error. Please try again or Contact support."
				Case Else
					lsd_LoadScreen.LoadText = ex.Message
			End Select

			If ex.Message.ToLower().Contains("username") Then
				lf_Login.Clear()
				lf_Login.UsernameField.Focus()
			Else
				lf_Login.PasswordField.Clear()
				lf_Login.PasswordField.Focus()
			End If

			lsd_LoadScreen.Image = My.Resources.ErrorImage
		Finally
			RaiseEvent EndLogin(Me, New EventArgs)
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

	Private Sub Frm_Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		lsd_LoadScreen.Dispose()
	End Sub

	Private Sub LoginBegin(sender As Object, e As EventArgs) Handles Me.BeginLogin
		lsd_LoadScreen.LoadText = "Attempting to login..."
		lsd_LoadScreen.ShowDialog()
		tmr_LoginTimer.Start()
	End Sub

	Private Sub LoginEnd(sender As Object, e As EventArgs) Handles Me.EndLogin
		tmr_LoginTimer.Stop()
		Opacity = 100
		Enabled = True
		UseWaitCursor = False
		lsd_LoadScreen.Closable = True
	End Sub
End Class