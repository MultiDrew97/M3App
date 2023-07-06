Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class OrdersDatabase
		Private ReadOnly tableName As String = "Orders"
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
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property InitialCatalog As String
			Get
				Return dbConnection.InitialCatalog
			End Get
			Set(value As String)
				dbConnection.InitialCatalog = value
			End Set
		End Property

		Public Function GetOrders() As OrderCollection
			Dim orders As New OrderCollection()

			Using cmd = dbConnection.Connect
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

				Using reader = cmd.ExecuteReader
					Do While reader.Read
						orders.Add(New Order(CInt(reader(ColumnNames.ID)), CInt(reader(ColumnNames.Customer)),
											 CInt(reader(ColumnNames.Item)), CInt(reader(ColumnNames.Quantity)),
											 CDec(reader(ColumnNames.Total)), CDate(reader(ColumnNames.PlacedDate)),
											 Utils.TryDateCast(reader(ColumnNames.CompletedDate))))
					Loop
				End Using
			End Using

			Return orders
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
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
				cmd.CommandType = CommandType.StoredProcedure

				cmd.Parameters.AddRange(params)

				' TODO: Verify if a return should happen
				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub UpdateOrder(order As Order)
			UpdateOrder(order.Id, order.Product.Id, order.Quantity)
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
			Using cmd = dbConnection.Connect
				cmd.Parameters.AddRange(params)

				cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[{tableName}] SET QUANTITY=@Quantity, ItemID=@ItemID WHERE OrderID = @OrderID"

				cmd.ExecuteNonQuery()

				'Throw New Exceptions.DatabaseException("Update Order not implemented yet")
			End Using
		End Sub

		Public Sub CancelOrder(orderID As Integer)
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			CancelOrder(New SqlParameter("OrderID", orderID))
		End Sub

		Private Sub CancelOrder(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_CancelOrder]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub CompleteOrder(orderID As Integer)
			If orderID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
		End Sub

		Private Sub CompleteOrder(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_CompleteOrder]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Function GetOrderById(orderID As Integer) As Order
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Using cmd = dbConnection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] WHERE OrderID=@OrderID"
				cmd.Parameters.AddWithValue("OrderID", orderID)

				Using reader = cmd.ExecuteReader()
					If Not reader.Read() Then
						Throw New Exceptions.OrderNotFoundException($"No order with OrderID '{orderID}' was found")
					End If

					Return New Order(CInt(reader(ColumnNames.ID)), CInt(reader(ColumnNames.Customer)),
											 CInt(reader(ColumnNames.Item)), CInt(reader(ColumnNames.Quantity)),
											 CDec(reader(ColumnNames.Total)), CDate(reader(ColumnNames.PlacedDate)),
											 Utils.TryDateCast(reader(ColumnNames.CompletedDate)))
				End Using
			End Using

			Throw New Exceptions.ConnectionException("Failed to connect to database")
		End Function

		Public Function GetOrderByCustomer(customerID As Integer) As OrderCollection
			Dim orders As New OrderCollection()
			If customerID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Using cmd = dbConnection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] WHERE CustomerID=@CustomerID"
				cmd.Parameters.AddWithValue("CustomerID", customerID)

				Using reader = cmd.ExecuteReader()
					While reader.Read()
						orders.Add(New Order(CInt(reader(ColumnNames.ID)), CInt(reader(ColumnNames.Customer)),
											 CInt(reader(ColumnNames.Item)), CInt(reader(ColumnNames.Quantity)),
											 CDec(reader(ColumnNames.Total)), CDate(reader(ColumnNames.PlacedDate)),
											 Utils.TryDateCast(reader(ColumnNames.CompletedDate))))
					End While

				End Using
			End Using

			Return orders
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