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
			this.dgc_ListenerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// dgc_ListenerID
			// 
			this.dgc_ListenerID.DataPropertyName = "Id";
			this.dgc_ListenerID.FillWeight = 5F;
			this.dgc_ListenerID.Frozen = true;
			this.dgc_ListenerID.HeaderText = "ListenerID";
			this.dgc_ListenerID.Name = "dgc_ListenerID";
			this.dgc_ListenerID.ReadOnly = true;
			this.dgc_ListenerID.Visible = false;
			// 
			// dgc_Email
			// 
			this.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_Email.DataPropertyName = "Email";
			this.dgc_Email.FillWeight = 50F;
			this.dgc_Email.HeaderText = "Email";
			this.dgc_Email.Name = "dgc_Email";
			// 
			// dgc_Name
			// 
			this.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_Name.DataPropertyName = "Name";
			this.dgc_Name.FillWeight = 50F;
			this.dgc_Name.HeaderText = "Name";
			this.dgc_Name.Name = "dgc_Name";
			// 
			// ListenersDataGrid
			// 
			this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dgc_Selection,
			this.dgc_ListenerID,
			this.dgc_Name,
			this.dgc_Email,
			this.dgc_Edit,
			this.dgc_Remove});
			this.RowTemplate.Height = 28;
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_ListenerID;
	}
}
