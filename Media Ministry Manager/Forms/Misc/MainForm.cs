using System;
using System.Windows.Forms;

namespace M3App
{
	/// <summary>
	/// Main form for all operations
	/// </summary>
	public partial class MainForm
	{
		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			// Menu Strip
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.Logout += new EventHandler(Logout);
			mms_Main.AddCustomer += new SPPBC.M3Tools.Events.Customers.CustomerEventHandler(AddCustomer);
			mms_Main.AddListener += new SPPBC.M3Tools.Events.Listeners.ListenerEventHandler(AddListener);
			mms_Main.AddOrder += new SPPBC.M3Tools.Events.Orders.OrderEventHandler(AddOrder);
			mms_Main.AddInventory += new SPPBC.M3Tools.Events.Inventory.InventoryEventHandler(AddInventory);

			// Management Buttons
			btn_ProductManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Inventory));
			btn_CustomerManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Customers));
			btn_ListenerManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Listeners));
			btn_OrderManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Orders));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			// Place any custom closing behavior here
			UseWaitCursor = false;
			base.OnFormClosed(e);

			//if (Application.OpenForms.Count > 0)
			//{
			//	return;
			//}

			//Utils.Exit();
		}

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			UseWaitCursor = true;
			try
			{
				Utils.OpenForm(e.Manage switch
				{
					SPPBC.M3Tools.Events.ManageType.Customers => typeof(CustomerManagement),
					SPPBC.M3Tools.Events.ManageType.Listeners => typeof(ListenerManagement),
					SPPBC.M3Tools.Events.ManageType.Orders => typeof(OrderManagement),
					SPPBC.M3Tools.Events.ManageType.Inventory => typeof(InventoryManagement),
					_ => throw new ArgumentException($"Unknown manage type {e.Manage}")
				});
				Close();
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		private void Logout(object sender, EventArgs e)
		{
			Utils.Logout(this);
			Close();
		}

		// TODO: Try to remove the need to have each DB object in the main form
		private void AddCustomer(object sender, SPPBC.M3Tools.Events.Customers.CustomerEventArgs e)
		{
			UseWaitCursor = true;
			//_ = dbCustomer.AddCustomer(e.Value);
			//_ = MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddListener(object sender, SPPBC.M3Tools.Events.Listeners.ListenerEventArgs e)
		{
			UseWaitCursor = true;
			//_ = dbListener.AddListener(e.Value);
			//_ = MessageBox.Show($"Successfully created listener", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddInventory(object sender, SPPBC.M3Tools.Events.Inventory.InventoryEventArgs e)
		{
			UseWaitCursor = true;
			//_ = dbInventory.AddInventory(e.Value);
			//_ = MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddOrder(object sender, SPPBC.M3Tools.Events.Orders.OrderEventArgs e)
		{
			UseWaitCursor = true;
			//_ = dbOrders.AddOrder(e.Value);
			//_ = MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void ViewSettings(object sender, EventArgs e)
		{
			SettingsForm settings = new();
			settings.Show();
		}
	}
}
