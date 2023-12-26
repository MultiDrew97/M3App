<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuStrip
	Inherits System.Windows.Forms.MenuStrip

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuStrip))
        Me.tsmi_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_NewCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_NewProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_NewListeners = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_View = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ViewCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ViewOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ViewProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ViewListeners = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.bw_Update = New System.ComponentModel.BackgroundWorker()
        Me.wb_Updater = New System.Windows.Forms.WebBrowser()
        Me.lsd_Loading = New SPPBC.M3Tools.LoadScreenDialog()
		Me.SuspendLayout()
		'
		'tsmi_File
		'
		Me.tsmi_File.AccessibleDescription = "File Menu Item"
		Me.tsmi_File.AccessibleName = "File"
		Me.tsmi_File.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
		Me.tsmi_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_New, Me.tsmi_Settings, Me.toolStripSeparator1, Me.tsmi_Logout, Me.tsmi_Exit})
		Me.tsmi_File.Name = "tsmi_File"
		Me.tsmi_File.Size = New System.Drawing.Size(37, 20)
		Me.tsmi_File.Text = "&File"
		'
		'tsmi_New
		'
		Me.tsmi_New.AccessibleName = "New"
		Me.tsmi_New.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_NewCustomer, Me.tsmi_NewProduct, Me.tsmi_NewListeners})
		Me.tsmi_New.Image = CType(resources.GetObject("tsmi_New.Image"), System.Drawing.Image)
		Me.tsmi_New.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmi_New.Name = "tsmi_New"
		Me.tsmi_New.Size = New System.Drawing.Size(132, 38)
		Me.tsmi_New.Text = "&New..."
		'
		'tsmi_NewCustomer
		'
		Me.tsmi_NewCustomer.Name = "tsmi_NewCustomer"
		Me.tsmi_NewCustomer.Size = New System.Drawing.Size(126, 22)
		Me.tsmi_NewCustomer.Text = "Customer"
		'
		'tsmi_NewProduct
		'
		Me.tsmi_NewProduct.Name = "tsmi_NewProduct"
		Me.tsmi_NewProduct.Size = New System.Drawing.Size(126, 22)
		Me.tsmi_NewProduct.Text = "Product"
		'
		'tsmi_NewListeners
		'
		Me.tsmi_NewListeners.Name = "tsmi_NewListeners"
		Me.tsmi_NewListeners.Size = New System.Drawing.Size(126, 22)
		Me.tsmi_NewListeners.Text = "Listener"
		'
		'tsmi_Settings
		'
		Me.tsmi_Settings.AccessibleName = "Settings"
		Me.tsmi_Settings.Name = "tsmi_Settings"
		Me.tsmi_Settings.Size = New System.Drawing.Size(132, 38)
		Me.tsmi_Settings.Text = "Settings"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.AccessibleName = "Separator"
		Me.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(129, 6)
		'
		'tsmi_Logout
		'
		Me.tsmi_Logout.AccessibleName = "Logout"
		Me.tsmi_Logout.Image = Global.SPPBC.M3Tools.My.Resources.Resources.Logout
		Me.tsmi_Logout.Name = "tsmi_Logout"
		Me.tsmi_Logout.Size = New System.Drawing.Size(132, 38)
		Me.tsmi_Logout.Text = "&Logout"
		'
		'tsmi_Exit
		'
		Me.tsmi_Exit.AccessibleName = "Exit"
		Me.tsmi_Exit.Name = "tsmi_Exit"
		Me.tsmi_Exit.Size = New System.Drawing.Size(132, 38)
		Me.tsmi_Exit.Text = "E&xit"
		'
		'tsmi_View
		'
		Me.tsmi_View.AccessibleDescription = "View Menu Item"
		Me.tsmi_View.AccessibleName = "View"
		Me.tsmi_View.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
		Me.tsmi_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_ViewCustomers, Me.tsmi_ViewOrders, Me.tsmi_ViewProducts, Me.tsmi_ViewListeners})
		Me.tsmi_View.Name = "tsmi_View"
		Me.tsmi_View.Size = New System.Drawing.Size(44, 20)
		Me.tsmi_View.Text = "&View"
		'
		'tsmi_ViewCustomers
		'
		Me.tsmi_ViewCustomers.AccessibleDescription = "Display all customers"
		Me.tsmi_ViewCustomers.AccessibleName = "Customers"
		Me.tsmi_ViewCustomers.Name = "tsmi_ViewCustomers"
		Me.tsmi_ViewCustomers.Size = New System.Drawing.Size(131, 22)
		Me.tsmi_ViewCustomers.Text = "Customers"
		'
		'tsmi_ViewOrders
		'
		Me.tsmi_ViewOrders.AccessibleDescription = "View all in progress and completed orders"
		Me.tsmi_ViewOrders.AccessibleName = "Orders"
		Me.tsmi_ViewOrders.Name = "tsmi_ViewOrders"
		Me.tsmi_ViewOrders.Size = New System.Drawing.Size(131, 22)
		Me.tsmi_ViewOrders.Text = "Orders"
		'
		'tsmi_ViewProducts
		'
		Me.tsmi_ViewProducts.AccessibleDescription = "View all inventory"
		Me.tsmi_ViewProducts.AccessibleName = "Products"
		Me.tsmi_ViewProducts.Name = "tsmi_ViewProducts"
		Me.tsmi_ViewProducts.Size = New System.Drawing.Size(131, 22)
		Me.tsmi_ViewProducts.Text = "Products"
		'
		'tsmi_ViewListeners
		'
		Me.tsmi_ViewListeners.AccessibleDescription = "Manage email ministry listeners"
		Me.tsmi_ViewListeners.AccessibleName = "Listeners"
		Me.tsmi_ViewListeners.Name = "tsmi_ViewListeners"
		Me.tsmi_ViewListeners.Size = New System.Drawing.Size(131, 22)
		Me.tsmi_ViewListeners.Text = "Listeners"
		'
		'tsmi_Tools
		'
		Me.tsmi_Tools.AccessibleDescription = "Tools Menu Item"
		Me.tsmi_Tools.AccessibleName = "Tools"
		Me.tsmi_Tools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
		Me.tsmi_Tools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Update})
		Me.tsmi_Tools.Name = "tsmi_Tools"
		Me.tsmi_Tools.Size = New System.Drawing.Size(46, 20)
		Me.tsmi_Tools.Text = "&Tools"
		'
		'tsmi_Update
		'
		Me.tsmi_Update.AccessibleDescription = "Check for updates"
		Me.tsmi_Update.AccessibleName = "Update"
		Me.tsmi_Update.Name = "tsmi_Update"
		Me.tsmi_Update.Size = New System.Drawing.Size(166, 22)
		Me.tsmi_Update.Text = "Check for Update"
		'
		'bw_Update
		'
		'
		'wb_Updater
		'
		Me.wb_Updater.Location = New System.Drawing.Point(0, 0)
		Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wb_Updater.Name = "wb_Updater"
		Me.wb_Updater.ScrollBarsEnabled = False
		Me.wb_Updater.Size = New System.Drawing.Size(250, 250)
		Me.wb_Updater.TabIndex = 0
		Me.wb_Updater.Visible = False
		'
		'lsd_Loading
		'
		Me.lsd_Loading.Image = CType(resources.GetObject("lsd_Loading.Image"), System.Drawing.Bitmap)
		Me.lsd_Loading.LoadText = ""
		'
		'MainMenuStrip
		'
		Me.ImageScalingSize = New System.Drawing.Size(16, 16)
		Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_File, Me.tsmi_View, Me.tsmi_Tools})
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tsmi_File As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_New As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_NewCustomer As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_NewProduct As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_NewListeners As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_Settings As Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As Windows.Forms.ToolStripSeparator
	Friend WithEvents tsmi_Logout As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_Exit As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_View As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_ViewCustomers As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_ViewOrders As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_ViewProducts As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_ViewListeners As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_Tools As Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmi_Update As Windows.Forms.ToolStripMenuItem
	Friend WithEvents bw_Update As ComponentModel.BackgroundWorker
	Friend WithEvents wb_Updater As Windows.Forms.WebBrowser
	Friend WithEvents lsd_Loading As LoadScreenDialog
End Class
