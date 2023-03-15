Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Structure EmailDetails
	Property Subject As String
	Property Body As String
	Property Files As Collection(Of String)
End Structure

Public Class SendEmailsDialog
	Private __username As String = ""
	'Private ReadOnly __sendingFiles As New Collection(Of String)
	Private __email As New EmailDetails With {
		.Subject = "",
		.Body = "",
		.Files = New Collection(Of String)
	}
	Public Property Username As String
		Set(value As String)
			__username = value
		End Set
		Get
			Return __username
		End Get
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

	Private Async Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		Await gmt_Gmail.Authorize(Username)
	End Sub

	Private Sub DialogShown(sender As Object, e As EventArgs) Handles Me.Shown
		UseWaitCursor = True
		dt_DriveHeirarchy.Username = Username
		Reload()
	End Sub

	Private Sub FindSelectedNodes(nodes As TreeNodeCollection)
		For Each node As TreeNode In nodes
			If node.Checked Then
				__email.Files.Add(node.Name)
			End If

			If node.Nodes.Count > 0 Then
				FindSelectedNodes(node.Nodes)
			End If
		Next
	End Sub

	Public Sub Reload()
		UseWaitCursor = True
		dt_DriveHeirarchy.RefreshTree()
		UseWaitCursor = False
	End Sub

	Private Sub NewFolder(sender As Object, e As EventArgs) Handles tsmi_NewFolder.Click
		Using newFolder As New CreateFolderDialog(Username)
			If newFolder.ShowDialog = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub NewUpload(sender As Object, e As EventArgs) Handles tsmi_NewUpload.Click
		Using newUpload As New UploadFileDialog(Username)
			If newUpload.ShowDialog = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub NewItem(sender As Object, e As EventArgs) Handles tss_NewItem.ButtonClick
		tss_NewItem.ShowDropDown()
	End Sub

	Private Sub GatherFiles(sender As Object, e As DoWorkEventArgs) Handles bw_GatherFiles.DoWork
		__email.Files.Clear()

		Select Case CType(e.Argument, TabPages)
			Case TabPages.Sermon
				Dim selectedNodes = dt_DriveHeirarchy.GetSelectedNodes()

				For Each node In selectedNodes

					__email.Files.Add(node.Name)
				Next
			Case TabPages.Receipt
				For Each file In fu_Receipts.Files
					__email.Files.Add(file.Name)
				Next
		End Select

		Console.WriteLine(__email.Files.Count)
	End Sub

	Private Sub PrepEmails(sender As Object, e As DoWorkEventArgs) Handles bw_PrepEmails.DoWork
		'Dim htmlBody As String = "", subject As String = "", rtfBody As String = ""
		Dim currentPage = CType(e.Argument, TabPages)
		Dim res = MessageBox.Show("Would you like to use the default email template?", "Default Email Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If Not res = DialogResult.Yes Then
			'Custom Message
			Using customEmail As New CustomEmailDialog
				If customEmail.ShowDialog() = DialogResult.OK Then
					__email.Subject = customEmail.Email.Subject
					__email.Body = customEmail.Email.RichTextBody
				End If
			End Using
			Return
		End If

		'Default message
		Select Case currentPage
			Case TabPages.Sermon
				__email.Subject = "New Sermon"
				__email.Body = My.Resources.DefaultSermonEmail
			Case TabPages.Receipt
				__email.Subject = "Thank you"
				__email.Body = My.Resources.DefaultReceiptEmail
		End Select

		Console.WriteLine($"Subject: {__email.Subject}{vbNewLine}Body:{vbNewLine}{__email.Body}")
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

	Private Sub SendEmails(sender As Object, e As DoWorkEventArgs) Handles bw_SendEmails.DoWork
		' Loop through files to determine type
		Console.WriteLine($"Subject: {__email.Subject}")
		Console.WriteLine($"Body: {__email.Body}")
		Console.WriteLine($"File Count: {__email.Files.Count}")

		For Each file In __email.Files
			Console.WriteLine($"File Name: {file}")
		Next
	End Sub
End Class
