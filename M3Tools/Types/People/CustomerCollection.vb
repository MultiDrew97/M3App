Imports System.Collections.ObjectModel

Namespace Types
	Public Class CustomerCollection
		Inherits DBEntryCollection(Of Customer)
		Sub New()
			MyBase.New()
		End Sub

		Sub New(customers As IList(Of Customer))
			MyBase.New(customers)
		End Sub

		'Default Overloads ReadOnly Property Item(customerID As Integer) As Customer
		'	Get
		'		Return GetItem(customerID)
		'	End Get
		'End Property


		'Overloads Function Contains(id As Integer) As Boolean
		'	For Each customer In Items
		'		If customer.Id = id Then
		'			Return True
		'		End If
		'	Next

		'	Return False
		'End Function

		'Overloads Function Contains(customerSearch As Customer) As Boolean
		'	For Each customer In Items
		'		If customer = customerSearch Then
		'			Return True
		'		End If
		'	Next

		'	Return False
		'End Function

		'Sub AddRange(customers As IList(Of Customer))
		'	For Each customer In customers
		'		Add(customer)
		'	Next
		'End Sub

		'Public Function GetItem(customerID As Integer) As Customer
		'	For Each customer In Items
		'		If customer.Id = customerID Then
		'			Return customer
		'		End If
		'	Next

		'	Throw New Exceptions.CustomerNotFoundException()
		'End Function
	End Class
End Namespace