<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryDataGrid
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
        Me.dgv_Inventory = New System.Windows.Forms.DataGridView()
        Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgc_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Available = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgc_Edit = New SPPBC.M3Tools.DataGridViewImageButtonEditColumn()
        Me.dgc_Remove = New SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn()
        Me.bsInventory = New System.Windows.Forms.BindingSource(Me.components)
		Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
		Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Inventory
        '
        Me.dgv_Inventory.AllowUserToAddRows = False
        Me.dgv_Inventory.AllowUserToOrderColumns = True
        Me.dgv_Inventory.AutoGenerateColumns = False
        Me.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_Selection, Me.dgc_Id, Me.dgc_Name, Me.dgc_Stock, Me.dgc_Price, Me.dgc_Available, Me.dgc_Edit, Me.dgc_Remove})
        Me.dgv_Inventory.DataSource = Me.bsInventory
        Me.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Inventory.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Inventory.Name = "dgv_Inventory"
        Me.dgv_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Inventory.Size = New System.Drawing.Size(500, 400)
        Me.dgv_Inventory.TabIndex = 3
        '
        'dgc_Selection
        '
        Me.dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgc_Selection.Frozen = True
        Me.dgc_Selection.HeaderText = ""
        Me.dgc_Selection.MinimumWidth = 25
        Me.dgc_Selection.Name = "dgc_Selection"
        Me.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgc_Selection.Width = 25
        '
        'dgc_Id
        '
        Me.dgc_Id.DataPropertyName = "Id"
        Me.dgc_Id.HeaderText = "ItemID"
        Me.dgc_Id.Name = "dgc_Id"
        Me.dgc_Id.ReadOnly = True
        Me.dgc_Id.Visible = False
        '
        'dgc_Name
        '
        Me.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Name.DataPropertyName = "Name"
        Me.dgc_Name.FillWeight = 40.0!
        Me.dgc_Name.HeaderText = "Name"
        Me.dgc_Name.MinimumWidth = 50
        Me.dgc_Name.Name = "dgc_Name"
        '
        'dgc_Stock
        '
        Me.dgc_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Stock.DataPropertyName = "Stock"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgc_Stock.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgc_Stock.FillWeight = 20.0!
        Me.dgc_Stock.HeaderText = "Stock"
        Me.dgc_Stock.Name = "dgc_Stock"
        '
        'dgc_Price
        '
        Me.dgc_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Price.DataPropertyName = "Price"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.dgc_Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgc_Price.FillWeight = 20.0!
        Me.dgc_Price.HeaderText = "Price"
        Me.dgc_Price.Name = "dgc_Price"
        '
        'dgc_Available
        '
        Me.dgc_Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Available.DataPropertyName = "Available"
        Me.dgc_Available.FalseValue = ""
        Me.dgc_Available.FillWeight = 20.0!
        Me.dgc_Available.HeaderText = "Available?"
        Me.dgc_Available.Name = "dgc_Available"
        Me.dgc_Available.TrueValue = ""
        '
        'dgc_Edit
        '
        Me.dgc_Edit.ButtonImage = Nothing
        Me.dgc_Edit.FillWeight = 5.0!
        Me.dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgc_Edit.HeaderText = ""
        Me.dgc_Edit.MinimumWidth = 25
        Me.dgc_Edit.Name = "dgc_Edit"
        Me.dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Edit.Width = 25
        '
        'dgc_Remove
        '
        Me.dgc_Remove.ButtonImage = Nothing
        Me.dgc_Remove.FillWeight = 5.0!
        Me.dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgc_Remove.HeaderText = ""
        Me.dgc_Remove.MinimumWidth = 25
        Me.dgc_Remove.Name = "dgc_Remove"
        Me.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Remove.Width = 25
        '
        'chk_SelectAll
        '
        Me.chk_SelectAll.AutoSize = True
        Me.chk_SelectAll.Location = New System.Drawing.Point(46, 3)
        Me.chk_SelectAll.Name = "chk_SelectAll"
        Me.chk_SelectAll.Size = New System.Drawing.Size(15, 14)
        Me.chk_SelectAll.TabIndex = 4
        Me.chk_SelectAll.TabStop = False
		Me.chk_SelectAll.UseVisualStyleBackColor = True
		'
		'cms_Tools
		'
		Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(133, 70)
        '
        'InventoryDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.cms_Tools
        Me.Controls.Add(Me.chk_SelectAll)
        Me.Controls.Add(Me.dgv_Inventory)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "InventoryDataGrid"
        Me.Size = New System.Drawing.Size(500, 400)
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Inventory As Windows.Forms.DataGridView
    Friend WithEvents bsInventory As Windows.Forms.BindingSource
    Friend WithEvents cms_Tools As ToolsContextMenu
	Friend WithEvents chk_SelectAll As Windows.Forms.CheckBox
	Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents dgc_Id As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Name As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Stock As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Price As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Available As Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents dgc_Edit As DataGridViewImageButtonEditColumn
	Friend WithEvents dgc_Remove As DataGridViewImageButtonDeleteColumn
End Class
