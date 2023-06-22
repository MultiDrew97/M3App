<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriveUploadDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriveUploadDialog))
        Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.chk_Custom = New System.Windows.Forms.CheckBox()
        Me.txt_CustomName = New System.Windows.Forms.TextBox()
        Me.tt_Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_CustomName = New System.Windows.Forms.Label()
        Me.bw_MovePairs = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'ofd_SelectAudio
        '
        Me.ofd_SelectAudio.FileName = "OpenFileDialog1"
		'
		'btn_AddFolder
		'
		Me.btn_AddFolder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_AddFolder.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_AddFolder.Location = New System.Drawing.Point(818, 101)
        Me.btn_AddFolder.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(55, 33)
        Me.btn_AddFolder.TabIndex = 18
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
		'
		'btn_Browse
		'
		Me.btn_Browse.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Browse.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_Browse.Location = New System.Drawing.Point(818, 244)
		Me.btn_Browse.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.btn_Browse.Name = "btn_Browse"
		Me.btn_Browse.Size = New System.Drawing.Size(55, 33)
		Me.btn_Browse.TabIndex = 17
		Me.btn_Browse.Text = "..."
		Me.btn_Browse.UseVisualStyleBackColor = True
		'
		'txt_FileLocation
		'
		Me.txt_FileLocation.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_FileLocation.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txt_FileLocation.Location = New System.Drawing.Point(338, 244)
		Me.txt_FileLocation.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.txt_FileLocation.Name = "txt_FileLocation"
		Me.txt_FileLocation.ReadOnly = True
		Me.txt_FileLocation.Size = New System.Drawing.Size(466, 31)
		Me.txt_FileLocation.TabIndex = 16
		Me.tt_Info.SetToolTip(Me.txt_FileLocation, "The file to be uploaded.")
		'
		'lbl_FileLocation
		'
		Me.lbl_FileLocation.AutoSize = True
		Me.lbl_FileLocation.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_FileLocation.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl_FileLocation.Location = New System.Drawing.Point(328, 213)
		Me.lbl_FileLocation.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
		Me.lbl_FileLocation.Name = "lbl_FileLocation"
		Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 25)
		Me.lbl_FileLocation.TabIndex = 15
		Me.lbl_FileLocation.Text = "File:"
		'
		'lbl_Folder
		'
		Me.lbl_Folder.AutoSize = True
		Me.lbl_Folder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_Folder.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl_Folder.Location = New System.Drawing.Point(328, 71)
		Me.lbl_Folder.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
		Me.lbl_Folder.Name = "lbl_Folder"
		Me.lbl_Folder.Size = New System.Drawing.Size(79, 25)
		Me.lbl_Folder.TabIndex = 14
		Me.lbl_Folder.Text = "Folder"
		'
		'cbx_Folders
		'
		Me.cbx_Folders.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cbx_Folders.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cbx_Folders.FormattingEnabled = True
		Me.cbx_Folders.Location = New System.Drawing.Point(338, 101)
		Me.cbx_Folders.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.cbx_Folders.Name = "cbx_Folders"
		Me.cbx_Folders.Size = New System.Drawing.Size(466, 33)
		Me.cbx_Folders.TabIndex = 13
		Me.tt_Info.SetToolTip(Me.cbx_Folders, "The folder that the file will uploaded to.")
		'
		'btn_Upload
		'
		Me.btn_Upload.AutoSize = True
		Me.btn_Upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Upload.Location = New System.Drawing.Point(68, 133)
		Me.btn_Upload.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.btn_Upload.MinimumSize = New System.Drawing.Size(163, 44)
		Me.btn_Upload.Name = "btn_Upload"
		Me.btn_Upload.Size = New System.Drawing.Size(163, 44)
		Me.btn_Upload.TabIndex = 19
		Me.btn_Upload.Text = "Upload"
		Me.btn_Upload.UseVisualStyleBackColor = True
		'
		'btn_Cancel
		'
		Me.btn_Cancel.AutoSize = True
		Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Cancel.Location = New System.Drawing.Point(68, 250)
		Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.btn_Cancel.MinimumSize = New System.Drawing.Size(163, 44)
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.Size = New System.Drawing.Size(163, 44)
		Me.btn_Cancel.TabIndex = 19
		Me.btn_Cancel.Text = "Cancel"
		Me.btn_Cancel.UseVisualStyleBackColor = True
		'
		'chk_Custom
		'
		Me.chk_Custom.AutoSize = True
		Me.chk_Custom.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chk_Custom.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.chk_Custom.Location = New System.Drawing.Point(518, 327)
		Me.chk_Custom.Name = "chk_Custom"
		Me.chk_Custom.Size = New System.Drawing.Size(177, 29)
		Me.chk_Custom.TabIndex = 20
		Me.chk_Custom.Text = "Custom Name"
		Me.tt_Info.SetToolTip(Me.chk_Custom, "When checked, you can set the name of the uploaded file yourself." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When uncheck" &
		"ed, the file will be uploaded with the name from the file name and the date it w" &
		"as uploaded.")
		Me.chk_Custom.UseVisualStyleBackColor = True
		'
		'txt_CustomName
		'
		Me.txt_CustomName.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_CustomName.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.txt_CustomName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txt_CustomName.Location = New System.Drawing.Point(338, 356)
		Me.txt_CustomName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.txt_CustomName.Name = "txt_CustomName"
		Me.txt_CustomName.Size = New System.Drawing.Size(466, 31)
		Me.txt_CustomName.TabIndex = 16
		Me.tt_Info.SetToolTip(Me.txt_CustomName, "The name of the file when uploaded.")
		Me.txt_CustomName.Visible = False
		'
		'lbl_CustomName
		'
		Me.lbl_CustomName.AutoSize = True
		Me.lbl_CustomName.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_CustomName.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_CustomName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_CustomName.Location = New System.Drawing.Point(333, 324)
        Me.lbl_CustomName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl_CustomName.Name = "lbl_CustomName"
        Me.lbl_CustomName.Size = New System.Drawing.Size(79, 25)
        Me.lbl_CustomName.TabIndex = 15
        Me.lbl_CustomName.Text = "Name:"
        Me.lbl_CustomName.Visible = False
        '
        'bw_MovePairs
        '
        '
        'DriveUploadDialog
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 427)
        Me.Controls.Add(Me.chk_Custom)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Upload)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_CustomName)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.Controls.Add(Me.lbl_CustomName)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "DriveUploadDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd_SelectAudio As OpenFileDialog
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents btn_Browse As Button
    Friend WithEvents txt_FileLocation As TextBox
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents btn_Upload As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents chk_Custom As CheckBox
    Friend WithEvents txt_CustomName As TextBox
    Friend WithEvents tt_Info As ToolTip
    Friend WithEvents lbl_CustomName As Label
    Friend WithEvents bw_MovePairs As System.ComponentModel.BackgroundWorker
End Class
