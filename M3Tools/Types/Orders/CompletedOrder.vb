Option Strict On
Namespace Types
    Public Class CompletedOrder
        Inherits CurrentOrder

        Public Property CompletedDate As Date

        Public Sub New(orderID As Integer, customerID As Integer, itemID As Integer, quantity As Integer, orderTotal As Double, orderedDate As Date, completedDate As Date)
            MyBase.New(orderID, customerID, itemID, quantity, orderTotal, orderedDate)
            Me.CompletedDate = completedDate
        End Sub

        Public Sub New(orderID As Integer, customerID As Integer, customerName As String(), itemID As Integer, itemName As String, quantity As Integer, orderTotal As Double, ordered As Date, completedDate As Date)
            MyBase.New(orderID, customerID, customerName, itemID, itemName, quantity, orderTotal, ordered)
            Me.CompletedDate = completedDate
        End Sub
    End Class
End Namespace