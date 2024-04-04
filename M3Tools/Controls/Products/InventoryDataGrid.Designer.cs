using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class InventoryDataGrid : Data.DataGrid<Types.Product>
	{

		// UserControl overrides dispose to clean up the component list.
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
			var DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			var DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			dgc_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			dgc_Edit = new DataGridViewImageButtonEditColumn();
			dgc_Remove = new DataGridViewImageButtonDeleteColumn();
			bsInventory = new System.Windows.Forms.BindingSource(components);
			cms_Tools = new ToolsContextMenu();
			((System.ComponentModel.ISupportInitialize)bsInventory).BeginInit();
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
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dgc_Stock.DefaultCellStyle = DataGridViewCellStyle1;
			dgc_Stock.FillWeight = 20.0f;
			dgc_Stock.HeaderText = "Stock";
			dgc_Stock.Name = "dgc_Stock";
			// 
			// dgc_Price
			// 
			dgc_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Price.DataPropertyName = "Price";
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.Format = "C2";
			DataGridViewCellStyle2.NullValue = "0";
			dgc_Price.DefaultCellStyle = DataGridViewCellStyle2;
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
			// dgc_Edit
			// 
			dgc_Edit.ButtonImage = null;
			dgc_Edit.FillWeight = 5.0f;
			dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			dgc_Edit.HeaderText = "";
			dgc_Edit.MinimumWidth = 25;
			dgc_Edit.Name = "dgc_Edit";
			dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			dgc_Edit.Width = 25;
			// 
			// dgc_Remove
			// 
			dgc_Remove.ButtonImage = null;
			dgc_Remove.FillWeight = 5.0f;
			dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			dgc_Remove.HeaderText = "";
			dgc_Remove.MinimumWidth = 25;
			dgc_Remove.Name = "dgc_Remove";
			dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			dgc_Remove.Width = 25;
			// 
			// chk_SelectAll
			// 
			chk_SelectAll.AutoSize = true;
			chk_SelectAll.Location = new System.Drawing.Point(46, 3);
			chk_SelectAll.Name = "chk_SelectAll";
			chk_SelectAll.Size = new System.Drawing.Size(15, 14);
			chk_SelectAll.TabIndex = 4;
			chk_SelectAll.TabStop = false;
			chk_SelectAll.UseVisualStyleBackColor = true;
			// 
			// InventoryDataGrid
			//
			Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_Id, dgc_Name, dgc_Stock, dgc_Price, dgc_Available, dgc_Edit, dgc_Remove });
			MinimumSize = new System.Drawing.Size(500, 400);
			Name = "InventoryDataGrid";
			Size = new System.Drawing.Size(500, 400);
			((System.ComponentModel.ISupportInitialize)bsInventory).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		internal System.Windows.Forms.BindingSource bsInventory;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Id;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Stock;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Price;
		internal System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Available;
	}
}
