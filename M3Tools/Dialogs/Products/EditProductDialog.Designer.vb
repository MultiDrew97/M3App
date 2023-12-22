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
			Me.components = New System.ComponentModel.Container()
			Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.btn_Done = New System.Windows.Forms.Button()
			Me.btn_Cancel = New System.Windows.Forms.Button()
			Me.dbInventory = New SPPBC.M3Tools.Database.InventoryDatabase(Me.components)
			Me.chk_Available = New System.Windows.Forms.CheckBox()
			Me.gi_Name = New SPPBC.M3Tools.GenericInputPair()
			Me.qn_Stock = New SPPBC.M3Tools.QuantityNudCtrl()
			Me.pi_Price = New SPPBC.M3Tools.PriceInput()
			Me.TableLayoutPanel1.SuspendLayout()
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
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(93, 219)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
			Me.TableLayoutPanel1.TabIndex = 0
			'
			'btn_Done
			'
			Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btn_Done.Location = New System.Drawing.Point(76, 3)
			Me.btn_Done.Name = "btn_Done"
			Me.btn_Done.Size = New System.Drawing.Size(67, 23)
			Me.btn_Done.TabIndex = 0
			Me.btn_Done.Text = "Done"
			'
			'btn_Cancel
			'
			Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
			Me.btn_Cancel.Name = "btn_Cancel"
			Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
			Me.btn_Cancel.TabIndex = 1
			Me.btn_Cancel.Text = "Cancel"
			'
			'dbInventory
			'
			Me.dbInventory.BaseUrl = Nothing
			Me.dbInventory.Password = Nothing
			Me.dbInventory.Username = Nothing
			'
			'chk_Available
			'
			Me.chk_Available.AutoSize = True
			Me.chk_Available.Location = New System.Drawing.Point(88, 171)
			Me.chk_Available.Name = "chk_Available"
			Me.chk_Available.Size = New System.Drawing.Size(75, 17)
			Me.chk_Available.TabIndex = 7
			Me.chk_Available.Text = "Available?"
			Me.chk_Available.UseVisualStyleBackColor = True
			'
			'gi_Name
			'
			Me.gi_Name.AutoSize = True
			Me.gi_Name.LabelText = "Name"
			Me.gi_Name.Location = New System.Drawing.Point(27, 20)
			Me.gi_Name.Mask = ""
			Me.gi_Name.Name = "gi_Name"
			Me.gi_Name.Placeholder = "Product Name"
			Me.gi_Name.Size = New System.Drawing.Size(197, 35)
			Me.gi_Name.TabIndex = 8
			Me.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'qn_Stock
			'
			Me.qn_Stock.Location = New System.Drawing.Point(75, 61)
			Me.qn_Stock.MaximumSize = New System.Drawing.Size(0, 42)
			Me.qn_Stock.MinimumSize = New System.Drawing.Size(100, 42)
			Me.qn_Stock.Name = "qn_Stock"
			Me.qn_Stock.Quantity = 0
			Me.qn_Stock.Size = New System.Drawing.Size(100, 42)
			Me.qn_Stock.TabIndex = 9
			'
			'pi_Price
			'
			Me.pi_Price.AutoSize = True
			Me.pi_Price.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.pi_Price.Location = New System.Drawing.Point(50, 109)
			Me.pi_Price.MaximumSize = New System.Drawing.Size(150, 45)
			Me.pi_Price.MinimumSize = New System.Drawing.Size(150, 45)
			Me.pi_Price.Name = "pi_Price"
			Me.pi_Price.Price = 0R
			Me.pi_Price.Size = New System.Drawing.Size(150, 45)
			Me.pi_Price.TabIndex = 10
			'
			'EditProductDialog
			'
			Me.AcceptButton = Me.btn_Done
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btn_Cancel
			Me.ClientSize = New System.Drawing.Size(251, 260)
			Me.Controls.Add(Me.pi_Price)
			Me.Controls.Add(Me.qn_Stock)
			Me.Controls.Add(Me.gi_Name)
			Me.Controls.Add(Me.chk_Available)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "EditProductDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Edit {0}"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btn_Done As System.Windows.Forms.Button
        Friend WithEvents btn_Cancel As System.Windows.Forms.Button
        Friend WithEvents dbInventory As Database.InventoryDatabase
        Friend WithEvents chk_Available As Windows.Forms.CheckBox
        Friend WithEvents gi_Name As GenericInputPair
        Friend WithEvents qn_Stock As QuantityNudCtrl
        Friend WithEvents pi_Price As PriceInput
    End Class
End Namespace
