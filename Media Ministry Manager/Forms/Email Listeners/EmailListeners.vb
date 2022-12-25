Imports System.ComponentModel
Imports SPPBC.M3Tools.Events.Listeners

Public Class frm_EmailListeners
	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		dlc_Listeners.Reload()
	End Sub

	Private Sub ClosingForm(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Frm_Main.Show()
	End Sub

	Private Sub ListenerAdded(sender As Object, e As ListenerAddedEvent) Handles dlc_Listeners.ListenerAdded
		Dim [to] = New MimeKit.MailboxAddress(e.ListenerName, e.ListenerEmail)
		Dim subject = "Welcome to the Ministry"
		Dim body = My.Resources.newListener

		Dim message = gt_Email.Create([to], subject, body)
		' TODO: Make this play nice with multi-tasking
		gt_Email.Send(message)
	End Sub
End Class