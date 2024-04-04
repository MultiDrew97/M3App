using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

	public partial class PlaceOrderDialog
	{
		private event CartItemAddedEventHandler CartItemAdded;

		private delegate void CartItemAddedEventHandler();

		// Private ReadOnly Property Cart As New Collection(Of Types.CartItem)

		public double OrderTotal
		{
			get
			{
				double sum = 0d;

				foreach (var item in cc_Cart.Cart)
					sum += item.ItemTotal;

				return sum;
			}
		}

		public PlaceOrderDialog()
		{
			InitializeComponent();
		}

		private void Reload()
		{
			ccb_Customers.Reload();
			pcb_Items.Reload();
			qnc_Quantity.Quantity = 1;
			otc_Total.Total = 0d;
		}

		private void Checkout(object sender, EventArgs e)
		{
			Types.Customer selectedCustomer = (Types.Customer)ccb_Customers.SelectedItem;
			var response = MessageBox.Show($"Are you sure you want to place an order for {selectedCustomer.Name}?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (response == DialogResult.No)
			{
				return;
			}

			bw_PlaceOrders.RunWorkerAsync(selectedCustomer.Id);
		}

		private void Cancel(object sender, EventArgs e)
		{
			var res = MessageBox.Show("Are you sure you want to cancel placing this order?", "Cancel Order Placement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

			if (res == DialogResult.No)
			{
				return;
			}

			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void DialogLoading(object sender, EventArgs e)
		{
			Reload();
		}

		private void AddToCart(object sender, EventArgs e)
		{
			cc_Cart.Add((Types.Product)pcb_Items.SelectedItem, qnc_Quantity.Quantity);

			CartItemAdded?.Invoke();
		}

		private void ItemAdded(double total)
		{
			otc_Total.Total = total;
		}

		private void PlaceOrders(object sender, DoWorkEventArgs e)
		{
			int customerID = Conversions.ToInteger(e.Argument);
			int failedOrders = 0;
			foreach (var item in cc_Cart.Cart)
			{
				try
				{
					db_Orders.AddOrder(customerID, item.ItemID, item.Quantity);
				}
				catch (Exception ex)
				{
					failedOrders += 1;
				}
			}

			e.Result = failedOrders;
		}

		private void OrdersPlaced(object sender, RunWorkerCompletedEventArgs e)
		{
			int failed = Conversions.ToInteger(e.Result);
			if (e.Cancelled)
			{
				return;
			}

			if (failed > 0)
			{
				MessageBox.Show($"{failed} order{(failed > 1 ? "s were" : "was")} unable to be placed. Please check the orders panel to see which items were not added and try again.", "Order Failures", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			var res = MessageBox.Show("Would you like to place any more orders?", "More Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (res == DialogResult.No)
			{
				Close();
				return;
			}

			Reload();
		}
	}
}
