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
            components = new System.ComponentModel.Container();
            tmr_Timer = new System.Windows.Forms.Timer(components);
            tmr_Timer.Tick += new EventHandler(TimerTicking);
            lbl_LoadText = new System.Windows.Forms.Label();
            btn_Close = new System.Windows.Forms.Button();
            btn_Close.Click += new EventHandler(CloseScreen);
            pic_Load = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Load).BeginInit();
            SuspendLayout();
            // 
            // tmr_Timer
            // 
            tmr_Timer.Interval = 10;
            // 
            // lbl_LoadText
            // 
            lbl_LoadText.BackColor = System.Drawing.SystemColors.Control;
            lbl_LoadText.Location = new System.Drawing.Point(7, 80);
            lbl_LoadText.Name = "lbl_LoadText";
            lbl_LoadText.Size = new System.Drawing.Size(190, 103);
            lbl_LoadText.TabIndex = 1;
            lbl_LoadText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lbl_LoadText.UseWaitCursor = true;
            // 
            // btn_Close
            // 
            btn_Close.Enabled = false;
            btn_Close.Location = new System.Drawing.Point(61, 198);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new System.Drawing.Size(83, 20);
            btn_Close.TabIndex = 2;
            btn_Close.Text = "Ok";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.UseWaitCursor = true;
            btn_Close.Visible = false;
            // 
            // pic_Load
            // 
            pic_Load.Image = My.Resources.Resources.Loading_Loop_3;
            pic_Load.Location = new System.Drawing.Point(74, 9);
            pic_Load.Name = "pic_Load";
            pic_Load.Size = new System.Drawing.Size(56, 58);
            pic_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_Load.TabIndex = 3;
            pic_Load.TabStop = false;
            pic_Load.UseWaitCursor = true;
            // 
            // LoadingScreen
            // 
            AcceptButton = btn_Close;
            ClientSize = new System.Drawing.Size(193, 214);
            ControlBox = false;
            Controls.Add(pic_Load);
            Controls.Add(btn_Close);
            Controls.Add(lbl_LoadText);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            Opacity = 0.75d;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pic_Load).EndInit();
            ClosableChanged += new EventHandler(LoadingScreen_ClosableChanged);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.Timer tmr_Timer;
        internal System.Windows.Forms.Label lbl_LoadText;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.PictureBox pic_Load;
    }
}