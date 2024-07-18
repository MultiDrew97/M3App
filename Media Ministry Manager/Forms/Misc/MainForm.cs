using System;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
	/// <summary>
	/// 
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
			mms_Main.ExitApplication += new EventHandler(ExitApp);
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
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLoad(EventArgs e)
		{
			// Place any custom loading behavior here
			base.OnLoad(e);
		}

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			UseWaitCursor = true;
			try
			{
				switch (e.Manage)
				{
					case SPPBC.M3Tools.Events.ManageType.Customers:
						UseWaitCursor = true;
						Utils.OpenForm(typeof(CustomerManagement));
						Close();
						break;
					case SPPBC.M3Tools.Events.ManageType.Listeners:
						UseWaitCursor = true;
						Utils.OpenForm(typeof(ListenerManagement));
						Close();
						break;
					case SPPBC.M3Tools.Events.ManageType.Orders:
#if !DEBUG
						MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						break;
#else
						UseWaitCursor = true;
						Utils.OpenForm(typeof(OrderManagement));
						Close();
						break;
#endif
					case SPPBC.M3Tools.Events.ManageType.Inventory:
						UseWaitCursor = true;
						Utils.OpenForm(typeof(InventoryManagement));
						Close();
						break;
				}
			}
			catch(ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.Error.WriteLine(ex.Message);
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		private void Logout(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			Utils.LogOff();
			Close();
		}

		private void ExitApp(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			Utils.CloseApplication();
			UseWaitCursor = false;
		}

		// TODO: Try to remove the need to have each DB object in the main form
		private void AddCustomer(object sender, SPPBC.M3Tools.Events.Customers.CustomerEventArgs e)
		{
			UseWaitCursor = true;
			dbCustomer.AddCustomer(e.Value);
			MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddListener(object sender, SPPBC.M3Tools.Events.Listeners.ListenerEventArgs e)
		{
			UseWaitCursor = true;
			dbListener.AddListener(e.Value);
			MessageBox.Show($"Successfully created listener", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddInventory(object sender, SPPBC.M3Tools.Events.Inventory.InventoryEventArgs e)
		{
			UseWaitCursor = true;
			dbInventory.AddInventory(e.Value);
			MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void AddOrder(object sender, SPPBC.M3Tools.Events.Orders.OrderEventArgs e)
		{
			UseWaitCursor = true;
			dbOrders.AddOrder(e.Value);
			MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UseWaitCursor = false;
		}

		private void ViewSettings(object sender, EventArgs e)
		{
			var settings = new SettingsForm();
			settings.Show();
		}
	}
}
