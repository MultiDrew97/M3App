using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditProductDialog : System.Windows.Forms.Form
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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btn_Done = new System.Windows.Forms.Button();
            btn_Done.Click += new EventHandler(FinishDialog);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(CancelDialog);
            chk_Available = new System.Windows.Forms.CheckBox();
            gi_Name = new GenericInputPair();
            qn_Stock = new QuantityNudCtrl();
            pi_Price = new PriceInput();
            Panel1 = new System.Windows.Forms.Panel();
            TableLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Done, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(179, 203);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Done
            // 
            btn_Done.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_Done.Location = new System.Drawing.Point(76, 3);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new System.Drawing.Size(67, 23);
            btn_Done.TabIndex = 1;
            btn_Done.Text = "Done";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            // 
            // chk_Available
            // 
            chk_Available.AutoSize = true;
            chk_Available.Location = new System.Drawing.Point(131, 162);
            chk_Available.Name = "chk_Available";
            chk_Available.Size = new System.Drawing.Size(75, 17);
            chk_Available.TabIndex = 3;
            chk_Available.Text = "Available?";
            chk_Available.UseVisualStyleBackColor = true;
            // 
            // gi_Name
            // 
            gi_Name.AutoSize = true;
            gi_Name.Label = "Name";
            gi_Name.Location = new System.Drawing.Point(18, 12);
            gi_Name.Mask = "";
            gi_Name.MaximumSize = new System.Drawing.Size(0, 45);
            gi_Name.MinimumSize = new System.Drawing.Size(300, 45);
            gi_Name.Name = "gi_Name";
            gi_Name.Placeholder = "Product Name";
            gi_Name.Size = new System.Drawing.Size(300, 45);
            gi_Name.TabIndex = 0;
            gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // qn_Stock
            // 
            qn_Stock.Label = "Stock";
            qn_Stock.Location = new System.Drawing.Point(118, 63);
            qn_Stock.MaximumSize = new System.Drawing.Size(0, 42);
            qn_Stock.MaximumValue = 100;
            qn_Stock.MinimumSize = new System.Drawing.Size(100, 42);
            qn_Stock.Name = "qn_Stock";
            qn_Stock.Size = new System.Drawing.Size(100, 42);
            qn_Stock.TabIndex = 1;
            // 
            // pi_Price
            // 
            pi_Price.AutoSize = true;
            pi_Price.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pi_Price.Location = new System.Drawing.Point(93, 111);
            pi_Price.MaximumSize = new System.Drawing.Size(150, 45);
            pi_Price.MinimumSize = new System.Drawing.Size(150, 45);
            pi_Price.Name = "pi_Price";
            pi_Price.Price = new decimal(new int[] { 0, 0, 0, 0 });
            pi_Price.Size = new System.Drawing.Size(150, 45);
            pi_Price.TabIndex = 2;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(pi_Price);
            Panel1.Controls.Add(gi_Name);
            Panel1.Controls.Add(qn_Stock);
            Panel1.Controls.Add(chk_Available);
            Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            Panel1.Location = new System.Drawing.Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new System.Drawing.Size(337, 197);
            Panel1.TabIndex = 0;
            // 
            // EditProductDialog
            // 
            AcceptButton = btn_Done;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(337, 244);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(Panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProductDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit {0}";
            TableLayoutPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ProductChanged += new ProductChangedEventHandler(ProductUpdated);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Done;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.CheckBox chk_Available;
        internal GenericInputPair gi_Name;
        internal QuantityNudCtrl qn_Stock;
        internal PriceInput pi_Price;
        internal System.Windows.Forms.Panel Panel1;
    }
}