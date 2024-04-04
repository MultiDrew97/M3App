//using System.Data;
using System.Linq;

namespace SPPBC.M3Tools.Types
{
    public abstract class DBEntryCollection<T> : System.Collections.ObjectModel.Collection<T>, System.ComponentModel.IBindingListView where T : IDbEntry
	{

        private string _filter = "";
        private bool _sorted = false;
        private readonly System.ComponentModel.ListSortDescriptionCollection _sortDescription = new System.ComponentModel.ListSortDescriptionCollection();
        // Protected _filteredData As IList(Of T)
        // Private _descriptor As DBEntryPropertyDescriptor

		/// <summary>
		/// Applies the filter to the list
		/// </summary>
		/// <param name="entry">The current entry</param>
		/// <param name="index">The index of the current entry</param>
		/// <returns></returns>
        public abstract bool ApplyFilter(T entry, int index);

        public new System.Collections.Generic.IList<T> Items
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

        public new T Item(int id)
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
                if (current.GetHashCode() == id)
                {
                    return current;
                }
            }

            throw new System.Exception($"No entry with ID '{id}'");
        }


        public new string Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                if (string.Equals(value, _filter, System.StringComparison.Ordinal))
                {
                    return;
                }

                _filter = value;

                OnChanged(System.ComponentModel.ListChangedType.Reset);
            }
        }

        public System.Collections.Generic.IList<T> FilteredData
        {
            get
            {
                return Items.Where(ApplyFilter).ToList();
            }
        }

        public System.ComponentModel.ListSortDescriptionCollection SortDescriptions
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

        public System.ComponentModel.PropertyDescriptor SortProperty
        {
            get
            {
                throw new System.NotImplementedException("SortProperty");
                // Return _descriptor
            }
        }

        public System.ComponentModel.ListSortDirection SortDirection
        {
            get
            {
                return System.ComponentModel.ListSortDirection.Ascending;
            }
        }

        public event System.ComponentModel.ListChangedEventHandler ListChanged;

        public void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts)
        {
            throw new System.NotImplementedException("ApplySort");
            _sorted = true;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }


        public void RemoveFilter()
        {
            Filter = string.Empty;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

        public void ApplySort(System.ComponentModel.PropertyDescriptor @property, System.ComponentModel.ListSortDirection direction)
        {
            // Throw New NotImplementedException("ApplySort")
            string Column = @property.Name;
            switch (direction)
            {
                case System.ComponentModel.ListSortDirection.Ascending:
                    {
                        break;
                    }

                case System.ComponentModel.ListSortDirection.Descending:
                    {
                        break;
                    }

                default:
                    {
                        throw new System.ArgumentException("Invalid sorting direction");
                    }
            }

            _sorted = true;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

        public void AddIndex(System.ComponentModel.PropertyDescriptor @property)
        {
            throw new System.NotImplementedException("AddIndex");
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

        public void RemoveIndex(System.ComponentModel.PropertyDescriptor @property)
        {
            throw new System.NotImplementedException("RemoveIndex");
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

        public void RemoveSort()
        {
            throw new System.NotImplementedException("RemoveSort");
            _sorted = false;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

        public object AddNew()
        {
            throw new System.NotImplementedException("AddNew");
            return (T)new object();
        }

        public int Find(System.ComponentModel.PropertyDescriptor @property, object key)
        {
            throw new System.NotImplementedException("Find");
        }

        private void OnChanged(System.ComponentModel.ListChangedType @type = System.ComponentModel.ListChangedType.Reset, int index = -1)
        {
            ListChanged?.Invoke(this, new System.ComponentModel.ListChangedEventArgs(type, index));
        }
    }
}

