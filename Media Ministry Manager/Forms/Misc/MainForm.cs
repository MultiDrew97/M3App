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

			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);
			FormClosed += ClosedForm;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClosedForm(object sender, EventArgs e)
		{
			UseWaitCursor = false;
		}

		private void Reload(object sender, EventArgs e)
		{
			tss_Feedback.Text = "What would you like to do?";
			tss_Feedback.ForeColor = SystemColors.WindowText;
			Focus();
		}

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			UseWaitCursor = true;
			try
			{
				switch (e.Manage)
				{
					case SPPBC.M3Tools.Events.ManageType.Customers:
						ManageCustomers(sender, e);
						break;
					case SPPBC.M3Tools.Events.ManageType.Listeners:
						ManageListeners(sender, e);
						break;
					case SPPBC.M3Tools.Events.ManageType.Orders:
						ManageOrders(sender, e);
						break;
					case SPPBC.M3Tools.Events.ManageType.Inventory:
						MangeInventory(sender, e);
						break;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.Error.WriteLine(ex.Message);
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		private void MangeInventory(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			Utils.OpenForm(typeof(InventoryManagement));
			//var products = new InventoryManagement();
			//products.Show();
			Close();
		}

		private void ManageOrders(object sender, EventArgs e)
		{
#if !DEBUG
			MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#endif
			UseWaitCursor = true;
			Utils.OpenForm(typeof(OrderManagement));
			//var orders = new OrderManagement();
			//orders.Show();
			Close();
		}

		private void ManageCustomers(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			Utils.OpenForm(typeof(CustomerManagement));
			//var customers = new CustomerManagement();
			//customers.Show();
			Close();
		}

		private void ManageListeners(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			Utils.OpenForm(typeof(ListenerManagement));
			//var listeners = new ListenerManagement();
			//listeners.Show();
			Close();
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

		private void AddProduct(object sender, SPPBC.M3Tools.Events.Inventory.InventoryEventArgs e)
		{
			UseWaitCursor = true;
			dbInventory.AddProduct(e.Value);
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
