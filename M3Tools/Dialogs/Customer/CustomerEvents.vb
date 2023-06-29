Namespace Events.Customers
	Public Delegate Sub AddCustomerEventHandler(sender As Object)
	Public Delegate Sub EditCustomerEventHandler(sender As Object, e As CustomerEventArgs)
	Public Class CustomerEventArgs
		Inherits EventArgs
		Property Type As CustomerEventType
		Property Customer As Types.Customer

		Sub New(customer As Types.Customer, Optional eventType As CustomerEventType = Nothing)
			Me.Customer = customer
			Me.Type = eventType
		End Sub
	End Class

	Public Enum CustomerEventType
		Added
		Deleted
		Editted
	End Enum
End Namespace
