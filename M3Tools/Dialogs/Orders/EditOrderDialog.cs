using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EditOrderDialog
	{

		private SPPBC.M3Tools.Types.CustomerCollection Customers { set => ccbx_Customers.Customers = value; }
		private SPPBC.M3Tools.Types.InventoryCollection Inventory { set => icbx_Inventory.Inventory = value; }

		/// <summary>
		/// The info for the current order
		/// </summary>
		private SPPBC.M3Tools.Types.Order CurrentOrder { get; set; }

		/// <summary>
		/// The updated info for the order
		/// </summary>
		public SPPBC.M3Tools.Types.Order UpdatedOrder
		{
			get => new(CurrentOrder.Id, ccbx_Customers.SelectedItem, icbx_Inventory.SelectedItem, qnc_Quantity.Quantity, CurrentOrder.OrderDate, CurrentOrder.CompletedDate);
			set
			{
				ccbx_Customers.SelectedValue = value.Customer.Id;
				icbx_Inventory.SelectedValue = value.Item.Id;
				qnc_Quantity.Quantity = CurrentOrder.Quantity;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public EditOrderDialog(SPPBC.M3Tools.Types.Order order, SPPBC.M3Tools.Types.CustomerCollection customers, SPPBC.M3Tools.Types.InventoryCollection inventory)
		{
			// This call is required by the designer.
			InitializeComponent();

			// Load Combo boxes
			// TODO: Figure out how to not need to do this effectively, and load list with in control
			Customers = customers;
			Inventory = inventory;

			// Add any initialization after the InitializeComponent() call.
			CurrentOrder = order;
			UpdatedOrder = order.Clone();
		}

		private void Finished(object sender, EventArgs e)
		{
			if (UpdatedOrder == CurrentOrder)
			{
				_ = MessageBox.Show("No changes were detected", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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

		}

		private bool ChangesDetected() => UpdatedOrder != CurrentOrder;
	}
}
