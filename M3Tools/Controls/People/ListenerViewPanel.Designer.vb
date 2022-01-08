<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListenerViewPanel
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
        Me.bw_LoadListenersTable = New System.ComponentModel.BackgroundWorker()
        Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
        Me.ListenerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListenerSelection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ListenerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListenerEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.AllowUserToDeleteRows = False
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ListenerID, Me.ListenerSelection, Me.ListenerName, Me.ListenerEmail})
        Me.dgv_Listeners.DataSource = Me.bsListeners
        Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(517, 395)
        Me.dgv_Listeners.TabIndex = 0
        '
        'bw_LoadListenersTable
        '
        '
        'db_Listeners
        '
        Me.db_Listeners.InitialCatalog = "Media Ministry"
        Me.db_Listeners.Password = "M3AppPassword2499"
        Me.db_Listeners.Username = "M3App"
        '
        'ListenerID
        '
        Me.ListenerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ListenerID.DataPropertyName = "ListenerID"
        Me.ListenerID.FillWeight = 1.0!
        Me.ListenerID.HeaderText = "ListenerId"
        Me.ListenerID.Name = "ListenerID"
        Me.ListenerID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListenerID.ToolTipText = "The listener's ID for database purposes"
        Me.ListenerID.Visible = False
        '
        'ListenerSelection
        '
        Me.ListenerSelection.FalseValue = "False"
        Me.ListenerSelection.HeaderText = ""
        Me.ListenerSelection.MinimumWidth = 40
        Me.ListenerSelection.Name = "ListenerSelection"
        Me.ListenerSelection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListenerSelection.TrueValue = "True"
        Me.ListenerSelection.Width = 40
        '
        'ListenerName
        '
        Me.ListenerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ListenerName.DataPropertyName = "Name"
        Me.ListenerName.FillWeight = 80.0!
        Me.ListenerName.HeaderText = "Name"
        Me.ListenerName.Name = "ListenerName"
        Me.ListenerName.ToolTipText = "The listener's name"
        '
        'ListenerEmail
        '
        Me.ListenerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ListenerEmail.DataPropertyName = "EmailAddress"
        Me.ListenerEmail.FillWeight = 120.0!
        Me.ListenerEmail.HeaderText = "Email Address"
        Me.ListenerEmail.Name = "ListenerEmail"
        Me.ListenerEmail.ToolTipText = "The listener's email address"
        '
        'ListenerViewPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgv_Listeners)
        Me.Name = "ListenerViewPanel"
        Me.Size = New System.Drawing.Size(517, 395)
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_Listeners As Windows.Forms.DataGridView
    Friend WithEvents bw_LoadListenersTable As ComponentModel.BackgroundWorker
    Friend WithEvents bsListeners As Windows.Forms.BindingSource
    Friend WithEvents db_Listeners As Database.ListenerDatabase
    Friend WithEvents ListenerID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListenerSelection As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ListenerName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListenerEmail As Windows.Forms.DataGridViewTextBoxColumn
End Class
