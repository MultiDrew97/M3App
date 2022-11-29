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
				Return db_Connection.Username
			End Get
			Set(value As String)
				db_Connection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return db_Connection.Password
			End Get
			Set(value As String)
				db_Connection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property InitialCatalog As String
			Get
				Return db_Connection.InitialCatalog
			End Get
			Set(value As String)
				db_Connection.InitialCatalog = value
			End Set
		End Property

		Public Function GetOrders() As DBEntryCollection(Of Order)
			Dim orders As New DBEntryCollection(Of Order)

			Using cmd = db_Connection.Connect
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

				Using reader = cmd.ExecuteReader
					Do While reader.Read
						Dim completedDate As Date = Nothing

						Try
							completedDate = CDate(reader("CompletedDate"))
						Catch ex As Exception
							completedDate = Nothing
						End Try

						orders.Add(New Order(
								   CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
									CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")),
									completedDate))
					Loop
				End Using
			End Using

			Return orders
		End Function

		Public Function GetCompletedOrders() As DBEntryCollection(Of Order)
			' TODO: Test this to make sure it works properly
			Return CType(GetOrders().Where(Function(order As Order) As Boolean
											   Return order.CompletedDate.Year > 1950
										   End Function), DBEntryCollection(Of Order))
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

		Public Sub AddOrder(ParamArray params As SqlParameter())
			Using cmd = db_Connection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
				cmd.CommandType = CommandType.StoredProcedure

				cmd.Parameters.AddRange(params)

				' TODO: Verify if a return should happen
				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub UpdateOrder(orderID As Integer, quantity As Integer)
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			If quantity < 1 Then
				Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
			End If

			UpdateOrder(New SqlParameter("OrderID", orderID), New SqlParameter("Quantity", quantity))
		End Sub

		Private Sub UpdateOrder(ParamArray params As SqlParameter())
			Using cmd = db_Connection.Connect
				cmd.Parameters.AddRange(params)

				cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[{tableName}] SET QUANTITY = @Quantity WHERE OrderID = @OrderID"
				Throw New Exceptions.DatabaseException("Update Order not implemented yet")
				'myCmd.ExecuteNonQuery()
			End Using
		End Sub

		Public Sub CancelOrder(orderID As Integer)
			If Not Utils.ValidID(orderID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			CancelOrder(New SqlParameter("OrderID", orderID))
		End Sub

		Private Sub CancelOrder(ParamArray params As SqlParameter())
			Using cmd = db_Connection.Connect
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
			Using cmd = db_Connection.Connect
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

			Using cmd = db_Connection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] WHERE OrderID=@OrderID"
				cmd.Parameters.AddWithValue("OrderID", orderID)

				Using reader = cmd.ExecuteReader()
					If Not reader.Read() Then
						Throw New Exceptions.OrderNotFoundException($"No order with OrderID '{orderID}' was found")
					End If

					'If CDate(reader("CompletedDate")).Year < 1901 Then
					'	Return New Order(
					'		CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
					'		CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")))
					'Else
					' TODO: Verify NULL from tf won't break this
					Dim completedDate As Date = Nothing

					Try
						completedDate = CDate(reader("CompletedDate"))
					Catch ex As Exception
						completedDate = Nothing
					End Try

					Return New Order(
								   CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
									CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")),
									completedDate)
					'End If
				End Using
			End Using

			Throw New Exceptions.ConnectionException("Failed to connect to database")
		End Function

		Public Function GetOrderByCustomer(customerID As Integer) As DBEntryCollection(Of Order)
			Dim orders As New DBEntryCollection(Of Order)
			If customerID < 0 Then
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			Using cmd = db_Connection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] WHERE CustomerID=@CustomerID"
				cmd.Parameters.AddWithValue("CustomerID", customerID)

				Using reader = cmd.ExecuteReader()
					While reader.Read()
						Dim compDate As Date = CDate(reader("CompletedDate"))
						If CDate(reader("CompletedDate")).Year < 1901 Then
							orders.Add(New Order(
							CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
							CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate"))))
						Else
							orders.Add(New Order(CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
							CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")), CDate(reader("CompletedDate"))))
						End If
					End While

				End Using
			End Using

			Return orders
		End Function
	End Class
End Namespace