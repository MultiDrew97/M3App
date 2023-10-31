Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace Types
	Public Class DBEntryCollection(Of T As DbEntry)
		Inherits Collection(Of T)
		Implements IBindingListView

		Private _filter As String

		Public Property Filter As String Implements IBindingListView.Filter
			Get
				Return _filter
			End Get
			Set(value As String)
				_filter = value
			End Set
		End Property

		Public ReadOnly Property SortDescriptions As ListSortDescriptionCollection Implements IBindingListView.SortDescriptions
			Get
				Throw New NotImplementedException()
			End Get
		End Property

		Public ReadOnly Property SupportsAdvancedSorting As Boolean Implements IBindingListView.SupportsAdvancedSorting
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property SupportsFiltering As Boolean Implements IBindingListView.SupportsFiltering
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowNew As Boolean Implements IBindingList.AllowNew
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowEdit As Boolean Implements IBindingList.AllowEdit
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowRemove As Boolean Implements IBindingList.AllowRemove
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property SupportsChangeNotification As Boolean Implements IBindingList.SupportsChangeNotification
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property SupportsSearching As Boolean Implements IBindingList.SupportsSearching
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property SupportsSorting As Boolean Implements IBindingList.SupportsSorting
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property IsSorted As Boolean Implements IBindingList.IsSorted
			Get
				Throw New NotImplementedException()
			End Get
		End Property

		Public ReadOnly Property SortProperty As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotImplementedException()
			End Get
		End Property

		Public ReadOnly Property SortDirection As ListSortDirection Implements IBindingList.SortDirection
			Get
				Throw New NotImplementedException()
			End Get
		End Property

		Public Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged

		Public Sub ApplySort(sorts As ListSortDescriptionCollection) Implements IBindingListView.ApplySort
			Throw New NotImplementedException()
		End Sub

		Public Sub RemoveFilter() Implements IBindingListView.RemoveFilter
			Filter = ""
		End Sub

		Public Sub ApplySort([property] As PropertyDescriptor, direction As ListSortDirection) Implements IBindingList.ApplySort
			Throw New NotImplementedException()
		End Sub

		Public Sub AddIndex([property] As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotImplementedException()
		End Sub

		Public Sub RemoveIndex([property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotImplementedException()
		End Sub

		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotImplementedException()
		End Sub

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Throw New NotImplementedException()
		End Function

		Public Function Find([property] As PropertyDescriptor, key As Object) As Integer Implements IBindingList.Find
			Throw New NotImplementedException()
		End Function

		Default Overloads ReadOnly Property Item(id As Integer) As T
			Get
				For Each curr In Items
					If curr.Id = id Then
						Return curr
					End If
				Next

				Throw New Exceptions.ItemNotFoundException()
			End Get
		End Property

		Sub New()
			MyBase.New()
		End Sub

		Sub New(list As IList(Of T))
			MyBase.New(list)
		End Sub

		Overloads Function Contains(id As Integer) As Boolean
			For Each listener In Items
				If listener.Id = id Then
					Return True
				End If
			Next

			Return False
		End Function

		Overloads Function Contains(search As T) As Boolean
			For Each listener In Items
				If listener = search Then
					Return True
				End If
			Next

			Return False
		End Function

		Public Sub AddRange(params As IList(Of T))
			For Each param In params
				Add(param)
			Next
		End Sub
	End Class
End Namespace