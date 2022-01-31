Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmPasswordField
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_ConfirmPassword = New System.Windows.Forms.Label()
        Me.txt_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.spc_LabelInputs = New System.Windows.Forms.SplitContainer()
        Me.spc_InputButton = New System.Windows.Forms.SplitContainer()
        CType(Me.spc_LabelInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spc_LabelInputs.Panel1.SuspendLayout()
        Me.spc_LabelInputs.Panel2.SuspendLayout()
        Me.spc_LabelInputs.SuspendLayout()
        CType(Me.spc_InputButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spc_InputButton.Panel1.SuspendLayout()
        Me.spc_InputButton.Panel2.SuspendLayout()
        Me.spc_InputButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ConfirmPassword
        '
        Me.lbl_ConfirmPassword.AutoSize = True
        Me.lbl_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConfirmPassword.Location = New System.Drawing.Point(0, 4)
        Me.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword"
        Me.lbl_ConfirmPassword.Size = New System.Drawing.Size(137, 20)
        Me.lbl_ConfirmPassword.TabIndex = 0
        Me.lbl_ConfirmPassword.Text = "Confirm Password"
        Me.lbl_ConfirmPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(0, 0)
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(255, 20)
        Me.txt_ConfirmPassword.TabIndex = 0
        Me.txt_ConfirmPassword.UseSystemPasswordChar = True
        '
        'btn_Show
        '
        Me.btn_Show.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Show.Image = Global.SPPBC.M3Tools.My.Resources.Resources.ShowPasswordIcon
        Me.btn_Show.Location = New System.Drawing.Point(0, 0)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(41, 20)
        Me.btn_Show.TabIndex = 0
        Me.btn_Show.TabStop = False
        Me.btn_Show.UseVisualStyleBackColor = True
        '
        'spc_LabelInputs
        '
        Me.spc_LabelInputs.BackColor = System.Drawing.Color.Transparent
        Me.spc_LabelInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_LabelInputs.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spc_LabelInputs.IsSplitterFixed = True
        Me.spc_LabelInputs.Location = New System.Drawing.Point(0, 0)
        Me.spc_LabelInputs.Name = "spc_LabelInputs"
        Me.spc_LabelInputs.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_LabelInputs.Panel1
        '
        Me.spc_LabelInputs.Panel1.Controls.Add(Me.lbl_ConfirmPassword)
        Me.spc_LabelInputs.Panel1MinSize = 15
        '
        'spc_LabelInputs.Panel2
        '
        Me.spc_LabelInputs.Panel2.Controls.Add(Me.spc_InputButton)
        Me.spc_LabelInputs.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.spc_LabelInputs.Size = New System.Drawing.Size(300, 50)
        Me.spc_LabelInputs.SplitterDistance = 24
        Me.spc_LabelInputs.SplitterWidth = 1
        Me.spc_LabelInputs.TabIndex = 2
        Me.spc_LabelInputs.TabStop = False
        '
        'spc_InputButton
        '
        Me.spc_InputButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_InputButton.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spc_InputButton.IsSplitterFixed = True
        Me.spc_InputButton.Location = New System.Drawing.Point(0, 0)
        Me.spc_InputButton.Name = "spc_InputButton"
        '
        'spc_InputButton.Panel1
        '
        Me.spc_InputButton.Panel1.Controls.Add(Me.txt_ConfirmPassword)
        '
        'spc_InputButton.Panel2
        '
        Me.spc_InputButton.Panel2.Controls.Add(Me.btn_Show)
        Me.spc_InputButton.Panel2MinSize = 40
        Me.spc_InputButton.Size = New System.Drawing.Size(300, 20)
        Me.spc_InputButton.SplitterDistance = 255
        Me.spc_InputButton.TabIndex = 0
        Me.spc_InputButton.TabStop = False
        '
        'ConfirmPasswordField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.spc_LabelInputs)
        Me.MinimumSize = New System.Drawing.Size(300, 50)
        Me.Name = "ConfirmPasswordField"
        Me.Size = New System.Drawing.Size(300, 50)
        Me.spc_LabelInputs.Panel1.ResumeLayout(False)
        Me.spc_LabelInputs.Panel1.PerformLayout()
        Me.spc_LabelInputs.Panel2.ResumeLayout(False)
        CType(Me.spc_LabelInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spc_LabelInputs.ResumeLayout(False)
        Me.spc_InputButton.Panel1.ResumeLayout(False)
        Me.spc_InputButton.Panel1.PerformLayout()
        Me.spc_InputButton.Panel2.ResumeLayout(False)
        CType(Me.spc_InputButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spc_InputButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lbl_ConfirmPassword As Label
    Private WithEvents txt_ConfirmPassword As TextBox
    Private WithEvents btn_Show As Button
    Friend WithEvents spc_LabelInputs As SplitContainer
    Friend WithEvents spc_InputButton As SplitContainer
End Class
