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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersManagement))
		Me.ss_StatusView = New System.Windows.Forms.StatusStrip()
		Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.bsCustomers = New SPPBC.M3Tools.Types.CustomersBindingSource()
		Me.dbCustomers = New SPPBC.M3Tools.Database.CustomerDatabase()
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.cdg_Customers = New SPPBC.M3Tools.CustomersDataGrid()
		Me.ts_Tools = New SPPBC.M3Tools.ToolsToolStrip()
		Me.ss_StatusView.SuspendLayout()
		CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStripContainer1.ContentPanel.SuspendLayout()
		Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ss_StatusView
		'
		Me.ss_StatusView.BackColor = System.Drawing.SystemColors.Control
		Me.ss_StatusView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ss_StatusView.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ss_StatusView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_CustomersView})
		Me.ss_StatusView.Location = New System.Drawing.Point(0, 439)
		Me.ss_StatusView.Name = "ss_StatusView"
		Me.ss_StatusView.Size = New System.Drawing.Size(784, 22)
		Me.ss_StatusView.TabIndex = 3
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
		Me.mms_Main.Size = New System.Drawing.Size(784, 24)
		Me.mms_Main.TabIndex = 6
		Me.mms_Main.Text = "Menu"
		'
		'dbCustomers
		'
		Me.dbCustomers.BaseUrl = Global.MediaMinistry.My.MySettings.Default.BaseUrl
		Me.dbCustomers.Password = Global.MediaMinistry.My.MySettings.Default.ApiPassword
		Me.dbCustomers.Username = Global.MediaMinistry.My.MySettings.Default.ApiUsername
		'
		'ToolStripContainer1
		'
		'
		'ToolStripContainer1.ContentPanel
		'
		Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.cdg_Customers)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(784, 376)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.Size = New System.Drawing.Size(784, 415)
		Me.ToolStripContainer1.TabIndex = 7
		Me.ToolStripContainer1.Text = "ToolStripContainer1"
		'
		'ToolStripContainer1.TopToolStripPanel
		'
		Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_Tools)
		'
		'cdg_Customers
		'
		Me.cdg_Customers.AllowColumnReordering = True
		Me.cdg_Customers.AutoSize = True
		Me.cdg_Customers.CustomersSelectable = False
		Me.cdg_Customers.DataSource = Me.bsCustomers
		Me.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cdg_Customers.Location = New System.Drawing.Point(0, 0)
		Me.cdg_Customers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.cdg_Customers.MinimumSize = New System.Drawing.Size(600, 500)
		Me.cdg_Customers.Name = "cdg_Customers"
		Me.cdg_Customers.Size = New System.Drawing.Size(784, 500)
		Me.cdg_Customers.TabIndex = 1
		'
		'ts_Tools
		'
		Me.ts_Tools.Dock = System.Windows.Forms.DockStyle.None
		Me.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ts_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ts_Tools.Location = New System.Drawing.Point(3, 0)
		Me.ts_Tools.Name = "ts_Tools"
		Me.ts_Tools.Size = New System.Drawing.Size(256, 39)
		Me.ts_Tools.TabIndex = 2
		Me.ts_Tools.Text = "ToolsToolStrip1"
		'
		'CustomersManagement
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.AutoSize = True
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(784, 461)
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Controls.Add(Me.ss_StatusView)
		Me.Controls.Add(Me.mms_Main)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(800, 500)
		Me.Name = "CustomersManagement"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.ss_StatusView.ResumeLayout(False)
		Me.ss_StatusView.PerformLayout()
		CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer1.ContentPanel.PerformLayout()
		Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer1.ResumeLayout(False)
		Me.ToolStripContainer1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ss_StatusView As StatusStrip
	Friend WithEvents tss_CustomersView As ToolStripStatusLabel
	Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents First_Name As DataGridViewTextBoxColumn
	Friend WithEvents Last_Name As DataGridViewTextBoxColumn
	Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
	Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
	Friend WithEvents JoinDate As DataGridViewTextBoxColumn
	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
    Friend WithEvents dbCustomers As SPPBC.M3Tools.Database.CustomerDatabase
    Friend WithEvents bsCustomers As CustomersBindingSource
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents cdg_Customers As SPPBC.M3Tools.CustomersDataGrid
    Friend WithEvents ts_Tools As SPPBC.M3Tools.ToolsToolStrip
End Class
