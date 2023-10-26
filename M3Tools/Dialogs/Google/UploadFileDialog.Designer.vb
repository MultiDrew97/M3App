<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadFileDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chk_DefaultPermissions = New System.Windows.Forms.CheckBox()
        Me.fu_FileUpload = New SPPBC.M3Tools.FileUpload()
        Me.bsFiles = New System.Windows.Forms.BindingSource(Me.components)
        Me.dt_DriveHeirarchy = New SPPBC.M3Tools.DriveTree()
        Me.bw_LoadDialog = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bw_LoadFiles = New System.ComponentModel.BackgroundWorker()
        Me.bw_UploadFiles = New System.ComponentModel.BackgroundWorker()
        Me.gdt_GDrive = New SPPBC.M3Tools.GTools.GdriveTool(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.bsFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Upload, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(229, 311)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Upload
        '
        Me.btn_Upload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Upload.Location = New System.Drawing.Point(76, 3)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(67, 23)
        Me.btn_Upload.TabIndex = 0
        Me.btn_Upload.Text = "Upload"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.chk_DefaultPermissions)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fu_FileUpload)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dt_DriveHeirarchy)
        Me.SplitContainer1.Size = New System.Drawing.Size(363, 286)
        Me.SplitContainer1.SplitterDistance = 113
        Me.SplitContainer1.TabIndex = 2
        '
        'chk_DefaultPermissions
        '
        Me.chk_DefaultPermissions.Checked = True
        Me.chk_DefaultPermissions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_DefaultPermissions.Dock = System.Windows.Forms.DockStyle.Right
        Me.chk_DefaultPermissions.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_DefaultPermissions.Location = New System.Drawing.Point(263, 0)
        Me.chk_DefaultPermissions.Name = "chk_DefaultPermissions"
        Me.chk_DefaultPermissions.Size = New System.Drawing.Size(100, 113)
        Me.chk_DefaultPermissions.TabIndex = 1
        Me.chk_DefaultPermissions.Text = "Default Permissions?"
        Me.chk_DefaultPermissions.UseVisualStyleBackColor = True
        '
        'fu_FileUpload
        '
        Me.fu_FileUpload.DataSource = Me.bsFiles
        Me.fu_FileUpload.Dock = System.Windows.Forms.DockStyle.Left
        Me.fu_FileUpload.Location = New System.Drawing.Point(0, 0)
        Me.fu_FileUpload.Name = "fu_FileUpload"
        Me.fu_FileUpload.Size = New System.Drawing.Size(257, 113)
        Me.fu_FileUpload.TabIndex = 0
		'
		'bsFiles
		'
		Me.bsFiles.DataSource = GetType(Types.GTools.FileCollection)
		'
		'dt_DriveHeirarchy
		'
		Me.dt_DriveHeirarchy.Checkboxes = False
        Me.dt_DriveHeirarchy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dt_DriveHeirarchy.Location = New System.Drawing.Point(0, 0)
        Me.dt_DriveHeirarchy.Name = "dt_DriveHeirarchy"
        Me.dt_DriveHeirarchy.Size = New System.Drawing.Size(363, 169)
        Me.dt_DriveHeirarchy.TabIndex = 1
        Me.dt_DriveHeirarchy.WithChildren = False
        '
        'bw_LoadDialog
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 286)
        Me.Panel1.TabIndex = 3
        '
        'bw_LoadFiles
        '
        '
        'bw_UploadFiles
        '
        '
        'gdt_GDrive
        '
        Me.gdt_GDrive.Username = Nothing
        '
        'UploadFileDialog
        '
        Me.AcceptButton = Me.btn_Upload
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(387, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UploadFileDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New File Upload"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.bsFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Upload As System.Windows.Forms.Button
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dt_DriveHeirarchy As DriveTree
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
	Friend WithEvents gdt_GDrive As GTools.GdriveTool
	Friend WithEvents bw_LoadDialog As ComponentModel.BackgroundWorker
	Friend WithEvents fu_FileUpload As FileUpload
	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents bw_LoadFiles As ComponentModel.BackgroundWorker
    Friend WithEvents bw_UploadFiles As ComponentModel.BackgroundWorker
    Friend WithEvents chk_DefaultPermissions As Windows.Forms.CheckBox
    Friend WithEvents bsFiles As Windows.Forms.BindingSource
End Class
