using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomEmailDialog : System.Windows.Forms.Form
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
            btn_Done.Click += new EventHandler(FinishedCustom);
            Cancel_Button = new System.Windows.Forms.Button();
            Cancel_Button.Click += new EventHandler(CancelCustom);
            ce_Email = new CustomEmail();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Done, 1, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(287, 319);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Done
            // 
            btn_Done.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Done.Location = new System.Drawing.Point(76, 3);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new System.Drawing.Size(67, 23);
            btn_Done.TabIndex = 1;
            btn_Done.Text = "Done";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Cancel_Button.Location = new System.Drawing.Point(3, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new System.Drawing.Size(67, 23);
            Cancel_Button.TabIndex = 0;
            Cancel_Button.Text = "Cancel";
            // 
            // ce_Email
            // 
            ce_Email.AutoSize = true;
            ce_Email.Body = "Email Body...";
            ce_Email.Location = new System.Drawing.Point(0, 0);
            ce_Email.Margin = new System.Windows.Forms.Padding(6);
            ce_Email.MaximumSize = new System.Drawing.Size(600, 500);
            ce_Email.MinimumSize = new System.Drawing.Size(400, 300);
            ce_Email.Name = "ce_Email";
            ce_Email.Size = new System.Drawing.Size(445, 300);
            ce_Email.Subject = "";
            ce_Email.TabIndex = 0;
            // 
            // CustomEmailDialog
            // 
            AcceptButton = btn_Done;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = Cancel_Button;
            ClientSize = new System.Drawing.Size(445, 360);
            Controls.Add(ce_Email);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomEmailDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Custom Email";
            TopMost = true;
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Done;
        internal System.Windows.Forms.Button Cancel_Button;
        internal CustomEmail ce_Email;
    }
}