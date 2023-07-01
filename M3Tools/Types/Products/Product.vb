Option Strict On
Namespace Types
    Public Class Product
        Inherits Item
        Public Property Stock As Integer
        Public Property Price As Double
        Public Property Available As Boolean

        Public Sub New()
			Me.New(1, "New Product", 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String)
			Me.New(id, name, 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String, stock As Integer, price As Double, available As Boolean)
			MyBase.New(id, name)
			Me.Stock = stock
			Me.Price = price
			Me.Available = available
		End Sub

		Public Function Display() As String
			Return $"{Id}) {Name} ({Price}) {If(Available, "Available", "Not Available")}"
		End Function

		Public Overrides Function ToString() As String
			Return String.Join(My.Settings.ObjectDelimiter, Id, Name, Stock, Price, If(Available, "Available", "Not Available"))
		End Function

		'Public Overrides Sub UpdateID(newID As Integer)
		'	If newID = Id Then
		'		Return
		'	End If

		'	Using conn As New Database.ProductDatabase
		'		Dim newProduct = conn.GetProduct(newID)

		'		Id = newID
		'		Name = newProduct.Name
		'		Stock = newProduct.Stock
		'		Price = newProduct.Price
		'		Available = newProduct.Available
		'	End Using
		'End Sub
	End Class
End Namespace