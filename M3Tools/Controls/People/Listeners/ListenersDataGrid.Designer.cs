using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ListenersDataGrid : Data.DataGrid<Types.Listener>
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
            bsListeners = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsListeners).BeginInit();
            SuspendLayout();
            // 
            // ListenersDataGrid
            // 
            Name = "ListenersDataGrid";
            Size = new System.Drawing.Size(450, 300);
            ((System.ComponentModel.ISupportInitialize)bsListeners).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal System.Windows.Forms.BindingSource bsListeners;
    }
}
