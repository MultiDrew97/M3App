using System;
using System.Linq;

using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
	public sealed partial class OrdersDatabase
	{
		private const string path = "orders";

		/// <summary>
		/// Retrieve the complete list of orders from the database
		/// </summary>
		/// <returns></returns>
		public OrderCollection GetOrders() => ExecuteWithResult<OrderCollection>(Method.Get, $"{path}").Result;

		/// <summary>
		/// Add a new order to the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="itemID"></param>
		/// <param name="quantity"></param>
		/// <exception cref="ArgumentException"></exception>
		public void AddOrder(int customerID, int itemID, int quantity)
		{
			if (!Utils.ValidID(customerID))
			{
				throw new ArgumentException($"Invalid customer ID '{customerID}' provided");
			}

			if (!Utils.ValidID(itemID))
			{
				throw new ArgumentException($"Invalid item ID '{itemID}' provided");
			}

			if (quantity < 1)
			{
				throw new ArgumentException($"Invalid quantity value '{quantity}' provided");
			}

			AddOrder(new(-1, customerID, itemID, quantity));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public void AddOrder(Order order) => Execute(Method.Post, $"{path}", JSON.ConvertToJSON(order));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public void UpdateOrder(Order order) => Execute(Method.Put, $"{path}/{order.Id}", JSON.ConvertToJSON(order));

		/// <summary>
		/// Cancel an order based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <exception cref="ArgumentException"></exception>
		public void CancelOrder(int orderID)
		{
			if (!Utils.ValidID(orderID))
			{
				throw new ArgumentException($"Invalid OrderID provided");
			}

			RemoveOrder(orderID, false);
		}

		/// <summary>
		/// Mark an order as complete based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <exception cref="ArgumentException"></exception>
		public void CompleteOrder(int orderID)
		{
			if (orderID < 0)
			{
				throw new ArgumentException("ID values must be greater than or equal to 0");
			}

			RemoveOrder(orderID, true);
		}

		private void RemoveOrder(int orderID, bool completed) =>
				Execute(Method.Delete, $"{path}/{orderID}?{(completed ? "completed" : "")}");

		/// <summary>
		/// Retrieve an order by its order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public Order GetOrderById(int orderID)
		{
			return !Utils.ValidID(orderID)
				? throw new ArgumentException("ID values must be greater than or equal to 0")
				: ExecuteWithResult<Order>(Method.Get, $"{path}/{orderID}").Result;
		}

		// TODO: Likely create a custom API path to search by customerID instead of orderID
		/// <summary>
		/// Retrieve an order based on the customer whom it's for
		/// </summary>
		/// <param name="customerID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="NotImplementedException"></exception>
		public OrderCollection GetOrderByCustomer(int customerID)
		{
			return !Utils.ValidID(customerID)
				? throw new ArgumentException("ID values must be greater than or equal to 0")
				: OrderCollection.Cast(GetOrders().Where((curr, index) => curr.Customer.Id == customerID).ToList());
		}
	}
}
