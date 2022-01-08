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
        Me.cms_RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.gdt_GDrive = New SPPBC.M3Tools.GoogleAPI.GoogleDriveTool(Me.components)
        Me.cms_RightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv_DriveFiles
        '
        Me.tv_DriveFiles.CheckBoxes = True
        Me.tv_DriveFiles.ContextMenuStrip = Me.cms_RightClick
        Me.tv_DriveFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv_DriveFiles.Location = New System.Drawing.Point(0, 0)
        Me.tv_DriveFiles.Name = "tv_DriveFiles"
        TreeNode1.Name = "main"
        TreeNode1.Text = "My Drive Folder"
        Me.tv_DriveFiles.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tv_DriveFiles.Size = New System.Drawing.Size(625, 500)
        Me.tv_DriveFiles.TabIndex = 2
        '
        'cms_RightClick
        '
        Me.cms_RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Refresh})
        Me.cms_RightClick.Name = "cms_RightClick"
        Me.cms_RightClick.Size = New System.Drawing.Size(181, 48)
        Me.cms_RightClick.Text = "Tree Tools"
        '
        'tsmi_Refresh
        '
        Me.tsmi_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsmi_Refresh.Name = "tsmi_Refresh"
        Me.tsmi_Refresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmi_Refresh.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_Refresh.Text = "Refresh"
        Me.tsmi_Refresh.ToolTipText = "Refresh the view"
        '
        'DriveTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tv_DriveFiles)
        Me.Name = "DriveTree"
        Me.Size = New System.Drawing.Size(625, 500)
        Me.cms_RightClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tv_DriveFiles As Windows.Forms.TreeView
    Friend WithEvents cms_RightClick As Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_Refresh As Windows.Forms.ToolStripMenuItem
    Friend WithEvents gdt_GDrive As GoogleAPI.GoogleDriveTool
End Class
