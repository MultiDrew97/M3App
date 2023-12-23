Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayOrdersCtrl
	' TODO: Implement a way to change between current and completed orders
	' TODO: Make an event for when the count is updated
	' TODO: Convert DataGridView to TreeView so that orders for the same person can be grouped together
	' TODO: Instead of TreeView, use something in the containing ToolStripContainer
	Private Event ShowCompletedChanged()
	Public Event DataChanged()

	'Private ReadOnly _orders As New Types.DBEntryCollection(Of Types.Order)
	Private _showCompleted As Boolean = False
	Private Confirmed As Boolean = False

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

	'Property DataSource As BindingSource
	'	Get
	'		Return odg_Orders.DataSource
	'	End Get
	'	Set(value As BindingSource)
	'		odg_Orders.DataSource = value
	'	End Set
	'End Property

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

		Filter = If(Not ShowCompleted, "[CompletedDate] IS NULL", "")
	End Sub

	Private Sub LoadOrders(sender As Object, e As DoWorkEventArgs) Handles bw_LoadOrders.DoWork
		Try
			' TODO: Figure out how to sort the table to sort by order date
			' DdataSource.Clear()
			For Each order In db_Orders.GetOrders()
				'DataSource.Add(order)
			Next
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			e.Cancel = True
			Exit Sub
		End Try
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load

	End Sub

	Public Sub Reload() Handles ts_Refresh.Click
		UseWaitCursor = True
		bw_LoadOrders.RunWorkerAsync()
	End Sub

	Private Sub OrdersLoaded() Handles bw_LoadOrders.RunWorkerCompleted
		UseWaitCursor = False
		' TODO: Play around with this to make sure it works
		ShowCompleted = False
		RaiseEvent DataChanged()
		dgv_Orders.Refresh()
	End Sub

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Orders.CellContentClick
		If (e.RowIndex < 0) Then
			Exit Sub
		End If

		'ToolButtonsClicked(e.ColumnIndex, DataSource(e.RowIndex).Id)
	End Sub

	Private Sub UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Orders.UserDeletingRow
		Confirmed = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed Or dgv_Orders.SelectedRows.Count < 1 Then
			e.Cancel = True
			Return
		End If

		ClearSelectedRows()
		e.Row.Selected = True
		RemoveSelectedRows()
	End Sub
	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		Confirmed = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed OrElse dgv_Orders.SelectedRows.Count < 1 Then
			Return
		End If

		RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_Orders.SelectedRows
			row.Selected = False
		Next
	End Sub

	Private Sub RemoveSelectedRows()
		Dim id As Integer
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Orders.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Orders.SelectedRows
			Try
				id = DirectCast(row.Cells.Item("CustomerID").Value, Integer)
				db_Orders.CancelOrder(id)
			Catch
				failed += 1
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
					If edit.ShowDialog(Me) = DialogResult.OK Then
						Reload()
					End If
				End Using
		End Select
	End Sub

	Private Sub ShowCompletedOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ts_ShowCompleted.Click
		ShowCompleted = True
	End Sub

	Private Sub PlaceOrder(sender As Object, e As EventArgs) Handles tbtn_PlaceOrder.Click
		Using placeOrder As New PlaceOrderDialog()
			If placeOrder.ShowDialog = DialogResult.Yes Then
				Reload()
			End If
		End Using
	End Sub
End Class
