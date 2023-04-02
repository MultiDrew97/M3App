<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriveTree
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Drive Folder")
        Me.tv_DriveFiles = New System.Windows.Forms.TreeView()
        Me.gdt_GDrive = New SPPBC.M3Tools.GTools.GdriveTool(Me.components)
        Me.ts_Tools = New System.Windows.Forms.ToolStrip()
        Me.tss_NewItem = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsmi_NewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_NewUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.ts_Tools.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv_DriveFiles
        '
        Me.tv_DriveFiles.CheckBoxes = True
        Me.tv_DriveFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv_DriveFiles.Location = New System.Drawing.Point(0, 0)
        Me.tv_DriveFiles.Name = "tv_DriveFiles"
        TreeNode1.Name = "main"
        TreeNode1.Text = "My Drive Folder"
        Me.tv_DriveFiles.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tv_DriveFiles.Size = New System.Drawing.Size(625, 475)
        Me.tv_DriveFiles.TabIndex = 2
        '
        'gdt_GDrive
        '
        Me.gdt_GDrive.Username = Global.SPPBC.M3Tools.My.MySettings.Default.CurrentUser
        '
        'ts_Tools
        '
        Me.ts_Tools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_NewItem})
        Me.ts_Tools.Location = New System.Drawing.Point(0, 0)
        Me.ts_Tools.Name = "ts_Tools"
        Me.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ts_Tools.Size = New System.Drawing.Size(625, 25)
        Me.ts_Tools.Stretch = True
        Me.ts_Tools.TabIndex = 3
        '
        'tss_NewItem
        '
        Me.tss_NewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tss_NewItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_NewFolder, Me.tsmi_NewUpload})
        Me.tss_NewItem.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tss_NewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tss_NewItem.Name = "tss_NewItem"
        Me.tss_NewItem.Size = New System.Drawing.Size(32, 22)
        Me.tss_NewItem.Text = "New"
        '
        'tsmi_NewFolder
        '
        Me.tsmi_NewFolder.Name = "tsmi_NewFolder"
        Me.tsmi_NewFolder.Size = New System.Drawing.Size(139, 22)
        Me.tsmi_NewFolder.Text = "New Folder"
        '
        'tsmi_NewUpload
        '
        Me.tsmi_NewUpload.Name = "tsmi_NewUpload"
        Me.tsmi_NewUpload.Size = New System.Drawing.Size(139, 22)
        Me.tsmi_NewUpload.Text = "New Upload"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tv_DriveFiles)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(625, 475)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(625, 500)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_Tools)
        '
        'cms_Tools
        '
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(118, 48)
        '
        'DriveTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.cms_Tools
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "DriveTree"
        Me.Size = New System.Drawing.Size(625, 500)
        Me.ts_Tools.ResumeLayout(False)
        Me.ts_Tools.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tv_DriveFiles As Windows.Forms.TreeView
	Friend WithEvents gdt_GDrive As GTools.GdriveTool
	Friend WithEvents ts_Tools As Windows.Forms.ToolStrip
	Friend WithEvents tss_NewItem As Windows.Forms.ToolStripSplitButton
	Friend WithEvents tsmi_NewFolder As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_NewUpload As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents cms_Tools As ToolsContextMenu
End Class
