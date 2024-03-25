using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PlaceOrderDialog : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderDialog));
            cbx_ItemName = new ComboBox();
            bsProducts = new BindingSource(components);
            lbl_ItemName = new Label();
            ss_AddOrder = new StatusStrip();
            tss_AddOrder = new ToolStripStatusLabel();
            cbx_Name = new ComboBox();
            bsCustomers = new BindingSource(components);
            lbl_Name = new Label();
            nud_Quantity = new NumericUpDown();
            lbl_Quantity = new Label();
            btn_AddOrder = new Button();
            btn_AddOrder.Click += new EventHandler(Btn_AddOrder_Click);
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            bw_LoadingData = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bsProducts).BeginInit();
            ss_AddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            SuspendLayout();
            // 
            // cbx_ItemName
            // 
            cbx_ItemName.DataSource = bsProducts;
            cbx_ItemName.Font = new Font("Microsoft Sans Serif", 16.0f);
            cbx_ItemName.FormattingEnabled = true;
            cbx_ItemName.Location = new Point(43, 158);
            cbx_ItemName.Name = "cbx_ItemName";
            cbx_ItemName.Size = new Size(323, 33);
            cbx_ItemName.TabIndex = 5;
            // 
            // bsProducts
            // 
            bsProducts.Filter = "Available=True";
            // 
            // lbl_ItemName
            // 
            lbl_ItemName.AutoSize = true;
            lbl_ItemName.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_ItemName.Location = new Point(40, 140);
            lbl_ItemName.Name = "lbl_ItemName";
            lbl_ItemName.Size = new Size(49, 15);
            lbl_ItemName.TabIndex = 4;
            lbl_ItemName.Text = "Product";
            // 
            // ss_AddOrder
            // 
            ss_AddOrder.Items.AddRange(new ToolStripItem[] { tss_AddOrder });
            ss_AddOrder.Location = new Point(0, 306);
            ss_AddOrder.Name = "ss_AddOrder";
            ss_AddOrder.Size = new Size(503, 22);
            ss_AddOrder.TabIndex = 10;
            // 
            // tss_AddOrder
            // 
            tss_AddOrder.Name = "tss_AddOrder";
            tss_AddOrder.Size = new Size(187, 17);
            tss_AddOrder.Text = "Add the information for the order.";
            // 
            // cbx_Name
            // 
            cbx_Name.DataSource = bsCustomers;
            cbx_Name.Font = new Font("Microsoft Sans Serif", 16.0f);
            cbx_Name.FormattingEnabled = true;
            cbx_Name.Location = new Point(102, 71);
            cbx_Name.Name = "cbx_Name";
            cbx_Name.Size = new Size(302, 33);
            cbx_Name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_Name.Location = new Point(99, 54);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(41, 15);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Name";
            // 
            // nud_Quantity
            // 
            nud_Quantity.Font = new Font("Microsoft Sans Serif", 16.0f);
            nud_Quantity.Location = new Point(414, 159);
            nud_Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new Size(48, 32);
            nud_Quantity.TabIndex = 7;
            nud_Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_Quantity.Location = new Point(411, 141);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(51, 15);
            lbl_Quantity.TabIndex = 6;
            lbl_Quantity.Text = "Quantity";
            // 
            // btn_AddOrder
            // 
            btn_AddOrder.AutoSize = true;
            btn_AddOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_AddOrder.DialogResult = DialogResult.Cancel;
            btn_AddOrder.Font = new Font("Microsoft Sans Serif", 16.0f);
            btn_AddOrder.Location = new Point(284, 239);
            btn_AddOrder.Name = "btn_AddOrder";
            btn_AddOrder.Size = new Size(122, 36);
            btn_AddOrder.TabIndex = 8;
            btn_AddOrder.Text = "Add Order";
            btn_AddOrder.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = new Font("Microsoft Sans Serif", 16.0f);
            btn_Cancel.Location = new Point(96, 239);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(90, 36);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // PlaceOrderDialog
            // 
            AcceptButton = btn_AddOrder;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(503, 328);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_AddOrder);
            Controls.Add(lbl_Quantity);
            Controls.Add(nud_Quantity);
            Controls.Add(ss_AddOrder);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_ItemName);
            Controls.Add(cbx_Name);
            Controls.Add(cbx_ItemName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PlaceOrderDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ((System.ComponentModel.ISupportInitialize)bsProducts).EndInit();
            ss_AddOrder.ResumeLayout(false);
            ss_AddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).EndInit();
            Load += new EventHandler(Frm_PlaceOrder_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal ComboBox cbx_ItemName;
        internal Label lbl_ItemName;
        internal StatusStrip ss_AddOrder;
        internal ToolStripStatusLabel tss_AddOrder;
        internal ComboBox cbx_Name;
        internal Label lbl_Name;
        internal NumericUpDown nud_Quantity;
        internal Label lbl_Quantity;
        internal Button btn_AddOrder;
        internal Button btn_Cancel;
        internal System.ComponentModel.BackgroundWorker bw_LoadingData;
        internal BindingSource bsProducts;
        internal BindingSource bsCustomers;
    }
}