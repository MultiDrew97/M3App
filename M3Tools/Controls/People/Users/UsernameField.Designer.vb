﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsernameField
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
        Me.spc_LabelInputs = New System.Windows.Forms.SplitContainer()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.spc_InputButton = New System.Windows.Forms.SplitContainer()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.btn_Show = New System.Windows.Forms.Button()
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
        'spc_LabelInputs
        '
        Me.spc_LabelInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_LabelInputs.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spc_LabelInputs.IsSplitterFixed = True
        Me.spc_LabelInputs.Location = New System.Drawing.Point(0, 0)
        Me.spc_LabelInputs.Name = "spc_LabelInputs"
        Me.spc_LabelInputs.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_LabelInputs.Panel1
        '
        Me.spc_LabelInputs.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.spc_LabelInputs.Panel1.Controls.Add(Me.lbl_Username)
        Me.spc_LabelInputs.Panel1MinSize = 15
        '
        'spc_LabelInputs.Panel2
        '
        Me.spc_LabelInputs.Panel2.Controls.Add(Me.spc_InputButton)
        Me.spc_LabelInputs.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.spc_LabelInputs.Size = New System.Drawing.Size(300, 50)
        Me.spc_LabelInputs.SplitterDistance = 24
        Me.spc_LabelInputs.SplitterWidth = 1
        Me.spc_LabelInputs.TabIndex = 3
        Me.spc_LabelInputs.TabStop = False
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(0, 4)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(83, 20)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username"
        Me.lbl_Username.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'spc_InputButton
        '
        Me.spc_InputButton.BackColor = System.Drawing.Color.Transparent
        Me.spc_InputButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_InputButton.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spc_InputButton.IsSplitterFixed = True
        Me.spc_InputButton.Location = New System.Drawing.Point(0, 0)
        Me.spc_InputButton.Name = "spc_InputButton"
        '
        'spc_InputButton.Panel1
        '
        Me.spc_InputButton.Panel1.Controls.Add(Me.txt_Username)
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
        'txt_Username
        '
        Me.txt_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(0, 0)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(255, 20)
        Me.txt_Username.TabIndex = 0
        '
        'btn_Show
        '
        Me.btn_Show.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Show.Enabled = False
        Me.btn_Show.Image = Global.SPPBC.M3Tools.My.Resources.Resources.ShowPasswordIcon
        Me.btn_Show.Location = New System.Drawing.Point(0, 0)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(41, 20)
        Me.btn_Show.TabIndex = 0
        Me.btn_Show.TabStop = False
        Me.btn_Show.UseVisualStyleBackColor = False
        Me.btn_Show.Visible = False
        '
        'UsernameField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.spc_LabelInputs)
        Me.MinimumSize = New System.Drawing.Size(300, 50)
        Me.Name = "UsernameField"
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

    Friend WithEvents spc_LabelInputs As Windows.Forms.SplitContainer
    Friend WithEvents lbl_Username As Windows.Forms.Label
    Friend WithEvents spc_InputButton As Windows.Forms.SplitContainer
    Friend WithEvents txt_Username As Windows.Forms.TextBox
    Friend WithEvents btn_Show As Windows.Forms.Button
End Class
