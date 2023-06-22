Option Strict On
Imports System.ComponentModel
Imports MediaMinistry.Helpers

Public Class Frm_DisplayCustomers
	Private Tooled As Boolean = False
	Private Sub DisplayLoading(sender As Object, e As EventArgs) Handles Me.Load
		Try
			dcc_Customers.Reload()
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
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

	Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles mms_Main.OpenCustomers
		Dim customers As New Frm_DisplayCustomers
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewProducts(sender As Object, e As EventArgs) Handles mms_Main.OpenProducts
		Dim products As New Frm_DisplayInventory
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewOrders(sender As Object, e As EventArgs) Handles mms_Main.OpenOrders
		Dim orders As New Frm_DisplayOrders
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewListeners(sender As Object, e As EventArgs) Handles mms_Main.OpenListeners
		'Dim listeners As New Frm_ViewListeners
		'listeners.Show()
		'Tooled = True
		'Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.OpenSettings
		Using settings As New Frm_Settings()
			settings.Show()
		End Using
	End Sub
End Class