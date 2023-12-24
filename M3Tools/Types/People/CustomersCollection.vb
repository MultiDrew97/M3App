Namespace Types
	Public Class CustomersCollection
		Inherits DBEntryCollection(Of Customer)

		Overrides Sub ApplyFilter()
			If String.IsNullOrEmpty(Filter) Then
				_filteredData = Items
				Return
			End If

			_filteredData = Items.Where(Function(customer)
											Return customer.Name.Contains(Filter) OrElse customer.Email.Contains(Filter) OrElse customer.Phone.Contains(Filter)
										End Function).ToList
		End Sub
	End Class
End Namespace
