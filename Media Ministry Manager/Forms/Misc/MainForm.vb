Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.Helpers

Public Class Frm_Main
	Dim firstTime As Boolean = True

	Structure WindowSizes
		Shared normal As New Size(413, 452)
		Shared max As New Size(1382, 744)
	End Structure

	Private Sub DisplayProductMgmt(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click, mms_Main.OpenProducts
		Dim inventory As New Frm_DisplayInventory
		inventory.Show()
		Me.Close()
	End Sub

	Private Sub DisplayOrders(sender As Object, e As EventArgs) Handles btn_OrderManagement.Click, mms_Main.OpenOrders
		Dim orders As New Frm_DisplayOrders()
		orders.Show()
		Me.Close()
	End Sub

	Private Sub DisplayCustomers(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click, mms_Main.OpenCustomers
		Dim customers As New Frm_DisplayCustomers
		customers.Show()
		Me.Close()
	End Sub

	Private Sub Reset() Handles Me.Load
		tss_Feedback.Text = "What would you like to do?"
		tss_Feedback.ForeColor = SystemColors.WindowText
	End Sub

	Private Sub EmailMinistry(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click, mms_Main.OpenListeners
		If EmailMinistryDialog.ShowDialog = DialogResult.OK Then
			Select Case EmailMinistryDialog.SelectedItem
				Case "Send"
					SendEmailsDialog.ShowDialog()
				Case "Upload"
					DriveUploadDialog.ShowDialog()
				Case "View"
					Dim listeners As New Frm_ViewListeners
					listeners.Show()
					Me.Close()
			End Select
		End If
	End Sub

	Private Sub FormSizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
		If firstTime Then
			firstTime = False
			Return
		End If

		' TODO: Determine proper way to do this

		If Me.Size = WindowSizes.max Then
			GrowToMax()
		Else
			BackToNormal()
		End If


		'bw_ChangedSizes.RunWorkerAsync(size)
	End Sub

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

	Private Sub DisplaySettings() Handles mms_Main.OpenSettings
		Frm_Settings.Show()
	End Sub

	Private Sub UpdateSizes(sender As Object, e As DoWorkEventArgs) Handles bw_ChangedSizes.DoWork
		Select Case CStr(e.Argument)
			Case "b"
				Invoke(
					Sub()
						GrowToMax()
					End Sub
				)
			Case "s"
				Invoke(
					Sub()
						BackToNormal()
					End Sub
				)
		End Select
	End Sub
End Class
