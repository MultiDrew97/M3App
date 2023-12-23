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
		Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
		Me.dgc_ListenerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.dgcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgcEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgc_Edit = New SPPBC.M3Tools.DataGridViewImageButtonEditColumn()
		Me.dgc_Remove = New SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn()
		Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
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
		'dgv_Listeners
		'
		Me.dgv_Listeners.AllowUserToAddRows = False
		Me.dgv_Listeners.AllowUserToOrderColumns = True
		Me.dgv_Listeners.AutoGenerateColumns = False
		Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgc_ListenerID, Me.dgc_Selection, Me.dgcName, Me.dgcEmail, Me.dgc_Edit, Me.dgc_Remove})
		Me.dgv_Listeners.ContextMenuStrip = Me.cms_Tools
		Me.dgv_Listeners.DataSource = Me.bsListeners
		Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
		Me.dgv_Listeners.Name = "dgv_Listeners"
		Me.dgv_Listeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
		'dgcName
		'
		Me.dgcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgcName.DataPropertyName = "Name"
		Me.dgcName.FillWeight = 50.0!
		Me.dgcName.HeaderText = "Name"
		Me.dgcName.Name = "dgcName"
		'
		'dgcEmail
		'
		Me.dgcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dgcEmail.DataPropertyName = "Email"
		Me.dgcEmail.FillWeight = 50.0!
		Me.dgcEmail.HeaderText = "Email"
		Me.dgcEmail.Name = "dgcEmail"
		'
		'dgc_Edit
		'
		Me.dgc_Edit.ButtonImage = Nothing
		Me.dgc_Edit.FillWeight = 5.0!
		Me.dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.dgc_Edit.HeaderText = ""
		Me.dgc_Edit.MinimumWidth = 25
		Me.dgc_Edit.Name = "dgc_Edit"
		Me.dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgc_Edit.Width = 25
		'
		'dgc_Remove
		'
		Me.dgc_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
		Me.dgc_Remove.ButtonImage = Nothing
		Me.dgc_Remove.FillWeight = 5.0!
		Me.dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.dgc_Remove.HeaderText = ""
		Me.dgc_Remove.MinimumWidth = 25
		Me.dgc_Remove.Name = "dgc_Remove"
		Me.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgc_Remove.Width = 25
		'
		'cms_Tools
		'
		Me.cms_Tools.Name = "cms_Tools"
		Me.cms_Tools.Size = New System.Drawing.Size(133, 70)
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
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgv_Listeners As Windows.Forms.DataGridView
	Friend WithEvents chk_SelectAll As Windows.Forms.CheckBox
	Friend WithEvents bsListeners As Windows.Forms.BindingSource
	Friend WithEvents cms_Tools As ToolsContextMenu
	Friend WithEvents dgc_Name As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Email As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_ListenerID As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Selection As Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents dgcName As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgcEmail As Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dgc_Edit As DataGridViewImageButtonEditColumn
	Friend WithEvents dgc_Remove As DataGridViewImageButtonDeleteColumn
End Class
