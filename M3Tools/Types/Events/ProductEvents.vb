Namespace Events.Products
	Public Delegate Sub ProductEventHandler(sender As Object, e As ProductEventArgs)

	Public Class ProductEventArgs
		Inherits BaseArgs

		Public Property Product As Types.Product

		Public Sub New(product As Types.Product, Optional eventType As EventType = Nothing)
			Me.Product = product
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
