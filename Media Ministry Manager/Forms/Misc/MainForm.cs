using System;
using System.Drawing;
using System.Windows.Forms;
using MediaMinistry.Helpers;

namespace MediaMinistry
{

    public partial class MainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            tss_Feedback.Text = "What would you like to do?";
            tss_Feedback.ForeColor = SystemColors.WindowText;
            Focus();
        }

        private void MangeProducts(object sender, EventArgs e)
        {
            var products = new InventoryManagement();
            products.Show();
            Close();
        }

        private void ManageOrders(object sender, EventArgs e)
        {
            var orders = new OrderManagement();
            orders.Show();
            Close();
        }

        private void ManageCustomers(object sender, EventArgs e)
        {
            var customers = new CustomersManagement();
            customers.Show();
            Close();
        }

        private void ManageListeners(object sender, EventArgs e)
        {
            var listeners = new ListenersManagement();
            listeners.Show();
            Close();
        }

        private void Logout()
        {
            Utils.LogOff();
            Close();
        }

        private void ExitApp()
        {
            Utils.CloseOpenForms();
        }

        private void AddCustomer(object sender, SPPBC.M3Tools.Events.Customers.CustomerEventArgs e)
        {
            dbCustomer.AddCustomer(e.Customer);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddListener(object sender, SPPBC.M3Tools.Events.Listeners.ListenerEventArgs e)
        {
            dbListener.AddListener(e.Listener);
            MessageBox.Show($"Successfully created listener", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddCustomer(object sender, SPPBC.M3Tools.Events.Inventory.InventoryEventArgs e)
        {
            dbInventory.AddProduct(e.Product);
            MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		// Private Sub AddOrder(sender As Object, e As SPPBC.M3Tools.Events.Orders.OrderEventArgs) Handles mms_Main.AddOrder
		// dbOrder.AddOrder(e.Order)
		// MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
		// End Sub

		private void ViewSettings()
        {
            var settings = new SettingsForm();
            settings.Show();
        }

        private void Reload(object sender, EventArgs e) => Reload();
    }
}
