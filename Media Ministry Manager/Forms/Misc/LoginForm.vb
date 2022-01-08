Option Strict On

Imports System.ComponentModel
Imports SPPBC.M3Tools.Exceptions
Imports SPPBC.M3Tools.Dialogs
Imports System.Data.SqlClient

Public Class Frm_Login

	Private Sub Frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Me.Hide()
		' TODO: Implement this folder path for settings file to prevent overwriting
		Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
		If My.Settings.KeepLoggedIn Then
			lf_UserPass.Username = My.Settings.Username
			lf_UserPass.Password = My.Settings.Password
			chk_KeepLoggedIn.Checked = True

			Btn_LogIn_Click(sender, e)
		Else
			Reset()
			Me.Show()
		End If
		'If My.Settings.KeepLoggedIn Then
		'    lf_UserPass.Username = My.Settings.Username
		'    lf_UserPass.Password = My.Settings.Password
		'    chk_KeepLoggedIn.Checked = True

		'    btn_LogIn.PerformClick()
		'Else
		'    Reset()
		'End If
	End Sub

	Private Sub Btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
		'If My.Settings.KeepLoggedIn Then
		'    _dbConnection.UserID = My.Settings.Username
		'    _dbConnection.Password = My.Settings.Password
		'Else
		'    _dbConnection.Password = lf_UserPass.Password
		'    _dbConnection.UserID = lf_UserPass.Username
		'End If
		Try
			UseWaitCursor = True
			TryLogin(lf_UserPass.Username, lf_UserPass.Password)
			bw_SaveSettings.RunWorkerAsync()
			Frm_Main.Show()
		Catch ex As Exception
			tss_UserFeedback.ForeColor = Color.Red
			UseWaitCursor = False

			Select Case ex.GetType()
				Case GetType(RoleException), GetType(PasswordException), GetType(ConnectionException)
					tss_UserFeedback.Text = ex.Message
				Case Else
					tss_UserFeedback.Text = String.Format("{0}. Please try again or Contact support.", ex.Message)
			End Select

			If ex.Message.ToLower().Contains("username") Then
				lf_UserPass.Clear()
				lf_UserPass.UsernameField.Focus()
			Else
				lf_UserPass.PasswordField.Clear()
				lf_UserPass.PasswordField.Focus()
			End If

			Me.Show()
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
		lf_UserPass.Clear()
		tss_UserFeedback.Text = "Please enter your log-in information"
		tss_UserFeedback.ForeColor = Color.Black
		lf_UserPass.Focus("u")
	End Sub

	Private Sub Bw_SaveSettings_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
		My.Settings.KeepLoggedIn = chk_KeepLoggedIn.Checked
		My.Settings.Username = lf_UserPass.Username
		My.Settings.Password = lf_UserPass.Password

		My.Settings.Save()
	End Sub

	Private Sub Bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
		UseWaitCursor = False
		Me.Close()
	End Sub

	Private Sub Txt_Password_GotFocus(sender As Object, e As EventArgs)
		lf_UserPass.PasswordField.SelectAll()
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
		Using create = New CreateAccountDialog()
			If create.ShowDialog = DialogResult.OK Then
				Reset()
			End If
		End Using
	End Sub

	'creating a login for a user in the database
	'CREATE USER [NAME] WITH PASSWORD = [PASSWORD]

	'granting permissions in database
	'GRANT [PERMISSION-NAME] ON [OBJECT-NAME] TO [USER/ROLE-TYPE]

	'chaging the passwords
	'ALTER USER [USER] WITH PASSWORD = [NEW-PASSWORD]
End Class