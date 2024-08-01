using System;
using System.Linq;
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
		public static new CustomerCollection Cast(System.Collections.IEnumerable source)
		{
			if (source == null)
			{
				return [];
			}

			CustomerCollection result;

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = [];
					foreach (DataGridViewRow row in source)
					{
						result.Add((Customer)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
				case var @genList when @genList == typeof(System.Collections.Generic.List<Customer>):
				case var @genIList when @genIList == typeof(System.Collections.Generic.IList<Customer>):
				case var @collection when collection == typeof(System.Collections.ICollection):
				case var @enum when @enum == typeof(System.Collections.IEnumerable):
					result = [.. source.Cast<Customer>().ToList()];

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
		public override bool ApplyFilter(Customer customer, int index) => customer is not null && (customer.Name.ToLower().Contains(Filter) || customer.Email.ToLower().Contains(Filter) || customer.Phone.Contains(Filter));
	}
}
