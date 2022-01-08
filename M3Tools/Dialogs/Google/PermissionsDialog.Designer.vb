<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissionsDialog
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cbx_Role = New System.Windows.Forms.ComboBox()
        Me.bsRoles = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Role = New System.Windows.Forms.Label()
        Me.cbx_Type = New System.Windows.Forms.ComboBox()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.bsTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.bsRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'cbx_Role
        '
        Me.cbx_Role.DataSource = Me.bsRoles
        Me.cbx_Role.FormattingEnabled = True
        Me.cbx_Role.Location = New System.Drawing.Point(101, 36)
        Me.cbx_Role.Name = "cbx_Role"
        Me.cbx_Role.Size = New System.Drawing.Size(184, 21)
        Me.cbx_Role.TabIndex = 1
        '
        'lbl_Role
        '
        Me.lbl_Role.AutoSize = True
        Me.lbl_Role.Location = New System.Drawing.Point(101, 17)
        Me.lbl_Role.Name = "lbl_Role"
        Me.lbl_Role.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Role.TabIndex = 2
        Me.lbl_Role.Text = "Role"
        '
        'cbx_Type
        '
        Me.cbx_Type.DataSource = Me.bsTypes
        Me.cbx_Type.FormattingEnabled = True
        Me.cbx_Type.Location = New System.Drawing.Point(101, 96)
        Me.cbx_Type.Name = "cbx_Type"
        Me.cbx_Type.Size = New System.Drawing.Size(184, 21)
        Me.cbx_Type.TabIndex = 1
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Location = New System.Drawing.Point(101, 77)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Type.TabIndex = 2
        Me.lbl_Type.Text = "Type"
        '
        'PermissionsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.lbl_Role)
        Me.Controls.Add(Me.cbx_Type)
        Me.Controls.Add(Me.cbx_Role)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PermissionsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PermissionsDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.bsRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents OK_Button As System.Windows.Forms.Button
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cbx_Role As Windows.Forms.ComboBox
    Friend WithEvents lbl_Role As Windows.Forms.Label
    Friend WithEvents cbx_Type As Windows.Forms.ComboBox
    Friend WithEvents lbl_Type As Windows.Forms.Label
    Friend WithEvents bsRoles As Windows.Forms.BindingSource
    Friend WithEvents bsTypes As Windows.Forms.BindingSource
End Class
