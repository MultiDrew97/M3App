using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginDialog : System.Windows.Forms.Form
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
            btn_Submit = new System.Windows.Forms.Button();
            btn_Submit.Click += new EventHandler(SubmitCredentials);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(CancelRequest);
            LoginFields1 = new LoginFields();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Submit, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(169, 187);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Submit
            // 
            btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Submit.Location = new System.Drawing.Point(76, 3);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new System.Drawing.Size(67, 23);
            btn_Submit.TabIndex = 0;
            btn_Submit.Text = "OK";
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
            // LoginFields1
            // 
            LoginFields1.AutoSize = true;
            LoginFields1.BackColor = System.Drawing.Color.Transparent;
            LoginFields1.ForeColor = System.Drawing.SystemColors.ControlText;
            LoginFields1.Location = new System.Drawing.Point(12, 12);
            LoginFields1.Name = "LoginFields1";
            LoginFields1.Padding = new System.Windows.Forms.Padding(10);
            LoginFields1.Password = "";
            LoginFields1.Size = new System.Drawing.Size(311, 163);
            LoginFields1.TabIndex = 1;
            LoginFields1.Username = "";
            // 
            // LoginDialog
            // 
            AcceptButton = btn_Submit;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(327, 228);
            Controls.Add(LoginFields1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Verify Identity";
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Submit;
        internal System.Windows.Forms.Button btn_Cancel;
        internal LoginFields LoginFields1;
    }
}