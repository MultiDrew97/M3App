<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFields
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
        Me.spc_UsernamePassword = New System.Windows.Forms.SplitContainer()
        Me.uf_Username = New M3Tools.UsernameField()
        Me.pf_Password = New M3Tools.PasswordField()
        CType(Me.spc_UsernamePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spc_UsernamePassword.Panel1.SuspendLayout()
        Me.spc_UsernamePassword.Panel2.SuspendLayout()
        Me.spc_UsernamePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_UsernamePassword
        '
        Me.spc_UsernamePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_UsernamePassword.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spc_UsernamePassword.IsSplitterFixed = True
        Me.spc_UsernamePassword.Location = New System.Drawing.Point(10, 10)
        Me.spc_UsernamePassword.Name = "spc_UsernamePassword"
        Me.spc_UsernamePassword.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_UsernamePassword.Panel1
        '
        Me.spc_UsernamePassword.Panel1.Controls.Add(Me.uf_Username)
        Me.spc_UsernamePassword.Panel1MinSize = 50
        '
        'spc_UsernamePassword.Panel2
        '
        Me.spc_UsernamePassword.Panel2.Controls.Add(Me.pf_Password)
        Me.spc_UsernamePassword.Panel2MinSize = 50
        Me.spc_UsernamePassword.Size = New System.Drawing.Size(415, 150)
        Me.spc_UsernamePassword.SplitterDistance = 72
        Me.spc_UsernamePassword.SplitterWidth = 10
        Me.spc_UsernamePassword.TabIndex = 1
        Me.spc_UsernamePassword.TabStop = False
        '
        'uf_Username
        '
        Me.uf_Username.AutoSize = True
        Me.uf_Username.BackColor = System.Drawing.SystemColors.Control
        Me.uf_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uf_Username.Location = New System.Drawing.Point(0, 0)
        Me.uf_Username.Name = "uf_Username"
        Me.uf_Username.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.uf_Username.Size = New System.Drawing.Size(415, 72)
        Me.uf_Username.TabIndex = 0
        '
        'pf_Password
        '
        Me.pf_Password.AutoSize = True
        Me.pf_Password.BackColor = System.Drawing.SystemColors.Control
        Me.pf_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pf_Password.Location = New System.Drawing.Point(0, 0)
        Me.pf_Password.Name = "pf_Password"
        Me.pf_Password.Size = New System.Drawing.Size(415, 68)
        Me.pf_Password.TabIndex = 0
        '
        'LoginFields
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.spc_UsernamePassword)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "LoginFields"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(435, 170)
        Me.spc_UsernamePassword.Panel1.ResumeLayout(False)
        Me.spc_UsernamePassword.Panel1.PerformLayout()
        Me.spc_UsernamePassword.Panel2.ResumeLayout(False)
        Me.spc_UsernamePassword.Panel2.PerformLayout()
        CType(Me.spc_UsernamePassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spc_UsernamePassword.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_UsernamePassword As Windows.Forms.SplitContainer
    Friend WithEvents pf_Password As PasswordField
    Friend WithEvents uf_Username As UsernameField
End Class
