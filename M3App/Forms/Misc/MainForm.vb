Option Strict On

Imports MediaMinistry.Helpers

Public Class MainForm
	Private Sub Reload() Handles Me.Load
		tss_Feedback.Text = "What would you like to do?"
		tss_Feedback.ForeColor = SystemColors.WindowText
		Me.Focus()
	End Sub

	Private Sub MangeProducts(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click, mms_Main.ManageProducts
		Dim products As New InventoryManagement()
		products.Show()
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles btn_OrderManagement.Click, mms_Main.ManageOrders
		Dim orders As New OrderManagement()
		orders.Show()
		Me.Close()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click, mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		Me.Close()
	End Sub

	Private Sub ManageListeners(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click, mms_Main.ManageListeners
		Dim listeners As New ListenersManagement()
		listeners.Show()
		Me.Close()
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Utils.LogOff()
		Me.Close()
	End Sub

	Private Sub ExitApp() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub AddCustomer(sender As Object, e As Customers.CustomerEventArgs) Handles mms_Main.AddCustomer
		dbCustomer.AddCustomer(e.Customer)
		MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub AddListener(sender As Object, e As Listeners.ListenerEventArgs) Handles mms_Main.AddListener
		dbListener.AddListener(e.Listener)
		MessageBox.Show($"Successfully created listener", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub AddCustomer(sender As Object, e As Inventory.InventoryEventArgs) Handles mms_Main.AddProduct
		dbInventory.AddProduct(e.Product)
		MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	'Private Sub AddOrder(sender As Object, e As Orders.OrderEventArgs) Handles mms_Main.AddOrder
	'	dbOrder.AddOrder(e.Order)
	'	MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
	'End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New SettingsForm()
		settings.Show()
	End Sub
End Class
