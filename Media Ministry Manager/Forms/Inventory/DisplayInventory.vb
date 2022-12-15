Option Strict On
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayInventory
	Private ReadOnly ProductsTable As New SPPBC.M3Tools.DataTables.ItemsDataTable
	Private Products As ObjectModel.Collection(Of Product)
	Private Tooled As Boolean = False

	Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Refresh()
		bsProducts.DataSource = ProductsTable
	End Sub

	Private Sub Btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
		If AddProductDialog.ShowDialog() = DialogResult.OK Then
			Refresh()
		End If
	End Sub

	Private Shadows Sub Refresh()
		ProductsTable.Clear()
		LoadData()
		FillTable()
	End Sub

	Private Sub Frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If Not Tooled Then
			Dim frm As New Frm_Main
			frm.Show()
		End If
	End Sub

	Private Sub Dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
		Dim column As String = dgv_Inventory.Columns(e.ColumnIndex).DataPropertyName
		Dim value As String = CStr(dgv_Inventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

		Dim itemID As Integer = CInt(ProductsTable.Rows(e.RowIndex)("ItemID"))

		Using db As New Database
			db.UpdateInventory(itemID, column, value)
		End Using
	End Sub

	Private Sub Dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
		Dim itemID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("ItemID"))
		Dim available As Boolean = CBool(CType(e.Row.DataBoundItem, DataRowView)("Available"))

		Using db As New Database
			db.ChangeAvailability(itemID, Not available)
		End Using

		e.Cancel = True
		Refresh()
	End Sub

	Private Sub LoadData()
		Using db As New Database
			Products = db.GetProducts
		End Using
	End Sub

	Private Sub FillTable()
		Dim row As DataRow
		For Each product As Product In Products
			row = ProductsTable.NewRow
			row("ItemID") = product.Id
			row("ItemName") = product.Name
			row("Stock") = product.Stock
			row("Price") = product.Price
			row("Available") = product.Available
			ProductsTable.Rows.Add(row)
		Next
	End Sub

	Private Sub Chk_ShowUnavailable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ShowUnavailable.CheckedChanged
		If chk_ShowUnavailable.Checked Then
			bsProducts.Filter = ""
		Else
			bsProducts.Filter = "Available = True"
		End If
	End Sub

	Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
		Refresh()
	End Sub

	Private Sub Dgv_Inventory_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Inventory.MouseDown
		For Each row As DataGridViewRow In dgv_Inventory.Rows
			row.Selected = False
		Next

		If e.Button = MouseButtons.Right Then
			Dim info As DataGridView.HitTestInfo = dgv_Inventory.HitTest(e.X, e.Y)
			If info.RowIndex > -1 Then
				dgv_Inventory.Rows(info.RowIndex).Selected = True
				AvailabilityToolStripMenuItem.Enabled = True
			Else
				AvailabilityToolStripMenuItem.Enabled = False
			End If
		End If
	End Sub

	Private Sub AvailabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailabilityToolStripMenuItem.Click
		For Each row As DataGridViewRow In dgv_Inventory.SelectedRows
			Dim itemID As Integer = CInt(CType(row.DataBoundItem, DataRowView)("ItemID"))
			Dim available As Boolean = CBool(CType(row.DataBoundItem, DataRowView)("Available"))

			Using db As New Database
				db.ChangeAvailability(itemID, Not available)
			End Using

			Refresh()
		Next
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
		Dim customers As New Frm_DisplayCustomers
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs)
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