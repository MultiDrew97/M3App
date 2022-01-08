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
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ts_TextButtons = New System.Windows.Forms.ToolStrip()
        Me.btn_Bold = New System.Windows.Forms.ToolStripButton()
        Me.btn_Underline = New System.Windows.Forms.ToolStripButton()
        Me.btn_Italics = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.fd_Font = New System.Windows.Forms.FontDialog()
        Me.ip_Subject = New SPPBC.M3Tools.GenericInputPair()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ts_TextButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtb_Body
        '
        Me.rtb_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_Body.Location = New System.Drawing.Point(0, 0)
        Me.rtb_Body.Name = "rtb_Body"
        Me.rtb_Body.Size = New System.Drawing.Size(542, 335)
        Me.rtb_Body.TabIndex = 1
        Me.rtb_Body.Text = ""
        '
        'ToolStripContainer2
        '
        Me.ToolStripContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStripContainer2.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.rtb_Body)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(542, 335)
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 48)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(542, 360)
        Me.ToolStripContainer2.TabIndex = 4
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ts_TextButtons)
        '
        'ts_TextButtons
        '
        Me.ts_TextButtons.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_TextButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Bold, Me.btn_Underline, Me.btn_Italics, Me.ToolStripSeparator1, Me.btn_ChangeFont})
        Me.ts_TextButtons.Location = New System.Drawing.Point(3, 0)
        Me.ts_TextButtons.Name = "ts_TextButtons"
        Me.ts_TextButtons.Size = New System.Drawing.Size(141, 25)
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
        Me.ip_Subject.TabIndex = 5
        Me.ip_Subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ip_Subject.UseSystemPasswordChar = False
        '
        'CustomEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.ip_Subject)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Name = "CustomEmail"
        Me.Size = New System.Drawing.Size(542, 411)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ts_TextButtons.ResumeLayout(False)
        Me.ts_TextButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtb_Body As Windows.Forms.RichTextBox
    Friend WithEvents ToolStripContainer2 As Windows.Forms.ToolStripContainer
    Friend WithEvents fd_Font As Windows.Forms.FontDialog
    Friend WithEvents ts_TextButtons As Windows.Forms.ToolStrip
    Friend WithEvents btn_Bold As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Underline As Windows.Forms.ToolStripButton
    Friend WithEvents btn_Italics As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_ChangeFont As Windows.Forms.ToolStripButton
    Friend WithEvents ip_Subject As GenericInputPair
End Class
