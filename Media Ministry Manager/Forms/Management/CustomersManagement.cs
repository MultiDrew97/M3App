using System;
using System.ComponentModel;
using System.Windows.Forms;
using MediaMinistry.Helpers;
using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Events.Customers;

namespace MediaMinistry
{

    // TODO: Figure out why it auto adds the other columns for some reason

    public partial class CustomersManagement
    {
        private event CustomerEventHandler CustomerDBModified;
        private event CustomerEventHandler CustomerAdd;
        private event CustomerEventHandler RemovoeCustomer;

        private bool Tooled = false;

        private CustomersBindingSource BindingSource
        {
            get
            {
                return bsCustomers;
            }
        }

        public CustomersManagement()
        {
            InitializeComponent();
        }

        private void Loading(object sender, EventArgs e)
        {
            mms_Main.ToggleViewItem("Customers");
        }

        private void DisplayClosing(object sender, CancelEventArgs e)
        {
            // TODO: Find easier way
            if (Tooled)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

        private void Logout()
        {
            Utils.LogOff();
            Tooled = true;
            Close();
        }

        private void ExitApplication()
        {
            Utils.CloseOpenForms();
        }

        private void ManageOrders(object sender, EventArgs e)
        {
            var orders = new OrderManagement();
            orders.Show();
            Tooled = true;
            Close();
        }

        private void ManageProducts(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            Tooled = true;
            Close();
        }

        private void ManageListeners(object sender, EventArgs e)
        {
            var listeners = new ListenersManagement();
            listeners.Show();
            Tooled = true;
            Close();
        }

        private void ViewSettings()
        {
			using var settings = new SettingsForm();
			settings.Show();
		}

        private void UpdateCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
            // dbCustomers.UpdateCustomer(e.Customer.Id, e.Customer.FirstName, e.Customer.LastName, e.Customer.Address, e.Customer.Email, e.Customer.Phone)
            MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, e);
        }

        private void AddCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
            dbCustomers.AddCustomer(e.Customer);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, e);
        }

        private void RemoveCustomer(object sender, CustomerEventArgs e)
        {
            UseWaitCursor = true;
            dbCustomers.RemoveCustomer(e.Customer.Id);
            MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CustomerDBModified.Invoke(this, e);
        }

        private void Reload(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            bsCustomers.Clear();
            foreach (var customer in dbCustomers.GetCustomers())
                bsCustomers.Add(customer);
            ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, cdg_Customers.Rows.Count);
            UseWaitCursor = false;
        }

        private void ToolsAddCustomer(object sender, EventArgs e)
        {
			using var @add = new AddCustomerDialog();

			if (!(@add.ShowDialog() == DialogResult.OK))
			{
				return;
			};

			CustomerAdd.Invoke(this, new CustomerEventArgs(add.Customer, SPPBC.M3Tools.Events.EventType.Added));
		}

        private void FilterChanged(object sender, string filter)
        {
            bsCustomers.Filter = filter;
        }
    }
}
