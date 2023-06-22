<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomMessageDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMessageDialog))
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lbl_MessageSubject = New System.Windows.Forms.Label()
        Me.lbl_MessageBody = New System.Windows.Forms.Label()
        Me.txt_MessageSubject = New System.Windows.Forms.TextBox()
        Me.rtb_MessageBody = New System.Windows.Forms.RichTextBox()
        Me.tt_HelperInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_UseMessage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Cancel.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_Cancel.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_Cancel.Location = New System.Drawing.Point(136, 362)
        Me.btn_Cancel.MaximumSize = New System.Drawing.Size(200, 200)
        Me.btn_Cancel.MinimumSize = New System.Drawing.Size(100, 50)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(100, 50)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'lbl_MessageSubject
        '
        Me.lbl_MessageSubject.AutoSize = True
		Me.lbl_MessageSubject.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_MessageSubject.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_MessageSubject.Location = New System.Drawing.Point(36, 33)
        Me.lbl_MessageSubject.Name = "lbl_MessageSubject"
        Me.lbl_MessageSubject.Size = New System.Drawing.Size(98, 25)
        Me.lbl_MessageSubject.TabIndex = 2
        Me.lbl_MessageSubject.Text = "Subject:"
        '
        'lbl_MessageBody
        '
        Me.lbl_MessageBody.AutoSize = True
		Me.lbl_MessageBody.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_MessageBody.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_MessageBody.Location = New System.Drawing.Point(34, 107)
        Me.lbl_MessageBody.Name = "lbl_MessageBody"
        Me.lbl_MessageBody.Size = New System.Drawing.Size(114, 25)
        Me.lbl_MessageBody.TabIndex = 3
        Me.lbl_MessageBody.Text = "Message:"
		'
		'txt_MessageSubject
		'
		Me.txt_MessageSubject.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_MessageSubject.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.txt_MessageSubject.Location = New System.Drawing.Point(39, 61)
		Me.txt_MessageSubject.Name = "txt_MessageSubject"
		Me.txt_MessageSubject.Size = New System.Drawing.Size(417, 31)
		Me.txt_MessageSubject.TabIndex = 4
		'
		'rtb_MessageBody
		'
		Me.rtb_MessageBody.AcceptsTab = True
		Me.rtb_MessageBody.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.rtb_MessageBody.EnableAutoDragDrop = True
		Me.rtb_MessageBody.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.rtb_MessageBody.Location = New System.Drawing.Point(37, 135)
		Me.rtb_MessageBody.MinimumSize = New System.Drawing.Size(600, 200)
		Me.rtb_MessageBody.Name = "rtb_MessageBody"
		Me.rtb_MessageBody.Size = New System.Drawing.Size(611, 200)
		Me.rtb_MessageBody.TabIndex = 5
		Me.rtb_MessageBody.Text = ""
		'
		'btn_UseMessage
		'
		Me.btn_UseMessage.AutoSize = True
		Me.btn_UseMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_UseMessage.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_UseMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_UseMessage.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_UseMessage.Location = New System.Drawing.Point(419, 362)
        Me.btn_UseMessage.MaximumSize = New System.Drawing.Size(200, 200)
        Me.btn_UseMessage.MinimumSize = New System.Drawing.Size(100, 50)
        Me.btn_UseMessage.Name = "btn_UseMessage"
        Me.btn_UseMessage.Size = New System.Drawing.Size(165, 50)
        Me.btn_UseMessage.TabIndex = 1
        Me.btn_UseMessage.Text = "Use Message"
        Me.btn_UseMessage.UseVisualStyleBackColor = True
        '
        'CustomMessageDialog
        '
        Me.AcceptButton = Me.btn_UseMessage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btn_Cancel
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.rtb_MessageBody)
        Me.Controls.Add(Me.txt_MessageSubject)
        Me.Controls.Add(Me.lbl_MessageBody)
        Me.Controls.Add(Me.lbl_MessageSubject)
        Me.Controls.Add(Me.btn_UseMessage)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(700, 500)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "CustomMessageDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents lbl_MessageSubject As Label
    Friend WithEvents lbl_MessageBody As Label
    Friend WithEvents txt_MessageSubject As TextBox
    Friend WithEvents rtb_MessageBody As RichTextBox
    Friend WithEvents tt_HelperInfo As ToolTip
    Friend WithEvents btn_UseMessage As Button
End Class
