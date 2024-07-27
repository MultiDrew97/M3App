using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public partial class CartCtrl
	{
		/// <summary>
		/// The cart of items
		/// </summary>
		public Types.CartItemCollection Cart => Types.CartItemCollection.Cast(dgv_Cart.Rows);

		/// <summary>
		/// The subtotal of the cart
		/// </summary>
		public double Total
		{
			get
			{
				double sum = 0;

				foreach (Types.CartItem item in Cart)
				{
					sum += item.ItemTotal;
				}

				return sum;
			}
		}

		/// <summary>
		/// Find the cart item instance related to the product passed
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public Types.CartItem this[Types.Product item]
		{
			get
			{
				foreach (Types.CartItem curr in Cart)
				{
					if (curr.Item != item)
					{
						continue;
					}

					return curr;
				}

				return null;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public CartCtrl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Add an entry to the cart
		/// </summary>
		/// <param name="source"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static CartCtrl operator +(CartCtrl source, (Types.Product item, int quantity) right)
		{
			source.Add(right.item, right.quantity);
			return source;
		}

		/// <summary>
		/// Add an item to the cart
		/// </summary>
		/// <param name="item"></param>
		/// <param name="quantity"></param>
		public void Add(Types.Product item, int quantity)
		{
			Add(new Types.CartItem(item, quantity));
		}

		private void Add(Types.CartItem item)
		{
			if (this[item.Item] == null)
			{
				_ = bsCart.Add(item);
				return;
			}

			this[item.Item].Quantity += item.Quantity;

			dgv_Cart.Refresh();
		}

		private void RemoveItem(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(e.ColumnIndex == dgc_Remove.DisplayIndex))
			{
				return;
			}

			Types.CartItem removed = (Types.CartItem)bsCart[e.RowIndex];
			bsCart.Remove(removed);
		}
	}
}
