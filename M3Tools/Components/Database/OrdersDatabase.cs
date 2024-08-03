using System;
using System.Linq;

namespace SPPBC.M3Tools.Database
{
	public sealed partial class OrdersDatabase
	{
		private const string basePath = "orders";

		/// <summary>
		/// Retrieve an order by its order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public Types.Order GetOrderById(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? ExecuteWithResult<Types.Order>(System.Net.Http.HttpMethod.Get, $"{basePath}/{orderID}", string.Empty, ct).Result
				: throw new ArgumentException("ID values must be greater than or equal to 0");

		// TODO: Likely create a custom API path to search by customerID instead of orderID
		/// <summary>
		/// Retrieve an order based on the customer whom it's for
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="NotImplementedException"></exception>
		public Types.OrderCollection GetOrderByCustomer(int customerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(customerID)
				? Types.OrderCollection.Cast(GetOrders().Where((curr, index) => curr.Customer.Id == customerID).ToList())
				: throw new ArgumentException("ID values must be greater than or equal to 0");

		/// <summary>
		/// Retrieve the complete list of orders from the database
		/// </summary>
		/// <returns></returns>
		public Types.OrderCollection GetOrders(System.Threading.CancellationToken ct = default)
			=> ExecuteWithResult<Types.OrderCollection>(System.Net.Http.HttpMethod.Get, $"{basePath}", string.Empty, ct).Result;

		/// <summary>
		/// Add a new order to the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="itemID"></param>
		/// <param name="quantity"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public bool AddOrder(int customerID, int itemID, int quantity, System.Threading.CancellationToken ct = default)
			=> true switch
			{
				var invalidCustomer when invalidCustomer == !Utils.ValidID(customerID) => throw new ArgumentException($"Invalid customer ID '{customerID}' provided"),
				var invalidItem when invalidItem == !Utils.ValidID(itemID) => throw new ArgumentException($"Invalid item ID '{itemID}' provided"),
				var invalidQuantity when invalidQuantity == (quantity < 1) => throw new ArgumentException($"Invalid quantity value '{quantity}' provided"),
				_ => AddOrder(new(-1, customerID, itemID, quantity), ct),
			};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		/// <param name="ct"></param>
		public bool AddOrder(Types.Order order, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Post, $"{basePath}", M3API.JSON.ConvertToJSON(order), ct);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		/// <param name="ct"></param>
		public bool UpdateOrder(Types.Order order, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Put, $"{basePath}/{order.Id}", M3API.JSON.ConvertToJSON(order), ct);

		/// <summary>
		/// Cancel an order based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public bool CancelOrder(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? RemoveOrder(orderID, false, ct)
				: throw new ArgumentException($"Invalid OrderID provided");

		/// <summary>
		/// Mark an order as complete based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public bool CompleteOrder(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? RemoveOrder(orderID, true, ct)
				: throw new ArgumentException("ID values must be greater than or equal to 0");

		private bool RemoveOrder(int orderID, bool completed, System.Threading.CancellationToken ct)
			=> Execute(System.Net.Http.HttpMethod.Delete, $"{basePath}/{orderID}?{(completed ? "completed" : "")}", string.Empty, ct);
	}
}
