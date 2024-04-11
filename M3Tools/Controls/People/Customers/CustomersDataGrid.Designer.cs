using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Data
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class CustomerDataGrid : DataGrid<Types.Customer>
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataGrid
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToOrderColumns = true;
            this.AutoGenerateColumns = false;
            this.CanAdd = false;
            this.CanReorder = true;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadOnly = true;
            this.RowTemplate.Height = 28;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(610, 500);
            this.TabIndex = 2;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
