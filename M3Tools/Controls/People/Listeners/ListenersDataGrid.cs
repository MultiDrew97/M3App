using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace SPPBC.M3Tools
{

    public partial class ListenersDataGrid
    {
        public event ListenerEventHandler EditListener;
        public event ListenerEventHandler RemoveListener;
        public event RefreshDisplayEventHandler RefreshDisplay;

        public delegate void RefreshDisplayEventHandler();

        public int SelectedRowsCount
        {
            get
            {
                return SelectedListeners.Count;
            }
        }

        public IList Listeners
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
                return (BindingSource)bsListeners.DataSource;
            }
            set
            {
                bsListeners.DataSource = value;
            }
        }

        public IList SelectedListeners
        {
            get
            {
                // TODO: Simplify this later
                if (!ListenersSelectable)
                {
                    return dgv_Listeners.SelectedRows;
                }

                if (chk_SelectAll.Checked)
                {
                    return dgv_Listeners.Rows;
                }

                // MyBase.clearselection()

                foreach (DataGridViewRow row in dgv_Listeners.Rows)
                    row.Selected = Conversions.ToBoolean(row.Cells[dgc_Selection.DisplayIndex].Value);

                return dgv_Listeners.SelectedRows;

            }
        }

        public string Filter
        {
            get
            {
                return DataSource.Filter;
            }
            set
            {
                Console.WriteLine(value);
                // TODO: Fix bug and flesh out
                if (value is not null && !string.IsNullOrEmpty(value) && !(value.Contains("[") || value.Contains("]")))
                {
                    DataSource.Filter = $"[Name] like '%{value}%' OR [Email] like '%{value}%'";
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
                return dgv_Listeners.AllowUserToAddRows;
            }
            set
            {
                dgv_Listeners.AllowUserToAddRows = value;
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
                return dgv_Listeners.AllowUserToOrderColumns;
            }
            set
            {
                dgv_Listeners.AllowUserToOrderColumns = value;
            }
        }

        [DefaultValue(true)]
        public bool ListenersSelectable
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

        public ListenersDataGrid()
        {
            InitializeComponent();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgc_Edit.Index && e.ColumnIndex != dgc_Remove.Index)
            {
                return;
            }

            var row = dgv_Listeners.Rows[e.RowIndex];
            Types.Listener listener = (Types.Listener)row.DataBoundItem;

            switch (e.ColumnIndex)
            {
                case var @case when @case == dgc_Edit.Index:
                    {
                        EditListener?.Invoke(this, new ListenerEventArgs(listener));
                        break;
                    }
                case var case1 when case1 == dgc_Remove.Index:
                    {
                        DeleteListener(this, new DataGridViewRowCancelEventArgs(row));
                        break;
                    }
            }
        }

        private void DeleteListener(object sender, DataGridViewRowCancelEventArgs e)
        {
            Types.Listener listener = (Types.Listener)e.Row.DataBoundItem;

            RemoveListener?.Invoke(this, new ListenerEventArgs(listener, EventType.Deleted));
            MessageBox.Show($"Successfully removed listener", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoveSelectedListeners()
        {
            if (SelectedRowsCount < 1)
            {
                return;
            }

            int failed = 0;
            int total = dgv_Listeners.SelectedRows.Count;

            foreach (DataGridViewRow row in dgv_Listeners.SelectedRows)
            {
                try
                {
                    DeleteListener(this, new DataGridViewRowCancelEventArgs(row));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    failed += 1;
                    return;
                }
            }

            if (failed > 0)
            {
                MessageBox.Show($"Failed to remove {failed} listener{(failed > 1 ? "s" : "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (total - failed > 0)
            {
                MessageBox.Show($"Successfully removed {total - failed} listener{(total - failed > 1 ? "s" : "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectAllListeners(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Listeners.Rows)
                row.Cells[dgc_Selection.DisplayIndex].Value = chk_SelectAll.Checked;

            dgv_Listeners.Invalidate();
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

            foreach (DataGridViewRow row in SelectedListeners)
                CellClicked(this, new DataGridViewCellEventArgs(dgc_Edit.Index, row.Index));
        }

        private void RefreshView()
        {
            RefreshDisplay?.Invoke();
        }
    }
}
