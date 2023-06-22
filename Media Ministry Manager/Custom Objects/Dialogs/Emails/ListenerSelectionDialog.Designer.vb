<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListenerSelectionDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ListenersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListenersEmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_AllListeners = New System.Windows.Forms.CheckBox()
        Me.btn_Finish = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.bw_RetrieveListeners = New System.ComponentModel.BackgroundWorker()
        Me.cbx_Column = New System.Windows.Forms.ComboBox()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.bw_AllListeners = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.AllowUserToDeleteRows = False
        Me.dgv_Listeners.AllowUserToOrderColumns = True
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Listeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selection, Me.ListenersName, Me.ListenersEmailAddress})
        Me.dgv_Listeners.DataSource = Me.bsListeners
        Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Listeners.Margin = New System.Windows.Forms.Padding(6)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(671, 546)
        Me.dgv_Listeners.TabIndex = 0
        '
        'Selection
        '
        Me.Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Selection.FillWeight = 50.0!
        Me.Selection.HeaderText = ""
        Me.Selection.MinimumWidth = 50
        Me.Selection.Name = "Selection"
        Me.Selection.Width = 50
        '
        'ListenersName
        '
        Me.ListenersName.DataPropertyName = "Name"
        Me.ListenersName.HeaderText = "Name"
        Me.ListenersName.Name = "ListenersName"
        Me.ListenersName.ReadOnly = True
        '
        'ListenersEmailAddress
        '
        Me.ListenersEmailAddress.DataPropertyName = "EmailAddress"
        Me.ListenersEmailAddress.HeaderText = "Email Address"
        Me.ListenersEmailAddress.Name = "ListenersEmailAddress"
        Me.ListenersEmailAddress.ReadOnly = True
        '
        'chk_AllListeners
        '
        Me.chk_AllListeners.AutoSize = True
        Me.chk_AllListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AllListeners.Location = New System.Drawing.Point(773, 487)
        Me.chk_AllListeners.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_AllListeners.Name = "chk_AllListeners"
        Me.chk_AllListeners.Size = New System.Drawing.Size(146, 29)
        Me.chk_AllListeners.TabIndex = 1
        Me.chk_AllListeners.Text = "Send to All"
        Me.chk_AllListeners.UseVisualStyleBackColor = True
        '
        'btn_Finish
        '
        Me.btn_Finish.AutoSize = True
        Me.btn_Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finish.Location = New System.Drawing.Point(773, 281)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.Size = New System.Drawing.Size(138, 48)
        Me.btn_Finish.TabIndex = 2
        Me.btn_Finish.Text = "Finish"
        Me.btn_Finish.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(773, 346)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(138, 48)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
		'
		'bw_RetrieveListeners
		'
		'
		'cbx_Column
		'
		Me.cbx_Column.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cbx_Column.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.cbx_Column.FormattingEnabled = True
		Me.cbx_Column.Items.AddRange(New Object() {"Name", "Email Address"})
		Me.cbx_Column.Location = New System.Drawing.Point(755, 31)
		Me.cbx_Column.Name = "cbx_Column"
		Me.cbx_Column.Size = New System.Drawing.Size(199, 33)
		Me.cbx_Column.TabIndex = 4
		'
		'txt_Search
		'
		Me.txt_Search.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_Search.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.txt_Search.Location = New System.Drawing.Point(695, 87)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(320, 31)
        Me.txt_Search.TabIndex = 5
        '
        'bw_AllListeners
        '
        '
        'ListenerSelectionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 546)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.cbx_Column)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Finish)
        Me.Controls.Add(Me.chk_AllListeners)
        Me.Controls.Add(Me.dgv_Listeners)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListenerSelectionDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ListenerSelectionDialog"
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Listeners As DataGridView
    Friend WithEvents chk_AllListeners As CheckBox
    Friend WithEvents btn_Finish As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents bw_RetrieveListeners As System.ComponentModel.BackgroundWorker
    Friend WithEvents bsListeners As BindingSource
    Friend WithEvents cbx_Column As ComboBox
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Selection As DataGridViewCheckBoxColumn
    Friend WithEvents ListenersName As DataGridViewTextBoxColumn
    Friend WithEvents ListenersEmailAddress As DataGridViewTextBoxColumn
    Friend WithEvents bw_AllListeners As System.ComponentModel.BackgroundWorker
End Class
