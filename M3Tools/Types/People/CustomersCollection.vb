Namespace Types
	Public Class CustomersCollection
		Inherits DBEntryCollection(Of Customer)

		Overloads ReadOnly Property List As IList(Of Customer)
			Get
				If (String.IsNullOrEmpty(Filter)) Then
					Return Me.Items
				End If

				Return FilteredData
			End Get
		End Property

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
