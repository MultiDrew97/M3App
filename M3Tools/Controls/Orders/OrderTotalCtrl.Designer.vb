<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderTotalCtrl
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
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.lbl_Total = New System.Windows.Forms.Label()
		Me.txt_Total = New System.Windows.Forms.TextBox()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.MinimumSize = New System.Drawing.Size(0, 20)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_Total)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Total)
		Me.SplitContainer1.Size = New System.Drawing.Size(115, 20)
		Me.SplitContainer1.SplitterDistance = 39
		Me.SplitContainer1.TabIndex = 0
		'
		'lbl_Total
		'
		Me.lbl_Total.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbl_Total.Location = New System.Drawing.Point(0, 0)
		Me.lbl_Total.Name = "lbl_Total"
		Me.lbl_Total.Size = New System.Drawing.Size(39, 20)
		Me.lbl_Total.TabIndex = 5
		Me.lbl_Total.Text = "Total:"
		Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txt_Total
		'
		Me.txt_Total.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txt_Total.Enabled = False
		Me.txt_Total.Location = New System.Drawing.Point(0, 0)
		Me.txt_Total.Name = "txt_Total"
		Me.txt_Total.ReadOnly = True
		Me.txt_Total.Size = New System.Drawing.Size(72, 20)
		Me.txt_Total.TabIndex = 7
		Me.txt_Total.Text = "0"
		Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'OrderTotalCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.SplitContainer1)
		Me.MaximumSize = New System.Drawing.Size(115, 20)
		Me.MinimumSize = New System.Drawing.Size(95, 20)
		Me.Name = "OrderTotalCtrl"
		Me.Size = New System.Drawing.Size(115, 20)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
	Friend WithEvents lbl_Total As Windows.Forms.Label
	Friend WithEvents txt_Total As Windows.Forms.TextBox
End Class
