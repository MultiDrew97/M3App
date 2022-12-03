<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceOrderDialog
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
		Me.components = New System.ComponentModel.Container()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.btn_Checkout = New System.Windows.Forms.Button()
		Me.btn_Cancel = New System.Windows.Forms.Button()
		Me.ccb_Customers = New SPPBC.M3Tools.CustomersComboBox()
		Me.pcb_Items = New SPPBC.M3Tools.ProductsComboBox()
		Me.QuantityNudCtrl1 = New SPPBC.M3Tools.QuantityNudCtrl()
		Me.lbl_Total = New System.Windows.Forms.Label()
		Me.txt_Total = New System.Windows.Forms.TextBox()
		Me.btn_AddCart = New System.Windows.Forms.Button()
		Me.OrdersDatabase1 = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Checkout, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(148, 312)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'btn_Checkout
		'
		Me.btn_Checkout.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_Checkout.Location = New System.Drawing.Point(3, 3)
		Me.btn_Checkout.Name = "btn_Checkout"
		Me.btn_Checkout.Size = New System.Drawing.Size(67, 23)
		Me.btn_Checkout.TabIndex = 0
		Me.btn_Checkout.Text = "Checkout"
		'
		'btn_Cancel
		'
		Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_Cancel.Location = New System.Drawing.Point(76, 3)
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
		Me.btn_Cancel.TabIndex = 1
		Me.btn_Cancel.Text = "Cancel"
		'
		'ccb_Customers
		'
		Me.ccb_Customers.AutoSize = True
		Me.ccb_Customers.Location = New System.Drawing.Point(42, 12)
		Me.ccb_Customers.MaximumSize = New System.Drawing.Size(0, 42)
		Me.ccb_Customers.MinimumSize = New System.Drawing.Size(200, 42)
		Me.ccb_Customers.Name = "ccb_Customers"
		Me.ccb_Customers.SelectedIndex = -1
		Me.ccb_Customers.SelectedItem = Nothing
		Me.ccb_Customers.SelectedValue = Nothing
		Me.ccb_Customers.Size = New System.Drawing.Size(200, 42)
		Me.ccb_Customers.TabIndex = 2
		'
		'pcb_Items
		'
		Me.pcb_Items.AutoSize = True
		Me.pcb_Items.Location = New System.Drawing.Point(42, 76)
		Me.pcb_Items.MaximumSize = New System.Drawing.Size(0, 42)
		Me.pcb_Items.MinimumSize = New System.Drawing.Size(200, 42)
		Me.pcb_Items.Name = "pcb_Items"
		Me.pcb_Items.SelectedIndex = -1
		Me.pcb_Items.SelectedItem = Nothing
		Me.pcb_Items.SelectedValue = Nothing
		Me.pcb_Items.Size = New System.Drawing.Size(200, 42)
		Me.pcb_Items.TabIndex = 1
		'
		'QuantityNudCtrl1
		'
		Me.QuantityNudCtrl1.Location = New System.Drawing.Point(42, 124)
		Me.QuantityNudCtrl1.MaximumSize = New System.Drawing.Size(0, 42)
		Me.QuantityNudCtrl1.MinimumSize = New System.Drawing.Size(100, 42)
		Me.QuantityNudCtrl1.Name = "QuantityNudCtrl1"
		Me.QuantityNudCtrl1.Quantity = 1
		Me.QuantityNudCtrl1.Size = New System.Drawing.Size(100, 42)
		Me.QuantityNudCtrl1.TabIndex = 3
		'
		'lbl_Total
		'
		Me.lbl_Total.AutoSize = True
		Me.lbl_Total.Location = New System.Drawing.Point(75, 258)
		Me.lbl_Total.Name = "lbl_Total"
		Me.lbl_Total.Size = New System.Drawing.Size(31, 13)
		Me.lbl_Total.TabIndex = 4
		Me.lbl_Total.Text = "Total"
		'
		'txt_Total
		'
		Me.txt_Total.Location = New System.Drawing.Point(118, 255)
		Me.txt_Total.Name = "txt_Total"
		Me.txt_Total.ReadOnly = True
		Me.txt_Total.Size = New System.Drawing.Size(100, 20)
		Me.txt_Total.TabIndex = 6
		'
		'btn_AddCart
		'
		Me.btn_AddCart.Location = New System.Drawing.Point(151, 133)
		Me.btn_AddCart.Name = "btn_AddCart"
		Me.btn_AddCart.Size = New System.Drawing.Size(75, 23)
		Me.btn_AddCart.TabIndex = 7
		Me.btn_AddCart.Text = "Add to Cart"
		Me.btn_AddCart.UseVisualStyleBackColor = True
		'
		'OrdersDatabase1
		'
		Me.OrdersDatabase1.InitialCatalog = "Media Ministry Test"
		Me.OrdersDatabase1.Password = "M3AppPassword2499"
		Me.OrdersDatabase1.Username = "M3App"
		'
		'PlaceOrderDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(306, 353)
		Me.Controls.Add(Me.btn_AddCart)
		Me.Controls.Add(Me.txt_Total)
		Me.Controls.Add(Me.lbl_Total)
		Me.Controls.Add(Me.QuantityNudCtrl1)
		Me.Controls.Add(Me.ccb_Customers)
		Me.Controls.Add(Me.pcb_Items)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "PlaceOrderDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "PlaceOrderDialog"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Checkout As System.Windows.Forms.Button
	Friend WithEvents btn_Cancel As System.Windows.Forms.Button
	Friend WithEvents pcb_Items As ProductsComboBox
	Friend WithEvents ccb_Customers As CustomersComboBox
	Friend WithEvents QuantityNudCtrl1 As QuantityNudCtrl
	Friend WithEvents lbl_Total As Windows.Forms.Label
	Friend WithEvents txt_Total As Windows.Forms.TextBox
	Friend WithEvents btn_AddCart As Windows.Forms.Button
	Friend WithEvents OrdersDatabase1 As Database.OrdersDatabase
	Friend WithEvents BackgroundWorker1 As ComponentModel.BackgroundWorker
End Class
