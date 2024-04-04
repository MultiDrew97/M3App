using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public partial class CartCtrl
	{
		// TODO: Turn into component?
		public event ItemAddedEventHandler ItemAdded;

		public delegate void ItemAddedEventHandler(double total);
		public event ItemUpdatedEventHandler ItemUpdated;

		public delegate void ItemUpdatedEventHandler(Types.CartItem item);

		public BindingList<Types.CartItem> Cart
		{
			get
			{
				return (BindingList<Types.CartItem>)bsCart.List;
			}
		}

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

		public CartCtrl()
		{
			InitializeComponent();
		}

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
