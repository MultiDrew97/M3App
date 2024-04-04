using System;

namespace SPPBC.M3Tools.Types
{
	// TODO: Consolidate CurrentOrder and CompletedOrder
	public class Order : DbEntry
	{

		[System.Text.Json.Serialization.JsonPropertyName("orderID")]
		public int Id { get; }

		[System.Text.Json.Serialization.JsonPropertyName("customer")]
		public Person Customer { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("item")]
		public Product Item { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("total")]
		public double OrderTotal
		{
			get
			{
				return (double)(Item.Price * Quantity);
			}
		}

		[System.Text.Json.Serialization.JsonPropertyName("ordered")]
		public DateTime OrderDate { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("completed")]
		public DateTime CompletedDate { get; set; }

		public static Order None { get; } = new Order();

		public Order() : this(-1)
		{
		}

		/// <summary>
		/// 		''' New CurrentOrder Object
		/// 		''' </summary>
		/// 		''' <param name="orderID"></param>
		/// 		''' <param name="customerID"></param>
		/// 		''' <param name="itemID"></param>
		/// 		''' <param name="quantity"></param>
		/// 		''' <param name="orderDate"></param>
		public Order(int orderID, int customerID = -1, int itemID = -1, int quantity = 0, DateTime orderDate = default, DateTime completedDate = default): base(orderID)
		{
			Quantity = quantity;
			OrderDate = orderDate.Year < 2000 ? DateTime.Now : orderDate;
			CompletedDate = completedDate;
			GetCustomer(customerID);
			GetItem(itemID);
		}

		/// <summary>
		/// 		''' Retrieve a user from the database using their CustomerID
		/// 		''' </summary>
		/// 		''' <param name="customerID">CustomerID of the desired customer</param>
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
		/// 		''' Retrieve an item from the database using the provided itemID
		/// 		''' </summary>
		/// 		''' <param name="itemID">ItemID of the desired item</param>
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

		public Order Clone()
		{
			return new Order(Id, Customer.Id, Item.Id, Quantity, OrderDate, CompletedDate);
		}
	}
}
