<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ViewListeners
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ViewListeners))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btn_Add = New System.Windows.Forms.Button()
		Me.ContextStripItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.lbl_Total = New System.Windows.Forms.Label()
		Me.btn_Advanced = New System.Windows.Forms.Button()
		Me.bsFilters = New System.Windows.Forms.BindingSource(Me.components)
		Me.txt_NameSearch = New System.Windows.Forms.TextBox()
		Me.txt_EmailSearch = New System.Windows.Forms.TextBox()
		Me.lbl_NameSearch = New System.Windows.Forms.Label()
		Me.lbl_EmailSearch = New System.Windows.Forms.Label()
		Me.gbx_AdvancedSearch = New System.Windows.Forms.GroupBox()
		Me.btn_AdvancedCancel = New System.Windows.Forms.Button()
		Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.gbx_Search = New System.Windows.Forms.GroupBox()
		Me.txt_SearchBox = New System.Windows.Forms.TextBox()
		Me.cbx_Column = New System.Windows.Forms.ComboBox()
		Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
		Me.ListenerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextStripItem.SuspendLayout()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsFilters, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbx_AdvancedSearch.SuspendLayout()
		Me.gbx_Search.SuspendLayout()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.mnstr_Strip.SuspendLayout()
		Me.SuspendLayout()
		'
		'btn_Add
		'
		Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Add.Location = New System.Drawing.Point(792, 344)
		Me.btn_Add.Name = "btn_Add"
		Me.btn_Add.Size = New System.Drawing.Size(169, 39)
		Me.btn_Add.TabIndex = 1
		Me.btn_Add.Text = "Add Listener"
		Me.btn_Add.UseVisualStyleBackColor = True
		'
		'ContextStripItem
		'
		Me.ContextStripItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
		Me.ContextStripItem.Name = "ContextMenuStrip1"
		Me.ContextStripItem.Size = New System.Drawing.Size(114, 26)
		Me.ContextStripItem.Text = "Refresh"
		'
		'RefreshToolStripMenuItem
		'
		Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
		Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
		Me.RefreshToolStripMenuItem.Text = "Refresh"
		'
		'lbl_Total
		'
		Me.lbl_Total.AutoSize = True
		Me.lbl_Total.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Total.Location = New System.Drawing.Point(787, 386)
		Me.lbl_Total.Name = "lbl_Total"
		Me.lbl_Total.Size = New System.Drawing.Size(183, 25)
		Me.lbl_Total.TabIndex = 2
		Me.lbl_Total.Text = "Total Listeners: "
		'
		'btn_Advanced
		'
		Me.btn_Advanced.AutoSize = True
		Me.btn_Advanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Advanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Advanced.Location = New System.Drawing.Point(100, 108)
		Me.btn_Advanced.Name = "btn_Advanced"
		Me.btn_Advanced.Size = New System.Drawing.Size(127, 36)
		Me.btn_Advanced.TabIndex = 6
		Me.btn_Advanced.Text = "Advanced"
		Me.btn_Advanced.UseVisualStyleBackColor = True
		'
		'txt_NameSearch
		'
		Me.txt_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.txt_NameSearch.Location = New System.Drawing.Point(11, 61)
		Me.txt_NameSearch.Name = "txt_NameSearch"
		Me.txt_NameSearch.Size = New System.Drawing.Size(306, 31)
		Me.txt_NameSearch.TabIndex = 8
		'
		'txt_EmailSearch
		'
		Me.txt_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.txt_EmailSearch.Location = New System.Drawing.Point(11, 141)
		Me.txt_EmailSearch.Name = "txt_EmailSearch"
		Me.txt_EmailSearch.Size = New System.Drawing.Size(306, 31)
		Me.txt_EmailSearch.TabIndex = 9
		'
		'lbl_NameSearch
		'
		Me.lbl_NameSearch.AutoSize = True
		Me.lbl_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.lbl_NameSearch.Location = New System.Drawing.Point(6, 33)
		Me.lbl_NameSearch.Name = "lbl_NameSearch"
		Me.lbl_NameSearch.Size = New System.Drawing.Size(79, 25)
		Me.lbl_NameSearch.TabIndex = 10
		Me.lbl_NameSearch.Text = "Name:"
		'
		'lbl_EmailSearch
		'
		Me.lbl_EmailSearch.AutoSize = True
		Me.lbl_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.lbl_EmailSearch.Location = New System.Drawing.Point(6, 113)
		Me.lbl_EmailSearch.Name = "lbl_EmailSearch"
		Me.lbl_EmailSearch.Size = New System.Drawing.Size(170, 25)
		Me.lbl_EmailSearch.TabIndex = 11
		Me.lbl_EmailSearch.Text = "Email Address:"
		'
		'gbx_AdvancedSearch
		'
		Me.gbx_AdvancedSearch.BackColor = System.Drawing.Color.Gray
		Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedCancel)
		Me.gbx_AdvancedSearch.Controls.Add(Me.txt_EmailSearch)
		Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_EmailSearch)
		Me.gbx_AdvancedSearch.Controls.Add(Me.txt_NameSearch)
		Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_NameSearch)
		Me.gbx_AdvancedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.gbx_AdvancedSearch.Location = New System.Drawing.Point(743, 47)
		Me.gbx_AdvancedSearch.Name = "gbx_AdvancedSearch"
		Me.gbx_AdvancedSearch.Size = New System.Drawing.Size(323, 243)
		Me.gbx_AdvancedSearch.TabIndex = 12
		Me.gbx_AdvancedSearch.TabStop = False
		Me.gbx_AdvancedSearch.Text = "Advanced Search"
		Me.gbx_AdvancedSearch.Visible = False
		'
		'btn_AdvancedCancel
		'
		Me.btn_AdvancedCancel.AutoSize = True
		Me.btn_AdvancedCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_AdvancedCancel.Location = New System.Drawing.Point(114, 196)
		Me.btn_AdvancedCancel.Name = "btn_AdvancedCancel"
		Me.btn_AdvancedCancel.Size = New System.Drawing.Size(95, 35)
		Me.btn_AdvancedCancel.TabIndex = 12
		Me.btn_AdvancedCancel.Text = "Cancel"
		Me.btn_AdvancedCancel.UseVisualStyleBackColor = True
		'
		'NAMEDataGridViewTextBoxColumn
		'
		Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
		'
		'EMAILDataGridViewTextBoxColumn
		'
		Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ProductToolStripMenuItem, Me.ListenerToolStripMenuItem})
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.NewToolStripMenuItem.Text = "&New..."
		'
		'CustomerToolStripMenuItem
		'
		Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
		Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.CustomerToolStripMenuItem.Text = "Customer"
		'
		'ProductToolStripMenuItem
		'
		Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
		Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ProductToolStripMenuItem.Text = "Product"
		'
		'ListenerToolStripMenuItem
		'
		Me.ListenerToolStripMenuItem.Name = "ListenerToolStripMenuItem"
		Me.ListenerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ListenerToolStripMenuItem.Text = "Listener"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(109, 6)
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.Logout
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.LogoutToolStripMenuItem.Text = "&Logout"
		'
		'ExitToolStripMenuItem1
		'
		Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
		Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
		Me.ExitToolStripMenuItem1.Text = "E&xit"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem
		'
		Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ProductToolStripMenuItem1, Me.ListenerToolStripMenuItem1})
		Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
		Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.CustomizeToolStripMenuItem.Text = "Find..."
		'
		'CustomerToolStripMenuItem1
		'
		Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
		Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.CustomerToolStripMenuItem1.Text = "Customer"
		'
		'ProductToolStripMenuItem1
		'
		Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
		Me.ProductToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.ProductToolStripMenuItem1.Text = "Product"
		'
		'ListenerToolStripMenuItem1
		'
		Me.ListenerToolStripMenuItem1.Name = "ListenerToolStripMenuItem1"
		Me.ListenerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.ListenerToolStripMenuItem1.Text = "Listener"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.OptionsToolStripMenuItem.Text = "Update"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ListenersToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.ViewToolStripMenuItem.Text = "&View"
		'
		'CustomersToolStripMenuItem
		'
		Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
		Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.CustomersToolStripMenuItem.Text = "Customers"
		'
		'OrdersToolStripMenuItem
		'
		Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
		Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.OrdersToolStripMenuItem.Text = "Orders"
		'
		'ProductsToolStripMenuItem
		'
		Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
		Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ProductsToolStripMenuItem.Text = "Products"
		'
		'ListenersToolStripMenuItem
		'
		Me.ListenersToolStripMenuItem.Name = "ListenersToolStripMenuItem"
		Me.ListenersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ListenersToolStripMenuItem.Text = "Listeners"
		'
		'gbx_Search
		'
		Me.gbx_Search.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Search.Controls.Add(Me.txt_SearchBox)
		Me.gbx_Search.Controls.Add(Me.cbx_Column)
		Me.gbx_Search.Controls.Add(Me.btn_Advanced)
		Me.gbx_Search.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.gbx_Search.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
		Me.gbx_Search.Location = New System.Drawing.Point(743, 47)
		Me.gbx_Search.Name = "gbx_Search"
		Me.gbx_Search.Size = New System.Drawing.Size(323, 172)
		Me.gbx_Search.TabIndex = 15
		Me.gbx_Search.TabStop = False
		Me.gbx_Search.Text = "Search"
		'
		'txt_SearchBox
		'
		Me.txt_SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		Me.txt_SearchBox.Location = New System.Drawing.Point(27, 67)
		Me.txt_SearchBox.Name = "txt_SearchBox"
		Me.txt_SearchBox.Size = New System.Drawing.Size(269, 31)
		Me.txt_SearchBox.TabIndex = 5
		'
		'cbx_Column
		'
		Me.cbx_Column.DataSource = Me.bsFilters
		Me.cbx_Column.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.cbx_Column.FormattingEnabled = True
		Me.cbx_Column.Location = New System.Drawing.Point(60, 28)
		Me.cbx_Column.Name = "cbx_Column"
		Me.cbx_Column.Size = New System.Drawing.Size(192, 33)
		Me.cbx_Column.TabIndex = 7
		'
		'dgv_Listeners
		'
		Me.dgv_Listeners.AllowUserToAddRows = False
		Me.dgv_Listeners.AllowUserToOrderColumns = True
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
		Me.dgv_Listeners.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgv_Listeners.AutoGenerateColumns = False
		Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Listeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ListenerName, Me.EmailAddress})
		Me.dgv_Listeners.ContextMenuStrip = Me.ContextStripItem
		Me.dgv_Listeners.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.dgv_Listeners.DataSource = Me.bsListeners
		Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Left
		Me.dgv_Listeners.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
		Me.dgv_Listeners.Location = New System.Drawing.Point(0, 24)
		Me.dgv_Listeners.Name = "dgv_Listeners"
		Me.dgv_Listeners.Size = New System.Drawing.Size(737, 503)
		Me.dgv_Listeners.TabIndex = 0
		'
		'ListenerName
		'
		Me.ListenerName.DataPropertyName = "Name"
		Me.ListenerName.FillWeight = 70.0!
		Me.ListenerName.HeaderText = "Name"
		Me.ListenerName.Name = "ListenerName"
		'
		'EmailAddress
		'
		Me.EmailAddress.DataPropertyName = "EmailAddress"
		Me.EmailAddress.HeaderText = "Email Address"
		Me.EmailAddress.Name = "EmailAddress"
		'
		'mnstr_Strip
		'
		Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
		Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
		Me.mnstr_Strip.Name = "mnstr_Strip"
		Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.mnstr_Strip.Size = New System.Drawing.Size(1078, 24)
		Me.mnstr_Strip.TabIndex = 16
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
		Me.ToolStripMenuItem1.Text = "&File"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.NewProductToolStripMenuItem, Me.NewListenerToolStripMenuItem})
		Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.ToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
		Me.ToolStripMenuItem2.Text = "&New..."
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
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(113, 6)
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Image = Global.MediaMinistry.My.Resources.Resources.Logout
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(116, 22)
		Me.ToolStripMenuItem3.Text = "&Logout"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(46, 20)
		Me.ToolStripMenuItem4.Text = "&Tools"
		'
		'UpdateToolStripMenuItem
		'
		Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
		Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.UpdateToolStripMenuItem.Text = "Update"
		'
		'ToolStripMenuItem5
		'
		Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomersToolStripMenuItem, Me.ViewOrdersToolStripMenuItem, Me.ViewProductsToolStripMenuItem})
		Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
		Me.ToolStripMenuItem5.Size = New System.Drawing.Size(44, 20)
		Me.ToolStripMenuItem5.Text = "&View"
		'
		'ViewCustomersToolStripMenuItem
		'
		Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
		Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ViewCustomersToolStripMenuItem.Text = "Customers"
		'
		'ViewOrdersToolStripMenuItem
		'
		Me.ViewOrdersToolStripMenuItem.Name = "ViewOrdersToolStripMenuItem"
		Me.ViewOrdersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ViewOrdersToolStripMenuItem.Text = "Orders"
		'
		'ViewProductsToolStripMenuItem
		'
		Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
		Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ViewProductsToolStripMenuItem.Text = "Products"
		'
		'Frm_ViewListeners
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.MediaMinistry.My.Resources.Resources.BannerImage
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1078, 527)
		Me.Controls.Add(Me.dgv_Listeners)
		Me.Controls.Add(Me.mnstr_Strip)
		Me.Controls.Add(Me.gbx_Search)
		Me.Controls.Add(Me.lbl_Total)
		Me.Controls.Add(Me.btn_Add)
		Me.Controls.Add(Me.gbx_AdvancedSearch)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Frm_ViewListeners"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.ContextStripItem.ResumeLayout(False)
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsFilters, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbx_AdvancedSearch.ResumeLayout(False)
		Me.gbx_AdvancedSearch.PerformLayout()
		Me.gbx_Search.ResumeLayout(False)
		Me.gbx_Search.PerformLayout()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnstr_Strip.ResumeLayout(False)
		Me.mnstr_Strip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btn_Add As Button
	Friend WithEvents dgv_Listeners As DataGridView
	Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents lbl_Total As Label
	Friend WithEvents txt_SearchBox As TextBox
	Friend WithEvents btn_Advanced As Button
	Friend WithEvents cbx_Column As ComboBox
	Friend WithEvents txt_NameSearch As TextBox
	Friend WithEvents txt_EmailSearch As TextBox
	Friend WithEvents lbl_NameSearch As Label
	Friend WithEvents lbl_EmailSearch As Label
	Friend WithEvents gbx_AdvancedSearch As GroupBox
	Friend WithEvents btn_AdvancedCancel As Button
	Friend WithEvents NAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents EMAILDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListenerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As ToolStripSeparator
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListenersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents bsListeners As BindingSource
	Friend WithEvents bsFilters As BindingSource
	Friend WithEvents ContextStripItem As ContextMenuStrip
	Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents gbx_Search As GroupBox
	Friend WithEvents ListenerName As DataGridViewTextBoxColumn
	Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
	Friend WithEvents mnstr_Strip As MenuStrip
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewListenerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
	Friend WithEvents ViewCustomersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewOrdersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
End Class
