Imports System.ComponentModel
Imports SPPBC.M3Tools.Events.Listeners

Public Class ListenersManagement
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
		'gt_Email.Send(message)
		Throw New NotYetImplementedException()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles mms_Main.OpenCustomers
		Dim customers As New CustomersManagement()
		customers.ShowDialog()
		Me.Close()
	End Sub

	Private Sub ManageListeners(sender As Object, e As EventArgs) Handles mms_Main.OpenListeners
		Dim listeners As New ListenersManagement()
		listeners.ShowDialog()
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.OpenOrders
		Dim orders As New Frm_DisplayOrders()
		orders.ShowDialog()
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.OpenProducts
		Dim products As New Frm_DisplayInventory()
		products.ShowDialog()
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.OpenSettings
		Dim settings As New Frm_Settings()
		settings.ShowDialog()
	End Sub
End Class