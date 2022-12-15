Public Class QuantityNudCtrl
	Public Event QuantityChanged(newQuantity As Integer)

	Property Quantity As Integer
		Get
			Return CInt(nud_Quantity.Value)
		End Get
		Set(value As Integer)
			nud_Quantity.Value = value
		End Set
	End Property

	Private Sub QuantityValueChanged(sender As Object, e As EventArgs) Handles nud_Quantity.ValueChanged
		RaiseEvent QuantityChanged(Quantity)
	End Sub
End Class
