<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagement
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagement))
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.bsInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbInventory = New SPPBC.M3Tools.Database.InventoryDatabase(Me.components)
        Me.dic_Inventory = New SPPBC.M3Tools.DisplayInventoryCtrl()
        Me.ss_StatusView = New System.Windows.Forms.StatusStrip()
        Me.tss_StatusView = New System.Windows.Forms.ToolStripStatusLabel()
		CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ss_StatusView.SuspendLayout()
		Me.SuspendLayout()
		'
		'mms_Main
		'
		Me.mms_Main.Location = New System.Drawing.Point(0, 0)
		Me.mms_Main.Name = "mms_Main"
		Me.mms_Main.Size = New System.Drawing.Size(800, 24)
		Me.mms_Main.TabIndex = 1
		Me.mms_Main.Text = "MainMenuStrip1"
		'
		'dbInventory
		'
		Me.dbInventory.BaseUrl = Global.MediaMinistry.My.MySettings.Default.BaseUrl
		Me.dbInventory.Password = Global.MediaMinistry.My.MySettings.Default.ApiPassword
		Me.dbInventory.Username = Global.MediaMinistry.My.MySettings.Default.ApiUsername
		'
		'dic_Inventory
		'
		Me.dic_Inventory.CountTemplate = "Count: {0}"
		Me.dic_Inventory.DataSource = Me.bsInventory
		Me.dic_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dic_Inventory.Location = New System.Drawing.Point(0, 24)
		Me.dic_Inventory.Name = "dic_Inventory"
		Me.dic_Inventory.Size = New System.Drawing.Size(800, 437)
		Me.dic_Inventory.TabIndex = 2
		'
		'ss_StatusView
		'
		Me.ss_StatusView.BackColor = System.Drawing.SystemColors.Control
		Me.ss_StatusView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ss_StatusView.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ss_StatusView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_StatusView})
		Me.ss_StatusView.Location = New System.Drawing.Point(0, 439)
		Me.ss_StatusView.Name = "ss_StatusView"
		Me.ss_StatusView.Size = New System.Drawing.Size(800, 22)
		Me.ss_StatusView.TabIndex = 5
		'
		'tss_StatusView
		'
		Me.tss_StatusView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tss_StatusView.Name = "tss_StatusView"
		Me.tss_StatusView.Size = New System.Drawing.Size(157, 17)
		Me.tss_StatusView.Text = "Here is the current inventory"
		'
		'InventoryManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 461)
		Me.Controls.Add(Me.ss_StatusView)
		Me.Controls.Add(Me.dic_Inventory)
		Me.Controls.Add(Me.mms_Main)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.MinimumSize = New System.Drawing.Size(800, 500)
		Me.Name = "InventoryManagement"
		Me.Text = "Inventory Management"
		CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ss_StatusView.ResumeLayout(False)
		Me.ss_StatusView.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
	Friend WithEvents bsInventory As BindingSource
    Friend WithEvents dbInventory As InventoryDatabase
	Friend WithEvents dic_Inventory As SPPBC.M3Tools.DisplayInventoryCtrl
    Friend WithEvents ss_StatusView As StatusStrip
    Friend WithEvents tss_StatusView As ToolStripStatusLabel
End Class
