using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.API;

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
			this.tt_Info = new System.Windows.Forms.ToolTip(this.components);
			this.tss_UserFeedback = new System.Windows.Forms.ToolStripStatusLabel();
			this.llb_ForgotPassword = new System.Windows.Forms.LinkLabel();
			this.llb_SignUp = new System.Windows.Forms.LinkLabel();
			this.chk_KeepLoggedIn = new System.Windows.Forms.CheckBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.ss_Feedback = new System.Windows.Forms.StatusStrip();
			this.pnl_Loading = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lf_Login = new SPPBC.M3Tools.LoginFields();
			this.dbUsers = new SPPBC.M3Tools.API.UserDatabase(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pnl_Loading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tss_UserFeedback
			// 
			this.tss_UserFeedback.Name = "tss_UserFeedback";
			this.tss_UserFeedback.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.tss_UserFeedback.Size = new System.Drawing.Size(553, 17);
			this.tss_UserFeedback.Spring = true;
			this.tss_UserFeedback.Text = "Please enter your log-in information";
			// 
			// llb_ForgotPassword
			// 
			this.llb_ForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.llb_ForgotPassword.AutoSize = true;
			this.llb_ForgotPassword.Enabled = false;
			this.llb_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.llb_ForgotPassword.Location = new System.Drawing.Point(53, 267);
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
			this.llb_SignUp.Location = new System.Drawing.Point(231, 268);
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
			this.chk_KeepLoggedIn.Location = new System.Drawing.Point(57, 158);
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
			this.btn_Login.Location = new System.Drawing.Point(155, 221);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(76, 29);
			this.btn_Login.TabIndex = 2;
			this.btn_Login.Text = "Log In";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.PerformLogin);
			// 
			// ss_Feedback
			// 
			this.ss_Feedback.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.ss_Feedback.Location = new System.Drawing.Point(0, 307);
			this.ss_Feedback.Name = "ss_Feedback";
			this.ss_Feedback.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ss_Feedback.Size = new System.Drawing.Size(384, 22);
			this.ss_Feedback.TabIndex = 5;
			this.ss_Feedback.Text = "StatusStrip1";
			// 
			// pnl_Loading
			// 
			this.pnl_Loading.Controls.Add(this.button1);
			this.pnl_Loading.Controls.Add(this.pictureBox1);
			this.pnl_Loading.Location = new System.Drawing.Point(92, 77);
			this.pnl_Loading.Name = "pnl_Loading";
			this.pnl_Loading.Size = new System.Drawing.Size(200, 175);
			this.pnl_Loading.TabIndex = 6;
			this.pnl_Loading.UseWaitCursor = true;
			this.pnl_Loading.Visible = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(63, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.UseWaitCursor = true;
			this.button1.Click += new System.EventHandler(this.CancelLogin);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = global::M3App.Properties.Resources.Error;
			this.pictureBox1.Image = global::M3App.Properties.Resources.Loading_Loop_3;
			this.pictureBox1.InitialImage = global::M3App.Properties.Resources.Loading_Loop_3;
			this.pictureBox1.Location = new System.Drawing.Point(73, 37);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 100);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.UseWaitCursor = true;
			// 
			// lf_Login
			// 
			this.lf_Login.AutoSize = true;
			this.lf_Login.BackColor = System.Drawing.Color.Transparent;
			this.lf_Login.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lf_Login.Location = new System.Drawing.Point(32, 20);
			this.lf_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lf_Login.MinimumSize = new System.Drawing.Size(320, 130);
			this.lf_Login.Name = "lf_Login";
			this.lf_Login.Padding = new System.Windows.Forms.Padding(10);
			this.lf_Login.Password = "";
			this.lf_Login.Size = new System.Drawing.Size(320, 144);
			this.lf_Login.TabIndex = 0;
			this.lf_Login.Username = "";
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btn_Login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(384, 329);
			this.Controls.Add(this.pnl_Loading);
			this.Controls.Add(this.llb_ForgotPassword);
			this.Controls.Add(this.llb_SignUp);
			this.Controls.Add(this.chk_KeepLoggedIn);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.lf_Login);
			this.Controls.Add(this.ss_Feedback);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Media Ministry Manager";
			this.pnl_Loading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        internal ToolTip tt_Info;
        internal SPPBC.M3Tools.API.UserDatabase dbUsers;
        internal ToolStripStatusLabel tss_UserFeedback;
        internal LinkLabel llb_ForgotPassword;
        internal LinkLabel llb_SignUp;
        internal CheckBox chk_KeepLoggedIn;
        internal Button btn_Login;
        internal SPPBC.M3Tools.LoginFields lf_Login;
		internal StatusStrip ss_Feedback;
		private Panel pnl_Loading;
		private PictureBox pictureBox1;
		private Button button1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
