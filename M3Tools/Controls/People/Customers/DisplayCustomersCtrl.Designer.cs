using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DisplayCustomersCtrl : System.Windows.Forms.UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayCustomersCtrl));
            tbtn_Refresh = new System.Windows.Forms.ToolStripButton();
            BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            ts_CustomerTools = new System.Windows.Forms.ToolStrip();
            tbtn_AddCustomer = new System.Windows.Forms.ToolStripButton();
            tbtn_AddCustomer.Click += new EventHandler(NewCustomer);
            tbtn_Import = new System.Windows.Forms.ToolStripButton();
            ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsl_Count = new System.Windows.Forms.ToolStripLabel();
            txt_Filter = new System.Windows.Forms.ToolStripTextBox();
            txt_Filter.TextChanged += new EventHandler(FilterChanged);
            RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            cdg_Customers = new CustomersDataGrid();
            cdg_Customers.RefreshDisplay += new CustomersDataGrid.RefreshDisplayEventHandler(RefreshView);
            cdg_Customers.EditCustomer += new Events.Customers.CustomerEventHandler(EditCustomer);
            cdg_Customers.RemoveCustomer += new Events.Customers.CustomerEventHandler(DeleteCustomer);
            ts_CustomerTools.SuspendLayout();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tbtn_Refresh
            // 
            tbtn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_Refresh.Enabled = false;
            tbtn_Refresh.Image = (System.Drawing.Image)resources.GetObject("tbtn_Refresh.Image");
            tbtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_Refresh.Name = "tbtn_Refresh";
            tbtn_Refresh.Size = new System.Drawing.Size(36, 36);
            tbtn_Refresh.Text = "Refresh";
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ts_CustomerTools
            // 
            ts_CustomerTools.Dock = System.Windows.Forms.DockStyle.None;
            ts_CustomerTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_CustomerTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbtn_AddCustomer, tbtn_Import, ToolStripSeparator2, tsl_Count, txt_Filter });
            ts_CustomerTools.Location = new System.Drawing.Point(3, 0);
            ts_CustomerTools.Name = "ts_CustomerTools";
            ts_CustomerTools.Size = new System.Drawing.Size(275, 25);
            ts_CustomerTools.TabIndex = 9;
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
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ContentPanel.Size = new System.Drawing.Size(748, 525);
            // 
            // ToolStripContainer1
            // 
            ToolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(cdg_Customers);
            ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(748, 525);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.LeftToolStripPanelVisible = false;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.RightToolStripPanelVisible = false;
            ToolStripContainer1.Size = new System.Drawing.Size(748, 550);
            ToolStripContainer1.TabIndex = 9;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_CustomerTools);
            // 
            // cdg_Customers
            // 
            cdg_Customers.AllowColumnReordering = true;
            cdg_Customers.AutoSize = true;
            cdg_Customers.CustomersSelectable = false;
            cdg_Customers.DataSource = null;
            cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            cdg_Customers.Location = new System.Drawing.Point(0, 0);
            cdg_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cdg_Customers.MinimumSize = new System.Drawing.Size(600, 500);
            cdg_Customers.Name = "cdg_Customers";
            cdg_Customers.Size = new System.Drawing.Size(748, 525);
            cdg_Customers.TabIndex = 0;
            // 
            // DisplayCustomersCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9.0f, 20.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(ToolStripContainer1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "DisplayCustomersCtrl";
            Size = new System.Drawing.Size(748, 550);
            ts_CustomerTools.ResumeLayout(false);
            ts_CustomerTools.PerformLayout();
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.ContentPanel.PerformLayout();
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.ToolStripButton tbtn_Refresh;
        internal System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        internal System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        internal System.Windows.Forms.ToolStrip ts_CustomerTools;
        internal System.Windows.Forms.ToolStripButton tbtn_AddCustomer;
        internal System.Windows.Forms.ToolStripButton tbtn_Import;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripLabel tsl_Count;
        internal System.Windows.Forms.ToolStripTextBox txt_Filter;
        internal System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        internal System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        internal System.Windows.Forms.ToolStripContentPanel ContentPanel;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal CustomersDataGrid cdg_Customers;
    }
}