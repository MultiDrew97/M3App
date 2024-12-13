using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ChangePasswordDialog : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            lbl_Password = new Label();
            lbl_Username = new Label();
            btn_ChangePassword = new Button();
            btn_ChangePassword.Click += new EventHandler(UpdatePassword);
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(CancelPasswordChange);
            txt_ConfirmPassword = new TextBox();
            lbl_ConfirmPassword = new Label();
            tss_UserFeedback = new ToolStripStatusLabel();
            ss_Feedback = new StatusStrip();
            ss_Feedback.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(34, 125);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(295, 26);
            txt_Password.TabIndex = 3;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(34, 55);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(295, 26);
            txt_Username.TabIndex = 1;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(34, 103);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(106, 19);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "New Password:";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(34, 33);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(73, 19);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username:";
            // 
            // btn_ChangePassword
            // 
            btn_ChangePassword.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ChangePassword.Location = new Point(209, 244);
            btn_ChangePassword.Name = "btn_ChangePassword";
            btn_ChangePassword.Size = new Size(82, 48);
            btn_ChangePassword.TabIndex = 7;
            btn_ChangePassword.Text = "Change Password";
            btn_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancel.Location = new Point(71, 244);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(82, 48);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ConfirmPassword.Location = new Point(34, 195);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new Size(295, 26);
            txt_ConfirmPassword.TabIndex = 5;
            txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ConfirmPassword.Location = new Point(34, 173);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(125, 19);
            lbl_ConfirmPassword.TabIndex = 4;
            lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // tss_UserFeedback
            // 
            tss_UserFeedback.BackColor = Color.Transparent;
            tss_UserFeedback.Name = "tss_UserFeedback";
            tss_UserFeedback.Size = new Size(345, 17);
            tss_UserFeedback.Text = "Enter the username of the user to change and the new password";
            // 
            // ss_Feedback
            // 
            ss_Feedback.Items.AddRange(new ToolStripItem[] { tss_UserFeedback });
            ss_Feedback.Location = new Point(0, 302);
            ss_Feedback.Name = "ss_Feedback";
            ss_Feedback.Size = new Size(362, 22);
            ss_Feedback.TabIndex = 8;
            // 
            // ChangePasswordDialog
            // 
            AcceptButton = btn_ChangePassword;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(362, 324);
            Controls.Add(ss_Feedback);
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(lbl_ConfirmPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(btn_ChangePassword);
            Controls.Add(btn_Cancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChangePasswordDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ss_Feedback.ResumeLayout(false);
            ss_Feedback.PerformLayout();
            Load += new EventHandler(ChangePasswordLoaded);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txt_Password;
        internal TextBox txt_Username;
        internal Label lbl_Password;
        internal Label lbl_Username;
        internal Button btn_ChangePassword;
        internal Button btn_Cancel;
        internal TextBox txt_ConfirmPassword;
        internal Label lbl_ConfirmPassword;
        internal ToolStripStatusLabel tss_UserFeedback;
        internal StatusStrip ss_Feedback;
    }
}