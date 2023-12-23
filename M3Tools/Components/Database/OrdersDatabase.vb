Imports System.ComponentModel
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class OrdersDatabase
		Private Const path As String = "orders"

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

		<Bindable(True)>
		<Description("The url to use for the database connection")>
		<SettingsBindable(True)>
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property

		Public Function GetOrders() As DBEntryCollection(Of Order)
			Return dbConnection.Consume(Of DBEntryCollection(Of Order))(Method.Get, $"/{path}").Result
		End Function

		Public Function GetCompletedOrders() As DBEntryCollection(Of Order)
			' TODO: Test this to make sure it works properly
			Return CType(GetOrders().Where(Function(order As Order) As Boolean
											   Return order.CompletedDate.Year > 2000
										   End Function), DBEntryCollection(Of Order))
		End Function

		Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
			If Not Utils.ValidID(customerID) Or Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			If quantity < 1 Then
				Throw New ArgumentException("Quantity values must be greater than or equal to 1")
			End If

			AddOrder(New Order(-1, customerID, itemID, quantity))
		End Sub

		Public Sub AddOrder(order As Order)
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(order))
		End Sub

		Public Sub UpdateOrder(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer)
			If Not Utils.ValidID(orderID) OrElse Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			If quantity < 1 Then
				Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
			End If

			UpdateOrder(New Order(orderID, customerID, itemID, quantity))
		End Sub

		Public Sub UpdateOrder(order As Order)
			dbConnection.Consume(Method.Put, $"/{path}/{order.Id}", JSON.ConvertToJSON(order))
		End Sub

		Public Sub CancelOrder(orderID As Integer)
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			RemoveOrder(orderID, False)
		End Sub

		Public Sub CompleteOrder(orderID As Integer)
			If orderID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			RemoveOrder(orderID, True)
		End Sub

		Private Sub RemoveOrder(orderID As Integer, completed As Boolean)
			dbConnection.Consume(Method.Put, $"/{path}/{orderID}?force={completed}")
		End Sub

		Public Function GetOrderById(orderID As Integer) As Order
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Return dbConnection.Consume(Of Order)(M3API.Method.Get, $"/orders/{orderID}").Result
		End Function

		' TODO: Likely create a custom API path to search by customerID instead of orderID
		Public Function GetOrderByCustomer(customerID As Integer) As DBEntryCollection(Of Order)
			If customerID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Return CType(GetOrders().Where(Function(order As Order)
											   Return order.Customer.Id = customerID
										   End Function), DBEntryCollection(Of Order))
		End Function
	End Class
End Namespace
