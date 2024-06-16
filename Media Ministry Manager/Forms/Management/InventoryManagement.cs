using System;
using System.ComponentModel;
using System.Windows.Forms;
using M3App.Helpers;
using SPPBC.M3Tools.Events.Customers;
using SPPBC.M3Tools.Events.Inventory;

namespace M3App
{
	// TODO: Mimic CustomerManagement
	// TODO: Place this in Filter for binding source: $"([FirstName] like '%{value}%') OR ([LastName] like '%${value}%') OR ([Email] like '%{value}%')";
	/// <summary>
	/// 
	/// </summary>
	public partial class InventoryManagement
    {
        public InventoryManagement() : base()
        {
            InitializeComponent();

			// TODO: Figure out if I can place button toggles in the base class and automate the hiding
			ts_Tools.ToggleButton(new[] { SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT });
			mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.CUSTOMERS);

			idg_Inventory.Reload += new EventHandler(Reload);
			idg_Inventory.AddProduct += new InventoryEventHandler(Add);
			idg_Inventory.UpdateProduct += new InventoryEventHandler(Update);
			idg_Inventory.RemoveProduct += new InventoryEventHandler(Remove);
		}

        private void DisplayClosing(object sender, CancelEventArgs e)
        {
            if (sender is SPPBC.M3Tools.MainMenuStrip)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

		protected override void Add(object sender, EventArgs e)
        {
            UseWaitCursor = true;

			using var @add = new AddProductDialog();

			if (add.ShowDialog() != DialogResult.OK)
				return;

            dbInventory.AddProduct(add.Product);
            MessageBox.Show($"Successfully created product", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
        }

        private void RemoveProduct(object sender, InventoryEventArgs e)
        {
            UseWaitCursor = true;
            dbInventory.RemoveProduct(e.Value.Id);
            MessageBox.Show($"Successfully removed product", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

        private void UpdateProduct(object sender, InventoryEventArgs e)
        {
            UseWaitCursor = true;
            dbInventory.UpdateProduct(e.Value);
            MessageBox.Show($"Successfully updated product", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reload(sender, e);
        }

		/*private void Reload(object sender, InventoryEventArgs e)
		{
			Reload(sender, EventArgs.Empty);
		}*/

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
