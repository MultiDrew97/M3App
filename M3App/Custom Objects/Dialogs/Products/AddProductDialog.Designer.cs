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
            this.components = new System.ComponentModel.Container();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ss_AddItem = new System.Windows.Forms.StatusStrip();
            this.tss_AddProduct = new System.Windows.Forms.ToolStripStatusLabel();
            this.ep_EmptyFields = new System.Windows.Forms.ErrorProvider(this.components);
            this.gi_Name = new SPPBC.M3Tools.GenericInputPair();
            this.pi_Price = new SPPBC.M3Tools.PriceInput();
            this.qnc_Stock = new SPPBC.M3Tools.QuantityNudCtrl();
            this.ss_AddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_EmptyFields)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Cancel.Location = new System.Drawing.Point(18, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(144, 53);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // btn_Add
            // 
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Add.Location = new System.Drawing.Point(214, 225);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(144, 53);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add Product";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Add);
            // 
            // ss_AddItem
            // 
            this.ss_AddItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_AddProduct});
            this.ss_AddItem.Location = new System.Drawing.Point(0, 284);
            this.ss_AddItem.Name = "ss_AddItem";
            this.ss_AddItem.Size = new System.Drawing.Size(377, 22);
            this.ss_AddItem.TabIndex = 8;
            // 
            // tss_AddProduct
            // 
            this.tss_AddProduct.Name = "tss_AddProduct";
            this.tss_AddProduct.Size = new System.Drawing.Size(231, 17);
            this.tss_AddProduct.Text = "Enter the information for the new product.";
            // 
            // ep_EmptyFields
            // 
            this.ep_EmptyFields.ContainerControl = this;
            // 
            // gi_Name
            // 
            this.gi_Name.AutoSize = true;
            this.gi_Name.Label = "Product Name:";
            this.gi_Name.Location = new System.Drawing.Point(78, 16);
            this.gi_Name.Mask = "";
            this.gi_Name.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_Name.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_Name.Name = "gi_Name";
            this.gi_Name.Placeholder = "Product Name";
            this.gi_Name.Size = new System.Drawing.Size(221, 45);
            this.gi_Name.TabIndex = 9;
            this.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pi_Price
            // 
            this.pi_Price.AutoSize = true;
            this.pi_Price.Location = new System.Drawing.Point(78, 168);
            this.pi_Price.MaximumSize = new System.Drawing.Size(0, 45);
            this.pi_Price.MinimumSize = new System.Drawing.Size(150, 45);
            this.pi_Price.Name = "pi_Price";
            this.pi_Price.Price = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.pi_Price.Size = new System.Drawing.Size(221, 45);
            this.pi_Price.TabIndex = 10;
            // 
            // qnc_Stock
            // 
            this.qnc_Stock.Label = "In Stock:";
            this.qnc_Stock.Location = new System.Drawing.Point(137, 92);
            this.qnc_Stock.MaximumSize = new System.Drawing.Size(0, 45);
            this.qnc_Stock.MinimumSize = new System.Drawing.Size(100, 45);
            this.qnc_Stock.Name = "qnc_Stock";
            this.qnc_Stock.Size = new System.Drawing.Size(100, 45);
            this.qnc_Stock.TabIndex = 11;
            // 
            // AddProductDialog
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(377, 306);
            this.Controls.Add(this.qnc_Stock);
            this.Controls.Add(this.gi_Name);
            this.Controls.Add(this.ss_AddItem);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pi_Price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AddProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ministry";
            this.Load += new System.EventHandler(Reload);
            this.ss_AddItem.ResumeLayout(false);
            this.ss_AddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_EmptyFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Button btn_Cancel;
        internal Button btn_Add;
        internal StatusStrip ss_AddItem;
        internal ToolStripStatusLabel tss_AddProduct;
        internal ErrorProvider ep_EmptyFields;
		private SPPBC.M3Tools.GenericInputPair gi_Name;
		private SPPBC.M3Tools.PriceInput pi_Price;
		private SPPBC.M3Tools.QuantityNudCtrl qnc_Stock;
	}
}
