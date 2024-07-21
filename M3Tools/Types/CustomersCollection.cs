using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// 
	/// </summary>
	public class CustomerCollection : DbEntryCollection<Customer>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static new CustomerCollection Cast(System.Collections.IList source)
		{
			if (source == null || source.Count <= 0)
			{
				return new();
			}

			CustomerCollection result;

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = new();
					foreach (DataGridViewRow row in source)
					{
						result.Add((Customer)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
				case var @collection when collection == typeof(System.Collections.ICollection):
					result = new();

					foreach (Customer item in source)
					{
						result.Add(item);
					}

					return result;
				case var @dbColl when dbColl == typeof(CustomerCollection):
					return (CustomerCollection)source;
				default:
					throw new Exception("Unable to cast collection to CustomerCollection");
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="customer">The current customer to compare with</param>
		/// <param name="index">The index of the current customer</param>
		/// <returns>True if current customer matches the search criteria, otherwise False</returns>
		public override bool ApplyFilter(Customer customer, int index)
		{
			return customer is not null && (customer.Name.Contains(Filter) || customer.Email.Contains(Filter) || customer.Phone.Contains(Filter));
		}
	}
}
