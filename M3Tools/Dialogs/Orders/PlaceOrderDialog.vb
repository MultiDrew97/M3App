Imports System.Collections.ObjectModel
Imports System.Windows.Forms

Public Class PlaceOrderDialog
	Private _cart As New Collection(Of CartItem)

	Private ReadOnly Property Cart As Collection(Of CartItem)
		Get
			Return _cart
		End Get
	End Property

	ReadOnly Property OrderTotal As Double
		Get
			Dim sum As Double = 0

			For Each item In Cart
				sum += (item.Item.Price * item.Quantity)
			Next

			Return sum
		End Get
	End Property

	Private Sub Checkout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Checkout.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub DialogLoading(sender As Object, e As EventArgs) Handles Me.Load
		ccb_Customers.Reload()
		pcb_Items.Reload()
	End Sub

	Private Sub AddToCart(sender As Object, e As EventArgs) Handles btn_AddCart.Click
		Cart.Add(New CartItem(CType(pcb_Items.SelectedItem, Types.Product), QuantityNudCtrl1.Quantity))

		' Update Order Total display
		txt_Total.Text = String.Format("{0:C2}", OrderTotal)
	End Sub
End Class

Friend Class CartItem
	Private _item As Types.Product
	Private _quantity As Integer

	Property Item As Types.Product
		Get
			Return _item
		End Get
		Set(value As Types.Product)
			_item = value
		End Set
	End Property
	Property Quantity As Integer
		Get
			Return _quantity
		End Get
		Set(value As Integer)
			_quantity = value
		End Set
	End Property

	Public Sub New(item As Types.Product, quantity As Integer)
		Me.Item = item
		Me.Quantity = quantity
	End Sub
End Class
