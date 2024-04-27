using System;
using System.ComponentModel;
using System.Windows.Forms;
using M3App.Helpers;
using SPPBC.M3Tools.Events.Inventory;

namespace M3App
{
	// TODO: Mimic CustomerManagement
    public partial class InventoryManagement
    {
        private event InventoryEventHandler InventoryDBModified;
        private bool Tooled = false;

        public InventoryManagement()
        {
            InitializeComponent();
			mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.INVENTORY);
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
            var customers = new CustomerManagement();
            customers.Show();
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


		private void AddProduct(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			AddProduct(sender, e as InventoryEventArgs);
		}

		private void AddProduct(object sender, InventoryEventArgs e)
        {
            UseWaitCursor = true;
            dbInventory.AddProduct(e.Value);
            MessageBox.Show($"Successfully created product", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InventoryDBModified.Invoke(this, e);
        }

        private void RemoveProduct(object sender, InventoryEventArgs e)
        {
            UseWaitCursor = true;
            dbInventory.RemoveProduct(e.Value.Id);
            MessageBox.Show($"Successfully removed product", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InventoryDBModified.Invoke(this, e);
        }

        private void UpdateProduct(object sender, InventoryEventArgs e)
        {
            UseWaitCursor = true;
            dbInventory.UpdateProduct(e.Value);
            MessageBox.Show($"Successfully updated product", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InventoryDBModified.Invoke(this, e);
        }

		private void Reload(object sender, InventoryEventArgs e)
		{
			Reload(sender, EventArgs.Empty);
		}

        private void Reload(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            bsInventory.Clear();
            foreach (var product in dbInventory.GetProducts())
                bsInventory.Add(product);
            UseWaitCursor = false;
        }
    }
}
