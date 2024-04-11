using System;
using System.ComponentModel;
using System.Windows.Forms;
using M3App.Helpers;
using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{

    // TODO: Figure out why it auto adds the other columns for some reason
	// MAYBE: Create a base management class that contains all basic functions for a management form (i.e DataEventHandler<T> Reload)

    public partial class CustomerManagement
    {
        private event CustomerEventHandler CustomerDBModified;

		// private SPPBC.M3Tools.Data.CustomerBindingSource DataSource => (SPPBC.M3Tools.Data.CustomerBindingSource)cdg_Customers.DataSource; 

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public CustomerManagement()
        {
            InitializeComponent();

			CustomerDBModified += new CustomerEventHandler(Reload);
			cdg_Customers.Reload += new SPPBC.M3Tools.Events.RefreshViewEventHandler(Reload);
			cdg_Customers.AddCustomer += new CustomerEventHandler(AddCustomer);
			cdg_Customers.UpdateCustomer += new CustomerEventHandler(UpdateCustomer);
			cdg_Customers.RemoveCustomer += new CustomerEventHandler(RemoveCustomer);
			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
			mms_Main.ExitApplication += new SPPBC.M3Tools.MainMenuStrip.ExitApplicationEventHandler(ExitApplication);
			mms_Main.Logout += new SPPBC.M3Tools.MainMenuStrip.LogoutEventHandler(Logout);
			mms_Main.ViewSettings += new SPPBC.M3Tools.MainMenuStrip.ViewSettingsEventHandler(ViewSettings);
        }

        private void Loading(object sender, EventArgs e)
        {
            mms_Main.ToggleViewItem("Customers");

			Reload(sender, e);
        }

        private void DisplayClosing(object sender, CancelEventArgs e)
        {
            // TODO: Find easier way
			Console.WriteLine(sender);
            if (sender is null)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

        private void Logout()
        {
            Utils.LogOff();
            DisplayClosing(null, null);
        }

        private void ExitApplication()
        {
            Utils.CloseOpenForms();
        }

        private void ManageOrders(object sender, EventArgs e)
        {
            var orders = new OrderManagement();
            orders.Show();
			DisplayClosing(null, null);
        }

        private void ManageProducts(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            DisplayClosing(null, null);
        }

        private void ManageListeners(object sender, EventArgs e)
        {
            var listeners = new ListenersManagement();
            listeners.Show();
            DisplayClosing(null, null);
        }

        private void ViewSettings()
        {
			using var settings = new SettingsForm();
			settings.Show();
		}

        private void UpdateCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
			dbCustomers.UpdateCustomer(e.Value.Id, e.Value.FirstName, e.Value.LastName, e.Value.Address, e.Value.Email, e.Value.Phone);
            MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, new CustomerEventArgs(e.Value, SPPBC.M3Tools.Events.EventType.Updated));
        }

        private void AddCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
            dbCustomers.AddCustomer(e.Value);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, new CustomerEventArgs(e.Value, SPPBC.M3Tools.Events.EventType.Added));
        }

        private void RemoveCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
            dbCustomers.RemoveCustomer(e.Value.Id);
            MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, new CustomerEventArgs(e.Value, SPPBC.M3Tools.Events.EventType.Removed));
        }

        private void Reload(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            bsCustomers.Clear();
            foreach (var customer in dbCustomers.GetCustomers())
				bsCustomers.Add(customer);
            ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, cdg_Customers.Customers.Count);
			bsCustomers.ResetBindings(false);
            UseWaitCursor = false;
        }

        private void ToolsAddCustomer(object sender, EventArgs e)
        {
			using var @add = new AddCustomerDialog();

			if (!(@add.ShowDialog() == DialogResult.OK))
			{
				return;
			};

			AddCustomer(this, new CustomerEventArgs(add.Customer, SPPBC.M3Tools.Events.EventType.Added));
		}

        private void FilterChanged(object sender, string filter)
        {
			bsCustomers.Filter = filter;
        }
    }
}
