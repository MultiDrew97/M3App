<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminInfoDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInfoDialog))
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.ss_Info = New System.Windows.Forms.StatusStrip()
        Me.tss_Info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pf_Password = New MediaMinistry.PasswordField()
        Me.SuspendLayout()
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(126, 159)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(80, 29)
        Me.btn_Submit.TabIndex = 5
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(30, 8)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(96, 20)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username:"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(26, 80)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(91, 20)
        Me.lbl_Password.TabIndex = 2
        Me.lbl_Password.Text = "Password:"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txt_Username.Location = New System.Drawing.Point(30, 31)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(224, 32)
        Me.txt_Username.TabIndex = 1
        '
        'ss_Info
        '
        Me.ss_Info.Location = New System.Drawing.Point(0, 210)
        Me.ss_Info.Name = "ss_Info"
        Me.ss_Info.Size = New System.Drawing.Size(332, 22)
        Me.ss_Info.TabIndex = 6
        '
        'tss_Info
        '
        Me.tss_Info.Name = "tss_Info"
        Me.tss_Info.Size = New System.Drawing.Size(159, 17)
        Me.tss_Info.Text = "Enter the admin's credentials"
		'
		'pf_Password
		'
		Me.pf_Password.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pf_Password.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.pf_Password.Location = New System.Drawing.Point(30, 106)
        Me.pf_Password.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.pf_Password.Name = "pf_Password"
        Me.pf_Password.Size = New System.Drawing.Size(271, 40)
        Me.pf_Password.TabIndex = 7
        '
        'AdminInfoDialog
        '
        Me.AcceptButton = Me.btn_Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 232)
        Me.Controls.Add(Me.pf_Password)
        Me.Controls.Add(Me.ss_Info)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.btn_Submit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdminInfoDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Submit As Button
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents ss_Info As StatusStrip
    Friend WithEvents tss_Info As ToolStripStatusLabel
    Friend WithEvents pf_Password As PasswordField
End Class
