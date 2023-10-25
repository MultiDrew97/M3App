Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class OrdersDatabase
		Private Const path As String = "orders"

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
			End Get
			Set(value As String)
				dbConnection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
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

		Public Function GetOrders() As OrderCollection
			Return dbConnection.Consume(Of OrderCollection)(M3API.Method.Get, $"/orders").Result
		End Function

		Public Function GetCompletedOrders() As OrderCollection
			' TODO: Test this to make sure it works properly
			Return CType(GetOrders().Where(Function(order As Order) As Boolean
											   Return order.CompletedDate.Year > 2000
										   End Function), OrderCollection)
		End Function

		Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
			If Not Utils.ValidID(customerID) Or Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			If quantity < 1 Then
				Throw New ArgumentException("Quantity values must be greater than or equal to 1")
			End If

			'insert the order into the ORDERS table
			AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})
		End Sub

		Private Sub AddOrder(ParamArray params As SqlParameter())
			Throw New NotImplementedException("AddOrder")
		End Sub

		Public Sub UpdateOrder(order As Order)
			UpdateOrder(order.Id, order.Item.Id, order.Quantity)
		End Sub

		Public Sub UpdateOrder(orderID As Integer, itemID As Integer, quantity As Integer)
			If Not Utils.ValidID(orderID) OrElse Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			If quantity < 1 Then
				Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
			End If

			UpdateOrder(New SqlParameter("OrderID", orderID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity))
		End Sub

		Private Sub UpdateOrder(ParamArray params As SqlParameter())
			Throw New NotImplementedException("UpdateOrder")
		End Sub

		Public Sub CancelOrder(orderID As Integer)
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			CancelOrder(New SqlParameter("OrderID", orderID))
		End Sub

		Private Sub CancelOrder(ParamArray params As SqlParameter())
			Throw New NotImplementedException("CancelOrder")
		End Sub

		Public Sub CompleteOrder(orderID As Integer)
			If orderID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
		End Sub

		Private Sub CompleteOrder(ParamArray params As SqlParameter())
			Throw New NotImplementedException("CompleteOrder")
		End Sub

		Public Function GetOrderById(orderID As Integer) As Order
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Return dbConnection.Consume(Of Order)(M3API.Method.Get, $"/orders/{orderID}").Result
		End Function

		Public Function GetOrderByCustomer(customerID As Integer) As OrderCollection
			If customerID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Throw New NotImplementedException("GetOrderByCustomer")
		End Function



		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "OrderID"
			Shared ReadOnly Property Customer As String = "CustomerID"
			Shared ReadOnly Property Item As String = "ItemID"
			Shared ReadOnly Property Quantity As String = "Quantity"
			Shared ReadOnly Property Total As String = "OrderTotal"
			Shared ReadOnly Property PlacedDate As String = "OrderDate"
			Shared ReadOnly Property CompletedDate As String = "CompletedDate"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace