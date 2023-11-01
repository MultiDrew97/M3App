<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btn_OrderManagement = New System.Windows.Forms.Button()
        Me.btn_ProductManagement = New System.Windows.Forms.Button()
        Me.btn_CustomerManagement = New System.Windows.Forms.Button()
        Me.ss_Queries = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bw_ChangedSizes = New System.ComponentModel.BackgroundWorker()
        Me.btn_EmailMinistry = New System.Windows.Forms.Button()
        Me.pnl_Controls = New System.Windows.Forms.Panel()
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.wb_Updater = New System.Windows.Forms.WebBrowser()
        Me.dbCustomer = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
        Me.dbListener = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
        Me.dbInventory = New SPPBC.M3Tools.Database.InventoryDatabase(Me.components)
        Me.ss_Queries.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_OrderManagement
        '
        Me.btn_OrderManagement.Enabled = False
        Me.btn_OrderManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OrderManagement.Location = New System.Drawing.Point(24, 95)
        Me.btn_OrderManagement.Name = "btn_OrderManagement"
        Me.btn_OrderManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_OrderManagement.TabIndex = 3
        Me.btn_OrderManagement.Text = "Order Management"
        Me.btn_OrderManagement.UseVisualStyleBackColor = True
        '
        'btn_ProductManagement
        '
        Me.btn_ProductManagement.Enabled = False
        Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProductManagement.Location = New System.Drawing.Point(24, 160)
        Me.btn_ProductManagement.Name = "btn_ProductManagement"
        Me.btn_ProductManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_ProductManagement.TabIndex = 4
        Me.btn_ProductManagement.Text = "Product Management"
        Me.btn_ProductManagement.UseVisualStyleBackColor = True
        '
        'btn_CustomerManagement
        '
        Me.btn_CustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CustomerManagement.Location = New System.Drawing.Point(24, 27)
        Me.btn_CustomerManagement.Name = "btn_CustomerManagement"
        Me.btn_CustomerManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_CustomerManagement.TabIndex = 1
        Me.btn_CustomerManagement.Text = "Customer Management"
        Me.btn_CustomerManagement.UseVisualStyleBackColor = True
        '
        'ss_Queries
        '
        Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Queries.Location = New System.Drawing.Point(0, 300)
        Me.ss_Queries.Name = "ss_Queries"
        Me.ss_Queries.Size = New System.Drawing.Size(272, 22)
        Me.ss_Queries.TabIndex = 0
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(151, 17)
        Me.tss_Feedback.Text = "What would you like to do?"
        '
        'btn_EmailMinistry
        '
        Me.btn_EmailMinistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_EmailMinistry.Location = New System.Drawing.Point(24, 221)
        Me.btn_EmailMinistry.Name = "btn_EmailMinistry"
        Me.btn_EmailMinistry.Size = New System.Drawing.Size(226, 43)
        Me.btn_EmailMinistry.TabIndex = 5
        Me.btn_EmailMinistry.Text = "Email Ministry"
        Me.btn_EmailMinistry.UseVisualStyleBackColor = True
        '
        'pnl_Controls
        '
        Me.pnl_Controls.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Controls.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Controls.Name = "pnl_Controls"
        Me.pnl_Controls.Size = New System.Drawing.Size(397, 413)
        Me.pnl_Controls.TabIndex = 0
        '
        'mms_Main
        '
        Me.mms_Main.Location = New System.Drawing.Point(0, 0)
        Me.mms_Main.Name = "mms_Main"
        Me.mms_Main.Size = New System.Drawing.Size(272, 24)
        Me.mms_Main.TabIndex = 7
        Me.mms_Main.Text = "Tools"
        '
        'wb_Updater
        '
        Me.wb_Updater.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb_Updater.Location = New System.Drawing.Point(222, 277)
        Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_Updater.Name = "wb_Updater"
        Me.wb_Updater.Size = New System.Drawing.Size(38, 20)
        Me.wb_Updater.TabIndex = 8
        Me.wb_Updater.Url = New System.Uri("", System.UriKind.Relative)
        Me.wb_Updater.Visible = False
		'
		'dbCustomer
		'
		Me.dbCustomer.BaseUrl = Global.MediaMinistry.My.MySettings.Default.DefaultUrl
		Me.dbCustomer.Password = Global.MediaMinistry.My.MySettings.Default.DefaultPassword
		Me.dbCustomer.Username = Global.MediaMinistry.My.MySettings.Default.DefaultUsername
		'
		'dbListener
		'
		Me.dbListener.BaseUrl = Global.MediaMinistry.My.MySettings.Default.DefaultUrl
		Me.dbListener.Password = Global.MediaMinistry.My.MySettings.Default.DefaultPassword
		Me.dbListener.Username = Global.MediaMinistry.My.MySettings.Default.DefaultUsername
		'
		'dbInventory
		'
		Me.dbInventory.BaseUrl = Global.MediaMinistry.My.MySettings.Default.DefaultUrl
		Me.dbInventory.Password = Global.MediaMinistry.My.MySettings.Default.DefaultPassword
		Me.dbInventory.Username = Global.MediaMinistry.My.MySettings.Default.DefaultUsername
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(272, 322)
        Me.Controls.Add(Me.wb_Updater)
        Me.Controls.Add(Me.mms_Main)
        Me.Controls.Add(Me.btn_EmailMinistry)
        Me.Controls.Add(Me.ss_Queries)
        Me.Controls.Add(Me.btn_CustomerManagement)
        Me.Controls.Add(Me.btn_OrderManagement)
        Me.Controls.Add(Me.btn_ProductManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mms_Main
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Queries.ResumeLayout(False)
        Me.ss_Queries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_OrderManagement As Button
    Friend WithEvents btn_ProductManagement As Button
    Friend WithEvents btn_CustomerManagement As Button
    Friend WithEvents ss_Queries As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents bw_ChangedSizes As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_EmailMinistry As Button
    Friend WithEvents wb_Updater As WebBrowser
    Friend WithEvents pnl_Controls As Panel
    Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
    Friend WithEvents dbCustomer As CustomerDatabase
    Friend WithEvents dbListener As ListenerDatabase
    Friend WithEvents dbInventory As InventoryDatabase
End Class
