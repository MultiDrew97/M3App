
using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Filterable collection of customers
	/// </summary>
	public class InventoryCollection : DbEntryCollection<Product>
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static new InventoryCollection Cast(System.Collections.IList collection)
		{
			if (collection == null || collection.Count <= 0)
			{
				return new();
			}

			InventoryCollection result;
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = new();
					foreach (DataGridViewRow row in collection)
					{
						result.Add((Product)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
					result = new();
					foreach (Product item in collection)
					{
						result.Add(item);
					}

					return result;
				case var @dbColl when dbColl == typeof(InventoryCollection):
					return (InventoryCollection)collection;
				default:
					throw new Exception("Unable to cast collection to InventoryCollection");
			}
		}

		/// <summary>
		/// Applies a filter to the collection, finding any values that match the criteria
		/// </summary>
		/// <param name="customer">The current customer to compare with</param>
		/// <param name="index">The index of the current customer</param>
		/// <returns>True if current customer matches the search criteria, otherwise False</returns>
		public override bool ApplyFilter(Product customer, int index)
		{
			// TODO: Do I want to allow for nothing values?
			return customer is not null && customer.Name.Contains(Filter);
		}
	}
}
