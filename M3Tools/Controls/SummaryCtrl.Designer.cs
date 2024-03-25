using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SummaryCtrl : System.Windows.Forms.UserControl
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
            pg_Summary = new System.Windows.Forms.PropertyGrid();
            SuspendLayout();
            // 
            // pg_Summary
            // 
            pg_Summary.CanShowVisualStyleGlyphs = false;
            pg_Summary.CommandsVisibleIfAvailable = false;
            pg_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            pg_Summary.Enabled = false;
            pg_Summary.HelpVisible = false;
            pg_Summary.Location = new System.Drawing.Point(0, 0);
            pg_Summary.Name = "pg_Summary";
            pg_Summary.Size = new System.Drawing.Size(150, 150);
            pg_Summary.TabIndex = 1;
            pg_Summary.ToolbarVisible = false;
            // 
            // SummaryCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pg_Summary);
            Name = "SummaryCtrl";
            ResumeLayout(false);

        }

        internal System.Windows.Forms.PropertyGrid pg_Summary;
    }
}