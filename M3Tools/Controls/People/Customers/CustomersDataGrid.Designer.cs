using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomersDataGrid : System.Windows.Forms.DataGridView
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            chk_SelectAll = new System.Windows.Forms.CheckBox();
            chk_SelectAll.CheckedChanged += new EventHandler(SelectAllCustomers);
            cms_Tools = new ToolsContextMenu();
            cms_Tools.RemoveRows += new ToolsContextMenu.RemoveRowsEventHandler(RemoveSelectedRows);
            cms_Tools.Opened += new EventHandler(ToolsOpened);
            cms_Tools.EditSelected += new ToolsContextMenu.EditSelectedEventHandler(EditPerson);
            cms_Tools.RefreshView += new ToolsContextMenu.RefreshViewEventHandler(RefreshView);
            bsCustomers = new Types.CustomersBindingSource();
            dgc_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Edit = new DataGridViewImageButtonEditColumn();
            dgc_Remove = new DataGridViewImageButtonDeleteColumn();
            ((System.ComponentModel.ISupportInitialize)bsCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // chk_SelectAll
            // 
            chk_SelectAll.AutoSize = true;
            chk_SelectAll.Location = new System.Drawing.Point(46, 3);
            chk_SelectAll.Name = "chk_SelectAll";
            chk_SelectAll.Size = new System.Drawing.Size(15, 14);
            chk_SelectAll.TabIndex = 3;
            chk_SelectAll.TabStop = false;
            chk_SelectAll.UseVisualStyleBackColor = true;
            // 
            // cms_Tools
            // 
            cms_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            cms_Tools.Name = "cms_Tools";
            cms_Tools.Size = new System.Drawing.Size(133, 70);
            // 
            // dgc_CustomerID
            // 
            dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgc_CustomerID.DataPropertyName = "CustomerID";
            dgc_CustomerID.FillWeight = 5.0f;
            dgc_CustomerID.Frozen = true;
            dgc_CustomerID.HeaderText = "CustomerID";
            dgc_CustomerID.MinimumWidth = 10;
            dgc_CustomerID.Name = "dgc_CustomerID";
            dgc_CustomerID.ReadOnly = true;
            dgc_CustomerID.Visible = false;
            // 
            // dgc_Selection
            // 
            dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Selection.Frozen = true;
            dgc_Selection.HeaderText = "";
            dgc_Selection.MinimumWidth = 25;
            dgc_Selection.Name = "dgc_Selection";
            dgc_Selection.ReadOnly = true;
            dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgc_Selection.Width = 25;
            // 
            // dgc_Name
            // 
            dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Name.DataPropertyName = "Name";
            dgc_Name.FillWeight = 25.0f;
            dgc_Name.Frozen = true;
            dgc_Name.HeaderText = "Name";
            dgc_Name.MinimumWidth = 10;
            dgc_Name.Name = "dgc_Name";
            dgc_Name.ReadOnly = true;
            dgc_Name.Width = 123;
            // 
            // dgc_Address
            // 
            dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Address.DataPropertyName = "Address";
            dgc_Address.FillWeight = 25.0f;
            dgc_Address.Frozen = true;
            dgc_Address.HeaderText = "Address";
            dgc_Address.MinimumWidth = 10;
            dgc_Address.Name = "dgc_Address";
            dgc_Address.ReadOnly = true;
            dgc_Address.Width = 123;
            // 
            // dgc_Phone
            // 
            dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Phone.DataPropertyName = "Phone";
            dgc_Phone.FillWeight = 25.0f;
            dgc_Phone.Frozen = true;
            dgc_Phone.HeaderText = "Phone";
            dgc_Phone.MinimumWidth = 10;
            dgc_Phone.Name = "dgc_Phone";
            dgc_Phone.ReadOnly = true;
            dgc_Phone.Width = 123;
            // 
            // dgc_Email
            // 
            dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Email.DataPropertyName = "Email";
            dgc_Email.FillWeight = 25.0f;
            dgc_Email.Frozen = true;
            dgc_Email.HeaderText = "Email";
            dgc_Email.MinimumWidth = 10;
            dgc_Email.Name = "dgc_Email";
            dgc_Email.ReadOnly = true;
            dgc_Email.Width = 123;
            // 
            // dgc_Edit
            // 
            dgc_Edit.ButtonImage = null;
            dgc_Edit.FillWeight = 5.0f;
            dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgc_Edit.Frozen = true;
            dgc_Edit.HeaderText = "";
            dgc_Edit.MinimumWidth = 25;
            dgc_Edit.Name = "dgc_Edit";
            dgc_Edit.ReadOnly = true;
            dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Edit.ToolTipText = "Edit";
            dgc_Edit.Width = 25;
            // 
            // dgc_Remove
            // 
            dgc_Remove.ButtonImage = null;
            dgc_Remove.FillWeight = 5.0f;
            dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgc_Remove.Frozen = true;
            dgc_Remove.HeaderText = "";
            dgc_Remove.MinimumWidth = 25;
            dgc_Remove.Name = "dgc_Remove";
            dgc_Remove.ReadOnly = true;
            dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Remove.ToolTipText = "Remove";
            dgc_Remove.Width = 25;
            // 
            // CustomersDataGrid
            // 
            AllowUserToAddRows = false;
            AllowUserToOrderColumns = true;
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_CustomerID, dgc_Selection, dgc_Name, dgc_Address, dgc_Phone, dgc_Email, dgc_Edit, dgc_Remove });
            ContextMenuStrip = cms_Tools;
            Controls.Add(chk_SelectAll);
            DataSource = bsCustomers;
            Dock = System.Windows.Forms.DockStyle.Fill;
            EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            ReadOnly = true;
            SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            Size = new System.Drawing.Size(610, 500);
            TabIndex = 2;
            ((System.ComponentModel.ISupportInitialize)bsCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(CellClicked);
            UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(DeleteCustomer);
            ResumeLayout(false);
            PerformLayout();

        }

        internal System.Windows.Forms.CheckBox chk_SelectAll;
        internal ToolsContextMenu cms_Tools;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Join;
        internal Types.CustomersBindingSource bsCustomers;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerID;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Selection;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Address;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Phone;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
        internal DataGridViewImageButtonEditColumn dgc_Edit;
        internal DataGridViewImageButtonDeleteColumn dgc_Remove;
    }
}