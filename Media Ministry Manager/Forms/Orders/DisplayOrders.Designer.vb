<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DisplayOrders
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DisplayOrders))
		Me.dgv_Orders = New System.Windows.Forms.DataGridView()
		Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrderTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
		Me.btn_Complete = New System.Windows.Forms.Button()
		Me.btn_ShowCompleted = New System.Windows.Forms.Button()
		Me.lbl_NoOrders = New System.Windows.Forms.Label()
		Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.mnstr_Strip.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgv_Orders
		'
		Me.dgv_Orders.AllowUserToAddRows = False
		Me.dgv_Orders.AllowUserToOrderColumns = True
		Me.dgv_Orders.AutoGenerateColumns = False
		Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
		Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerName, Me.ItemName, Me.Quantity, Me.OrderTotal})
		Me.dgv_Orders.DataSource = Me.bsOrders
		Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Right
		Me.dgv_Orders.Location = New System.Drawing.Point(157, 24)
		Me.dgv_Orders.Name = "dgv_Orders"
		Me.dgv_Orders.Size = New System.Drawing.Size(643, 426)
		Me.dgv_Orders.TabIndex = 0
		'
		'CustomerName
		'
		Me.CustomerName.DataPropertyName = "CustomerName"
		Me.CustomerName.HeaderText = "Customer Name"
		Me.CustomerName.Name = "CustomerName"
		'
		'ItemName
		'
		Me.ItemName.DataPropertyName = "ItemName"
		Me.ItemName.HeaderText = "Item Name"
		Me.ItemName.Name = "ItemName"
		'
		'Quantity
		'
		Me.Quantity.DataPropertyName = "Quantity"
		Me.Quantity.HeaderText = "Quantity"
		Me.Quantity.Name = "Quantity"
		'
		'OrderTotal
		'
		Me.OrderTotal.DataPropertyName = "OrderTotal"
		DataGridViewCellStyle1.Format = "C2"
		Me.OrderTotal.DefaultCellStyle = DataGridViewCellStyle1
		Me.OrderTotal.HeaderText = "Total"
		Me.OrderTotal.Name = "OrderTotal"
		'
		'btn_Complete
		'
		Me.btn_Complete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Complete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Complete.Location = New System.Drawing.Point(12, 55)
		Me.btn_Complete.Name = "btn_Complete"
		Me.btn_Complete.Size = New System.Drawing.Size(128, 63)
		Me.btn_Complete.TabIndex = 1
		Me.btn_Complete.Text = "Complete Order(s)"
		Me.btn_Complete.UseVisualStyleBackColor = True
		'
		'btn_ShowCompleted
		'
		Me.btn_ShowCompleted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_ShowCompleted.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_ShowCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ShowCompleted.Location = New System.Drawing.Point(12, 188)
		Me.btn_ShowCompleted.Name = "btn_ShowCompleted"
		Me.btn_ShowCompleted.Size = New System.Drawing.Size(128, 87)
		Me.btn_ShowCompleted.TabIndex = 1
		Me.btn_ShowCompleted.Text = "View Completed Orders"
		Me.btn_ShowCompleted.UseVisualStyleBackColor = True
		Me.btn_ShowCompleted.Visible = False
		'
		'lbl_NoOrders
		'
		Me.lbl_NoOrders.AutoSize = True
		Me.lbl_NoOrders.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_NoOrders.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
		Me.lbl_NoOrders.Location = New System.Drawing.Point(274, 219)
		Me.lbl_NoOrders.Name = "lbl_NoOrders"
		Me.lbl_NoOrders.Size = New System.Drawing.Size(397, 25)
		Me.lbl_NoOrders.TabIndex = 3
		Me.lbl_NoOrders.Text = "There are currently no orders placed"
		Me.lbl_NoOrders.Visible = False
		'
		'mnstr_Strip
		'
		Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
		Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
		Me.mnstr_Strip.Name = "mnstr_Strip"
		Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.mnstr_Strip.Size = New System.Drawing.Size(800, 24)
		Me.mnstr_Strip.TabIndex = 4
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.NewProductToolStripMenuItem, Me.NewListenerToolStripMenuItem})
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.NewToolStripMenuItem.Text = "&New..."
		'
		'NewCustomerToolStripMenuItem
		'
		Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
		Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.NewCustomerToolStripMenuItem.Text = "Customer"
		'
		'NewProductToolStripMenuItem
		'
		Me.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem"
		Me.NewProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.NewProductToolStripMenuItem.Text = "Product"
		'
		'NewListenerToolStripMenuItem
		'
		Me.NewListenerToolStripMenuItem.Name = "NewListenerToolStripMenuItem"
		Me.NewListenerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.NewListenerToolStripMenuItem.Text = "Listener"
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.SettingsToolStripMenuItem.Text = "Settings"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(113, 6)
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.Logout
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.LogoutToolStripMenuItem.Text = "&Logout"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'UpdateToolStripMenuItem
		'
		Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
		Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.UpdateToolStripMenuItem.Text = "Update"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomersToolStripMenuItem, Me.ViewProductsToolStripMenuItem, Me.ViewListenersToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.ViewToolStripMenuItem.Text = "&View"
		'
		'ViewCustomersToolStripMenuItem
		'
		Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
		Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ViewCustomersToolStripMenuItem.Text = "Customers"
		'
		'ViewProductsToolStripMenuItem
		'
		Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
		Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ViewProductsToolStripMenuItem.Text = "Products"
		'
		'ViewListenersToolStripMenuItem
		'
		Me.ViewListenersToolStripMenuItem.Name = "ViewListenersToolStripMenuItem"
		Me.ViewListenersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ViewListenersToolStripMenuItem.Text = "Listeners"
		'
		'Frm_DisplayOrders
		'
		Me.AcceptButton = Me.btn_Complete
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.dgv_Orders)
		Me.Controls.Add(Me.mnstr_Strip)
		Me.Controls.Add(Me.lbl_NoOrders)
		Me.Controls.Add(Me.btn_Complete)
		Me.Controls.Add(Me.btn_ShowCompleted)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Frm_DisplayOrders"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnstr_Strip.ResumeLayout(False)
		Me.mnstr_Strip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgv_Orders As DataGridView
	Friend WithEvents btn_Complete As Button
	Friend WithEvents btn_ShowCompleted As Button
	Friend WithEvents bsOrders As BindingSource
	Friend WithEvents CustomerName As DataGridViewTextBoxColumn
	Friend WithEvents ItemName As DataGridViewTextBoxColumn
	Friend WithEvents Quantity As DataGridViewTextBoxColumn
	Friend WithEvents OrderTotal As DataGridViewTextBoxColumn
	Friend WithEvents lbl_NoOrders As Label
	Friend WithEvents mnstr_Strip As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewListenerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As ToolStripSeparator
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewCustomersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewListenersToolStripMenuItem As ToolStripMenuItem
End Class
