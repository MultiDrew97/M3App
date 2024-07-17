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
			this.dgc_OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_CompletedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
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
			// 
			// dgc_ItemName
			// 
			this.dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_ItemName.DataPropertyName = "Item.Name";
			this.dgc_ItemName.FillWeight = 25F;
			this.dgc_ItemName.HeaderText = "Item";
			this.dgc_ItemName.MinimumWidth = 10;
			this.dgc_ItemName.Name = "dgc_ItemName";
			// 
			// dgc_OrderDate
			// 
			this.dgc_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_OrderDate.DataPropertyName = "OrderDate";
			this.dgc_OrderDate.FillWeight = 25F;
			this.dgc_OrderDate.HeaderText = "Ordered";
			this.dgc_OrderDate.MinimumWidth = 10;
			this.dgc_OrderDate.Name = "dgc_OrderDate";
			// 
			// dgc_CompletedDate
			// 
			this.dgc_CompletedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_CompletedDate.DataPropertyName = "CompletedDate";
			this.dgc_CompletedDate.FillWeight = 25F;
			this.dgc_CompletedDate.HeaderText = "Completed";
			this.dgc_CompletedDate.MinimumWidth = 10;
			this.dgc_CompletedDate.Name = "dgc_CompletedDate";
			// 
			// OrderDataGrid
			// 
			this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				dgc_Selection, dgc_OrderID,
				dgc_CustomerName, dgc_ItemName, dgc_OrderDate, dgc_CompletedDate,
				dgc_Edit, dgc_Remove
			});
			this.Name = "OrderDataGrid";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}

		#endregion
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_OrderID;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerName;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_ItemName;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_OrderDate;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_CompletedDate;
	}
}
