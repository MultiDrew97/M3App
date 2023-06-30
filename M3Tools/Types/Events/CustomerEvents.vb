Namespace Events.Customers
	Public Delegate Sub CustomerEventHandler(sender As Object, e As CustomerEventArgs)
	'Public Delegate Sub EditCustomerEventHandler(sender As Object, e As CustomerEventArgs)

	Public Class CustomerEventArgs
		Inherits BaseArgs

		Property Customer As Types.Customer

		Sub New(customer As Types.Customer, Optional eventType As EventType = Nothing)
			Me.Customer = customer
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
