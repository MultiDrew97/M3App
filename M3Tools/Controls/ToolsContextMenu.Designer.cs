using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ToolsContextMenu : System.Windows.Forms.ContextMenuStrip
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
            ts_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            ts_Refresh.Click += new EventHandler(Reload);
            ts_Remove = new System.Windows.Forms.ToolStripMenuItem();
            ts_Remove.Click += new EventHandler(RemoveRowByToolStrip);
            ts_Send = new System.Windows.Forms.ToolStripMenuItem();
            ts_Send.Click += new EventHandler(EmailFunctions);
            ts_Edit = new System.Windows.Forms.ToolStripMenuItem();
            ts_Edit.Click += new EventHandler(EditClicked);
            SuspendLayout();
            // 
            // ts_Refresh
            // 
            ts_Refresh.Name = "ts_Refresh";
            ts_Refresh.Size = new System.Drawing.Size(132, 22);
            ts_Refresh.Text = "Refresh";
            // 
            // ts_Remove
            // 
            ts_Remove.Enabled = false;
            ts_Remove.Name = "ts_Remove";
            ts_Remove.Size = new System.Drawing.Size(132, 22);
            ts_Remove.Text = "Remove";
            // 
            // ts_Send
            // 
            ts_Send.Name = "ts_Send";
            ts_Send.Size = new System.Drawing.Size(132, 22);
            ts_Send.Text = "Send Email";
            ts_Send.Visible = false;
            // 
            // ts_Edit
            // 
            ts_Edit.Enabled = false;
            ts_Edit.Name = "ts_Edit";
            ts_Edit.Size = new System.Drawing.Size(132, 22);
            ts_Edit.Text = "Edit";
            // 
            // ToolsContextMenu
            // 
            Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ts_Refresh, ts_Remove, ts_Edit, ts_Send });
            Size = new System.Drawing.Size(133, 92);
            Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(MenuClosed);
            ResumeLayout(false);

        }

        internal System.Windows.Forms.ToolStripMenuItem ts_Refresh;
        internal System.Windows.Forms.ToolStripMenuItem ts_Remove;
        internal System.Windows.Forms.ToolStripMenuItem ts_Send;
        internal System.Windows.Forms.ToolStripMenuItem ts_Edit;
    }
}