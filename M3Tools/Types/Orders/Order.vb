Option Strict On
Namespace Types
    ' TODO: Consolidate CurrentOrder and CompletedOrder
    Public Class Order
        Inherits DBEntry

		Public Property Customer As Person
		Public Property Item As Item
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
		''' Retrieve a user from the database using their CustomerID
		''' </summary>
		''' <param name="customerID">CustomerID of the desired customer</param>
		Private Sub GetCustomer(customerID As Integer)
			If Not Utils.ValidID(customerID) Then
				Exit Sub
			End If

			Using c As New Database.CustomerDatabase
				Customer = c.GetCustomer(customerID)
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

			Using i As New Database.InventoryDatabase
				Item = i.GetItem(itemID)
			End Using
		End Sub

		'Public Overrides Sub UpdateID(newID As Integer)
		'	If newID = Id Then
		'		Return
		'	End If

		'	Using conn As New Database.OrdersDatabase
		'		Dim newOrder = conn.GetOrderById(newID)

		'		' TODO: Finish implementing updates
		'	End Using
		'End Sub

		Public Function Clone() As Order
			Return New Order(Id, Customer.Id, Item.Id, Quantity, OrderTotal, OrderDate, CompletedDate)
		End Function
	End Class
End Namespace