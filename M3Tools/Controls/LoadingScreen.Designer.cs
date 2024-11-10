using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoadingScreen : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
			this.lbl_LoadText = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.pic_Load = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Load)).BeginInit();
			this.SuspendLayout();
			// 
			// tmr_Timer
			// 
			this.tmr_Timer.Interval = 10;
			this.tmr_Timer.Tick += new System.EventHandler(this.TimerTicking);
			// 
			// lbl_LoadText
			// 
			this.lbl_LoadText.BackColor = System.Drawing.SystemColors.Control;
			this.lbl_LoadText.Location = new System.Drawing.Point(7, 80);
			this.lbl_LoadText.Name = "lbl_LoadText";
			this.lbl_LoadText.Size = new System.Drawing.Size(190, 103);
			this.lbl_LoadText.TabIndex = 1;
			this.lbl_LoadText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_LoadText.UseWaitCursor = true;
			// 
			// btn_Close
			// 
			this.btn_Close.Enabled = false;
			this.btn_Close.Location = new System.Drawing.Point(61, 198);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(83, 20);
			this.btn_Close.TabIndex = 2;
			this.btn_Close.Text = "Ok";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.UseWaitCursor = true;
			this.btn_Close.Visible = false;
			this.btn_Close.Click += new System.EventHandler(this.CloseScreen);
			// 
			// pic_Load
			// 
			this.pic_Load.ErrorImage = global::SPPBC.M3Tools.Properties.Resources.ErrorImage;
			this.pic_Load.Image = global::SPPBC.M3Tools.Properties.Resources.Loading_Loop_3;
			this.pic_Load.InitialImage = global::SPPBC.M3Tools.Properties.Resources.Loading_Loop_3;
			this.pic_Load.Location = new System.Drawing.Point(74, 9);
			this.pic_Load.Name = "pic_Load";
			this.pic_Load.Size = new System.Drawing.Size(56, 58);
			this.pic_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Load.TabIndex = 3;
			this.pic_Load.TabStop = false;
			this.pic_Load.UseWaitCursor = true;
			// 
			// LoadingScreen
			// 
			this.AcceptButton = this.btn_Close;
			this.ClientSize = new System.Drawing.Size(189, 210);
			this.ControlBox = false;
			this.Controls.Add(this.pic_Load);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.lbl_LoadText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoadingScreen";
			this.Opacity = 0.75D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pic_Load)).EndInit();
			this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Timer tmr_Timer;
        internal System.Windows.Forms.Label lbl_LoadText;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.PictureBox pic_Load;
    }
}
