using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
            this.odg_Orders = new SPPBC.M3Tools.Data.OrderDataGrid();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
            this.bsOrders = new SPPBC.M3Tools.Data.OrderBindingSource();
            this.dbOrders = new SPPBC.M3Tools.Database.OrdersDatabase(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odg_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.odg_Orders);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(775, 345);
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // odg_Orders
            // 
            this.odg_Orders.AllowUserToAddRows = false;
            this.odg_Orders.AllowUserToOrderColumns = true;
            this.odg_Orders.AutoGenerateColumns = false;
            this.odg_Orders.CanReorder = true;
            this.odg_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odg_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageButtonEditColumn1,
            this.dataGridViewImageButtonDeleteColumn1});
            this.odg_Orders.DataSource = this.bsOrders;
            this.odg_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.odg_Orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.odg_Orders.Location = new System.Drawing.Point(0, 0);
            this.odg_Orders.Name = "odg_Orders";
            this.odg_Orders.ReadOnly = true;
            this.odg_Orders.RowTemplate.Height = 28;
            this.odg_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.odg_Orders.Size = new System.Drawing.Size(775, 345);
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
            // dbOrders
            // 
            this.dbOrders.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbOrders.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbOrders.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Name = "OrderManagement";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odg_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		private SPPBC.M3Tools.Data.OrderDataGrid odg_Orders;
		private SPPBC.M3Tools.Database.OrdersDatabase dbOrders;
		private SPPBC.M3Tools.Data.OrderBindingSource bsOrders;
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
	}
}
