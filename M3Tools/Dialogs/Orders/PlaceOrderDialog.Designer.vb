<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaceOrderDialog
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
		Me.btn_Checkout = New System.Windows.Forms.Button()
		Me.btn_Cancel = New System.Windows.Forms.Button()
		Me.btn_AddCart = New System.Windows.Forms.Button()
		Me.bw_PlaceOrders = New System.ComponentModel.BackgroundWorker()
		Me.otc_Total = New SPPBC.M3Tools.OrderTotalCtrl()
		Me.qnc_Quantity = New SPPBC.M3Tools.QuantityNudCtrl()
		Me.ccb_Customers = New SPPBC.M3Tools.CustomersComboBox()
		Me.pcb_Items = New SPPBC.M3Tools.ProductsComboBox()
		Me.cc_Cart = New SPPBC.M3Tools.CartCtrl()
		Me.db_Orders = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.btn_Checkout, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(37, 219)
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
		'btn_AddCart
		'
		Me.btn_AddCart.Location = New System.Drawing.Point(137, 129)
		Me.btn_AddCart.Name = "btn_AddCart"
		Me.btn_AddCart.Size = New System.Drawing.Size(75, 23)
		Me.btn_AddCart.TabIndex = 7
		Me.btn_AddCart.Text = "Add to Cart"
		Me.btn_AddCart.UseVisualStyleBackColor = True
		'
		'bw_PlaceOrders
		'
		'
		'otc_Total
		'
		Me.otc_Total.Location = New System.Drawing.Point(55, 179)
		Me.otc_Total.MaximumSize = New System.Drawing.Size(115, 20)
		Me.otc_Total.MinimumSize = New System.Drawing.Size(95, 20)
		Me.otc_Total.Name = "otc_Total"
		Me.otc_Total.Size = New System.Drawing.Size(115, 20)
		Me.otc_Total.TabIndex = 8
		Me.otc_Total.Total = 0R
		'
		'qnc_Quantity
		'
		Me.qnc_Quantity.Location = New System.Drawing.Point(12, 119)
		Me.qnc_Quantity.MaximumSize = New System.Drawing.Size(0, 42)
		Me.qnc_Quantity.MinimumSize = New System.Drawing.Size(100, 42)
		Me.qnc_Quantity.Name = "qnc_Quantity"
		Me.qnc_Quantity.Quantity = 1
		Me.qnc_Quantity.Size = New System.Drawing.Size(100, 42)
		Me.qnc_Quantity.TabIndex = 3
		'
		'ccb_Customers
		'
		Me.ccb_Customers.AutoSize = True
		Me.ccb_Customers.Location = New System.Drawing.Point(12, 14)
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
		Me.pcb_Items.Location = New System.Drawing.Point(12, 62)
		Me.pcb_Items.MaximumSize = New System.Drawing.Size(0, 42)
		Me.pcb_Items.MinimumSize = New System.Drawing.Size(200, 42)
		Me.pcb_Items.Name = "pcb_Items"
		Me.pcb_Items.SelectedIndex = -1
		Me.pcb_Items.SelectedItem = Nothing
		Me.pcb_Items.SelectedValue = Nothing
		Me.pcb_Items.Size = New System.Drawing.Size(200, 42)
		Me.pcb_Items.TabIndex = 1
		'
		'cc_Cart
		'
		Me.cc_Cart.Dock = System.Windows.Forms.DockStyle.Right
		Me.cc_Cart.Location = New System.Drawing.Point(218, 0)
		Me.cc_Cart.Name = "cc_Cart"
		Me.cc_Cart.Size = New System.Drawing.Size(367, 260)
		Me.cc_Cart.TabIndex = 9
		'
		'db_Orders
		'
		Me.db_Orders.BaseUrl = "Media Ministry Test"
		Me.db_Orders.Password = "M3AppPassword2499"
		Me.db_Orders.Username = "M3App"
		'
		'PlaceOrderDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(585, 260)
		Me.Controls.Add(Me.otc_Total)
		Me.Controls.Add(Me.btn_AddCart)
		Me.Controls.Add(Me.qnc_Quantity)
		Me.Controls.Add(Me.ccb_Customers)
		Me.Controls.Add(Me.pcb_Items)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.cc_Cart)
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
	Friend WithEvents qnc_Quantity As QuantityNudCtrl
	Friend WithEvents btn_AddCart As Windows.Forms.Button
	Friend WithEvents bw_PlaceOrders As ComponentModel.BackgroundWorker
	Friend WithEvents otc_Total As OrderTotalCtrl
	Friend WithEvents cc_Cart As CartCtrl
	Friend WithEvents db_Orders As Database.OrdersDatabase
End Class
