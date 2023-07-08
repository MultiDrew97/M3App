<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FolderCreationDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolderCreationDialog))
        Me.txt_FolderName = New System.Windows.Forms.TextBox()
        Me.lbl_FolderName = New System.Windows.Forms.Label()
        Me.btn_CreateFolder = New System.Windows.Forms.Button()
        Me.ts_Feedback = New System.Windows.Forms.ToolStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripLabel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.ts_Feedback.SuspendLayout()
        Me.SuspendLayout()
		'
		'txt_FolderName
		'
		Me.txt_FolderName.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_FolderName.Font = Global.MediaMinistry.My.MySettings.Default.CurrentFont
		Me.txt_FolderName.Location = New System.Drawing.Point(53, 48)
		Me.txt_FolderName.Name = "txt_FolderName"
		Me.txt_FolderName.Size = New System.Drawing.Size(332, 31)
		Me.txt_FolderName.TabIndex = 0
		'
		'lbl_FolderName
		'
		Me.lbl_FolderName.AutoSize = True
		Me.lbl_FolderName.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_FolderName.Font = Global.MediaMinistry.My.MySettings.Default.CurrentFont
		Me.lbl_FolderName.Location = New System.Drawing.Point(48, 19)
		Me.lbl_FolderName.Name = "lbl_FolderName"
		Me.lbl_FolderName.Size = New System.Drawing.Size(153, 25)
		Me.lbl_FolderName.TabIndex = 1
		Me.lbl_FolderName.Text = "Folder Name:"
		'
		'btn_CreateFolder
		'
		Me.btn_CreateFolder.AutoSize = True
		Me.btn_CreateFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_CreateFolder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_CreateFolder.Font = Global.MediaMinistry.My.MySettings.Default.CurrentFont
		Me.btn_CreateFolder.Location = New System.Drawing.Point(224, 120)
		Me.btn_CreateFolder.MinimumSize = New System.Drawing.Size(150, 50)
		Me.btn_CreateFolder.Name = "btn_CreateFolder"
		Me.btn_CreateFolder.Size = New System.Drawing.Size(166, 50)
		Me.btn_CreateFolder.TabIndex = 2
		Me.btn_CreateFolder.Text = "Create Folder"
		Me.btn_CreateFolder.UseVisualStyleBackColor = True
		'
		'ts_Feedback
		'
		Me.ts_Feedback.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ts_Feedback.Location = New System.Drawing.Point(0, 201)
		Me.ts_Feedback.Name = "ts_Feedback"
		Me.ts_Feedback.Size = New System.Drawing.Size(439, 25)
		Me.ts_Feedback.TabIndex = 3
		Me.ts_Feedback.Text = "Feedback"
		'
		'tss_Feedback
		'
		Me.tss_Feedback.Name = "tss_Feedback"
		Me.tss_Feedback.Size = New System.Drawing.Size(183, 22)
		Me.tss_Feedback.Text = "Enter the name of the new folder."
		'
		'btn_Cancel
		'
		Me.btn_Cancel.AutoSize = True
		Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Cancel.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_Cancel.Font = Global.MediaMinistry.My.MySettings.Default.CurrentFont
		Me.btn_Cancel.Location = New System.Drawing.Point(50, 120)
        Me.btn_Cancel.MinimumSize = New System.Drawing.Size(150, 50)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(150, 50)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'FolderCreationDialog
        '
        Me.AcceptButton = Me.btn_CreateFolder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(439, 226)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.ts_Feedback)
        Me.Controls.Add(Me.btn_CreateFolder)
        Me.Controls.Add(Me.lbl_FolderName)
        Me.Controls.Add(Me.txt_FolderName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FolderCreationDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ts_Feedback.ResumeLayout(False)
        Me.ts_Feedback.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_FolderName As TextBox
    Friend WithEvents lbl_FolderName As Label
    Friend WithEvents btn_CreateFolder As Button
    Friend WithEvents ts_Feedback As ToolStrip
    Friend WithEvents tss_Feedback As ToolStripLabel
    Friend WithEvents btn_Cancel As Button
End Class
