using System;
using System.Linq;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// 
	/// </summary>
	public class OrderCollection : DbEntryCollection<Order>
	{
		/// <summary>
		/// Attempt to cast a collection to a order collection
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static new OrderCollection Cast(System.Collections.IEnumerable source)
		{
			if (source == null)
			{
				return [];
			}

			OrderCollection result;

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = [];
					foreach (DataGridViewRow row in source)
					{
						result.Add((Order)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
				case var @genList when @genList == typeof(System.Collections.Generic.List<Order>):
				case var @genIList when @genIList == typeof(System.Collections.Generic.IList<Order>):
				case var @collection when collection == typeof(System.Collections.ICollection):
				case var @enum when @enum == typeof(System.Collections.IEnumerable):
					result = [.. source.Cast<Order>().ToList()];

					return result;
				case var @dbColl when dbColl == typeof(OrderCollection):
					return (OrderCollection)source;
				default:
					throw new Exception("Unable to cast collection to OrderCollection");
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="order">The current customer to compare with</param>
		/// <param name="index">The index of the current customer</param>
		/// <returns>True if current customer matches the search criteria, otherwise False</returns>
		public override bool ApplyFilter(Order order, int index) =>
			// TODO: Find best way to check against order number to search by that param as well
			order is not null && (order.Customer.Name.Contains(Filter) || order.Item.Name.Contains(Filter));
	}
}
