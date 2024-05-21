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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgc_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Join = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgc_CustomerID
            // 
            this.dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_CustomerID.DataPropertyName = "Id";
            this.dgc_CustomerID.FillWeight = 5F;
            this.dgc_CustomerID.Frozen = true;
            this.dgc_CustomerID.HeaderText = "CustomerID";
            this.dgc_CustomerID.MinimumWidth = 10;
            this.dgc_CustomerID.Name = "dgc_CustomerID";
            this.dgc_CustomerID.ReadOnly = true;
            this.dgc_CustomerID.Visible = false;
            // 
            // dgc_Name
            // 
            this.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgc_Name.DataPropertyName = "Name";
            this.dgc_Name.FillWeight = 25F;
            this.dgc_Name.HeaderText = "Name";
            this.dgc_Name.MinimumWidth = 10;
            this.dgc_Name.Name = "dgc_Name";
            this.dgc_Name.ReadOnly = true;
            // 
            // dgc_Address
            // 
            this.dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Address.DataPropertyName = "Address";
            this.dgc_Address.FillWeight = 25F;
            this.dgc_Address.HeaderText = "Address";
            this.dgc_Address.MinimumWidth = 10;
            this.dgc_Address.Name = "dgc_Address";
            this.dgc_Address.ReadOnly = true;
            // 
            // dgc_Phone
            // 
            this.dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Phone.DataPropertyName = "Phone";
            this.dgc_Phone.FillWeight = 25F;
            this.dgc_Phone.HeaderText = "Phone";
            this.dgc_Phone.MinimumWidth = 10;
            this.dgc_Phone.Name = "dgc_Phone";
            this.dgc_Phone.ReadOnly = true;
            // 
            // dgc_Email
            // 
            this.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgc_Email.DataPropertyName = "Email";
            this.dgc_Email.FillWeight = 25F;
            this.dgc_Email.HeaderText = "Email";
            this.dgc_Email.MinimumWidth = 10;
            this.dgc_Email.Name = "dgc_Email";
            this.dgc_Email.ReadOnly = true;
            // 
            // dgc_Join
            // 
            this.dgc_Join.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgc_Join.DataPropertyName = "Joined";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgc_Join.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgc_Join.HeaderText = "Joined";
            this.dgc_Join.MinimumWidth = 10;
            this.dgc_Join.Name = "dgc_Join";
            this.dgc_Join.ReadOnly = true;
            // 
            // CustomerDataGrid
            // 
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_Selection,
            this.dgc_CustomerID,
            this.dgc_Name,
            this.dgc_Address,
            this.dgc_Phone,
            this.dgc_Email,
            this.dgc_Join,
            this.dgc_Edit,
            this.dgc_Remove});
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadOnly = true;
            this.RowTemplate.Height = 28;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Join;
	}
}
