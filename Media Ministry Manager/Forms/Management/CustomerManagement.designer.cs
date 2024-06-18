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
            this.cdg_Customers = new SPPBC.M3Tools.Data.CustomerDataGrid();
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
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // cdg_Customers
            // 
            this.cdg_Customers.AllowUserToAddRows = false;
            this.cdg_Customers.AllowUserToOrderColumns = true;
            this.cdg_Customers.AutoGenerateColumns = false;
            this.cdg_Customers.CanReorder = true;
            this.cdg_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdg_Customers.DataSource = this.bsCustomers;
            this.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdg_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cdg_Customers.Location = new System.Drawing.Point(0, 0);
            this.cdg_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdg_Customers.Name = "cdg_Customers";
            this.cdg_Customers.ReadOnly = true;
            this.cdg_Customers.RowHeadersWidth = 82;
            this.cdg_Customers.RowsCheckable = false;
            this.cdg_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cdg_Customers.Size = new System.Drawing.Size(775, 345);
            this.cdg_Customers.TabIndex = 1;
            // 
            // bsCustomers
            // 
            this.bsCustomers.Filter = "";
            // 
            // dbCustomers
            // 
            this.dbCustomers.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            this.dbCustomers.Password = global::M3App.My.Settings.Default.ApiPassword;
            this.dbCustomers.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Icon = global::M3App.My.Resources.Resources.App_Icon;
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
	}
}
