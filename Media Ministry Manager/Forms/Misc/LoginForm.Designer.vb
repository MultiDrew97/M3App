<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
		Me.bw_SaveSettings = New System.ComponentModel.BackgroundWorker()
		Me.tt_Info = New System.Windows.Forms.ToolTip(Me.components)
		Me.tmr_LoginTimer = New System.Windows.Forms.Timer(Me.components)
		Me.tss_UserFeedback = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
		Me.dbUsers = New SPPBC.M3Tools.Database.UserDatabase(Me.components)
		Me.lsd_LoadScreen = New SPPBC.M3Tools.LoadScreenDialog()
		Me.llb_ForgotPassword = New System.Windows.Forms.LinkLabel()
		Me.llb_SignUp = New System.Windows.Forms.LinkLabel()
		Me.chk_KeepLoggedIn = New System.Windows.Forms.CheckBox()
		Me.btn_Login = New System.Windows.Forms.Button()
		Me.lf_Login = New SPPBC.M3Tools.LoginFields()
		Me.ss_Feedback.SuspendLayout()
		Me.SuspendLayout()
		'
		'bw_SaveSettings
		'
		'
		'tmr_LoginTimer
		'
		Me.tmr_LoginTimer.Interval = 10000
		'
		'tss_UserFeedback
		'
		Me.tss_UserFeedback.Name = "tss_UserFeedback"
		Me.tss_UserFeedback.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
		Me.tss_UserFeedback.Size = New System.Drawing.Size(369, 17)
		Me.tss_UserFeedback.Spring = True
		Me.tss_UserFeedback.Text = "Please enter your log-in information"
		'
		'ss_Feedback
		'
		Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UserFeedback})
		Me.ss_Feedback.Location = New System.Drawing.Point(0, 307)
		Me.ss_Feedback.Name = "ss_Feedback"
		Me.ss_Feedback.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.ss_Feedback.Size = New System.Drawing.Size(384, 22)
		Me.ss_Feedback.TabIndex = 5
		Me.ss_Feedback.Text = "StatusStrip1"
		'
		'dbUsers
		'
		Me.dbUsers.InitialCatalog = Global.MediaMinistry.My.MySettings.Default.DefaultCatalog
		Me.dbUsers.Password = Global.MediaMinistry.My.MySettings.Default.DefaultPassword
		Me.dbUsers.Username = Global.MediaMinistry.My.MySettings.Default.DefaultUsername
		'
		'lsd_LoadScreen
		'
		Me.lsd_LoadScreen.Image = CType(resources.GetObject("lsd_LoadScreen.Image"), System.Drawing.Bitmap)
		Me.lsd_LoadScreen.LoadText = ""
		'
		'llb_ForgotPassword
		'
		Me.llb_ForgotPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.llb_ForgotPassword.AutoSize = True
		Me.llb_ForgotPassword.Enabled = False
		Me.llb_ForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.llb_ForgotPassword.Location = New System.Drawing.Point(53, 267)
		Me.llb_ForgotPassword.Name = "llb_ForgotPassword"
		Me.llb_ForgotPassword.Size = New System.Drawing.Size(129, 20)
		Me.llb_ForgotPassword.TabIndex = 9
		Me.llb_ForgotPassword.TabStop = True
		Me.llb_ForgotPassword.Text = "Forgot Password"
		Me.llb_ForgotPassword.Visible = False
		'
		'llb_SignUp
		'
		Me.llb_SignUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.llb_SignUp.AutoSize = True
		Me.llb_SignUp.Enabled = False
		Me.llb_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.llb_SignUp.Location = New System.Drawing.Point(231, 268)
		Me.llb_SignUp.Name = "llb_SignUp"
		Me.llb_SignUp.Size = New System.Drawing.Size(66, 20)
		Me.llb_SignUp.TabIndex = 8
		Me.llb_SignUp.TabStop = True
		Me.llb_SignUp.Text = "Sign Up"
		Me.llb_SignUp.Visible = False
		'
		'chk_KeepLoggedIn
		'
		Me.chk_KeepLoggedIn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.chk_KeepLoggedIn.AutoSize = True
		Me.chk_KeepLoggedIn.BackColor = System.Drawing.Color.Transparent
		Me.chk_KeepLoggedIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chk_KeepLoggedIn.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk_KeepLoggedIn.Location = New System.Drawing.Point(57, 158)
		Me.chk_KeepLoggedIn.Name = "chk_KeepLoggedIn"
		Me.chk_KeepLoggedIn.Size = New System.Drawing.Size(119, 23)
		Me.chk_KeepLoggedIn.TabIndex = 6
		Me.chk_KeepLoggedIn.TabStop = False
		Me.chk_KeepLoggedIn.Text = "Remember Me"
		Me.chk_KeepLoggedIn.UseVisualStyleBackColor = False
		'
		'btn_Login
		'
		Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btn_Login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Login.Location = New System.Drawing.Point(155, 221)
		Me.btn_Login.Name = "btn_Login"
		Me.btn_Login.Size = New System.Drawing.Size(76, 29)
		Me.btn_Login.TabIndex = 7
		Me.btn_Login.Text = "Log In"
		Me.btn_Login.UseVisualStyleBackColor = True
		'
		'lf_Login
		'
		Me.lf_Login.AutoSize = True
		Me.lf_Login.BackColor = System.Drawing.Color.Transparent
		Me.lf_Login.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lf_Login.Location = New System.Drawing.Point(32, 20)
		Me.lf_Login.MinimumSize = New System.Drawing.Size(320, 130)
		Me.lf_Login.Name = "lf_Login"
		Me.lf_Login.Padding = New System.Windows.Forms.Padding(10)
		Me.lf_Login.Password = Nothing
		Me.lf_Login.Size = New System.Drawing.Size(320, 144)
		Me.lf_Login.TabIndex = 10
		Me.lf_Login.Username = Nothing
		'
		'Frm_Login
		'
		Me.AcceptButton = Me.btn_Login
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(384, 329)
		Me.Controls.Add(Me.llb_ForgotPassword)
		Me.Controls.Add(Me.llb_SignUp)
		Me.Controls.Add(Me.chk_KeepLoggedIn)
		Me.Controls.Add(Me.btn_Login)
		Me.Controls.Add(Me.lf_Login)
		Me.Controls.Add(Me.ss_Feedback)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Frm_Login"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.TopMost = True
		Me.ss_Feedback.ResumeLayout(False)
		Me.ss_Feedback.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents bw_SaveSettings As System.ComponentModel.BackgroundWorker
    Friend WithEvents tt_Info As ToolTip
    Friend WithEvents dbUsers As SPPBC.M3Tools.Database.UserDatabase
	Friend WithEvents tmr_LoginTimer As Timer
	Friend WithEvents tss_UserFeedback As ToolStripStatusLabel
    Friend WithEvents ss_Feedback As StatusStrip
	Friend WithEvents lsd_LoadScreen As SPPBC.M3Tools.LoadScreenDialog
	Friend WithEvents llb_ForgotPassword As LinkLabel
	Friend WithEvents llb_SignUp As LinkLabel
	Friend WithEvents chk_KeepLoggedIn As CheckBox
	Friend WithEvents btn_Login As Button
	Friend WithEvents lf_Login As SPPBC.M3Tools.LoginFields
End Class
