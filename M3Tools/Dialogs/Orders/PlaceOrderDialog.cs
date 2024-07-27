using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PlaceOrderDialog
	{
		public Types.CustomerCollection Customers
		{
			set => ccb_Customers.Customers = value;
		}

		public Types.InventoryCollection Inventory
		{
			set => pcb_Items.Inventory = value;
		}

		// Private ReadOnly Property Cart As New Collection(Of Types.CartItem)
		// MAYBE: Implement a cart system instead of using one item per row
		/// <summary>
		/// 
		/// </summary>
		public Types.CartItemCollection Cart => cc_Cart.Cart;//new(-1, ccb_Customers.SelectedItem, pcb_Items.SelectedItem, qnc_Quantity.Quantity, default, default);

		/// <summary>
		/// 
		/// </summary>
		public Types.Customer Customer => ccb_Customers.SelectedItem;

		/// <summary>
		/// The total for the order
		/// </summary>
		public double OrderTotal => cc_Cart.Total;

		/// <summary>
		/// 
		/// </summary>
		public PlaceOrderDialog(Types.CustomerCollection customers, Types.InventoryCollection inventory)
		{
			InitializeComponent();

			Customers = customers;
			Inventory = inventory;
		}

		private void Reload(object sender, EventArgs e)
		{
			qnc_Quantity.Quantity = 1;
			otc_Total.Total = 0d;
		}

		private void Checkout(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show($"Are you sure you want to place an order for {Customer.Name}?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result != DialogResult.Yes)
			{
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to cancel placing this order?", "Cancel Order Placement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

			if (res == DialogResult.No)
			{
				return;
			}

			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void AddToCart(object sender, EventArgs e)
		{
			cc_Cart.Add(pcb_Items.SelectedItem, qnc_Quantity.Quantity);

			otc_Total.Total = OrderTotal;
		}
	}
}
