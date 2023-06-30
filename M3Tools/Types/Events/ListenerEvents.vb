Namespace Events.Listeners
	Public Delegate Sub ListenerEventHandler(sender As Object, e As ListenerEventArgs)
	'Public Delegate Sub EditListenerEventHandler(sender As Object, e As ListenerEventArgs)

	Public Class ListenerEventArgs
		Inherits BaseArgs

		Property Listener As Types.Listener

		Sub New(listener As Types.Listener, Optional eventType As EventType = Nothing)
			Me.Listener = listener
			Me.EventType = eventType
		End Sub
	End Class
End Namespace
