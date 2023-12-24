<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersDataGrid
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
        Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.dgc_CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgc_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Edit = New SPPBC.M3Tools.DataGridViewImageButtonEditColumn()
        Me.dgc_Remove = New SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_CustomerID, Me.dgc_Selection, Me.dgc_Name, Me.dgc_Address, Me.dgc_Phone, Me.dgc_Email, Me.dgc_Edit, Me.dgc_Remove})
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Customers.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Customers.Size = New System.Drawing.Size(610, 500)
        Me.dgv_Customers.TabIndex = 2
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
        'dgc_Name
        '
        Me.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Name.DataPropertyName = "Name"
        Me.dgc_Name.FillWeight = 25.0!
        Me.dgc_Name.HeaderText = "Name"
        Me.dgc_Name.Name = "dgc_Name"
        '
        'dgc_Address
        '
        Me.dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Address.DataPropertyName = "Address"
        Me.dgc_Address.FillWeight = 25.0!
        Me.dgc_Address.HeaderText = "Address"
        Me.dgc_Address.Name = "dgc_Address"
        '
        'dgc_Phone
        '
        Me.dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Phone.DataPropertyName = "Phone"
        Me.dgc_Phone.FillWeight = 25.0!
        Me.dgc_Phone.HeaderText = "Phone"
        Me.dgc_Phone.Name = "dgc_Phone"
        '
        'dgc_Email
        '
        Me.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Email.DataPropertyName = "Email"
        Me.dgc_Email.FillWeight = 25.0!
        Me.dgc_Email.HeaderText = "Email"
        Me.dgc_Email.Name = "dgc_Email"
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
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(133, 70)
        '
        'CustomersDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ContextMenuStrip = Me.cms_Tools
        Me.Controls.Add(Me.chk_SelectAll)
        Me.Controls.Add(Me.dgv_Customers)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "CustomersDataGrid"
        Me.Size = New System.Drawing.Size(610, 500)
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Customers As Windows.Forms.DataGridView
	Friend WithEvents chk_SelectAll As Windows.Forms.CheckBox
	Friend WithEvents cms_Tools As ToolsContextMenu
	Friend WithEvents dgc_Join As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_CustomerID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents dgc_Name As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Address As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Phone As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Email As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Edit As DataGridViewImageButtonEditColumn
	Friend WithEvents dgc_Remove As DataGridViewImageButtonDeleteColumn
End Class
