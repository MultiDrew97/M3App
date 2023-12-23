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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Price, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Price, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(150, 45)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txt_Price
        '
        Me.txt_Price.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Price.Location = New System.Drawing.Point(3, 25)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(144, 20)
        Me.txt_Price.TabIndex = 2
        Me.txt_Price.Text = "$ 0.00"
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Price
        '
        Me.lbl_Price.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Price.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Price.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(144, 16)
        Me.lbl_Price.TabIndex = 1
        Me.lbl_Price.Text = "Price"
        Me.lbl_Price.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PriceInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(0, 45)
        Me.MinimumSize = New System.Drawing.Size(150, 45)
        Me.Name = "PriceInput"
        Me.Size = New System.Drawing.Size(150, 45)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_Price As Windows.Forms.TextBox
    Friend WithEvents lbl_Price As Windows.Forms.Label
End Class
