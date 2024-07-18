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
		public static new OrderCollection Cast(System.Collections.IList collection)
		{
			OrderCollection coll;
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					coll = new();
					foreach (DataGridViewRow row in collection)
					{
						coll.Add((Order)row.DataBoundItem);
					}
					return coll;
				case var @list when @list == typeof(System.Collections.IList):
				case var @gen_list when @gen_list == typeof(List<Order>):
					coll = new();
					foreach (Order item in collection)
					{
						coll.Add(item);
					}
					return coll;
				case var @dbColl when dbColl == typeof(OrderCollection):
					return (OrderCollection)collection;
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
