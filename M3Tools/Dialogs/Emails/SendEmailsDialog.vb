Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class SendEmailsDialog
	Private __username As String = ""
	Private ReadOnly __sendingFiles As New Collection(Of String)

	Public WriteOnly Property Username As String
		Set(value As String)
			__username = value
		End Set
	End Property

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles btn_Send.Click
		Dim fileCount As Integer = fu_Receipts.Files.Count, nodeCount As Integer = dt_DriveHeirarchy.GetSelectedNodes().Count

		If fileCount = 0 And nodeCount = 0 Then
			Console.WriteLine(fileCount)
			Console.WriteLine(nodeCount)
			MessageBox.Show("You must select a file.", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		'gather files to send
		bw_GatherFiles.RunWorkerAsync(tc_EmailTypes.SelectedIndex)
		'prep the email contents to be sent
		bw_PrepEmails.RunWorkerAsync(tc_EmailTypes.SelectedIndex)
		'Gather email reciepients
		bw_GatherReceipients.RunWorkerAsync()

		Do Until Not (bw_GatherFiles.IsBusy Or bw_PrepEmails.IsBusy Or bw_GatherReceipients.IsBusy)
			'Wait for bw to finish
			Utils.Wait(1)
		Loop

		'send emails
		bw_SendEmails.RunWorkerAsync()
		'Me.DialogResult = DialogResult.OK
		'Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Async Sub DialogShown(sender As Object, e As EventArgs) Handles Me.Shown
		UseWaitCursor = True
		Await gmt_Gmail.Authorize(__username)
		Await gdt_GDrive.Authorize(__username)
		dt_DriveHeirarchy.Username = __username
		Refresh()
	End Sub

	Private Sub LoadWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
		UseWaitCursor = False
	End Sub

	Private Sub FindSelectedNodes(nodes As TreeNodeCollection)
		For Each node As TreeNode In nodes
			If node.Checked Then
				__sendingFiles.Add(node.Name)
			End If

			If node.Nodes.Count > 0 Then
				FindSelectedNodes(node.Nodes)
			End If
		Next
	End Sub

	Public Overrides Sub Refresh()
		UseWaitCursor = True
		dt_DriveHeirarchy.RefreshTree()
		UseWaitCursor = False
	End Sub

	Private Sub NewFolder(sender As Object, e As EventArgs) Handles tsmi_NewFolder.Click
		Using newFolder As New CreateFolderDialog(__username)
			If newFolder.ShowDialog = DialogResult.OK Then
				Refresh()
			End If
		End Using
	End Sub

	Private Sub NewUpload(sender As Object, e As EventArgs) Handles tsmi_NewUpload.Click
		Using newUpload As New UploadFileDialog(__username)
			If newUpload.ShowDialog = DialogResult.OK Then
				Refresh()
			End If
		End Using
	End Sub

	Private Sub NewItem(sender As Object, e As EventArgs) Handles tss_NewItem.ButtonClick
		tss_NewItem.ShowDropDown()
	End Sub

	Private Sub GatherFiles(sender As Object, e As DoWorkEventArgs) Handles bw_GatherFiles.DoWork
		__sendingFiles.Clear()

		Select Case CType(e.Argument, TabPages)
			Case TabPages.Sermon
				Dim selectedNodes = dt_DriveHeirarchy.GetSelectedNodes()

				For Each node In selectedNodes

					__sendingFiles.Add(node.Name)
				Next
			Case TabPages.Receipt
				For Each file In fu_Receipts.Files
					__sendingFiles.Add(file.Name)
				Next
		End Select

		Console.WriteLine(__sendingFiles.Count)
	End Sub

	Private Sub PrepEmails(sender As Object, e As DoWorkEventArgs) Handles bw_PrepEmails.DoWork
		Dim htmlBody As String = "", subject As String = "", rtfBody As String = ""
		If MessageBox.Show("Would you like to use the default email template?", "Default Email Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			'Default message
			Select Case CType(e.Argument, TabPages)
				Case TabPages.Sermon
					subject = "New Sermon"
					htmlBody = My.Resources.DefaultSermonEmail
				Case TabPages.Receipt
					subject = "Thank you"
					htmlBody = My.Resources.DefaultReceiptEmail
			End Select
		Else
			'Custom Message
			Using customEmail As New CustomEmailDialog
				If customEmail.ShowDialog() = DialogResult.OK Then
					subject = customEmail.Email.Subject
					rtfBody = customEmail.Email.RichTextBody
				End If
			End Using
		End If

		Console.WriteLine(String.Format("Subject: {0}{3}html:{3}{1}{3}rtf:{3}{2}", subject, htmlBody, rtfBody, vbNewLine))
	End Sub

	Private Sub GatherReceipients(sender As Object, e As DoWorkEventArgs) Handles bw_GatherReceipients.DoWork
		Do Until Not bw_PrepEmails.IsBusy
			Utils.Wait()
		Loop

		Using reciepientSelection As New ReciepientSelectionDialog()
			If reciepientSelection.ShowDialog() = DialogResult.OK Then

			End If
		End Using
	End Sub
End Class
