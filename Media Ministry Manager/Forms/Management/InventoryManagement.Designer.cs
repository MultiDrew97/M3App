using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;
using SPPBC.M3Tools.Events.Inventory;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagement));
            this.dbInventory = new SPPBC.M3Tools.Database.InventoryDatabase(this.components);
            this.ss_StatusView = new System.Windows.Forms.StatusStrip();
            this.tss_StatusView = new System.Windows.Forms.ToolStripStatusLabel();
            this.idg_Inventory = new SPPBC.M3Tools.Data.InventoryDataGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn3 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn3 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn2 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn2 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.bsInventory = new SPPBC.M3Tools.Data.InventoryBindingSource();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ss_StatusView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.idg_Inventory);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 365);
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 415);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // dbInventory
            // 
            this.dbInventory.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            this.dbInventory.Password = global::M3App.My.Settings.Default.ApiPassword;
            this.dbInventory.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // ss_StatusView
            // 
            this.ss_StatusView.BackColor = System.Drawing.SystemColors.Control;
            this.ss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_StatusView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_StatusView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_StatusView});
            this.ss_StatusView.Location = new System.Drawing.Point(0, 439);
            this.ss_StatusView.Name = "ss_StatusView";
            this.ss_StatusView.Size = new System.Drawing.Size(784, 22);
            this.ss_StatusView.TabIndex = 5;
            // 
            // tss_StatusView
            // 
            this.tss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_StatusView.Name = "tss_StatusView";
            this.tss_StatusView.Size = new System.Drawing.Size(157, 17);
            this.tss_StatusView.Text = "Here is the current inventory";
            // 
            // idg_Inventory
            // 
            this.idg_Inventory.AllowUserToAddRows = false;
            this.idg_Inventory.AllowUserToOrderColumns = true;
            this.idg_Inventory.AutoGenerateColumns = false;
            this.idg_Inventory.CanReorder = true;
            this.idg_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idg_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewImageButtonEditColumn3,
            this.dataGridViewImageButtonDeleteColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageButtonEditColumn2,
            this.dataGridViewImageButtonDeleteColumn2,
            this.dataGridViewImageButtonEditColumn1,
            this.dataGridViewImageButtonDeleteColumn1});
            this.idg_Inventory.DataSource = this.bsInventory;
            this.idg_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idg_Inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.idg_Inventory.Location = new System.Drawing.Point(0, 0);
            this.idg_Inventory.MinimumSize = new System.Drawing.Size(500, 400);
            this.idg_Inventory.Name = "idg_Inventory";
            this.idg_Inventory.ReadOnly = true;
            this.idg_Inventory.RowTemplate.Height = 28;
            this.idg_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idg_Inventory.Size = new System.Drawing.Size(784, 400);
            this.idg_Inventory.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn6.FillWeight = 20F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.FillWeight = 20F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Available";
            this.dataGridViewCheckBoxColumn2.FalseValue = "";
            this.dataGridViewCheckBoxColumn2.FillWeight = 20F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Available?";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.TrueValue = "";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn3.FillWeight = 20F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Available";
            this.dataGridViewCheckBoxColumn1.FalseValue = "";
            this.dataGridViewCheckBoxColumn1.FillWeight = 20F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Available?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "";
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
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ss_StatusView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DisplayClosing);
            this.Load += new System.EventHandler(this.Reload);
            this.Controls.SetChildIndex(this.ss_StatusView, 0);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ss_StatusView.ResumeLayout(false);
            this.ss_StatusView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal InventoryDatabase dbInventory;
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_StatusView;
		private SPPBC.M3Tools.Data.InventoryDataGrid idg_Inventory;
		private SPPBC.M3Tools.Data.InventoryBindingSource bsInventory;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn2;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private SPPBC.M3Tools.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn3;
		private SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn3;
	}
}
