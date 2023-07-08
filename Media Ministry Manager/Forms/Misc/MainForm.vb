Option Strict On

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports MediaMinistry.Helpers

Public Class Frm_Main
	' TODO: Add functionality for menu strip items here or figure out how to truley centralize in control
	Structure WindowSizes
		Shared normal As New Size(413, 452)
		Shared max As New Size(1382, 744)
	End Structure

	Private Sub Reload() Handles Me.Load
		tss_Feedback.Text = "What would you like to do?"
		tss_Feedback.ForeColor = SystemColors.WindowText
	End Sub

	Private Sub MangeProducts(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click, mms_Main.ManageProducts
		Dim products As New Frm_DisplayInventory()
		products.Show()
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles btn_OrderManagement.Click, mms_Main.ManageOrders
		Dim orders As New Frm_DisplayOrders()
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

	'Private Sub FormSizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
	'	If firstTime Then
	'		firstTime = False
	'		Return
	'	End If

	'	' TODO: Determine proper way to do this

	'	If Me.Size = WindowSizes.max Then
	'		GrowToMax()
	'	Else
	'		BackToNormal()
	'	End If


	'	'bw_ChangedSizes.RunWorkerAsync(size)
	'End Sub

	Private Sub GrowToMax()
		'Hide normal size menu buttons
		btn_CustomerManagement.Hide()
		btn_OrderManagement.Hide()
		btn_ProductManagement.Hide()
		btn_EmailMinistry.Hide()

		'show max size menu options
		'tctl_MaxOption.Show()

		'tctl size
		'1366, 667
	End Sub

	Private Sub BackToNormal()
		'show normal size menu buttons
		btn_CustomerManagement.Show()
		btn_OrderManagement.Show()
		btn_ProductManagement.Show()
		btn_EmailMinistry.Show()

		'hide max size menu options
		'tctl_MaxOption.Hide()
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Utils.Logout()
		Me.Close()
	End Sub

	Private Sub ExitApp() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Utils.CloseOpenForms()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New Frm_Settings()
		settings.Show()
	End Sub

	Private Sub UpdateSizes(sender As Object, e As DoWorkEventArgs) Handles bw_ChangedSizes.DoWork
		Select Case CStr(e.Argument)
			Case "b"
				GrowToMax()
			Case "s"
				BackToNormal()
		End Select
	End Sub
End Class
