
using System;
using System.Linq;
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
		/// <param name="source"></param>
		/// <returns></returns>
		public static new InventoryCollection Cast(System.Collections.IEnumerable source)
		{
			if (source == null)
			{
				return [];
			}

			InventoryCollection result;
			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = [];
					foreach (DataGridViewRow row in source)
					{
						result.Add((Product)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
				case var @genList when @genList == typeof(System.Collections.Generic.List<Product>):
				case var @genIList when @genIList == typeof(System.Collections.Generic.IList<Product>):
				case var @collection when collection == typeof(System.Collections.ICollection):
				case var @enum when @enum == typeof(System.Collections.IEnumerable):
					result = [.. source.Cast<Product>().ToList()];

					return result;
				case var @dbColl when @dbColl == typeof(InventoryCollection):
					return (InventoryCollection)source;
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
		public override bool ApplyFilter(Product customer, int index) =>
			// TODO: Do I want to allow for nothing values?
			customer is not null && customer.Name.Contains(Filter);
	}
}
