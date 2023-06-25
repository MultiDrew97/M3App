<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileUpload
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
        Me.ofd_FileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_Files = New System.Windows.Forms.DataGridView()
        Me.bsFiles = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbtn_Select = New System.Windows.Forms.ToolStripButton()
        Me.dgc_File = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd_FileDialog
        '
        Me.ofd_FileDialog.Multiselect = True
        Me.ofd_FileDialog.Title = "Upload New File(s)"
        '
        'dgv_Files
        '
        Me.dgv_Files.AllowUserToAddRows = False
        Me.dgv_Files.AutoGenerateColumns = False
        Me.dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Files.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_File})
        Me.dgv_Files.DataSource = Me.bsFiles
        Me.dgv_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Files.Location = New System.Drawing.Point(10, 10)
        Me.dgv_Files.Name = "dgv_Files"
        Me.dgv_Files.ReadOnly = True
        Me.dgv_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Files.Size = New System.Drawing.Size(394, 313)
        Me.dgv_Files.TabIndex = 1
        '
        'bsFiles
        '
        Me.bsFiles.AllowNew = True
        Me.bsFiles.DataSource = GetType(SPPBC.M3Tools.GTools.Types.FileCollection)
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgv_Files)
        Me.ToolStripContainer1.ContentPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(414, 333)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(414, 358)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_Select})
        Me.ToolStrip1.Location = New System.Drawing.Point(55, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(26, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'tbtn_Select
        '
        Me.tbtn_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Select.Image = Global.SPPBC.M3Tools.My.Resources.Resources.import
        Me.tbtn_Select.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Select.Name = "tbtn_Select"
        Me.tbtn_Select.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_Select.Text = "Select"
        '
        'dgc_File
        '
        Me.dgc_File.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_File.DataPropertyName = "Name"
        Me.dgc_File.HeaderText = "File"
        Me.dgc_File.Name = "dgc_File"
        Me.dgc_File.ReadOnly = True
        Me.dgc_File.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FileUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FileUpload"
        Me.Size = New System.Drawing.Size(414, 358)
        CType(Me.dgv_Files, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ofd_FileDialog As Windows.Forms.OpenFileDialog
    Friend WithEvents dgv_Files As Windows.Forms.DataGridView
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents tbtn_Select As Windows.Forms.ToolStripButton
    Friend WithEvents bsFiles As Windows.Forms.BindingSource
    Friend WithEvents dgc_File As Windows.Forms.DataGridViewTextBoxColumn
End Class
