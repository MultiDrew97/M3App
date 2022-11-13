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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
		Me.bw_LoadCustomers = New System.ComponentModel.BackgroundWorker()
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
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
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_CustomerTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgv_CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_CustomerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName, Me.EmailAddress, Me.PhoneNumber, Me.Address, Me.JoinDate})
		Me.dgv_CustomerTable.DataSource = Me.bs_Customers
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_CustomerTable.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgv_CustomerTable.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_CustomerTable.Location = New System.Drawing.Point(0, 0)
		Me.dgv_CustomerTable.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
		Me.dgv_CustomerTable.Name = "dgv_CustomerTable"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_CustomerTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgv_CustomerTable.RowHeadersWidth = 82
		Me.dgv_CustomerTable.Size = New System.Drawing.Size(1582, 856)
		Me.dgv_CustomerTable.TabIndex = 0
		'
		'FirstName
		'
		Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.FirstName.DataPropertyName = "FirstName"
		Me.FirstName.HeaderText = "First Name"
		Me.FirstName.MinimumWidth = 10
		Me.FirstName.Name = "FirstName"
		'
		'LastName
		'
		Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.LastName.DataPropertyName = "LastName"
		Me.LastName.HeaderText = "Last Name"
		Me.LastName.MinimumWidth = 10
		Me.LastName.Name = "LastName"
		'
		'EmailAddress
		'
		Me.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.EmailAddress.DataPropertyName = "EmailAddress"
		Me.EmailAddress.HeaderText = "Email"
		Me.EmailAddress.MinimumWidth = 10
		Me.EmailAddress.Name = "EmailAddress"
		'
		'PhoneNumber
		'
		Me.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.PhoneNumber.DataPropertyName = "PhoneNumber"
		Me.PhoneNumber.HeaderText = "Phone"
		Me.PhoneNumber.MinimumWidth = 10
		Me.PhoneNumber.Name = "PhoneNumber"
		'
		'Address
		'
		Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Address.DataPropertyName = "Address"
		Me.Address.HeaderText = "Address"
		Me.Address.MinimumWidth = 10
		Me.Address.Name = "Address"
		'
		'JoinDate
		'
		Me.JoinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.JoinDate.DataPropertyName = "JoinDate"
		Me.JoinDate.HeaderText = "Join Date"
		Me.JoinDate.MinimumWidth = 10
		Me.JoinDate.Name = "JoinDate"
		Me.JoinDate.ReadOnly = True
		'
		'cms_Tools
		'
		Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.cms_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Refresh, Me.ts_Remove})
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(249, 80)
		Me.cms_Tools.Text = "Tools"
		'
		'ts_Refresh
		'
		Me.ts_Refresh.Name = "ts_Refresh"
		Me.ts_Refresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.ts_Refresh.Size = New System.Drawing.Size(248, 38)
		Me.ts_Refresh.Text = "Refresh"
		'
		'ts_Remove
		'
		Me.ts_Remove.Name = "ts_Remove"
		Me.ts_Remove.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.ts_Remove.Size = New System.Drawing.Size(248, 38)
		Me.ts_Remove.Text = "Remove"
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
		Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1582, 856)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.Size = New System.Drawing.Size(1582, 906)
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
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
		Me.ToolStrip1.Location = New System.Drawing.Point(6, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(68, 50)
		Me.ToolStrip1.TabIndex = 6
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(46, 44)
		Me.ToolStripButton1.Text = "New Customer"
		'
		'db_Customers
		'
		Me.db_Customers.InitialCatalog = "Media Ministry"
		Me.db_Customers.Password = "M3AppPassword2499"
		Me.db_Customers.Username = "M3App"
		'
		'DisplayCustomersCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ContextMenuStrip = Me.cms_Tools
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
		Me.Name = "DisplayCustomersCtrl"
		Me.Size = New System.Drawing.Size(1582, 906)
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
	Friend WithEvents bw_LoadCustomers As ComponentModel.BackgroundWorker
	Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
	Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
	Private WithEvents db_Customers As Database.CustomerDatabase
End Class
