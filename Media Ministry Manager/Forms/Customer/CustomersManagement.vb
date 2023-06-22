Option Strict On
Imports System.ComponentModel
Imports MediaMinistry.Helpers

Public Class CustomersManagement
	Private Tooled As Boolean = False
	Private Sub DisplayLoading(sender As Object, e As EventArgs) Handles Me.Load
		UseWaitCursor = True
		dcc_Customers.Reload()
		UseWaitCursor = False
		mms_Main.ToggleViewItem("Customers")
	End Sub

	Private Sub DisplayClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
		Dim customers As New CustomersManagement
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub MangageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New Frm_DisplayOrders
		orders.Show()
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
End Class