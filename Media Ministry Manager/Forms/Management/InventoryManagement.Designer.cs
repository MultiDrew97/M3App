using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;
using SPPBC.M3Tools.Events.Inventory;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InventoryManagement : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagement));
            mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            mms_Main.Logout += Logout;
            mms_Main.ExitApplication += ExitApplication;
            mms_Main.UpdateAvailable += ExitApplication;
            mms_Main.ManageOrders += ManageOrders;
            mms_Main.ManageCustomers += ManageProducts;
            mms_Main.ManageListeners += ManageListeners;
            mms_Main.ViewSettings += ViewSettings;
            mms_Main.AddProduct += AddProduct;
            bsInventory = new BindingSource(components);
            dbInventory = new InventoryDatabase(components);
            ss_StatusView = new StatusStrip();
            tss_StatusView = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)bsInventory).BeginInit();
            ss_StatusView.SuspendLayout();
            SuspendLayout();
            // 
            // mms_Main
            // 
            mms_Main.Location = new Point(0, 0);
            mms_Main.Name = "mms_Main";
            mms_Main.Size = new Size(800, 24);
            mms_Main.TabIndex = 1;
            mms_Main.Text = "MainMenuStrip1";
            // 
            // dbInventory
            // 
            dbInventory.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbInventory.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbInventory.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // ss_StatusView
            // 
            ss_StatusView.BackColor = SystemColors.Control;
            ss_StatusView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ss_StatusView.ImageScalingSize = new Size(32, 32);
            ss_StatusView.Items.AddRange(new ToolStripItem[] { tss_StatusView });
            ss_StatusView.Location = new Point(0, 439);
            ss_StatusView.Name = "ss_StatusView";
            ss_StatusView.Size = new Size(800, 22);
            ss_StatusView.TabIndex = 5;
            // 
            // tss_StatusView
            // 
            tss_StatusView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tss_StatusView.Name = "tss_StatusView";
            tss_StatusView.Size = new Size(157, 17);
            tss_StatusView.Text = "Here is the current inventory";
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(ss_StatusView);
            Controls.Add(mms_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mms_Main;
            MinimumSize = new Size(800, 500);
            Name = "InventoryManagement";
            Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)bsInventory).EndInit();
            ss_StatusView.ResumeLayout(false);
            ss_StatusView.PerformLayout();
            Load += new EventHandler(Reload);
            Closing += new System.ComponentModel.CancelEventHandler(DisplayClosing);
            InventoryDBModified += new InventoryEventHandler(Reload);
            ResumeLayout(false);
            PerformLayout();

        }
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal BindingSource bsInventory;
        internal InventoryDatabase dbInventory;
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_StatusView;
    }
}
