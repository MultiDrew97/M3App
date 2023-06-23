Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class SendEmailsDialog
	Private Event EmailsSending()
	Private Event EmailsSent()
	Private Event EmailsCancelled()
	'TODO: Make email sending more straight forward

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

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles btn_Send.Click
		RaiseEvent EmailsSending()

		Dim details As New EmailDetails(tc_EmailTypes.SelectedIndex)

		If FileCount = 0 Then
			Dim res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If res = DialogResult.No Then
				RaiseEvent EmailsCancelled()
				Return
			End If

			bw_PrepEmails.RunWorkerAsync(details)
			Return
		End If

		'gather files to send
		bw_GatherFiles.RunWorkerAsync(details)
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		gmt_Gmail.Authorize()
		gdt_Files.Load()
	End Sub

	Public Sub Reload() Handles Me.Shown
		UseWaitCursor = True
		gdt_Files.Reload()
		UseWaitCursor = False
	End Sub

	Private Sub NewFolder(sender As Object, e As EventArgs)
		Using newFolder As New CreateFolderDialog()
			Dim res = newFolder.ShowDialog()
			If res = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub NewUpload(sender As Object, e As EventArgs)
		Using newUpload As New UploadFileDialog()
			Dim res = newUpload.ShowDialog()
			If res = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub GatherFiles(sender As Object, e As DoWorkEventArgs) Handles bw_GatherFiles.DoWork
		Dim details = CType(e.Argument, EmailDetails)

		For Each node In gdt_Files.GetSelectedNodes()
			details.Files.Add(String.Format(My.Resources.DriveShareLink, node.Name))
		Next

		For Each file In fu_Receipts.Files
			details.Files.Add(file.Name)
		Next

		e.Result = details
	End Sub

	Private Sub FilesGathered(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_GatherFiles.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_GatherReceipients.RunWorkerAsync(e.Result)
	End Sub

	Private Sub PrepEmails(sender As Object, e As DoWorkEventArgs) Handles bw_PrepEmails.DoWork
		Dim details As EmailDetails = CType(e.Argument, EmailDetails)

		Dim res = MessageBox.Show("Would you like to use the default email template?", "Default Email Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If res = DialogResult.Yes Then
			' TODO: How to get names and links into these templates
			'Default message
			Select Case details.CurrentIndex
				Case tp_GDrive.TabIndex
					details.Subject = "New Sermon"
					details.Body = My.Resources.DefaultSermonEmail
				Case tp_LocalFiles.TabIndex
					details.Subject = "Thank you"
					details.Body = My.Resources.DefaultReceiptEmail
			End Select
			details.BodyType = "html"
			Return
		End If

		'Custom Message
		Using customEmail As New CustomEmailDialog
			res = customEmail.ShowDialog()
			If Not res = DialogResult.OK Then
				RaiseEvent EmailsCancelled()
				Return
			End If

			details.Subject = customEmail.Subject
			details.Body = customEmail.Body
			details.BodyType = "plain"
		End Using


		Console.WriteLine($"Subject: {details.Subject}{vbNewLine}Body:{vbNewLine}{details.Body}")
		e.Result = details
	End Sub

	Private Sub EmailsPrepped(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_PrepEmails.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_SendEmails.RunWorkerAsync(e.Result)
	End Sub

	Private Sub GatherReceipients(sender As Object, e As DoWorkEventArgs) Handles bw_GatherReceipients.DoWork
		Using listenerSelect As New ReciepientSelectionDialog()
			Dim details = CType(e.Argument, EmailDetails)
			Dim res = listenerSelect.ShowDialog()
			If Not res = DialogResult.OK Then
				e.Cancel = True
				Return
			End If

			details.Recipients = listenerSelect.Selection
			e.Result = details
		End Using
	End Sub

	Private Sub ReceipientsGathered(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_GatherReceipients.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		bw_PrepEmails.RunWorkerAsync(e.Result)
	End Sub

	Private Sub SendEmails(sender As Object, e As DoWorkEventArgs) Handles bw_SendEmails.DoWork
		Console.WriteLine("Selected Listeners:")

		Dim details = CType(e.Argument, EmailDetails)
		Dim message As MimeKit.MimeMessage
		For Each listener In details.Recipients
			Console.WriteLine($"Name - {listener.Name}{vbNewLine}Email - {listener.Email}")
		Next

		' Loop through files to determine type
		Console.WriteLine($"Subject: {details.Subject}")
		Console.WriteLine($"Body: {details.Body}")
		Console.WriteLine($"File Count: {details.Files.Count}")

		gmt_Gmail.SendEmails(details)

		For Each listener In details.Recipients
			message = gmt_Gmail.Create(New MimeKit.MailboxAddress(listener.Name, listener.Email), details.Subject, details.Body, bodyType:=details.BodyType)
			gmt_Gmail.Send(message)
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