using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UsernameField : System.Windows.Forms.UserControl
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
            spc_LabelInputs = new System.Windows.Forms.SplitContainer();
            lbl_Username = new System.Windows.Forms.Label();
            spc_InputButton = new System.Windows.Forms.SplitContainer();
            txt_Username = new System.Windows.Forms.TextBox();
            txt_Username.LostFocus += new EventHandler(Txt_UsernameLostFocus);
            txt_Username.TextChanged += new EventHandler(Txt_Username_TextChanged);
            btn_Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)spc_LabelInputs).BeginInit();
            spc_LabelInputs.Panel1.SuspendLayout();
            spc_LabelInputs.Panel2.SuspendLayout();
            spc_LabelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spc_InputButton).BeginInit();
            spc_InputButton.Panel1.SuspendLayout();
            spc_InputButton.Panel2.SuspendLayout();
            spc_InputButton.SuspendLayout();
            SuspendLayout();
            // 
            // spc_LabelInputs
            // 
            spc_LabelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            spc_LabelInputs.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            spc_LabelInputs.IsSplitterFixed = true;
            spc_LabelInputs.Location = new System.Drawing.Point(0, 0);
            spc_LabelInputs.Name = "spc_LabelInputs";
            spc_LabelInputs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_LabelInputs.Panel1
            // 
            spc_LabelInputs.Panel1.BackColor = System.Drawing.Color.Transparent;
            spc_LabelInputs.Panel1.Controls.Add(lbl_Username);
            spc_LabelInputs.Panel1MinSize = 15;
            // 
            // spc_LabelInputs.Panel2
            // 
            spc_LabelInputs.Panel2.Controls.Add(spc_InputButton);
            spc_LabelInputs.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            spc_LabelInputs.Size = new System.Drawing.Size(300, 50);
            spc_LabelInputs.SplitterDistance = 24;
            spc_LabelInputs.SplitterWidth = 1;
            spc_LabelInputs.TabIndex = 3;
            spc_LabelInputs.TabStop = false;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Dock = System.Windows.Forms.DockStyle.Bottom;
            lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbl_Username.Location = new System.Drawing.Point(0, 4);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(83, 20);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            lbl_Username.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // spc_InputButton
            // 
            spc_InputButton.BackColor = System.Drawing.Color.Transparent;
            spc_InputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            spc_InputButton.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            spc_InputButton.IsSplitterFixed = true;
            spc_InputButton.Location = new System.Drawing.Point(0, 0);
            spc_InputButton.Name = "spc_InputButton";
            // 
            // spc_InputButton.Panel1
            // 
            spc_InputButton.Panel1.Controls.Add(txt_Username);
            // 
            // spc_InputButton.Panel2
            // 
            spc_InputButton.Panel2.Controls.Add(btn_Show);
            spc_InputButton.Panel2MinSize = 40;
            spc_InputButton.Size = new System.Drawing.Size(300, 20);
            spc_InputButton.SplitterDistance = 255;
            spc_InputButton.TabIndex = 0;
            spc_InputButton.TabStop = false;
            // 
            // txt_Username
            // 
            txt_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txt_Username.Location = new System.Drawing.Point(0, 0);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new System.Drawing.Size(255, 20);
            txt_Username.TabIndex = 0;
            // 
            // btn_Show
            // 
            btn_Show.BackColor = System.Drawing.Color.Transparent;
            btn_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Show.Enabled = false;
            btn_Show.Image = Properties.Resources.ShowPasswordIcon;
            btn_Show.Location = new System.Drawing.Point(0, 0);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new System.Drawing.Size(41, 20);
            btn_Show.TabIndex = 0;
            btn_Show.TabStop = false;
            btn_Show.UseVisualStyleBackColor = false;
            btn_Show.Visible = false;
            // 
            // UsernameField
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(spc_LabelInputs);
            MinimumSize = new System.Drawing.Size(300, 50);
            Name = "UsernameField";
            Size = new System.Drawing.Size(300, 50);
            spc_LabelInputs.Panel1.ResumeLayout(false);
            spc_LabelInputs.Panel1.PerformLayout();
            spc_LabelInputs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spc_LabelInputs).EndInit();
            spc_LabelInputs.ResumeLayout(false);
            spc_InputButton.Panel1.ResumeLayout(false);
            spc_InputButton.Panel1.PerformLayout();
            spc_InputButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spc_InputButton).EndInit();
            spc_InputButton.ResumeLayout(false);
            ResumeLayout(false);

        }

        internal System.Windows.Forms.SplitContainer spc_LabelInputs;
        internal System.Windows.Forms.Label lbl_Username;
        internal System.Windows.Forms.SplitContainer spc_InputButton;
        internal System.Windows.Forms.TextBox txt_Username;
        internal System.Windows.Forms.Button btn_Show;
    }
}
