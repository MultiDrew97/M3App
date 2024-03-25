using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events.Inventory;

namespace SPPBC.M3Tools
{

    public partial class InventoryDataGrid
    {
        public event InventoryEventHandler EditProduct;
        public event InventoryEventHandler RemoveProduct;
        public event RefreshDisplayEventHandler RefreshDisplay;

        public delegate void RefreshDisplayEventHandler();

        public int SelectedRowsCount
        {
            get
            {
                return SelectedProducts.Count;
            }
        }

        public IList Products
        {
            get
            {
                return DataSource.List;
            }
        }

        [Description("Data Source to use for data grid.")]
        public BindingSource DataSource
        {
            get
            {
                return (BindingSource)bsInventory.DataSource;
            }
            set
            {
                bsInventory.DataSource = value;
            }
        }

        public IList SelectedProducts
        {
            get
            {
                if (InventorySelectable)
                {
                    if (chk_SelectAll.Checked)
                    {
                        return dgv_Inventory.Rows;
                    }

                    foreach (DataGridViewRow row in dgv_Inventory.Rows)
                        row.Selected = Conversions.ToBoolean(row.Cells[dgc_Selection.DisplayIndex].Value);
                }

                return dgv_Inventory.SelectedRows;
            }
        }

        [DefaultValue("")]
        public string Filter
        {
            get
            {
                return DataSource.Filter;
            }
            set
            {
                // TODO: Fix bug and flesh out
                if (!string.IsNullOrEmpty(value))
                {
                    DataSource.Filter = $"([FirstName] like '%{value}%') OR ([LastName] like '%${value}%') OR ([Email] like '%{value}%')";
                    return;
                }

                DataSource.Filter = value;
            }
        }

        [DefaultValue(true)]
        public bool AllowEditting
        {
            get
            {
                return dgc_Edit.Visible;
            }
            set
            {
                dgc_Edit.Visible = value;
            }
        }

        [DefaultValue(false)]
        public bool AllowAdding
        {
            get
            {
                return dgv_Inventory.AllowUserToAddRows;
            }
            set
            {
                dgv_Inventory.AllowUserToAddRows = value;
            }
        }

        [DefaultValue(true)]
        public bool AllowDeleting
        {
            get
            {
                return dgc_Remove.Visible;
            }
            set
            {
                dgc_Remove.Visible = value;
            }
        }

        [DefaultValue(false)]
        public bool AllowColumnReordering
        {
            get
            {
                return dgv_Inventory.AllowUserToOrderColumns;
            }
            set
            {
                dgv_Inventory.AllowUserToOrderColumns = value;
            }
        }

        [DefaultValue(true)]
        public bool InventorySelectable
        {
            get
            {
                return dgc_Selection.Visible;
            }
            set
            {
                dgc_Selection.Visible = value;
                chk_SelectAll.Visible = value;
            }
        }

        public InventoryDataGrid()
        {
            InitializeComponent();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgc_Edit.Index && e.ColumnIndex != dgc_Remove.Index)
            {
                return;
            }

            var row = dgv_Inventory.Rows[e.RowIndex];
            Types.Product product = (Types.Product)row.DataBoundItem;

            switch (e.ColumnIndex)
            {
                case var @case when @case == dgc_Edit.Index:
                    {
                        EditProduct?.Invoke(this, new InventoryEventArgs(product));
                        break;
                    }
                case var case1 when case1 == dgc_Remove.Index:
                    {
                        DeleteProduct(this, new DataGridViewRowCancelEventArgs(row));
                        break;
                    }
            }
        }

        private void DeleteProduct(object sender, DataGridViewRowCancelEventArgs e)
        {
            Types.Product product = (Types.Product)e.Row.DataBoundItem;

            RemoveProduct?.Invoke(this, new InventoryEventArgs(product));
        }

        public void RemoveSelectedRows()
        {
            if (SelectedRowsCount < 1)
            {
                return;
            }

            int failed = 0;
            int total = dgv_Inventory.SelectedRows.Count;

            foreach (DataGridViewRow row in dgv_Inventory.SelectedRows)
            {
                try
                {
                    DeleteProduct(this, new DataGridViewRowCancelEventArgs(row));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    failed += 1;
                    continue;
                }
            }

            if (failed > 0)
            {
                MessageBox.Show($"Failed to remove {failed} product{(failed > 1 ? "s" : "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (total - failed > 0)
            {
                MessageBox.Show($"Successfully removed {total - failed} product{(total - failed > 1 ? "s" : "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectAllProducts(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Inventory.Rows)
                row.Cells[dgc_Selection.DisplayIndex].Value = chk_SelectAll.Checked;

            dgv_Inventory.Invalidate();
        }

        private void ToolsOpened(object sender, EventArgs e)
        {
            cms_Tools.ToggleRemove(SelectedRowsCount > 0);
            cms_Tools.ToggleEdit(SelectedRowsCount > 0);
        }

        private void EditPerson()
        {
            if (SelectedRowsCount < 1)
            {
                return;
            }

            foreach (DataGridViewRow row in SelectedProducts)
                CellClicked(this, new DataGridViewCellEventArgs(dgc_Edit.Index, row.Index));
        }

        private void RefreshView()
        {
            RefreshDisplay?.Invoke();
        }
    }
}
