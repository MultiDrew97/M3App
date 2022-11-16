Option Strict On
Namespace Types
    ' TODO: Consolidate CurrentOrder and CompletedOrder
    Public Class Order
        Inherits DBEntry

        Public Property Customer As Person
        Public Property Product As Item
        Public Property Quantity As Integer
        Public Property OrderTotal As Double
        Public Property OrderDate As Date
        Public Property CompletedDate As Date

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
            MyBase.New(orderID)
            Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = orderDate

            If customerID > -1 Then
                GetItem(itemID)
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
            Me.Product = New Item(itemID, itemName)
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
                    cmd.CommandText = $"SELECT FirstName, LastName FROM [{My.Settings.Schema}].[Customers] WHERE CustomerID=@CustomerID"
                    End If
                    cmd.CommandType = CommandType.Text

                    cmd.Parameters.AddWithValue("CustomerID", customerID)

                    Using reader = Await cmd.ExecuteReaderAsync
                        reader.Read()
                        cmd.Parameters.AddWithValue("CustomerID", customerID)

                        Using reader = cmd.ExecuteReader
                            If Not reader.Read() Then
                                Throw New Exceptions.CustomerNotFoundException($"Unable to find customer with ID {customerID}")
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
                    cmd.CommandText = $"SELECT ItemName FROM [{My.Settings.Schema}].[Items] WHERE ItemID=@ItemID"
                    cmd.CommandType = CommandType.Text

                    cmd.Parameters.AddWithValue("ItemID", itemID)

                    Using reader = Await cmd.ExecuteReaderAsync
                        reader.Read()

                        Me.Product = New Item(itemID, CStr(reader("ItemName")))
                    End Using
                End Using
            End Using
        End Sub
    End Class
End Namespace