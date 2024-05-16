using System;
using System.ComponentModel;
using System.Windows.Forms;
using M3App.Helpers;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
    public partial class CustomerManagement
    {
		// private SPPBC.M3Tools.Data.CustomerBindingSource DataSource => (SPPBC.M3Tools.Data.CustomerBindingSource)cdg_Customers.DataSource; 

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public CustomerManagement() : base()
        {
            InitializeComponent();

			ts_Tools.ToggleButton(SPPBC.M3Tools.ToolButtons.EMAIL);
			mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.CUSTOMERS);
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(ChangeView);

			mms_Main.AddCustomer += new CustomerEventHandler(AddCustomer);
			mms_Main.ExitApplication += new EventHandler(Exit);
			mms_Main.Logout += new EventHandler(LogOff);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);

			cdg_Customers.Reload += new EventHandler(Reload);
			cdg_Customers.AddCustomer += new CustomerEventHandler(AddCustomer);
			cdg_Customers.UpdateCustomer += new CustomerEventHandler(UpdateCustomer);
			cdg_Customers.RemoveCustomer += new CustomerEventHandler(RemoveCustomer);

			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
        }

        private new void DisplayClosing(object sender, CancelEventArgs e)
        {
            // TODO: Find easier way
			Console.WriteLine(sender);
            if (sender is SPPBC.M3Tools.MainMenuStrip)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

        private void LogOff(object sender, EventArgs e)
        {
			Close();
            Utils.LogOff();
        }

        private void Exit(object sender, EventArgs e)
        {
            Utils.CloseOpenForms();
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
				default:
					return;
			}

			DisplayClosing(sender, new CancelEventArgs());
		}

        private void ViewSettings(object sender, EventArgs e)
        {
			using var settings = new SettingsForm();
			settings.Show();
		}

		private void UpdateCustomer(object sender, CustomerEventArgs e)
        {
			BeginWait();

			using var @edit = new SPPBC.M3Tools.Dialogs.EditCustomerDialog(e.Value);
			
			if (edit.ShowDialog() != DialogResult.OK)
			{
				EndWait();
				return;
			}
			

			dbCustomers.UpdateCustomer(edit.Customer);
            MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
        }

		private void AddCustomer(object sender, EventArgs e)
        {
			BeginWait();
			using var @add = new SPPBC.M3Tools.Dialogs.AddCustomerDialog();

			if (add.ShowDialog() != DialogResult.OK)
			{
				EndWait();
				return;
			}

			/*dbCustomers.AddCustomer(add.Customer);*/
			MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
        }

		private void RemoveCustomer(object sender, CustomerEventArgs e)
        {
			BeginWait();
            dbCustomers.RemoveCustomer(e.Value.Id);
            MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        protected override void Reload(object sender, EventArgs e)
        {
            BeginWait();
            bsCustomers.Clear();
            foreach (var customer in dbCustomers.GetCustomers())
				bsCustomers.Add(customer);
            ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, cdg_Customers.Customers.Count);
			// FIXME: Determine how to no longer need this like before to have the DataGridView actually show the new data
			bsCustomers.ResetBindings(false);
			EndWait();
        }

        private void FilterChanged(object sender, string filter)
        {
			bsCustomers.Filter = filter;
        }

		private void BeginWait()
		{
			UseWaitCursor = true;
		}

		private void EndWait()
		{
			UseWaitCursor = false;
		}
    }
}
