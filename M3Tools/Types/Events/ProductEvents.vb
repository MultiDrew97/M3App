Namespace Events.Inventory
	Public Delegate Sub InventoryEventHandler(sender As Object, e As InventoryEventArgs)

	Public Class InventoryEventArgs
		Inherits BaseArgs

		Public Property Product As Types.Product

		Public Sub New(product As Types.Product, Optional eventType As EventType = Nothing)
			Me.Product = product
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
