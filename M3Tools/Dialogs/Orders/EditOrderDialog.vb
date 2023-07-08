Imports System.ComponentModel
Imports System.Windows.Forms

Public Class EditOrderDialog
	Private _order As Types.Order
	Private _changed As Types.Order

	Property OrderID As Integer

	Property CurrentOrder As Types.Order
		Get
			Return _order
		End Get
		Set(value As Types.Order)
			_order = value
		End Set
	End Property

	Property UpdatedOrder As Types.Order
		Get
			Return _changed
		End Get
		Set(ByVal value As Types.Order)
			_changed = value
		End Set
	End Property

	Sub New(orderID As Integer)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.OrderID = orderID
	End Sub

	Private Sub Finished(sender As Object, e As EventArgs) Handles OK_Button.Click
		If Not ChangesDetected() Then
			MessageBox.Show("No changes were detected", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		db_Orders.UpdateOrder(UpdatedOrder)

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub DialogLoading(sender As Object, e As EventArgs) Handles Me.Load
		bw_LoadOrder.RunWorkerAsync()
		pcb_Items.Reload()
	End Sub

	Private Sub LoadOrder(sender As Object, e As DoWorkEventArgs) Handles bw_LoadOrder.DoWork
		Try
			CurrentOrder = db_Orders.GetOrderById(OrderID)
		Catch ex As Exception
			e.Cancel = True
		End Try
	End Sub

	Private Sub OrderLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadOrder.RunWorkerCompleted
		If CurrentOrder Is Nothing Or e.Cancelled Then
			Exit Sub
		End If

		gi_CustomerName.Text = CurrentOrder.Customer.Name
		pcb_Items.SelectedValue = CurrentOrder.Product.Id
		qnc_Quantity.Quantity = CurrentOrder.Quantity

		UpdatedOrder = CurrentOrder.Clone
	End Sub

	Private Sub ItemsLoadBegin() Handles pcb_Items.LoadBegin
		UseWaitCursor = True
	End Sub

	Private Sub ItemsLoadEnd() Handles pcb_Items.LoadEnd
		UseWaitCursor = False
	End Sub

	Private Function ChangesDetected() As Boolean
		If UpdatedOrder.Quantity <> CurrentOrder.Quantity Then
			Return True
		End If

		If UpdatedOrder.Product.Id <> CurrentOrder.Product.Id Then
			Return True
		End If

		Return False
	End Function

	Private Sub SelectedItemChanged(newValue As Integer) Handles pcb_Items.SelectedItemChanged
		If Not Utils.ValidID(newValue) OrElse pcb_Items.Disposing OrElse UpdatedOrder Is Nothing Then
			Return
		End If

		'UpdatedOrder.Product.UpdateID(newValue)
	End Sub

	Private Sub QuantityUpdated(newQuantity As Integer) Handles qnc_Quantity.QuantityChanged
		If newQuantity <= 0 OrElse UpdatedOrder Is Nothing Then
			Return
		End If

		UpdatedOrder.Quantity = newQuantity
	End Sub
End Class
