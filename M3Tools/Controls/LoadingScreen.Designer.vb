<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
		Me.tmr_Timer = New System.Windows.Forms.Timer(Me.components)
		Me.lbl_LoadText = New System.Windows.Forms.Label()
		Me.btn_Close = New System.Windows.Forms.Button()
		Me.pic_Load = New System.Windows.Forms.PictureBox()
		CType(Me.pic_Load, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tmr_Timer
		'
		Me.tmr_Timer.Interval = 10
		'
		'lbl_LoadText
		'
		Me.lbl_LoadText.BackColor = System.Drawing.SystemColors.Control
		Me.lbl_LoadText.Location = New System.Drawing.Point(7, 80)
		Me.lbl_LoadText.Name = "lbl_LoadText"
		Me.lbl_LoadText.Size = New System.Drawing.Size(190, 103)
		Me.lbl_LoadText.TabIndex = 1
		Me.lbl_LoadText.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lbl_LoadText.UseWaitCursor = True
		'
		'btn_Close
		'
		Me.btn_Close.Enabled = False
		Me.btn_Close.Location = New System.Drawing.Point(61, 198)
		Me.btn_Close.Name = "btn_Close"
		Me.btn_Close.Size = New System.Drawing.Size(83, 20)
		Me.btn_Close.TabIndex = 2
		Me.btn_Close.Text = "Ok"
		Me.btn_Close.UseVisualStyleBackColor = True
		Me.btn_Close.UseWaitCursor = True
		Me.btn_Close.Visible = False
		'
		'pic_Load
		'
		Me.pic_Load.Image = Global.SPPBC.M3Tools.My.Resources.Resources.Loading_Loop_3
		Me.pic_Load.Location = New System.Drawing.Point(74, 9)
		Me.pic_Load.Name = "pic_Load"
		Me.pic_Load.Size = New System.Drawing.Size(56, 58)
		Me.pic_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pic_Load.TabIndex = 3
		Me.pic_Load.TabStop = False
		Me.pic_Load.UseWaitCursor = True
		'
		'LoadingScreen
		'
		Me.AcceptButton = Me.btn_Close
		Me.ClientSize = New System.Drawing.Size(201, 222)
		Me.ControlBox = False
		Me.Controls.Add(Me.pic_Load)
		Me.Controls.Add(Me.btn_Close)
		Me.Controls.Add(Me.lbl_LoadText)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "LoadingScreen"
		Me.Opacity = 0.75R
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.TopMost = True
		CType(Me.pic_Load, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents tmr_Timer As Windows.Forms.Timer
	Friend WithEvents lbl_LoadText As Windows.Forms.Label
	Friend WithEvents btn_Close As Windows.Forms.Button
	Friend WithEvents pic_Load As Windows.Forms.PictureBox
End Class
