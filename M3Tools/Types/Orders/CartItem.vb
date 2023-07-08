Namespace Types
	Public Class CartItem
		Private Property Product As Product
		Public Property Quantity As Integer

		ReadOnly Property ItemTotal As Double
			Get
				Return Me.Product.Price * Me.Quantity
			End Get
		End Property

		Public ReadOnly Property ItemName As String
			Get
				Return Product.Name
			End Get
		End Property

		Public ReadOnly Property ItemID As Integer
			Get
				Return Product.Id
			End Get
		End Property

		Public ReadOnly Property ItemPrice As Double
			Get
				Return Product.Price
			End Get
		End Property

		Public Sub New()
			Me.New(New Product(), 0)
		End Sub

		Public Sub New(product As Product, quantity As Integer)
			Me.Product = product
			Me.Quantity = quantity
		End Sub
	End Class
End Namespace