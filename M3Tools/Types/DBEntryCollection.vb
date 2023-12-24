Imports System.Collections.ObjectModel
Imports System.ComponentModel


Namespace Types
	Public MustInherit Class DBEntryCollection(Of T As DbEntry)
		Inherits Collection(Of T)
		Implements IBindingListView

		Private _filter As String = ""
		Protected _filteredData As IList(Of T)
		Private ReadOnly _listDescription As New ListSortDescriptionCollection

		MustOverride Sub ApplyFilter()

		Public Property Filter As String Implements IBindingListView.Filter
			Get
				Return _filter
			End Get
			Set(value As String)
				If Not SupportsFiltering OrElse _filter.Equals(value) Then
					Return
				End If

				_filter = value

				ApplyFilter()

				RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))
			End Set
		End Property

		Public ReadOnly Property FilteredData As IList(Of T)
			Get
				Return _filteredData
				Throw New NotImplementedException("FilteredData")
			End Get
		End Property

		Public ReadOnly Property SortDescriptions As ListSortDescriptionCollection Implements IBindingListView.SortDescriptions
			Get
				Return _listDescription
			End Get
		End Property

		Public ReadOnly Property SupportsAdvancedSorting As Boolean Implements IBindingListView.SupportsAdvancedSorting
			Get
				Return False
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

		Public Shadows ReadOnly Property SupportsSorting As Boolean Implements IBindingList.SupportsSorting
			Get
				' TODO: Figure out sorting
				Return True
			End Get
		End Property

		Public ReadOnly Property IsSorted As Boolean Implements IBindingList.IsSorted
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property SortProperty As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotImplementedException("SortProperty")
			End Get
		End Property

		Public ReadOnly Property SortDirection As ListSortDirection Implements IBindingList.SortDirection
			Get
				Throw New NotImplementedException("SortDirection")
			End Get
		End Property

		Public Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged

		Public Sub ApplySort(sorts As ListSortDescriptionCollection) Implements IBindingListView.ApplySort
			Throw New NotImplementedException("ApplySort")
		End Sub


		Public Sub RemoveFilter() Implements IBindingListView.RemoveFilter
			Filter = String.Empty
		End Sub

		Public Sub ApplySort([property] As PropertyDescriptor, direction As ListSortDirection) Implements IBindingList.ApplySort
			Throw New NotImplementedException("ApplySort")
		End Sub

		Public Sub AddIndex([property] As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotImplementedException("AddIndex")
		End Sub

		Public Sub RemoveIndex([property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotImplementedException("RemoveIndex")
		End Sub

		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotImplementedException("RemoveSort")
		End Sub

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Throw New NotImplementedException("AddNew")
			Return CType(New Object(), T)
		End Function

		Public Function Find([property] As PropertyDescriptor, key As Object) As Integer Implements IBindingList.Find
			Throw New NotImplementedException("Find")
		End Function
	End Class
End Namespace
