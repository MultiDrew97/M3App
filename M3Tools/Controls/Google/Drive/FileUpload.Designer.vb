<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileUpload
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Me.ofd_FileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.sc_Label = New System.Windows.Forms.SplitContainer()
        Me.lbl_Upload = New System.Windows.Forms.Label()
        Me.sc_Upload = New System.Windows.Forms.SplitContainer()
        Me.txt_FileName = New System.Windows.Forms.TextBox()
        Me.btn_Select = New System.Windows.Forms.Button()
        CType(Me.sc_Label, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc_Label.Panel1.SuspendLayout()
        Me.sc_Label.Panel2.SuspendLayout()
        Me.sc_Label.SuspendLayout()
        CType(Me.sc_Upload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc_Upload.Panel1.SuspendLayout()
        Me.sc_Upload.Panel2.SuspendLayout()
        Me.sc_Upload.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd_FileDialog
        '
        Me.ofd_FileDialog.Multiselect = True
        Me.ofd_FileDialog.Title = "Upload New File(s)"
        '
        'sc_Label
        '
        Me.sc_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sc_Label.Location = New System.Drawing.Point(3, 0)
        Me.sc_Label.Name = "sc_Label"
        Me.sc_Label.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sc_Label.Panel1
        '
        Me.sc_Label.Panel1.Controls.Add(Me.lbl_Upload)
        '
        'sc_Label.Panel2
        '
        Me.sc_Label.Panel2.Controls.Add(Me.sc_Upload)
        Me.sc_Label.Size = New System.Drawing.Size(314, 56)
        Me.sc_Label.SplitterDistance = 25
        Me.sc_Label.TabIndex = 0
        '
        'lbl_Upload
        '
        Me.lbl_Upload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Upload.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Upload.Name = "lbl_Upload"
        Me.lbl_Upload.Size = New System.Drawing.Size(314, 25)
        Me.lbl_Upload.TabIndex = 0
        Me.lbl_Upload.Text = "Files"
        Me.lbl_Upload.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'sc_Upload
        '
        Me.sc_Upload.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sc_Upload.Location = New System.Drawing.Point(3, 3)
        Me.sc_Upload.Name = "sc_Upload"
        '
        'sc_Upload.Panel1
        '
        Me.sc_Upload.Panel1.Controls.Add(Me.txt_FileName)
        '
        'sc_Upload.Panel2
        '
        Me.sc_Upload.Panel2.Controls.Add(Me.btn_Select)
        Me.sc_Upload.Size = New System.Drawing.Size(307, 22)
        Me.sc_Upload.SplitterDistance = 273
        Me.sc_Upload.TabIndex = 0
        '
        'txt_FileName
        '
        Me.txt_FileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_FileName.Location = New System.Drawing.Point(0, 0)
        Me.txt_FileName.Multiline = True
        Me.txt_FileName.Name = "txt_FileName"
        Me.txt_FileName.ReadOnly = True
        Me.txt_FileName.Size = New System.Drawing.Size(273, 22)
        Me.txt_FileName.TabIndex = 0
        '
        'btn_Select
        '
        Me.btn_Select.AutoSize = True
        Me.btn_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Select.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Select.Location = New System.Drawing.Point(0, 0)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(30, 22)
        Me.btn_Select.TabIndex = 0
        Me.btn_Select.Text = "..."
        Me.btn_Select.UseVisualStyleBackColor = True
        '
        'FileUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sc_Label)
        Me.Name = "FileUpload"
        Me.Size = New System.Drawing.Size(320, 59)
        Me.sc_Label.Panel1.ResumeLayout(False)
        Me.sc_Label.Panel2.ResumeLayout(False)
        CType(Me.sc_Label, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc_Label.ResumeLayout(False)
        Me.sc_Upload.Panel1.ResumeLayout(False)
        Me.sc_Upload.Panel1.PerformLayout()
        Me.sc_Upload.Panel2.ResumeLayout(False)
        Me.sc_Upload.Panel2.PerformLayout()
        CType(Me.sc_Upload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc_Upload.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ofd_FileDialog As Windows.Forms.OpenFileDialog
	Friend WithEvents sc_Label As Windows.Forms.SplitContainer
    Friend WithEvents lbl_Upload As Windows.Forms.Label
    Friend WithEvents sc_Upload As Windows.Forms.SplitContainer
    Friend WithEvents txt_FileName As Windows.Forms.TextBox
    Friend WithEvents btn_Select As Windows.Forms.Button
End Class
