using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btn_Checkout = new System.Windows.Forms.Button();
            btn_Checkout.Click += new EventHandler(Checkout);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            btn_AddCart = new System.Windows.Forms.Button();
            btn_AddCart.Click += new EventHandler(AddToCart);
            bw_PlaceOrders = new System.ComponentModel.BackgroundWorker();
            bw_PlaceOrders.DoWork += new System.ComponentModel.DoWorkEventHandler(PlaceOrders);
            bw_PlaceOrders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(OrdersPlaced);
            otc_Total = new OrderTotalCtrl();
            qnc_Quantity = new QuantityNudCtrl();
            ccb_Customers = new CustomersComboBox();
            pcb_Items = new ProductsComboBox();
            cc_Cart = new CartCtrl();
            cc_Cart.ItemAdded += new CartCtrl.ItemAddedEventHandler(ItemAdded);
            db_Orders = new Database.OrdersDatabase(components);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Cancel, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Checkout, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(37, 219);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            btn_Checkout.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Checkout.Location = new System.Drawing.Point(3, 3);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new System.Drawing.Size(67, 23);
            btn_Checkout.TabIndex = 0;
            btn_Checkout.Text = "Checkout";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.Location = new System.Drawing.Point(76, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // btn_AddCart
            // 
            btn_AddCart.Location = new System.Drawing.Point(137, 129);
            btn_AddCart.Name = "btn_AddCart";
            btn_AddCart.Size = new System.Drawing.Size(75, 23);
            btn_AddCart.TabIndex = 7;
            btn_AddCart.Text = "Add to Cart";
            btn_AddCart.UseVisualStyleBackColor = true;
            // 
            // bw_PlaceOrders
            // 
            // 
            // otc_Total
            // 
            otc_Total.Location = new System.Drawing.Point(55, 179);
            otc_Total.MaximumSize = new System.Drawing.Size(115, 20);
            otc_Total.MinimumSize = new System.Drawing.Size(95, 20);
            otc_Total.Name = "otc_Total";
            otc_Total.Size = new System.Drawing.Size(115, 20);
            otc_Total.TabIndex = 8;
            otc_Total.Total = 0d;
            // 
            // qnc_Quantity
            // 
            qnc_Quantity.Location = new System.Drawing.Point(12, 119);
            qnc_Quantity.MaximumSize = new System.Drawing.Size(0, 42);
            qnc_Quantity.MinimumSize = new System.Drawing.Size(100, 42);
            qnc_Quantity.Name = "qnc_Quantity";
            qnc_Quantity.Quantity = 1;
            qnc_Quantity.Size = new System.Drawing.Size(100, 42);
            qnc_Quantity.TabIndex = 3;
            // 
            // ccb_Customers
            // 
            ccb_Customers.AutoSize = true;
            ccb_Customers.Location = new System.Drawing.Point(12, 14);
            ccb_Customers.MaximumSize = new System.Drawing.Size(0, 42);
            ccb_Customers.MinimumSize = new System.Drawing.Size(200, 42);
            ccb_Customers.Name = "ccb_Customers";
            ccb_Customers.SelectedIndex = -1;
            ccb_Customers.SelectedItem = null;
            ccb_Customers.SelectedValue = null;
            ccb_Customers.Size = new System.Drawing.Size(200, 42);
            ccb_Customers.TabIndex = 2;
            // 
            // pcb_Items
            // 
            pcb_Items.AutoSize = true;
            pcb_Items.Location = new System.Drawing.Point(12, 62);
            pcb_Items.MaximumSize = new System.Drawing.Size(0, 42);
            pcb_Items.MinimumSize = new System.Drawing.Size(200, 42);
            pcb_Items.Name = "pcb_Items";
            pcb_Items.SelectedIndex = -1;
            pcb_Items.SelectedItem = null;
            pcb_Items.SelectedValue = null;
            pcb_Items.Size = new System.Drawing.Size(200, 42);
            pcb_Items.TabIndex = 1;
            // 
            // cc_Cart
            // 
            cc_Cart.Dock = System.Windows.Forms.DockStyle.Right;
            cc_Cart.Location = new System.Drawing.Point(218, 0);
            cc_Cart.Name = "cc_Cart";
            cc_Cart.Size = new System.Drawing.Size(367, 260);
            cc_Cart.TabIndex = 9;
            // 
            // db_Orders
            // 
            db_Orders.BaseUrl = "Media Ministry Test";
            db_Orders.Password = "M3AppPassword2499";
            db_Orders.Username = "M3App";
            // 
            // PlaceOrderDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(585, 260);
            Controls.Add(otc_Total);
            Controls.Add(btn_AddCart);
            Controls.Add(qnc_Quantity);
            Controls.Add(ccb_Customers);
            Controls.Add(pcb_Items);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(cc_Cart);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaceOrderDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PlaceOrderDialog";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(DialogLoading);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Checkout;
        internal System.Windows.Forms.Button btn_Cancel;
        internal ProductsComboBox pcb_Items;
        internal CustomersComboBox ccb_Customers;
        internal QuantityNudCtrl qnc_Quantity;
        internal System.Windows.Forms.Button btn_AddCart;
        internal System.ComponentModel.BackgroundWorker bw_PlaceOrders;
        internal OrderTotalCtrl otc_Total;
        internal CartCtrl cc_Cart;
        internal Database.OrdersDatabase db_Orders;
    }
}