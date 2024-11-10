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
			this.spc_UsernamePassword = new System.Windows.Forms.SplitContainer();
			this.uf_Username = new SPPBC.M3Tools.UsernameField();
			this.pf_Password = new SPPBC.M3Tools.PasswordField();
			((System.ComponentModel.ISupportInitialize)(this.spc_UsernamePassword)).BeginInit();
			this.spc_UsernamePassword.Panel1.SuspendLayout();
			this.spc_UsernamePassword.Panel2.SuspendLayout();
			this.spc_UsernamePassword.SuspendLayout();
			this.SuspendLayout();
			// 
			// spc_UsernamePassword
			// 
			this.spc_UsernamePassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spc_UsernamePassword.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spc_UsernamePassword.Location = new System.Drawing.Point(10, 10);
			this.spc_UsernamePassword.MinimumSize = new System.Drawing.Size(300, 100);
			this.spc_UsernamePassword.Name = "spc_UsernamePassword";
			this.spc_UsernamePassword.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spc_UsernamePassword.Panel1
			// 
			this.spc_UsernamePassword.Panel1.Controls.Add(this.uf_Username);
			this.spc_UsernamePassword.Panel1MinSize = 50;
			// 
			// spc_UsernamePassword.Panel2
			// 
			this.spc_UsernamePassword.Panel2.Controls.Add(this.pf_Password);
			this.spc_UsernamePassword.Panel2MinSize = 50;
			this.spc_UsernamePassword.Size = new System.Drawing.Size(300, 110);
			this.spc_UsernamePassword.SplitterWidth = 1;
			this.spc_UsernamePassword.TabIndex = 1;
			this.spc_UsernamePassword.TabStop = false;
			// 
			// uf_Username
			// 
			this.uf_Username.AutoSize = true;
			this.uf_Username.BackColor = System.Drawing.Color.Transparent;
			this.uf_Username.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uf_Username.Location = new System.Drawing.Point(0, 0);
			this.uf_Username.MinimumSize = new System.Drawing.Size(300, 50);
			this.uf_Username.Name = "uf_Username";
			this.uf_Username.Size = new System.Drawing.Size(300, 50);
			this.uf_Username.TabIndex = 0;
			this.uf_Username.Username = "";
			// 
			// pf_Password
			// 
			this.pf_Password.AutoSize = true;
			this.pf_Password.BackColor = System.Drawing.Color.Transparent;
			this.pf_Password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pf_Password.Location = new System.Drawing.Point(0, 0);
			this.pf_Password.MinimumSize = new System.Drawing.Size(300, 50);
			this.pf_Password.Name = "pf_Password";
			this.pf_Password.Password = "";
			this.pf_Password.Size = new System.Drawing.Size(300, 59);
			this.pf_Password.TabIndex = 0;
			this.pf_Password.PasswordGotFocus += new System.EventHandler(this.PasswordGotFocus);
			// 
			// LoginFields
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.spc_UsernamePassword);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimumSize = new System.Drawing.Size(320, 130);
			this.Name = "LoginFields";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(320, 130);
			this.spc_UsernamePassword.Panel1.ResumeLayout(false);
			this.spc_UsernamePassword.Panel1.PerformLayout();
			this.spc_UsernamePassword.Panel2.ResumeLayout(false);
			this.spc_UsernamePassword.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spc_UsernamePassword)).EndInit();
			this.spc_UsernamePassword.ResumeLayout(false);
			this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer spc_UsernamePassword;
        internal UsernameField uf_Username;
        internal PasswordField pf_Password;
    }
}