using System.ComponentModel;
using System.Data;
using System.Linq;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Base class for database entry collections
	/// </summary>
	/// <typeparam name="T">The type of entries in collection</typeparam>
	public abstract class DbEntryCollection<T> : /*System.Collections.ObjectModel.Collection<T>,*/ BindingList<T>, IBindingListView where T : IDbEntry, new()
	{
		private string _filter = "";

		/// <summary>
		/// Attempts a given collection into a DbEntryCollection
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		internal static DbEntryCollection<T> Cast(System.Collections.IEnumerable collection) => throw new System.NotImplementedException("Cast for this collection was not implemented yet");

		/// <summary>
		/// Add a range of values to the collection. Can be shadowed to add any data verification gap
		/// </summary>
		/// <param name="collection">The range of values to add to the collection</param>
		public virtual void AddRange(DbEntryCollection<T> collection)
		{
			foreach (T item in collection)
			{
				Add(item);
				OnChanged(ListChangedType.ItemAdded, IndexOf(item));
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
				if (Items[i].Id != item.Id)
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
		public new System.Collections.Generic.IList<T> Items => string.IsNullOrEmpty(Filter) ? base.Items : base.Items.Where(ApplyFilter).ToList();

		/// <summary>
		/// Gets an item that has the specified ID in the collection
		/// </summary>
		/// <param name="entryID">The ID of the entry to find</param>
		/// <returns>The entry if found</returns>
		/// <exception cref="System.ArgumentException">Thrown if the entry doesn't exist in the collection</exception>
		public new T this[int entryID]
		{
			get
			{
				foreach (T item in Items)
				{
					if (item.Id != entryID)
						continue;

					return item;
				}

				throw new System.ArgumentException($"No entry with ID '{entryID}'");
			}
		}

		/// <summary>
		/// Sets a filter to use on the collection
		/// </summary>
		public virtual string Filter
		{
			get => _filter.ToLower();
			set
			{
				if (string.Equals(value, _filter, System.StringComparison.Ordinal))
					return;

				_filter = value;

				OnChanged(ListChangedType.Reset);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public ListSortDescriptionCollection SortDescriptions { get; protected set; }

		/// <summary>
		/// 
		/// </summary>
		public bool SupportsAdvancedSorting => true;

		/// <summary>
		/// Whether the collection supports filtering
		/// </summary>
		public bool SupportsFiltering => true;

		/// <summary>
		/// Whether the collection supports adding new entries
		/// </summary>
		public new bool AllowNew => true;

		/// <summary>
		/// Whether the collection allows editing
		/// </summary>
		public new bool AllowEdit => true;

		/// <summary>
		/// Whether the collection allows removal
		/// </summary>
		public new bool AllowRemove => true;

		/// <summary>
		/// Whether the collection supports change notification
		/// </summary>
		public bool SupportsChangeNotification => true;

		/// <summary>
		/// Whether the collection supports searching
		/// </summary>
		public bool SupportsSearching => true;

		/// <summary>
		/// Whether the collection supports sorting
		/// </summary>
		public bool SupportsSorting => true;

		/// <summary>
		/// Whether the collection is currently sorted
		/// </summary>
		public bool IsSorted { get; protected set; }

		/// <summary>
		/// 
		/// </summary>
		public System.ComponentModel.PropertyDescriptor SortProperty { get; protected set; }

		/// <summary>
		/// The direction the collection is sorted
		/// </summary>
		public System.ComponentModel.ListSortDirection SortDirection { get; protected set; }

		/// <summary>
		/// Event that occurs when the collection is changed in any way
		/// </summary>
		public new event System.ComponentModel.ListChangedEventHandler ListChanged;

		/// <summary>
		/// Applies a sort to the collection based on the sort criteria description provided
		/// </summary>
		/// <param name="sorts"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts)
		{
#if !DEBUG
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
#if !DEBUG
			throw new System.NotImplementedException("ApplySort");
#else
			switch (direction)
			{
				case System.ComponentModel.ListSortDirection.Ascending:
					break;
				case System.ComponentModel.ListSortDirection.Descending:
					break;
				default:
					throw new System.ArgumentException("Invalid sorting direction");
			}

			IsSorted = true;
			SortProperty = property;
			SortDirection = direction;
			OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="property"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void AddIndex(System.ComponentModel.PropertyDescriptor @property) =>
#if !DEBUG
			throw new System.NotImplementedException("AddIndex");
#else
			OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif

		/// <summary>
		/// 
		/// </summary>
		/// <param name="property"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void RemoveIndex(System.ComponentModel.PropertyDescriptor @property) =>
#if !DEBUG
			throw new System.NotImplementedException("RemoveIndex");
#else
			OnChanged(System.ComponentModel.ListChangedType.Reset);
#endif

		/// <summary>
		/// Removes the applied sort from the collection
		/// </summary>
		/// <exception cref="System.NotImplementedException"></exception>
		public void RemoveSort()
		{
#if !DEBUG
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
		public new T AddNew() =>
#if !DEBUG
			throw new System.NotImplementedException("AddNew");
#else
			new();
#endif

		/// <summary>
		/// 
		/// </summary>
		/// <param name="property"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public int Find(System.ComponentModel.PropertyDescriptor @property, object key)
		{
#if !DEBUG
			throw new System.NotImplementedException("Find");
#else
			for (int index = 0; index < Count; index++)
			{
				T item = this[index];
				if (property.GetValue(item) != key)
					continue;

				return index;
			}

			return -1;
#endif
		}

		/// <summary>
		/// Method called when the collection is modified in any way
		/// </summary>
		/// <param name="type">The type of collection change that occurred</param>
		/// <param name="index">The index of the item that was changed</param>
		protected internal virtual void OnChanged(System.ComponentModel.ListChangedType @type = System.ComponentModel.ListChangedType.Reset, int index = -1) => ListChanged?.Invoke(this, new System.ComponentModel.ListChangedEventArgs(type, index));
	}
}

