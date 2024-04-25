using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
	public class Product : DbEntry
	{

		[System.ComponentModel.Browsable(false)]
		[System.Text.Json.Serialization.JsonPropertyName("itemID")]
		public new int Id { get; }

		[System.Text.Json.Serialization.JsonPropertyName("itemName")]
		public string Name { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("stock")]
		public int Stock { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("price")]
		public decimal Price { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("available")]
		public bool Available { get; set; }

		public Product() : this(-1)
		{
		}

		public Product(int productID, string name = "New Product", int stock = 0, decimal price = 0m, bool available = false): base(productID)
		{
			Name = name;
			Stock = stock;
			Price = price;
			Available = available;
		}

		public string Display()
		{
			return $"{Id}) {Name} ({Price.FormatPrice()}) {(Available ? "Available" : "Not Available")}";
		}

		public override string ToString()
		{
			return string.Join(My.Settings.Default.ObjectDelimiter, Id, Name, Stock, Price.FormatPrice(), Available ? "Available" : "Not Available");
		}
	}
}
