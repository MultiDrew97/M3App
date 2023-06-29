Namespace Events.Listeners
	Public Delegate Sub ListenerAddedEventHandler(sender As Object, e As ListenerAddedEventArgs)

	Public Class ListenerAddedEventArgs
		Inherits EventArgs

		Property ListenerName As String
		Property ListenerEmail As String

		Sub New(listenerName As String, listenerEmail As String)
			MyBase.New()

			Me.ListenerName = listenerName
			Me.ListenerEmail = listenerEmail
		End Sub
	End Class
End Namespace
