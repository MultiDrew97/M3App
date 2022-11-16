Public Class QuantityNudCtrl
	Property Quantity As Integer
		Get
			Return CInt(nud_Quantity.Value)
		End Get
		Set(value As Integer)
			nud_Quantity.Value = value
		End Set
	End Property
End Class
