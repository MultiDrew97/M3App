using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DisplayInventoryCtrl : System.Windows.Forms.UserControl
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
            components = new System.ComponentModel.Container();
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            idg_Inventory = new InventoryDataGrid();
            idg_Inventory.RefreshDisplay += new InventoryDataGrid.RefreshDisplayEventHandler(Reload);
            idg_Inventory.EditProduct += new Events.Inventory.InventoryEventHandler(EditProduct);
            idg_Inventory.RemoveProduct += new Events.Inventory.InventoryEventHandler(DeleteProduct);
            ts_InventoryTools = new System.Windows.Forms.ToolStrip();
            tbtn_AddCustomer = new System.Windows.Forms.ToolStripButton();
            tbtn_AddCustomer.Click += new EventHandler(NewItem);
            tbtn_Import = new System.Windows.Forms.ToolStripButton();
            tbtn_Import.Click += new EventHandler(ImportItem);
            ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsl_Count = new System.Windows.Forms.ToolStripLabel();
            txt_Filter = new System.Windows.Forms.ToolStripTextBox();
            txt_Filter.TextChanged += new EventHandler(FilterChanged);
            cms_Tools = new ToolsContextMenu();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ts_InventoryTools.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripContainer1
            // 
            ToolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(idg_Inventory);
            ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(834, 496);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.LeftToolStripPanelVisible = false;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.RightToolStripPanelVisible = false;
            ToolStripContainer1.Size = new System.Drawing.Size(834, 521);
            ToolStripContainer1.TabIndex = 10;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_InventoryTools);
            // 
            // idg_Inventory
            // 
            idg_Inventory.AllowColumnReordering = true;
            idg_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            idg_Inventory.Filter = null;
            idg_Inventory.Location = new System.Drawing.Point(0, 0);
            idg_Inventory.MinimumSize = new System.Drawing.Size(500, 400);
            idg_Inventory.Name = "idg_Inventory";
            idg_Inventory.InventorySelectable = false;
            idg_Inventory.Size = new System.Drawing.Size(834, 496);
            idg_Inventory.TabIndex = 0;
            // 
            // ts_InventoryTools
            // 
            ts_InventoryTools.Dock = System.Windows.Forms.DockStyle.None;
            ts_InventoryTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_InventoryTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbtn_AddCustomer, tbtn_Import, ToolStripSeparator2, tsl_Count, txt_Filter });
            ts_InventoryTools.Location = new System.Drawing.Point(3, 0);
            ts_InventoryTools.Name = "ts_InventoryTools";
            ts_InventoryTools.Size = new System.Drawing.Size(244, 25);
            ts_InventoryTools.TabIndex = 9;
            // 
            // tbtn_AddCustomer
            // 
            tbtn_AddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_AddCustomer.Image = My.Resources.Resources.NewDocumentOption;
            tbtn_AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_AddCustomer.Name = "tbtn_AddCustomer";
            tbtn_AddCustomer.Size = new System.Drawing.Size(23, 22);
            tbtn_AddCustomer.Text = "Add Customer";
            // 
            // tbtn_Import
            // 
            tbtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_Import.Enabled = false;
            tbtn_Import.Image = My.Resources.Resources.import;
            tbtn_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_Import.Name = "tbtn_Import";
            tbtn_Import.Size = new System.Drawing.Size(23, 22);
            tbtn_Import.Text = "Import Customers";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsl_Count
            // 
            tsl_Count.Name = "tsl_Count";
            tsl_Count.Size = new System.Drawing.Size(87, 22);
            tsl_Count.Text = "ToolStripLabel1";
            tsl_Count.ToolTipText = "Number of listeners currently subscribed";
            // 
            // txt_Filter
            // 
            txt_Filter.Font = new System.Drawing.Font("Segoe UI", 9.0f);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new System.Drawing.Size(100, 25);
            // 
            // cms_Tools
            // 
            cms_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            cms_Tools.Name = "cms_Tools";
            cms_Tools.Size = new System.Drawing.Size(133, 70);
            // 
            // DisplayInventoryCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ContextMenuStrip = cms_Tools;
            Controls.Add(ToolStripContainer1);
            Name = "DisplayInventoryCtrl";
            Size = new System.Drawing.Size(834, 521);
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ts_InventoryTools.ResumeLayout(false);
            ts_InventoryTools.PerformLayout();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.ToolStrip ts_InventoryTools;
        internal System.Windows.Forms.ToolStripButton tbtn_AddCustomer;
        internal System.Windows.Forms.ToolStripButton tbtn_Import;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripLabel tsl_Count;
        internal System.Windows.Forms.ToolStripTextBox txt_Filter;
        internal ToolsContextMenu cms_Tools;
        internal InventoryDataGrid idg_Inventory;
    }
}
