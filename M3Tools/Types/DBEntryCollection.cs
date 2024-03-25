using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace SPPBC.M3Tools.Types
{
    public abstract class DBEntryCollection<T> : Collection<T>, IBindingListView where T : DbEntry
    {

        private string _filter = "";
        private bool _sorted = false;
        private readonly ListSortDescriptionCollection _sortDescription = new ListSortDescriptionCollection();
        // Protected _filteredData As IList(Of T)
        // Private _descriptor As DBEntryPropertyDescriptor

        public abstract bool ApplyFilter(T entry, int index);

        public new IList<T> Items
        {
            get
            {
                if (string.IsNullOrEmpty(Filter))
                {
                    return base.Items;
                }

                return base.Items.Where(ApplyFilter).ToList();
            }
        }

        public new T get_Item(int id)
        {
            // If Not String.IsNullOrEmpty(Filter) Then
            // For Each current In FilteredData
            // If current.Id = id Then
            // Return current
            // End If
            // Next

            // End If

            foreach (var current in Items)
            {
                if (current.Id == id)
                {
                    return current;
                }
            }

            throw new Exception($"No entry with ID '{id}'");
        }


        public new string Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                if (string.Equals(value, _filter, StringComparison.Ordinal))
                {
                    return;
                }

                _filter = value;

                OnChanged(ListChangedType.Reset);
            }
        }

        public IList<T> FilteredData
        {
            get
            {
                return Items.Where(ApplyFilter).ToList();
            }
        }

        public ListSortDescriptionCollection SortDescriptions
        {
            get
            {
                return _sortDescription;
            }
        }

        public bool SupportsAdvancedSorting
        {
            get
            {
                return true;
            }
        }

        public bool SupportsFiltering
        {
            get
            {
                return true;
            }
        }

        public bool AllowNew
        {
            get
            {
                return true;
            }
        }

        public bool AllowEdit
        {
            get
            {
                return true;
            }
        }

        public bool AllowRemove
        {
            get
            {
                return true;
            }
        }

        public bool SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }

        public bool SupportsSearching
        {
            get
            {
                return true;
            }
        }

        public new bool SupportsSorting
        {
            get
            {
                // TODO: Figure out sorting
                return true;
            }
        }

        public bool IsSorted
        {
            get
            {
                return _sorted;
            }
        }

        public PropertyDescriptor SortProperty
        {
            get
            {
                throw new NotImplementedException("SortProperty");
                // Return _descriptor
            }
        }

        public ListSortDirection SortDirection
        {
            get
            {
                return ListSortDirection.Ascending;
            }
        }

        public event ListChangedEventHandler ListChanged;

        public void ApplySort(ListSortDescriptionCollection sorts)
        {
            throw new NotImplementedException("ApplySort");
            _sorted = true;
            OnChanged(ListChangedType.Reset);
        }


        public void RemoveFilter()
        {
            Filter = string.Empty;
            OnChanged(ListChangedType.Reset);
        }

        public void ApplySort(PropertyDescriptor @property, ListSortDirection direction)
        {
            // Throw New NotImplementedException("ApplySort")
            string Column = @property.Name;
            switch (direction)
            {
                case ListSortDirection.Ascending:
                    {
                        break;
                    }

                case ListSortDirection.Descending:
                    {
                        break;
                    }

                default:
                    {
                        throw new ArgumentException("Invalid sorting direction");
                    }
            }

            _sorted = true;
            OnChanged(ListChangedType.Reset);
        }

        public void AddIndex(PropertyDescriptor @property)
        {
            throw new NotImplementedException("AddIndex");
            OnChanged(ListChangedType.Reset);
        }

        public void RemoveIndex(PropertyDescriptor @property)
        {
            throw new NotImplementedException("RemoveIndex");
            OnChanged(ListChangedType.Reset);
        }

        public void RemoveSort()
        {
            throw new NotImplementedException("RemoveSort");
            _sorted = false;
            OnChanged(ListChangedType.Reset);
        }

        public object AddNew()
        {
            throw new NotImplementedException("AddNew");
            return (T)new object();
        }

        public int Find(PropertyDescriptor @property, object key)
        {
            throw new NotImplementedException("Find");
        }

        private void OnChanged(ListChangedType @type = ListChangedType.Reset, int index = -1)
        {
            ListChanged?.Invoke(this, new ListChangedEventArgs(type, index));
        }
    }

    // MustInherit Class DBEntryPropertyDescriptor
    // Inherits PropertyDescriptor

    // Protected Sub New(descr As MemberDescriptor)
    // MyBase.New(descr)
    // End Sub

    // Protected Sub New(name As String, attrs() As Attribute)
    // MyBase.New(name, attrs)
    // End Sub

    // Protected Sub New(descr As MemberDescriptor, attrs() As Attribute)
    // MyBase.New(descr, attrs)
    // End Sub
    // End Class
}


// Namespace Types
// Public MustInherit Class DBEntryCollection(Of T As DbEntry)
// Inherits Windows.Forms.BindingSource

// Private _filter As String = ""
// Private ReadOnly _innerList As New Collection(Of T)
// 'Protected _filteredData As IList(Of T)
// 'Private _descriptor As DBEntryPropertyDescriptor

// MustOverride Function ApplyFilter(entry As T, index As Integer) As Boolean

// Shadows ReadOnly Property List As IList
// Get
// If String.IsNullOrEmpty(Filter) Then
// Return MyBase.List
// End If

// Return MyBase.List.Cast(Of T).Where(AddressOf ApplyFilter).ToList
// End Get
// End Property

// Public Shadows Property Filter As String
// Get
// Return _filter
// End Get
// Set(value As String)
// If String.Equals(value, _ filter, StringComparison.Ordinal) Then
// Return
// End If

// _filter = value
// End Set
// End Property

// Public Shadows ReadOnly Property SupportsAdvancedSorting As Boolean
// Get
// Return True
// End Get
// End Property

// Public Shadows ReadOnly Property SupportsFiltering As Boolean
// Get
// Return True
// End Get
// End Property

// Protected Sub New(innerList As Collection(Of T))
// MyBase.New(innerList, String.Empty)
// End Sub
// End Class

// MustInherit Class DBEntryPropertyDescriptor
// Inherits PropertyDescriptor

// Protected Sub New(descr As MemberDescriptor)
// MyBase.New(descr)
// End Sub

// Protected Sub New(name As String, attrs() As Attribute)
// MyBase.New(name, attrs)
// End Sub

// Protected Sub New(descr As MemberDescriptor, attrs() As Attribute)
// MyBase.New(descr, attrs)
// End Sub
// End Class
// End Namespace

