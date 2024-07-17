namespace SPPBC.M3Tools.Data
{
	partial class OrderDataGrid : DataGrid<Types.Order>
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgc_OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_CompletedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrders = new SPPBC.M3Tools.Data.OrderBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgc_Selection
            // 
            this.dgc_Selection.ReadOnly = true;
            // 
            // dgc_OrderID
            // 
            this.dgc_OrderID.DataPropertyName = "Id";
            this.dgc_OrderID.HeaderText = "CustomerID";
            this.dgc_OrderID.Name = "dgc_OrderID";
            this.dgc_OrderID.ReadOnly = true;
            this.dgc_OrderID.Visible = false;
            // 
            // dgc_CustomerName
            // 
            this.dgc_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgc_CustomerName.DataPropertyName = "Customer.Name";
            this.dgc_CustomerName.FillWeight = 25F;
            this.dgc_CustomerName.HeaderText = "Customer";
            this.dgc_CustomerName.MinimumWidth = 10;
            this.dgc_CustomerName.Name = "dgc_CustomerName";
            this.dgc_CustomerName.ReadOnly = true;
            // 
            // dgc_ItemName
            // 
            this.dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_ItemName.DataPropertyName = "Item.Id";
            this.dgc_ItemName.FillWeight = 25F;
            this.dgc_ItemName.HeaderText = "Item";
            this.dgc_ItemName.MinimumWidth = 10;
            this.dgc_ItemName.Name = "dgc_ItemName";
            this.dgc_ItemName.ReadOnly = true;
            // 
            // dgc_OrderTotal
            // 
            this.dgc_OrderTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_OrderTotal.DataPropertyName = "Total";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.dgc_OrderTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgc_OrderTotal.FillWeight = 25F;
            this.dgc_OrderTotal.HeaderText = "Total";
            this.dgc_OrderTotal.MinimumWidth = 50;
            this.dgc_OrderTotal.Name = "dgc_OrderTotal";
            this.dgc_OrderTotal.ReadOnly = true;
            // 
            // dgc_OrderDate
            // 
            this.dgc_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "N/A";
            this.dgc_OrderDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgc_OrderDate.FillWeight = 25F;
            this.dgc_OrderDate.HeaderText = "Ordered";
            this.dgc_OrderDate.MinimumWidth = 10;
            this.dgc_OrderDate.Name = "dgc_OrderDate";
            this.dgc_OrderDate.ReadOnly = true;
            // 
            // dgc_CompletedDate
            // 
            this.dgc_CompletedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_CompletedDate.DataPropertyName = "CompletedDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "N/A";
            this.dgc_CompletedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgc_CompletedDate.FillWeight = 25F;
            this.dgc_CompletedDate.HeaderText = "Completed";
            this.dgc_CompletedDate.MinimumWidth = 10;
            this.dgc_CompletedDate.Name = "dgc_CompletedDate";
            this.dgc_CompletedDate.ReadOnly = true;
            // 
            // OrderDataGrid
            // 
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_Selection,
            this.dgc_OrderID,
            this.dgc_CustomerName,
            this.dgc_ItemName,
            this.dgc_OrderTotal,
            this.dgc_OrderDate,
            this.dgc_CompletedDate,
            this.dgc_Edit,
            this.dgc_Remove});
            this.RowTemplate.Height = 28;
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_OrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_OrderTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_OrderDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_CompletedDate;
		private OrderBindingSource bsOrders;
	}
}
