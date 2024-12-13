using System.Diagnostics;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OrderManagement : ManagementForm<SPPBC.M3Tools.Types.Order>
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
			this.odg_Orders = new SPPBC.M3Tools.Data.OrderDataGrid();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
			this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
			this.dbOrders = new SPPBC.M3Tools.API.OrdersDatabase(this.components);
			this.dbCustomers = new SPPBC.M3Tools.API.CustomerDatabase(this.components);
			this.dbInventory = new SPPBC.M3Tools.API.InventoryDatabase(this.components);
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.odg_Orders)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = true;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.odg_Orders);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(765, 244);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 48);
			this.toolStripContainer1.Size = new System.Drawing.Size(765, 361);
			this.toolStripContainer1.TopToolStripPanelVisible = true;
			// 
			// odg_Orders
			// 
			this.odg_Orders.AllowUserToAddRows = false;
			this.odg_Orders.AllowUserToOrderColumns = true;
			this.odg_Orders.AutoGenerateColumns = false;
			this.odg_Orders.CanReorder = true;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.odg_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.odg_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.odg_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageButtonEditColumn1,
            this.dataGridViewImageButtonDeleteColumn1});
			dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.odg_Orders.DefaultCellStyle = dataGridViewCellStyle73;
			this.odg_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.odg_Orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.odg_Orders.Location = new System.Drawing.Point(0, 0);
			this.odg_Orders.Name = "odg_Orders";
			this.odg_Orders.ReadOnly = true;
			dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle74.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.odg_Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle74;
			this.odg_Orders.RowHeadersWidth = 82;
			this.odg_Orders.RowsCheckable = false;
			this.odg_Orders.RowTemplate.Height = 28;
			this.odg_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.odg_Orders.Size = new System.Drawing.Size(765, 244);
			this.odg_Orders.TabIndex = 0;
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
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 200;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer.Name";
			this.dataGridViewTextBoxColumn2.FillWeight = 25F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Customer";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 96;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Item.Name";
			this.dataGridViewTextBoxColumn3.FillWeight = 25F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Item";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
			dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle65.NullValue = "0";
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle65;
			this.dataGridViewTextBoxColumn4.FillWeight = 25F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
			dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle66.Format = "C2";
			dataGridViewCellStyle66.NullValue = "$0.00";
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle66;
			this.dataGridViewTextBoxColumn5.FillWeight = 25F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Total";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderDate";
			dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle71.Format = "d";
			dataGridViewCellStyle71.NullValue = "N/A";
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle71;
			this.dataGridViewTextBoxColumn6.FillWeight = 25F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Ordered";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "CompletedDate";
			dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle72.Format = "d";
			dataGridViewCellStyle72.NullValue = "N/A";
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle72;
			this.dataGridViewTextBoxColumn7.FillWeight = 25F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Completed";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
			// OrderManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 409);
			this.Name = "OrderManagement";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.odg_Orders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private SPPBC.M3Tools.Data.OrderDataGrid odg_Orders;
		private SPPBC.M3Tools.API.OrdersDatabase dbOrders;
		private SPPBC.M3Tools.API.CustomerDatabase dbCustomers;
		private SPPBC.M3Tools.API.InventoryDatabase dbInventory;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
	}
}
