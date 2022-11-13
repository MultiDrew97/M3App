Option Strict On
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayCustomers
	Private Sub DisplayLoading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Customers")
	End Sub

	Private Sub DisplayClosing(sender As Object, e As EventArgs) Handles Me.Closing
		mms_Main.ToggleViewItem("Customers")
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Utils.Logout()
		Me.Close()
	End Sub

	Private Sub ExitApplication() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles mms_Main.OpenCustomers
		Dim customers As New Frm_DisplayCustomers
		customers.Show()
		Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewProducts(sender As Object, e As EventArgs) Handles mms_Main.OpenProducts
		Dim products As New Frm_DisplayInventory
		products.Show()
		Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewOrders(sender As Object, e As EventArgs) Handles mms_Main.OpenOrders
		Dim orders As New Frm_DisplayOrders
		orders.Show()
		Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewListeners(sender As Object, e As EventArgs) Handles mms_Main.OpenListeners
		Dim listeners As New Frm_ViewListeners
		listeners.Show()
		Utils.SpecialClose(sender)
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.OpenSettings
		Using settings As New Frm_Settings()
			settings.Show()
		End Using
	End Sub
End Class