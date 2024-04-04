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
            this.bsCustomers = new SPPBC.M3Tools.Data.CustomersBindingSource();
            this.dbCustomers = new SPPBC.M3Tools.Database.CustomerDatabase(this.components);
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cdg_Customers = new SPPBC.M3Tools.Data.CustomerDataGrid();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn3 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn3 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn2 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn2 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.ts_Tools = new SPPBC.M3Tools.ToolsToolStrip(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.ss_StatusView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // ss_StatusView
            // 
            this.ss_StatusView.BackColor = System.Drawing.SystemColors.Control;
            this.ss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_StatusView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_StatusView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_CustomersView});
            this.ss_StatusView.Location = new System.Drawing.Point(0, 439);
            this.ss_StatusView.Name = "ss_StatusView";
            this.ss_StatusView.Size = new System.Drawing.Size(784, 22);
            this.ss_StatusView.TabIndex = 3;
            // 
            // tss_CustomersView
            // 
            this.tss_CustomersView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_CustomersView.Name = "tss_CustomersView";
            this.tss_CustomersView.Size = new System.Drawing.Size(170, 17);
            this.tss_CustomersView.Text = "Here are the current customers";
            // 
            // mms_Main
            // 
            this.mms_Main.Location = new System.Drawing.Point(0, 0);
            this.mms_Main.Name = "mms_Main";
            this.mms_Main.Size = new System.Drawing.Size(784, 24);
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
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 376);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(784, 415);
            this.ToolStripContainer1.TabIndex = 7;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ts_Tools);
            // 
            // cdg_Customers
            // 
            this.cdg_Customers.AllowColumnReordering = true;
            this.cdg_Customers.AllowUserToAddRows = false;
            this.cdg_Customers.AllowUserToOrderColumns = true;
            this.cdg_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdg_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewImageButtonEditColumn3,
            this.dataGridViewImageButtonDeleteColumn3});
            this.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdg_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cdg_Customers.Location = new System.Drawing.Point(0, 0);
            this.cdg_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdg_Customers.Name = "cdg_Customers";
            this.cdg_Customers.ReadOnly = true;
            this.cdg_Customers.RowHeadersWidth = 82;
            this.cdg_Customers.RowsCheckable = false;
            this.cdg_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cdg_Customers.Size = new System.Drawing.Size(784, 376);
            this.cdg_Customers.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn3.Frozen = true;
            this.dataGridViewCheckBoxColumn3.HeaderText = "";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            this.dataGridViewCheckBoxColumn3.Width = 25;
            // 
            // dataGridViewImageButtonEditColumn3
            // 
            this.dataGridViewImageButtonEditColumn3.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn3.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn3.HeaderText = "";
            this.dataGridViewImageButtonEditColumn3.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn3.Name = "dataGridViewImageButtonEditColumn3";
            this.dataGridViewImageButtonEditColumn3.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn3.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn3.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn3
            // 
            this.dataGridViewImageButtonDeleteColumn3.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn3.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn3.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn3.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn3.Name = "dataGridViewImageButtonDeleteColumn3";
            this.dataGridViewImageButtonDeleteColumn3.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn3.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn3.Width = 25;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn2.Frozen = true;
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            this.dataGridViewCheckBoxColumn2.Width = 25;
            // 
            // dataGridViewImageButtonEditColumn2
            // 
            this.dataGridViewImageButtonEditColumn2.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn2.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn2.HeaderText = "";
            this.dataGridViewImageButtonEditColumn2.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn2.Name = "dataGridViewImageButtonEditColumn2";
            this.dataGridViewImageButtonEditColumn2.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn2.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn2.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn2
            // 
            this.dataGridViewImageButtonDeleteColumn2.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn2.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn2.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn2.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn2.Name = "dataGridViewImageButtonDeleteColumn2";
            this.dataGridViewImageButtonDeleteColumn2.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn2.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn2.Width = 25;
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewImageButtonEditColumn1
            // 
            this.dataGridViewImageButtonEditColumn1.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn1.HeaderText = "";
            this.dataGridViewImageButtonEditColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn1.Name = "dataGridViewImageButtonEditColumn1";
            this.dataGridViewImageButtonEditColumn1.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn1.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn1.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn1
            // 
            this.dataGridViewImageButtonDeleteColumn1.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn1.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn1.Name = "dataGridViewImageButtonDeleteColumn1";
            this.dataGridViewImageButtonDeleteColumn1.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn1.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn1.Width = 25;
            // 
            // CustomerManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
            this.Load += new System.EventHandler(this.Reload);
            this.ss_StatusView.ResumeLayout(false);
            this.ss_StatusView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_CustomersView;
        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal SPPBC.M3Tools.Database.CustomerDatabase dbCustomers;
        internal CustomersBindingSource bsCustomers;
        internal ToolStripContainer ToolStripContainer1;
        internal SPPBC.M3Tools.Data.CustomerDataGrid cdg_Customers;
        internal SPPBC.M3Tools.ToolsToolStrip ts_Tools;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn2;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn2;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn3;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn3;
	}
}
