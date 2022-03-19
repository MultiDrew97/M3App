Option Strict On
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayCustomers
	Private Tooled As Boolean = False
	Private ReadOnly _parent As Form = Nothing

	Public Sub New(ByRef Optional parent As Form = Nothing)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_parent = parent
	End Sub

	Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
		Refresh()
		mms_Main.Items.Item("tsmi_ViewCustomers").Visible = False
		'For Each toolItem As ToolStripItem In mms_Main.Items
		'	If toolItem.Name = "ts_ViewCustomers" Then
		'		toolItem.Enabled = True
		'	End If
		'Next
	End Sub

	Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If Not Tooled Then
			Frm_Main.Show()
		End If
	End Sub

	Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs)
		Using dialog As New SPPBC.M3Tools.Dialogs.AddCustomerDialog()
			If dialog.ShowDialog() = DialogResult.OK Then
				Refresh()
			End If
		End Using
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.Logout
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mms_Main.ExitApplication
		Utils.CloseOpenForms()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.UpdateAvailable
		'Dim updateLocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
		'Dim updateCheck As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

		'Dim request As HttpWebRequest = WebRequest.CreateHttp(updateCheck)
		'Dim responce As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

		'Dim sr As StreamReader = New StreamReader(responce.GetResponseStream)

		'Dim latestVersion As String = sr.ReadToEnd()
		'Dim currentVersion As String = Application.ProductVersion

		'If Not latestVersion.Contains(currentVersion) Then
		'    wb_Updater.Navigate(updateLocation)
		'End If
		MessageBox.Show("This feature is currently under construction.", "Out of Order", MessageBoxButtons.OK, MessageBoxIcon.Hand)
	End Sub

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenCustomers
		Using customers As New Frm_DisplayCustomers(Me)
			customers.Show()
			Tooled = True
			Me.Close()
		End Using
	End Sub

	Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenProducts
		Using products As New Frm_DisplayInventory
			products.Show()
			Tooled = True
			Me.Close()
		End Using
	End Sub

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenOrders
		Using orders As New Frm_DisplayOrders
			orders.Show()
			Tooled = True
			Me.Close()
		End Using
	End Sub

	Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenListeners
		Using listeners As New Frm_ViewListeners
			listeners.Show()
			Tooled = True
			Me.Close()
		End Using
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mms_Main.OpenSettings
		Using settings As New Frm_Settings()
			settings.Show()
		End Using
	End Sub
End Class