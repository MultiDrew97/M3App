using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            bw_SaveSettings = new System.ComponentModel.BackgroundWorker();
            bw_SaveSettings.DoWork += new System.ComponentModel.DoWorkEventHandler(SaveSettings);
            bw_SaveSettings.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(SettingsSaved);
            tt_Info = new ToolTip(components);
            tmr_LoginTimer = new Timer(components);
            tmr_LoginTimer.Tick += new EventHandler(TimerTicking);
            tss_UserFeedback = new ToolStripStatusLabel();
            ss_Feedback = new StatusStrip();
            llb_ForgotPassword = new LinkLabel();
            llb_ForgotPassword.LinkClicked += new LinkLabelLinkClickedEventHandler(ForgotPassword);
            llb_SignUp = new LinkLabel();
            llb_SignUp.LinkClicked += new LinkLabelLinkClickedEventHandler(NewUser);
            llb_SignUp.LinkClicked += new LinkLabelLinkClickedEventHandler(CreateAccount);
            chk_KeepLoggedIn = new CheckBox();
            btn_Login = new Button();
            btn_Login.Click += new EventHandler(PerformLogin);
            lf_Login = new SPPBC.M3Tools.LoginFields();
            dbUsers = new UserDatabase(components);
            lsd_LoadScreen = new SPPBC.M3Tools.LoadScreenDialog();
            ss_Feedback.SuspendLayout();
            SuspendLayout();
            // 
            // bw_SaveSettings
            // 
            // 
            // tmr_LoginTimer
            // 
            tmr_LoginTimer.Interval = 10000;
            // 
            // tss_UserFeedback
            // 
            tss_UserFeedback.Name = "tss_UserFeedback";
            tss_UserFeedback.Overflow = ToolStripItemOverflow.Never;
            tss_UserFeedback.Size = new Size(369, 17);
            tss_UserFeedback.Spring = true;
            tss_UserFeedback.Text = "Please enter your log-in information";
            // 
            // ss_Feedback
            // 
            ss_Feedback.Items.AddRange(new ToolStripItem[] { tss_UserFeedback });
            ss_Feedback.Location = new Point(0, 307);
            ss_Feedback.Name = "ss_Feedback";
            ss_Feedback.RenderMode = ToolStripRenderMode.Professional;
            ss_Feedback.Size = new Size(384, 22);
            ss_Feedback.TabIndex = 5;
            ss_Feedback.Text = "StatusStrip1";
            // 
            // llb_ForgotPassword
            // 
            llb_ForgotPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            llb_ForgotPassword.AutoSize = true;
            llb_ForgotPassword.Enabled = false;
            llb_ForgotPassword.Font = new Font("Microsoft Sans Serif", 12.0f);
            llb_ForgotPassword.Location = new Point(53, 267);
            llb_ForgotPassword.Name = "llb_ForgotPassword";
            llb_ForgotPassword.Size = new Size(129, 20);
            llb_ForgotPassword.TabIndex = 3;
            llb_ForgotPassword.TabStop = true;
            llb_ForgotPassword.Text = "Forgot Password";
            llb_ForgotPassword.Visible = false;
            // 
            // llb_SignUp
            // 
            llb_SignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            llb_SignUp.AutoSize = true;
            llb_SignUp.Enabled = false;
            llb_SignUp.Font = new Font("Microsoft Sans Serif", 12.0f);
            llb_SignUp.Location = new Point(231, 268);
            llb_SignUp.Name = "llb_SignUp";
            llb_SignUp.Size = new Size(66, 20);
            llb_SignUp.TabIndex = 4;
            llb_SignUp.TabStop = true;
            llb_SignUp.Text = "Sign Up";
            llb_SignUp.Visible = false;
            // 
            // chk_KeepLoggedIn
            // 
            chk_KeepLoggedIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            chk_KeepLoggedIn.AutoSize = true;
            chk_KeepLoggedIn.BackColor = Color.Transparent;
            chk_KeepLoggedIn.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_KeepLoggedIn.ForeColor = SystemColors.ControlText;
            chk_KeepLoggedIn.Location = new Point(57, 158);
            chk_KeepLoggedIn.Name = "chk_KeepLoggedIn";
            chk_KeepLoggedIn.Size = new Size(119, 23);
            chk_KeepLoggedIn.TabIndex = 1;
            chk_KeepLoggedIn.TabStop = false;
            chk_KeepLoggedIn.Text = "Remember Me";
            chk_KeepLoggedIn.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            btn_Login.FlatStyle = FlatStyle.System;
            btn_Login.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(155, 221);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(76, 29);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // lf_Login
            // 
            lf_Login.AutoSize = true;
            lf_Login.BackColor = Color.Transparent;
            lf_Login.ForeColor = SystemColors.ControlText;
            lf_Login.Location = new Point(32, 20);
            lf_Login.MinimumSize = new Size(320, 130);
            lf_Login.Name = "lf_Login";
            lf_Login.Padding = new Padding(10);
            lf_Login.Password = null;
            lf_Login.Size = new Size(320, 144);
            lf_Login.TabIndex = 0;
            lf_Login.Username = null;
            // 
            // dbUsers
            // 
            dbUsers.BaseUrl = My.MySettings.Default.BaseUrl;
            dbUsers.Password = My.MySettings.Default.ApiPassword;
            dbUsers.Username = My.MySettings.Default.ApiUsername;
            // 
            // lsd_LoadScreen
            // 
            lsd_LoadScreen.Image = (Bitmap)resources.GetObject("lsd_LoadScreen.Image");
            lsd_LoadScreen.LoadText = "";
            lsd_LoadScreen.TopMost = true;
            // 
            // LogOnForm
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(384, 329);
            Controls.Add(llb_ForgotPassword);
            Controls.Add(llb_SignUp);
            Controls.Add(chk_KeepLoggedIn);
            Controls.Add(btn_Login);
            Controls.Add(lf_Login);
            Controls.Add(ss_Feedback);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogOnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ss_Feedback.ResumeLayout(false);
            ss_Feedback.PerformLayout();
            Shown += new EventHandler(Showing);
            Closing += new System.ComponentModel.CancelEventHandler(LoginClosing);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.ComponentModel.BackgroundWorker bw_SaveSettings;
        internal ToolTip tt_Info;
        internal SPPBC.M3Tools.Database.UserDatabase dbUsers;
        internal Timer tmr_LoginTimer;
        internal ToolStripStatusLabel tss_UserFeedback;
        internal StatusStrip ss_Feedback;
        internal SPPBC.M3Tools.LoadScreenDialog lsd_LoadScreen;
        internal LinkLabel llb_ForgotPassword;
        internal LinkLabel llb_SignUp;
        internal CheckBox chk_KeepLoggedIn;
        internal Button btn_Login;
        internal SPPBC.M3Tools.LoginFields lf_Login;
    }
}
