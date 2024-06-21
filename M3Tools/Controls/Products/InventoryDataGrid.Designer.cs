using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Data
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class InventoryDataGrid : DataGrid<Types.Product>
	{
		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		[DebuggerStepThrough()]
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgc_ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgc_Selection
            // 
            this.dgc_Selection.ReadOnly = true;
            // 
            // dgc_ItemId
            // 
            this.dgc_ItemId.DataPropertyName = "Id";
            this.dgc_ItemId.HeaderText = "ItemID";
            this.dgc_ItemId.Name = "dgc_ItemId";
            this.dgc_ItemId.ReadOnly = true;
            this.dgc_ItemId.Visible = false;
            // 
            // dgc_Name
            // 
            this.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Name.DataPropertyName = "Name";
            this.dgc_Name.FillWeight = 40F;
            this.dgc_Name.HeaderText = "Name";
            this.dgc_Name.MinimumWidth = 50;
            this.dgc_Name.Name = "dgc_Name";
            this.dgc_Name.ReadOnly = true;
            // 
            // dgc_Stock
            // 
            this.dgc_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Stock.DataPropertyName = "Stock";
            this.dgc_Stock.FillWeight = 20F;
            this.dgc_Stock.HeaderText = "Stock";
            this.dgc_Stock.Name = "dgc_Stock";
            this.dgc_Stock.ReadOnly = true;
            // 
            // dgc_Price
            // 
            this.dgc_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.dgc_Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgc_Price.FillWeight = 20F;
            this.dgc_Price.HeaderText = "Price";
            this.dgc_Price.Name = "dgc_Price";
            this.dgc_Price.ReadOnly = true;
            // 
            // dgc_Available
            // 
            this.dgc_Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Available.DataPropertyName = "Available";
            this.dgc_Available.FalseValue = "";
            this.dgc_Available.FillWeight = 20F;
            this.dgc_Available.HeaderText = "Available?";
            this.dgc_Available.Name = "dgc_Available";
            this.dgc_Available.ReadOnly = true;
            this.dgc_Available.TrueValue = "";
            // 
            // InventoryDataGrid
            // 
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_Selection,
            this.dgc_ItemId,
            this.dgc_Name,
            this.dgc_Stock,
            this.dgc_Price,
            this.dgc_Available,
            this.dgc_Edit,
            this.dgc_Remove});
            this.RowTemplate.Height = 28;
            this.Controls.SetChildIndex(this.chk_SelectAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ItemId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Stock;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Price;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Available;
	}
}
