Option Strict On
Namespace Types
    Public Class CurrentOrder
        Public Property Id As Integer
        Public Property Customer As Customer
        Public Property Item As Product
        Public Property Quantity As Integer
        Public Property OrderTotal As Double
        Public Property OrderDate As Date

        Public Sub New()
            Me.New(-1, -1, {"John", "Doe"}, -1, "No Item", 0, 0.0, Date.Now)
        End Sub

        Public Sub New(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer, orderTotal As Double, ordered As Date)
            Me.Id = orderID
            Me.Customer = New Customer(customerID, "", "", "", "", "", "", "", "")
            Me.Item = New Product(itemID, "", 0, 0, True)
            Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = ordered
        End Sub

        Public Sub New(orderID As Integer, customerID As Integer, customerName As String(), itemID As Integer, itemName As String, quantity As Integer, orderTotal As Double, ordered As Date)
            Me.Id = orderID
            Me.Customer = New Customer() With {
                .Id = customerID,
                .FirstName = customerName(0),
                .LastName = customerName(1)
            }
            Me.Item = New Product() With {
                .Id = itemID,
                .Name = itemName
            }
            Me.Quantity = quantity
            Me.OrderTotal = orderTotal
            Me.OrderDate = ordered
        End Sub

        'Private Sub GetCustomer(customerID As Integer)
        '    Using db As New Database
        '        Customer = db.GetCustomerInfo(customerID)
        '    End Using
        'End Sub

        'Private Sub GetItem(itemID As Integer)
        '    Using db As New Database
        '        Item = db.GetProductInfo(itemID)
        '    End Using
        'End Sub
    End Class
End Namespace