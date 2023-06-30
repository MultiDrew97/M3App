Imports System.ComponentModel
Imports SPPBC.M3Tools.Events.Listeners

Public Class ListenersManagement
	Private tooled As Boolean = False
	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		UseWaitCursor = True
		dlc_Listeners.Reload()
		UseWaitCursor = False
		mms_Main.ToggleViewItem("Listeners")
	End Sub

	Private Sub ClosingForm(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If tooled Then
			Return
		End If

		Frm_Main.Show()
	End Sub

	Private Sub ListenerAdded(sender As Object, e As ListenerEventArgs) Handles dlc_Listeners.ListenerAdded, mms_Main.ListenerAdded
		Dim subject = "Welcome to the Ministry"
		Dim body = My.Resources.newListener

		Dim message = gt_Email.Create(e.Listener, subject, body)
		' TODO: Make this play nice with multi-tasking
		'gt_Email.Send(message)
		dlc_Listeners.Reload()
		Throw New NotYetImplementedException()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New Frm_DisplayOrders()
		orders.Show()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory()
		products.Show()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New Frm_Settings()
		settings.ShowDialog()
	End Sub

	Private Sub SendEmails() Handles dlc_Listeners.Emails
		Using emails As New SendEmailsDialog()
			UseWaitCursor = True
			Dim res = emails.ShowDialog
			UseWaitCursor = False
		End Using
	End Sub
End Class