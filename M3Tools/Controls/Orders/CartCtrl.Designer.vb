<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartCtrl
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
		Me.dgv_Cart = New System.Windows.Forms.DataGridView()
		Me.bsCart = New System.Windows.Forms.BindingSource(Me.components)
		Me.dgc_ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ItemTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Remove = New System.Windows.Forms.DataGridViewImageColumn()
		CType(Me.dgv_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsCart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgv_Cart
		'
		Me.dgv_Cart.AllowUserToAddRows = False
		Me.dgv_Cart.AutoGenerateColumns = False
		Me.dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_ItemName, Me.QuantityDataGridViewTextBoxColumn, Me.ItemTotalDataGridViewTextBoxColumn, Me.dgc_Remove})
		Me.dgv_Cart.DataSource = Me.bsCart
		Me.dgv_Cart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Cart.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Cart.MultiSelect = False
		Me.dgv_Cart.Name = "dgv_Cart"
		Me.dgv_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Cart.Size = New System.Drawing.Size(543, 302)
		Me.dgv_Cart.TabIndex = 0
		'
		'bsCart
		'
		Me.bsCart.DataSource = GetType(SPPBC.M3Tools.Types.CartItem)
		'
		'dgc_ItemName
		'
		Me.dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgc_ItemName.DataPropertyName = "ItemName"
		Me.dgc_ItemName.HeaderText = "Product"
		Me.dgc_ItemName.MinimumWidth = 100
		Me.dgc_ItemName.Name = "dgc_ItemName"
		Me.dgc_ItemName.ReadOnly = True
		'
		'QuantityDataGridViewTextBoxColumn
		'
		Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
		Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
		Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
		Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
		Me.QuantityDataGridViewTextBoxColumn.Width = 71
		'
		'ItemTotalDataGridViewTextBoxColumn
		'
		Me.ItemTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.ItemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.Format = "C2"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.ItemTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
		Me.ItemTotalDataGridViewTextBoxColumn.HeaderText = "Price"
		Me.ItemTotalDataGridViewTextBoxColumn.Name = "ItemTotalDataGridViewTextBoxColumn"
		Me.ItemTotalDataGridViewTextBoxColumn.ReadOnly = True
		Me.ItemTotalDataGridViewTextBoxColumn.Width = 56
		'
		'dgc_Remove
		'
		Me.dgc_Remove.HeaderText = ""
		Me.dgc_Remove.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
		Me.dgc_Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.dgc_Remove.Name = "dgc_Remove"
		Me.dgc_Remove.ReadOnly = True
		Me.dgc_Remove.Width = 25
		'
		'CartCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.dgv_Cart)
		Me.Name = "CartCtrl"
		Me.Size = New System.Drawing.Size(543, 302)
		CType(Me.dgv_Cart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsCart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents dgv_Cart As Windows.Forms.DataGridView
	Friend WithEvents bsCart As Windows.Forms.BindingSource
	Friend WithEvents ProductDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_ItemName As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents QuantityDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ItemTotalDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Remove As Windows.Forms.DataGridViewImageColumn
End Class
