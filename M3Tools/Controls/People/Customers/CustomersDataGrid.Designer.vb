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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersDataGrid))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
        Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
        Me.dgc_CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgc_FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Join = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgc_Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgc_Remove = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AllowUserToAddRows = False
        Me.dgv_Customers.AllowUserToOrderColumns = True
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_CustomerID, Me.dgc_Selection, Me.dgc_FirstName, Me.dgc_LastName, Me.dgc_Address, Me.dgc_Phone, Me.dgc_Email, Me.dgc_Join, Me.dgc_Edit, Me.dgc_Remove})
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
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(SPPBC.M3Tools.DataTables.CustomersDataTable)
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
        'db_Customers
        '
        Me.db_Customers.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
        Me.db_Customers.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
        Me.db_Customers.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
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
        Me.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgc_Selection.Width = 25
        '
        'dgc_FirstName
        '
        Me.dgc_FirstName.DataPropertyName = "FirstName"
        Me.dgc_FirstName.FillWeight = 20.0!
        Me.dgc_FirstName.Frozen = True
        Me.dgc_FirstName.HeaderText = "First Name"
        Me.dgc_FirstName.MinimumWidth = 100
        Me.dgc_FirstName.Name = "dgc_FirstName"
        Me.dgc_FirstName.ReadOnly = True
        '
        'dgc_LastName
        '
        Me.dgc_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgc_LastName.DataPropertyName = "LastName"
        Me.dgc_LastName.FillWeight = 20.0!
        Me.dgc_LastName.Frozen = True
        Me.dgc_LastName.HeaderText = "Last Name"
        Me.dgc_LastName.MinimumWidth = 100
        Me.dgc_LastName.Name = "dgc_LastName"
        Me.dgc_LastName.ReadOnly = True
        '
        'dgc_Address
        '
        Me.dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Address.DataPropertyName = "Address"
        Me.dgc_Address.FillWeight = 20.0!
        Me.dgc_Address.HeaderText = "Address"
        Me.dgc_Address.MinimumWidth = 200
        Me.dgc_Address.Name = "dgc_Address"
        Me.dgc_Address.ReadOnly = True
        '
        'dgc_Phone
        '
        Me.dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Phone.DataPropertyName = "PhoneNumber"
        DataGridViewCellStyle1.Format = "(999) 000-0000"
        Me.dgc_Phone.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgc_Phone.FillWeight = 20.0!
        Me.dgc_Phone.HeaderText = "Phone"
        Me.dgc_Phone.MinimumWidth = 100
        Me.dgc_Phone.Name = "dgc_Phone"
        Me.dgc_Phone.ReadOnly = True
        '
        'dgc_Email
        '
        Me.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Email.DataPropertyName = "Email"
        Me.dgc_Email.FillWeight = 20.0!
        Me.dgc_Email.HeaderText = "Email"
        Me.dgc_Email.MinimumWidth = 100
        Me.dgc_Email.Name = "dgc_Email"
        Me.dgc_Email.ReadOnly = True
        '
        'dgc_Join
        '
        Me.dgc_Join.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgc_Join.DataPropertyName = "JoinDate"
        Me.dgc_Join.FillWeight = 20.0!
        Me.dgc_Join.HeaderText = "Joined"
        Me.dgc_Join.MinimumWidth = 75
        Me.dgc_Join.Name = "dgc_Join"
        Me.dgc_Join.ReadOnly = True
        '
        'dgc_Edit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        Me.dgc_Edit.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgc_Edit.FillWeight = 5.0!
        Me.dgc_Edit.HeaderText = ""
        Me.dgc_Edit.Image = Global.SPPBC.M3Tools.My.Resources.Resources.edit
        Me.dgc_Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgc_Edit.MinimumWidth = 25
        Me.dgc_Edit.Name = "dgc_Edit"
        Me.dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Edit.Width = 25
        '
        'dgc_Remove
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        Me.dgc_Remove.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgc_Remove.Description = "Remove the listener from the database and stop sending emails"
        Me.dgc_Remove.FillWeight = 5.0!
        Me.dgc_Remove.HeaderText = ""
        Me.dgc_Remove.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
        Me.dgc_Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgc_Remove.MinimumWidth = 25
        Me.dgc_Remove.Name = "dgc_Remove"
        Me.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgc_Remove.Width = 25
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
    Friend WithEvents db_Customers As Database.CustomerDatabase
    Friend WithEvents cms_Tools As ToolsContextMenu
    Friend WithEvents dgc_CustomerID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgc_FirstName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_LastName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Address As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Phone As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Email As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Join As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgc_Edit As Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgc_Remove As Windows.Forms.DataGridViewImageColumn
End Class
