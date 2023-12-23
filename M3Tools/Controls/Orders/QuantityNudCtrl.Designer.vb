<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuantityNudCtrl
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.nud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Quantity, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nud_Quantity, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.55556!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.44444!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(100, 45)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Quantity.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Quantity.MaximumSize = New System.Drawing.Size(0, 20)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(94, 16)
        Me.lbl_Quantity.TabIndex = 0
        Me.lbl_Quantity.Text = "Quantity"
        Me.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'nud_Quantity
        '
        Me.nud_Quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nud_Quantity.Location = New System.Drawing.Point(3, 19)
        Me.nud_Quantity.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nud_Quantity.Name = "nud_Quantity"
        Me.nud_Quantity.Size = New System.Drawing.Size(94, 20)
        Me.nud_Quantity.TabIndex = 1
        Me.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_Quantity.ThousandsSeparator = True
        '
        'QuantityNudCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(0, 45)
        Me.MinimumSize = New System.Drawing.Size(100, 45)
        Me.Name = "QuantityNudCtrl"
        Me.Size = New System.Drawing.Size(100, 45)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
	Friend WithEvents lbl_Quantity As Windows.Forms.Label
    Friend WithEvents nud_Quantity As Windows.Forms.NumericUpDown
End Class
