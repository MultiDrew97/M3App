Namespace Events
	Public Delegate Sub RemoveEventHandler(sender As Object, e As BulkActionEventArgs)
	Public Delegate Sub AddEventHandler(sender As Object, e As BulkActionEventArgs)
	Public Delegate Sub EditEventHandler(sender As Object, e As BulkActionEventArgs)

	Public MustInherit Class BaseArgs
		Inherits EventArgs
		Property EventType As EventType
	End Class

	Public Class BulkActionEventArgs
		Inherits BaseArgs

		Public Property List As IList

		Sub New(list As IList, Optional eventType As EventType = EventType.None)
			Me.List = list
			Me.EventType = eventType
		End Sub
	End Class

	Public Enum EventType
		None
		Added
		Deleted
		Updated
	End Enum
End Namespace
