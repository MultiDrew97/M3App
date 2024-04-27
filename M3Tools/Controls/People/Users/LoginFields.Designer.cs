using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginFields : System.Windows.Forms.UserControl
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
            spc_UsernamePassword = new System.Windows.Forms.SplitContainer();
            uf_Username = new UsernameField();
            pf_Password = new PasswordField();
            pf_Password.PasswordGotFocus += new EventHandler(PasswordGotFocus);
            ((System.ComponentModel.ISupportInitialize)spc_UsernamePassword).BeginInit();
            spc_UsernamePassword.Panel1.SuspendLayout();
            spc_UsernamePassword.Panel2.SuspendLayout();
            spc_UsernamePassword.SuspendLayout();
            SuspendLayout();
            // 
            // spc_UsernamePassword
            // 
            spc_UsernamePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            spc_UsernamePassword.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            spc_UsernamePassword.Location = new System.Drawing.Point(10, 10);
            spc_UsernamePassword.MinimumSize = new System.Drawing.Size(300, 100);
            spc_UsernamePassword.Name = "spc_UsernamePassword";
            spc_UsernamePassword.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_UsernamePassword.Panel1
            // 
            spc_UsernamePassword.Panel1.Controls.Add(uf_Username);
            spc_UsernamePassword.Panel1MinSize = 50;
            // 
            // spc_UsernamePassword.Panel2
            // 
            spc_UsernamePassword.Panel2.Controls.Add(pf_Password);
            spc_UsernamePassword.Panel2MinSize = 50;
            spc_UsernamePassword.Size = new System.Drawing.Size(300, 110);
            spc_UsernamePassword.SplitterWidth = 1;
            spc_UsernamePassword.TabIndex = 1;
            spc_UsernamePassword.TabStop = false;
            // 
            // uf_Username
            // 
            uf_Username.AutoSize = true;
            uf_Username.BackColor = System.Drawing.Color.Transparent;
            uf_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            uf_Username.Location = new System.Drawing.Point(0, 0);
            uf_Username.MinimumSize = new System.Drawing.Size(300, 50);
            uf_Username.Name = "uf_Username";
            uf_Username.Size = new System.Drawing.Size(300, 50);
            uf_Username.TabIndex = 0;
            uf_Username.Username = "";
            // 
            // pf_Password
            // 
            pf_Password.AutoSize = true;
            pf_Password.BackColor = System.Drawing.Color.Transparent;
            pf_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            pf_Password.Location = new System.Drawing.Point(0, 0);
            pf_Password.MinimumSize = new System.Drawing.Size(300, 50);
            pf_Password.Name = "pf_Password";
            pf_Password.Password = "";
            pf_Password.Size = new System.Drawing.Size(300, 59);
            pf_Password.TabIndex = 0;
            // 
            // LoginFields
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(spc_UsernamePassword);
            ForeColor = System.Drawing.SystemColors.ControlText;
            MinimumSize = new System.Drawing.Size(320, 130);
            Name = "LoginFields";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(320, 130);
            spc_UsernamePassword.Panel1.ResumeLayout(false);
            spc_UsernamePassword.Panel1.PerformLayout();
            spc_UsernamePassword.Panel2.ResumeLayout(false);
            spc_UsernamePassword.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spc_UsernamePassword).EndInit();
            spc_UsernamePassword.ResumeLayout(false);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer spc_UsernamePassword;
        internal UsernameField uf_Username;
        internal PasswordField pf_Password;
    }
}