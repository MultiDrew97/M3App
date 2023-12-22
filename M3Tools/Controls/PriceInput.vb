Public Class PriceInput
	<ComponentModel.DefaultValue(0)>
	Public Property Price As Double
		Get
			Return CDec(txt_Price.Text)
		End Get
		Set(value As Double)
			txt_Price.Text = value.FormatPrice
		End Set
	End Property

	Sub FormatText() Handles txt_Price.LostFocus
		txt_Price.Text = String.Format("{0:C2}", Price)
	End Sub
End Class
