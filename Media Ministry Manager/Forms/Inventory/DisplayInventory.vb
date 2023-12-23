Option Strict On
Imports MediaMinistry.Helpers

Public Class Frm_DisplayInventory
	Private ReadOnly ProductsTable As New SPPBC.M3Tools.DataTables.InventoryDataTable
	Private ReadOnly Inventory As New DBEntryCollection(Of Product)
	Private Tooled As Boolean = False

	Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Reload()
		bsProducts.DataSource = ProductsTable
	End Sub

	Private Sub Btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
		If AddProductDialog.ShowDialog() = DialogResult.OK Then
			Reload()
		End If
	End Sub

	Private Sub Reload()
		ProductsTable.Clear()
		' TODO: Load items
		FillTable()
	End Sub

	Private Sub Frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If Not Tooled Then
			Dim frm As New MainForm
			frm.Show()
		End If
	End Sub

	Private Sub Dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
		' TODO: Update Item
	End Sub

	Private Sub Dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
		' TODO: Verify if to force deleting item

		e.Cancel = True
		Reload()
	End Sub

	Private Sub FillTable()
		Dim row As DataRow
		For Each item As SPPBC.M3Tools.Types.Product In Inventory
			row = ProductsTable.NewRow
			row("ItemID") = item.Id
			row("ItemName") = item.Name
			row("Stock") = item.Stock
			row("Price") = item.Price
			row("Available") = item.Available
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
		Reload()
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
		' TODO: Modify availablity for items

		Reload()
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Helpers.Utils.CloseOpenForms()
	End Sub

	Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
		'AddCustomerDialog.ShowDialog()
	End Sub

	Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
		AddProductDialog.ShowDialog()
	End Sub

	Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewListenerToolStripMenuItem.Click
		'AddListenerDialog.Show()
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
		Dim customers As New CustomersManagement()
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrdersToolStripMenuItem.Click
		Dim orders As New OrderManagement()
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewListenersToolStripMenuItem.Click
		'Dim listeners As New Frm_ViewListeners
		'listeners.Show()
		'Tooled = True
		'Me.Close()
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
		Dim settings As New SettingsForm()
		settings.Show()
	End Sub
End Class