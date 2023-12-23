Option Strict On
Imports MediaMinistry.Helpers

Public Class Frm_DisplayOrders
	' TODO: Add eventhandler for when data is updated to show/hide empty message
	Private Sub ViewLoading(sender As Object, e As EventArgs) Handles Me.Load
		doc_Orders.Reload()
		mms_Strip.ToggleViewItem("Orders")
		'lbl_NoOrders.Visible = doc_Orders.Count
	End Sub

	Private Sub ViewClosed(sender As Object, e As EventArgs) Handles Me.Closed
		mms_Strip.ToggleViewItem("Orders")
		MainForm.Show()
	End Sub

	Private Sub Logout() Handles mms_Strip.Logout
		Utils.LogOff()
		Me.Close()
	End Sub

	Private Sub ExitApplication() Handles mms_Strip.ExitApplication, mms_Strip.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles mms_Strip.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		'Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewProducts(sender As Object, e As EventArgs) Handles mms_Strip.ManageProducts
		Dim products As New InventoryManagement()
		products.Show()
		'Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewListeners(sender As Object, e As EventArgs) Handles mms_Strip.ManageListeners
		Dim listeners As New ListenersManagement()
		listeners.Show()
		'Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Strip.ViewSettings
		Dim settings As New SettingsForm()
		settings.Show()
	End Sub

	Private Sub DataUpdated() Handles doc_Orders.DataChanged
		'lbl_NoOrders.Visible = doc_Orders.IsEmpty
	End Sub
End Class
