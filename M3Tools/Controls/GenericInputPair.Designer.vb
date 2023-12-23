<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenericInputPair
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
        Me.lbl_InputLabel = New System.Windows.Forms.Label()
        Me.txt_Input = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_InputLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Input, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_InputLabel
        '
        Me.lbl_InputLabel.AutoSize = True
        Me.lbl_InputLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_InputLabel.Location = New System.Drawing.Point(3, 0)
        Me.lbl_InputLabel.Name = "lbl_InputLabel"
        Me.lbl_InputLabel.Size = New System.Drawing.Size(294, 22)
        Me.lbl_InputLabel.TabIndex = 0
        Me.lbl_InputLabel.Text = "Label1"
        Me.lbl_InputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_Input
        '
        Me.txt_Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Input.Location = New System.Drawing.Point(3, 25)
        Me.txt_Input.Name = "txt_Input"
        Me.txt_Input.Size = New System.Drawing.Size(294, 20)
        Me.txt_Input.TabIndex = 1
        '
        'GenericInputPair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(0, 45)
        Me.MinimumSize = New System.Drawing.Size(300, 45)
        Me.Name = "GenericInputPair"
        Me.Size = New System.Drawing.Size(300, 45)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_InputLabel As Windows.Forms.Label
    Friend WithEvents txt_Input As Windows.Forms.MaskedTextBox
End Class
