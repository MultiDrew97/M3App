<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayInventoryCtrl
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.idg_Inventory = New SPPBC.M3Tools.InventoryDataGrid()
        Me.ts_InventoryTools = New System.Windows.Forms.ToolStrip()
        Me.tbtn_AddCustomer = New System.Windows.Forms.ToolStripButton()
        Me.tbtn_Import = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.txt_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ts_InventoryTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.idg_Inventory)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(834, 496)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(834, 521)
        Me.ToolStripContainer1.TabIndex = 10
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_InventoryTools)
        '
        'idg_Inventory
        '
        Me.idg_Inventory.AllowColumnReordering = True
        Me.idg_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idg_Inventory.Filter = Nothing
        Me.idg_Inventory.Location = New System.Drawing.Point(0, 0)
        Me.idg_Inventory.MinimumSize = New System.Drawing.Size(500, 400)
        Me.idg_Inventory.Name = "idg_Inventory"
        Me.idg_Inventory.InventorySelectable = False
        Me.idg_Inventory.Size = New System.Drawing.Size(834, 496)
        Me.idg_Inventory.TabIndex = 0
        '
        'ts_InventoryTools
        '
        Me.ts_InventoryTools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_InventoryTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_InventoryTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_AddCustomer, Me.tbtn_Import, Me.ToolStripSeparator2, Me.tsl_Count, Me.txt_Filter})
        Me.ts_InventoryTools.Location = New System.Drawing.Point(3, 0)
        Me.ts_InventoryTools.Name = "ts_InventoryTools"
        Me.ts_InventoryTools.Size = New System.Drawing.Size(244, 25)
        Me.ts_InventoryTools.TabIndex = 9
        '
        'tbtn_AddCustomer
        '
        Me.tbtn_AddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_AddCustomer.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tbtn_AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_AddCustomer.Name = "tbtn_AddCustomer"
        Me.tbtn_AddCustomer.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_AddCustomer.Text = "Add Customer"
        '
        'tbtn_Import
        '
        Me.tbtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Import.Enabled = False
        Me.tbtn_Import.Image = Global.SPPBC.M3Tools.My.Resources.Resources.import
        Me.tbtn_Import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Import.Name = "tbtn_Import"
        Me.tbtn_Import.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_Import.Text = "Import Customers"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsl_Count
        '
        Me.tsl_Count.Name = "tsl_Count"
        Me.tsl_Count.Size = New System.Drawing.Size(87, 22)
        Me.tsl_Count.Text = "ToolStripLabel1"
        Me.tsl_Count.ToolTipText = "Number of listeners currently subscribed"
        '
        'txt_Filter
        '
        Me.txt_Filter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(100, 25)
        '
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(133, 70)
        '
        'DisplayInventoryCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.cms_Tools
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "DisplayInventoryCtrl"
        Me.Size = New System.Drawing.Size(834, 521)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ts_InventoryTools.ResumeLayout(False)
        Me.ts_InventoryTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents ts_InventoryTools As Windows.Forms.ToolStrip
	Friend WithEvents tbtn_AddCustomer As Windows.Forms.ToolStripButton
	Friend WithEvents tbtn_Import As Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
	Friend WithEvents tsl_Count As Windows.Forms.ToolStripLabel
	Friend WithEvents txt_Filter As Windows.Forms.ToolStripTextBox
	Friend WithEvents cms_Tools As ToolsContextMenu
	Friend WithEvents idg_Inventory As InventoryDataGrid
End Class
