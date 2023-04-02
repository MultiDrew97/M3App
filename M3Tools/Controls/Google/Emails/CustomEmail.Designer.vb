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
        Me.rtb_Body = New System.Windows.Forms.RichTextBox()
        Me.tsc_BodyContainer = New System.Windows.Forms.ToolStripContainer()
        Me.ShortcutKeyStrip = New System.Windows.Forms.MenuStrip()
        Me.Bold = New System.Windows.Forms.ToolStripMenuItem()
        Me.Underline = New System.Windows.Forms.ToolStripMenuItem()
        Me.Italics = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_TextButtons = New System.Windows.Forms.ToolStrip()
        Me.btn_Bold = New System.Windows.Forms.ToolStripButton()
        Me.btn_Underline = New System.Windows.Forms.ToolStripButton()
        Me.btn_Italics = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.fd_Font = New System.Windows.Forms.FontDialog()
        Me.ip_Subject = New SPPBC.M3Tools.GenericInputPair()
        Me.tsc_BodyContainer.ContentPanel.SuspendLayout()
        Me.tsc_BodyContainer.TopToolStripPanel.SuspendLayout()
        Me.tsc_BodyContainer.SuspendLayout()
        Me.ShortcutKeyStrip.SuspendLayout()
        Me.ts_TextButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtb_Body
        '
        Me.rtb_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_Body.Location = New System.Drawing.Point(0, 0)
        Me.rtb_Body.Name = "rtb_Body"
        Me.rtb_Body.Size = New System.Drawing.Size(542, 335)
        Me.rtb_Body.TabIndex = 0
        Me.rtb_Body.Text = ""
        '
        'tsc_BodyContainer
        '
        Me.tsc_BodyContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsc_BodyContainer.BottomToolStripPanelVisible = False
        '
        'tsc_BodyContainer.ContentPanel
        '
        Me.tsc_BodyContainer.ContentPanel.Controls.Add(Me.rtb_Body)
        Me.tsc_BodyContainer.ContentPanel.Size = New System.Drawing.Size(542, 335)
        Me.tsc_BodyContainer.LeftToolStripPanelVisible = False
        Me.tsc_BodyContainer.Location = New System.Drawing.Point(0, 48)
        Me.tsc_BodyContainer.Name = "tsc_BodyContainer"
        Me.tsc_BodyContainer.RightToolStripPanelVisible = False
        Me.tsc_BodyContainer.Size = New System.Drawing.Size(542, 360)
        Me.tsc_BodyContainer.TabIndex = 1
        Me.tsc_BodyContainer.Text = "ToolStripContainer2"
        '
        'tsc_BodyContainer.TopToolStripPanel
        '
        Me.tsc_BodyContainer.TopToolStripPanel.Controls.Add(Me.ts_TextButtons)
        '
        'ShortcutKeyStrip
        '
        Me.ShortcutKeyStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ShortcutKeyStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bold, Me.Underline, Me.Italics})
        Me.ShortcutKeyStrip.Location = New System.Drawing.Point(200, 3)
        Me.ShortcutKeyStrip.Name = "ShortcutKeyStrip"
        Me.ShortcutKeyStrip.Size = New System.Drawing.Size(170, 24)
        Me.ShortcutKeyStrip.TabIndex = 1
        Me.ShortcutKeyStrip.Text = "MenuStrip1"
        Me.ShortcutKeyStrip.Visible = False
        '
        'Bold
        '
        Me.Bold.Name = "Bold"
        Me.Bold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Bold.Size = New System.Drawing.Size(43, 20)
        Me.Bold.Text = "Bold"
        '
        'Underline
        '
        Me.Underline.Name = "Underline"
        Me.Underline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.Underline.Size = New System.Drawing.Size(70, 20)
        Me.Underline.Text = "Underline"
        '
        'Italics
        '
        Me.Italics.Name = "Italics"
        Me.Italics.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Italics.Size = New System.Drawing.Size(49, 20)
        Me.Italics.Text = "Italics"
        '
        'ts_TextButtons
        '
        Me.ts_TextButtons.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_TextButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Bold, Me.btn_Underline, Me.btn_Italics, Me.ToolStripSeparator1, Me.btn_ChangeFont})
        Me.ts_TextButtons.Location = New System.Drawing.Point(3, 0)
        Me.ts_TextButtons.Name = "ts_TextButtons"
        Me.ts_TextButtons.Size = New System.Drawing.Size(110, 25)
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
        Me.btn_Bold.Size = New System.Drawing.Size(23, 22)
        Me.btn_Bold.Text = "Bold"
        '
        'btn_Underline
        '
        Me.btn_Underline.CheckOnClick = True
        Me.btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Underline.Image = Global.SPPBC.M3Tools.My.Resources.Resources.UnderlineOption
        Me.btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Underline.Name = "btn_Underline"
        Me.btn_Underline.Size = New System.Drawing.Size(23, 22)
        Me.btn_Underline.Text = "Underline"
        '
        'btn_Italics
        '
        Me.btn_Italics.CheckOnClick = True
        Me.btn_Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Italics.Image = Global.SPPBC.M3Tools.My.Resources.Resources.ItalicOption
        Me.btn_Italics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Italics.Name = "btn_Italics"
        Me.btn_Italics.Size = New System.Drawing.Size(23, 22)
        Me.btn_Italics.Text = "Italics"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_ChangeFont
        '
        Me.btn_ChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ChangeFont.Image = Global.SPPBC.M3Tools.My.Resources.Resources.FontOption
        Me.btn_ChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ChangeFont.Name = "btn_ChangeFont"
        Me.btn_ChangeFont.Size = New System.Drawing.Size(23, 22)
        Me.btn_ChangeFont.Text = "Change Font"
        '
        'fd_Font
        '
        Me.fd_Font.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ip_Subject
        '
        Me.ip_Subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ip_Subject.AutoSize = True
        Me.ip_Subject.LabelText = "Subject"
        Me.ip_Subject.Location = New System.Drawing.Point(3, 3)
        Me.ip_Subject.Mask = ""
        Me.ip_Subject.Name = "ip_Subject"
        Me.ip_Subject.Size = New System.Drawing.Size(536, 42)
        Me.ip_Subject.TabIndex = 0
        Me.ip_Subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CustomEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.ShortcutKeyStrip)
        Me.Controls.Add(Me.ip_Subject)
        Me.Controls.Add(Me.tsc_BodyContainer)
        Me.Name = "CustomEmail"
        Me.Size = New System.Drawing.Size(542, 411)
        Me.tsc_BodyContainer.ContentPanel.ResumeLayout(False)
        Me.tsc_BodyContainer.TopToolStripPanel.ResumeLayout(False)
        Me.tsc_BodyContainer.TopToolStripPanel.PerformLayout()
        Me.tsc_BodyContainer.ResumeLayout(False)
        Me.tsc_BodyContainer.PerformLayout()
        Me.ShortcutKeyStrip.ResumeLayout(False)
        Me.ShortcutKeyStrip.PerformLayout()
        Me.ts_TextButtons.ResumeLayout(False)
        Me.ts_TextButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtb_Body As Windows.Forms.RichTextBox
    Friend WithEvents tsc_BodyContainer As Windows.Forms.ToolStripContainer
    Friend WithEvents fd_Font As Windows.Forms.FontDialog
    Friend WithEvents ts_TextButtons As Windows.Forms.ToolStrip
    Friend WithEvents btn_Bold As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Underline As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Italics As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_ChangeFont As Windows.Forms.ToolStripButton
    Friend WithEvents ip_Subject As GenericInputPair
    Friend WithEvents ShortcutKeyStrip As Windows.Forms.MenuStrip
    Friend WithEvents Bold As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Underline As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Italics As Windows.Forms.ToolStripMenuItem
End Class
