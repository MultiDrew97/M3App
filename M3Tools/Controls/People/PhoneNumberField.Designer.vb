<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneNumberField
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
        Me.txt_PhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_PhoneNumber = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PhoneNumber, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_PhoneNumber, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.89743!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.10256!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(383, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_PhoneNumber
        '
        Me.txt_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PhoneNumber.Location = New System.Drawing.Point(3, 16)
        Me.txt_PhoneNumber.Mask = "(999) 000-0000"
        Me.txt_PhoneNumber.Name = "txt_PhoneNumber"
        Me.txt_PhoneNumber.Size = New System.Drawing.Size(377, 20)
        Me.txt_PhoneNumber.TabIndex = 0
        '
        'lbl_PhoneNumber
        '
        Me.lbl_PhoneNumber.AutoSize = True
        Me.lbl_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_PhoneNumber.Location = New System.Drawing.Point(3, 0)
        Me.lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        Me.lbl_PhoneNumber.Size = New System.Drawing.Size(377, 13)
        Me.lbl_PhoneNumber.TabIndex = 1
        Me.lbl_PhoneNumber.Text = "Phone Number"
        '
        'PhoneNumberField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PhoneNumberField"
        Me.Size = New System.Drawing.Size(389, 45)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_PhoneNumber As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_PhoneNumber As Windows.Forms.Label
End Class
