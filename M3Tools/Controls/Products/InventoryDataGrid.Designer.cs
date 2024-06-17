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
			dgc_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			SuspendLayout();
			// 
			// dgc_Id
			// 
			dgc_Id.DataPropertyName = "Id";
			dgc_Id.HeaderText = "ItemID";
			dgc_Id.Name = "dgc_Id";
			dgc_Id.ReadOnly = true;
			dgc_Id.Visible = false;
			// 
			// dgc_Name
			// 
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 40.0f;
			dgc_Name.HeaderText = "Name";
			dgc_Name.MinimumWidth = 50;
			dgc_Name.Name = "dgc_Name";
			// 
			// dgc_Stock
			// 
			dgc_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Stock.DataPropertyName = "Stock";
			dgc_Stock.FillWeight = 20.0f;
			dgc_Stock.HeaderText = "Stock";
			dgc_Stock.Name = "dgc_Stock";
			// 
			// dgc_Price
			// 
			dgc_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Price.DataPropertyName = "Price";
			dgc_Price.FillWeight = 20.0f;
			dgc_Price.HeaderText = "Price";
			dgc_Price.Name = "dgc_Price";
			// 
			// dgc_Available
			// 
			dgc_Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Available.DataPropertyName = "Available";
			dgc_Available.FalseValue = "";
			dgc_Available.FillWeight = 20.0f;
			dgc_Available.HeaderText = "Available?";
			dgc_Available.Name = "dgc_Available";
			dgc_Available.TrueValue = "";
			// 
			// InventoryDataGrid
			//
			Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_Selection, dgc_Id, dgc_Name, dgc_Stock, dgc_Price, dgc_Available, dgc_Edit, dgc_Remove });
			Name = "InventoryDataGrid";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Stock;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Price;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Available;
	}
}
