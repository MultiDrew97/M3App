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

	Private Sub ListenerAdded(sender As Object, e As ListenerAddedEvent) Handles dlc_Listeners.ListenerAdded
		Dim [to] = New MimeKit.MailboxAddress(e.ListenerName, e.ListenerEmail)
		Dim subject = "Welcome to the Ministry"
		Dim body = My.Resources.newListener

		Dim message = gt_Email.Create([to], subject, body)
		' TODO: Make this play nice with multi-tasking
		'gt_Email.Send(message)
		Throw New NotYetImplementedException()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.ShowDialog()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageListeners(sender As Object, e As EventArgs) Handles mms_Main.ManageListeners
		Dim listeners As New ListenersManagement()
		listeners.ShowDialog()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New Frm_DisplayOrders()
		orders.ShowDialog()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory()
		products.ShowDialog()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New Frm_Settings()
		settings.ShowDialog()
	End Sub
End Class