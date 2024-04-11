using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Data;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomerManagement : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.ss_StatusView = new System.Windows.Forms.StatusStrip();
            this.tss_CustomersView = new System.Windows.Forms.ToolStripStatusLabel();
            this.mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            this.dbCustomers = new SPPBC.M3Tools.Database.CustomerDatabase(this.components);
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cdg_Customers = new SPPBC.M3Tools.Data.CustomerDataGrid();
            this.ts_Tools = new SPPBC.M3Tools.ToolsToolStrip(this.components);
            this.bsCustomers = new SPPBC.M3Tools.Data.CustomerBindingSource();
            this.ss_StatusView.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // ss_StatusView
            // 
            this.ss_StatusView.BackColor = System.Drawing.SystemColors.Control;
            this.ss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_StatusView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_StatusView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_CustomersView});
            this.ss_StatusView.Location = new System.Drawing.Point(0, 450);
            this.ss_StatusView.Name = "ss_StatusView";
            this.ss_StatusView.Size = new System.Drawing.Size(784, 11);
            this.ss_StatusView.TabIndex = 3;
            // 
            // tss_CustomersView
            // 
            this.tss_CustomersView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_CustomersView.Name = "tss_CustomersView";
            this.tss_CustomersView.Size = new System.Drawing.Size(170, 6);
            this.tss_CustomersView.Text = "Here are the current customers";
            // 
            // mms_Main
            // 
            this.mms_Main.Location = new System.Drawing.Point(0, 0);
            this.mms_Main.Name = "mms_Main";
            this.mms_Main.Size = new System.Drawing.Size(784, 12);
            this.mms_Main.TabIndex = 6;
            this.mms_Main.Text = "Menu";
            // 
            // dbCustomers
            // 
            this.dbCustomers.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            this.dbCustomers.Password = global::M3App.My.Settings.Default.ApiPassword;
            this.dbCustomers.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.ContentPanel
            // 
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.cdg_Customers);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 411);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 6);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(784, 450);
            this.ToolStripContainer1.TabIndex = 7;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ts_Tools);
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
            this.cdg_Customers.Size = new System.Drawing.Size(784, 411);
            this.cdg_Customers.TabIndex = 1;
            // 
            // ts_Tools
            // 
            this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_Tools.ListType = null;
            this.ts_Tools.Location = new System.Drawing.Point(0, 0);
            this.ts_Tools.Name = "ts_Tools";
            this.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_Tools.Size = new System.Drawing.Size(784, 39);
            this.ts_Tools.Stretch = true;
            this.ts_Tools.TabIndex = 2;
            this.ts_Tools.Text = "ToolsToolStrip1";
            // 
            // CustomerManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1568, 922);
            this.Controls.Add(this.ToolStripContainer1);
            this.Controls.Add(this.ss_StatusView);
            this.Controls.Add(this.mms_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mms_Main;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ministry Manager";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DisplayClosing);
            this.Load += new System.EventHandler(this.Loading);
            this.ss_StatusView.ResumeLayout(false);
            this.ss_StatusView.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_CustomersView;
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal SPPBC.M3Tools.Database.CustomerDatabase dbCustomers;
        internal ToolStripContainer ToolStripContainer1;
        internal SPPBC.M3Tools.Data.CustomerDataGrid cdg_Customers;
        internal SPPBC.M3Tools.ToolsToolStrip ts_Tools;
		private CustomerBindingSource bsCustomers;
	}
}
