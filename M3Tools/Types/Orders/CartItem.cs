
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An item with in the cart.
	/// Contains item info as well as quantity
	/// </summary>
	public class CartItem
	{
		/// <summary>
		/// The item for this cart item entry
		/// </summary>
		public Product Product { get; set; }

		/// <summary>
		/// How many of this item to have in the cart
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// The complete total for the amount of the item in the cart
		/// </summary>
		public double ItemTotal => (double)(Product.Price * Quantity);

		/// <summary>
		/// The name of the item
		/// </summary>
		public string ItemName => Product.Name;

		/// <summary>
		/// The ID of the item in the cart
		/// </summary>
		public int ItemID => Product.Id;

		/// <summary>
		/// The price of one of the item
		/// </summary>
		public double ItemPrice => (double)Product.Price;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="product"></param>
		/// <param name="quantity"></param>
		public CartItem(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
}
