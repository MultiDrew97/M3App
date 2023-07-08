Public Class OrderTotalCtrl
	Private Event TotalChanged()
	Public Property Total As Double
		Get
			Return CDbl(txt_Total.Text.Replace("$", ""))
		End Get
		Set(value As Double)
			txt_Total.Text = $"{value}"
			RaiseEvent TotalChanged()
		End Set
	End Property

	Private Sub UpdateTotal() Handles Me.TotalChanged
		txt_Total.Text = $"{CDec($"0{Total}"):C2}"
	End Sub
End Class
