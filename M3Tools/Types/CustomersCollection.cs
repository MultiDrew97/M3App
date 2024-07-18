using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Filterable collection of customers
	/// </summary>
    public class CustomerCollection : DbEntryCollection<Customer>
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static new CustomerCollection Cast(System.Collections.IList collection)
		{
			CustomerCollection coll = new();
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in collection)
					{
						coll.Add((Customer)row.DataBoundItem);
					}
					break;
				default:
					throw new Exception("Unable to cast collection");
			}

			return coll;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="customer">The current customer to compare with</param>
		/// <param name="index">The index of the current customer</param>
		/// <returns>True if current customer matches the search criteria, otherwise False</returns>
        public override bool ApplyFilter(Customer customer, int index)
        {
            // TODO: Do I want to allow for nothing values?
            if (customer is null)
            {
                return false;
            }

            return customer.Name.Contains(Filter) || customer.Email.Contains(Filter) || customer.Phone.Contains(Filter);
        }
    }
}
