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
            this.dbCustomers = new SPPBC.M3Tools.Database.CustomerDatabase(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).BeginInit();
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
            this.cdg_Customers.CanReorder = true;
            this.cdg_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.Name = "CustomerManagement";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SPPBC.M3Tools.Data.CustomerDataGrid cdg_Customers;
		private SPPBC.M3Tools.Database.CustomerDatabase dbCustomers;
	}
}
