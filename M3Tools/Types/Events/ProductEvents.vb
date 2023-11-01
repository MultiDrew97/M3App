Namespace Events.Inventory
	Public Delegate Sub InventoryEventHandler(sender As Object, e As InventoryEventArgs)

	Public Class InventoryEventArgs
		Inherits BaseArgs

		Public Property Item As Types.Item

		Public Sub New(product As Types.Item, Optional eventType As EventType = Nothing)
			Me.Item = product
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
