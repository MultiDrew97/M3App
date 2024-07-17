using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Gmail.v1.Data;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Used to hold the collection of orders
	/// </summary>
	public class OrderCollection : DbEntryCollection<Order>
	{
		/// <summary>
		/// Attempt to cast a collection to a order collection
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static new OrderCollection Cast(System.Collections.ICollection collection)
		{
			OrderCollection list = new();
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in collection)
					{
						list.Add((Order)row.DataBoundItem);
					}
					break;
				default:
					throw new Exception("Unable to cast collection");
			}

			return list;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="order">The current customer to compare with</param>
		/// <param name="index">The index of the current customer</param>
		/// <returns>True if current customer matches the search criteria, otherwise False</returns>
		public override bool ApplyFilter(Order order, int index)
		{
			// TODO: Do I want to allow for nothing values?
			if (order is null)
			{
				return false;
			}

			// TODO: Find best way to check against order number to search by that param as well
			return order.Customer.Name.Contains(Filter) || order.Item.Name.Contains(Filter);
		}
	}
}
