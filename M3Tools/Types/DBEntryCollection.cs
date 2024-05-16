using System.Data;
using System.Linq;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Base class for database entry collections
	/// </summary>
	/// <typeparam name="T">The type of entries in collection</typeparam>
    public abstract class DBEntryCollection<T> : System.Collections.ObjectModel.Collection<T>, System.ComponentModel.IBindingListView
	{

        private string _filter = "";
        private System.ComponentModel.ListSortDescriptionCollection _sortDescriptions = new();
		// Protected _filteredData As IList(Of T)
		// Private _descriptor As DBEntryPropertyDescriptor

		/// <summary>
		/// Add a range of values to the collection. Can be shadowed to add any data verification gap
		/// </summary>
		/// <param name="collection">The range of values to add to the collection</param>
		public virtual void AddRange(DBEntryCollection<T> collection)
		{
			foreach (T item in collection)
			{
				Add(item);
				OnChanged(System.ComponentModel.ListChangedType.ItemAdded, IndexOf(item));
			}
		}

		/// <summary>
		/// Finds the index of the item being searched for
		/// </summary>
		/// <param name="item">The item being searched for</param>
		/// <returns>The index of the item if found, otherwise -1</returns>
		public new int IndexOf(T item)
		{
			for (int i = 0; i < Count; i++)
			{
				if (Items[i].GetHashCode() != item.GetHashCode())
				{
					continue;
				}

				return i;
			}

			return -1;
		}

		/// <summary>
		/// Applies the filter to the list
		/// </summary>
		/// <param name="entry">The current entry</param>
		/// <param name="index">The index of the current entry</param>
		/// <returns></returns>
		public abstract bool ApplyFilter(T entry, int index);

		/// <summary>
		/// List of items currently in the collection
		/// </summary>
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

		/// <summary>
		/// Gets an item that has the specified ID in the collection
		/// </summary>
		/// <param name="id">The ID of the entry to find</param>
		/// <returns>The entry if found</returns>
		/// <exception cref="System.ArgumentException">Thrown if the entry doesn't exist in the collection</exception>
        public new T this[int id]
        {
			get
			{
				foreach (var current in Items)
				{
					if (current.GetHashCode() != id)
					{
						continue;
					}

					return current;
				}

				throw new System.ArgumentException($"No entry with ID '{id}'");
			}
        }

		/// <summary>
		/// The list of items in the collection
		/// </summary>
		public System.Collections.Generic.IList<T> List => Items;

		/// <summary>
		/// Applies a filter to the collection
		/// </summary>
		public string Filter
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

/*		public System.Collections.Generic.IList<T> FilteredData
		{
			get
			{
				return Items.Where(ApplyFilter).ToList();
			}
		}*/

		/// <inheritdoc/>
		public System.ComponentModel.ListSortDescriptionCollection SortDescriptions
        {
            get
            {
                return _sortDescriptions;
            }
			private set
			{
				_sortDescriptions = value;
			}
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public bool SupportsAdvancedSorting
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection supports filtering
		/// </summary>
        public bool SupportsFiltering
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection supports adding new entries
		/// </summary>
        public bool AllowNew
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection allows editing
		/// </summary>
        public bool AllowEdit
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection allows removal
		/// </summary>
        public bool AllowRemove
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection supports change notification
		/// </summary>
        public bool SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection supports searching
		/// </summary>
        public bool SupportsSearching
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection supports sorting
		/// </summary>
        public bool SupportsSorting
        {
            get
            {
                return true;
            }
        }

		/// <summary>
		/// Whether the collection is currently sorted
		/// </summary>
        public bool IsSorted { get; protected set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public System.ComponentModel.PropertyDescriptor SortProperty
		{
			get
			{
				throw new System.NotImplementedException("SortProperty");
				// Return _descriptor
			}
		}

		/// <summary>
		/// The direction the collection is sorted
		/// </summary>
		public System.ComponentModel.ListSortDirection SortDirection
        {
            get
            {
                return System.ComponentModel.ListSortDirection.Ascending;
            }
        }

		/// <summary>
		/// Event that occurs when the collection is changed in any way
		/// </summary>
        public event System.ComponentModel.ListChangedEventHandler ListChanged;

		/// <summary>
		/// Applies a sort to the collection based on the sort criteria description provided
		/// </summary>
		/// <param name="sorts"></param>
		/// <exception cref="System.NotImplementedException"></exception>
        public void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts)
        {
#if DEBUG
			throw new System.NotImplementedException("ApplySort");
#else
			IsSorted = true;
			SortDescriptions = sorts;

            OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif
        }

		/// <summary>
		/// Removes the applied filter from the 
		/// </summary>
        public void RemoveFilter()
        {
            Filter = string.Empty;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

		/// <summary>
		/// Applies a sort to the collection using the provided criteria
		/// </summary>
		/// <param name="property">The column to sort on</param>
		/// <param name="direction">The direction to sort in</param>
		/// <exception cref="System.ArgumentException">The provided sort direction is not valid</exception>
        public void ApplySort(System.ComponentModel.PropertyDescriptor @property, System.ComponentModel.ListSortDirection direction)
        {
            // Throw New NotImplementedException("ApplySort")
            // string Column = @property.Name;
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

            IsSorted = true;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="property"></param>
		/// <exception cref="System.NotImplementedException"></exception>
        public void AddIndex(System.ComponentModel.PropertyDescriptor @property)
        {
#if DEBUG
			throw new System.NotImplementedException("AddIndex");
#else
			OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="property"></param>
		/// <exception cref="System.NotImplementedException"></exception>
        public void RemoveIndex(System.ComponentModel.PropertyDescriptor @property)
        {
#if DEBUG
			throw new System.NotImplementedException("RemoveIndex");
#else
			OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif
        }

		/// <summary>
		/// Removes the applied sort from the collection
		/// </summary>
		/// <exception cref="System.NotImplementedException"></exception>
        public void RemoveSort()
        {
#if DEBUG
			throw new System.NotImplementedException("RemoveSort");
#else
			IsSorted = false;
            OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif
        }

		/// <summary>
		/// Create a new entry and return it
		/// </summary>
		/// <returns>The new empty entry</returns>
		/// <exception cref="System.NotImplementedException"></exception>
        public object AddNew()
        {
#if DEBUG
			throw new System.NotImplementedException("AddNew");
#else
			return (T)new object();
#endif
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="property"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public int Find(System.ComponentModel.PropertyDescriptor @property, object key)
		{
			return Find(property, (T)key);
		}

		private int Find(System.ComponentModel.PropertyDescriptor @property, T key)
		{
			throw new System.NotImplementedException("Find");
		}

		/// <summary>
		/// Method called when the collection is modified in any way
		/// </summary>
		/// <param name="type">The type of collection change that occurred</param>
		/// <param name="index">The index of the item that was changed</param>
		internal protected virtual void OnChanged(System.ComponentModel.ListChangedType @type = System.ComponentModel.ListChangedType.Reset, int index = -1)
        {
            ListChanged?.Invoke(this, new System.ComponentModel.ListChangedEventArgs(type, index));
        }
    }
}

