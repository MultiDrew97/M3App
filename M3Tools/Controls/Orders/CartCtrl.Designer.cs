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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Cart = new System.Windows.Forms.DataGridView();
            this.bsCart = new System.Windows.Forms.BindingSource(this.components);
            this.dgc_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Remove = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cart
            // 
            this.dgv_Cart.AllowUserToAddRows = false;
            this.dgv_Cart.AutoGenerateColumns = false;
            this.dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_ItemName,
            this.QuantityDataGridViewTextBoxColumn,
            this.ItemTotalDataGridViewTextBoxColumn,
            this.dgc_Remove});
            this.dgv_Cart.DataSource = this.bsCart;
            this.dgv_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cart.Location = new System.Drawing.Point(0, 0);
            this.dgv_Cart.MultiSelect = false;
            this.dgv_Cart.Name = "dgv_Cart";
            this.dgv_Cart.ReadOnly = true;
            this.dgv_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cart.Size = new System.Drawing.Size(543, 302);
            this.dgv_Cart.TabIndex = 0;
            this.dgv_Cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveItem);
            this.dgv_Cart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemValuesUpdated);
            // 
            // bsCart
            // 
            this.bsCart.DataSource = typeof(SPPBC.M3Tools.Types.CartItem);
            // 
            // dgc_ItemName
            // 
            this.dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_ItemName.DataPropertyName = "ItemName";
            this.dgc_ItemName.HeaderText = "Product";
            this.dgc_ItemName.MinimumWidth = 100;
            this.dgc_ItemName.Name = "dgc_ItemName";
            this.dgc_ItemName.ReadOnly = true;
            // 
            // QuantityDataGridViewTextBoxColumn
            // 
            this.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn";
            this.QuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.QuantityDataGridViewTextBoxColumn.Width = 71;
            // 
            // ItemTotalDataGridViewTextBoxColumn
            // 
            this.ItemTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ItemTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemTotalDataGridViewTextBoxColumn.HeaderText = "Price";
            this.ItemTotalDataGridViewTextBoxColumn.Name = "ItemTotalDataGridViewTextBoxColumn";
            this.ItemTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.ItemTotalDataGridViewTextBoxColumn.Width = 56;
            // 
            // dgc_Remove
            // 
            this.dgc_Remove.ButtonImage = null;
            this.dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dgc_Remove.HeaderText = "";
            this.dgc_Remove.Name = "dgc_Remove";
            this.dgc_Remove.ReadOnly = true;
            this.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgc_Remove.ToolTipText = "Remove";
            this.dgc_Remove.Width = 25;
            // 
            // CartCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Cart);
            this.Name = "CartCtrl";
            this.Size = new System.Drawing.Size(543, 302);
            this.Load += new System.EventHandler(this.CartLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).EndInit();
            this.ResumeLayout(false);

		}

		internal System.Windows.Forms.DataGridView dgv_Cart;
		internal System.Windows.Forms.BindingSource bsCart;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemTotalDataGridViewTextBoxColumn;
		private Data.DataGridViewImageButtonDeleteColumn dgc_Remove;
	}
}
