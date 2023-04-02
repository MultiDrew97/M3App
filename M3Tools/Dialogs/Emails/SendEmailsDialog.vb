Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Structure EmailDetails
	Property Subject As String
	Property Body As String
	Property Files As Collection(Of String)
End Structure

Public Class SendEmailsDialog
	'Private __username As String = ""
	'Private ReadOnly __sendingFiles As New Collection(Of String)
	Private __email As New EmailDetails With {
		.Subject = "",
		.Body = "",
		.Files = New Collection(Of String)
	}

	Private Event EmailsSending()
	Private Event EmailsSent()
	Private Event EmailsCancelled()

	ReadOnly Property FileCount As Integer
		Get
			Dim files As Integer = fu_Receipts.Files.Count, nodes As Integer = gdt_Files.GetSelectedNodes().Count

			Console.WriteLine(files)
			Console.WriteLine(nodes)
			If files = 0 Then
				Return nodes
			Else
				Return files
			End If
		End Get
	End Property

	'Public Property Username As String
	'	Set(value As String)
	'		My.Settings.CurrentUser = value
	'	End Set
	'	Get
	'		Return My.Settings.CurrentUser
	'	End Get
	'End Property

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles btn_Send.Click
		btn_Send.Enabled = False

		If FileCount = 0 Then
			MessageBox.Show("You must select a file.", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		RaiseEvent EmailsSending()
		'gather files to send
		bw_GatherFiles.RunWorkerAsync(tc_EmailTypes.SelectedIndex)
		''prep the email contents to be sent
		'bw_PrepEmails.RunWorkerAsync(tc_EmailTypes.SelectedIndex)
		''Gather email reciepients
		'bw_GatherReceipients.RunWorkerAsync()
		''send emails
		'bw_SendEmails.RunWorkerAsync()
		'Me.DialogResult = DialogResult.OK
		'Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		gmt_Gmail.Authorize()
		gdt_Files.Load()
	End Sub

	Private Sub DialogShown(sender As Object, e As EventArgs) Handles Me.Shown
		UseWaitCursor = True
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
		gdt_Files.Reload()
		UseWaitCursor = False
	End Sub

	Private Sub NewFolder(sender As Object, e As EventArgs) Handles tsmi_NewFolder.Click
		Using newFolder As New CreateFolderDialog()
			If newFolder.ShowDialog = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub NewUpload(sender As Object, e As EventArgs) Handles tsmi_NewUpload.Click
		Using newUpload As New UploadFileDialog()
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
		' TODO: Allow the option to select files from GDrive for reciepts
		Select Case CType(e.Argument, TabPages)
			Case TabPages.Sermon
				Dim selectedNodes = gdt_Files.GetSelectedNodes()

				For Each node In selectedNodes
					__email.Files.Add(node.Name)
				Next
			Case TabPages.Receipt
				For Each file In fu_Receipts.Files
					__email.Files.Add(file.Name)
				Next
		End Select
	End Sub

	Private Sub FilesGathered(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_GatherFiles.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_PrepEmails.RunWorkerAsync(tc_EmailTypes.SelectedIndex)
	End Sub

	Private Sub PrepEmails(sender As Object, e As DoWorkEventArgs) Handles bw_PrepEmails.DoWork
		Dim currentPage = CType(e.Argument, TabPages)
		Dim res = MessageBox.Show("Would you like to use the default email template?", "Default Email Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If res = DialogResult.Yes Then
			'Default message
			Select Case currentPage
				Case TabPages.Sermon
					__email.Subject = "New Sermon"
					__email.Body = My.Resources.DefaultSermonEmail
				Case TabPages.Receipt
					__email.Subject = "Thank you"
					__email.Body = My.Resources.DefaultReceiptEmail
			End Select
			Return
		End If

		'Custom Message
		Using customEmail As New CustomEmailDialog
			If Not customEmail.ShowDialog() = DialogResult.OK Then
				e.Cancel = True
				Return
			End If

			__email.Subject = customEmail.Email.Subject
			__email.Body = customEmail.Email.RichTextBody
		End Using


		Console.WriteLine($"Subject: {__email.Subject}{vbNewLine}Body:{vbNewLine}{__email.Body}")
	End Sub

	Private Sub EmailsPrepped(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_PrepEmails.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_GatherReceipients.RunWorkerAsync()
	End Sub

	Private Sub GatherReceipients(sender As Object, e As DoWorkEventArgs) Handles bw_GatherReceipients.DoWork
		Using reciepientSelection As New ReciepientSelectionDialog()
			If Not reciepientSelection.ShowDialog() = DialogResult.OK Then
				e.Cancel = True
				Return
			End If

			'e.Result = reciepientSelection.Listeners
		End Using
	End Sub

	Private Sub ReceipientsGathered(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_GatherReceipients.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_SendEmails.RunWorkerAsync(e.Result)
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

	Private Sub EmailsDone(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SendEmails.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Console.Out.WriteLine("Worker was cancelled")
		End If

		If e.Error IsNot Nothing Then
			Console.Error.WriteLine(e.Error.Message)
		End If

		RaiseEvent EmailsSent()
	End Sub

	Private Sub Cancelled() Handles Me.EmailsCancelled
		btn_Send.Enabled = True
	End Sub

	Private Sub Sending() Handles Me.EmailsSending
		btn_Send.Enabled = False
	End Sub

	Private Sub Sent() Handles Me.EmailsSent
		btn_Send.Enabled = True
	End Sub
End Class
