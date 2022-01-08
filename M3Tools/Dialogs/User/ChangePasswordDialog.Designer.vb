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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.pf_Password = New SPPBC.M3Tools.PasswordField()
        Me.ConfirmPasswordField1 = New SPPBC.M3Tools.ConfirmPasswordField()
        Me.db_Users = New SPPBC.M3Tools.Database.UserDatabase(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Reset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(74, 148)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Reset
        '
        Me.btn_Reset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Reset.Location = New System.Drawing.Point(101, 3)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(92, 29)
        Me.btn_Reset.TabIndex = 0
        Me.btn_Reset.Text = "Reset Password"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 29)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'pf_Password
        '
        Me.pf_Password.AutoSize = True
        Me.pf_Password.BackColor = System.Drawing.SystemColors.Control
        Me.pf_Password.Location = New System.Drawing.Point(12, 12)
        Me.pf_Password.Name = "pf_Password"
        Me.pf_Password.Size = New System.Drawing.Size(249, 56)
        Me.pf_Password.TabIndex = 4
        '
        'ConfirmPasswordField1
        '
        Me.ConfirmPasswordField1.AutoSize = True
        Me.ConfirmPasswordField1.BackColor = System.Drawing.SystemColors.Control
        Me.ConfirmPasswordField1.Location = New System.Drawing.Point(12, 74)
        Me.ConfirmPasswordField1.Name = "ConfirmPasswordField1"
        Me.ConfirmPasswordField1.Size = New System.Drawing.Size(249, 62)
        Me.ConfirmPasswordField1.TabIndex = 3
        '
        'db_Users
        '
        Me.db_Users.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
        Me.db_Users.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
        Me.db_Users.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
        '
        'ChangePasswordDialog
        '
        Me.AcceptButton = Me.btn_Reset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(282, 195)
        Me.Controls.Add(Me.pf_Password)
        Me.Controls.Add(Me.ConfirmPasswordField1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePasswordDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Reset As System.Windows.Forms.Button
	Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents db_Users As Database.UserDatabase
    Friend WithEvents ConfirmPasswordField1 As ConfirmPasswordField
    Friend WithEvents pf_Password As PasswordField
End Class
