Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayOrdersCtrl
    ' TODO: Implement a way to change between current and completed orders
    ' TODO: Make an event for when the count is updated

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
    End Sub

    Private Sub LoadOrders(sender As Object, e As DoWorkEventArgs) Handles bw_LoadOrders.DoWork
        Dim orders As New Types.DBEntryCollection(Of Types.Order)
        Try
            orders = db_Orders.GetCurrentOrders()
            _orders.Clear()

            For Each currentOrder In currentOrders
                _orders.AddOrdersRow(
                    currentOrder.Id, currentOrder.Customer.Name, currentOrder.Product.Name,
                    currentOrder.Quantity, currentOrder.OrderTotal, currentOrder.OrderDate, currentOrder.CompletedDate)
            Next
            For Each currentOrder In currentOrders
                _orders.AddOrdersRow(
                    currentOrder.Id, currentOrder.Customer.Name, currentOrder.Product.Name,
                    currentOrder.Quantity, currentOrder.OrderTotal, currentOrder.OrderDate)
            Next

        ' TODO: Figure out how to sort the table to sort by order date

    End Sub

    Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
        bsOrders.DataSource = _orders
    End Sub

    Private Sub Reload() Handles ts_Refresh.Click
    Public Sub Reload() Handles ts_Refresh.Click
        UseWaitCursor = True
        bw_LoadOrders.RunWorkerAsync()
    End Sub

		UseWaitCursor = False
		Refresh()
	End Sub
        Refresh()
	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Orders.CellContentClick
        Dim orderID As Integer
        If (e.RowIndex < 0) Then
            If (e.RowIndex < 0) Then
                Exit Sub
            Else

                orderID = CInt(_orders.Rows(e.RowIndex)("OrderID"))
            ToolButtonsClicked(e.ColumnIndex, orderID)
    End Sub

    Private Sub UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Orders.UserDeletingRow
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

    Private Sub Dgv_Orders_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Orders.UserDeletingRow
        If MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim orderID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("OrderID"))
            db_Orders.CancelOrder(orderID)
        Else
            e.Cancel = True
        End If
    End Sub
End Class
