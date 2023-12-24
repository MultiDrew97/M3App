Namespace Types
	Public Class ListenerCollection
		Inherits DBEntryCollection(Of Listener)

		Public Overrides Sub ApplyFilter()
			Throw New NotImplementedException("ApplyFilter")
			_filteredData.Clear()

			If String.IsNullOrWhiteSpace(Filter) Then
				_filteredData = Items
			End If

			_filteredData = Items.Where(Function(listener As Listener) As Boolean
											Return listener.Name.Contains(Filter) OrElse listener.Email.Contains(Filter)
										End Function).ToList
		End Sub
	End Class
End Namespace
