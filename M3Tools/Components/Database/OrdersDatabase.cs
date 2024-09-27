using System;
using System.Linq;
using System.Threading.Tasks;

namespace SPPBC.M3Tools.Database
{
	public sealed partial class OrdersDatabase
	{
		/// <summary>
		/// Retrieve an order by its order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<Types.Order> GetOrderById(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? await ExecuteWithResultAsync<Types.Order>(System.Net.Http.HttpMethod.Get, string.Join(Paths.Separator, Paths.Orders, orderID), string.Empty, ct)
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
		public async Task<Types.OrderCollection> GetOrderByCustomer(int customerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(customerID)
				? Types.OrderCollection.Cast((await GetOrders()).Where((curr, index) => curr.Customer.Id == customerID).ToList())
				: throw new ArgumentException("ID values must be greater than or equal to 0");

		/// <summary>
		/// Retrieve the complete list of orders from the database
		/// </summary>
		/// <returns></returns>
		public async Task<Types.OrderCollection> GetOrders(System.Threading.CancellationToken ct = default)
			=> await ExecuteWithResultAsync<Types.OrderCollection>(System.Net.Http.HttpMethod.Get, Paths.Orders, string.Empty, ct);

		/// <summary>
		/// Add a new order to the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="itemID"></param>
		/// <param name="quantity"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public async Task<bool> AddOrder(int customerID, int itemID, int quantity, System.Threading.CancellationToken ct = default)
			=> true switch
			{
				var invalidCustomer when invalidCustomer == !Utils.ValidID(customerID) => throw new ArgumentException($"Invalid customer ID '{customerID}' provided"),
				var invalidItem when invalidItem == !Utils.ValidID(itemID) => throw new ArgumentException($"Invalid item ID '{itemID}' provided"),
				var invalidQuantity when invalidQuantity == (quantity < 1) => throw new ArgumentException($"Invalid quantity value '{quantity}' provided"),
				_ => await AddOrder(new(-1, customerID, itemID, quantity), ct),
			};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		/// <param name="ct"></param>
		public async Task<bool> AddOrder(Types.Order order, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Post, Paths.Orders, M3API.JSON.ConvertToJSON(order), ct);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		/// <param name="ct"></param>
		public async Task<bool> UpdateOrder(Types.Order order, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Put, string.Join(Paths.Separator, Paths.Orders, order.Id), M3API.JSON.ConvertToJSON(order), ct);

		/// <summary>
		/// Cancel an order based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public async Task<bool> CancelOrder(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? await RemoveOrder(orderID, false, ct)
				: throw new ArgumentException($"Invalid OrderID provided");

		/// <summary>
		/// Mark an order as complete based on the provided order ID
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public async Task<bool> CompleteOrder(int orderID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(orderID)
				? await RemoveOrder(orderID, true, ct)
				: throw new ArgumentException("ID values must be greater than or equal to 0");

		private async Task<bool> RemoveOrder(int orderID, bool completed, System.Threading.CancellationToken ct)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Delete, string.Join(Paths.Separator, Paths.Orders, $"{orderID}?{(completed ? "completed" : "")}"), string.Empty, ct);
	}
}
