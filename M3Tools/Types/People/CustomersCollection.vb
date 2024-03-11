Namespace Types
	Public Class CustomersCollection
		Inherits DBEntryCollection(Of Customer)

		Public Overrides Function ApplyFilter(customer As Customer, index As Integer) As Boolean
			' TODO: Do I want to allow for nothing values?
			If customer Is Nothing Then
				Return False
			End If

			Return customer.Name.Contains(Filter) OrElse customer.Email.Contains(Filter) OrElse customer.Phone.Contains(Filter)
		End Function
	End Class
End Namespace
