Option Strict On
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayCustomers
	Private Tooled As Boolean = False
	Private ReadOnly _parent As Form = Nothing
	Private __customers As New Collection(Of Customer)
	Private Property CustomersTable As New CustomData.CustomersDataTable

	Public Sub New(ByRef Optional parent As Form = Nothing)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_parent = parent
	End Sub

	Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
		Refresh()
		mms_Main.ToggleViewItem("ViewCustomers")
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
	'Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
 '       If MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
 '           Dim id As Integer = CInt(CType(dgv_Customers.Rows(e.Row.Index).DataBoundItem, DataRowView)("CustomerID"))
 '           Console.WriteLine(id)
 '           db_Customers.RemoveCustomer(id)
 '       Else
 '           e.Cancel = True
 '       End If
 '   End Sub

	'Public Overrides Sub Refresh() Handles tsm_Refresh.Click
	'	__customers = db_Customers.GetCustomers()

	'	Select Case column
	'		Case "FirstName", "LastName", "PhoneNumber"
	'			If Not String.IsNullOrWhiteSpace(value) Then
	'				db_Customers.UpdateCustomer(customerID, column, value)
	'			Else
	'				MessageBox.Show("You must enter AddressOf value for this field", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'			End If
	'		Case Else
	'			db_Customers.UpdateCustomer(customerID, column, value)
	'	End Select

	'	If __customers IsNot Nothing Then
	'		For Each customer As Customer In __customers
	'			row = CustomersTable.NewRow
	'			row("CustomerID") = customer.Id
	'			row("FirstName") = customer.FirstName
	'			row("LastName") = customer.LastName
	'			row("Street") = customer.Address.Street
	'			row("City") = customer.Address.City
	'			row("State") = customer.Address.State
	'			row("ZipCode") = customer.Address.ZipCode
	'			row("PhoneNumber") = customer.PhoneNumber
	'			row("EmailAddress") = customer.EmailAddress
	'			row("JoinDate") = customer.JoinDate
	'			CustomersTable.Rows.Add(row)
	'		Next
	'	End If
	'End Sub

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