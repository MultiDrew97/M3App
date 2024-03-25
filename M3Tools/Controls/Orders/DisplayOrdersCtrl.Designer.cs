using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DisplayOrdersCtrl : System.Windows.Forms.UserControl
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
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            bsOrders = new System.Windows.Forms.BindingSource(components);
            bw_LoadOrders = new System.ComponentModel.BackgroundWorker();
            bw_LoadOrders.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadOrders);
            bw_LoadOrders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(OrdersLoaded);
            cms_Tools = new System.Windows.Forms.ContextMenuStrip(components);
            ts_ShowCompleted = new System.Windows.Forms.ToolStripMenuItem();
            ts_ShowCompleted.Click += new EventHandler(ShowCompletedOrdersToolStripMenuItem_Click);
            ts_Seperator = new System.Windows.Forms.ToolStripSeparator();
            ts_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            ts_Refresh.Click += new EventHandler(Reload);
            ts_Remove = new System.Windows.Forms.ToolStripMenuItem();
            ts_Remove.Click += new EventHandler(RemoveRowByToolStrip);
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            dgv_Orders = new System.Windows.Forms.DataGridView();
            dgv_Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(CellClicked);
            dgv_Orders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(UserDeletingRow);
            ToolStrip1 = new System.Windows.Forms.ToolStrip();
            tbtn_PlaceOrder = new System.Windows.Forms.ToolStripButton();
            tbtn_PlaceOrder.Click += new EventHandler(PlaceOrder);
            OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompletedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btn_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            btn_Complete = new System.Windows.Forms.DataGridViewImageColumn();
            btn_Cancel = new System.Windows.Forms.DataGridViewImageColumn();
            db_Orders = new Database.OrdersDatabase(components);
            ((System.ComponentModel.ISupportInitialize)bsOrders).BeginInit();
            cms_Tools.SuspendLayout();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Orders).BeginInit();
            ToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bsOrders
            // 
            bsOrders.Filter = "";
            // 
            // bw_LoadOrders
            // 
            // 
            // cms_Tools
            // 
            cms_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            cms_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ts_ShowCompleted, ts_Seperator, ts_Refresh, ts_Remove });
            cms_Tools.Name = "cms_Tools";
            cms_Tools.Size = new System.Drawing.Size(204, 76);
            cms_Tools.Text = "Tools";
            // 
            // ts_ShowCompleted
            // 
            ts_ShowCompleted.CheckOnClick = true;
            ts_ShowCompleted.Name = "ts_ShowCompleted";
            ts_ShowCompleted.Size = new System.Drawing.Size(203, 22);
            ts_ShowCompleted.Text = "Show Completed Orders";
            // 
            // ts_Seperator
            // 
            ts_Seperator.Name = "ts_Seperator";
            ts_Seperator.Size = new System.Drawing.Size(200, 6);
            // 
            // ts_Refresh
            // 
            ts_Refresh.Name = "ts_Refresh";
            ts_Refresh.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R;
            ts_Refresh.Size = new System.Drawing.Size(203, 22);
            ts_Refresh.Text = "Refresh";
            // 
            // ts_Remove
            // 
            ts_Remove.Name = "ts_Remove";
            ts_Remove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            ts_Remove.Size = new System.Drawing.Size(203, 22);
            ts_Remove.Text = "Remove";
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(dgv_Orders);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 403);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.Size = new System.Drawing.Size(800, 442);
            ToolStripContainer1.TabIndex = 1;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip1);
            // 
            // dgv_Orders
            // 
            dgv_Orders.AllowUserToAddRows = false;
            dgv_Orders.AllowUserToOrderColumns = true;
            dgv_Orders.AutoGenerateColumns = false;
            dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_Orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderID, Customer, Product, OrderQuantity, Total, OrderDate, CompletedDate, btn_Edit, btn_Complete, btn_Cancel });
            dgv_Orders.DataSource = bsOrders;
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_Orders.DefaultCellStyle = DataGridViewCellStyle5;
            dgv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Orders.Location = new System.Drawing.Point(0, 0);
            dgv_Orders.MinimumSize = new System.Drawing.Size(800, 400);
            dgv_Orders.Name = "dgv_Orders";
            dgv_Orders.ReadOnly = true;
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_Orders.RowHeadersDefaultCellStyle = DataGridViewCellStyle6;
            dgv_Orders.RowHeadersWidth = 82;
            dgv_Orders.Size = new System.Drawing.Size(800, 403);
            dgv_Orders.TabIndex = 3;
            // 
            // ToolStrip1
            // 
            ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbtn_PlaceOrder });
            ToolStrip1.Location = new System.Drawing.Point(3, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new System.Drawing.Size(48, 39);
            ToolStrip1.TabIndex = 0;
            // 
            // tbtn_PlaceOrder
            // 
            tbtn_PlaceOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_PlaceOrder.Image = My.Resources.Resources.NewDocumentOption;
            tbtn_PlaceOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_PlaceOrder.Name = "tbtn_PlaceOrder";
            tbtn_PlaceOrder.Size = new System.Drawing.Size(36, 36);
            tbtn_PlaceOrder.Text = "Place Order";
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "Order Number";
            OrderID.MinimumWidth = 10;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Visible = false;
            // 
            // Customer
            // 
            Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Customer.DataPropertyName = "CustomerName";
            Customer.HeaderText = "Buyer";
            Customer.MinimumWidth = 100;
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.Width = 200;
            // 
            // Product
            // 
            Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Product.DataPropertyName = "ItemName";
            Product.HeaderText = "Product";
            Product.MinimumWidth = 200;
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            OrderQuantity.DataPropertyName = "Quantity";
            OrderQuantity.HeaderText = "Quantity";
            OrderQuantity.MinimumWidth = 100;
            OrderQuantity.Name = "OrderQuantity";
            OrderQuantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "OrderTotal";
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle2.Format = "C2";
            DataGridViewCellStyle2.NullValue = "N/A";
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            Total.DefaultCellStyle = DataGridViewCellStyle2;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 100;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrderDate.DataPropertyName = "OrderDate";
            DataGridViewCellStyle3.Format = "d";
            DataGridViewCellStyle3.NullValue = null;
            OrderDate.DefaultCellStyle = DataGridViewCellStyle3;
            OrderDate.HeaderText = "Date Placed";
            OrderDate.MinimumWidth = 100;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // CompletedDate
            // 
            CompletedDate.DataPropertyName = "CompletedDate";
            DataGridViewCellStyle4.Format = "d";
            DataGridViewCellStyle4.NullValue = "N/A";
            CompletedDate.DefaultCellStyle = DataGridViewCellStyle4;
            CompletedDate.HeaderText = "Date Completed";
            CompletedDate.MinimumWidth = 100;
            CompletedDate.Name = "CompletedDate";
            CompletedDate.ReadOnly = true;
            // 
            // btn_Edit
            // 
            btn_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            btn_Edit.Description = "Edit the order of this row";
            btn_Edit.HeaderText = "";
            btn_Edit.Image = My.Resources.Resources.edit;
            btn_Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            btn_Edit.MinimumWidth = 25;
            btn_Edit.Name = "btn_Edit";
            btn_Edit.ReadOnly = true;
            btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            btn_Edit.ToolTipText = "Edit Order";
            btn_Edit.Width = 25;
            // 
            // btn_Complete
            // 
            btn_Complete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            btn_Complete.Description = "Fulfil the order of this row";
            btn_Complete.HeaderText = "";
            btn_Complete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            btn_Complete.MinimumWidth = 25;
            btn_Complete.Name = "btn_Complete";
            btn_Complete.ReadOnly = true;
            btn_Complete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            btn_Complete.ToolTipText = "Fulfil Order";
            btn_Complete.Width = 25;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            btn_Cancel.Description = "Cancel the order of this row";
            btn_Cancel.HeaderText = "";
            btn_Cancel.Image = My.Resources.Resources.delete;
            btn_Cancel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            btn_Cancel.MinimumWidth = 25;
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.ReadOnly = true;
            btn_Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            btn_Cancel.ToolTipText = "Cancel Order";
            btn_Cancel.Width = 25;
            // 
            // db_Orders
            // 
            db_Orders.BaseUrl = "Media Ministry Test";
            db_Orders.Password = "M3AppPassword2499";
            db_Orders.Username = "M3App";
            // 
            // DisplayOrdersCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ContextMenuStrip = cms_Tools;
            Controls.Add(ToolStripContainer1);
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(800, 442);
            Name = "DisplayOrdersCtrl";
            Size = new System.Drawing.Size(800, 442);
            ((System.ComponentModel.ISupportInitialize)bsOrders).EndInit();
            cms_Tools.ResumeLayout(false);
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Orders).EndInit();
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ShowCompletedChanged += new ShowCompletedChangedEventHandler(ToggleCompleted);
            Load += new EventHandler(ControlLoaded);
            ResumeLayout(false);

        }
        internal Database.OrdersDatabase db_Orders;
        internal System.Windows.Forms.BindingSource bsOrders;
        internal System.ComponentModel.BackgroundWorker bw_LoadOrders;
        internal System.Windows.Forms.ContextMenuStrip cms_Tools;
        internal System.Windows.Forms.ToolStripMenuItem ts_Refresh;
        internal System.Windows.Forms.ToolStripMenuItem ts_Remove;
        internal System.Windows.Forms.ToolStripMenuItem ts_ShowCompleted;
        internal System.Windows.Forms.ToolStripSeparator ts_Seperator;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.DataGridView dgv_Orders;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tbtn_PlaceOrder;
        internal System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Product;
        internal System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Total;
        internal System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CompletedDate;
        internal System.Windows.Forms.DataGridViewImageColumn btn_Edit;
        internal System.Windows.Forms.DataGridViewImageColumn btn_Complete;
        internal System.Windows.Forms.DataGridViewImageColumn btn_Cancel;
    }
}