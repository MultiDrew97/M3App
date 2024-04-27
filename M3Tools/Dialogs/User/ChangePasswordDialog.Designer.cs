using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ChangePasswordDialog : System.Windows.Forms.Form
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
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel_Button_Click);
            btn_Reset = new System.Windows.Forms.Button();
            btn_Reset.Click += new EventHandler(OK_Button_Click);
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pf_Password = new PasswordField();
            ConfirmPasswordField1 = new ConfirmPasswordField();
            db_Users = new Database.UserDatabase(components);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(92, 29);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // btn_Reset
            // 
            btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            btn_Reset.Location = new System.Drawing.Point(101, 3);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new System.Drawing.Size(92, 29);
            btn_Reset.TabIndex = 0;
            btn_Reset.Text = "Reset Password";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Reset, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(118, 159);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(196, 35);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // pf_Password
            // 
            pf_Password.AutoSize = true;
            pf_Password.BackColor = System.Drawing.SystemColors.Control;
            pf_Password.Location = new System.Drawing.Point(12, 12);
            pf_Password.MinimumSize = new System.Drawing.Size(300, 50);
            pf_Password.Name = "pf_Password";
            pf_Password.Password = "";
            pf_Password.Size = new System.Drawing.Size(300, 56);
            pf_Password.TabIndex = 4;
            // 
            // ConfirmPasswordField1
            // 
            ConfirmPasswordField1.AutoSize = true;
            ConfirmPasswordField1.BackColor = System.Drawing.SystemColors.Control;
            ConfirmPasswordField1.Location = new System.Drawing.Point(12, 74);
            ConfirmPasswordField1.MinimumSize = new System.Drawing.Size(300, 50);
            ConfirmPasswordField1.Name = "ConfirmPasswordField1";
            ConfirmPasswordField1.Size = new System.Drawing.Size(300, 62);
            ConfirmPasswordField1.TabIndex = 3;
            // 
            // ChangePasswordDialog
            // 
            AcceptButton = btn_Reset;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(326, 206);
            Controls.Add(pf_Password);
            Controls.Add(ConfirmPasswordField1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Change Password";
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Database.UserDatabase db_Users;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.Button btn_Reset;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal ConfirmPasswordField ConfirmPasswordField1;
        internal PasswordField pf_Password;
    }
}