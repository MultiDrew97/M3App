using System;
using System.Text.Json.Serialization;

namespace SPPBC.M3Tools.Types
{
	// TODO: Consolidate CurrentOrder and CompletedOrder
	/// <summary>
	/// 
	/// </summary>
	public class Order : DbEntry
	{

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[JsonPropertyName("orderID")]
		public override int Id
		{
			get => base.Id;
			set => base.Id = value;
		}

		/// <summary>
		/// The customer the order was placed for
		/// </summary>
		[JsonPropertyName("customer")]
		public Customer Customer { get; set; }

		/// <summary>
		/// The item the order was placed for
		/// </summary>
		[JsonPropertyName("item")]
		public Product Item { get; set; }

		/// <summary>
		/// How many of the item the customer wanted
		/// </summary>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// The subtotal for the order
		/// </summary>
		[JsonPropertyName("total")]
		public double Total => (double)(Item.Price * Quantity);

		/// <summary>
		/// The date the order was placed
		/// </summary>
		[JsonPropertyName("ordered")]
		public DateTime OrderDate { get; set; }

		/// <summary>
		/// The date the order was fulfilled
		/// </summary>
		[JsonPropertyName("completed")]
		public DateTime CompletedDate { get; set; }

		/// <summary>
		/// An empty instance of an Order object
		/// </summary>
		public static new Order None { get; } = new();

		/// <summary>
		/// 
		/// </summary>
		public Order() : this(-1)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderID"></param>
		public Order(int orderID) : this(orderID, -1, -1, 0, default, default)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="customerID"></param>
		/// <param name="itemID"></param>
		/// <param name="quantity"></param>
		/// <param name="orderDate"></param>
		/// <param name="completedDate"></param>
		public Order(int orderID, int customerID, int itemID, int quantity, DateTime orderDate = default, DateTime completedDate = default) : this(orderID, new Customer(customerID), new Product(itemID), quantity, orderDate, completedDate)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="customer"></param>
		/// <param name="item"></param>
		/// <param name="quantity"></param>
		/// <param name="orderDate"></param>
		/// <param name="completedDate"></param>
		public Order(int orderID, Customer customer, Product item, int quantity, DateTime orderDate, DateTime completedDate) : base(orderID)
		{
			Customer = customer;
			Item = item;
			Quantity = quantity;
			OrderDate = orderDate.Year < 2000 ? DateTime.Now : orderDate;
			CompletedDate = completedDate.Year < 2000 ? DateTime.MinValue : completedDate;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(Order left, Order right)
		{
			return !(left is null ^ right is null) && left.Id == right.Id && left.Customer == right.Customer && left.Item == right.Item && left.Quantity == right.Quantity && left.OrderDate == right.OrderDate && left.CompletedDate == right.CompletedDate;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(Order left, Order right)
		{
			return !(left == right);
		}

		/// <summary>
		/// Clones a copy of the current Order object
		/// </summary>
		/// <returns></returns>
		public new Order Clone()
		{
			return new Order(Id, Customer.Id, Item.Id, Quantity, OrderDate, CompletedDate);
		}
	}
}
