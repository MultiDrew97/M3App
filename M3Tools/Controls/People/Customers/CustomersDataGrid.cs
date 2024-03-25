using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Customers;

namespace SPPBC.M3Tools
{

    // TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
    public partial class CustomersDataGrid : DataGridView
    {
        public event CustomerEventHandler EditCustomer;
        public event CustomerEventHandler RemoveCustomer;
        public event RefreshDisplayEventHandler RefreshDisplay;

        public delegate void RefreshDisplayEventHandler();

        // <Browsable(False)>
        // Public ReadOnly Property SelectedRowsCount As Integer
        // Get
        // Return SelectedRows.Count
        // End Get
        // End Property

        [Browsable(false)]
        public IList Customers
        {
            get
            {
                return Rows;
            }
        }

        // '<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        // '<DefaultValue(GetType(BindingSource))>
        // <RefreshProperties(RefreshProperties.Repaint)>
        // <AttributeProvider(GetType(IListSource))>
        // <Description("Data Source to use for data grid.")>
        // Public Overloads Property DataSource As Types.CustomersCollection
        // Get
        // Return bsCustomers.DataSource
        // End Get
        // Set(value As Types.CustomersCollection)
        // AutoGenerateColumns = False
        // bsCustomers.DataSource = value
        // End Set
        // End Property

        // <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        // <DefaultValue(GetType(BindingSource))>
        // <AttributeProvider(GetType(IListSource))>
        [RefreshProperties(RefreshProperties.Repaint)]
        [Description("Data Source to use for data grid.")]
        public new object DataSource
        {
            get
            {
                return base.DataSource ?? (Types.CustomersBindingSource)base.DataSource;
            }
            set
            {
                AutoGenerateColumns = false;
                switch (true)
                {
                    case object _ when value is Types.CustomersBindingSource:
                        {
                            base.DataSource = value;
                            break;
                        }
                    case object _ when value is Types.Customer:
                        {
                            base.DataSource = new Types.CustomersCollection();
                            break;
                        }

                    default:
                        {
                            throw new Exception("CustomerDataGrid - Unknown DataSource Type");
                        }
                }
            }
        }

        [Browsable(false)]
        public new IList SelectedRows
        {
            get
            {
                if (!CustomersSelectable)
                {
                    return base.SelectedRows;
                }

                if (chk_SelectAll.Checked)
                {
                    return Rows;
                }

                ClearSelection();

                foreach (DataGridViewRow row in Rows)
                    row.Selected = Conversions.ToBoolean(row.Cells[dgc_Selection.DisplayIndex].Value);

                return base.SelectedRows;
            }
        }

