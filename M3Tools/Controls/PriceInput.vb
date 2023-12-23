Public Class PriceInput

	<ComponentModel.DefaultValue("Price")>
	Public Property Label As String
		Get
			Return lbl_Price.Text
		End Get
		Set(value As String)
			lbl_Price.Text = value
		End Set
	End Property

	<ComponentModel.DefaultValue(0)>
	Public Property Price As Decimal
		Get
			Return CDec(txt_Price.Text)
		End Get
		Set(value As Decimal)
			txt_Price.Text = value.FormatPrice
		End Set
	End Property

	Private Sub FormatText() Handles txt_Price.LostFocus
		txt_Price.Text = Price.FormatPrice
	End Sub
End Class
