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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayCustomersCtrl))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.cdg_Customers = New SPPBC.M3Tools.CustomersDataGrid()
        Me.ts_CustomerTools = New System.Windows.Forms.ToolStrip()
        Me.tbtn_AddCustomer = New System.Windows.Forms.ToolStripButton()
        Me.tbtn_Import = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.txt_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.tbtn_Refresh = New System.Windows.Forms.ToolStripButton()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ts_CustomerTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.cdg_Customers)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(748, 525)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(748, 550)
        Me.ToolStripContainer1.TabIndex = 9
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_CustomerTools)
        '
        'cdg_Customers
        '
        Me.cdg_Customers.AllowColumnReordering = True
        Me.cdg_Customers.ContextMenuStrip = Me.cms_Tools
        Me.cdg_Customers.CustomersSelectable = False
        Me.cdg_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cdg_Customers.Filter = Nothing
        Me.cdg_Customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdg_Customers.Location = New System.Drawing.Point(0, 0)
        Me.cdg_Customers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cdg_Customers.Name = "cdg_Customers"
        Me.cdg_Customers.Size = New System.Drawing.Size(748, 525)
        Me.cdg_Customers.TabIndex = 1
        '
        'ts_CustomerTools
        '
        Me.ts_CustomerTools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_CustomerTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_CustomerTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_AddCustomer, Me.tbtn_Import, Me.ToolStripSeparator2, Me.tsl_Count, Me.txt_Filter})
        Me.ts_CustomerTools.Location = New System.Drawing.Point(3, 0)
        Me.ts_CustomerTools.Name = "ts_CustomerTools"
        Me.ts_CustomerTools.Size = New System.Drawing.Size(244, 25)
        Me.ts_CustomerTools.TabIndex = 9
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
        'tbtn_Refresh
        '
        Me.tbtn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Refresh.Enabled = False
        Me.tbtn_Refresh.Image = CType(resources.GetObject("tbtn_Refresh.Image"), System.Drawing.Image)
        Me.tbtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Refresh.Name = "tbtn_Refresh"
        Me.tbtn_Refresh.Size = New System.Drawing.Size(36, 36)
        Me.tbtn_Refresh.Text = "Refresh"
        '
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cms_Tools.Name = "cms_Tools"
        Me.cms_Tools.Size = New System.Drawing.Size(133, 48)
        '
        'DisplayCustomersCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DisplayCustomersCtrl"
        Me.Size = New System.Drawing.Size(748, 550)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ts_CustomerTools.ResumeLayout(False)
        Me.ts_CustomerTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents tbtn_Refresh As Windows.Forms.ToolStripButton
    Friend WithEvents cdg_Customers As CustomersDataGrid
    Friend WithEvents ts_CustomerTools As Windows.Forms.ToolStrip
    Friend WithEvents tbtn_AddCustomer As Windows.Forms.ToolStripButton
    Friend WithEvents tbtn_Import As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsl_Count As Windows.Forms.ToolStripLabel
    Friend WithEvents txt_Filter As Windows.Forms.ToolStripTextBox
    Friend WithEvents cms_Tools As ToolsContextMenu
End Class
