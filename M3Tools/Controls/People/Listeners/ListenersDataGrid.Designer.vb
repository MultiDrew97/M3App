<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListenersDataGrid
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListenersDataGrid))
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
		Me.dgc_ListenerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.dgc_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Edit = New System.Windows.Forms.DataGridViewImageColumn()
		Me.dgc_Remove = New System.Windows.Forms.DataGridViewImageColumn()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
		Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgv_Listeners
		'
		Me.dgv_Listeners.AllowUserToAddRows = False
		Me.dgv_Listeners.AllowUserToOrderColumns = True
		Me.dgv_Listeners.AutoGenerateColumns = False
		Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_ListenerID, Me.dgc_Selection, Me.dgc_Name, Me.dgc_Email, Me.dgc_Edit, Me.dgc_Remove})
		Me.dgv_Listeners.DataSource = Me.bsListeners
		Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Listeners.Name = "dgv_Listeners"
		Me.dgv_Listeners.Size = New System.Drawing.Size(450, 300)
		Me.dgv_Listeners.TabIndex = 1
		'
		'dgc_ListenerID
		'
		Me.dgc_ListenerID.DataPropertyName = "ListenerID"
		Me.dgc_ListenerID.FillWeight = 5.0!
		Me.dgc_ListenerID.Frozen = True
		Me.dgc_ListenerID.HeaderText = "ListenerID"
		Me.dgc_ListenerID.Name = "dgc_ListenerID"
		Me.dgc_ListenerID.ReadOnly = True
		Me.dgc_ListenerID.Visible = False
		'
		'dgc_Selection
		'
		Me.dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.dgc_Selection.Frozen = True
		Me.dgc_Selection.HeaderText = ""
		Me.dgc_Selection.MinimumWidth = 25
		Me.dgc_Selection.Name = "dgc_Selection"
		Me.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.dgc_Selection.Width = 25
		'
		'dgc_Name
		'
		Me.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgc_Name.DataPropertyName = "Name"
		Me.dgc_Name.FillWeight = 50.0!
		Me.dgc_Name.HeaderText = "Name"
		Me.dgc_Name.MinimumWidth = 25
		Me.dgc_Name.Name = "dgc_Name"
		Me.dgc_Name.ReadOnly = True
		'
		'dgc_Email
		'
		Me.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgc_Email.DataPropertyName = "Email"
		Me.dgc_Email.FillWeight = 50.0!
		Me.dgc_Email.HeaderText = "Email"
		Me.dgc_Email.MinimumWidth = 25
		Me.dgc_Email.Name = "dgc_Email"
		Me.dgc_Email.ReadOnly = True
		'
		'dgc_Edit
		'
		Me.dgc_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
		DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
		Me.dgc_Edit.DefaultCellStyle = DataGridViewCellStyle1
		Me.dgc_Edit.Description = "Update a listener's info"
		Me.dgc_Edit.FillWeight = 5.0!
		Me.dgc_Edit.HeaderText = ""
		Me.dgc_Edit.Image = CType(resources.GetObject("dgc_Edit.Image"), System.Drawing.Image)
		Me.dgc_Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.dgc_Edit.MinimumWidth = 25
		Me.dgc_Edit.Name = "dgc_Edit"
		Me.dgc_Edit.Width = 25
		'
		'dgc_Remove
		'
		Me.dgc_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
		DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
		Me.dgc_Remove.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgc_Remove.Description = "Remove the listener from the database and stop sending emails"
		Me.dgc_Remove.FillWeight = 5.0!
		Me.dgc_Remove.HeaderText = ""
		Me.dgc_Remove.Image = CType(resources.GetObject("dgc_Remove.Image"), System.Drawing.Image)
		Me.dgc_Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.dgc_Remove.MinimumWidth = 25
		Me.dgc_Remove.Name = "dgc_Remove"
		Me.dgc_Remove.Width = 25
		'
		'bsListeners
		'
		Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.Types.ListenerCollection)
		'
		'chk_SelectAll
		'
		Me.chk_SelectAll.AutoSize = True
		Me.chk_SelectAll.Location = New System.Drawing.Point(46, 3)
		Me.chk_SelectAll.Name = "chk_SelectAll"
		Me.chk_SelectAll.Size = New System.Drawing.Size(15, 14)
		Me.chk_SelectAll.TabIndex = 2
		Me.chk_SelectAll.TabStop = False
		Me.chk_SelectAll.UseVisualStyleBackColor = True
		'
		'db_Listeners
		'
		Me.db_Listeners.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
		Me.db_Listeners.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
		Me.db_Listeners.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
		'
		'ListenersDataGrid
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.chk_SelectAll)
		Me.Controls.Add(Me.dgv_Listeners)
		Me.MinimumSize = New System.Drawing.Size(450, 300)
		Me.Name = "ListenersDataGrid"
		Me.Size = New System.Drawing.Size(450, 300)
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgv_Listeners As Windows.Forms.DataGridView
	Friend WithEvents db_Listeners As Database.ListenerDatabase
	Friend WithEvents chk_SelectAll As Windows.Forms.CheckBox
	Friend WithEvents bsListeners As Windows.Forms.BindingSource
	Friend WithEvents dgc_ListenerID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents dgc_Name As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Email As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Edit As Windows.Forms.DataGridViewImageColumn
	Friend WithEvents dgc_Remove As Windows.Forms.DataGridViewImageColumn
End Class
