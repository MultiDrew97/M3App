Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayOrdersCtrl
	' TODO: Implement a way to change between current and completed orders
	' TODO: Make an event for when the count is updated
	' TODO: Convert DataGridView to TreeView so that orders for the same person can be grouped together

	Private Event ShowCompletedChanged()
	Public Event DataChanged()

	Private ReadOnly _orders As New DataTables.OrdersDataTable()
	Private _showCompleted As Boolean = False

	Public Property ShowCompleted As Boolean
		Get
			Return _showCompleted
		End Get
		Set(value As Boolean)
			_showCompleted = value
			RaiseEvent ShowCompletedChanged()
		End Set
	End Property

	Public Property Filter As String
		Get
			Return bsOrders.Filter
		End Get
		Set(value As String)
			bsOrders.Filter = value
		End Set
	End Property

	Public ReadOnly Property IsEmpty As Boolean
		Get
			Return _orders.Rows.Count = 0
		End Get
	End Property

	Public Sub FulfilOrder()
		Dim orderID As Integer

		If dgv_Orders.SelectedRows.Count > 0 Or dgv_Orders.SelectedCells.Count > 0 Then
			For Each row As DataGridViewRow In dgv_Orders.SelectedRows
				orderID = CInt(CType(row.DataBoundItem, DataRowView)("OrderID"))
				db_Orders.CompleteOrder(orderID)
				dgv_Orders.Rows.RemoveAt(row.Index)
			Next
		Else
			MessageBox.Show("You must select at least 1 order to fulfill it.", "Select an Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub ToggleCompleted() Handles Me.ShowCompletedChanged
		If Not ShowCompleted Then
			Exit Sub
		End If

		' TODO: Determine how to display completed orders
	End Sub

	Private Sub LoadOrders(sender As Object, e As DoWorkEventArgs) Handles bw_LoadOrders.DoWork
		Dim orders As New Types.DBEntryCollection(Of Types.Order)
		Try
			orders = db_Orders.GetCurrentOrders()
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
		_orders.Clear()

		For Each order In orders
			_orders.AddOrdersRow(
				order.Id, order.Customer.Name, order.Product.Name,
				order.Quantity, order.OrderTotal, order.OrderDate, order.CompletedDate)
		Next

		' TODO: Figure out how to sort the table to sort by order date
		RaiseEvent DataChanged()
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsOrders.DataSource = _orders
	End Sub

	Public Sub Reload() Handles ts_Refresh.Click
		UseWaitCursor = True
		bw_LoadOrders.RunWorkerAsync()
	End Sub

	Private Sub OrdersLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadOrders.RunWorkerCompleted
		UseWaitCursor = False
		'Filter = "CompletedDate != 'N/A'"
		Refresh()
	End Sub

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs)
		Dim orderID As Integer
		If (e.RowIndex < 0) Then
			Exit Sub
		End If

		orderID = CInt(_orders.Rows(e.RowIndex)("OrderID"))
		ToolButtonsClicked(e.ColumnIndex, orderID)
	End Sub

	Private Sub UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs)
		If MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			Dim orderID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("OrderID"))
			db_Orders.CancelOrder(orderID)
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub ToolButtonsClicked(colIndex As Integer, orderID As Integer)
		Select Case colIndex
			Case btn_Complete.Index
				' Complete Order
				'db_Orders.CompleteOrder(orderID)
			Case btn_Cancel.Index
				' Cancel Order
				'db_Orders.CancelOrder(orderID)
			Case btn_Edit.Index
				' Edit Order
				Using edit As New EditOrderDialog(orderID)
					edit.ShowDialog(Me)
				End Using
		End Select
	End Sub

	Private Sub ShowCompletedOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCompletedOrdersToolStripMenuItem.Click
		ShowCompleted = True
	End Sub

	Private Sub PlaceOrder(sender As Object, e As EventArgs) Handles tbtn_New.Click
		Using newOrder As New PlaceOrderDialog()
			If newOrder.ShowDialog() = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub
End Class
