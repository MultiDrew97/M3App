Imports System.Collections.ObjectModel
Imports SPPBC.M3Tools.Types
Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace Database
	Public NotInheritable Class InventoryDatabase
		<EditorBrowsable()>
		<Description("The username to use for the database connection")>
		<SettingsBindable(True)>
		Public Property Username As String
			Get
				Return dbConnection.Username
			End Get
			Set(value As String)
				dbConnection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return dbConnection.Password
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
				dbConnection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property
		Public Function GetItem(itemID As Integer) As Item
			Return dbConnection.Consume(Of Item)(M3API.Method.Get, $"/inventory/{itemID}").Result
		End Function

		Public Function GetItems() As ItemCollection
			Return dbConnection.Consume(Of ItemCollection)(M3API.Method.Get, $"/inventory").Result
		End Function

		Public Sub AddItem(product As Item)
			AddItem(product.Name, product.Stock, product.Price)
		End Sub

		Public Sub AddItem(itemName As String, stock As Integer, price As Double)
			AddItem(
				New SqlParameter("ItemName", itemName),
				New SqlParameter("Stock", stock),
				New SqlParameter("Price", price),
				New SqlParameter("Available", If(stock > 0, 1, 0))
			)
		End Sub

		Private Sub AddItem(ParamArray params As SqlParameter())
			Throw New NotImplementedException("AddItem")
		End Sub


		Public Sub UpdateItem(item As Item)
			UpdateItem(item.Id, item.Name, item.Stock, item.Price, item.Available)
		End Sub

		Public Sub UpdateItem(itemID As Integer, itemName As String, stock As Integer, price As Double, available As Boolean)
			UpdateItem(New SqlParameter("ItemID", itemID), New SqlParameter("ItemName", itemName),
							New SqlParameter("Stock", stock), New SqlParameter("Price", price),
							New SqlParameter("Available", If(available, 1, 0)))
		End Sub

		Private Sub UpdateItem(ParamArray params As SqlParameter())
			Throw New NotImplementedException("UpdateItem")
		End Sub

		Public Sub RemoveItem(itemID As Integer)
			RemoveItem(New SqlParameter("ItemID", itemID))
		End Sub

		Private Sub RemoveItem(ParamArray params As SqlParameter())
			Throw New NotImplementedException("RemoveItem")
		End Sub

		Private Sub ChangeAvailability(ParamArray params As SqlParameter())
			Throw New NotImplementedException("ChangeAvailablity")
		End Sub



		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "ItemID"
			Shared ReadOnly Property Name As String = "ItemName"
			Shared ReadOnly Property Stock As String = "Stock"
			Shared ReadOnly Property Price As String = "Price"
			Shared ReadOnly Property Available As String = "Available"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace