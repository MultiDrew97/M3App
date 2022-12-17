<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmailListeners
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmailListeners))
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.DisplayListenersCtrl1 = New SPPBC.M3Tools.DisplayListenersCtrl()
		Me.cms_Tools = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.SendAnEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cms_Tools.SuspendLayout()
		Me.SuspendLayout()
		'
		'mms_Main
		'
		Me.mms_Main.Location = New System.Drawing.Point(0, 0)
		Me.mms_Main.Name = "mms_Main"
		Me.mms_Main.Size = New System.Drawing.Size(733, 24)
		Me.mms_Main.TabIndex = 0
		Me.mms_Main.Text = "MainMenuStrip1"
		'
		'DisplayListenersCtrl1
		'
		Me.DisplayListenersCtrl1.AllowDeleting = True
		Me.DisplayListenersCtrl1.AllowEditting = True
		Me.DisplayListenersCtrl1.Dock = System.Windows.Forms.DockStyle.Left
		Me.DisplayListenersCtrl1.Location = New System.Drawing.Point(0, 24)
		Me.DisplayListenersCtrl1.Name = "DisplayListenersCtrl1"
		Me.DisplayListenersCtrl1.Size = New System.Drawing.Size(517, 350)
		Me.DisplayListenersCtrl1.TabIndex = 1
		'
		'cms_Tools
		'
		Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendAnEmailToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem, Me.RemoveToolStripMenuItem})
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(181, 98)
		'
		'RefreshToolStripMenuItem
		'
		Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
		Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.RefreshToolStripMenuItem.Text = "Refresh"
		'
		'RemoveToolStripMenuItem
		'
		Me.RemoveToolStripMenuItem.Enabled = False
		Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
		Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.RemoveToolStripMenuItem.Text = "Remove"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
		'
		'SendAnEmailToolStripMenuItem
		'
		Me.SendAnEmailToolStripMenuItem.Enabled = False
		Me.SendAnEmailToolStripMenuItem.Name = "SendAnEmailToolStripMenuItem"
		Me.SendAnEmailToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SendAnEmailToolStripMenuItem.Text = "Send an Email"
		'
		'frm_EmailListeners
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(733, 374)
		Me.Controls.Add(Me.DisplayListenersCtrl1)
		Me.Controls.Add(Me.mms_Main)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.Name = "frm_EmailListeners"
		Me.Text = "Media Ministry Manager"
		Me.cms_Tools.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
	Friend WithEvents DisplayListenersCtrl1 As SPPBC.M3Tools.DisplayListenersCtrl
	Friend WithEvents cms_Tools As ContextMenuStrip
	Friend WithEvents SendAnEmailToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
