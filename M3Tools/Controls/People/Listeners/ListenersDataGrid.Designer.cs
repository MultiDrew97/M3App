using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Data
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class ListenersDataGrid : DataGrid<Types.Listener>
	{
		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		[DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.bsListeners = new SPPBC.M3Tools.Data.ListenerBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ListenersDataGrid
            // 
            this.DataSource = this.bsListeners;
            this.RowTemplate.Height = 28;
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private ListenerBindingSource bsListeners;
	}
}
