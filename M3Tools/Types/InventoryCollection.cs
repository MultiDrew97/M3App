
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Filterable collection of customers
	/// </summary>
    public class InventoryCollection : DBEntryCollection<Product>
    {
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
