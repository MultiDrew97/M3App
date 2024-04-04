using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;

namespace M3App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bw_SaveSettings = new System.ComponentModel.BackgroundWorker();
            this.tt_Info = new System.Windows.Forms.ToolTip(this.components);
            this.tmr_LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.tss_UserFeedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_Feedback = new System.Windows.Forms.StatusStrip();
            this.llb_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llb_SignUp = new System.Windows.Forms.LinkLabel();
            this.chk_KeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lf_Login = new SPPBC.M3Tools.LoginFields();
            this.dbUsers = new SPPBC.M3Tools.Database.UserDatabase(this.components);
            this.lsd_LoadScreen = new SPPBC.M3Tools.LoadScreenDialog();
            this.SuspendLayout();
            // 
            // bw_SaveSettings
            // 
            this.bw_SaveSettings.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveSettings);
            this.bw_SaveSettings.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SettingsSaved);
            // 
            // tmr_LoginTimer
            // 
            this.tmr_LoginTimer.Interval = 10000;
            this.tmr_LoginTimer.Tick += new System.EventHandler(this.TimerTicking);
            // 
            // tss_UserFeedback
            // 
            this.tss_UserFeedback.Name = "tss_UserFeedback";
            this.tss_UserFeedback.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tss_UserFeedback.Size = new System.Drawing.Size(553, 17);
            this.tss_UserFeedback.Spring = true;
            this.tss_UserFeedback.Text = "Please enter your log-in information";
            // 
            // ss_Feedback
            // 
            this.ss_Feedback.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_Feedback.Location = new System.Drawing.Point(0, 484);
            this.ss_Feedback.Name = "ss_Feedback";
            this.ss_Feedback.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss_Feedback.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_Feedback.Size = new System.Drawing.Size(576, 22);
            this.ss_Feedback.TabIndex = 5;
            this.ss_Feedback.Text = "StatusStrip1";
            // 
            // llb_ForgotPassword
            // 
            this.llb_ForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_ForgotPassword.AutoSize = true;
            this.llb_ForgotPassword.Enabled = false;
            this.llb_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llb_ForgotPassword.Location = new System.Drawing.Point(80, 411);
            this.llb_ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_ForgotPassword.Name = "llb_ForgotPassword";
            this.llb_ForgotPassword.Size = new System.Drawing.Size(129, 20);
            this.llb_ForgotPassword.TabIndex = 3;
            this.llb_ForgotPassword.TabStop = true;
            this.llb_ForgotPassword.Text = "Forgot Password";
            this.llb_ForgotPassword.Visible = false;
            this.llb_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassword);
            // 
            // llb_SignUp
            // 
            this.llb_SignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_SignUp.AutoSize = true;
            this.llb_SignUp.Enabled = false;
            this.llb_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llb_SignUp.Location = new System.Drawing.Point(346, 412);
            this.llb_SignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_SignUp.Name = "llb_SignUp";
            this.llb_SignUp.Size = new System.Drawing.Size(66, 20);
            this.llb_SignUp.TabIndex = 4;
            this.llb_SignUp.TabStop = true;
            this.llb_SignUp.Text = "Sign Up";
            this.llb_SignUp.Visible = false;
            this.llb_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccount);
            // 
            // chk_KeepLoggedIn
            // 
            this.chk_KeepLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_KeepLoggedIn.AutoSize = true;
            this.chk_KeepLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.chk_KeepLoggedIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_KeepLoggedIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_KeepLoggedIn.Location = new System.Drawing.Point(86, 243);
            this.chk_KeepLoggedIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_KeepLoggedIn.Name = "chk_KeepLoggedIn";
            this.chk_KeepLoggedIn.Size = new System.Drawing.Size(119, 23);
            this.chk_KeepLoggedIn.TabIndex = 1;
            this.chk_KeepLoggedIn.TabStop = false;
            this.chk_KeepLoggedIn.Text = "Remember Me";
            this.chk_KeepLoggedIn.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(232, 340);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 45);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.PerformLogin);
            // 
            // lf_Login
            // 
            this.lf_Login.AutoSize = true;
            this.lf_Login.BackColor = System.Drawing.Color.Transparent;
            this.lf_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lf_Login.Location = new System.Drawing.Point(48, 31);
            this.lf_Login.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lf_Login.MinimumSize = new System.Drawing.Size(480, 200);
            this.lf_Login.Name = "lf_Login";
            this.lf_Login.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.lf_Login.Password = null;
            this.lf_Login.Size = new System.Drawing.Size(480, 222);
            this.lf_Login.TabIndex = 0;
            this.lf_Login.Username = null;
            // 
            // dbUsers
            // 
            this.dbUsers.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            this.dbUsers.Password = global::M3App.My.Settings.Default.ApiPassword;
            this.dbUsers.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // lsd_LoadScreen
            // 
            this.lsd_LoadScreen.Image = ((System.Drawing.Bitmap)(resources.GetObject("lsd_LoadScreen.Image")));
            this.lsd_LoadScreen.LoadText = "";
            this.lsd_LoadScreen.TopMost = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(576, 506);
            this.Controls.Add(this.llb_ForgotPassword);
            this.Controls.Add(this.llb_SignUp);
            this.Controls.Add(this.chk_KeepLoggedIn);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lf_Login);
            this.Controls.Add(this.ss_Feedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ministry Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

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
