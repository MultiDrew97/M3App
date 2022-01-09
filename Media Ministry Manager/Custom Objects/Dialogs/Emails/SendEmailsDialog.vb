Imports System.ComponentModel
Imports SPPBC.M3Tools.Types
Imports MimeKit
Imports System.Collections.ObjectModel

Public Class SendEmailsDialog
	Private ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
	Private fileID As String = Nothing
	Private listeners As Collection(Of Listener)
	Private closable As Boolean = False
	Private body As String = "", subject As String = ""


	Private Sub Btn_UploadFile_Click(sender As Object, e As EventArgs) Handles btn_UploadFile.Click
		If DriveUploadDialog.ShowDialog = DialogResult.OK Then
			LoadFiles()
		End If
	End Sub

	Private Sub Cbx_Folders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folders.SelectedIndexChanged
		LoadFiles()
	End Sub

	Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_LocalSend.Click, btn_SermonSend.Click, btn_CustomSend.Click
		If tcl_EmailOptions.SelectedIndex = 0 Then
			bw_GetFileID.RunWorkerAsync()
		ElseIf tcl_EmailOptions.SelectedIndex = 2 Then
			If MessageBox.Show("Would you like to attach a file to this message?", "Attachment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				GetFile()
			End If
		End If
		bw_LoadListeners.RunWorkerAsync()
	End Sub

	Private Sub Bw_LoadListeners_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_LoadListeners.DoWork
		If ListenerSelectionDialog.ShowDialog() = DialogResult.OK Then
			listeners = ListenerSelectionDialog.Listeners
		End If
	End Sub

	Private Sub Bw_LoadListeners_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadListeners.RunWorkerCompleted
		bw_SendEmails.RunWorkerAsync()
	End Sub

	Private Sub Bw_SendEmails_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SendEmails.DoWork
		Dim content As MimeMessage

		e.Cancel = Not PrepSubject()

		If Not bw_SendEmails.CancellationPending Then
			Using emailer As New GoogleAPI.Sender()
				For Each listener As Listener In ListenerSelectionDialog.Listeners
					If PrepBody(listener.Name) Then
						If tcl_EmailOptions.SelectedIndex < 2 Then
							If tcl_EmailOptions.SelectedIndex = 1 Then
								content = emailer.CreateWithAttachment(listener.EmailAddress, subject, body, flf_LocalReciept.ofdFileSelection.FileName)
							Else
								content = emailer.Create(listener.EmailAddress, subject, body)
							End If
						Else
							If FileSelectionDialog.FileName <> Nothing Then
								content = emailer.CreateWithAttachment(listener.EmailAddress, subject, body, FileSelectionDialog.FileName)
							Else
								content = emailer.Create(listener.EmailAddress, subject, body)
							End If
						End If
						emailer.Send(content)
					End If
				Next
			End Using
		Else
			MessageBox.Show("If you are using a custom message, you must set one in the custom message tab", "Custom Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
		'Invoke(
		'    Sub()
		'        Dim content As MimeMessage

		'        e.Cancel = Not PrepSubject()

		'        If Not bw_SendEmails.CancellationPending Then
		'            Using emailer As New GoogleAPI.Sender()
		'                For Each listener As Listener In listeners
		'                    If PrepBody(listener.Name) Then
		'If tcl_EmailOptions.SelectedIndex < 2 Then
		'	If tcl_EmailOptions.SelectedIndex = 1 Then
		'		content = emailer.CreateWithAttachment(listener.EmailAddress, subject, body, flf_LocalReciept.ofdFileSelection.FileName)
		'	Else
		'		content = emailer.Create(listener.EmailAddress, subject, body)
		'	End If
		'Else
		'	If FileSelectionDialog.FileName <> Nothing Then
		'                                content = emailer.CreateWithAttachment(listener.EmailAddress, subject, body, FileSelectionDialog.FileName)
		'                            Else
		'                                content = emailer.Create(listener.EmailAddress, subject, body)
		'                            End If
		'                        End If
		'                        emailer.Send(content)
		'                    End If
		'                Next
		'            End Using
		'        Else
		'            MessageBox.Show("If you are using a custom message, you must set one in the custom message tab", "Custom Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
		'        End If
		'    End Sub
		'    )
	End Sub

	Private Sub Frm_SendEmails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If bw_SendEmails.IsBusy Or bw_LoadListeners.IsBusy Then
			Console.WriteLine("Background Worker still running")
			e.Cancel = True
			Me.Hide()
			closable = True
		End If
	End Sub

	Private Sub Bw_SendEmails_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SendEmails.RunWorkerCompleted
		If Not e.Cancelled Then
			MessageBox.Show("All emails have been sent.", "Email Ministry", MessageBoxButtons.OK, MessageBoxIcon.Information)

			If closable Then
				Me.Close()
			End If
		End If
	End Sub

	Private Sub Bw_GetFileID_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_GetFileID.DoWork
		fileID = gd_Uploader.GetFileID(CStr(cbx_Files.SelectedItem)).Result
		'Invoke(
		'    Sub()
		'        Using uploader As New GoogleAPI.DriveUploader()
		'            fileID = uploader.FindFile(CType(cbx_Files.SelectedItem, String))
		'        End Using
		'    End Sub
		')
	End Sub

	Sub LoadFolders()
		cbx_Folders.DataSource = gd_Uploader.GetFolders()
		'Using uploader As New GoogleAPI.DriveUploader()
		'    cbx_Folders.DataSource = uploader.GetFolders()
		'End Using
	End Sub

	Private Sub LoadFiles()
		cbx_Files.DataSource = gd_Uploader.GetFiles(CStr(cbx_Folders.SelectedItem))
		cbx_Files.Text = ""
		'Using uploader As New GoogleAPI.DriveUploader
		'    cbx_Files.DataSource = uploader.GetFiles(CType(cbx_Folders.SelectedValue, String))
		'End Using
	End Sub

	Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
		If FolderCreationDialog.ShowDialog = DialogResult.OK Then
			If MessageBox.Show("Would you like to upload a file to this new folder?", "Upload New File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				If DriveUploadDialog.ShowDialog = DialogResult.OK Then
					LoadFiles()
				End If
			Else
				LoadFolders()
			End If
		End If
	End Sub

	Private Sub Btn_CustomMessage_Click(sender As Object, e As EventArgs) Handles btn_CustomMessage.Click
		CustomMessageDialog.ShowDialog()
	End Sub

	Private Sub GetFile()
		Dim response As DialogResult
		While response <> DialogResult.OK And response <> DialogResult.Cancel And response <> DialogResult.Yes
			response = FileSelectionDialog.ShowDialog()
			If response = DialogResult.Cancel Then
				response = MessageBox.Show("Are sure you don't want to select a file?", "File Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			End If
		End While
	End Sub

	Private Function PrepBody(name As String) As Boolean
		Select Case tcl_EmailOptions.SelectedIndex
			Case 0
				If chk_SermonDefault.Checked Then
					body = String.Format(My.Resources.newSermon, name, String.Format(shareLink, fileID))
				Else
					body = String.Format(My.Resources.customMessageWithDriveLink, name, CustomMessageDialog.Body, String.Format(shareLink, fileID))
				End If
			Case 1
				If chk_RecieptDefault.Checked Then
					If RecieptTypeDialog.ShowDialog = DialogResult.OK Then
						body = String.Format(My.Resources.receipt, RecieptTypeDialog.Amount, RecieptTypeDialog.Type)
					Else
						Return False
					End If
				Else
					If CustomMessageDialog.ShowDialog = DialogResult.OK Then
						If RecieptTypeDialog.ShowDialog = DialogResult.OK Then
							body = String.Format(My.Resources.receipt, name, RecieptTypeDialog.Amount, RecieptTypeDialog.Type)
						Else
							Return False
						End If
					Else
						Return False
					End If
				End If
			Case 2
				If FileSelectionDialog.FileID = Nothing Then
					If CustomMessageDialog.Subject <> "" And CustomMessageDialog.Body <> "" Then
						body = String.Format(My.Resources.customMessageTemplate, name, CustomMessageDialog.Body)
					Else
						MessageBox.Show("You must create a custom message first before you can send one.", "No Custom Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return False
					End If
				Else
					If CustomMessageDialog.Subject <> "" And CustomMessageDialog.Body <> "" Then
						body = String.Format(My.Resources.customMessageWithDriveLink, name, CustomMessageDialog.Body, String.Format(shareLink, FileSelectionDialog.FileID))
					Else
						MessageBox.Show("You must create a custom message first before you can send one.", "No Custom Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return False
					End If
				End If
		End Select

		Return True
	End Function

	Private Function PrepSubject() As Boolean
		If tcl_EmailOptions.SelectedIndex < 2 Then
			If chk_SermonDefault.Checked Or chk_RecieptDefault.Checked Then
				'set subject to default one

				If tcl_EmailOptions.SelectedIndex = 0 Then
					subject = "Sunday Morning Message"
				Else
					subject = "Love Offering Reciept"
				End If
			Else
				'open custom message form then set subject and body to custom message
				If CustomMessageDialog.Subject <> "" And CustomMessageDialog.Body <> "" Then
					subject = CustomMessageDialog.Subject
				Else
					If CustomMessageDialog.ShowDialog = DialogResult.OK Then
						subject = CustomMessageDialog.Subject
					Else
						Return False
					End If
				End If
			End If
		Else
			subject = CustomMessageDialog.Subject
		End If

		Return True
	End Function

	Private Sub Tcl_EmailOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcl_EmailOptions.SelectedIndexChanged
		'SelectedOption = tcl_EmailOptions.SelectedIndex
	End Sub

	Private Async Sub SendEmailsDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		UseWaitCursor = True
		Await gd_Uploader.Authorize(My.Settings.Username)
		LoadFolders()
		UseWaitCursor = False
	End Sub
End Class