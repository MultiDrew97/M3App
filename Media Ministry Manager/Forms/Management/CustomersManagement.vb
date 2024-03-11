Imports System.ComponentModel
Imports MediaMinistry.Helpers

Public Class CustomersManagement
	Private Event CustomerDBModified As Customers.CustomerEventHandler
	Private Event CustomerAdd As Customers.CustomerEventHandler
	Private Event RemovoeCustomer As Customers.CustomerEventHandler

	Private Tooled As Boolean = False

	Private ReadOnly Property BindingSource As BindingSource
		Get
			Return bsCustomers
		End Get
	End Property

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Customers")
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

	Private Sub ExitApplication() Handles mms_Main.UpdateAvailable, mms_Main.ExitApplication
		Utils.CloseOpenForms()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New OrderManagement()
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New InventoryManagement()
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
		Using settings As New SettingsForm()
			settings.Show()
		End Using
	End Sub

	Private Sub UpdateCustomer(sender As Object, e As Customers.CustomerEventArgs) Handles cdg_Customers.EditCustomer
		UseWaitCursor = True
		'dbCustomers.UpdateCustomer(e.Customer.Id, e.Customer.FirstName, e.Customer.LastName, e.Customer.Address, e.Customer.Email, e.Customer.Phone)
		MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub AddCustomer(sender As Object, e As Customers.CustomerEventArgs) Handles mms_Main.AddCustomer, Me.CustomerAdd
		UseWaitCursor = True
		dbCustomers.AddCustomer(e.Customer)
		MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub RemoveCustomer(sender As Object, e As Customers.CustomerEventArgs) Handles cdg_Customers.RemoveCustomer
		UseWaitCursor = True
		dbCustomers.RemoveCustomer(e.Customer.Id)
		MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information)
		RaiseEvent CustomerDBModified(Me, e)
	End Sub

	Private Sub Reload() Handles Me.CustomerDBModified, Me.Load
		UseWaitCursor = True
		bsCustomers.Clear()
		For Each customer In dbCustomers.GetCustomers()
			bsCustomers.Add(customer)
		Next
		ts_Tools.Count = String.Format(My.Resources.CountTemplate, cdg_Customers.Rows.Count)
		UseWaitCursor = False
	End Sub

	Private Sub ToolsAddCustomer(sender As Object, e As EventArgs) Handles ts_Tools.Add
		Using add As New AddCustomerDialog()
			Dim res = add.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent CustomerAdd(Me, New Customers.CustomerEventArgs(add.Customer, EventType.Added))
		End Using
	End Sub

	Private Sub FilterChanged(sender As Object, filter As String) Handles ts_Tools.FilterChanged
		bsCustomers.Filter = filter
	End Sub
End Class
