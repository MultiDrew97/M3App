using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Data
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class CustomerDataGrid : DataGrid<Types.Customer>
	{
		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		[DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.bsCustomers = new SPPBC.M3Tools.Data.CustomerBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataSource = typeof(SPPBC.M3Tools.Types.CustomerCollection);
            // 
            // CustomerDataGrid
            // 
            this.DataSource = this.bsCustomers;
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private CustomerBindingSource bsCustomers;
	}
}
