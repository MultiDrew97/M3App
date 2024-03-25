using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ReciepientSelection : System.Windows.Forms.Form
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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btn_Select = new System.Windows.Forms.Button();
            btn_Select.Click += new EventHandler(ConfirmSelection);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            ldg_Listeners = new ListenersDataGrid();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Select, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(366, 368);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Select
            // 
            btn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Select.Location = new System.Drawing.Point(76, 3);
            btn_Select.Name = "btn_Select";
            btn_Select.Size = new System.Drawing.Size(67, 23);
            btn_Select.TabIndex = 0;
            btn_Select.Text = "Select";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // ldg_Listeners
            // 
            ldg_Listeners.AllowColumnReordering = true;
            ldg_Listeners.AllowDeleting = false;
            ldg_Listeners.AllowEditting = false;
            ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Top;
            ldg_Listeners.Filter = null;
            ldg_Listeners.Location = new System.Drawing.Point(0, 0);
            ldg_Listeners.MinimumSize = new System.Drawing.Size(400, 200);
            ldg_Listeners.Name = "ldg_Listeners";
            ldg_Listeners.Size = new System.Drawing.Size(524, 362);
            ldg_Listeners.TabIndex = 1;
            // 
            // ReciepientSelectionDialog
            // 
            AcceptButton = btn_Select;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(524, 409);
            Controls.Add(ldg_Listeners);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReciepientSelectionDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Which Listener(s)?";
            TopMost = true;
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Select;
        internal System.Windows.Forms.Button btn_Cancel;
        internal ListenersDataGrid ldg_Listeners;
    }
}