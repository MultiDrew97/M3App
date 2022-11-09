Option Strict On
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_DisplayOrders
	Private ReadOnly OrdersTable As New CustomData.OrdersDataTable
	Private Orders As ObjectModel.Collection(Of CurrentOrder)
	Private Tooled As Boolean = False
	'TODO: Implement a way to change between current and completed orders
	Private Sub FormLoading(sender As Object, e As EventArgs) Handles Me.Load
		bsOrders.DataSource = OrdersTable
		LoadData()
		lbl_NoOrders.Visible = OrdersTable.Rows.Count = 0
	End Sub

	Private Sub OrdersClosed(sender As Object, e As EventArgs) Handles Me.Closed
		If Not Tooled Then
			Dim frm As New Frm_Main
			frm.Show()
		End If
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub Btn_Fulfil_Click(sender As Object, e As EventArgs) Handles btn_Complete.Click
		Dim orderID As Integer

		If dgv_Orders.SelectedRows.Count > 0 Or dgv_Orders.SelectedCells.Count > 0 Then
			For Each row As DataGridViewRow In dgv_Orders.SelectedRows
				Using db = New Database
					orderID = CInt(CType(row.DataBoundItem, DataRowView)("OrderID"))
					db.CompleteOrder(orderID)
					dgv_Orders.Rows.RemoveAt(row.Index)
				End Using
			Next
		Else
			MessageBox.Show("You must select at least 1 order to fulfill it.", "Select an Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub ShowCompleted(sender As Object, e As EventArgs) Handles btn_ShowCompleted.Click
		'TODO: Create a new form or dialog box to show completed orders
	End Sub

	Private Sub LoadData()
		Orders = db_Orders.GetCurrentOrders

		FillTable()
	End Sub

	Private Sub FillTable()
		Dim row As DataRow
		For Each order As CurrentOrder In Orders
			row = OrdersTable.NewRow
			row("OrderID") = order.Id
			row("CustomerName") = order.Customer.Name
			row("ItemName") = order.Item.Name
			row("Quantity") = order.Quantity
			row("OrderDate") = order.OrderDate
			row("OrderTotal") = order.OrderTotal
			OrdersTable.Rows.Add(row)
		Next
	End Sub

	Private Sub Dgv_Orders_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Orders.UserDeletingRow
		If MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			Using db As New Database
				Dim orderID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("OrderID"))
				db.CancelOrder(orderID)
			End Using
		Else
			e.Cancel = True
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

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
		Dim customers As New Frm_DisplayCustomers(Me)
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

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs)
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