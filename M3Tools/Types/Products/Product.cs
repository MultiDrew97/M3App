using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An inventory item
	/// </summary>
	public class Product : DbEntry
	{

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[System.Text.Json.Serialization.JsonPropertyName("itemID")]
		public new int Id { get; }

		/// <summary>
		/// The name of the item
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("itemName")]
		public string Name { get; set; }

		/// <summary>
		/// How many of the item is currently in stock
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("stock")]
		public int Stock { get; set; }

		/// <summary>
		/// The price per unit of the item
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("price")]
		public decimal Price { get; set; }

		/// <summary>
		/// Whether the item is currently available to purchase
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("available")]
		public bool Available { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Product() : this(-1)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productID"></param>
		/// <param name="name"></param>
		/// <param name="stock"></param>
		/// <param name="price"></param>
		/// <param name="available"></param>
		public Product(int productID, string name = "New Product", int stock = 0, decimal price = 0m, bool available = false): base(productID)
		{
			Name = name;
			Stock = stock;
			Price = price;
			Available = available;
		}

		/// <summary>
		/// Returns the item in a display friendly format
		/// </summary>
		/// <returns></returns>
		public string Display()
		{
			return $"{Id}) {Name} ({Price.FormatPrice()}) {(Available ? "Available" : "Not Available")}";
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Join(My.Settings.Default.ObjectDelimiter, Id, Name, Stock, Price.FormatPrice(), Available ? "Available" : "Not Available");
		}
	}
}
