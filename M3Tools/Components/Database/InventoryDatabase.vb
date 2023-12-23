Imports SPPBC.M3Tools.Types
Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace Database
	Public NotInheritable Class InventoryDatabase
		Private Const path As String = "inventory"

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
			End Get
			Set(value As String)
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

		Public Function GetProduct(itemID As Integer) As Product
			Return dbConnection.Consume(Of Product)(M3API.Method.Get, $"/{path}/{itemID}").Result
		End Function

		Public Function GetProducts() As DBEntryCollection(Of Product)
			Return dbConnection.Consume(Of DBEntryCollection(Of Product))(Method.Get, $"/{path}").Result
		End Function

		Public Sub AddProduct(itemName As String, stock As Integer, price As Decimal)
			AddProduct(New Product(-1, itemName, stock, price, True))
		End Sub

		Public Sub AddProduct(item As Product)
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(item))
		End Sub

		Public Sub UpdateProduct(itemID As Integer, itemName As String, stock As Integer, price As Decimal, available As Boolean)
			UpdateProduct(New Product(itemID, itemName, stock, price, available))
		End Sub

		Public Sub UpdateProduct(item As Product)
			dbConnection.Consume(Method.Put, $"/{path}/{item.Id}", JSON.ConvertToJSON(item))
		End Sub

		Public Sub RemoveProduct(itemID As Integer)
			dbConnection.Consume(Method.Put, $"/{path}/{itemID}")
		End Sub

		Private Sub ChangeAvailability(ParamArray params As SqlParameter())
			Throw New NotImplementedException("ChangeAvailablity")
		End Sub
	End Class
End Namespace
