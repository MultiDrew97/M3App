using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public partial class CartCtrl
	{
		/// <summary>
		/// The event that occurs when an item is added
		/// </summary>
		// TODO: Turn into component?
		public event ItemAddedEventHandler ItemAdded;

		/// <summary>
		/// The event that occurs when an item is updated
		/// </summary>
		public event ItemUpdatedEventHandler ItemUpdated;

		/// <summary>
		/// The event handler that will handle an item being added
		/// </summary>
		/// <param name="total"></param>
		public delegate void ItemAddedEventHandler(double total);

		/// <summary>
		/// The event handler that will handle an item being updated
		/// </summary>
		/// <param name="item"></param>
		public delegate void ItemUpdatedEventHandler(Types.CartItem item);

		/// <summary>
		/// The cart of items
		/// </summary>
		public BindingList<Types.CartItem> Cart
		{
			get
			{
				return (BindingList<Types.CartItem>)bsCart.List;
			}
		}

		/// <summary>
		/// The subtotal of the cart
		/// </summary>
		public double Total
		{
			get
			{
				var sum = default(double);

				foreach (var item in Cart)
					sum += item.ItemTotal;

				return sum;
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
			int i = FindItem(item);
			if (i > -1)
			{
				Types.CartItem curr = (Types.CartItem)bsCart[i];

				curr.Quantity += item.Quantity;
			}
			else
			{
				bsCart.Add(item);
			}

			ItemAdded?.Invoke(Total);
		}

		/// <summary>
		/// Add a list of cart items
		/// </summary>
		/// <param name="items"></param>
		public void AddRange(params Types.CartItem[] items)
		{
			foreach (var item in items)
				Add(item);
		}

		private void CartLoaded(object sender, EventArgs e)
		{
			bsCart.Clear();
		}

		private void Reload(double total)
		{
			dgv_Cart.Refresh();
		}

		private void Temp(Types.CartItem item)
		{
			ItemAdded?.Invoke(Total);
		}

		private void ItemValuesUpdated(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			ItemUpdated?.Invoke((Types.CartItem)bsCart[e.RowIndex]);
		}

		private void RemoveItem(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(e.ColumnIndex == dgc_Remove.DisplayIndex))
			{
				return;
			}
			Types.CartItem removed = (Types.CartItem)bsCart[e.RowIndex];
			bsCart.Remove(removed);
			ItemUpdated?.Invoke(removed);
		}

		private int FindItem(Types.CartItem item)
		{
			foreach (var current in Cart)
			{
				if (current.ItemID == item.ItemID)
				{
					return bsCart.IndexOf(current);
				}
			}

			return -1;
		}
	}
}
