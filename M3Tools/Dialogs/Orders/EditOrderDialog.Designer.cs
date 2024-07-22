using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class EditOrderDialog : System.Windows.Forms.Form
	{

		// Form overrides dispose to clean up the component list.
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.qnc_Quantity = new SPPBC.M3Tools.QuantityNudCtrl();
            this.icbx_Inventory = new SPPBC.M3Tools.InventoryComboBox();
            this.ccbx_Customers = new SPPBC.M3Tools.CustomersComboBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(199, 187);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(76, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.Finished);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(3, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel);
            // 
            // qnc_Quantity
            // 
            this.qnc_Quantity.Location = new System.Drawing.Point(128, 125);
            this.qnc_Quantity.MaximumSize = new System.Drawing.Size(0, 42);
            this.qnc_Quantity.MinimumSize = new System.Drawing.Size(100, 42);
            this.qnc_Quantity.Name = "qnc_Quantity";
            this.qnc_Quantity.Size = new System.Drawing.Size(100, 42);
            this.qnc_Quantity.TabIndex = 4;
            // 
            // icbx_Inventory
            // 
            this.icbx_Inventory.AutoSize = true;
            this.icbx_Inventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.icbx_Inventory.Location = new System.Drawing.Point(78, 77);
            this.icbx_Inventory.MaximumSize = new System.Drawing.Size(0, 42);
            this.icbx_Inventory.MinimumSize = new System.Drawing.Size(200, 42);
            this.icbx_Inventory.Name = "icbx_Inventory";
            this.icbx_Inventory.SelectedValue = null;
            this.icbx_Inventory.Size = new System.Drawing.Size(200, 42);
            this.icbx_Inventory.TabIndex = 3;
            // 
            // ccbx_Customers
            // 
            this.ccbx_Customers.AutoSize = true;
            this.ccbx_Customers.Location = new System.Drawing.Point(78, 12);
            this.ccbx_Customers.MaximumSize = new System.Drawing.Size(0, 42);
            this.ccbx_Customers.MinimumSize = new System.Drawing.Size(200, 42);
            this.ccbx_Customers.Name = "ccbx_Customers";
            this.ccbx_Customers.SelectedValue = null;
            this.ccbx_Customers.Size = new System.Drawing.Size(200, 42);
            this.ccbx_Customers.TabIndex = 6;
            // 
            // EditOrderDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(357, 228);
            this.Controls.Add(this.ccbx_Customers);
            this.Controls.Add(this.qnc_Quantity);
            this.Controls.Add(this.icbx_Inventory);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditOrderDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Order";
            this.Load += new System.EventHandler(this.DialogLoading);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal SPPBC.M3Tools.InventoryComboBox icbx_Inventory;
		internal SPPBC.M3Tools.QuantityNudCtrl qnc_Quantity;
		private SPPBC.M3Tools.CustomersComboBox ccbx_Customers;
	}
}
