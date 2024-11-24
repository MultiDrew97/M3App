using System.Diagnostics;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ConfirmPasswordField : UserControl
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
            lbl_ConfirmPassword = new Label();
            txt_ConfirmPassword = new TextBox();
            btn_Show = new Button();
            spc_LabelInputs = new SplitContainer();
            spc_InputButton = new SplitContainer();
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
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Dock = DockStyle.Bottom;
            lbl_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbl_ConfirmPassword.Location = new System.Drawing.Point(0, 4);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new System.Drawing.Size(137, 20);
            lbl_ConfirmPassword.TabIndex = 0;
            lbl_ConfirmPassword.Text = "Confirm Password";
            lbl_ConfirmPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Dock = DockStyle.Fill;
            txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.0f);
            txt_ConfirmPassword.Location = new System.Drawing.Point(0, 0);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new System.Drawing.Size(255, 20);
            txt_ConfirmPassword.TabIndex = 0;
            txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btn_Show
            // 
            btn_Show.BackColor = System.Drawing.Color.Transparent;
            btn_Show.Dock = DockStyle.Fill;
            btn_Show.Image = Properties.Resources.Show_Password;
            btn_Show.Location = new System.Drawing.Point(0, 0);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new System.Drawing.Size(41, 20);
            btn_Show.TabIndex = 0;
            btn_Show.TabStop = false;
            btn_Show.UseVisualStyleBackColor = true;
            // 
            // spc_LabelInputs
            // 
            spc_LabelInputs.BackColor = System.Drawing.Color.Transparent;
            spc_LabelInputs.Dock = DockStyle.Fill;
            spc_LabelInputs.FixedPanel = FixedPanel.Panel2;
            spc_LabelInputs.IsSplitterFixed = true;
            spc_LabelInputs.Location = new System.Drawing.Point(0, 0);
            spc_LabelInputs.Name = "spc_LabelInputs";
            spc_LabelInputs.Orientation = Orientation.Horizontal;
            // 
            // spc_LabelInputs.Panel1
            // 
            spc_LabelInputs.Panel1.Controls.Add(lbl_ConfirmPassword);
            spc_LabelInputs.Panel1MinSize = 15;
            // 
            // spc_LabelInputs.Panel2
            // 
            spc_LabelInputs.Panel2.Controls.Add(spc_InputButton);
            spc_LabelInputs.Panel2.Padding = new Padding(0, 0, 0, 5);
            spc_LabelInputs.Size = new System.Drawing.Size(300, 50);
            spc_LabelInputs.SplitterDistance = 24;
            spc_LabelInputs.SplitterWidth = 1;
            spc_LabelInputs.TabIndex = 2;
            spc_LabelInputs.TabStop = false;
            // 
            // spc_InputButton
            // 
            spc_InputButton.Dock = DockStyle.Fill;
            spc_InputButton.FixedPanel = FixedPanel.Panel2;
            spc_InputButton.IsSplitterFixed = true;
            spc_InputButton.Location = new System.Drawing.Point(0, 0);
            spc_InputButton.Name = "spc_InputButton";
            // 
            // spc_InputButton.Panel1
            // 
            spc_InputButton.Panel1.Controls.Add(txt_ConfirmPassword);
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
            // ConfirmPasswordField
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(spc_LabelInputs);
            MinimumSize = new System.Drawing.Size(300, 50);
            Name = "ConfirmPasswordField";
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

        private Label lbl_ConfirmPassword;
        private TextBox txt_ConfirmPassword;
        private Button btn_Show;
        internal SplitContainer spc_LabelInputs;
        internal SplitContainer spc_InputButton;
    }
}
