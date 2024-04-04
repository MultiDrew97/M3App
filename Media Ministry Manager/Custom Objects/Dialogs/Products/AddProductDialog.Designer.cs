using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddProductDialog : Form
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
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(CancelAddition);
            btn_Add = new Button();
            btn_Add.Click += new EventHandler(AddProduct);
            lbl_ProductName = new Label();
            lbl_InStock = new Label();
            txt_ProductName = new TextBox();
            txt_ProductName.GotFocus += new EventHandler(NameGotFocus);
            txt_ProductName.LostFocus += new EventHandler(NameLostFocus);
            txt_ProductName.TextChanged += new EventHandler(NameTextChanged);
            txt_Price = new TextBox();
            txt_Price.GotFocus += new EventHandler(PriceGotFocus);
            txt_Price.LostFocus += new EventHandler(PriceLostFocus);
            nud_Stock = new NumericUpDown();
            nud_Stock.GotFocus += new EventHandler(StockGotFocus);
            lbl_Price = new Label();
            ss_AddItem = new StatusStrip();
            tss_AddProduct = new ToolStripStatusLabel();
            ep_EmptyFields = new ErrorProvider(components);
            bw_AddProduct = new System.ComponentModel.BackgroundWorker();
            bw_AddProduct.DoWork += new System.ComponentModel.DoWorkEventHandler(AddProductBW);
            ((System.ComponentModel.ISupportInitialize)nud_Stock).BeginInit();
            ss_AddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_EmptyFields).BeginInit();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = new Font("Microsoft Sans Serif", 16.0f);
            btn_Cancel.Location = new Point(18, 225);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(144, 53);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.DialogResult = DialogResult.Cancel;
            btn_Add.Font = new Font("Microsoft Sans Serif", 16.0f);
            btn_Add.Location = new Point(214, 225);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(144, 53);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Add Product";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_ProductName.Location = new Point(80, 29);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(89, 15);
            lbl_ProductName.TabIndex = 0;
            lbl_ProductName.Text = "Product Name:";
            // 
            // lbl_InStock
            // 
            lbl_InStock.AutoSize = true;
            lbl_InStock.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_InStock.Location = new Point(146, 98);
            lbl_InStock.Name = "lbl_InStock";
            lbl_InStock.Size = new Size(53, 15);
            lbl_InStock.TabIndex = 2;
            lbl_InStock.Text = "In Stock:";
            // 
            // txt_ProductName
            // 
            txt_ProductName.Font = new Font("Microsoft Sans Serif", 16.0f);
            txt_ProductName.ForeColor = SystemColors.ControlLight;
            txt_ProductName.Location = new Point(83, 46);
            txt_ProductName.Name = "txt_ProductName";
            txt_ProductName.Size = new Size(213, 32);
            txt_ProductName.TabIndex = 1;
            txt_ProductName.Text = "Product Name";
            // 
            // txt_Price
            // 
            txt_Price.Font = new Font("Microsoft Sans Serif", 16.0f);
            txt_Price.ForeColor = SystemColors.ControlLight;
            txt_Price.Location = new Point(83, 173);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(213, 32);
            txt_Price.TabIndex = 5;
            txt_Price.Text = "$0.00";
            // 
            // nud_Stock
            // 
            nud_Stock.Font = new Font("Microsoft Sans Serif", 16.0f);
            nud_Stock.Location = new Point(149, 116);
            nud_Stock.Name = "nud_Stock";
            nud_Stock.Size = new Size(80, 32);
            nud_Stock.TabIndex = 3;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Microsoft Sans Serif", 9.0f);
            lbl_Price.Location = new Point(80, 155);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(38, 15);
            lbl_Price.TabIndex = 4;
            lbl_Price.Text = "Price:";
            // 
            // ss_AddItem
            // 
            ss_AddItem.Items.AddRange(new ToolStripItem[] { tss_AddProduct });
            ss_AddItem.Location = new Point(0, 284);
            ss_AddItem.Name = "ss_AddItem";
            ss_AddItem.Size = new Size(377, 22);
            ss_AddItem.TabIndex = 8;
            // 
            // tss_AddProduct
            // 
            tss_AddProduct.Name = "tss_AddProduct";
            tss_AddProduct.Size = new Size(231, 17);
            tss_AddProduct.Text = "Enter the information for the new product.";
            // 
            // ep_EmptyFields
            // 
            ep_EmptyFields.ContainerControl = this;
            // 
            // bw_AddProduct
            // 
            // 
            // AddProductDialog
            // 
            AcceptButton = btn_Add;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(377, 306);
            Controls.Add(ss_AddItem);
            Controls.Add(nud_Stock);
            Controls.Add(txt_Price);
            Controls.Add(txt_ProductName);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_InStock);
            Controls.Add(lbl_ProductName);
            Controls.Add(btn_Add);
            Controls.Add(btn_Cancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AddProductDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry";
            ((System.ComponentModel.ISupportInitialize)nud_Stock).EndInit();
            ss_AddItem.ResumeLayout(false);
            ss_AddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_EmptyFields).EndInit();
            Load += new EventHandler(Frm_AddNewProduct_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btn_Cancel;
        internal Button btn_Add;
        internal Label lbl_ProductName;
        internal Label lbl_InStock;
        internal TextBox txt_ProductName;
        internal TextBox txt_Price;
        internal NumericUpDown nud_Stock;
        internal Label lbl_Price;
        internal StatusStrip ss_AddItem;
        internal ToolStripStatusLabel tss_AddProduct;
        internal ErrorProvider ep_EmptyFields;
        internal System.ComponentModel.BackgroundWorker bw_AddProduct;
    }
}