using System.Diagnostics;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InventoryManagement : ManagementForm<SPPBC.M3Tools.Types.Product>
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
            this.dbInventory = new SPPBC.M3Tools.Database.InventoryDatabase(this.components);
            this.idg_Inventory = new SPPBC.M3Tools.Data.InventoryDataGrid();
            this.bsInventory = new SPPBC.M3Tools.Data.InventoryBindingSource();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.idg_Inventory);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(775, 345);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // dbInventory
            // 
            this.dbInventory.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbInventory.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbInventory.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // idg_Inventory
            // 
            this.idg_Inventory.AllowUserToAddRows = false;
            this.idg_Inventory.AllowUserToOrderColumns = true;
            this.idg_Inventory.CanReorder = true;
            this.idg_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idg_Inventory.DataSource = this.bsInventory;
            this.idg_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idg_Inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.idg_Inventory.Location = new System.Drawing.Point(0, 0);
            this.idg_Inventory.Name = "idg_Inventory";
            this.idg_Inventory.ReadOnly = true;
            this.idg_Inventory.RowsCheckable = false;
            this.idg_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idg_Inventory.Size = new System.Drawing.Size(775, 345);
            this.idg_Inventory.TabIndex = 1;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Icon = global::M3App.Properties.Resources.App_Icon;
            this.Name = "InventoryManagement";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal SPPBC.M3Tools.Database.InventoryDatabase dbInventory;
		private SPPBC.M3Tools.Data.InventoryDataGrid idg_Inventory;
		private SPPBC.M3Tools.Data.InventoryBindingSource bsInventory;
	}
}
