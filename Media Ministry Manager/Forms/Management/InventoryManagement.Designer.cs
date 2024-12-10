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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dbInventory = new SPPBC.M3Tools.API.InventoryDatabase(this.components);
			this.idg_Inventory = new SPPBC.M3Tools.Data.InventoryDataGrid();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
			this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = true;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.idg_Inventory);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(765, 244);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 48);
			this.toolStripContainer1.Size = new System.Drawing.Size(765, 361);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.TopToolStripPanelVisible = true;
			// 
			// idg_Inventory
			// 
			this.idg_Inventory.AllowUserToAddRows = false;
			this.idg_Inventory.AllowUserToOrderColumns = true;
			this.idg_Inventory.AutoGenerateColumns = false;
			this.idg_Inventory.CanReorder = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.idg_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.idg_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.idg_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewImageButtonEditColumn1,
            this.dataGridViewImageButtonDeleteColumn1});
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.idg_Inventory.DefaultCellStyle = dataGridViewCellStyle21;
			this.idg_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idg_Inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.idg_Inventory.Location = new System.Drawing.Point(0, 0);
			this.idg_Inventory.Name = "idg_Inventory";
			this.idg_Inventory.ReadOnly = true;
			dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.idg_Inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
			this.idg_Inventory.RowHeadersWidth = 82;
			this.idg_Inventory.RowsCheckable = false;
			this.idg_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.idg_Inventory.Size = new System.Drawing.Size(765, 244);
			this.idg_Inventory.TabIndex = 0;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewCheckBoxColumn1.FalseValue = "False";
			this.dataGridViewCheckBoxColumn1.Frozen = true;
			this.dataGridViewCheckBoxColumn1.HeaderText = "";
			this.dataGridViewCheckBoxColumn1.MinimumWidth = 25;
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewCheckBoxColumn1.TrueValue = "True";
			this.dataGridViewCheckBoxColumn1.Visible = false;
			this.dataGridViewCheckBoxColumn1.Width = 25;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 200;
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
			this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
			dataGridViewCellStyle19.Format = "C2";
			dataGridViewCellStyle19.NullValue = "$0.00";
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridViewTextBoxColumn4.FillWeight = 20F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Price";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "Available";
			this.dataGridViewCheckBoxColumn2.FalseValue = "False";
			this.dataGridViewCheckBoxColumn2.FillWeight = 20F;
			this.dataGridViewCheckBoxColumn2.HeaderText = "Available?";
			this.dataGridViewCheckBoxColumn2.MinimumWidth = 10;
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn2.TrueValue = "True";
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
			this.ClientSize = new System.Drawing.Size(765, 409);
			this.Name = "InventoryManagement";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.idg_Inventory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        internal SPPBC.M3Tools.API.InventoryDatabase dbInventory;
		private SPPBC.M3Tools.Data.InventoryDataGrid idg_Inventory;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
	}
}
