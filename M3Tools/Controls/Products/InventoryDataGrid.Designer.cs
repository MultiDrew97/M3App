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
            this.bsInventory = new SPPBC.M3Tools.Data.InventoryBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInventory
            // 
            this.bsInventory.DataSource = typeof(SPPBC.M3Tools.Types.InventoryCollection);
            // 
            // InventoryDataGrid
            // 
            this.DataSource = this.bsInventory;
            this.RowTemplate.Height = 28;
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private InventoryBindingSource bsInventory;
	}
}
