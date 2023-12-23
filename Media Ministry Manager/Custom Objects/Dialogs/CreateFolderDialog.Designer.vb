<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFolderDialog
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
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.dt_DriveHeirarchy = New SPPBC.M3Tools.DriveTree()
        Me.gdt_GDrive = New SPPBC.M3Tools.GTools.GdriveTool(Me.components)
        Me.ip_FolderName = New SPPBC.M3Tools.GenericInputPair()
        Me.bw_GatherInfo = New System.ComponentModel.BackgroundWorker()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Create, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(184, 361)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'btn_Create
		'
		Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_Create.Location = New System.Drawing.Point(76, 3)
		Me.btn_Create.Name = "btn_Create"
		Me.btn_Create.Size = New System.Drawing.Size(67, 23)
		Me.btn_Create.TabIndex = 0
		Me.btn_Create.Text = "Create"
		'
		'btn_Cancel
		'
		Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
		Me.btn_Cancel.TabIndex = 1
		Me.btn_Cancel.Text = "Cancel"
		'
		'dt_DriveHeirarchy
		'
		Me.dt_DriveHeirarchy.Checkboxes = False
		Me.dt_DriveHeirarchy.DataBindings.Add(New System.Windows.Forms.Binding("Username", Global.MediaMinistry.My.MySettings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.dt_DriveHeirarchy.Location = New System.Drawing.Point(12, 69)
		Me.dt_DriveHeirarchy.Name = "dt_DriveHeirarchy"
		Me.dt_DriveHeirarchy.Size = New System.Drawing.Size(303, 266)
		Me.dt_DriveHeirarchy.TabIndex = 2
		Me.dt_DriveHeirarchy.Username = Global.MediaMinistry.My.MySettings.Default.Username
		Me.dt_DriveHeirarchy.WithChildren = False
		'
		'ip_FolderName
		'
		Me.ip_FolderName.AutoSize = True
		Me.ip_FolderName.Label = "Folder Name"
		Me.ip_FolderName.Location = New System.Drawing.Point(12, 12)
		Me.ip_FolderName.Mask = ""
		Me.ip_FolderName.Name = "ip_FolderName"
		Me.ip_FolderName.Placeholder = Nothing
		Me.ip_FolderName.Size = New System.Drawing.Size(302, 44)
		Me.ip_FolderName.TabIndex = 3
		Me.ip_FolderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'bw_GatherInfo
		'
		'
		'CreateFolderDialog
		'
		Me.AcceptButton = Me.btn_Create
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btn_Cancel
		Me.ClientSize = New System.Drawing.Size(342, 402)
		Me.Controls.Add(Me.ip_FolderName)
		Me.Controls.Add(Me.dt_DriveHeirarchy)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "CreateFolderDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "New Folder"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Create As System.Windows.Forms.Button
	Friend WithEvents btn_Cancel As System.Windows.Forms.Button
	Friend WithEvents dt_DriveHeirarchy As SPPBC.M3Tools.DriveTree
	Friend WithEvents gdt_GDrive As SPPBC.M3Tools.GTools.GdriveTool
	Friend WithEvents ip_FolderName As SPPBC.M3Tools.GenericInputPair
	Friend WithEvents bw_GatherInfo As ComponentModel.BackgroundWorker
End Class
