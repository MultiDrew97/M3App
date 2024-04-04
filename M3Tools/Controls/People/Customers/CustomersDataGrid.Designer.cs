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
			this.bsCustomers = new Data.CustomersBindingSource();
			this.dgc_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Join = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// dgc_CustomerID
			// 
			this.dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_CustomerID.DataPropertyName = "CustomerID";
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
			this.dgc_Name.Frozen = true;
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
			// CustomersDataGrid
			// 
			this.AllowUserToAddRows = false;
			this.AllowUserToOrderColumns = true;
			this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataSource = this.bsCustomers;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.ReadOnly = true;
			this.RowTemplate.Height = 28;
			this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Size = new System.Drawing.Size(610, 500);
			this.TabIndex = 2;
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Join;
		internal Data.CustomersBindingSource bsCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
	}
}
