<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceInput
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
        Me.sct_Input = New System.Windows.Forms.SplitContainer()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        CType(Me.sct_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sct_Input.Panel1.SuspendLayout()
        Me.sct_Input.Panel2.SuspendLayout()
        Me.sct_Input.SuspendLayout()
        Me.SuspendLayout()
        '
        'sct_Input
        '
        Me.sct_Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sct_Input.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.sct_Input.IsSplitterFixed = True
        Me.sct_Input.Location = New System.Drawing.Point(0, 0)
        Me.sct_Input.MaximumSize = New System.Drawing.Size(150, 50)
        Me.sct_Input.MinimumSize = New System.Drawing.Size(150, 50)
        Me.sct_Input.Name = "sct_Input"
        Me.sct_Input.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sct_Input.Panel1
        '
        Me.sct_Input.Panel1.Controls.Add(Me.lbl_Price)
        Me.sct_Input.Panel1MinSize = 20
        '
        'sct_Input.Panel2
        '
        Me.sct_Input.Panel2.Controls.Add(Me.txt_Price)
        Me.sct_Input.Panel2MinSize = 20
        Me.sct_Input.Size = New System.Drawing.Size(150, 50)
        Me.sct_Input.SplitterDistance = 24
        Me.sct_Input.SplitterWidth = 1
        Me.sct_Input.TabIndex = 0
        '
        'lbl_Price
        '
        Me.lbl_Price.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Price.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Price.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(150, 24)
        Me.lbl_Price.TabIndex = 0
        Me.lbl_Price.Text = "Price"
        Me.lbl_Price.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_Price
        '
        Me.txt_Price.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Price.Location = New System.Drawing.Point(0, 0)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(150, 20)
        Me.txt_Price.TabIndex = 0
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PriceInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.sct_Input)
        Me.MaximumSize = New System.Drawing.Size(150, 45)
        Me.MinimumSize = New System.Drawing.Size(150, 45)
        Me.Name = "PriceInput"
        Me.Size = New System.Drawing.Size(150, 45)
        Me.sct_Input.Panel1.ResumeLayout(False)
        Me.sct_Input.Panel2.ResumeLayout(False)
        Me.sct_Input.Panel2.PerformLayout()
        CType(Me.sct_Input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sct_Input.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sct_Input As Windows.Forms.SplitContainer
    Friend WithEvents lbl_Price As Windows.Forms.Label
    Friend WithEvents txt_Price As Windows.Forms.TextBox
End Class
