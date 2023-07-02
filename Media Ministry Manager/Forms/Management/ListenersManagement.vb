Imports System.ComponentModel
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Events.Listeners

Public Class ListenersManagement
	Private Tooled As Boolean = False

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Listeners")
		gt_Email.Authorize()
		Reload()
	End Sub

	Private Sub ClosingForm(sender As Object, e As CancelEventArgs) Handles Me.Closing
		' TODO: Find easier way
		If Tooled Then
			Return
		End If

		Frm_Main.Show()
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Utils.Logout()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ExitApplication() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New Frm_DisplayOrders()
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory()
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New Frm_Settings()
		settings.ShowDialog()
	End Sub

	Private Sub SendEmails() Handles dlc_Listeners.SendEmails
		Using emails As New SendEmailsDialog()
			UseWaitCursor = True
			Dim res = emails.ShowDialog
			UseWaitCursor = False
		End Using
	End Sub

	Private Sub RemoveListener(sender As Object, e As ListenerEventArgs) Handles dlc_Listeners.RemoveListener
		UseWaitCursor = True
		dbListeners.RemoveListener(e.Listener.Id)
		Reload()
	End Sub

	Private Sub ListenerAdded(sender As Object, e As ListenerEventArgs) Handles mms_Main.ListenerAdded, dlc_Listeners.ListenerAdded
		UseWaitCursor = True
		Dim subject = "Welcome to the Ministry"
		Dim body = String.Format(newListener, e.Listener.Name.Trim)
		Dim message = gt_Email.Create(e.Listener, subject, body)

		gt_Email.Send(message)
		Reload()
	End Sub

	Private Sub UpdateListener(sender As Object, e As ListenerEventArgs) Handles dlc_Listeners.UpdateListener
		UseWaitCursor = True
		dbListeners.UpdateListener(e.Listener)
		Reload()
	End Sub

	Private Sub Reload() Handles dlc_Listeners.RefreshDisplay
		UseWaitCursor = True
		bsListeners.Clear()
		For Each listener In dbListeners.GetListeners()
			bsListeners.Add(listener)
		Next
		dlc_Listeners.Reload()
		UseWaitCursor = False
	End Sub
End Class