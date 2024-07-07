using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class CartCtrl : System.Windows.Forms.UserControl
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
			dgv_Cart = new System.Windows.Forms.DataGridView();
			dgv_Cart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(ItemValuesUpdated);
			dgv_Cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(RemoveItem);
			bsCart = new System.Windows.Forms.BindingSource(components);
			dgc_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			QuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ItemTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Remove = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)dgv_Cart).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsCart).BeginInit();
			SuspendLayout();
			// 
			// dgv_Cart
			// 
			dgv_Cart.AllowUserToAddRows = false;
			dgv_Cart.AutoGenerateColumns = false;
			dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_ItemName, QuantityDataGridViewTextBoxColumn, ItemTotalDataGridViewTextBoxColumn, dgc_Remove });
			dgv_Cart.DataSource = bsCart;
			dgv_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_Cart.Location = new System.Drawing.Point(0, 0);
			dgv_Cart.MultiSelect = false;
			dgv_Cart.Name = "dgv_Cart";
			dgv_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			dgv_Cart.Size = new System.Drawing.Size(543, 302);
			dgv_Cart.TabIndex = 0;
			// 
			// bsCart
			// 
			bsCart.DataSource = typeof(Types.CartItem);
			// 
			// dgc_ItemName
			// 
			dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_ItemName.DataPropertyName = "ItemName";
			dgc_ItemName.HeaderText = "Product";
			dgc_ItemName.MinimumWidth = 100;
			dgc_ItemName.Name = "dgc_ItemName";
			dgc_ItemName.ReadOnly = true;
			// 
			// QuantityDataGridViewTextBoxColumn
			// 
			QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1;
			QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn";
			QuantityDataGridViewTextBoxColumn.Width = 71;
			// 
			// ItemTotalDataGridViewTextBoxColumn
			// 
			ItemTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			ItemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal";
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.Format = "C2";
			DataGridViewCellStyle2.NullValue = null;
			ItemTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2;
			ItemTotalDataGridViewTextBoxColumn.HeaderText = "Price";
			ItemTotalDataGridViewTextBoxColumn.Name = "ItemTotalDataGridViewTextBoxColumn";
			ItemTotalDataGridViewTextBoxColumn.ReadOnly = true;
			ItemTotalDataGridViewTextBoxColumn.Width = 56;
			// 
			// dgc_Remove
			// 
			dgc_Remove.HeaderText = "";
			dgc_Remove.Image = My.Resources.Resources.delete;
			dgc_Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			dgc_Remove.Name = "dgc_Remove";
			dgc_Remove.ReadOnly = true;
			dgc_Remove.Width = 25;
			// 
			// CartCtrl
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(dgv_Cart);
			Name = "CartCtrl";
			Size = new System.Drawing.Size(543, 302);
			((System.ComponentModel.ISupportInitialize)dgv_Cart).EndInit();
			((System.ComponentModel.ISupportInitialize)bsCart).EndInit();
			Load += new EventHandler(CartLoaded);
			ItemAdded += new ItemAddedEventHandler(Reload);
			ItemUpdated += new ItemUpdatedEventHandler(Temp);
			ResumeLayout(false);

		}

		internal System.Windows.Forms.DataGridView dgv_Cart;
		internal System.Windows.Forms.BindingSource bsCart;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_ItemName;
		internal System.Windows.Forms.DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
		internal System.Windows.Forms.DataGridViewTextBoxColumn ItemTotalDataGridViewTextBoxColumn;
		internal System.Windows.Forms.DataGridViewImageColumn dgc_Remove;
	}
}
