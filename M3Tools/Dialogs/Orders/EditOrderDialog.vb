Imports System.ComponentModel
Imports System.Windows.Forms

Public Class EditOrderDialog
	Private ReadOnly _items As New DataTables.InventoryDataTable

	Property OrderID As Integer

	Private Sub Finished(sender As Object, e As EventArgs) Handles OK_Button.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub DialogLoading(sender As Object, e As EventArgs) Handles Me.Load
		bsItems.DataSource = _items
		cbx_Items.DisplayMember = "ItemName"
		cbx_Items.ValueMember = "ItemID"
		bw_LoadOrder.RunWorkerAsync()
		bw_LoadItems.RunWorkerAsync()
	End Sub

	Private Sub LoadItems(sender As Object, e As DoWorkEventArgs) Handles bw_LoadItems.DoWork
		Dim items = db_Items.GetProducts()
		_items.Clear()

		For Each item In items
			_items.AddInventoryRow(item.Id, item.Name, item.Stock, item.Price, item.Available)
		Next
	End Sub

	Private Sub ItemsLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadItems.RunWorkerCompleted
		Refresh()
	End Sub

	Private Sub ChangeItem(sender As Object, e As EventArgs) Handles cbx_Items.SelectedIndexChanged
		Console.WriteLine($"ItemID: {cbx_Items.SelectedValue}{vbNewLine}Item Name: {cbx_Items.SelectedText}")
	End Sub

	Private Sub LoadOrder(sender As Object, e As DoWorkEventArgs) Handles bw_LoadOrder.DoWork
		db_Orders.GetOrder(OrderID)
	End Sub
End Class
