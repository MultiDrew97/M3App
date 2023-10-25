Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class PlaceOrderDialog
	Private Event CartItemAdded()

	'Private ReadOnly Property Cart As New Collection(Of Types.CartItem)

	ReadOnly Property OrderTotal As Double
		Get
			Dim sum As Double = 0

			For Each item In cc_Cart.Cart
				sum += (item.ItemTotal)
			Next

			Return sum
		End Get
	End Property

	Private Sub Reload()
		ccb_Customers.Reload()
		pcb_Items.Reload()
		qnc_Quantity.Quantity = 1
		otc_Total.Total = 0
	End Sub

	Private Sub Checkout(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Checkout.Click
		Dim selectedCustomer = CType(ccb_Customers.SelectedItem, Types.Customer)
		Dim response = MessageBox.Show($"Are you sure you want to place an order for {selectedCustomer.Name}?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If response = DialogResult.No Then
			Return
		End If

		bw_PlaceOrders.RunWorkerAsync(selectedCustomer.Id)
	End Sub

	Private Sub Cancel(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancel.Click
		Dim res = MessageBox.Show("Are you sure you want to cancel placing this order?", "Cancel Order Placement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

		If res = DialogResult.No Then
			Return
		End If

		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub DialogLoading(sender As Object, e As EventArgs) Handles Me.Load
		Reload()
	End Sub

	Private Sub AddToCart(sender As Object, e As EventArgs) Handles btn_AddCart.Click
		cc_Cart.Add(CType(pcb_Items.SelectedItem, Types.Item), qnc_Quantity.Quantity)

		RaiseEvent CartItemAdded()
	End Sub

	Private Sub ItemAdded(total As Double) Handles cc_Cart.ItemAdded
		otc_Total.Total = total
	End Sub

	Private Sub PlaceOrders(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_PlaceOrders.DoWork
		Dim customerID = CInt(e.Argument)
		Dim failedOrders As Integer = 0
		For Each item In cc_Cart.Cart
			Try
				db_Orders.AddOrder(customerID, item.ItemID, item.Quantity)
			Catch ex As Exception
				failedOrders += 1
			End Try
		Next

		e.Result = failedOrders
	End Sub

	Private Sub OrdersPlaced(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_PlaceOrders.RunWorkerCompleted
		Dim failed = CInt(e.Result)
		If e.Cancelled Then
			Return
		End If

		If failed > 0 Then
			MessageBox.Show($"{failed} order{If(failed > 1, "s were", "was")} unable to be placed. Please check the orders panel to see which items were not added and try again.", "Order Failures", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		Dim res = MessageBox.Show("Would you like to place any more orders?", "More Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If res = DialogResult.No Then
			Me.Close()
			Return
		End If

		Reload()
	End Sub
End Class
