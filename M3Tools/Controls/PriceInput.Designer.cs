using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PriceInput : System.Windows.Forms.UserControl
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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            txt_Price = new System.Windows.Forms.TextBox();
            txt_Price.LostFocus += new EventHandler(FormatText);
            lbl_Price = new System.Windows.Forms.Label();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(txt_Price, 0, 1);
            TableLayoutPanel1.Controls.Add(lbl_Price, 0, 0);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(150, 45);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // txt_Price
            // 
            txt_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Price.Location = new System.Drawing.Point(3, 25);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new System.Drawing.Size(144, 20);
            txt_Price.TabIndex = 2;
            txt_Price.Text = "$ 0.00";
            txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Price
            // 
            lbl_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_Price.Location = new System.Drawing.Point(3, 3);
            lbl_Price.Margin = new System.Windows.Forms.Padding(3);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new System.Drawing.Size(144, 16);
            lbl_Price.TabIndex = 1;
            lbl_Price.Text = "Price";
            lbl_Price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PriceInput
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MaximumSize = new System.Drawing.Size(0, 45);
            MinimumSize = new System.Drawing.Size(150, 45);
            Name = "PriceInput";
            Size = new System.Drawing.Size(150, 45);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox txt_Price;
        internal System.Windows.Forms.Label lbl_Price;
    }
}