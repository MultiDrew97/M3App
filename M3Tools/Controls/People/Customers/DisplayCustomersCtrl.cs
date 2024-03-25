using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;

namespace SPPBC.M3Tools
{

    public partial class DisplayCustomersCtrl
    {
        public event CustomerEventHandler AddCustomer;
        public event CustomerEventHandler UpdateCustomer;
        public event CustomerEventHandler RemoveCustomer;
        public event RefreshDisplayEventHandler RefreshDisplay;

        public delegate void RefreshDisplayEventHandler();

        public DisplayCustomersCtrl()
        {
            InitializeComponent();
        }

        // <DefaultValue(GetType(Object))>
        // <Description("Data Source to use for data grid.")>
        // Public Property DataSource As BindingSource
        // Get
        // Return cdg_Customers.DataSource
        // End Get
        // Set(value As BindingSource)
        // cdg_Customers.DataSource = value
        // End Set
        // End Property

        // Public Sub Reload()
        // tsl_Count.Text = String.Format(CountTemplate, cdg_Customers.Customers.Count)
        // End Sub

        private void RefreshView()
        {
            RefreshDisplay?.Invoke();
        }

        private void NewCustomer(object sender, EventArgs e)
        {
            using (var @add = new Dialogs.AddCustomerDialog())
            {
                var res = @add.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                AddCustomer?.Invoke(this, new CustomerEventArgs(@add.Customer, M3Tools.Events.EventType.Added));
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            // cdg_Customers.Filter = txt_Filter.Text
        }

        private void RemoveRowByToolStrip(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes) || cdg_Customers.SelectedRows.Count < 1)
            {
                return;
            }

            cdg_Customers.RemoveSelectedRows();

            // TODO: Open a dialog for bulk deletion
            // Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
            // bulk.ShowDialog()
            // End Using
        }



        private void EditCustomer(object sender, CustomerEventArgs e)
        {
            using (var edit = new Dialogs.EditCustomerDialog() { Customer = e.Customer })
            {
                var res = edit.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                UpdateCustomer?.Invoke(this, new CustomerEventArgs(edit.NewInfo, M3Tools.Events.EventType.Updated));
            }
        }

        private void DeleteCustomer(object sender, CustomerEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to remove this Customer?", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            RemoveCustomer?.Invoke(this, e);
        }
    }
}