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
        Public Sub New(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer, orderTotal As Double, orderDate As Date, Optional completedDate As Date = Nothing)
            MyBase.New(orderID)
            Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = orderDate
            Me.CompletedDate = completedDate
            GetCustomer(customerID)
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
        ''' <param name="completedDate"></param>
        Public Sub New(orderID As Integer, customerID As Integer, customerName As String(), itemID As Integer, itemName As String, quantity As Integer, orderTotal As Double, orderDate As Date, Optional completedDate As Date = Nothing)
            Me.Id = orderID
            Me.Customer = New Person(customerID, String.Join(" ", customerName))
            Me.Product = New Item(itemID, itemName)
            Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = orderDate

            If completedDate.Year > 1900 Then
                Me.CompletedDate = completedDate
            End If
        End Sub

        ''' <summary>
        ''' Retrieve a user from the database using their CustomerID
        ''' </summary>
        ''' <param name="customerID">CustomerID of the desired customer</param>
        Private Sub GetCustomer(customerID As Integer)
			If Not Utils.ValidID(customerID) Then
				Exit Sub
			End If

			Using db As New Database.Database(My.Settings.DefaultUsername, My.Settings.DefaultPassword, My.Settings.DefaultCatalog)
                Using cmd = db.Connect
					cmd.CommandText = $"SELECT FirstName, LastName, Email FROM [{My.Settings.Schema}].[Customers] WHERE CustomerID=@CustomerID"
					cmd.CommandType = CommandType.Text

                    cmd.Parameters.AddWithValue("CustomerID", customerID)

                    Using reader = cmd.ExecuteReader
                        If Not reader.Read() Then
                            Throw New Exceptions.CustomerNotFoundException($"Unable to find customer with ID {customerID}")
                        End If

						Me.Customer = New Person(customerID, CStr(reader("FirstName")), CStr(reader("LastName")), TryCast(reader("Email"), String))
					End Using
                End Using
            End Using
        End Sub

        ''' <summary>
        ''' Retrieve an item from the database using the provided itemID
        ''' </summary>
        ''' <param name="itemID">ItemID of the desired item</param>
        Private Sub GetItem(itemID As Integer)
			If Not Utils.ValidID(itemID) Then
				Exit Sub
			End If

			Using db As New Database.Database(My.Settings.DefaultUsername, My.Settings.DefaultPassword, My.Settings.DefaultCatalog)
                Using cmd = db.Connect
                    cmd.CommandText = $"SELECT ItemName FROM [{My.Settings.Schema}].[Items] WHERE ItemID=@ItemID"
                    cmd.CommandType = CommandType.Text

                    cmd.Parameters.AddWithValue("ItemID", itemID)

                    Using reader = cmd.ExecuteReader
                        If Not reader.Read() Then
                            Throw New Exceptions.ItemNotFoundException($"Unable to find Item with ID {itemID}")
                        End If

                        Me.Product = New Item(itemID, CStr(reader("ItemName")))
                    End Using
                End Using
            End Using
        End Sub
    End Class
End Namespace