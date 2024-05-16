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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_OrderManagement = new Button();
            btn_OrderManagement.Click += new EventHandler(ManageOrders);
            btn_ProductManagement = new Button();
            btn_ProductManagement.Click += new EventHandler(MangeInventory);
            btn_CustomerManagement = new Button();
            btn_CustomerManagement.Click += new EventHandler(ManageCustomers);
            ss_Queries = new StatusStrip();
            tss_Feedback = new ToolStripStatusLabel();
            bw_ChangedSizes = new System.ComponentModel.BackgroundWorker();
            btn_EmailMinistry = new Button();
            btn_EmailMinistry.Click += new EventHandler(ManageListeners);
            pnl_Controls = new Panel();
            mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            mms_Main.Logout += Logout;
            mms_Main.ExitApplication += ExitApp;
            mms_Main.UpdateAvailable += ExitApp;
            mms_Main.AddCustomer += AddCustomer;
            mms_Main.AddListener += AddListener;
            mms_Main.AddProduct += AddProduct;
            mms_Main.ViewSettings += ViewSettings;
            wb_Updater = new WebBrowser();
            dbCustomer = new CustomerDatabase(components);
            dbListener = new ListenerDatabase(components);
            dbInventory = new InventoryDatabase(components);
            ss_Queries.SuspendLayout();
            SuspendLayout();
            // 
            // btn_OrderManagement
            // 
            btn_OrderManagement.Enabled = false;
            btn_OrderManagement.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OrderManagement.Location = new Point(24, 95);
            btn_OrderManagement.Name = "btn_OrderManagement";
            btn_OrderManagement.Size = new Size(226, 43);
            btn_OrderManagement.TabIndex = 3;
            btn_OrderManagement.Text = "Order Management";
            btn_OrderManagement.UseVisualStyleBackColor = true;
            // 
            // btn_ProductManagement
            // 
            btn_ProductManagement.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ProductManagement.Location = new Point(24, 160);
            btn_ProductManagement.Name = "btn_ProductManagement";
            btn_ProductManagement.Size = new Size(226, 43);
            btn_ProductManagement.TabIndex = 4;
            btn_ProductManagement.Text = "Product Management";
            btn_ProductManagement.UseVisualStyleBackColor = true;
            // 
            // btn_CustomerManagement
            // 
            btn_CustomerManagement.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CustomerManagement.Location = new Point(24, 27);
            btn_CustomerManagement.Name = "btn_CustomerManagement";
            btn_CustomerManagement.Size = new Size(226, 43);
            btn_CustomerManagement.TabIndex = 1;
            btn_CustomerManagement.Text = "Customer Management";
            btn_CustomerManagement.UseVisualStyleBackColor = true;
            // 
            // ss_Queries
            // 
            ss_Queries.Items.AddRange(new ToolStripItem[] { tss_Feedback });
            ss_Queries.Location = new Point(0, 300);
            ss_Queries.Name = "ss_Queries";
            ss_Queries.Size = new Size(272, 22);
            ss_Queries.TabIndex = 0;
            // 
            // tss_Feedback
            // 
            tss_Feedback.Name = "tss_Feedback";
            tss_Feedback.Size = new Size(151, 17);
            tss_Feedback.Text = "What would you like to do?";
            // 
            // btn_EmailMinistry
            // 
            btn_EmailMinistry.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
            btn_EmailMinistry.Location = new Point(24, 221);
            btn_EmailMinistry.Name = "btn_EmailMinistry";
            btn_EmailMinistry.Size = new Size(226, 43);
            btn_EmailMinistry.TabIndex = 5;
            btn_EmailMinistry.Text = "Email Ministry";
            btn_EmailMinistry.UseVisualStyleBackColor = true;
            // 
            // pnl_Controls
            // 
            pnl_Controls.BackColor = Color.Transparent;
            pnl_Controls.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Controls.Dock = DockStyle.Fill;
            pnl_Controls.Location = new Point(0, 0);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(397, 413);
            pnl_Controls.TabIndex = 0;
            // 
            // mms_Main
            // 
            mms_Main.Location = new Point(0, 0);
            mms_Main.Name = "mms_Main";
            mms_Main.Size = new Size(272, 24);
            mms_Main.TabIndex = 7;
            mms_Main.Text = "Tools";
            // 
            // wb_Updater
            // 
            wb_Updater.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            wb_Updater.Location = new Point(222, 277);
            wb_Updater.MinimumSize = new Size(20, 20);
            wb_Updater.Name = "wb_Updater";
            wb_Updater.Size = new Size(38, 20);
            wb_Updater.TabIndex = 8;
            wb_Updater.Url = new Uri("", UriKind.Relative);
            wb_Updater.Visible = false;
            // 
            // dbCustomer
            // 
            dbCustomer.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbCustomer.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbCustomer.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // dbListener
            // 
            dbListener.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbListener.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbListener.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // dbInventory
            // 
            dbInventory.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbInventory.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbInventory.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(272, 322);
            Controls.Add(wb_Updater);
            Controls.Add(mms_Main);
            Controls.Add(btn_EmailMinistry);
            Controls.Add(ss_Queries);
            Controls.Add(btn_CustomerManagement);
            Controls.Add(btn_OrderManagement);
            Controls.Add(btn_ProductManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mms_Main;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ss_Queries.ResumeLayout(false);
            ss_Queries.PerformLayout();
            Load += new EventHandler(Reload);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button btn_OrderManagement;
        internal Button btn_ProductManagement;
        internal Button btn_CustomerManagement;
        internal StatusStrip ss_Queries;
        internal ToolStripStatusLabel tss_Feedback;
        internal System.ComponentModel.BackgroundWorker bw_ChangedSizes;
        internal Button btn_EmailMinistry;
        internal WebBrowser wb_Updater;
        internal Panel pnl_Controls;
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal CustomerDatabase dbCustomer;
        internal ListenerDatabase dbListener;
        internal InventoryDatabase dbInventory;
    }
}
