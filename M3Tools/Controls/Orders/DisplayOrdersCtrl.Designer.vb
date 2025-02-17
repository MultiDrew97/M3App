﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayOrdersCtrl
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
		Me.bw_LoadOrders = New System.ComponentModel.BackgroundWorker()
		Me.cms_Tools = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ts_ShowCompleted = New System.Windows.Forms.ToolStripMenuItem()
		Me.ts_Seperator = New System.Windows.Forms.ToolStripSeparator()
		Me.ts_Refresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.ts_Remove = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.dgv_Orders = New System.Windows.Forms.DataGridView()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.tbtn_PlaceOrder = New System.Windows.Forms.ToolStripButton()
		Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btn_Edit = New System.Windows.Forms.DataGridViewImageColumn()
		Me.btn_Complete = New System.Windows.Forms.DataGridViewImageColumn()
		Me.btn_Cancel = New System.Windows.Forms.DataGridViewImageColumn()
		Me.db_Orders = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cms_Tools.SuspendLayout()
		Me.ToolStripContainer1.ContentPanel.SuspendLayout()
		Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer1.SuspendLayout()
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip1.SuspendLayout()
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
		Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_ShowCompleted, Me.ts_Seperator, Me.ts_Refresh, Me.ts_Remove})
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(204, 76)
		Me.cms_Tools.Text = "Tools"
		'
		'ts_ShowCompleted
		'
		Me.ts_ShowCompleted.CheckOnClick = True
		Me.ts_ShowCompleted.Name = "ts_ShowCompleted"
		Me.ts_ShowCompleted.Size = New System.Drawing.Size(203, 22)
		Me.ts_ShowCompleted.Text = "Show Completed Orders"
		'
		'ts_Seperator
		'
		Me.ts_Seperator.Name = "ts_Seperator"
		Me.ts_Seperator.Size = New System.Drawing.Size(200, 6)
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
		'ToolStripContainer1
		'
		'
		'ToolStripContainer1.ContentPanel
		'
		Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgv_Orders)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(800, 403)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 442)
		Me.ToolStripContainer1.TabIndex = 1
		Me.ToolStripContainer1.Text = "ToolStripContainer1"
		'
		'ToolStripContainer1.TopToolStripPanel
		'
		Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
		'
		'dgv_Orders
		'
		Me.dgv_Orders.AllowUserToAddRows = False
		Me.dgv_Orders.AllowUserToOrderColumns = True
		Me.dgv_Orders.AutoGenerateColumns = False
		Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.Customer, Me.Product, Me.OrderQuantity, Me.Total, Me.OrderDate, Me.CompletedDate, Me.btn_Edit, Me.btn_Complete, Me.btn_Cancel})
		Me.dgv_Orders.DataSource = Me.bsOrders
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Orders.DefaultCellStyle = DataGridViewCellStyle5
		Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Orders.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Orders.MinimumSize = New System.Drawing.Size(800, 400)
		Me.dgv_Orders.Name = "dgv_Orders"
		Me.dgv_Orders.ReadOnly = True
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Orders.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.dgv_Orders.RowHeadersWidth = 82
		Me.dgv_Orders.Size = New System.Drawing.Size(800, 403)
		Me.dgv_Orders.TabIndex = 3
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_PlaceOrder})
		Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(48, 39)
		Me.ToolStrip1.TabIndex = 0
		'
		'tbtn_PlaceOrder
		'
		Me.tbtn_PlaceOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tbtn_PlaceOrder.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
		Me.tbtn_PlaceOrder.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tbtn_PlaceOrder.Name = "tbtn_PlaceOrder"
		Me.tbtn_PlaceOrder.Size = New System.Drawing.Size(36, 36)
		Me.tbtn_PlaceOrder.Text = "Place Order"
		'
		'OrderID
		'
		Me.OrderID.DataPropertyName = "OrderID"
		Me.OrderID.HeaderText = "Order Number"
		Me.OrderID.MinimumWidth = 10
		Me.OrderID.Name = "OrderID"
		Me.OrderID.ReadOnly = True
		Me.OrderID.Visible = False
		'
		'Customer
		'
		Me.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.Customer.DataPropertyName = "CustomerName"
		Me.Customer.HeaderText = "Buyer"
		Me.Customer.MinimumWidth = 100
		Me.Customer.Name = "Customer"
		Me.Customer.ReadOnly = True
		Me.Customer.Width = 200
		'
		'Product
		'
		Me.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Product.DataPropertyName = "ItemName"
		Me.Product.HeaderText = "Product"
		Me.Product.MinimumWidth = 200
		Me.Product.Name = "Product"
		Me.Product.ReadOnly = True
		'
		'OrderQuantity
		'
		Me.OrderQuantity.DataPropertyName = "Quantity"
		Me.OrderQuantity.HeaderText = "Quantity"
		Me.OrderQuantity.MinimumWidth = 100
		Me.OrderQuantity.Name = "OrderQuantity"
		Me.OrderQuantity.ReadOnly = True
		'
		'Total
		'
		Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Total.DataPropertyName = "OrderTotal"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle2.Format = "C2"
		DataGridViewCellStyle2.NullValue = "N/A"
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.Total.DefaultCellStyle = DataGridViewCellStyle2
		Me.Total.HeaderText = "Total"
		Me.Total.MinimumWidth = 100
		Me.Total.Name = "Total"
		Me.Total.ReadOnly = True
		'
		'OrderDate
		'
		Me.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.OrderDate.DataPropertyName = "OrderDate"
		DataGridViewCellStyle3.Format = "d"
		DataGridViewCellStyle3.NullValue = Nothing
		Me.OrderDate.DefaultCellStyle = DataGridViewCellStyle3
		Me.OrderDate.HeaderText = "Date Placed"
		Me.OrderDate.MinimumWidth = 100
		Me.OrderDate.Name = "OrderDate"
		Me.OrderDate.ReadOnly = True
		'
		'CompletedDate
		'
		Me.CompletedDate.DataPropertyName = "CompletedDate"
		DataGridViewCellStyle4.Format = "d"
		DataGridViewCellStyle4.NullValue = "N/A"
		Me.CompletedDate.DefaultCellStyle = DataGridViewCellStyle4
		Me.CompletedDate.HeaderText = "Date Completed"
		Me.CompletedDate.MinimumWidth = 100
		Me.CompletedDate.Name = "CompletedDate"
		Me.CompletedDate.ReadOnly = True
		'
		'btn_Edit
		'
		Me.btn_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.btn_Edit.Description = "Edit the order of this row"
		Me.btn_Edit.HeaderText = ""
		Me.btn_Edit.Image = Global.SPPBC.M3Tools.My.Resources.Resources.edit
		Me.btn_Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.btn_Edit.MinimumWidth = 25
		Me.btn_Edit.Name = "btn_Edit"
		Me.btn_Edit.ReadOnly = True
		Me.btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Edit.ToolTipText = "Edit Order"
		Me.btn_Edit.Width = 25
		'
		'btn_Complete
		'
		Me.btn_Complete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.btn_Complete.Description = "Fulfil the order of this row"
		Me.btn_Complete.HeaderText = ""
		Me.btn_Complete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.btn_Complete.MinimumWidth = 25
		Me.btn_Complete.Name = "btn_Complete"
		Me.btn_Complete.ReadOnly = True
		Me.btn_Complete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Complete.ToolTipText = "Fulfil Order"
		Me.btn_Complete.Width = 25
		'
		'btn_Cancel
		'
		Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.btn_Cancel.Description = "Cancel the order of this row"
		Me.btn_Cancel.HeaderText = ""
		Me.btn_Cancel.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
		Me.btn_Cancel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.btn_Cancel.MinimumWidth = 25
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.ReadOnly = True
		Me.btn_Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.btn_Cancel.ToolTipText = "Cancel Order"
		Me.btn_Cancel.Width = 25
		'
		'db_Orders
		'
		Me.db_Orders.BaseUrl = "Media Ministry Test"
		Me.db_Orders.Password = "M3AppPassword2499"
		Me.db_Orders.Username = "M3App"
		'
		'DisplayOrdersCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ContextMenuStrip = Me.cms_Tools
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MinimumSize = New System.Drawing.Size(800, 442)
		Me.Name = "DisplayOrdersCtrl"
		Me.Size = New System.Drawing.Size(800, 442)
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cms_Tools.ResumeLayout(False)
		Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer1.ResumeLayout(False)
		Me.ToolStripContainer1.PerformLayout()
		CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents db_Orders As Database.OrdersDatabase
	Friend WithEvents bsOrders As Windows.Forms.BindingSource
	Friend WithEvents bw_LoadOrders As ComponentModel.BackgroundWorker
	Friend WithEvents cms_Tools As Windows.Forms.ContextMenuStrip
	Friend WithEvents ts_Refresh As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_ShowCompleted As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_Seperator As Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents dgv_Orders As Windows.Forms.DataGridView
	Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
	Friend WithEvents tbtn_PlaceOrder As Windows.Forms.ToolStripButton
	Friend WithEvents OrderID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Customer As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Product As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents OrderQuantity As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents OrderDate As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CompletedDate As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents btn_Edit As Windows.Forms.DataGridViewImageColumn
	Friend WithEvents btn_Complete As Windows.Forms.DataGridViewImageColumn
	Friend WithEvents btn_Cancel As Windows.Forms.DataGridViewImageColumn
End Class