        // <DefaultValue("")>
        // Property Filter As String
        // Get
        // Return DataSource?.Filter
        // End Get
        // Set(value As String)
        // DataSource.Filter = value
        // End Set
        // End Property

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
                return AllowUserToAddRows;
            }
            set
            {
                AllowUserToAddRows = value;
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
                return AllowUserToOrderColumns;
            }
            set
            {
                AllowUserToOrderColumns = value;
            }
        }

        [DefaultValue(true)]
        public bool CustomersSelectable
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

        public CustomersDataGrid()
        {
            InitializeComponent();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgc_Edit.Index && e.ColumnIndex != dgc_Remove.Index)
            {
                return;
            }

            var row = Rows[e.RowIndex];
            Types.Customer customer = (Types.Customer)row.DataBoundItem;

            switch (e.ColumnIndex)
            {
                case var @case when @case == dgc_Edit.Index:
                    {
                        EditCustomer?.Invoke(this, new CustomerEventArgs(customer, EventType.Updated));
                        break;
                    }
                case var case1 when case1 == dgc_Remove.DisplayIndex:
                    {
                        DeleteCustomer(this, new DataGridViewRowCancelEventArgs(row));
                        break;
                    }
            }
        }

        private void DeleteCustomer(object sender, DataGridViewRowCancelEventArgs e)
        {
            Types.Customer customer = (Types.Customer)e.Row.DataBoundItem;

            RemoveCustomer?.Invoke(this, new CustomerEventArgs(customer, EventType.Deleted));
        }

        public void RemoveSelectedRows()
        {
            if (SelectedRows.Count < 1)
            {
                return;
            }

            int failed = 0;
            int total = SelectedRows.Count;

            foreach (DataGridViewRow row in SelectedRows)
            {
                try
                {
                    DeleteCustomer(this, new DataGridViewRowCancelEventArgs(row));
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
                MessageBox.Show($"Failed to remove {failed} customer{(failed > 1 ? "s" : "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (total - failed > 0)
            {
                MessageBox.Show($"Successfully removed {total - failed} customer{(total - failed > 1 ? "s" : "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectAllCustomers(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Rows)
                row.Cells[dgc_Selection.DisplayIndex].Value = chk_SelectAll.Checked;
            Invalidate();
        }

        private void ToolsOpened(object sender, EventArgs e)
        {
            cms_Tools.ToggleRemove(SelectedRows.Count > 0);
            cms_Tools.ToggleEdit(SelectedRows.Count > 0);
        }

        private void EditPerson()
        {
            if (SelectedRows.Count < 1)
            {
                return;
            }

            foreach (DataGridViewRow row in SelectedRows)
                CellClicked(this, new DataGridViewCellEventArgs(dgc_Edit.Index, row.Index));
        }

        private void RefreshView()
        {
            Refresh();
        }
    }
}
// Public Class CustomersDataGrid
// Inherits DataGridView
// Public Event EditCustomer As CustomerEventHandler
// Public Event RemoveCustomer As CustomerEventHandler
// Public Event RefreshDisplay()

// <Browsable(False)>
// Public ReadOnly Property SelectedRowsCount As Integer
// Get
// Return SelectedCustomers.Count
// End Get
// End Property

// <Browsable(False)>
// Public ReadOnly Property Customers As IList
// Get
// Return Rows
// End Get
// End Property

// '<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
// '<DefaultValue(GetType(BindingSource))>
// <RefreshProperties(RefreshProperties.Repaint)>
// <AttributeProvider(GetType(IListSource))>
// <Description("Data Source to use for data grid.")>
// Public Shadows Property DataSource As BindingSource
// Get
// Return CType(dgv_Customers.DataSource, BindingSource)
// End Get
// Set(value As BindingSource)
// Me.AutoGenerateColumns = False
// MyBase.DataSource = value
// 'dgv_Customers.Refresh()
// End Set
// End Property

// <Browsable(False)>
// Public ReadOnly Property SelectedCustomers As IList
// Get
// If CustomersSelectable Then
// If chk_SelectAll.Checked Then
// Return dgv_Customers.Rows
// End If

// For Each row As DataGridViewRow In dgv_Customers.Rows
// row.Selected = CBool(row.Cells(dgc_Selection.DisplayIndex).Value)
// Next
// End If

// Return dgv_Customers.SelectedRows
// End Get
// End Property

// '<DefaultValue("")>
// 'Property Filter As String
// '	Get
// '		Return DataSource?.Filter
// '	End Get
// '	Set(value As String)
// '		DataSource.Filter = value
// '	End Set
// 'End Property

// <DefaultValue(True)>
// Property AllowEditting As Boolean
// Get
// Return dgc_Edit.Visible
// End Get
// Set(value As Boolean)
// dgc_Edit.Visible = value
// End Set
// End Property

// <DefaultValue(False)>
// Property AllowAdding As Boolean
// Get
// Return dgv_Customers.AllowUserToAddRows
// End Get
// Set(value As Boolean)
// dgv_Customers.AllowUserToAddRows = value
// End Set
// End Property

// <DefaultValue(True)>
// Property AllowDeleting As Boolean
// Get
// Return dgc_Remove.Visible
// End Get
// Set(value As Boolean)
// dgc_Remove.Visible = value
// End Set
// End Property

// <DefaultValue(False)>
// Property AllowColumnReordering As Boolean
// Get
// Return dgv_Customers.AllowUserToOrderColumns
// End Get
// Set(value As Boolean)
// dgv_Customers.AllowUserToOrderColumns = value
// End Set
// End Property

// <DefaultValue(True)>
// Property CustomersSelectable As Boolean
// Get
// Return dgc_Selection.Visible
// End Get
// Set(value As Boolean)
// dgc_Selection.Visible = value
// chk_SelectAll.Visible = value
// End Set
// End Property

// Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellContentClick
// If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
// Return
// End If

// Dim row = dgv_Customers.Rows(e.RowIndex)
// Dim customer = CType(row.DataBoundItem, Types.Customer)

// Select Case e.ColumnIndex
// Case dgc_Edit.Index
// RaiseEvent EditCustomer(Me, New CustomerEventArgs(customer, EventType.Updated))
// Case dgc_Remove.DisplayIndex
// DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
// End Select
// End Sub

// Private Sub DeleteCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
// Dim customer = CType(e.Row.DataBoundItem, Types.Customer)

// RaiseEvent RemoveCustomer(Me, New CustomerEventArgs(customer, EventType.Deleted))
// End Sub

// Public Sub RemoveSelectedRows() Handles cms_Tools.RemoveRows
// If SelectedRowsCount < 1 Then
// Return
// End If

// Dim failed As Integer = 0
// Dim total As Integer = dgv_Customers.SelectedRows.Count

// For Each row As DataGridViewRow In dgv_Customers.SelectedRows
// Try
// DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
// Catch ex As Exception
// Console.WriteLine(ex.Message)
// failed += 1
// Continue For
// End Try
// Next

// If failed > 0 Then
// MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
// End If

// If total - failed > 0 Then
// MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
// End If
// End Sub

// Private Sub SelectAllCustomers(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
// For Each row As DataGridViewRow In dgv_Customers.Rows
// row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
// Next
// dgv_Customers.Invalidate()
// End Sub

// Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
// cms_Tools.ToggleRemove(SelectedRowsCount > 0)
// cms_Tools.ToggleEdit(SelectedRowsCount > 0)
// End Sub

// Private Sub EditPerson() Handles cms_Tools.EditSelected
// If SelectedRowsCount < 1 Then
// Return
// End If

// For Each row As DataGridViewRow In SelectedCustomers
// CellClicked(Me, New DataGridViewCellEventArgs(dgc_Edit.Index, row.Index))
// Next
// End Sub

// Private Sub RefreshView() Handles cms_Tools.RefreshView
// RaiseEvent RefreshDisplay()
// End Sub
// End Class
