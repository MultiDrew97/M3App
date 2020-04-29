﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EmailListeners
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmailListeners))
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.ofd_SelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.bw_Upload = New System.ComponentModel.BackgroundWorker()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_SendEmails = New System.Windows.Forms.Button()
        Me.btn_ViewListeners = New System.Windows.Forms.Button()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.rdo_GoingLive = New System.Windows.Forms.RadioButton()
        Me.rdo_EmailMinistry = New System.Windows.Forms.RadioButton()
        Me.cbx_FileList = New System.Windows.Forms.ComboBox()
        Me.btn_UploadFile = New System.Windows.Forms.Button()
        Me.gbx_Options = New System.Windows.Forms.GroupBox()
        Me.rdo_Sermon = New System.Windows.Forms.RadioButton()
        Me.rdo_Receipt = New System.Windows.Forms.RadioButton()
        Me.chk_Attachment = New System.Windows.Forms.CheckBox()
        Me.btn_CancelUpload = New System.Windows.Forms.Button()
        Me.ss_Feedback.SuspendLayout()
        Me.gbx_Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Upload
        '
        Me.btn_Upload.AutoSize = True
        Me.btn_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Upload.Location = New System.Drawing.Point(21, 27)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(238, 36)
        Me.btn_Upload.TabIndex = 0
        Me.btn_Upload.Text = "Upload to Drive"
        Me.btn_Upload.UseVisualStyleBackColor = True
        Me.btn_Upload.Visible = False
        '
        'ofd_SelectFile
        '
        Me.ofd_SelectFile.Multiselect = True
        Me.ofd_SelectFile.Title = "Email Ministry"
        '
        'cbx_Folders
        '
        Me.cbx_Folders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_Folders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(390, 32)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Folders.TabIndex = 1
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(294, 32)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(86, 26)
        Me.lbl_Folder.TabIndex = 2
        Me.lbl_Folder.Text = "Folder:"
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(326, 91)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 26)
        Me.lbl_FileLocation.TabIndex = 3
        Me.lbl_FileLocation.Text = "File:"
        '
        'txt_FileLocation
        '
        Me.txt_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FileLocation.Location = New System.Drawing.Point(390, 143)
        Me.txt_FileLocation.Name = "txt_FileLocation"
        Me.txt_FileLocation.ReadOnly = True
        Me.txt_FileLocation.Size = New System.Drawing.Size(367, 32)
        Me.txt_FileLocation.TabIndex = 4
        Me.txt_FileLocation.Visible = False
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Browse.Location = New System.Drawing.Point(763, 145)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(44, 31)
        Me.btn_Browse.TabIndex = 5
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        Me.btn_Browse.Visible = False
        '
        'bw_Upload
        '
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(763, 34)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(44, 31)
        Me.btn_AddFolder.TabIndex = 6
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 214)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(829, 22)
        Me.ss_Feedback.TabIndex = 7
        Me.ss_Feedback.Text = "ss_Feedback"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(340, 17)
        Me.tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
        '
        'btn_SendEmails
        '
        Me.btn_SendEmails.AutoSize = True
        Me.btn_SendEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SendEmails.Location = New System.Drawing.Point(21, 85)
        Me.btn_SendEmails.Name = "btn_SendEmails"
        Me.btn_SendEmails.Size = New System.Drawing.Size(238, 36)
        Me.btn_SendEmails.TabIndex = 8
        Me.btn_SendEmails.Text = "Send Emails"
        Me.btn_SendEmails.UseVisualStyleBackColor = True
        '
        'btn_ViewListeners
        '
        Me.btn_ViewListeners.AutoSize = True
        Me.btn_ViewListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ViewListeners.Location = New System.Drawing.Point(21, 143)
        Me.btn_ViewListeners.Name = "btn_ViewListeners"
        Me.btn_ViewListeners.Size = New System.Drawing.Size(238, 36)
        Me.btn_ViewListeners.TabIndex = 10
        Me.btn_ViewListeners.Text = "Current Listeners"
        Me.btn_ViewListeners.UseVisualStyleBackColor = True
        '
        'rdo_GoingLive
        '
        Me.rdo_GoingLive.Location = New System.Drawing.Point(0, 0)
        Me.rdo_GoingLive.Name = "rdo_GoingLive"
        Me.rdo_GoingLive.Size = New System.Drawing.Size(104, 24)
        Me.rdo_GoingLive.TabIndex = 0
        '
        'rdo_EmailMinistry
        '
        Me.rdo_EmailMinistry.Location = New System.Drawing.Point(0, 0)
        Me.rdo_EmailMinistry.Name = "rdo_EmailMinistry"
        Me.rdo_EmailMinistry.Size = New System.Drawing.Size(104, 24)
        Me.rdo_EmailMinistry.TabIndex = 0
        '
        'cbx_FileList
        '
        Me.cbx_FileList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_FileList.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_FileList.FormattingEnabled = True
        Me.cbx_FileList.Location = New System.Drawing.Point(390, 88)
        Me.cbx_FileList.Name = "cbx_FileList"
        Me.cbx_FileList.Size = New System.Drawing.Size(367, 33)
        Me.cbx_FileList.TabIndex = 11
        '
        'btn_UploadFile
        '
        Me.btn_UploadFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_UploadFile.Location = New System.Drawing.Point(763, 90)
        Me.btn_UploadFile.Name = "btn_UploadFile"
        Me.btn_UploadFile.Size = New System.Drawing.Size(44, 31)
        Me.btn_UploadFile.TabIndex = 6
        Me.btn_UploadFile.Text = "+"
        Me.btn_UploadFile.UseVisualStyleBackColor = True
        '
        'gbx_Options
        '
        Me.gbx_Options.AutoSize = True
        Me.gbx_Options.Controls.Add(Me.rdo_Sermon)
        Me.gbx_Options.Controls.Add(Me.rdo_Receipt)
        Me.gbx_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_Options.Location = New System.Drawing.Point(188, 203)
        Me.gbx_Options.Name = "gbx_Options"
        Me.gbx_Options.Size = New System.Drawing.Size(453, 85)
        Me.gbx_Options.TabIndex = 12
        Me.gbx_Options.TabStop = False
        Me.gbx_Options.Text = "Options"
        Me.gbx_Options.Visible = False
        '
        'rdo_Sermon
        '
        Me.rdo_Sermon.AutoSize = True
        Me.rdo_Sermon.Checked = True
        Me.rdo_Sermon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_Sermon.Location = New System.Drawing.Point(99, 24)
        Me.rdo_Sermon.Name = "rdo_Sermon"
        Me.rdo_Sermon.Size = New System.Drawing.Size(113, 30)
        Me.rdo_Sermon.TabIndex = 1
        Me.rdo_Sermon.TabStop = True
        Me.rdo_Sermon.Text = "Sermon"
        Me.rdo_Sermon.UseVisualStyleBackColor = True
        '
        'rdo_Receipt
        '
        Me.rdo_Receipt.AutoSize = True
        Me.rdo_Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_Receipt.Location = New System.Drawing.Point(243, 24)
        Me.rdo_Receipt.Name = "rdo_Receipt"
        Me.rdo_Receipt.Size = New System.Drawing.Size(111, 30)
        Me.rdo_Receipt.TabIndex = 0
        Me.rdo_Receipt.Text = "Receipt"
        Me.rdo_Receipt.UseVisualStyleBackColor = True
        '
        'chk_Attachment
        '
        Me.chk_Attachment.AutoSize = True
        Me.chk_Attachment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Attachment.Location = New System.Drawing.Point(500, 143)
        Me.chk_Attachment.Name = "chk_Attachment"
        Me.chk_Attachment.Size = New System.Drawing.Size(158, 30)
        Me.chk_Attachment.TabIndex = 13
        Me.chk_Attachment.Text = "Attach File?"
        Me.chk_Attachment.UseVisualStyleBackColor = True
        '
        'btn_CancelUpload
        '
        Me.btn_CancelUpload.AutoSize = True
        Me.btn_CancelUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_CancelUpload.Location = New System.Drawing.Point(522, 85)
        Me.btn_CancelUpload.Name = "btn_CancelUpload"
        Me.btn_CancelUpload.Size = New System.Drawing.Size(109, 36)
        Me.btn_CancelUpload.TabIndex = 14
        Me.btn_CancelUpload.Text = "Cancel"
        Me.btn_CancelUpload.UseVisualStyleBackColor = True
        Me.btn_CancelUpload.Visible = False
        '
        'frm_EmailListeners
        '
        Me.AcceptButton = Me.btn_Upload
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 236)
        Me.Controls.Add(Me.btn_CancelUpload)
        Me.Controls.Add(Me.chk_Attachment)
        Me.Controls.Add(Me.btn_ViewListeners)
        Me.Controls.Add(Me.btn_SendEmails)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Controls.Add(Me.btn_Upload)
        Me.Controls.Add(Me.gbx_Options)
        Me.Controls.Add(Me.cbx_FileList)
        Me.Controls.Add(Me.btn_UploadFile)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_EmailListeners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.gbx_Options.ResumeLayout(False)
        Me.gbx_Options.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Upload As Button
    Friend WithEvents ofd_SelectFile As OpenFileDialog
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents txt_FileLocation As TextBox
    Friend WithEvents btn_Browse As Button
    Friend WithEvents bw_Upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents btn_SendEmails As Button
    Friend WithEvents btn_ViewListeners As Button
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents rdo_GoingLive As RadioButton
    Friend WithEvents rdo_EmailMinistry As RadioButton
    Friend WithEvents cbx_FileList As ComboBox
    Friend WithEvents btn_UploadFile As Button
    Friend WithEvents gbx_Options As GroupBox
    Friend WithEvents rdo_Sermon As RadioButton
    Friend WithEvents rdo_Receipt As RadioButton
    Friend WithEvents chk_Attachment As CheckBox
    Friend WithEvents btn_CancelUpload As Button
End Class
