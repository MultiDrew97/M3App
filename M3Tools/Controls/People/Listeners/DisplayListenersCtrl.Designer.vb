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
        Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ts_Tools = New System.Windows.Forms.ToolStrip()
        Me.tbtn_AddListener = New System.Windows.Forms.ToolStripButton()
        Me.tbtn_Import = New System.Windows.Forms.ToolStripButton()
        Me.tbtn_Email = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.txt_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.ldg_Listeners = New SPPBC.M3Tools.ListenersDataGrid()
        Me.cms_Tools = New SPPBC.M3Tools.ToolsContextMenu()
        Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ts_Tools.SuspendLayout()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ldg_Listeners)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(517, 370)
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
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ts_Tools)
        '
        'ts_Tools
        '
        Me.ts_Tools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtn_AddListener, Me.tbtn_Import, Me.tbtn_Email, Me.ToolStripSeparator2, Me.tsl_Count, Me.txt_Filter})
        Me.ts_Tools.Location = New System.Drawing.Point(3, 0)
        Me.ts_Tools.Name = "ts_Tools"
        Me.ts_Tools.Size = New System.Drawing.Size(267, 25)
        Me.ts_Tools.TabIndex = 1
        '
        'tbtn_AddListener
        '
        Me.tbtn_AddListener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_AddListener.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tbtn_AddListener.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_AddListener.Name = "tbtn_AddListener"
        Me.tbtn_AddListener.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_AddListener.Text = "Add Listener"
        '
        'tbtn_Import
        '
        Me.tbtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Import.Image = Global.SPPBC.M3Tools.My.Resources.Resources.import
        Me.tbtn_Import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Import.Name = "tbtn_Import"
        Me.tbtn_Import.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_Import.Text = "Import Listeners"
        '
        'tbtn_Email
        '
        Me.tbtn_Email.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtn_Email.Image = Global.SPPBC.M3Tools.My.Resources.Resources.send_email
        Me.tbtn_Email.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtn_Email.Name = "tbtn_Email"
        Me.tbtn_Email.Size = New System.Drawing.Size(23, 22)
        Me.tbtn_Email.Text = "Send Emails"
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
        'ldg_Listeners
        '
        Me.ldg_Listeners.AllowColumnReordering = True
        Me.ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ldg_Listeners.Filter = Nothing
        Me.ldg_Listeners.ListenersSelectable = False
        Me.ldg_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.ldg_Listeners.MinimumSize = New System.Drawing.Size(400, 200)
        Me.ldg_Listeners.Name = "ldg_Listeners"
        Me.ldg_Listeners.Size = New System.Drawing.Size(517, 370)
        Me.ldg_Listeners.TabIndex = 1
        '
        'cms_Tools
        '
        Me.cms_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
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
        Me.ts_Tools.ResumeLayout(False)
        Me.ts_Tools.PerformLayout()
        CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bw_LoadListeners As ComponentModel.BackgroundWorker
    Friend WithEvents bsListeners As Windows.Forms.BindingSource
    Friend WithEvents db_Listeners As Database.ListenerDatabase
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents ts_Tools As Windows.Forms.ToolStrip
    Friend WithEvents tbtn_AddListener As Windows.Forms.ToolStripButton
    Friend WithEvents txt_Filter As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtn_Import As Windows.Forms.ToolStripButton
    Friend WithEvents cms_Tools As ToolsContextMenu
    Friend WithEvents tbtn_Email As Windows.Forms.ToolStripButton
    Friend WithEvents ldg_Listeners As ListenersDataGrid
    Friend WithEvents tsl_Count As Windows.Forms.ToolStripLabel
End Class
