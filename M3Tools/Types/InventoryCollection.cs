
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
		public static new InventoryCollection Cast(System.Collections.ICollection collection)
		{
			InventoryCollection list = new();
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in collection)
					{
						list.Add((Product)row.DataBoundItem);
					}
					break;
			}



			return list;
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
            if (customer is null)
            {
                return false;
            }

			return customer.Name.Contains(Filter);
        }
    }
}
