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
		Me.btn_LogIn = New System.Windows.Forms.Button()
		Me.chk_KeepLoggedIn = New System.Windows.Forms.CheckBox()
		Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
		Me.tss_UserFeedback = New System.Windows.Forms.ToolStripStatusLabel()
		Me.bw_SaveSettings = New System.ComponentModel.BackgroundWorker()
		Me.tt_Info = New System.Windows.Forms.ToolTip(Me.components)
		Me.llb_ForgotPassword = New System.Windows.Forms.LinkLabel()
		Me.llb_SignUp = New System.Windows.Forms.LinkLabel()
		Me.LoginFields1 = New SPPBC.M3Tools.LoginFields()
		Me.lf_UserPass = New SPPBC.M3Tools.LoginFields()
		Me.db_Users = New SPPBC.M3Tools.Database.UserDatabase(Me.components)
		Me.ss_Feedback.SuspendLayout()
		Me.SuspendLayout()
		'
		'btn_LogIn
		'
		Me.btn_LogIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btn_LogIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_LogIn.Location = New System.Drawing.Point(107, 205)
		Me.btn_LogIn.Name = "btn_LogIn"
		Me.btn_LogIn.Size = New System.Drawing.Size(76, 27)
		Me.btn_LogIn.TabIndex = 2
		Me.btn_LogIn.Text = "Log In"
		Me.btn_LogIn.UseVisualStyleBackColor = True
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
		Me.chk_KeepLoggedIn.Location = New System.Drawing.Point(47, 150)
		Me.chk_KeepLoggedIn.Name = "chk_KeepLoggedIn"
		Me.chk_KeepLoggedIn.Size = New System.Drawing.Size(119, 23)
		Me.chk_KeepLoggedIn.TabIndex = 1
		Me.chk_KeepLoggedIn.TabStop = False
		Me.chk_KeepLoggedIn.Text = "Remember Me"
		Me.chk_KeepLoggedIn.UseVisualStyleBackColor = False
		'
		'ss_Feedback
		'
		Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UserFeedback})
		Me.ss_Feedback.Location = New System.Drawing.Point(0, 307)
		Me.ss_Feedback.Name = "ss_Feedback"
		Me.ss_Feedback.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.ss_Feedback.Size = New System.Drawing.Size(313, 22)
		Me.ss_Feedback.TabIndex = 5
		Me.ss_Feedback.Text = "StatusStrip1"
		'
		'tss_UserFeedback
		'
		Me.tss_UserFeedback.Name = "tss_UserFeedback"
		Me.tss_UserFeedback.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
		Me.tss_UserFeedback.Size = New System.Drawing.Size(298, 17)
		Me.tss_UserFeedback.Spring = True
		Me.tss_UserFeedback.Text = "Please enter your log-in information"
		'
		'bw_SaveSettings
		'
		'
		'llb_ForgotPassword
		'
		Me.llb_ForgotPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.llb_ForgotPassword.AutoSize = True
		Me.llb_ForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.llb_ForgotPassword.Location = New System.Drawing.Point(152, 264)
		Me.llb_ForgotPassword.Name = "llb_ForgotPassword"
		Me.llb_ForgotPassword.Size = New System.Drawing.Size(129, 20)
		Me.llb_ForgotPassword.TabIndex = 4
		Me.llb_ForgotPassword.TabStop = True
		Me.llb_ForgotPassword.Text = "Forgot Password"
		'
		'llb_SignUp
		'
		Me.llb_SignUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.llb_SignUp.AutoSize = True
		Me.llb_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.llb_SignUp.Location = New System.Drawing.Point(49, 264)
		Me.llb_SignUp.Name = "llb_SignUp"
		Me.llb_SignUp.Size = New System.Drawing.Size(66, 20)
		Me.llb_SignUp.TabIndex = 3
		Me.llb_SignUp.TabStop = True
		Me.llb_SignUp.Text = "Sign Up"
		'
		'LoginFields1
		'
		Me.LoginFields1.AutoSize = True
		Me.LoginFields1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.LoginFields1.BackColor = System.Drawing.Color.Transparent
		Me.LoginFields1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
		Me.LoginFields1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LoginFields1.Location = New System.Drawing.Point(-79, 45)
		Me.LoginFields1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
		Me.LoginFields1.Name = "LoginFields1"
		Me.LoginFields1.Padding = New System.Windows.Forms.Padding(20, 19, 20, 19)
		Me.LoginFields1.Password = ""
		Me.LoginFields1.Size = New System.Drawing.Size(40, 38)
		Me.LoginFields1.TabIndex = 11
		Me.LoginFields1.Username = ""
		'
		'lf_UserPass
		'
		Me.lf_UserPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lf_UserPass.AutoSize = True
		Me.lf_UserPass.BackColor = System.Drawing.Color.Transparent
		Me.lf_UserPass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lf_UserPass.Location = New System.Drawing.Point(38, 14)
		Me.lf_UserPass.Name = "lf_UserPass"
		Me.lf_UserPass.Padding = New System.Windows.Forms.Padding(10)
		Me.lf_UserPass.Password = ""
		Me.lf_UserPass.Size = New System.Drawing.Size(237, 159)
		Me.lf_UserPass.TabIndex = 0
		Me.lf_UserPass.Username = ""
		'
		'db_Users
		'
		Me.db_Users.InitialCatalog = Global.MediaMinistry.MySettings.Default.DefaultCatalog
		Me.db_Users.Password = Global.MediaMinistry.MySettings.Default.DefaultPassword
		Me.db_Users.Username = Global.MediaMinistry.MySettings.Default.DefaultUsername
		'
		'Frm_Login
		'
		Me.AcceptButton = Me.btn_LogIn
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(313, 329)
		Me.Controls.Add(Me.LoginFields1)
		Me.Controls.Add(Me.llb_SignUp)
		Me.Controls.Add(Me.llb_ForgotPassword)
		Me.Controls.Add(Me.ss_Feedback)
		Me.Controls.Add(Me.chk_KeepLoggedIn)
		Me.Controls.Add(Me.btn_LogIn)
		Me.Controls.Add(Me.lf_UserPass)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Frm_Login"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.ss_Feedback.ResumeLayout(False)
		Me.ss_Feedback.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn_LogIn As Button
	Friend WithEvents chk_KeepLoggedIn As CheckBox
	Friend WithEvents ss_Feedback As StatusStrip
	Friend WithEvents tss_UserFeedback As ToolStripStatusLabel
	Friend WithEvents bw_SaveSettings As System.ComponentModel.BackgroundWorker
	Friend WithEvents tt_Info As ToolTip
	Friend WithEvents db_Users As SPPBC.M3Tools.Database.UserDatabase
	Friend WithEvents llb_ForgotPassword As LinkLabel
	Friend WithEvents LoginFields1 As SPPBC.M3Tools.LoginFields
	Friend WithEvents lf_UserPass As SPPBC.M3Tools.LoginFields
	Friend WithEvents llb_SignUp As LinkLabel
End Class
