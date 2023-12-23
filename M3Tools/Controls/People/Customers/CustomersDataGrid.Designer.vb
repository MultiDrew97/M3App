<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersDataGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersDataGrid))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgc_CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Edit = New SPPBC.M3Tools.DataGridViewImageButtonEditColumn()
        Me.dgc_Remove = New SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn()
        Me.dgc_Edit_Old = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgc_Remove_Old = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_SelectAll
        '
        Me.chk_SelectAll.AutoSize = True
        Me.chk_SelectAll.Location = New System.Drawing.Point(46, 3)
        Me.chk_SelectAll.Name = "chk_SelectAll"
        Me.chk_SelectAll.Size = New System.Drawing.Size(15, 14)
        Me.chk_SelectAll.TabIndex = 3
        Me.chk_SelectAll.TabStop = False
        Me.chk_SelectAll.UseVisualStyleBackColor = True
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AllowUserToAddRows = False
        Me.dgv_Customers.AllowUserToOrderColumns = True
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_CustomerID, Me.dgc_Selection, Me.dgcName, Me.dgcAddress, Me.dgcPhone, Me.dgcEmail, Me.dgc_Edit, Me.dgc_Remove, Me.dgc_Edit_Old, Me.dgc_Remove_Old})
        Me.dgv_Customers.ContextMenuStrip = Me.cms_Tools
        Me.dgv_Customers.DataSource = Me.bsCustomers
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Customers.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Customers.Size = New System.Drawing.Size(610, 500)
        Me.dgv_Customers.TabIndex = 2
        '
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(133, 70)
        '
        'dgc_CustomerID
        '
        Me.dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_CustomerID.DataPropertyName = "CustomerID"
        Me.dgc_CustomerID.FillWeight = 5.0!
        Me.dgc_CustomerID.Frozen = True
        Me.dgc_CustomerID.HeaderText = "CustomerID"
        Me.dgc_CustomerID.Name = "dgc_CustomerID"
        Me.dgc_CustomerID.ReadOnly = True
        Me.dgc_CustomerID.Visible = False
        '
        'dgc_Selection
        '
        Me.dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgc_Selection.Frozen = True
        Me.dgc_Selection.HeaderText = ""
        Me.dgc_Selection.MinimumWidth = 25
        Me.dgc_Selection.Name = "dgc_Selection"
        Me.dgc_Selection.ReadOnly = True
        Me.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgc_Selection.Width = 25
        '
        'dgcName
        '
        Me.dgcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcName.DataPropertyName = "Name"
        Me.dgcName.FillWeight = 25.0!
        Me.dgcName.HeaderText = "Name"
        Me.dgcName.Name = "dgcName"
        '
        'dgcAddress
        '
        Me.dgcAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcAddress.DataPropertyName = "Address"
        Me.dgcAddress.FillWeight = 25.0!
        Me.dgcAddress.HeaderText = "Address"
        Me.dgcAddress.Name = "dgcAddress"
        '
        'dgcPhone
        '
        Me.dgcPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcPhone.DataPropertyName = "Phone"
        Me.dgcPhone.FillWeight = 25.0!
        Me.dgcPhone.HeaderText = "Phone"
        Me.dgcPhone.Name = "dgcPhone"
        '
        'dgcEmail
        '
        Me.dgcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcEmail.DataPropertyName = "Email"
        Me.dgcEmail.FillWeight = 25.0!
        Me.dgcEmail.HeaderText = "Email"
        Me.dgcEmail.Name = "dgcEmail"
        '
        'dgc_Edit
        '
        Me.dgc_Edit.ButtonImage = Nothing
        Me.dgc_Edit.FillWeight = 5.0!
        Me.dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgc_Edit.HeaderText = ""
        Me.dgc_Edit.MinimumWidth = 25
        Me.dgc_Edit.Name = "dgc_Edit"
        Me.dgc_Edit.ReadOnly = True
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
        Me.dgc_Remove.ReadOnly = True
        Me.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Remove.Width = 25
        '
        'dgc_Edit_Old
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.dgc_Edit_Old.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgc_Edit_Old.FillWeight = 5.0!
        Me.dgc_Edit_Old.HeaderText = ""
        Me.dgc_Edit_Old.Image = Global.SPPBC.M3Tools.My.Resources.Resources.edit
        Me.dgc_Edit_Old.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgc_Edit_Old.MinimumWidth = 25
        Me.dgc_Edit_Old.Name = "dgc_Edit_Old"
        Me.dgc_Edit_Old.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Edit_Old.Visible = False
        Me.dgc_Edit_Old.Width = 25
        '
        'dgc_Remove_Old
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        Me.dgc_Remove_Old.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgc_Remove_Old.Description = "Remove the listener from the database and stop sending emails"
        Me.dgc_Remove_Old.FillWeight = 5.0!
        Me.dgc_Remove_Old.HeaderText = ""
        Me.dgc_Remove_Old.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
        Me.dgc_Remove_Old.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgc_Remove_Old.MinimumWidth = 25
        Me.dgc_Remove_Old.Name = "dgc_Remove_Old"
        Me.dgc_Remove_Old.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Remove_Old.Visible = False
        Me.dgc_Remove_Old.Width = 25
        '
        'CustomersDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chk_SelectAll)
        Me.Controls.Add(Me.dgv_Customers)
        Me.Name = "CustomersDataGrid"
        Me.Size = New System.Drawing.Size(610, 500)
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Customers As Windows.Forms.DataGridView
    Friend WithEvents bsCustomers As Windows.Forms.BindingSource
    Friend WithEvents chk_SelectAll As Windows.Forms.CheckBox
    Friend WithEvents cms_Tools As ToolsContextMenu
    Friend WithEvents dgc_Join As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_CustomerID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgcName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcAddress As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcPhone As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcEmail As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Edit As DataGridViewImageButtonEditColumn
    Friend WithEvents dgc_Remove As DataGridViewImageButtonDeleteColumn
    Friend WithEvents dgc_Edit_Old As Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgc_Remove_Old As Windows.Forms.DataGridViewImageColumn
End Class
