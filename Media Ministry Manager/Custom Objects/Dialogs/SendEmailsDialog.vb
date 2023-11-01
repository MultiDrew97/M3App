Imports System.ComponentModel
Imports SPPBC.M3Tools.Types.GTools

Public Class SendEmailsDialog
	Private Event EmailsSending()
	Private Event EmailsSent()
	Private Event EmailsCancelled()
	Private Event ProgressMade()
	Private Event ProgressReset(total As Integer)

	'TODO: Make email sending more straight forward
	Const DriveLinkHtml = "<a href=""{0}"" class=""drive-link"">{1}</a>"

	ReadOnly Property FileCount As Integer
		Get
			Return fu_Receipts.Files.Count + gdt_Files.GetSelectedNodes().Count
		End Get
	End Property

	Private Sub BeginSending(sender As Object, e As EventArgs) Handles btn_Send.Click
		RaiseEvent EmailsSending()

		Dim details As New EmailDetails()

		If Not FileCount > 0 Then
			Dim res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If Not res = DialogResult.Yes Then
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
		Console.WriteLine(My.Settings.Username)
		gmt_Gmail.Authorize(My.Settings.Username)
		gdt_Files.Load(My.Settings.Username)
	End Sub

	Public Sub Reload() Handles Me.Shown
		UseWaitCursor = True
		gdt_Files.Reload()
		UseWaitCursor = False
	End Sub

	'Private Sub NewFolder(sender As Object, e As EventArgs)
	'	Using newFolder As New SPPBC.M3Tools.CreateFolderDialog()
	'		Dim res = newFolder.ShowDialog()
	'		If res = DialogResult.OK Then
	'			Reload()
	'		End If
	'	End Using
	'End Sub

	'Private Sub NewUpload(sender As Object, e As EventArgs)
	'	Using newUpload As New SPPBC.M3Tools.UploadFileDialog()
	'		Dim res = newUpload.ShowDialog()
	'		If res = DialogResult.OK Then
	'			Reload()
	'		End If
	'	End Using
	'End Sub

	Private Sub GatherFiles(sender As Object, e As DoWorkEventArgs) Handles bw_GatherFiles.DoWork
		Dim details = CType(e.Argument, EmailDetails)

		For Each node In gdt_Files.GetSelectedNodes()
			' TODO: Uncomment after build
			details.DriveLinks.Add(New File(node.Name, node.Text, "")) 'String.Format(My.Resources.DriveShareLink, node.Name))
		Next

		For Each file As File In fu_Receipts.Files
			details.LocalFiles.Add(file.Name)
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
		Dim details = CType(e.Argument, EmailDetails)
		'Dim links As New List(Of String)

		For Each file In details.DriveLinks
			Select Case details.EmailContents.BodyType
				Case "plain"
					details.SendingLinks.Add(String.Format(DriveShareLink, file.Id))
				Case "html"
					details.SendingLinks.Add(String.Format(DriveLinkHtml, String.Format(DriveShareLink, file.Id), file.Name))
				Case Else
			End Select
		Next

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
		Dim details = CType(e.Argument, EmailDetails)
		Dim res = rsd_Selection.ShowDialog(dbListeners.GetListeners())
		If Not res = DialogResult.OK Then
			e.Cancel = True
			Return
		End If

		details.Recipients = rsd_Selection.List
		e.Result = details
	End Sub

	Private Sub ReceipientsGathered(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_GatherReceipients.RunWorkerCompleted
		If e.Cancelled Then
			RaiseEvent EmailsCancelled()
			Return
		End If

		Dim details = CType(e.Result, EmailDetails)

		Using body As New EmailBodySelection(New TemplateList() From {
																   New Template() With {
																   .Name = "Sermon",
																   .Text = My.Resources.newSermon,
																   .Subject = "New Sermon"
																   },
				New Template() With {.Name = "Reciept", .Text = My.Resources.receipt, .Subject = "Thank you"}})
			Dim res = body.ShowDialog()
			If Not res = DialogResult.OK Then
				RaiseEvent EmailsCancelled()
				Return
			End If

			details.EmailContents = body.Content
		End Using

		bw_PrepEmails.RunWorkerAsync(details)
	End Sub

	Private Sub SendEmails(sender As Object, e As DoWorkEventArgs) Handles bw_SendEmails.DoWork
		Dim messages As New List(Of MimeKit.MimeMessage)
		Dim details = CType(e.Argument, EmailDetails)
		For Each listener In details.Recipients
			Dim body As String
			Select Case details.EmailContents.BodyType
				Case "plain"
					body = $"Hello {listener.Name}, {vbCrLf}{vbCrLf}{details.EmailContents.Body}{vbCrLf}{vbCrLf}{String.Join(vbCrLf, details.SendingLinks)}"
				Case "html"
					body = String.Format(details.EmailContents.Body, listener.Name, String.Join("<br />", details.SendingLinks))
				Case Else
					e.Cancel = True
					Exit Sub
			End Select

			' TODO: Make login screen store the user info instead of just username and password to use for sender info
			Dim message = gmt_Gmail.CreateWithAttachment(listener, details.EmailContents.Subject, body, details.EmailContents.BodyType, details.LocalFiles) ', New MimeKit.MailboxAddress(My.Settings.User.Name, My.Settings.User.Email))
			messages.Add(message)
		Next
		e.Result = messages

		'Dim message As MimeKit.MimeMessage
		'For Each listener In details.Recipients
		'	Console.WriteLine($"Name - {listener.Name}{vbNewLine}Email - {listener.Email}")
		'Next

		'tsl_Status.Text = "Prepping any attachments..."
		'RaiseEvent ProgressReset(details.DriveFiles.Count)
		'If details.DriveFiles.Count > 0 Then
		'	details.Content.Body &= $"{vbNewLine}{vbNewLine}Attachements:{vbNewLine}{vbNewLine}"

		'	For Each file In details.DriveFiles
		'		details.Content.Body &= String.Format($"{My.Resources.DriveShareLink}{vbNewLine}", file.Id)
		'		RaiseEvent ProgressMade()
		'	Next

		'	tsl_Status.Text = "Sending emails now..."
		'	RaiseEvent ProgressReset(details.Recipients.Count)
		'End If

		'For Each listener In details.Recipients
		'	message = gmt_Gmail.CreateWithAttachment(New MimeKit.MailboxAddress(listener.Name, listener.Email), details.Content, details.LocalFiles.ToArray)
		'	gmt_Gmail.Send(message)
		'	RaiseEvent ProgressMade()
		'Next
	End Sub

	Private Sub EmailsDone(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SendEmails.RunWorkerCompleted
		If e.Cancelled OrElse e.Error IsNot Nothing Then
			RaiseEvent EmailsCancelled()
			Console.Out.WriteLine("Worker was cancelled")
			Return
		End If

		Dim messages = CType(e.Result, List(Of MimeKit.MimeMessage))
		RaiseEvent ProgressReset(messages.Count)
		For Each message In messages
			gmt_Gmail.Send(message)
			RaiseEvent ProgressMade()
		Next

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

	Private Sub ResetProgress(total As Integer) Handles Me.ProgressReset
		tsp_Progress.Value = 0
		tsp_Progress.Step = CInt(Math.Floor(1 / total))
	End Sub

	Private Sub UpdateProgress() Handles Me.ProgressMade
		tsp_Progress.PerformStep()
	End Sub
End Class