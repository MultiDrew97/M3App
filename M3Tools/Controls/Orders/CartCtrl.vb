Imports System.ComponentModel
Imports System.Windows.Forms

Public Class CartCtrl
	' TODO: Turn into component?
	Event ItemAdded(total As Double)
	Event ItemUpdated(item As Types.CartItem)

	ReadOnly Property Cart As BindingList(Of Types.CartItem)
		Get
			Return CType(bsCart.List, BindingList(Of Types.CartItem))
		End Get
	End Property

	ReadOnly Property Total As Double
		Get
			Dim sum As Double

			For Each item In Cart
				sum += item.ItemTotal
			Next

			Return sum
		End Get
	End Property

	Public Sub Add(item As Types.Item, quantity As Integer)
		Me.Add(New Types.CartItem(item, quantity))
	End Sub

	Private Sub Add(item As Types.CartItem)
		Dim i = FindItem(item)
		If i > -1 Then
			Dim curr = CType(bsCart(i), Types.CartItem)

			curr.Quantity += item.Quantity
		Else
			bsCart.Add(item)
		End If

		RaiseEvent ItemAdded(Total)
	End Sub

	Public Sub AddRange(ParamArray items As Types.CartItem())
		For Each item In items
			Add(item)
		Next
	End Sub

	Private Sub CartLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsCart.Clear()
	End Sub

	Private Sub Reload(total As Double) Handles Me.ItemAdded
		dgv_Cart.Refresh()
	End Sub

	Private Sub Temp(item As Types.CartItem) Handles Me.ItemUpdated
		RaiseEvent ItemAdded(Total)
	End Sub

	Private Sub ItemValuesUpdated(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Cart.CellValueChanged
		If e.RowIndex < 0 Then
			Return
		End If

		RaiseEvent ItemUpdated(CType(bsCart.Item(e.RowIndex), Types.CartItem))
	End Sub

	Private Sub RemoveItem(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Cart.CellContentClick
		If e.RowIndex < 0 OrElse e.ColumnIndex < 0 OrElse Not e.ColumnIndex = dgc_Remove.DisplayIndex Then
			Return
		End If
		Dim removed = CType(bsCart(e.RowIndex), Types.CartItem)
		bsCart.Remove(removed)
		RaiseEvent ItemUpdated(removed)
	End Sub

	Private Function FindItem(item As Types.CartItem) As Integer
		For Each current In Cart
			If current.ItemID = item.ItemID Then
				Return bsCart.IndexOf(current)
			End If
		Next

		Return -1
	End Function
End Class
