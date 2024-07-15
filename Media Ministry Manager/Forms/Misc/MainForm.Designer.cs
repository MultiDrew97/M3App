using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_OrderManagement = new System.Windows.Forms.Button();
            this.btn_ProductManagement = new System.Windows.Forms.Button();
            this.btn_CustomerManagement = new System.Windows.Forms.Button();
            this.ss_Queries = new System.Windows.Forms.StatusStrip();
            this.tss_Feedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.bw_ChangedSizes = new System.ComponentModel.BackgroundWorker();
            this.btn_EmailMinistry = new System.Windows.Forms.Button();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            this.dbCustomer = new SPPBC.M3Tools.Database.CustomerDatabase(this.components);
            this.dbListener = new SPPBC.M3Tools.Database.ListenerDatabase(this.components);
            this.dbInventory = new SPPBC.M3Tools.Database.InventoryDatabase(this.components);
			this.dbOrders = new SPPBC.M3Tools.Database.OrdersDatabase(this.components);
            this.ss_Queries.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OrderManagement
            // 
            this.btn_OrderManagement.Enabled = false;
            this.btn_OrderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderManagement.Location = new System.Drawing.Point(24, 228);
            this.btn_OrderManagement.Name = "btn_OrderManagement";
            this.btn_OrderManagement.Size = new System.Drawing.Size(226, 43);
            this.btn_OrderManagement.TabIndex = 3;
            this.btn_OrderManagement.Text = "Order Management";
            this.btn_OrderManagement.UseVisualStyleBackColor = true;
            this.btn_OrderManagement.Click += new System.EventHandler(this.ManageOrders);
            // 
            // btn_ProductManagement
            // 
            this.btn_ProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductManagement.Location = new System.Drawing.Point(24, 160);
            this.btn_ProductManagement.Name = "btn_ProductManagement";
            this.btn_ProductManagement.Size = new System.Drawing.Size(226, 43);
            this.btn_ProductManagement.TabIndex = 4;
            this.btn_ProductManagement.Text = "Product Management";
            this.btn_ProductManagement.UseVisualStyleBackColor = true;
            this.btn_ProductManagement.Click += new System.EventHandler(this.MangeInventory);
            // 
            // btn_CustomerManagement
            // 
            this.btn_CustomerManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerManagement.Location = new System.Drawing.Point(24, 95);
            this.btn_CustomerManagement.Name = "btn_CustomerManagement";
            this.btn_CustomerManagement.Size = new System.Drawing.Size(226, 43);
            this.btn_CustomerManagement.TabIndex = 1;
            this.btn_CustomerManagement.Text = "Customer Management";
            this.btn_CustomerManagement.UseVisualStyleBackColor = true;
            this.btn_CustomerManagement.Click += new System.EventHandler(this.ManageCustomers);
            // 
            // ss_Queries
            // 
            this.ss_Queries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Feedback});
            this.ss_Queries.Location = new System.Drawing.Point(0, 300);
            this.ss_Queries.Name = "ss_Queries";
            this.ss_Queries.Size = new System.Drawing.Size(272, 22);
            this.ss_Queries.TabIndex = 0;
            // 
            // tss_Feedback
            // 
            this.tss_Feedback.Name = "tss_Feedback";
            this.tss_Feedback.Size = new System.Drawing.Size(151, 17);
            this.tss_Feedback.Text = "What would you like to do?";
            // 
            // btn_EmailMinistry
            // 
            this.btn_EmailMinistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EmailMinistry.Location = new System.Drawing.Point(24, 27);
            this.btn_EmailMinistry.Name = "btn_EmailMinistry";
            this.btn_EmailMinistry.Size = new System.Drawing.Size(226, 43);
            this.btn_EmailMinistry.TabIndex = 5;
            this.btn_EmailMinistry.Text = "Email Ministry";
            this.btn_EmailMinistry.UseVisualStyleBackColor = true;
            this.btn_EmailMinistry.Click += new System.EventHandler(this.ManageListeners);
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(397, 413);
            this.pnl_Controls.TabIndex = 0;
            // 
            // mms_Main
            // 
            this.mms_Main.Location = new System.Drawing.Point(0, 0);
            this.mms_Main.Name = "mms_Main";
            this.mms_Main.Size = new System.Drawing.Size(272, 24);
            this.mms_Main.TabIndex = 7;
            this.mms_Main.Text = "Tools";
            // 
            // dbCustomer
            // 
            this.dbCustomer.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbCustomer.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbCustomer.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // dbListener
            // 
            this.dbListener.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbListener.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbListener.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // dbInventory
            // 
            this.dbInventory.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbInventory.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbInventory.Username = global::M3App.Properties.Settings.Default.ApiUsername;
			// 
			// dbOrders
			//
			this.dbOrders.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
			this.dbOrders.Password = global::M3App.Properties.Settings.Default.ApiPassword;
			this.dbOrders.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(272, 322);
            this.Controls.Add(this.btn_OrderManagement);
            this.Controls.Add(this.btn_ProductManagement);
            this.Controls.Add(this.btn_CustomerManagement);
            this.Controls.Add(this.btn_EmailMinistry);
            this.Controls.Add(this.mms_Main);
            this.Controls.Add(this.ss_Queries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mms_Main;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ministry Manager";
            this.Load += new System.EventHandler(this.Reload);
            this.ss_Queries.ResumeLayout(false);
            this.ss_Queries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button btn_OrderManagement;
        internal Button btn_ProductManagement;
        internal Button btn_CustomerManagement;
        internal StatusStrip ss_Queries;
        internal ToolStripStatusLabel tss_Feedback;
        internal System.ComponentModel.BackgroundWorker bw_ChangedSizes;
        internal Button btn_EmailMinistry;
        internal Panel pnl_Controls;
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal CustomerDatabase dbCustomer;
        internal ListenerDatabase dbListener;
        internal InventoryDatabase dbInventory;
		internal OrdersDatabase dbOrders;
    }
}
