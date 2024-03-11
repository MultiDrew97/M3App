Imports System.Collections.ObjectModel
Imports System.ComponentModel


Namespace Types
	Public MustInherit Class DBEntryCollection(Of T As DbEntry)
		Inherits Collection(Of T)
		Implements IBindingListView

		Private _filter As String = ""
		Private _sorted As Boolean = False
		Private ReadOnly _sortDescription As New ListSortDescriptionCollection
		'Protected _filteredData As IList(Of T)
		'Private _descriptor As DBEntryPropertyDescriptor

		MustOverride Function ApplyFilter(entry As T, index As Integer) As Boolean

		Shadows ReadOnly Property Items As IList(Of T)
			Get
				If String.IsNullOrEmpty(Filter) Then
					Return MyBase.Items
				End If

				Return MyBase.Items.Where(AddressOf ApplyFilter).ToList
			End Get
		End Property

		Shadows ReadOnly Property Item(id As Integer) As T
			Get
				'If Not String.IsNullOrEmpty(Filter) Then
				'	For Each current In FilteredData
				'		If current.Id = id Then
				'			Return current
				'		End If
				'	Next

				'End If

				For Each current In Items
					If current.Id = id Then
						Return current
					End If
				Next

				Throw New Exception($"No entry with ID '{id}'")
			End Get
		End Property


		Public Shadows Property Filter As String Implements IBindingListView.Filter
			Get
				Return _filter
			End Get
			Set(value As String)
				If String.Equals(value, _filter, StringComparison.Ordinal) Then
					Return
				End If

				_filter = value

				OnChanged(ListChangedType.Reset)
			End Set
		End Property

		Public ReadOnly Property FilteredData As IList(Of T)
			Get
				Return Items.Where(AddressOf ApplyFilter).ToList
			End Get
		End Property

		Public ReadOnly Property SortDescriptions As ListSortDescriptionCollection Implements IBindingListView.SortDescriptions
			Get
				Return _sortDescription
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

		Public Shadows ReadOnly Property SupportsSorting As Boolean Implements IBindingList.SupportsSorting
			Get
				' TODO: Figure out sorting
				Return True
			End Get
		End Property

		Public ReadOnly Property IsSorted As Boolean Implements IBindingList.IsSorted
			Get
				Return _sorted
			End Get
		End Property

		Public ReadOnly Property SortProperty As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotImplementedException("SortProperty")
				'Return _descriptor
			End Get
		End Property

		Public ReadOnly Property SortDirection As ListSortDirection Implements IBindingList.SortDirection
			Get
				Return ListSortDirection.Ascending
			End Get
		End Property

		Public Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged

		Public Sub ApplySort(sorts As ListSortDescriptionCollection) Implements IBindingListView.ApplySort
			Throw New NotImplementedException("ApplySort")
			_sorted = True
			OnChanged(ListChangedType.Reset)
		End Sub


		Public Sub RemoveFilter() Implements IBindingListView.RemoveFilter
			Filter = String.Empty
			OnChanged(ListChangedType.Reset)
		End Sub

		Public Sub ApplySort([property] As PropertyDescriptor, direction As ListSortDirection) Implements IBindingList.ApplySort
			'Throw New NotImplementedException("ApplySort")
			Dim Column = [property].Name
			Select Case direction
				Case ListSortDirection.Ascending

				Case ListSortDirection.Descending

				Case Else
					Throw New ArgumentException("Invalid sorting direction")
			End Select

			_sorted = True
			OnChanged(ListChangedType.Reset)
		End Sub

		Public Sub AddIndex([property] As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotImplementedException("AddIndex")
			OnChanged(ListChangedType.Reset)
		End Sub

		Public Sub RemoveIndex([property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotImplementedException("RemoveIndex")
			OnChanged(ListChangedType.Reset)
		End Sub

		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotImplementedException("RemoveSort")
			_sorted = False
			OnChanged(ListChangedType.Reset)
		End Sub

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Throw New NotImplementedException("AddNew")
			Return CType(New Object(), T)
		End Function

		Public Function Find([property] As PropertyDescriptor, key As Object) As Integer Implements IBindingList.Find
			Throw New NotImplementedException("Find")
		End Function

		Private Sub OnChanged(Optional type As ListChangedType = ListChangedType.Reset, Optional index As Integer = -1)
			RaiseEvent ListChanged(Me, New ListChangedEventArgs(type, index))
		End Sub
	End Class

	'MustInherit Class DBEntryPropertyDescriptor
	'	Inherits PropertyDescriptor

	'	Protected Sub New(descr As MemberDescriptor)
	'		MyBase.New(descr)
	'	End Sub

	'	Protected Sub New(name As String, attrs() As Attribute)
	'		MyBase.New(name, attrs)
	'	End Sub

	'	Protected Sub New(descr As MemberDescriptor, attrs() As Attribute)
	'		MyBase.New(descr, attrs)
	'	End Sub
	'End Class
End Namespace


'Namespace Types
'Public MustInherit Class DBEntryCollection(Of T As DbEntry)
'	Inherits Windows.Forms.BindingSource

'	Private _filter As String = ""
'	Private ReadOnly _innerList As New Collection(Of T)
'	'Protected _filteredData As IList(Of T)
'	'Private _descriptor As DBEntryPropertyDescriptor

'	MustOverride Function ApplyFilter(entry As T, index As Integer) As Boolean

'	Shadows ReadOnly Property List As IList
'		Get
'			If String.IsNullOrEmpty(Filter) Then
'				Return MyBase.List
'			End If

'			Return MyBase.List.Cast(Of T).Where(AddressOf ApplyFilter).ToList
'		End Get
'	End Property

'	Public Shadows Property Filter As String
'		Get
'			Return _filter
'		End Get
'		Set(value As String)
'			If String.Equals(value, _ filter, StringComparison.Ordinal) Then
'				Return
'			End If

'			_filter = value
'		End Set
'	End Property

'	Public Shadows ReadOnly Property SupportsAdvancedSorting As Boolean
'		Get
'			Return True
'		End Get
'	End Property

'	Public Shadows ReadOnly Property SupportsFiltering As Boolean
'		Get
'			Return True
'		End Get
'	End Property

'	Protected Sub New(innerList As Collection(Of T))
'		MyBase.New(innerList, String.Empty)
'	End Sub
'End Class

'MustInherit Class DBEntryPropertyDescriptor
'	Inherits PropertyDescriptor

'	Protected Sub New(descr As MemberDescriptor)
'		MyBase.New(descr)
'	End Sub

'	Protected Sub New(name As String, attrs() As Attribute)
'		MyBase.New(name, attrs)
'	End Sub

'	Protected Sub New(descr As MemberDescriptor, attrs() As Attribute)
'		MyBase.New(descr, attrs)
'	End Sub
'End Class
'End Namespace

