using System.Diagnostics;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomerManagement : ManagementForm<SPPBC.M3Tools.Types.Customer>
    {

        // Form overrides dispose to clean up the component list.
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cdg_Customers = new SPPBC.M3Tools.Data.CustomerDataGrid();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageButtonEditColumn2 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn2 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
            this.bsCustomers = new SPPBC.M3Tools.Data.CustomerBindingSource();
            this.dbCustomers = new SPPBC.M3Tools.Database.CustomerDatabase(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cdg_Customers);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(775, 345);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // cdg_Customers
            // 
            this.cdg_Customers.AllowUserToAddRows = false;
            this.cdg_Customers.AllowUserToOrderColumns = true;
            this.cdg_Customers.AutoGenerateColumns = false;
            this.cdg_Customers.CanReorder = true;
            this.cdg_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdg_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageButtonEditColumn2,
            this.dataGridViewImageButtonDeleteColumn2});
            this.cdg_Customers.DataSource = this.bsCustomers;
            this.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdg_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cdg_Customers.Location = new System.Drawing.Point(0, 0);
            this.cdg_Customers.Name = "cdg_Customers";
            this.cdg_Customers.ReadOnly = true;
            this.cdg_Customers.RowsCheckable = false;
            this.cdg_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cdg_Customers.Size = new System.Drawing.Size(775, 345);
            this.cdg_Customers.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn2.FalseValue = "False";
            this.dataGridViewCheckBoxColumn2.Frozen = true;
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "True";
            this.dataGridViewCheckBoxColumn2.Visible = false;
            this.dataGridViewCheckBoxColumn2.Width = 25;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.FillWeight = 25F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.FillWeight = 25F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Address";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn10.FillWeight = 25F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn11.FillWeight = 25F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Email";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Joined";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn12.HeaderText = "Joined";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 63;
            // 
            // dataGridViewImageButtonEditColumn2
            // 
            this.dataGridViewImageButtonEditColumn2.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn2.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn2.HeaderText = "";
            this.dataGridViewImageButtonEditColumn2.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn2.Name = "dataGridViewImageButtonEditColumn2";
            this.dataGridViewImageButtonEditColumn2.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn2.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn2.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn2
            // 
            this.dataGridViewImageButtonDeleteColumn2.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn2.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn2.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn2.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn2.Name = "dataGridViewImageButtonDeleteColumn2";
            this.dataGridViewImageButtonDeleteColumn2.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn2.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn2.Width = 25;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 25F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.FillWeight = 25F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.FillWeight = 25F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.FillWeight = 25F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Joined";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Joined";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageButtonEditColumn1
            // 
            this.dataGridViewImageButtonEditColumn1.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn1.HeaderText = "";
            this.dataGridViewImageButtonEditColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn1.Name = "dataGridViewImageButtonEditColumn1";
            this.dataGridViewImageButtonEditColumn1.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn1.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn1.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn1
            // 
            this.dataGridViewImageButtonDeleteColumn1.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn1.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn1.Name = "dataGridViewImageButtonDeleteColumn1";
            this.dataGridViewImageButtonDeleteColumn1.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn1.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn1.Width = 25;
            // 
            // dbCustomers
            // 
            this.dbCustomers.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbCustomers.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbCustomers.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Icon = global::M3App.Properties.Resources.App_Icon;
            this.Name = "CustomerManagement";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SPPBC.M3Tools.Data.CustomerDataGrid cdg_Customers;
		private SPPBC.M3Tools.Data.CustomerBindingSource bsCustomers;
		private SPPBC.M3Tools.Database.CustomerDatabase dbCustomers;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn2;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn2;
	}
}
