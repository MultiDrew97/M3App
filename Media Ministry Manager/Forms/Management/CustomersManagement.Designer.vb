<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersManagement))
        Dim MySettings2 As MediaMinistry.My.MySettings = New MediaMinistry.My.MySettings()
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ViewOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcc_Customers = New SPPBC.M3Tools.DisplayCustomersCtrl()
        Me.CustomerDialogs = New SPPBC.M3Tools.CustomerBasedDialogs(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbCustomers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
        Me.ss_CustomerView.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ss_CustomerView
        '
        Me.ss_CustomerView.BackColor = System.Drawing.SystemColors.Control
        Me.ss_CustomerView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_CustomerView.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ss_CustomerView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_CustomersView})
        Me.ss_CustomerView.Location = New System.Drawing.Point(0, 437)
        Me.ss_CustomerView.Name = "ss_CustomerView"
        Me.ss_CustomerView.Size = New System.Drawing.Size(574, 22)
        Me.ss_CustomerView.TabIndex = 3
        '
        'tss_CustomersView
        '
        Me.tss_CustomersView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss_CustomersView.Name = "tss_CustomersView"
        Me.tss_CustomersView.Size = New System.Drawing.Size(170, 17)
        Me.tss_CustomersView.Text = "Here are the current customers"
        '
        'mms_Main
        '
        Me.mms_Main.Location = New System.Drawing.Point(0, 0)
        Me.mms_Main.Name = "mms_Main"
        Me.mms_Main.Size = New System.Drawing.Size(574, 24)
        Me.mms_Main.TabIndex = 6
        Me.mms_Main.Text = "Menu"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(888, 24)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewOrdersToolStripMenuItem, Me.ViewProductsToolStripMenuItem, Me.ViewListenersToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ViewOrdersToolStripMenuItem
        '
        Me.ViewOrdersToolStripMenuItem.Name = "ViewOrdersToolStripMenuItem"
        Me.ViewOrdersToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ViewOrdersToolStripMenuItem.Text = "Orders"
        '
        'ViewProductsToolStripMenuItem
        '
        Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ViewProductsToolStripMenuItem.Text = "Products"
        '
        'ViewListenersToolStripMenuItem
        '
        Me.ViewListenersToolStripMenuItem.Name = "ViewListenersToolStripMenuItem"
        Me.ViewListenersToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ViewListenersToolStripMenuItem.Text = "Listeners"
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.HeaderText = "First Name"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastNameColumn
        '
        Me.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameColumn.DataPropertyName = "LastName"
        Me.LastNameColumn.HeaderText = "Last Name"
        Me.LastNameColumn.Name = "LastNameColumn"
        '
        'Street
        '
        Me.Street.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Street.DataPropertyName = "Street"
        Me.Street.HeaderText = "Street"
        Me.Street.Name = "Street"
        '
        'City
        '
        Me.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'State
        '
        Me.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'ZipCode
        '
        Me.ZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ZipCode.DataPropertyName = "ZipCode"
        Me.ZipCode.HeaderText = "Zip Code"
        Me.ZipCode.Name = "ZipCode"
        '
        'PhoneNumberColumn
        '
        Me.PhoneNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumberColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberColumn.HeaderText = "Phone Number"
        Me.PhoneNumberColumn.Name = "PhoneNumberColumn"
        '
        'EmailAddressColumn
        '
        Me.EmailAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailAddressColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressColumn.HeaderText = "Email Address"
        Me.EmailAddressColumn.Name = "EmailAddressColumn"
        '
        'JoinDateColumn
        '
        Me.JoinDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JoinDateColumn.DataPropertyName = "JoinDate"
        Me.JoinDateColumn.HeaderText = "Join Date"
        Me.JoinDateColumn.Name = "JoinDateColumn"
        Me.JoinDateColumn.ReadOnly = True
        '
        'dcc_Customers
        '
        Me.dcc_Customers.AutoSize = True
        MySettings2.CurrentFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        MySettings2.debugConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry Test"";Connect Timeout" &
    "=30;Encrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
        MySettings2.KeepLoggedIn = True
        MySettings2.Password = "JasmineLove2697"
        MySettings2.releaseConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry"";Connect Timeout=30;E" &
    "ncrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
        MySettings2.SettingsKey = ""
        MySettings2.UpgradeRequired = True
        MySettings2.Username = "arandlemiller97"
        Me.dcc_Customers.CountTemplate = MySettings2.CountTemplate
        Me.dcc_Customers.DataSource = Me.bsCustomers
        Me.dcc_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dcc_Customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcc_Customers.Location = New System.Drawing.Point(0, 24)
        Me.dcc_Customers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dcc_Customers.Name = "dcc_Customers"
        Me.dcc_Customers.Size = New System.Drawing.Size(574, 413)
        Me.dcc_Customers.TabIndex = 7
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(SPPBC.M3Tools.Types.CustomerCollection)
        '
        'dbCustomers
        '
        Me.dbCustomers.InitialCatalog = "Media Ministry Test"
        Me.dbCustomers.Password = "M3AppPassword2499"
        Me.dbCustomers.Username = "M3App"
        '
        'CustomersManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(574, 459)
        Me.Controls.Add(Me.dcc_Customers)
        Me.Controls.Add(Me.ss_CustomerView)
        Me.Controls.Add(Me.mms_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mms_Main
        Me.MaximizeBox = False
        Me.Name = "CustomersManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_CustomerView.ResumeLayout(False)
        Me.ss_CustomerView.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ss_CustomerView As StatusStrip
	Friend WithEvents tss_CustomersView As ToolStripStatusLabel
	Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents First_Name As DataGridViewTextBoxColumn
	Friend WithEvents Last_Name As DataGridViewTextBoxColumn
	Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
	Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
	Friend WithEvents JoinDate As DataGridViewTextBoxColumn
	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
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
	Friend WithEvents ViewOrdersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewListenersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
	Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn
	Friend WithEvents Street As DataGridViewTextBoxColumn
	Friend WithEvents City As DataGridViewTextBoxColumn
	Friend WithEvents State As DataGridViewTextBoxColumn
	Friend WithEvents ZipCode As DataGridViewTextBoxColumn
	Friend WithEvents PhoneNumberColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmailAddressColumn As DataGridViewTextBoxColumn
	Friend WithEvents JoinDateColumn As DataGridViewTextBoxColumn
	Friend WithEvents dcc_Customers As SPPBC.M3Tools.DisplayCustomersCtrl
    Friend WithEvents CustomerDialogs As SPPBC.M3Tools.CustomerBasedDialogs
	Friend WithEvents bsCustomers As BindingSource
	Friend WithEvents dbCustomers As SPPBC.M3Tools.Database.CustomerDatabase
End Class
