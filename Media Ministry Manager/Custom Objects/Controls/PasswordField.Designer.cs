using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PasswordField : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordField));
            SplitContainer1 = new SplitContainer();
            txtPassword = new TextBox();
            btnShow = new Button();
            btnShow.Click += new EventHandler(BtnShow_Click);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = DockStyle.Fill;
            SplitContainer1.Location = new Point(0, 0);
            SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(txtPassword);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(btnShow);
            SplitContainer1.Size = new Size(414, 20);
            SplitContainer1.SplitterDistance = 344;
            SplitContainer1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(0, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 20);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShow
            // 
            btnShow.Dock = DockStyle.Fill;
            btnShow.Image = (Image)resources.GetObject("btnShow.Image");
            btnShow.Location = new Point(0, 0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(66, 20);
            btnShow.TabIndex = 0;
            btnShow.UseVisualStyleBackColor = true;
            // 
            // PasswordField
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(SplitContainer1);
            Name = "PasswordField";
            Size = new Size(414, 20);
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel1.PerformLayout();
            SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            ResumeLayout(false);

        }

        internal SplitContainer SplitContainer1;
        internal TextBox txtPassword;
        internal Button btnShow;
    }
}