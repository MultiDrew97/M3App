using System;
using System.ComponentModel;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
	// TODO: Figure out how to make controls editable from designer child designer natuarally
	// TODO: Figure out how to allow to be abstract and still have designer privleges
	/// <summary>
	/// 
	/// </summary>
	public abstract partial class ManagementForm<T> //where T : SPPBC.M3Tools.Types.IDbEntry
	{
		// private SPPBC.M3Tools.Data.CustomerBindingSource DataSource => (SPPBC.M3Tools.Data.CustomerBindingSource)cdg_Customers.DataSource; 

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public ManagementForm()
        {
            InitializeComponent();

			mms_Main.ExitApplication += new EventHandler(Exit);
			mms_Main.Logout += new EventHandler(LogOff);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(ChangeView);
		}

		/// <summary>
		/// Called when the display is being closed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected abstract void DisplayClosing(object sender, CancelEventArgs e);

		/// <summary>
		/// Reloads the display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected abstract void Reload(object sender, EventArgs e);

		private void LogOff(object sender, EventArgs e)
		{
			Close();
			Helpers.Utils.LogOff();
		}

		private void Exit(object sender, EventArgs e)
		{
			Helpers.Utils.CloseOpenForms();
		}

		private void ViewSettings(object sender, EventArgs e)
		{
			using var settings = new SettingsForm();
			settings.Show();
		}

		private void ChangeView(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			switch (e.Manage)
			{
				case SPPBC.M3Tools.Events.ManageType.Listeners:
					new ListenersManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Inventory:
					new InventoryManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Orders:
					new OrderManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Customers:
					new CustomerManagement().Show();
					break;
				default:
					return;
			}


			DisplayClosing(sender, new CancelEventArgs());
		}
	}
}
