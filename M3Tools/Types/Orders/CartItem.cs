
namespace SPPBC.M3Tools.Types
{
	public class CartItem
	{
		private Product Product { get; set; }
		public int Quantity { get; set; }

		public double ItemTotal
		{
			get
			{
				return (double)(Product.Price * Quantity);
			}
		}

		public string ItemName
		{
			get
			{
				return Product.Name;
			}
		}

		public int ItemID
		{
			get
			{
				return Product.Id;
			}
		}

		public double ItemPrice
		{
			get
			{
				return (double)Product.Price;
			}
		}

		public CartItem()
		{
			// Me.New(New Item(), 0)
		}

		public CartItem(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
}
