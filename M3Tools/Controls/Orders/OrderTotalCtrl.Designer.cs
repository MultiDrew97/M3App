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
            SplitContainer1 = new System.Windows.Forms.SplitContainer();
            lbl_Total = new System.Windows.Forms.Label();
            txt_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            SplitContainer1.Location = new System.Drawing.Point(0, 0);
            SplitContainer1.MinimumSize = new System.Drawing.Size(0, 20);
            SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(lbl_Total);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(txt_Total);
            SplitContainer1.Size = new System.Drawing.Size(115, 20);
            SplitContainer1.SplitterDistance = 39;
            SplitContainer1.TabIndex = 0;
            // 
            // lbl_Total
            // 
            lbl_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_Total.Location = new System.Drawing.Point(0, 0);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new System.Drawing.Size(39, 20);
            lbl_Total.TabIndex = 5;
            lbl_Total.Text = "Total:";
            lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Total
            // 
            txt_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Total.Enabled = false;
            txt_Total.Location = new System.Drawing.Point(0, 0);
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new System.Drawing.Size(72, 20);
            txt_Total.TabIndex = 7;
            txt_Total.Text = "0";
            txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderTotalCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(SplitContainer1);
            MaximumSize = new System.Drawing.Size(115, 20);
            MinimumSize = new System.Drawing.Size(95, 20);
            Name = "OrderTotalCtrl";
            Size = new System.Drawing.Size(115, 20);
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel2.ResumeLayout(false);
            SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            TotalChanged += new TotalChangedEventHandler(UpdateTotal);
            ResumeLayout(false);

        }

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label lbl_Total;
        internal System.Windows.Forms.TextBox txt_Total;
    }
}