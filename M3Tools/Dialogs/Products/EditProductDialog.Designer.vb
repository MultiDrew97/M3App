Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EditProductDialog
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.btn_Done = New System.Windows.Forms.Button()
            Me.btn_Cancel = New System.Windows.Forms.Button()
            Me.chk_Available = New System.Windows.Forms.CheckBox()
            Me.gi_Name = New SPPBC.M3Tools.GenericInputPair()
            Me.qn_Stock = New SPPBC.M3Tools.QuantityNudCtrl()
            Me.pi_Price = New SPPBC.M3Tools.PriceInput()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Done, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 203)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'btn_Done
            '
            Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Done.Location = New System.Drawing.Point(76, 3)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(67, 23)
            Me.btn_Done.TabIndex = 1
            Me.btn_Done.Text = "Done"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
            Me.btn_Cancel.TabIndex = 0
            Me.btn_Cancel.Text = "Cancel"
            '
            'chk_Available
            '
            Me.chk_Available.AutoSize = True
            Me.chk_Available.Location = New System.Drawing.Point(131, 162)
            Me.chk_Available.Name = "chk_Available"
            Me.chk_Available.Size = New System.Drawing.Size(75, 17)
            Me.chk_Available.TabIndex = 3
            Me.chk_Available.Text = "Available?"
            Me.chk_Available.UseVisualStyleBackColor = True
            '
            'gi_Name
            '
            Me.gi_Name.AutoSize = True
            Me.gi_Name.Label = "Name"
            Me.gi_Name.Location = New System.Drawing.Point(18, 12)
            Me.gi_Name.Mask = ""
            Me.gi_Name.MaximumSize = New System.Drawing.Size(0, 45)
            Me.gi_Name.MinimumSize = New System.Drawing.Size(300, 45)
            Me.gi_Name.Name = "gi_Name"
            Me.gi_Name.Placeholder = "Product Name"
            Me.gi_Name.Size = New System.Drawing.Size(300, 45)
            Me.gi_Name.TabIndex = 0
            Me.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'qn_Stock
            '
            Me.qn_Stock.Label = "Stock"
            Me.qn_Stock.Location = New System.Drawing.Point(118, 63)
            Me.qn_Stock.MaximumSize = New System.Drawing.Size(0, 42)
            Me.qn_Stock.MaximumValue = 100
            Me.qn_Stock.MinimumSize = New System.Drawing.Size(100, 42)
            Me.qn_Stock.Name = "qn_Stock"
            Me.qn_Stock.Size = New System.Drawing.Size(100, 42)
            Me.qn_Stock.TabIndex = 1
            '
            'pi_Price
            '
            Me.pi_Price.AutoSize = True
            Me.pi_Price.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.pi_Price.Location = New System.Drawing.Point(93, 111)
            Me.pi_Price.MaximumSize = New System.Drawing.Size(150, 45)
            Me.pi_Price.MinimumSize = New System.Drawing.Size(150, 45)
            Me.pi_Price.Name = "pi_Price"
            Me.pi_Price.Price = New Decimal(New Integer() {0, 0, 0, 0})
            Me.pi_Price.Size = New System.Drawing.Size(150, 45)
            Me.pi_Price.TabIndex = 2
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pi_Price)
            Me.Panel1.Controls.Add(Me.gi_Name)
            Me.Panel1.Controls.Add(Me.qn_Stock)
            Me.Panel1.Controls.Add(Me.chk_Available)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(337, 197)
            Me.Panel1.TabIndex = 0
            '
            'EditProductDialog
            '
            Me.AcceptButton = Me.btn_Done
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btn_Cancel
            Me.ClientSize = New System.Drawing.Size(337, 244)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditProductDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Edit {0}"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btn_Done As System.Windows.Forms.Button
        Friend WithEvents btn_Cancel As System.Windows.Forms.Button
        Friend WithEvents chk_Available As Windows.Forms.CheckBox
        Friend WithEvents gi_Name As GenericInputPair
        Friend WithEvents qn_Stock As QuantityNudCtrl
        Friend WithEvents pi_Price As PriceInput
        Friend WithEvents Panel1 As Windows.Forms.Panel
    End Class
End Namespace
