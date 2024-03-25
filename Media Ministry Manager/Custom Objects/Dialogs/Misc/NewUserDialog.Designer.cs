using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class NewUserDialog : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserDialog));
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            btn_Create = new Button();
            btn_Create.Click += new EventHandler(Btn_Create_Click);
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_ConfirmPassword = new TextBox();
            lbl_ConfirmPassword = new Label();
            ss_Feedback = new StatusStrip();
            tss_UserFeedback = new ToolStripStatusLabel();
            ss_Feedback.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancel.Location = new Point(33, 258);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(82, 33);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            btn_Create.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Create.Location = new Point(171, 258);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(82, 33);
            btn_Create.TabIndex = 7;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(33, 30);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(73, 19);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(33, 102);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(72, 19);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password:";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(33, 52);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(220, 26);
            txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(33, 124);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(220, 26);
            txt_Password.TabIndex = 3;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ConfirmPassword.Location = new Point(33, 196);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new Size(220, 26);
            txt_ConfirmPassword.TabIndex = 5;
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ConfirmPassword.Location = new Point(33, 174);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(125, 19);
            lbl_ConfirmPassword.TabIndex = 4;
            lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // ss_Feedback
            // 
            ss_Feedback.Items.AddRange(new ToolStripItem[] { tss_UserFeedback });
            ss_Feedback.Location = new Point(0, 298);
            ss_Feedback.Name = "ss_Feedback";
            ss_Feedback.Size = new Size(286, 22);
            ss_Feedback.TabIndex = 8;
            ss_Feedback.Text = "StatusStrip1";
            // 
            // tss_UserFeedback
            // 
            tss_UserFeedback.Name = "tss_UserFeedback";
            tss_UserFeedback.Size = new Size(174, 17);
            tss_UserFeedback.Text = "Enter a username and password";
            // 
            // NewUserDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(286, 320);
            Controls.Add(ss_Feedback);
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(lbl_ConfirmPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(btn_Create);
            Controls.Add(btn_Cancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewUserDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ss_Feedback.ResumeLayout(false);
            ss_Feedback.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btn_Cancel;
        internal Button btn_Create;
        internal Label lbl_Username;
        internal Label lbl_Password;
        internal TextBox txt_Username;
        internal TextBox txt_Password;
        internal TextBox txt_ConfirmPassword;
        internal Label lbl_ConfirmPassword;
        internal StatusStrip ss_Feedback;
        internal ToolStripStatusLabel tss_UserFeedback;
    }
}