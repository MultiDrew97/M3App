Namespace Events.Products
	Public Delegate Sub ProductEventHandler(sender As Object, e As ProductEventArgs)

	Public Class ProductEventArgs
		Inherits BaseArgs

		Public Property Product As Types.Item

		Public Sub New(product As Types.Item, Optional eventType As EventType = Nothing)
			Me.Product = product
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
