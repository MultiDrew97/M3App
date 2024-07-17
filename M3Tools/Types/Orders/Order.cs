using System;

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
		[System.Text.Json.Serialization.JsonPropertyName("orderID")]
		public new int Id { get; }

		/// <summary>
		/// The customer the order was placed for
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("customer")]
		public Customer Customer { get; set; }

		/// <summary>
		/// The item the order was placed for
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("item")]
		public Product Item { get; set; }

		/// <summary>
		/// How many of the item the customer wanted
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// The subtotal for the order
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("total")]
		public double OrderTotal
		{
			get
			{
				return (double)(Item.Price * Quantity);
			}
		}

		/// <summary>
		/// The date the order was placed
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("ordered")]
		public DateTime OrderDate { get; set; }

		/// <summary>
		/// The date the order was fulfilled
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("completed")]
		public DateTime CompletedDate { get; set; }

		/// <summary>
		/// An empty instance of an Order object
		/// </summary>
		public new static Order None { get; } = new();

		/// <summary>
		/// 
		/// </summary>
		public Order() : this(-1)
		{
		}

		/// <summary>
		/// New CurrentOrder Object
		/// </summary>
		/// <param name="orderID"></param>
		/// <param name="customerID"></param>
		/// <param name="itemID"></param>
		/// <param name="quantity"></param>
		/// <param name="orderDate"></param>
		/// <param name="completedDate"></param>
		public Order(int orderID, int customerID = -1, int itemID = -1, int quantity = 0, DateTime orderDate = default, DateTime completedDate = default): base(orderID)
		{
			Quantity = quantity;
			OrderDate = orderDate.Year < 2000 ? DateTime.Now : orderDate;
			CompletedDate = completedDate;
			GetCustomer(customerID);
			GetItem(itemID);
		}

		/// <summary>
		/// Retrieve a user from the database using their CustomerID
		/// </summary>
		/// <param name="customerID">CustomerID of the desired customer</param>
		private void GetCustomer(int customerID)
		{
			if (!Utils.ValidID(customerID))
			{
				return;
			}

			using var c = new Database.CustomerDatabase();
			Customer = c.GetCustomer(customerID);
		}

		/// <summary>
		/// Retrieve an item from the database using the provided itemID
		/// </summary>
		/// <param name="itemID">ItemID of the desired item</param>
		private void GetItem(int itemID)
		{
			if (!Utils.ValidID(itemID))
			{
				return;
			}

			using var i = new Database.InventoryDatabase();
			Item = i.GetProduct(itemID);
		}

		// Public Overrides Sub UpdateID(newID As Integer)
		// If newID = Id Then
		// Return
		// End If

		// Using conn As New Database.OrdersDatabase
		// Dim newOrder = conn.GetOrderById(newID)

		// ' TODO: Finish implementing updates
		// End Using
		// End Sub

		/// <summary>
		/// Clones a copy of the current Order object
		/// </summary>
		/// <returns></returns>
		public Order Clone()
		{
			return new Order(Id, Customer.Id, Item.Id, Quantity, OrderDate, CompletedDate);
		}
	}
}
