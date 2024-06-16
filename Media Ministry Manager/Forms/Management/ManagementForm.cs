using System;
using System.ComponentModel;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
	// TODO: Figure out how to allow to be abstract and still have designer privleges
	/// <summary>
	/// 
	/// </summary>
	public partial class ManagementForm<T> where T : SPPBC.M3Tools.Types.IDbEntry
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public ManagementForm()
        {
            InitializeComponent();

			mms_Main.ExitApplication += new EventHandler(Exit);
			mms_Main.Logout += new EventHandler(LogOff);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.AddCustomer += new CustomerEventHandler(Add);
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);

			ts_Tools.AddEntry += new EventHandler(Add);
			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void DisplayClosing(object sender, FormClosingEventArgs e)
		{
			if (sender is SPPBC.M3Tools.MainMenuStrip)
			{
				return;
			}

			My.MyProject.Forms.MainForm.Show();
		}

		/// <summary>
		/// Reloads the display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Reload(object sender, EventArgs e) 
		{
		}

		/// <summary>
		/// Add a new entry to the database 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Add(object sender, EventArgs e) 
		{
		}
		
		/// <summary>
		/// Update an entry in the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		protected virtual void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<T> e)
		{
		}

		/// <summary>
		/// Remove an entry from the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		protected virtual void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<T> e)
		{
		}

		/// <summary>
		/// Called when the filter is changed in the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected virtual void FilterChanged(object sender, string filter)
		{
		}

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

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			switch (e.Manage)
			{
				case SPPBC.M3Tools.Events.ManageType.Listeners:
					My.MyProject.Forms.ListenersManagement.Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Inventory:
					My.MyProject.Forms.InventoryManagement.Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Orders:
					My.MyProject.Forms.OrderManagement.Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Customers:
					My.MyProject.Forms.CustomersManagement.Show();
					break;
				default:
					return;
			}

			((Control)sender).Invoke(Close);

			//OnFormClosing(new(CloseReason.None, false));
			//DisplayClosing(sender, new(CloseReason.None, false));
		}
	}
}
