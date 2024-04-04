using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public partial class EditOrderDialog
	{
		private Types.Order _order;
		private Types.Order _changed;

		public int OrderID { get; set; }

		public Types.Order CurrentOrder
		{
			get
			{
				return _order;
			}
			set
			{
				_order = value;
			}
		}

		public Types.Order UpdatedOrder
		{
			get
			{
				return _changed;
			}
			set
			{
				_changed = value;
			}
		}

		public EditOrderDialog(int orderID)
		{
			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.
			OrderID = orderID;
		}

		private void Finished(object sender, EventArgs e)
		{
			if (!ChangesDetected())
			{
				MessageBox.Show("No changes were detected", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			db_Orders.UpdateOrder(UpdatedOrder);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void DialogLoading(object sender, EventArgs e)
		{
			bw_LoadOrder.RunWorkerAsync();
			pcb_Items.Reload();
		}

		private void LoadOrder(object sender, DoWorkEventArgs e)
		{
			try
			{
				CurrentOrder = db_Orders.GetOrderById(OrderID);
			}
			catch (Exception ex)
			{
				e.Cancel = true;
			}
		}

		private void OrderLoaded(object sender, RunWorkerCompletedEventArgs e)
		{
			if (CurrentOrder is null | e.Cancelled)
			{
				return;
			}

			gi_CustomerName.Text = CurrentOrder.Customer.Name;
			pcb_Items.SelectedValue = CurrentOrder.Item.Id;
			qnc_Quantity.Quantity = CurrentOrder.Quantity;

			UpdatedOrder = CurrentOrder.Clone();
		}

		private void ItemsLoadBegin()
		{
			UseWaitCursor = true;
		}

		private void ItemsLoadEnd()
		{
			UseWaitCursor = false;
		}

		private bool ChangesDetected()
		{
			if (UpdatedOrder.Quantity != CurrentOrder.Quantity)
			{
				return true;
			}

			if (UpdatedOrder.Item.Id != CurrentOrder.Item.Id)
			{
				return true;
			}

			return false;
		}

		private void SelectedItemChanged(int newValue)
		{
			if (!Utils.ValidID(newValue) || pcb_Items.Disposing || UpdatedOrder is null)
			{
				return;
			}

			// UpdatedOrder.Product.UpdateID(newValue)
		}

		private void QuantityUpdated(int newQuantity)
		{
			if (newQuantity <= 0 || UpdatedOrder is null)
			{
				return;
			}

			UpdatedOrder.Quantity = newQuantity;
		}
	}
}
