<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayCustomersCtrl
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
		Me.dgv_CustomerTable = New System.Windows.Forms.DataGridView()
		Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.JoinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bs_Customers = New System.Windows.Forms.BindingSource(Me.components)
		Me.cms_Tools = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ts_Refresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.ts_Remove = New System.Windows.Forms.ToolStripMenuItem()
		Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
		Me.bw_LoadCustomers = New System.ComponentModel.BackgroundWorker()
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		CType(Me.dgv_CustomerTable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cms_Tools.SuspendLayout()
		Me.ToolStripContainer1.ContentPanel.SuspendLayout()
		Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgv_CustomerTable
		'
		Me.dgv_CustomerTable.AutoGenerateColumns = False
		Me.dgv_CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_CustomerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName, Me.EmailAddress, Me.PhoneNumber, Me.Address, Me.JoinDate})
		Me.dgv_CustomerTable.DataSource = Me.bs_Customers
		Me.dgv_CustomerTable.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_CustomerTable.Location = New System.Drawing.Point(0, 0)
		Me.dgv_CustomerTable.Name = "dgv_CustomerTable"
		Me.dgv_CustomerTable.Size = New System.Drawing.Size(791, 446)
		Me.dgv_CustomerTable.TabIndex = 0
		'
		'FirstName
		'
		Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.FirstName.DataPropertyName = "FirstName"
		Me.FirstName.HeaderText = "First Name"
		Me.FirstName.Name = "FirstName"
		'
		'LastName
		'
		Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.LastName.DataPropertyName = "LastName"
		Me.LastName.HeaderText = "Last Name"
		Me.LastName.Name = "LastName"
		'
		'EmailAddress
		'
		Me.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.EmailAddress.DataPropertyName = "EmailAddress"
		Me.EmailAddress.HeaderText = "Email"
		Me.EmailAddress.Name = "EmailAddress"
		'
		'PhoneNumber
		'
		Me.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.PhoneNumber.DataPropertyName = "PhoneNumber"
		Me.PhoneNumber.HeaderText = "Phone"
		Me.PhoneNumber.Name = "PhoneNumber"
		'
		'Address
		'
		Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Address.DataPropertyName = "Address"
		Me.Address.HeaderText = "Address"
		Me.Address.Name = "Address"
		'
		'JoinDate
		'
		Me.JoinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.JoinDate.DataPropertyName = "JoinDate"
		Me.JoinDate.HeaderText = "Join Date"
		Me.JoinDate.Name = "JoinDate"
		Me.JoinDate.ReadOnly = True
		'
		'cms_Tools
		'
		Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Refresh, Me.ts_Remove})
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(155, 48)
		Me.cms_Tools.Text = "Tools"
		'
		'ts_Refresh
		'
		Me.ts_Refresh.Name = "ts_Refresh"
		Me.ts_Refresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.ts_Refresh.Size = New System.Drawing.Size(154, 22)
		Me.ts_Refresh.Text = "Refresh"
		'
		'ts_Remove
		'
		Me.ts_Remove.Name = "ts_Remove"
		Me.ts_Remove.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.ts_Remove.Size = New System.Drawing.Size(154, 22)
		Me.ts_Remove.Text = "Remove"
		'
		'db_Customers
		'
		Me.db_Customers.InitialCatalog = "Media Ministry"
		Me.db_Customers.Password = "M3AppPassword2499"
		Me.db_Customers.Username = "M3App"
		'
		'bw_LoadCustomers
		'
		'
		'ToolStripContainer1
		'
		'
		'ToolStripContainer1.ContentPanel
		'
		Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgv_CustomerTable)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(791, 446)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.Size = New System.Drawing.Size(791, 471)
		Me.ToolStripContainer1.TabIndex = 9
		Me.ToolStripContainer1.Text = "ToolStripContainer1"
		'
		'ToolStripContainer1.TopToolStripPanel
		'
		Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
		Me.ToolStrip1.Location = New System.Drawing.Point(4, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(35, 25)
		Me.ToolStrip1.TabIndex = 6
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton1.Text = "New Customer"
		'
		'DisplayCustomers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ContextMenuStrip = Me.cms_Tools
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Name = "DisplayCustomers"
		Me.Size = New System.Drawing.Size(791, 471)
		CType(Me.dgv_CustomerTable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_Customers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cms_Tools.ResumeLayout(False)
		Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer1.ResumeLayout(False)
		Me.ToolStripContainer1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents dgv_CustomerTable As Windows.Forms.DataGridView
	Friend WithEvents bs_Customers As Windows.Forms.BindingSource
	Friend WithEvents FirstName As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents LastName As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EmailAddress As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PhoneNumber As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Address As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents JoinDate As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents cms_Tools As Windows.Forms.ContextMenuStrip
	Friend WithEvents ts_Refresh As Windows.Forms.ToolStripMenuItem
	Friend WithEvents db_Customers As Database.CustomerDatabase
	Friend WithEvents bw_LoadCustomers As ComponentModel.BackgroundWorker
	Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
	Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
End Class
