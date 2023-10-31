Option Strict On
Namespace Types
	Public Class Item
		Inherits DbEntry

		<Text.Json.Serialization.JsonPropertyName("itemID")>
		Overrides Property Id As Integer

		<Text.Json.Serialization.JsonPropertyName("itemName")>
		Public Property Name As String

		<Text.Json.Serialization.JsonPropertyName("stock")>
		Public Property Stock As Integer

		<Text.Json.Serialization.JsonPropertyName("price")>
		Public Property Price As Double

		<Text.Json.Serialization.JsonPropertyName("available")>
		Public Property Available As Boolean

		Public Sub New()
			Me.New(1, "New Product", 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String)
			Me.New(id, name, 0, 0, True)
		End Sub

		Public Sub New(id As Integer, name As String, stock As Integer, price As Double, available As Boolean)
			Me.Id = id
			Me.Name = name
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
	End Class
End Namespace