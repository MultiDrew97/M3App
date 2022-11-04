<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendEmailsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmailsDialog))
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.bw_GetFileID = New System.ComponentModel.BackgroundWorker()
        Me.tcl_EmailOptions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_SermonSend = New System.Windows.Forms.Button()
        Me.chk_SermonDefault = New System.Windows.Forms.CheckBox()
        Me.cbx_Files = New System.Windows.Forms.ComboBox()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo_Other = New System.Windows.Forms.RadioButton()
        Me.rdo_Reciept = New System.Windows.Forms.RadioButton()
        Me.btn_LocalSend = New System.Windows.Forms.Button()
        Me.chk_RecieptDefault = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flf_LocalReciept = New MediaMinistry.FileLocationField()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_CustomSend = New System.Windows.Forms.Button()
        Me.btn_CustomMessage = New System.Windows.Forms.Button()
        Me.btn_UploadFile = New System.Windows.Forms.Button()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.gd_Uploader = New SPPBC.M3Tools.GoogleAPI.GoogleDriveTool(Me.components)
        Me.ss_Feedback.SuspendLayout()
        Me.tcl_EmailOptions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback, Me.tsp_Progress})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 382)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.ss_Feedback.Size = New System.Drawing.Size(846, 22)
        Me.ss_Feedback.TabIndex = 14
        Me.ss_Feedback.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(104, 17)
        Me.tss_Feedback.Text = "Please select a file."
        '
        'tsp_Progress
        '
        Me.tsp_Progress.Margin = New System.Windows.Forms.Padding(650, 3, 1, 3)
        Me.tsp_Progress.Name = "tsp_Progress"
        Me.tsp_Progress.Size = New System.Drawing.Size(100, 16)
        Me.tsp_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'bw_LoadListeners
        '
        '
        'bw_SendEmails
        '
        Me.bw_SendEmails.WorkerReportsProgress = True
        Me.bw_SendEmails.WorkerSupportsCancellation = True
        '
        'bw_GetFileID
        '
        '
        'tcl_EmailOptions
        '
        Me.tcl_EmailOptions.Controls.Add(Me.TabPage1)
        Me.tcl_EmailOptions.Controls.Add(Me.TabPage2)
        Me.tcl_EmailOptions.Controls.Add(Me.TabPage3)
        Me.tcl_EmailOptions.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tcl_EmailOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.tcl_EmailOptions.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.tcl_EmailOptions.Location = New System.Drawing.Point(217, 0)
        Me.tcl_EmailOptions.Name = "tcl_EmailOptions"
        Me.tcl_EmailOptions.SelectedIndex = 0
        Me.tcl_EmailOptions.Size = New System.Drawing.Size(629, 382)
        Me.tcl_EmailOptions.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_SermonSend)
        Me.TabPage1.Controls.Add(Me.chk_SermonDefault)
        Me.TabPage1.Controls.Add(Me.cbx_Files)
        Me.TabPage1.Controls.Add(Me.cbx_Folders)
        Me.TabPage1.Controls.Add(Me.lbl_Folder)
        Me.TabPage1.Controls.Add(Me.lbl_FileLocation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Sermon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_SermonSend
        '
        Me.btn_SermonSend.AutoSize = True
        Me.btn_SermonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_SermonSend.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_SermonSend.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_SermonSend.Location = New System.Drawing.Point(221, 282)
        Me.btn_SermonSend.Name = "btn_SermonSend"
        Me.btn_SermonSend.Size = New System.Drawing.Size(178, 35)
        Me.btn_SermonSend.TabIndex = 23
        Me.btn_SermonSend.Text = "Send Message"
        Me.btn_SermonSend.UseVisualStyleBackColor = True
        '
        'chk_SermonDefault
        '
        Me.chk_SermonDefault.AutoSize = True
        Me.chk_SermonDefault.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_SermonDefault.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.chk_SermonDefault.Location = New System.Drawing.Point(188, 219)
        Me.chk_SermonDefault.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_SermonDefault.Name = "chk_SermonDefault"
        Me.chk_SermonDefault.Size = New System.Drawing.Size(256, 29)
        Me.chk_SermonDefault.TabIndex = 22
        Me.chk_SermonDefault.Text = "Use Default Message"
        Me.chk_SermonDefault.UseVisualStyleBackColor = True
        '
        'cbx_Files
        '
        Me.cbx_Files.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbx_Files.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.cbx_Files.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Files.FormattingEnabled = True
        Me.cbx_Files.Location = New System.Drawing.Point(75, 156)
        Me.cbx_Files.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Files.Name = "cbx_Files"
        Me.cbx_Files.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Files.TabIndex = 21
        '
        'cbx_Folders
        '
        Me.cbx_Folders.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbx_Folders.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(75, 57)
        Me.cbx_Folders.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Folders.TabIndex = 18
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Folder.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(65, 27)
        Me.lbl_Folder.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Folder.TabIndex = 19
        Me.lbl_Folder.Text = "Folder"
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_FileLocation.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(65, 125)
        Me.lbl_FileLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 25)
        Me.lbl_FileLocation.TabIndex = 20
        Me.lbl_FileLocation.Text = "File:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.btn_LocalSend)
        Me.TabPage2.Controls.Add(Me.chk_RecieptDefault)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.flf_LocalReciept)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reciept/Local File"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_Other)
        Me.GroupBox1.Controls.Add(Me.rdo_Reciept)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 100)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdo_Other
        '
        Me.rdo_Other.AutoSize = True
        Me.rdo_Other.Location = New System.Drawing.Point(220, 46)
        Me.rdo_Other.Name = "rdo_Other"
        Me.rdo_Other.Size = New System.Drawing.Size(88, 29)
        Me.rdo_Other.TabIndex = 1
        Me.rdo_Other.Text = "Other"
        Me.rdo_Other.UseVisualStyleBackColor = True
        '
        'rdo_Reciept
        '
        Me.rdo_Reciept.AutoSize = True
        Me.rdo_Reciept.Checked = True
        Me.rdo_Reciept.Location = New System.Drawing.Point(53, 46)
        Me.rdo_Reciept.Name = "rdo_Reciept"
        Me.rdo_Reciept.Size = New System.Drawing.Size(110, 29)
        Me.rdo_Reciept.TabIndex = 0
        Me.rdo_Reciept.TabStop = True
        Me.rdo_Reciept.Text = "Reciept"
        Me.rdo_Reciept.UseVisualStyleBackColor = True
        '
        'btn_LocalSend
        '
        Me.btn_LocalSend.AutoSize = True
        Me.btn_LocalSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_LocalSend.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_LocalSend.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_LocalSend.Location = New System.Drawing.Point(219, 280)
        Me.btn_LocalSend.Name = "btn_LocalSend"
        Me.btn_LocalSend.Size = New System.Drawing.Size(178, 35)
        Me.btn_LocalSend.TabIndex = 23
        Me.btn_LocalSend.Text = "Send Message"
        Me.btn_LocalSend.UseVisualStyleBackColor = True
        '
        'chk_RecieptDefault
        '
        Me.chk_RecieptDefault.AutoSize = True
        Me.chk_RecieptDefault.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_RecieptDefault.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.chk_RecieptDefault.Location = New System.Drawing.Point(186, 230)
        Me.chk_RecieptDefault.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_RecieptDefault.Name = "chk_RecieptDefault"
        Me.chk_RecieptDefault.Size = New System.Drawing.Size(256, 29)
        Me.chk_RecieptDefault.TabIndex = 22
        Me.chk_RecieptDefault.Text = "Use Default Message"
        Me.chk_RecieptDefault.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(36, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "File:"
        '
        'flf_LocalReciept
        '
        Me.flf_LocalReciept.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.flf_LocalReciept.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.flf_LocalReciept.Location = New System.Drawing.Point(41, 159)
        Me.flf_LocalReciept.Name = "flf_LocalReciept"
        Me.flf_LocalReciept.Size = New System.Drawing.Size(560, 33)
        Me.flf_LocalReciept.TabIndex = 26
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_CustomSend)
        Me.TabPage3.Controls.Add(Me.btn_CustomMessage)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(621, 344)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Custom Message"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_CustomSend
        '
        Me.btn_CustomSend.AutoSize = True
        Me.btn_CustomSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_CustomSend.Location = New System.Drawing.Point(221, 217)
        Me.btn_CustomSend.Name = "btn_CustomSend"
        Me.btn_CustomSend.Size = New System.Drawing.Size(178, 35)
        Me.btn_CustomSend.TabIndex = 1
        Me.btn_CustomSend.Text = "Send Message"
        Me.btn_CustomSend.UseVisualStyleBackColor = True
        '
        'btn_CustomMessage
        '
        Me.btn_CustomMessage.AutoSize = True
        Me.btn_CustomMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_CustomMessage.Location = New System.Drawing.Point(170, 93)
        Me.btn_CustomMessage.Name = "btn_CustomMessage"
        Me.btn_CustomMessage.Size = New System.Drawing.Size(280, 35)
        Me.btn_CustomMessage.TabIndex = 0
        Me.btn_CustomMessage.Text = "Create Custom Message"
        Me.btn_CustomMessage.UseVisualStyleBackColor = True
        '
        'btn_UploadFile
        '
        Me.btn_UploadFile.AutoSize = True
        Me.btn_UploadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_UploadFile.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_UploadFile.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_UploadFile.Location = New System.Drawing.Point(28, 241)
        Me.btn_UploadFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_UploadFile.MaximumSize = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.MinimumSize = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.Name = "btn_UploadFile"
        Me.btn_UploadFile.Size = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.TabIndex = 16
        Me.btn_UploadFile.Text = "Upload New File"
        Me.btn_UploadFile.UseVisualStyleBackColor = True
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.AutoSize = True
        Me.btn_AddFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_AddFolder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_AddFolder.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_AddFolder.Location = New System.Drawing.Point(28, 81)
        Me.btn_AddFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_AddFolder.MaximumSize = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.MinimumSize = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.TabIndex = 12
        Me.btn_AddFolder.Text = "Create New Folder"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'SendEmailsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 404)
        Me.Controls.Add(Me.tcl_EmailOptions)
        Me.Controls.Add(Me.btn_UploadFile)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "SendEmailsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "emails"
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.tcl_EmailOptions.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents btn_UploadFile As Button
    Friend WithEvents bw_LoadListeners As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_GetFileID As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsp_Progress As ToolStripProgressBar
    Friend WithEvents tcl_EmailOptions As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_SermonSend As Button
    Friend WithEvents chk_SermonDefault As CheckBox
    Friend WithEvents cbx_Files As ComboBox
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_LocalSend As Button
    Friend WithEvents chk_RecieptDefault As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents flf_LocalReciept As FileLocationField
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_CustomMessage As Button
    Friend WithEvents btn_CustomSend As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdo_Other As RadioButton
    Friend WithEvents rdo_Reciept As RadioButton
    Friend WithEvents gd_Uploader As SPPBC.M3Tools.GoogleAPI.GoogleDriveTool
End Class
