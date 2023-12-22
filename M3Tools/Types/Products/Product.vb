Option Strict On
Namespace Types
	Public Class Product
		Inherits DbEntry

		<ComponentModel.Browsable(False)>
		<Text.Json.Serialization.JsonPropertyName("itemID")>
		Public Overrides Property Id As Integer

		<Text.Json.Serialization.JsonPropertyName("itemName")>
		Public Property Name As String

		<Text.Json.Serialization.JsonPropertyName("stock")>
		Public Property Stock As Integer

		<Text.Json.Serialization.JsonPropertyName("price")>
		Public Property Price As Double

		<Text.Json.Serialization.JsonPropertyName("available")>
		Public Property Available As Boolean

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(id As Integer, Optional name As String = "New Product", Optional stock As Integer = 0, Optional price As Double = 0, Optional available As Boolean = False)
			Me.Id = id
			Me.Name = name
			Me.Stock = stock
			Me.Price = price
			Me.Available = available
		End Sub

		Public Function Display() As String
			Return $"{Id}) {Name} ({Price:c}) {If(Available, "Available", "Not Available")}"
		End Function

		Public Overrides Function ToString() As String
			Return String.Join(My.Settings.ObjectDelimiter, Id, Name, Stock, Price, If(Available, "Available", "Not Available"))
		End Function
	End Class
End Namespace
