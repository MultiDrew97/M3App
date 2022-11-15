Option Strict On
Namespace Types
    Public Class CurrentOrder
        Public Property Id As Integer
		Public Property Customer As Person
		Public Property Item As Item
		Public Property Quantity As Integer
        Public Property OrderTotal As Double
        Public Property OrderDate As Date

        Public Sub New()
			Me.New(-1, -1, -1, 0, 0, Date.Now)
		End Sub

		''' <summary>
		''' New CurrentOrder Object
		''' </summary>
		''' <param name="orderID"></param>
		''' <param name="customerID"></param>
		''' <param name="itemID"></param>
		''' <param name="quantity"></param>
		''' <param name="orderTotal"></param>
		''' <param name="orderDate"></param>
		Public Sub New(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer, orderTotal As Double, orderDate As Date)
			Me.Id = orderID
			Me.Quantity = quantity
			Me.OrderTotal = orderTotal
			Me.OrderDate = orderDate

			If customerID > -1 Then
				GetCustomer(customerID)
			End If

			If itemID > -1 Then
				GetItem(itemID)
			End If
		End Sub

		''' <summary>
		''' New CurrentOrder Object
		''' </summary>
		''' <param name="orderID"></param>
		''' <param name="customerID"></param>
		''' <param name="customerName"></param>
		''' <param name="itemID"></param>
		''' <param name="itemName"></param>
		''' <param name="quantity"></param>
		''' <param name="orderTotal"></param>
		''' <param name="orderDate"></param>
		Public Sub New(orderID As Integer, customerID As Integer, customerName As String(), itemID As Integer, itemName As String, quantity As Integer, orderTotal As Double, orderDate As Date)
			Me.Id = orderID
			Me.Customer = New Person(customerID, String.Join(" ", customerName))
			Me.Item = New Item(itemID, itemName)
			Me.Quantity = quantity
			Me.OrderTotal = orderTotal
			Me.OrderDate = orderDate
		End Sub

		''' <summary>
		''' Retrieve a user from the database using their CustomerID
		''' </summary>
		''' <param name="customerID">CustomerID of the desired customer</param>
		Private Async Sub GetCustomer(customerID As Integer)
			Using db As New Database.Database(My.Settings.DefaultUsername, My.Settings.DefaultPassword, My.Settings.DefaultCatalog)
				Using cmd = db.Connect
					cmd.CommandText = $"SELECT FirstName, LastName FROM Customers WHERE CustomerID=@CustomerID"
					cmd.CommandType = CommandType.Text

					cmd.Parameters.AddWithValue("CustomerID", customerID)

					Using reader = Await cmd.ExecuteReaderAsync
						reader.Read()

						Me.Customer = New Person(
							customerID,
							reader.GetString(reader.GetOrdinal("FirstName")),
							reader.GetString(reader.GetOrdinal("LastName"))
						)
					End Using
				End Using
			End Using
		End Sub

		''' <summary>
		''' Retrieve an item from the database using the provided itemID
		''' </summary>
		''' <param name="itemID">ItemID of the desired item</param>
		Private Async Sub GetItem(itemID As Integer)
			Using db As New Database.Database(My.Settings.DefaultUsername, My.Settings.DefaultPassword, My.Settings.DefaultCatalog)
				Using cmd = db.Connect
					cmd.CommandText = "SELECT ItemName FROM Inventory WHERE ItemID=@ItemID"
					cmd.CommandType = CommandType.Text

					cmd.Parameters.AddWithValue("ItemID", itemID)

					Using reader = Await cmd.ExecuteReaderAsync
						reader.Read()

						Me.Item = New Item(
							itemID,
							reader.GetString(reader.GetOrdinal("ItemName"))
						)
					End Using
				End Using
			End Using
		End Sub
	End Class
End Namespace