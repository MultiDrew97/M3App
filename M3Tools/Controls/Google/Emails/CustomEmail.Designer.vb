<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomEmail
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.tsc_BodyContainer = New System.Windows.Forms.ToolStripContainer()
        Me.txt_Body = New System.Windows.Forms.TextBox()
        Me.rtb_Body = New System.Windows.Forms.RichTextBox()
        Me.ts_TextButtons = New System.Windows.Forms.ToolStrip()
        Me.btn_Bold = New System.Windows.Forms.ToolStripButton()
        Me.btn_Underline = New System.Windows.Forms.ToolStripButton()
        Me.btn_Italics = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.ShortcutKeyStrip = New System.Windows.Forms.MenuStrip()
        Me.Bold = New System.Windows.Forms.ToolStripMenuItem()
        Me.Underline = New System.Windows.Forms.ToolStripMenuItem()
        Me.Italics = New System.Windows.Forms.ToolStripMenuItem()
        Me.fd_Font = New System.Windows.Forms.FontDialog()
        Me.sc_CustomComp = New System.Windows.Forms.SplitContainer()
        Me.txt_Subject = New System.Windows.Forms.TextBox()
        Me.tsc_BodyContainer.ContentPanel.SuspendLayout()
        Me.tsc_BodyContainer.TopToolStripPanel.SuspendLayout()
        Me.tsc_BodyContainer.SuspendLayout()
        Me.ts_TextButtons.SuspendLayout()
        Me.ShortcutKeyStrip.SuspendLayout()
        CType(Me.sc_CustomComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc_CustomComp.Panel1.SuspendLayout()
        Me.sc_CustomComp.Panel2.SuspendLayout()
        Me.sc_CustomComp.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsc_BodyContainer
        '
        Me.tsc_BodyContainer.BottomToolStripPanelVisible = False
        '
        'tsc_BodyContainer.ContentPanel
        '
        Me.tsc_BodyContainer.ContentPanel.Controls.Add(Me.txt_Body)
        Me.tsc_BodyContainer.ContentPanel.Controls.Add(Me.rtb_Body)
        Me.tsc_BodyContainer.ContentPanel.Size = New System.Drawing.Size(380, 236)
        Me.tsc_BodyContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsc_BodyContainer.LeftToolStripPanelVisible = False
        Me.tsc_BodyContainer.Location = New System.Drawing.Point(10, 10)
        Me.tsc_BodyContainer.Name = "tsc_BodyContainer"
        Me.tsc_BodyContainer.RightToolStripPanelVisible = False
        Me.tsc_BodyContainer.Size = New System.Drawing.Size(380, 236)
        Me.tsc_BodyContainer.TabIndex = 0
        Me.tsc_BodyContainer.Text = "ToolStripContainer2"
        '
        'tsc_BodyContainer.TopToolStripPanel
        '
        Me.tsc_BodyContainer.TopToolStripPanel.Controls.Add(Me.ts_TextButtons)
        Me.tsc_BodyContainer.TopToolStripPanel.Enabled = False
        Me.tsc_BodyContainer.TopToolStripPanelVisible = False
        '
        'txt_Body
        '
        Me.txt_Body.AcceptsReturn = True
        Me.txt_Body.AcceptsTab = True
        Me.txt_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Body.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_Body.Location = New System.Drawing.Point(0, 0)
        Me.txt_Body.Margin = New System.Windows.Forms.Padding(25, 26, 25, 26)
        Me.txt_Body.Multiline = True
        Me.txt_Body.Name = "txt_Body"
        Me.txt_Body.Size = New System.Drawing.Size(380, 236)
        Me.txt_Body.TabIndex = 0
        Me.txt_Body.Text = "Email Body..."
        '
        'rtb_Body
        '
        Me.rtb_Body.Location = New System.Drawing.Point(96, 3)
        Me.rtb_Body.Name = "rtb_Body"
        Me.rtb_Body.Size = New System.Drawing.Size(281, 251)
        Me.rtb_Body.TabIndex = 1
        Me.rtb_Body.TabStop = False
        Me.rtb_Body.Text = ""
        '
        'ts_TextButtons
        '
        Me.ts_TextButtons.AutoSize = False
        Me.ts_TextButtons.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_TextButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_TextButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Bold, Me.btn_Underline, Me.btn_Italics, Me.ToolStripSeparator1, Me.btn_ChangeFont})
        Me.ts_TextButtons.Location = New System.Drawing.Point(6, 0)
        Me.ts_TextButtons.Name = "ts_TextButtons"
        Me.ts_TextButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ts_TextButtons.Size = New System.Drawing.Size(132, 24)
        Me.ts_TextButtons.TabIndex = 0
        '
        'btn_Bold
        '
        Me.btn_Bold.BackColor = System.Drawing.Color.Transparent
        Me.btn_Bold.CheckOnClick = True
        Me.btn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Bold.Image = Global.SPPBC.M3Tools.My.Resources.Resources.BoldOption
        Me.btn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Bold.Name = "btn_Bold"
        Me.btn_Bold.Size = New System.Drawing.Size(23, 21)
        Me.btn_Bold.Text = "Bold"
        '
        'btn_Underline
        '
        Me.btn_Underline.CheckOnClick = True
        Me.btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Underline.Image = Global.SPPBC.M3Tools.My.Resources.Resources.UnderlineOption
        Me.btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Underline.Name = "btn_Underline"
        Me.btn_Underline.Size = New System.Drawing.Size(23, 21)
        Me.btn_Underline.Text = "Underline"
        '
        'btn_Italics
        '
        Me.btn_Italics.CheckOnClick = True
        Me.btn_Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Italics.Image = Global.SPPBC.M3Tools.My.Resources.Resources.ItalicOption
        Me.btn_Italics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Italics.Name = "btn_Italics"
        Me.btn_Italics.Size = New System.Drawing.Size(23, 21)
        Me.btn_Italics.Text = "Italics"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 24)
        '
        'btn_ChangeFont
        '
        Me.btn_ChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ChangeFont.Image = Global.SPPBC.M3Tools.My.Resources.Resources.FontOption
        Me.btn_ChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ChangeFont.Name = "btn_ChangeFont"
        Me.btn_ChangeFont.Size = New System.Drawing.Size(23, 21)
        Me.btn_ChangeFont.Text = "Change Font"
        '
        'ShortcutKeyStrip
        '
        Me.ShortcutKeyStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ShortcutKeyStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ShortcutKeyStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bold, Me.Underline, Me.Italics})
        Me.ShortcutKeyStrip.Location = New System.Drawing.Point(200, 3)
        Me.ShortcutKeyStrip.Name = "ShortcutKeyStrip"
        Me.ShortcutKeyStrip.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.ShortcutKeyStrip.Size = New System.Drawing.Size(167, 24)
        Me.ShortcutKeyStrip.TabIndex = 1
        Me.ShortcutKeyStrip.Text = "MenuStrip1"
        Me.ShortcutKeyStrip.Visible = False
        '
        'Bold
        '
        Me.Bold.Name = "Bold"
        Me.Bold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Bold.Size = New System.Drawing.Size(43, 22)
        Me.Bold.Text = "Bold"
        '
        'Underline
        '
        Me.Underline.Name = "Underline"
        Me.Underline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.Underline.Size = New System.Drawing.Size(70, 22)
        Me.Underline.Text = "Underline"
        '
        'Italics
        '
        Me.Italics.Name = "Italics"
        Me.Italics.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Italics.Size = New System.Drawing.Size(49, 22)
        Me.Italics.Text = "Italics"
        '
        'fd_Font
        '
        Me.fd_Font.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sc_CustomComp
        '
        Me.sc_CustomComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc_CustomComp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.sc_CustomComp.IsSplitterFixed = True
        Me.sc_CustomComp.Location = New System.Drawing.Point(0, 0)
        Me.sc_CustomComp.Name = "sc_CustomComp"
        Me.sc_CustomComp.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sc_CustomComp.Panel1
        '
        Me.sc_CustomComp.Panel1.Controls.Add(Me.txt_Subject)
        Me.sc_CustomComp.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.sc_CustomComp.Panel1MinSize = 40
        '
        'sc_CustomComp.Panel2
        '
        Me.sc_CustomComp.Panel2.Controls.Add(Me.tsc_BodyContainer)
        Me.sc_CustomComp.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.sc_CustomComp.Size = New System.Drawing.Size(400, 300)
        Me.sc_CustomComp.SplitterDistance = 40
        Me.sc_CustomComp.SplitterIncrement = 5
        Me.sc_CustomComp.TabIndex = 0
        Me.sc_CustomComp.TabStop = False
        '
        'txt_Subject
        '
        Me.txt_Subject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Subject.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_Subject.Location = New System.Drawing.Point(10, 10)
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(380, 20)
        Me.txt_Subject.TabIndex = 0
        Me.txt_Subject.Text = "Subject..."
        '
        'CustomEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.sc_CustomComp)
        Me.Controls.Add(Me.ShortcutKeyStrip)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "CustomEmail"
        Me.Size = New System.Drawing.Size(400, 300)
        Me.tsc_BodyContainer.ContentPanel.ResumeLayout(False)
        Me.tsc_BodyContainer.ContentPanel.PerformLayout()
        Me.tsc_BodyContainer.TopToolStripPanel.ResumeLayout(False)
        Me.tsc_BodyContainer.ResumeLayout(False)
        Me.tsc_BodyContainer.PerformLayout()
        Me.ts_TextButtons.ResumeLayout(False)
        Me.ts_TextButtons.PerformLayout()
        Me.ShortcutKeyStrip.ResumeLayout(False)
        Me.ShortcutKeyStrip.PerformLayout()
        Me.sc_CustomComp.Panel1.ResumeLayout(False)
        Me.sc_CustomComp.Panel1.PerformLayout()
        Me.sc_CustomComp.Panel2.ResumeLayout(False)
        CType(Me.sc_CustomComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc_CustomComp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsc_BodyContainer As Windows.Forms.ToolStripContainer
    Friend WithEvents fd_Font As Windows.Forms.FontDialog
    Friend WithEvents ts_TextButtons As Windows.Forms.ToolStrip
    Friend WithEvents btn_Bold As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Underline As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Italics As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_ChangeFont As Windows.Forms.ToolStripButton
    Friend WithEvents ShortcutKeyStrip As Windows.Forms.MenuStrip
    Friend WithEvents Bold As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Underline As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Italics As Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_Body As Windows.Forms.TextBox
    Friend WithEvents sc_CustomComp As Windows.Forms.SplitContainer
    Friend WithEvents rtb_Body As Windows.Forms.RichTextBox
    Friend WithEvents txt_Subject As Windows.Forms.TextBox
End Class
