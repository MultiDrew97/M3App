
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An item with in the cart.
	/// Contains item info as well as quantity
	/// </summary>
	public class CartItem
	{
		private Product Product { get; set; }

		/// <summary>
		/// How many of this item to have in the cart
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// The complete total for the amount of the item in the cart
		/// </summary>
		public double ItemTotal
		{
			get
			{
				return (double)(Product.Price * Quantity);
			}
		}

		/// <summary>
		/// The name of the item
		/// </summary>
		public string ItemName
		{
			get
			{
				return Product.Name;
			}
		}

		/// <summary>
		/// The ID of the item in the cart
		/// </summary>
		public int ItemID
		{
			get
			{
				return Product.Id;
			}
		}

		/// <summary>
		/// The price of one of the item
		/// </summary>
		public double ItemPrice
		{
			get
			{
				return (double)Product.Price;
			}
		}

		/// <summary>
		/// <inheritdoc/>
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
