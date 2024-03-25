using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Events.Customers;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomersManagement : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersManagement));
            ss_StatusView = new StatusStrip();
            tss_CustomersView = new ToolStripStatusLabel();
            mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            mms_Main.Logout += Logout;
            mms_Main.UpdateAvailable += ExitApplication;
            mms_Main.ExitApplication += ExitApplication;
            mms_Main.ManageOrders += ManageOrders;
            mms_Main.ManageProducts += ManageProducts;
            mms_Main.ManageListeners += ManageListeners;
            mms_Main.ViewSettings += ViewSettings;
            mms_Main.AddCustomer += AddCustomer;
            bsCustomers = new CustomersBindingSource();
            dbCustomers = new CustomerDatabase(components);
            ToolStripContainer1 = new ToolStripContainer();
            cdg_Customers = new SPPBC.M3Tools.CustomersDataGrid();
            cdg_Customers.EditCustomer += UpdateCustomer;
            cdg_Customers.RemoveCustomer += RemoveCustomer;
            ts_Tools = new SPPBC.M3Tools.ToolsToolStrip(components);
            ts_Tools.Add += ToolsAddCustomer;
            ts_Tools.FilterChanged += FilterChanged;
            ss_StatusView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCustomers).BeginInit();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cdg_Customers).BeginInit();
            SuspendLayout();
            // 
            // ss_StatusView
            // 
            ss_StatusView.BackColor = SystemColors.Control;
            ss_StatusView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ss_StatusView.ImageScalingSize = new Size(32, 32);
            ss_StatusView.Items.AddRange(new ToolStripItem[] { tss_CustomersView });
            ss_StatusView.Location = new Point(0, 439);
            ss_StatusView.Name = "ss_StatusView";
            ss_StatusView.Size = new Size(784, 22);
            ss_StatusView.TabIndex = 3;
            // 
            // tss_CustomersView
            // 
            tss_CustomersView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tss_CustomersView.Name = "tss_CustomersView";
            tss_CustomersView.Size = new Size(170, 17);
            tss_CustomersView.Text = "Here are the current customers";
            // 
            // mms_Main
            // 
            mms_Main.Location = new Point(0, 0);
            mms_Main.Name = "mms_Main";
            mms_Main.Size = new Size(784, 24);
            mms_Main.TabIndex = 6;
            mms_Main.Text = "Menu";
            // 
            // dbCustomers
            // 
            dbCustomers.BaseUrl = My.MySettings.Default.BaseUrl;
            dbCustomers.Password = My.MySettings.Default.ApiPassword;
            dbCustomers.Username = My.MySettings.Default.ApiUsername;
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(cdg_Customers);
            ToolStripContainer1.ContentPanel.Size = new Size(784, 376);
            ToolStripContainer1.Dock = DockStyle.Fill;
            ToolStripContainer1.Location = new Point(0, 24);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.Size = new Size(784, 415);
            ToolStripContainer1.TabIndex = 7;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_Tools);
            // 
            // cdg_Customers
            // 
            cdg_Customers.AllowColumnReordering = true;
            cdg_Customers.AllowUserToAddRows = false;
            cdg_Customers.AllowUserToOrderColumns = true;
            cdg_Customers.AutoGenerateColumns = false;
            cdg_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cdg_Customers.CustomersSelectable = false;
            cdg_Customers.DataSource = bsCustomers;
            cdg_Customers.Dock = DockStyle.Fill;
            cdg_Customers.EditMode = DataGridViewEditMode.EditProgrammatically;
            cdg_Customers.Location = new Point(0, 0);
            cdg_Customers.Margin = new Padding(4, 5, 4, 5);
            cdg_Customers.Name = "cdg_Customers";
            cdg_Customers.ReadOnly = true;
            cdg_Customers.RowHeadersWidth = 82;
            cdg_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cdg_Customers.Size = new Size(784, 376);
            cdg_Customers.TabIndex = 1;
            // 
            // ts_Tools
            // 
            ts_Tools.Dock = DockStyle.None;
            ts_Tools.GripStyle = ToolStripGripStyle.Hidden;
            ts_Tools.ImageScalingSize = new Size(32, 32);
            ts_Tools.ListType = null;
            ts_Tools.Location = new Point(0, 0);
            ts_Tools.Name = "ts_Tools";
            ts_Tools.RenderMode = ToolStripRenderMode.Professional;
            ts_Tools.Size = new Size(784, 39);
            ts_Tools.Stretch = true;
            ts_Tools.TabIndex = 2;
            ts_Tools.Text = "ToolsToolStrip1";
            // 
            // CustomersManagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(784, 461);
            Controls.Add(ToolStripContainer1);
            Controls.Add(ss_StatusView);
            Controls.Add(mms_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mms_Main;
            MaximizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "CustomersManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ss_StatusView.ResumeLayout(false);
            ss_StatusView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCustomers).EndInit();
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cdg_Customers).EndInit();
            Load += new EventHandler(Loading);
            Closing += new System.ComponentModel.CancelEventHandler(DisplayClosing);
            CustomerAdd += new CustomerEventHandler(AddCustomer);
            CustomerDBModified += new CustomerEventHandler(Reload);
            Load += new EventHandler(Reload);
            ResumeLayout(false);
            PerformLayout();

        }
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_CustomersView;
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal SPPBC.M3Tools.Database.CustomerDatabase dbCustomers;
        internal CustomersBindingSource bsCustomers;
        internal ToolStripContainer ToolStripContainer1;
        internal SPPBC.M3Tools.CustomersDataGrid cdg_Customers;
        internal SPPBC.M3Tools.ToolsToolStrip ts_Tools;
    }
}
