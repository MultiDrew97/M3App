<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayListenersCtrl
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayListenersCtrl))
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
		Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.tbtn_AddListener = New System.Windows.Forms.ToolStripButton()
		Me.tbtn_Import = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.txt_Filter = New System.Windows.Forms.ToolStripTextBox()
		Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
		Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
		Me.dgc_ListenerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Edit = New System.Windows.Forms.DataGridViewImageColumn()
		Me.dgc_Remove = New System.Windows.Forms.DataGridViewImageColumn()
		Me.ToolStripContainer1.ContentPanel.SuspendLayout()
		Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
		Me.ToolStripContainer1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'bw_LoadListeners
		'
		'
		'ToolStripContainer1
		'
		Me.ToolStripContainer1.BottomToolStripPanelVisible = False
		'
		'ToolStripContainer1.ContentPanel
		'
		Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgv_Listeners)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(517, 356)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStripContainer1.LeftToolStripPanelVisible = False
		Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStripContainer1.Name = "ToolStripContainer1"
		Me.ToolStripContainer1.RightToolStripPanelVisible = False
		Me.ToolStripContainer1.Size = New System.Drawing.Size(517, 395)
		Me.ToolStripContainer1.TabIndex = 1
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
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_AddListener, Me.tbtn_Import, Me.ToolStripSeparator2, Me.txt_Filter})
		Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(192, 39)
		Me.ToolStrip1.TabIndex = 1
		'
		'tbtn_AddListener
		'
		Me.tbtn_AddListener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tbtn_AddListener.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
		Me.tbtn_AddListener.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tbtn_AddListener.Name = "tbtn_AddListener"
		Me.tbtn_AddListener.Size = New System.Drawing.Size(36, 36)
		Me.tbtn_AddListener.Text = "Add Listener"
		'
		'tbtn_Import
		'
		Me.tbtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tbtn_Import.Image = CType(resources.GetObject("tbtn_Import.Image"), System.Drawing.Image)
		Me.tbtn_Import.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tbtn_Import.Name = "tbtn_Import"
		Me.tbtn_Import.Size = New System.Drawing.Size(36, 36)
		Me.tbtn_Import.Text = "ToolStripButton1"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
		'
		'txt_Filter
		'
		Me.txt_Filter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txt_Filter.Name = "txt_Filter"
		Me.txt_Filter.Size = New System.Drawing.Size(100, 39)
		'
		'dgv_Listeners
		'
		Me.dgv_Listeners.AllowUserToAddRows = False
		Me.dgv_Listeners.AllowUserToOrderColumns = True
		Me.dgv_Listeners.AutoGenerateColumns = False
		Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_ListenerID, Me.NameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.dgc_Edit, Me.dgc_Remove})
		Me.dgv_Listeners.ContextMenuStrip = Me.cms_Tools
		Me.dgv_Listeners.DataSource = Me.bsListeners
		Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Listeners.Name = "dgv_Listeners"
		Me.dgv_Listeners.Size = New System.Drawing.Size(517, 356)
		Me.dgv_Listeners.TabIndex = 0
		'
		'cms_Tools
		'
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(118, 48)
		'
		'bsListeners
		'
		Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.DataTables.ListenersDataTable)
		'
		'db_Listeners
		'
		Me.db_Listeners.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
		Me.db_Listeners.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
		Me.db_Listeners.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
		'
		'dgc_ListenerID
		'
		Me.dgc_ListenerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgc_ListenerID.DataPropertyName = "ListenerID"
		Me.dgc_ListenerID.FillWeight = 5.0!
		Me.dgc_ListenerID.HeaderText = "ListenerID"
		Me.dgc_ListenerID.Name = "dgc_ListenerID"
		Me.dgc_ListenerID.ReadOnly = True
		Me.dgc_ListenerID.Visible = False
		'
		'NameDataGridViewTextBoxColumn
		'
		Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
		Me.NameDataGridViewTextBoxColumn.FillWeight = 45.0!
		Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
		Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
		'
		'EmailDataGridViewTextBoxColumn
		'
		Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
		Me.EmailDataGridViewTextBoxColumn.FillWeight = 45.0!
		Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
		Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
		'
		'dgc_Edit
		'
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
		DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
		Me.dgc_Edit.DefaultCellStyle = DataGridViewCellStyle1
		Me.dgc_Edit.Description = "Update a listener's info"
		Me.dgc_Edit.FillWeight = 5.0!
		Me.dgc_Edit.HeaderText = ""
		Me.dgc_Edit.Image = Global.SPPBC.M3Tools.My.Resources.Resources.edit
		Me.dgc_Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.dgc_Edit.MinimumWidth = 25
		Me.dgc_Edit.Name = "dgc_Edit"
		Me.dgc_Edit.ReadOnly = True
		Me.dgc_Edit.Width = 25
		'
		'dgc_Remove
		'
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
		DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
		Me.dgc_Remove.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgc_Remove.Description = "Remove the listener from the database and stop sending emails"
		Me.dgc_Remove.FillWeight = 5.0!
		Me.dgc_Remove.HeaderText = ""
		Me.dgc_Remove.Image = Global.SPPBC.M3Tools.My.Resources.Resources.delete
		Me.dgc_Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.dgc_Remove.MinimumWidth = 25
		Me.dgc_Remove.Name = "dgc_Remove"
		Me.dgc_Remove.ReadOnly = True
		Me.dgc_Remove.Width = 25
		'
		'DisplayListenersCtrl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.ToolStripContainer1)
		Me.Name = "DisplayListenersCtrl"
		Me.Size = New System.Drawing.Size(517, 395)
		Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
		Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
		Me.ToolStripContainer1.ResumeLayout(False)
		Me.ToolStripContainer1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgv_Listeners As Windows.Forms.DataGridView
	Friend WithEvents bw_LoadListeners As ComponentModel.BackgroundWorker
	Friend WithEvents bsListeners As Windows.Forms.BindingSource
	Friend WithEvents db_Listeners As Database.ListenerDatabase
	Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
	Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
	Friend WithEvents tbtn_AddListener As Windows.Forms.ToolStripButton
	Friend WithEvents txt_Filter As Windows.Forms.ToolStripTextBox
	Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
	Friend WithEvents tbtn_Import As Windows.Forms.ToolStripButton
	Friend WithEvents cms_Tools As ToolsContextMenu
	Friend WithEvents dgc_ListenerID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents NameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EmailDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Edit As Windows.Forms.DataGridViewImageColumn
	Friend WithEvents dgc_Remove As Windows.Forms.DataGridViewImageColumn
End Class
