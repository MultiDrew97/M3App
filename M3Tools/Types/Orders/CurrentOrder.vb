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
			Me.New(-1, -1, {"John", "Doe"}, -1, "No Item", 0, 0, Date.Now)
		End Sub

        Public Sub New(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer, orderTotal As Double, ordered As Date)
			Me.Id = orderID
			'Me.Customer = New Customer(customerID, "", "", "", "", "", "", "", "")
			'Me.Item = New Item(itemID, "")
			Me.Quantity = quantity
			Me.OrderTotal = orderTotal
			Me.OrderDate = ordered
			GetCustomer(customerID)
			GetItem(itemID)
		End Sub

        Public Sub New(orderID As Integer, customerID As Integer, customerName As String(), itemID As Integer, itemName As String, quantity As Integer, orderTotal As Double, ordered As Date)
            Me.Id = orderID
			Me.Customer = New Person(customerID, String.Join(" ", customerName))
			Me.Item = New Item(itemID, itemName)
			Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = ordered
        End Sub

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

		Private Async Sub GetItem(itemID As Integer)
			Using db As New Database.Database(My.Settings.DefaultUsername, My.Settings.DefaultPassword, My.Settings.DefaultCatalog)
				Using cmd = db.Connect
					cmd.CommandText = $"SELECT ItemName FROM Customers WHERE ItemID=@ItemID"
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