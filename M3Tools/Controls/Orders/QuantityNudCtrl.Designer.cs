using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class QuantityNudCtrl : System.Windows.Forms.UserControl
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
            lbl_Quantity = new System.Windows.Forms.Label();
            nud_Quantity = new System.Windows.Forms.NumericUpDown();
            nud_Quantity.ValueChanged += new EventHandler(QuantityValueChanged);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(lbl_Quantity, 0, 0);
            TableLayoutPanel1.Controls.Add(nud_Quantity, 0, 1);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.55556f));
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.44444f));
            TableLayoutPanel1.Size = new System.Drawing.Size(100, 45);
            TableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_Quantity.Location = new System.Drawing.Point(3, 0);
            lbl_Quantity.MaximumSize = new System.Drawing.Size(0, 20);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new System.Drawing.Size(94, 16);
            lbl_Quantity.TabIndex = 0;
            lbl_Quantity.Text = "Quantity";
            lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nud_Quantity
            // 
            nud_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            nud_Quantity.Location = new System.Drawing.Point(3, 19);
            nud_Quantity.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new System.Drawing.Size(94, 20);
            nud_Quantity.TabIndex = 1;
            nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nud_Quantity.ThousandsSeparator = true;
            // 
            // QuantityNudCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel1);
            MaximumSize = new System.Drawing.Size(0, 45);
            MinimumSize = new System.Drawing.Size(100, 45);
            Name = "QuantityNudCtrl";
            Size = new System.Drawing.Size(100, 45);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).EndInit();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label lbl_Quantity;
        internal System.Windows.Forms.NumericUpDown nud_Quantity;
    }
}