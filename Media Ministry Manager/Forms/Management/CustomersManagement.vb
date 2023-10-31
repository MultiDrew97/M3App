Imports System.ComponentModel
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Events.Customers

Public Class CustomersManagement
	Private Event CustomerDBModified As CustomerEventHandler
	Private Tooled As Boolean = False

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Customers")
		Reload()
	End Sub

	Private Sub DisplayClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		' TODO: Find easier way
		If Tooled Then
			Return
		End If

		Frm_Main.Show()
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
		Dim orders As New Frm_DisplayOrders
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageListeners(sender As Object, e As EventArgs) Handles mms_Main.ManageListeners
		Dim listeners As New ListenersManagement()
		listeners.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Using settings As New Frm_Settings()
			settings.Show()
		End Using
	End Sub

	Private Sub EditCustomer(sender As Object, e As CustomerEventArgs) Handles dcc_Customers.UpdateCustomer
		'Dim res = CustomerDialogs.EditCustomer(e.Customer)
		UseWaitCursor = True
		dbCustomers.UpdateCustomer(e.Customer.Id, e.Customer.FirstName, e.Customer.LastName, e.Customer.Address, e.Customer.PhoneNumber, e.Customer.Email)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub AddCustomer(sender As Object, e As CustomerEventArgs) Handles dcc_Customers.AddCustomer, mms_Main.AddCustomer
		UseWaitCursor = True
		dbCustomers.AddCustomer(e.Customer)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub RemoveCustomer(sender As Object, e As CustomerEventArgs) Handles dcc_Customers.RemoveCustomer
		UseWaitCursor = True
		dbCustomers.RemoveCustomer(e.Customer.Id)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub Reload() Handles dcc_Customers.RefreshDisplay, Me.CustomerDBModified
		UseWaitCursor = True
		bsCustomers.Clear()
		For Each customer In dbCustomers.GetCustomers()
			bsCustomers.Add(customer)
		Next
		dcc_Customers.Reload()
		UseWaitCursor = False
	End Sub
End Class