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
            this.bsOrders = new SPPBC.M3Tools.Data.OrderBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bsOrders
            // 
            this.bsOrders.DataSource = typeof(SPPBC.M3Tools.Types.OrderCollection);
            // 
            // OrderDataGrid
            // 
            this.DataSource = this.bsOrders;
            this.RowTemplate.Height = 28;
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		internal OrderBindingSource bsOrders;
	}
}
