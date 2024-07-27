using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OrderTotalCtrl : System.Windows.Forms.UserControl
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.MinimumSize = new System.Drawing.Size(0, 20);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.lbl_Total);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.txt_Total);
            this.SplitContainer1.Size = new System.Drawing.Size(115, 20);
            this.SplitContainer1.SplitterDistance = 39;
            this.SplitContainer1.TabIndex = 0;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Total.Location = new System.Drawing.Point(0, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(39, 20);
            this.lbl_Total.TabIndex = 5;
            this.lbl_Total.Text = "Total:";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Total
            // 
            this.txt_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Total.Location = new System.Drawing.Point(0, 0);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(72, 20);
            this.txt_Total.TabIndex = 7;
            this.txt_Total.Text = "$ 0.00";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderTotalCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer1);
            this.MaximumSize = new System.Drawing.Size(115, 20);
            this.MinimumSize = new System.Drawing.Size(95, 20);
            this.Name = "OrderTotalCtrl";
            this.Size = new System.Drawing.Size(115, 20);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label lbl_Total;
        internal System.Windows.Forms.TextBox txt_Total;
    }
}
