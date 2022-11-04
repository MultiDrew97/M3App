<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.btn_placeOrder = New System.Windows.Forms.Button()
        Me.btn_ShowOrders = New System.Windows.Forms.Button()
        Me.btn_ProductManagement = New System.Windows.Forms.Button()
        Me.btn_CustomerManagement = New System.Windows.Forms.Button()
        Me.ss_Queries = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bw_ChangedSizes = New System.ComponentModel.BackgroundWorker()
		Me.btn_EmailMinistry = New System.Windows.Forms.Button()
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.wb_Updater = New System.Windows.Forms.WebBrowser()
		Me.ss_Queries.SuspendLayout()
		Me.SuspendLayout()
		'
		'btn_placeOrder
		'
		Me.btn_placeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_placeOrder.Location = New System.Drawing.Point(77, 102)
		Me.btn_placeOrder.Name = "btn_placeOrder"
		Me.btn_placeOrder.Size = New System.Drawing.Size(226, 43)
		Me.btn_placeOrder.TabIndex = 2
		Me.btn_placeOrder.Text = "Place an Order"
		Me.btn_placeOrder.UseVisualStyleBackColor = True
		'
		'btn_ShowOrders
		'
		Me.btn_ShowOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ShowOrders.Location = New System.Drawing.Point(77, 177)
		Me.btn_ShowOrders.Name = "btn_ShowOrders"
		Me.btn_ShowOrders.Size = New System.Drawing.Size(226, 43)
		Me.btn_ShowOrders.TabIndex = 3
		Me.btn_ShowOrders.Text = "Show Orders"
		Me.btn_ShowOrders.UseVisualStyleBackColor = True
		'
		'btn_ProductManagement
		'
		Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ProductManagement.Location = New System.Drawing.Point(77, 252)
		Me.btn_ProductManagement.Name = "btn_ProductManagement"
		Me.btn_ProductManagement.Size = New System.Drawing.Size(226, 43)
		Me.btn_ProductManagement.TabIndex = 4
		Me.btn_ProductManagement.Text = "Product Management"
		Me.btn_ProductManagement.UseVisualStyleBackColor = True
		'
		'btn_CustomerManagement
		'
		Me.btn_CustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_CustomerManagement.Location = New System.Drawing.Point(77, 27)
		Me.btn_CustomerManagement.Name = "btn_CustomerManagement"
		Me.btn_CustomerManagement.Size = New System.Drawing.Size(226, 43)
		Me.btn_CustomerManagement.TabIndex = 1
		Me.btn_CustomerManagement.Text = "Customer Management"
		Me.btn_CustomerManagement.UseVisualStyleBackColor = True
		'
		'ss_Queries
		'
		Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
		Me.ss_Queries.Location = New System.Drawing.Point(0, 391)
		Me.ss_Queries.Name = "ss_Queries"
		Me.ss_Queries.Size = New System.Drawing.Size(397, 22)
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
		Me.btn_EmailMinistry.Location = New System.Drawing.Point(77, 327)
		Me.btn_EmailMinistry.Name = "btn_EmailMinistry"
		Me.btn_EmailMinistry.Size = New System.Drawing.Size(226, 43)
		Me.btn_EmailMinistry.TabIndex = 5
		Me.btn_EmailMinistry.Text = "Email Ministry"
		Me.btn_EmailMinistry.UseVisualStyleBackColor = True
		Me.pnl_Controls = New System.Windows.Forms.Panel()
		Me.wb_Updater = New System.Windows.Forms.WebBrowser()
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.ss_Queries.SuspendLayout()
		Me.pnl_Controls.SuspendLayout()
		Me.SuspendLayout()
		'
		'btn_placeOrder
		'
		Me.btn_placeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_placeOrder.Location = New System.Drawing.Point(85, 113)
		Me.btn_placeOrder.Name = "btn_placeOrder"
		Me.btn_placeOrder.Size = New System.Drawing.Size(226, 43)
		Me.btn_placeOrder.TabIndex = 2
		Me.btn_placeOrder.Text = "Place an Order"
		Me.btn_placeOrder.UseVisualStyleBackColor = True
		'
		'btn_ShowOrders
		'
		Me.btn_ShowOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ShowOrders.Location = New System.Drawing.Point(85, 188)
		Me.btn_ShowOrders.Name = "btn_ShowOrders"
		Me.btn_ShowOrders.Size = New System.Drawing.Size(226, 43)
		Me.btn_ShowOrders.TabIndex = 3
		Me.btn_ShowOrders.Text = "Show Orders"
		Me.btn_ShowOrders.UseVisualStyleBackColor = True
		'
		'btn_ProductManagement
		'
		Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ProductManagement.Location = New System.Drawing.Point(85, 263)
		Me.btn_ProductManagement.Name = "btn_ProductManagement"
		Me.btn_ProductManagement.Size = New System.Drawing.Size(226, 43)
		Me.btn_ProductManagement.TabIndex = 4
		Me.btn_ProductManagement.Text = "Product Management"
		Me.btn_ProductManagement.UseVisualStyleBackColor = True
		'
		'btn_CustomerManagement
		'
		Me.btn_CustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_CustomerManagement.Location = New System.Drawing.Point(85, 38)
		Me.btn_CustomerManagement.Name = "btn_CustomerManagement"
		Me.btn_CustomerManagement.Size = New System.Drawing.Size(226, 43)
		Me.btn_CustomerManagement.TabIndex = 1
		Me.btn_CustomerManagement.Text = "Customer Management"
		Me.btn_CustomerManagement.UseVisualStyleBackColor = True
		'
		'ss_Queries
		'
		Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
		Me.ss_Queries.Location = New System.Drawing.Point(0, 391)
		Me.ss_Queries.Name = "ss_Queries"
		Me.ss_Queries.Size = New System.Drawing.Size(397, 22)
		Me.ss_Queries.TabIndex = 0
		'
		'tss_Feedback
		'
		Me.tss_Feedback.Name = "tss_Feedback"
		Me.tss_Feedback.Size = New System.Drawing.Size(151, 17)
		Me.tss_Feedback.Text = "What would you like to do?"
		'
		'bw_ChangedSizes
		'
		'
		'btn_EmailMinistry
		'
		Me.btn_EmailMinistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btn_EmailMinistry.Location = New System.Drawing.Point(85, 338)
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
		Me.pnl_Controls.Controls.Add(Me.mms_Main)
		Me.pnl_Controls.Controls.Add(Me.wb_Updater)
		Me.pnl_Controls.Controls.Add(Me.btn_EmailMinistry)
		Me.pnl_Controls.Controls.Add(Me.btn_CustomerManagement)
		Me.pnl_Controls.Controls.Add(Me.btn_ShowOrders)
		Me.pnl_Controls.Controls.Add(Me.btn_placeOrder)
		Me.pnl_Controls.Controls.Add(Me.btn_ProductManagement)
		Me.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_Controls.Location = New System.Drawing.Point(0, 0)
		Me.pnl_Controls.Name = "pnl_Controls"
		Me.pnl_Controls.Size = New System.Drawing.Size(397, 413)
		Me.pnl_Controls.TabIndex = 0
		'
		'wb_Updater
		'
		Me.wb_Updater.Location = New System.Drawing.Point(340, 335)
		Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wb_Updater.Name = "wb_Updater"
		Me.wb_Updater.Size = New System.Drawing.Size(45, 36)
		Me.wb_Updater.TabIndex = 6
		Me.wb_Updater.Visible = False
		'
		'mms_Main
		'
		Me.mms_Main.Location = New System.Drawing.Point(0, 0)
		Me.mms_Main.Name = "mms_Main"
		Me.mms_Main.Size = New System.Drawing.Size(397, 24)
		Me.mms_Main.TabIndex = 7
		Me.mms_Main.Text = "Tools"
		'
		'wb_Browser
		'
		Me.wb_Updater.Location = New System.Drawing.Point(334, 320)
		Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wb_Updater.Name = "wb_Browser"
		Me.wb_Updater.Size = New System.Drawing.Size(40, 22)
		Me.wb_Updater.TabIndex = 8
		Me.wb_Updater.Url = New System.Uri("", System.UriKind.Relative)
		Me.wb_Updater.Visible = False
		'
		'Frm_Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(397, 413)
		Me.Controls.Add(Me.wb_Updater)
		Me.Controls.Add(Me.mms_Main)
		Me.Controls.Add(Me.btn_EmailMinistry)
		Me.Controls.Add(Me.ss_Queries)
		Me.Controls.Add(Me.btn_CustomerManagement)
		Me.Controls.Add(Me.btn_ShowOrders)
		Me.Controls.Add(Me.btn_placeOrder)
		Me.Controls.Add(Me.btn_ProductManagement)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.MaximizeBox = False
		Me.Name = "Frm_Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.ss_Queries.ResumeLayout(False)
		Me.ss_Queries.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btn_placeOrder As Button
	Friend WithEvents btn_ShowOrders As Button
	Friend WithEvents btn_ProductManagement As Button
	Friend WithEvents btn_CustomerManagement As Button
	Friend WithEvents ss_Queries As StatusStrip
	Friend WithEvents tss_Feedback As ToolStripStatusLabel
	Friend WithEvents bw_ChangedSizes As System.ComponentModel.BackgroundWorker
	Friend WithEvents btn_EmailMinistry As Button
	Friend WithEvents wb_Updater As WebBrowser
	Friend WithEvents pnl_Controls As Panel
	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
End Class
