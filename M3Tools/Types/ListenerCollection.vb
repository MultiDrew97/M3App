Namespace Types
	Public Class ListenerCollection
		Inherits DBEntryCollection(Of Listener)

		Public Overrides Function ApplyFilter(listener As Listener) As Boolean
			Throw New NotImplementedException("ApplyFilter")
			Return listener.Name.Contains(Filter) OrElse listener.Email.Contains(Filter)
		End Function
	End Class
End Namespace
