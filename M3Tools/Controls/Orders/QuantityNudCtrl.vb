Public Class QuantityNudCtrl
	Public Event QuantityChanged(newQuantity As Integer)

	<ComponentModel.DefaultValue(0)>
	Public Property MinimumValue As Integer
		Get
			Return CInt(nud_Quantity.Minimum)
		End Get
		Set(value As Integer)
			nud_Quantity.Minimum = If(value < 0, 0, value)
		End Set
	End Property

	<ComponentModel.DefaultValue(Integer.MaxValue)>
	Public Property MaximumValue As Integer
		Get
			Return CInt(nud_Quantity.Maximum)
		End Get
		Set(value As Integer)
			nud_Quantity.Maximum = If(value > Integer.MaxValue, Integer.MaxValue, value)
		End Set
	End Property

	<ComponentModel.DefaultValue("Quantity")>
	Public Property Label As String
		Get
			Return lbl_Quantity.Text
		End Get
		Set(value As String)
			lbl_Quantity.Text = value
		End Set
	End Property

	<ComponentModel.DefaultValue(0)>
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
