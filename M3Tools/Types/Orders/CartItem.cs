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
		public Product Item { get; set; }

		/// <summary>
		/// How many of this item to have in the cart
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string ItemName => Item.Name;

		/// <summary>
		/// The complete total for the amount of the item in the cart
		/// </summary>
		public double ItemTotal => (double)(Item.Price * Quantity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="product"></param>
		/// <param name="quantity"></param>
		public CartItem(Product product, int quantity)
		{
			Item = product;
			Quantity = quantity;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(CartItem left, CartItem right)
		{
			return !(left is null ^ right is null) && left?.Item == right?.Item;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(CartItem left, CartItem right)
		{
			return !(left == right);
		}
	}
}
