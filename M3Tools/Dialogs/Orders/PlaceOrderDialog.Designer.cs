using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class PlaceOrderDialog : System.Windows.Forms.Form
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.btn_AddCart = new System.Windows.Forms.Button();
            this.otc_Total = new SPPBC.M3Tools.OrderTotalCtrl();
            this.qnc_Quantity = new SPPBC.M3Tools.QuantityNudCtrl();
            this.ccb_Customers = new SPPBC.M3Tools.CustomersComboBox();
            this.pcb_Items = new SPPBC.M3Tools.InventoryComboBox();
            this.cc_Cart = new SPPBC.M3Tools.CartCtrl();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Checkout, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(37, 219);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(76, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Checkout.Location = new System.Drawing.Point(3, 3);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(67, 23);
            this.btn_Checkout.TabIndex = 0;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.Click += new System.EventHandler(this.Checkout);
            // 
            // btn_AddCart
            // 
            this.btn_AddCart.Location = new System.Drawing.Point(137, 129);
            this.btn_AddCart.Name = "btn_AddCart";
            this.btn_AddCart.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCart.TabIndex = 7;
            this.btn_AddCart.Text = "Add to Cart";
            this.btn_AddCart.UseVisualStyleBackColor = true;
            this.btn_AddCart.Click += new System.EventHandler(this.AddToCart);
            // 
            // otc_Total
            // 
            this.otc_Total.Location = new System.Drawing.Point(55, 179);
            this.otc_Total.MaximumSize = new System.Drawing.Size(115, 20);
            this.otc_Total.MinimumSize = new System.Drawing.Size(95, 20);
            this.otc_Total.Name = "otc_Total";
            this.otc_Total.Size = new System.Drawing.Size(115, 20);
            this.otc_Total.TabIndex = 8;
            this.otc_Total.Total = 0D;
            // 
            // qnc_Quantity
            // 
            this.qnc_Quantity.Location = new System.Drawing.Point(12, 119);
            this.qnc_Quantity.MaximumSize = new System.Drawing.Size(0, 42);
            this.qnc_Quantity.MinimumSize = new System.Drawing.Size(100, 42);
            this.qnc_Quantity.Name = "qnc_Quantity";
            this.qnc_Quantity.Quantity = 1;
            this.qnc_Quantity.Size = new System.Drawing.Size(100, 42);
            this.qnc_Quantity.TabIndex = 3;
            // 
            // ccb_Customers
            // 
            this.ccb_Customers.AutoSize = true;
            this.ccb_Customers.Location = new System.Drawing.Point(12, 14);
            this.ccb_Customers.MaximumSize = new System.Drawing.Size(0, 42);
            this.ccb_Customers.MinimumSize = new System.Drawing.Size(200, 42);
            this.ccb_Customers.Name = "ccb_Customers";
            this.ccb_Customers.SelectedValue = null;
            this.ccb_Customers.Size = new System.Drawing.Size(200, 42);
            this.ccb_Customers.TabIndex = 2;
            // 
            // pcb_Items
            // 
            this.pcb_Items.AutoSize = true;
            this.pcb_Items.Location = new System.Drawing.Point(12, 62);
            this.pcb_Items.MaximumSize = new System.Drawing.Size(0, 42);
            this.pcb_Items.MinimumSize = new System.Drawing.Size(200, 42);
            this.pcb_Items.Name = "pcb_Items";
            this.pcb_Items.SelectedValue = null;
            this.pcb_Items.Size = new System.Drawing.Size(200, 42);
            this.pcb_Items.TabIndex = 1;
            // 
            // cc_Cart
            // 
            this.cc_Cart.Dock = System.Windows.Forms.DockStyle.Right;
            this.cc_Cart.Location = new System.Drawing.Point(218, 0);
            this.cc_Cart.Name = "cc_Cart";
            this.cc_Cart.Size = new System.Drawing.Size(367, 260);
            this.cc_Cart.TabIndex = 9;
            // 
            // PlaceOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 260);
            this.Controls.Add(this.otc_Total);
            this.Controls.Add(this.btn_AddCart);
            this.Controls.Add(this.qnc_Quantity);
            this.Controls.Add(this.ccb_Customers);
            this.Controls.Add(this.pcb_Items);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.cc_Cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaceOrderDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlaceOrderDialog";
            this.Load += new System.EventHandler(this.Reload);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button btn_Checkout;
		internal System.Windows.Forms.Button btn_Cancel;
		internal InventoryComboBox pcb_Items;
		internal CustomersComboBox ccb_Customers;
		internal QuantityNudCtrl qnc_Quantity;
		internal System.Windows.Forms.Button btn_AddCart;
		internal OrderTotalCtrl otc_Total;
		internal CartCtrl cc_Cart;
	}
}
