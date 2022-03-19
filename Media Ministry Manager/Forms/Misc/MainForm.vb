Option Strict On

Imports System.ComponentModel

Public Class Frm_Main
	ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"
	Dim firstTime As Boolean = True

	Structure WindowSizes
		Shared normal As New Size(413, 452)
		Shared max As New Size(1382, 744)
	End Structure

	Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
		If My.Application.OpenForms.Count = 1 And Not My.Settings.KeepLoggedIn Then
			Frm_Login.Show()
			'Dim login As New Frm_Login()
			'login.Show()
		End If
	End Sub

	Private Sub Btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
		PlaceOrderDialog.ShowDialog(Me)
	End Sub

	Private Sub Btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
		Frm_DisplayInventory.Show(Me)
		'Dim inventory As New Frm_DisplayInventory
		'inventory.Show()
		Me.Close()
	End Sub

	Private Sub Btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
		Frm_DisplayOrders.Show(Me)
		'Dim ordersView = New Frm_DisplayOrders
		'ordersView.Show()
		Me.Close()
	End Sub

	Private Sub Btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
		'Dim displayCustomers = New Frm_DisplayCustomers
		'displayCustomers.Show()
		Using customers As New Frm_DisplayCustomers(Me)
			customers.Show()
			Me.Close()
		End Using
	End Sub

	Private Sub Reset()
		tss_Feedback.Text = "What would you like to do?"
		tss_Feedback.ForeColor = SystemColors.WindowText
	End Sub

	Private Sub Btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
		If EmailMinistryDialog.ShowDialog = DialogResult.OK Then
			Dim form As Form
			Select Case EmailMinistryDialog.SelectedItem
				Case "Send"
					SendEmailsDialog.ShowDialog()
				Case "Upload"
					DriveUploadDialog.ShowDialog()
				Case "View"
					form = New Frm_ViewListeners
					form.Show()
					Me.Close()
			End Select
		End If
	End Sub

	Private Sub Frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
		Dim size As String

		If Me.Size = WindowSizes.max Then
			size = "b"
		Else
			size = "s"
		End If

		If Not firstTime Then
			bw_ChangedSizes.RunWorkerAsync(size)
		Else
			firstTime = False
		End If
	End Sub

	Private Sub GrowToMax()
		'Hide normal size menu buttons
		btn_CustomerManagement.Hide()
		btn_placeOrder.Hide()
		btn_ShowOrders.Hide()
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
		btn_placeOrder.Show()
		btn_ShowOrders.Show()
		btn_ProductManagement.Show()
		btn_EmailMinistry.Show()

		'hide max size menu options
		'tctl_MaxOption.Hide()
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.Logout
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mms_Main.ExitApplication
		Helpers.Utils.CloseOpenForms()
	End Sub

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenCustomers
		Using customers As New Frm_DisplayCustomers(Me)
			customers.Show()
			Me.Close()
		End Using
	End Sub

	Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenProducts
		Frm_DisplayInventory.Show()
		Me.Close()
	End Sub

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenOrders
		Frm_DisplayOrders.Show()
		Me.Close()
	End Sub

	Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenListeners
		Frm_ViewListeners.Show()
		Me.Close()
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenSettings
		Frm_Settings.Show()
	End Sub

	Private Sub Bw_ChangedSizes_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_ChangedSizes.DoWork
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

	Private Sub UpdateApp(sender As Object, e As EventArgs) Handles mms_Main.UpdateAvailable
		Helpers.Utils.CloseOpenForms()
		'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13
		'Dim latestVersion As String = ""

		'While String.IsNullOrEmpty(latestVersion) Or (latestVersion.Split("."c).Length) > 4
		'	wb_Browser.Url = New Uri("https://sppbc.hopto.org/manager/version")
		'	Console.WriteLine(wb_Browser.DocumentText)

		'	latestVersion = wb_Browser.DocumentText.Replace("Version ", String.Empty)
		'	latestVersion = latestVersion.Replace(vbCrLf, String.Empty)
		'	latestVersion = latestVersion.Trim

		'	Console.WriteLine(latestVersion)
		'End While
	End Sub
End Class
