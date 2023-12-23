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
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbCustomers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
        Me.ss_CustomerView.SuspendLayout()
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
        'FirstNameColumn
        '
        Me.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.HeaderText = "First Name"
        Me.FirstNameColumn.MinimumWidth = 10
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastNameColumn
        '
        Me.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameColumn.DataPropertyName = "LastName"
        Me.LastNameColumn.HeaderText = "Last Name"
        Me.LastNameColumn.MinimumWidth = 10
        Me.LastNameColumn.Name = "LastNameColumn"
        '
        'Street
        '
        Me.Street.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Street.DataPropertyName = "Street"
        Me.Street.HeaderText = "Street"
        Me.Street.MinimumWidth = 10
        Me.Street.Name = "Street"
        '
        'City
        '
        Me.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "City"
        Me.City.MinimumWidth = 10
        Me.City.Name = "City"
        '
        'State
        '
        Me.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.MinimumWidth = 10
        Me.State.Name = "State"
        '
        'ZipCode
        '
        Me.ZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ZipCode.DataPropertyName = "ZipCode"
        Me.ZipCode.HeaderText = "Zip Code"
        Me.ZipCode.MinimumWidth = 10
        Me.ZipCode.Name = "ZipCode"
        '
        'PhoneNumberColumn
        '
        Me.PhoneNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumberColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberColumn.HeaderText = "Phone Number"
        Me.PhoneNumberColumn.MinimumWidth = 10
        Me.PhoneNumberColumn.Name = "PhoneNumberColumn"
        '
        'EmailAddressColumn
        '
        Me.EmailAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailAddressColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressColumn.HeaderText = "Email Address"
        Me.EmailAddressColumn.MinimumWidth = 10
        Me.EmailAddressColumn.Name = "EmailAddressColumn"
        '
        'JoinDateColumn
        '
        Me.JoinDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JoinDateColumn.DataPropertyName = "JoinDate"
        Me.JoinDateColumn.HeaderText = "Join Date"
        Me.JoinDateColumn.MinimumWidth = 10
        Me.JoinDateColumn.Name = "JoinDateColumn"
        Me.JoinDateColumn.ReadOnly = True
        '
        'dcc_Customers
        '
        Me.dcc_Customers.AutoSize = True
        Me.dcc_Customers.CountTemplate = "Count: {0}"
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
        Me.bsCustomers.Filter = "[Name] like '%f%'"
		'
		'dbCustomers
		'
		Me.dbCustomers.BaseUrl = Global.MediaMinistry.My.MySettings.Default.BaseUrl
		Me.dbCustomers.Password = Global.MediaMinistry.My.MySettings.Default.ApiPassword
		Me.dbCustomers.Username = Global.MediaMinistry.My.MySettings.Default.ApiUsername
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
	Friend WithEvents bsCustomers As BindingSource
	Friend WithEvents dbCustomers As SPPBC.M3Tools.Database.CustomerDatabase
End Class
