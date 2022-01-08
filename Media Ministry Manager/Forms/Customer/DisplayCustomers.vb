Option Strict On
Imports System.Collections.ObjectModel
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayCustomers
	Private __customers As New Collection(Of Customer)
	Private Property CustomersTable As New CustomData.CustomersDataTable
	Private Tooled As Boolean = False

	Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
		bsCustomers.DataSource = CustomersTable
		Refresh()
	End Sub

	Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If Not Tooled Then
			Frm_Main.Show()
		End If
	End Sub

	Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
		If AddCustomerDialog.ShowDialog() = DialogResult.OK Then
			Refresh()
		End If
	End Sub

	Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
		If MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			Dim id As Integer = CInt(CType(dgv_Customers.Rows(e.Row.Index).DataBoundItem, DataRowView)("CustomerID"))
			Console.WriteLine(id)
			db_Customers.RemoveCustomer(id)
		Else
			e.Cancel = True
		End If
	End Sub

	Public Overrides Sub Refresh() Handles tsm_Refresh.Click
		__customers = db_Customers.GetCustomers()

		FillDataTable()
	End Sub

	Private Sub Dgv_Customers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellEndEdit
		'get values from table
		Dim column As String = dgv_Customers.Columns(e.ColumnIndex).DataPropertyName
		Dim value As String = If(dgv_Customers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot DBNull.Value, dgv_Customers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString()
		Dim customerID As Integer = CInt(CustomersTable.Rows(e.RowIndex)("CustomerID"))

		Select Case column
			Case "FirstName", "LastName", "PhoneNumber"
				If Not String.IsNullOrWhiteSpace(value) Then
					db_Customers.UpdateCustomer(customerID, column, value)
				Else
					MessageBox.Show("You must enter AddressOf value for this field", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			Case Else
				db_Customers.UpdateCustomer(customerID, column, value)
		End Select

	End Sub

	Private Sub FillDataTable()
		Dim row As DataRow

		CustomersTable.Clear()

		If __customers IsNot Nothing Then
			For Each customer As Customer In __customers
				row = CustomersTable.NewRow
				row("CustomerID") = customer.Id
				row("FirstName") = customer.FirstName
				row("LastName") = customer.LastName
				row("Street") = customer.Address.Street
				row("City") = customer.Address.City
				row("State") = customer.Address.State
				row("ZipCode") = customer.Address.ZipCode
				row("PhoneNumber") = customer.PhoneNumber
				row("EmailAddress") = customer.EmailAddress
				row("JoinDate") = customer.JoinDate
				CustomersTable.Rows.Add(row)
			Next
		End If
	End Sub

	Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
			If row.Selected Then
				Dgv_Customers_UserDeletingRow(sender, New DataGridViewRowCancelEventArgs(row))
			End If
		Next
	End Sub

	Private Sub Dgv_Customers_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Customers.MouseDown
		For Each cell As DataGridViewCell In dgv_Customers.SelectedCells
			cell.Selected = False
		Next

		If e.Button = MouseButtons.Right Then
			Dim info As DataGridView.HitTestInfo = dgv_Customers.HitTest(e.X, e.Y)
			RemoveToolStripMenuItem.Enabled = info.RowIndex > -1
			If info.RowIndex > -1 Then
				dgv_Customers.Rows(info.RowIndex).Selected = True
			End If
		End If
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Utils.CloseOpenForms()
	End Sub

	Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
		AddCustomerDialog.ShowDialog()
	End Sub

	Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
		AddProductDialog.ShowDialog()
	End Sub

	Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewListenerToolStripMenuItem.Click
		AddListenerDialog.Show()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
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

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim customers As New Frm_DisplayCustomers
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
		Dim products As New Frm_DisplayInventory
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrdersToolStripMenuItem.Click
		Dim orders As New Frm_DisplayOrders
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewListenersToolStripMenuItem.Click
		Dim listeners As New Frm_ViewListeners
		listeners.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
		Dim settings As New Frm_Settings()
		settings.Show()
	End Sub
End Class