<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordDialog))
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_ChangePassword = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lbl_ConfirmPassword = New System.Windows.Forms.Label()
        Me.tss_UserFeedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.ss_Feedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(34, 125)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(295, 26)
        Me.txt_Password.TabIndex = 3
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(34, 55)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(295, 26)
        Me.txt_Username.TabIndex = 1
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(34, 103)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(106, 19)
        Me.lbl_Password.TabIndex = 2
        Me.lbl_Password.Text = "New Password:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(34, 33)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(73, 19)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username:"
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ChangePassword.Location = New System.Drawing.Point(209, 244)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(82, 48)
        Me.btn_ChangePassword.TabIndex = 7
        Me.btn_ChangePassword.Text = "Change Password"
        Me.btn_ChangePassword.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(71, 244)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(82, 48)
        Me.btn_Cancel.TabIndex = 6
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(34, 195)
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(295, 26)
        Me.txt_ConfirmPassword.TabIndex = 5
        Me.txt_ConfirmPassword.UseSystemPasswordChar = True
        '
        'lbl_ConfirmPassword
        '
        Me.lbl_ConfirmPassword.AutoSize = True
        Me.lbl_ConfirmPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConfirmPassword.Location = New System.Drawing.Point(34, 173)
        Me.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword"
        Me.lbl_ConfirmPassword.Size = New System.Drawing.Size(125, 19)
        Me.lbl_ConfirmPassword.TabIndex = 4
        Me.lbl_ConfirmPassword.Text = "Confirm Password:"
        '
        'tss_UserFeedback
        '
        Me.tss_UserFeedback.BackColor = System.Drawing.Color.Transparent
        Me.tss_UserFeedback.Name = "tss_UserFeedback"
        Me.tss_UserFeedback.Size = New System.Drawing.Size(345, 17)
        Me.tss_UserFeedback.Text = "Enter the username of the user to change and the new password"
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UserFeedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 302)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(362, 22)
        Me.ss_Feedback.TabIndex = 8
        '
        'ChangePasswordDialog
        '
        Me.AcceptButton = Me.btn_ChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(362, 324)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.txt_ConfirmPassword)
        Me.Controls.Add(Me.lbl_ConfirmPassword)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.btn_ChangePassword)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangePasswordDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_ChangePassword As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents txt_ConfirmPassword As TextBox
    Friend WithEvents lbl_ConfirmPassword As Label
    Friend WithEvents tss_UserFeedback As ToolStripStatusLabel
    Friend WithEvents ss_Feedback As StatusStrip
End Class
