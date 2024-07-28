namespace SPPBC.M3Tools.Data
{
	public partial class OrderDataGrid : DataGrid<Types.Order>
	{

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
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal OrderBindingSource bsOrders;
	}
}
