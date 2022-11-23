<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayOrdersCtrl
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
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
		Me.bw_LoadOrders = New System.ComponentModel.BackgroundWorker()
		Me.cms_Tools = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ShowCompletedOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ts_Refresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.ts_Remove = New System.Windows.Forms.ToolStripMenuItem()
		Me.db_Orders = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.dgv_Orders = New System.Windows.Forms.DataGridView()
		Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btn_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.btn_Complete = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.btn_Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.ts_OrderTools = New System.Windows.Forms.ToolStrip()
		Me.tbtn_New = New System.Windows.Forms.ToolStripButton()
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cms_Tools.SuspendLayout()
		Me.ToolStripContainer1.ContentPanel.SuspendLayout()
		Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer1.SuspendLayout()
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ts_OrderTools.SuspendLayout()
		Me.SuspendLayout()
		'
		'bsOrders
		'
		Me.bsOrders.Filter = ""
		'
		'bw_LoadOrders
		'
		'
		'cms_Tools
		'
		Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowCompletedOrdersToolStripMenuItem, Me.ToolStripSeparator1, Me.ts_Refresh, Me.ts_Remove})
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(204, 76)
		Me.cms_Tools.Text = "Tools"
		'
		'ShowCompletedOrdersToolStripMenuItem
		'
		Me.ShowCompletedOrdersToolStripMenuItem.Name = "ShowCompletedOrdersToolStripMenuItem"
		Me.ShowCompletedOrdersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
		Me.ShowCompletedOrdersToolStripMenuItem.Text = "Show Completed Orders"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
		'
		'ts_Refresh
		'
		Me.ts_Refresh.Name = "ts_Refresh"
		Me.ts_Refresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.ts_Refresh.Size = New System.Drawing.Size(203, 22)
		Me.ts_Refresh.Text = "Refresh"
		'
		'ts_Remove
		'
		Me.ts_Remove.Name = "ts_Remove"
		Me.ts_Remove.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.ts_Remove.Size = New System.Drawing.Size(203, 22)
		Me.ts_Remove.Text = "Remove"
		'
		'db_Orders
		'
		Me.db_Orders.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
		Me.db_Orders.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
		Me.db_Orders.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
		'
		'ToolStripContainer1
		'
		'
		'ToolStripContainer1.ContentPanel
		'
		Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgv_Orders)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(803, 401)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.Size = New System.Drawing.Size(803, 440)
		Me.ToolStripContainer1.TabIndex = 1
		Me.ToolStripContainer1.Text = "ToolStripContainer1"
		'
		'ToolStripContainer1.TopToolStripPanel
		'
		Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_OrderTools)
		'
		'dgv_Orders
		'
		Me.dgv_Orders.AllowUserToAddRows = False
		Me.dgv_Orders.AllowUserToOrderColumns = True
		Me.dgv_Orders.AutoGenerateColumns = False
		Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
		Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.Customer, Me.Product, Me.Total, Me.OrderDate, Me.CompletedDate, Me.btn_Edit, Me.btn_Complete, Me.btn_Cancel})
		Me.dgv_Orders.DataSource = Me.bsOrders
		Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Orders.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Orders.Name = "dgv_Orders"
		Me.dgv_Orders.RowHeadersWidth = 82
		Me.dgv_Orders.Size = New System.Drawing.Size(803, 401)
		Me.dgv_Orders.TabIndex = 2
		'
		'OrderID
		'
		Me.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.OrderID.DataPropertyName = "OrderID"
		Me.OrderID.HeaderText = "Order Number"
		Me.OrderID.MinimumWidth = 10
		Me.OrderID.Name = "OrderID"
		Me.OrderID.ReadOnly = True
		'
		'Customer
		'
		Me.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Customer.DataPropertyName = "CustomerName"
		Me.Customer.HeaderText = "Buyer"
		Me.Customer.MinimumWidth = 10
		Me.Customer.Name = "Customer"
		Me.Customer.ReadOnly = True
		'
		'Product
		'
		Me.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Product.DataPropertyName = "ItemName"
		Me.Product.HeaderText = "Product"
		Me.Product.MinimumWidth = 10
		Me.Product.Name = "Product"
		Me.Product.ReadOnly = True
		'
		'Total
		'
		Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Total.DataPropertyName = "OrderTotal"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle1.Format = "C2"
		DataGridViewCellStyle1.NullValue = "N/A"
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.Total.DefaultCellStyle = DataGridViewCellStyle1
		Me.Total.HeaderText = "Total"
		Me.Total.MinimumWidth = 10
		Me.Total.Name = "Total"
		Me.Total.ReadOnly = True
		'
		'OrderDate
		'
		Me.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.OrderDate.DataPropertyName = "OrderDate"
		DataGridViewCellStyle2.Format = "d"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.OrderDate.DefaultCellStyle = DataGridViewCellStyle2
		Me.OrderDate.HeaderText = "Date Placed"
		Me.OrderDate.MinimumWidth = 10
		Me.OrderDate.Name = "OrderDate"
		Me.OrderDate.ReadOnly = True
		'
		'CompletedDate
		'
		Me.CompletedDate.DataPropertyName = "CompletedDate"
		DataGridViewCellStyle3.Format = "d"
		DataGridViewCellStyle3.NullValue = "N/A"
		Me.CompletedDate.DefaultCellStyle = DataGridViewCellStyle3
		Me.CompletedDate.HeaderText = "Date Completed"
		Me.CompletedDate.Name = "CompletedDate"
		Me.CompletedDate.ReadOnly = True
		'
		'btn_Edit
		'
		Me.btn_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btn_Edit.HeaderText = ""
		Me.btn_Edit.MinimumWidth = 25
		Me.btn_Edit.Name = "btn_Edit"
		Me.btn_Edit.ReadOnly = True
		Me.btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Edit.Text = "Edit"
		Me.btn_Edit.ToolTipText = "Edit Order"
		Me.btn_Edit.UseColumnTextForButtonValue = True
		Me.btn_Edit.Width = 25
		'
		'btn_Complete
		'
		Me.btn_Complete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.btn_Complete.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btn_Complete.HeaderText = ""
		Me.btn_Complete.MinimumWidth = 25
		Me.btn_Complete.Name = "btn_Complete"
		Me.btn_Complete.ReadOnly = True
		Me.btn_Complete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Complete.Text = "Complete"
		Me.btn_Complete.ToolTipText = "Fulfil Order"
		Me.btn_Complete.Width = 25
		'
		'btn_Cancel
		'
		Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btn_Cancel.HeaderText = ""
		Me.btn_Cancel.MinimumWidth = 25
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.ReadOnly = True
		Me.btn_Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Cancel.Text = "Cancel"
		Me.btn_Cancel.ToolTipText = "Cancel Order"
		Me.btn_Cancel.Width = 25
		'
		'ts_OrderTools
		'
		Me.ts_OrderTools.Dock = System.Windows.Forms.DockStyle.None
		Me.ts_OrderTools.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ts_OrderTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_New})
		Me.ts_OrderTools.Location = New System.Drawing.Point(3, 0)
		Me.ts_OrderTools.Name = "ts_OrderTools"
		Me.ts_OrderTools.Size = New System.Drawing.Size(79, 39)
		Me.ts_OrderTools.TabIndex = 7
		Me.ts_OrderTools.Text = "ToolStrip1"
		'
		'tbtn_New
		'
		Me.tbtn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tbtn_New.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
		Me.tbtn_New.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tbtn_New.Name = "tbtn_New"
		Me.tbtn_New.Size = New System.Drawing.Size(36, 36)
		Me.tbtn_New.Text = "New Customer"
		'
		'DisplayOrdersCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ContextMenuStrip = Me.cms_Tools
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MinimumSize = New System.Drawing.Size(803, 440)
		Me.Name = "DisplayOrdersCtrl"
		Me.Size = New System.Drawing.Size(803, 440)
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cms_Tools.ResumeLayout(False)
		Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer1.ResumeLayout(False)
		Me.ToolStripContainer1.PerformLayout()
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ts_OrderTools.ResumeLayout(False)
		Me.ts_OrderTools.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents db_Orders As Database.OrdersDatabase
	Friend WithEvents bsOrders As Windows.Forms.BindingSource
	Friend WithEvents bw_LoadOrders As ComponentModel.BackgroundWorker
	Friend WithEvents cms_Tools As Windows.Forms.ContextMenuStrip
	Friend WithEvents ts_Refresh As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ShowCompletedOrdersToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents dgv_Orders As Windows.Forms.DataGridView
	Friend WithEvents OrderID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Customer As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Product As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents OrderDate As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CompletedDate As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents btn_Edit As Windows.Forms.DataGridViewButtonColumn
	Friend WithEvents btn_Complete As Windows.Forms.DataGridViewButtonColumn
	Friend WithEvents btn_Cancel As Windows.Forms.DataGridViewButtonColumn
	Friend WithEvents ts_OrderTools As Windows.Forms.ToolStrip
	Friend WithEvents tbtn_New As Windows.Forms.ToolStripButton
End Class
