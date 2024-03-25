using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Inventory;

namespace SPPBC.M3Tools
{

    public partial class DisplayInventoryCtrl
    {
        public event InventoryEventHandler AddProduct;
        public event InventoryEventHandler UpdateProduct;
        public event InventoryEventHandler RemoveProduct;
        //public event RefreshDisplayEventHandler RefreshDisplay;

        // public delegate void RefreshDisplayEventHandler(object sender);

        public string CountTemplate { get; set; }

        public BindingSource DataSource
        {
            get
            {
                return idg_Inventory.DataSource;
            }
            set
            {
                idg_Inventory.DataSource = value;
            }
        }

        public DisplayInventoryCtrl()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            tsl_Count.Text = string.Format(CountTemplate, idg_Inventory.Products.Count);
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            idg_Inventory.Filter = txt_Filter.Text;
        }

        private void RemoveRowByToolStrip(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (idg_Inventory.SelectedProducts.Count < 1 || !(res == DialogResult.Yes))
            {
                return;
            }

            idg_Inventory.RemoveSelectedRows();

            // TODO: Open a dialog for bulk deletion
            // Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
            // bulk.ShowDialog()
            // End Using
        }

        private void EditProduct(object sender, InventoryEventArgs e)
        {
            using (var edit = new Dialogs.EditProductDialog() { Product = e.Product })
            {
                var res = edit.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                UpdateProduct?.Invoke(this, new InventoryEventArgs(edit.NewInfo));
            }
        }

        private void DeleteProduct(object sender, InventoryEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to remove this product?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            RemoveProduct?.Invoke(this, e);
        }
        private void NewItem(object sender, EventArgs e)
        {
            using (var @add = new Dialogs.AddProductDialog())
            {
                var res = @add.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                AddProduct?.Invoke(this, new InventoryEventArgs(@add.Product));
            }
        }

        private void ImportItem(object sender, EventArgs e)
        {
            throw new NotImplementedException("ImportItem");
        }
    }
}
