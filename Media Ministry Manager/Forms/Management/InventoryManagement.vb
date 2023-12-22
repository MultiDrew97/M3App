Imports System.ComponentModel
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Events.Inventory

Public Class InventoryManagement
	Private Event InventoryDBModified As InventoryEventHandler
	Private Tooled As Boolean = False

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Products")
		Reload()
	End Sub

	Private Sub DisplayClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		' TODO: Find easier way
		If Tooled Then
			Return
		End If

		MainForm.Show()
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Utils.LogOff()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ExitApplication() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New OrderManagement()
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		tooled = True
		Me.Close()
	End Sub

	Private Sub ManageListeners(sender As Object, e As EventArgs) Handles mms_Main.ManageListeners
		Dim listeners As New ListenersManagement()
		listeners.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Using settings As New SettingsForm()
			settings.Show()
		End Using
	End Sub

	Private Sub AddProduct(sender As Object, e As InventoryEventArgs) Handles dic_Inventory.AddProduct, mms_Main.AddProduct
		UseWaitCursor = True
		dbInventory.AddProduct(e.Product)
		MessageBox.Show($"Successfully created product", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent InventoryDBModified(Me, e)
	End Sub

	Private Sub RemoveProduct(sender As Object, e As InventoryEventArgs) Handles dic_Inventory.RemoveProduct
		UseWaitCursor = True
		dbInventory.RemoveProduct(e.Product.Id)
		MessageBox.Show($"Successfully removed product", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent InventoryDBModified(Me, e)
	End Sub

	Private Sub UpdateProduct(sender As Object, e As InventoryEventArgs) Handles dic_Inventory.UpdateProduct
		UseWaitCursor = True
		dbInventory.UpdateProduct(e.Product)
		MessageBox.Show($"Successfully updated product", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent InventoryDBModified(Me, e)
	End Sub

	Private Sub Reload() Handles Me.InventoryDBModified, dic_Inventory.RefreshDisplay
		UseWaitCursor = True
		bsInventory.Clear()
		For Each product In dbInventory.GetProducts()
			bsInventory.Add(product)
		Next
		dic_Inventory.Reload()
		UseWaitCursor = False
	End Sub
End Class
