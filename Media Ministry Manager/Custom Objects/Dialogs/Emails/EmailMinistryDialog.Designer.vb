<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmailMinistryDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailMinistryDialog))
		Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
		Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
		Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
		Me.btn_SendEmails = New System.Windows.Forms.Button()
		Me.btn_ViewListeners = New System.Windows.Forms.Button()
		Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
		Me.rdo_GoingLive = New System.Windows.Forms.RadioButton()
		Me.rdo_EmailMinistry = New System.Windows.Forms.RadioButton()
		Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btn_Upload = New System.Windows.Forms.Button()
		Me.btn_Cancel = New System.Windows.Forms.Button()
		Me.ss_Feedback.SuspendLayout()
		Me.mnstr_Strip.SuspendLayout()
		Me.SuspendLayout()
		'
		'ofd_SelectAudio
		'
		Me.ofd_SelectAudio.Multiselect = True
		Me.ofd_SelectAudio.Title = "Email Ministry"
		'
		'ss_Feedback
		'
		Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
		Me.ss_Feedback.Location = New System.Drawing.Point(0, 232)
		Me.ss_Feedback.Name = "ss_Feedback"
		Me.ss_Feedback.Size = New System.Drawing.Size(369, 22)
		Me.ss_Feedback.TabIndex = 7
		Me.ss_Feedback.Text = "ss_Feedback"
		'
		'tss_Feedback
		'
		Me.tss_Feedback.Name = "tss_Feedback"
		Me.tss_Feedback.Size = New System.Drawing.Size(340, 17)
		Me.tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
		'
		'btn_SendEmails
		'
		Me.btn_SendEmails.AutoSize = True
		Me.btn_SendEmails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_SendEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.btn_SendEmails.Location = New System.Drawing.Point(65, 68)
		Me.btn_SendEmails.MinimumSize = New System.Drawing.Size(238, 36)
		Me.btn_SendEmails.Name = "btn_SendEmails"
		Me.btn_SendEmails.Size = New System.Drawing.Size(238, 36)
		Me.btn_SendEmails.TabIndex = 8
		Me.btn_SendEmails.Text = "Send Emails"
		Me.btn_SendEmails.UseVisualStyleBackColor = True
		'
		'btn_ViewListeners
		'
		Me.btn_ViewListeners.AutoSize = True
		Me.btn_ViewListeners.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_ViewListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.btn_ViewListeners.Location = New System.Drawing.Point(65, 124)
		Me.btn_ViewListeners.MinimumSize = New System.Drawing.Size(238, 36)
		Me.btn_ViewListeners.Name = "btn_ViewListeners"
		Me.btn_ViewListeners.Size = New System.Drawing.Size(238, 36)
		Me.btn_ViewListeners.TabIndex = 10
		Me.btn_ViewListeners.Text = "Current Listeners"
		Me.btn_ViewListeners.UseVisualStyleBackColor = True
		'
		'rdo_GoingLive
		'
		Me.rdo_GoingLive.Location = New System.Drawing.Point(0, 0)
		Me.rdo_GoingLive.Name = "rdo_GoingLive"
		Me.rdo_GoingLive.Size = New System.Drawing.Size(104, 24)
		Me.rdo_GoingLive.TabIndex = 0
		'
		'rdo_EmailMinistry
		'
		Me.rdo_EmailMinistry.Location = New System.Drawing.Point(0, 0)
		Me.rdo_EmailMinistry.Name = "rdo_EmailMinistry"
		Me.rdo_EmailMinistry.Size = New System.Drawing.Size(104, 24)
		Me.rdo_EmailMinistry.TabIndex = 0
		'
		'mnstr_Strip
		'
		Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
		Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
		Me.mnstr_Strip.Name = "mnstr_Strip"
		Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.mnstr_Strip.Size = New System.Drawing.Size(826, 24)
		Me.mnstr_Strip.TabIndex = 11
		Me.mnstr_Strip.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ProductToolStripMenuItem, Me.ListenerToolStripMenuItem})
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.NewToolStripMenuItem.Text = "&New..."
		'
		'CustomerToolStripMenuItem
		'
		Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
		Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.CustomerToolStripMenuItem.Text = "Customer"
		'
		'ProductToolStripMenuItem
		'
		Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
		Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ProductToolStripMenuItem.Text = "Product"
		'
		'ListenerToolStripMenuItem
		'
		Me.ListenerToolStripMenuItem.Name = "ListenerToolStripMenuItem"
		Me.ListenerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ListenerToolStripMenuItem.Text = "Listener"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(109, 6)
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.Logout
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.LogoutToolStripMenuItem.Text = "&Logout"
		'
		'ExitToolStripMenuItem1
		'
		Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
		Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
		Me.ExitToolStripMenuItem1.Text = "E&xit"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem
		'
		Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ProductToolStripMenuItem1, Me.ListenerToolStripMenuItem1})
		Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
		Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.CustomizeToolStripMenuItem.Text = "Find..."
		'
		'CustomerToolStripMenuItem1
		'
		Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
		Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.CustomerToolStripMenuItem1.Text = "Customer"
		'
		'ProductToolStripMenuItem1
		'
		Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
		Me.ProductToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.ProductToolStripMenuItem1.Text = "Product"
		'
		'ListenerToolStripMenuItem1
		'
		Me.ListenerToolStripMenuItem1.Name = "ListenerToolStripMenuItem1"
		Me.ListenerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
		Me.ListenerToolStripMenuItem1.Text = "Listener"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.OptionsToolStripMenuItem.Text = "Update"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ListenersToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.ViewToolStripMenuItem.Text = "&View"
		'
		'CustomersToolStripMenuItem
		'
		Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
		Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.CustomersToolStripMenuItem.Text = "Customers"
		'
		'OrdersToolStripMenuItem
		'
		Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
		Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.OrdersToolStripMenuItem.Text = "Orders"
		'
		'ProductsToolStripMenuItem
		'
		Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
		Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ProductsToolStripMenuItem.Text = "Products"
		'
		'ListenersToolStripMenuItem
		'
		Me.ListenersToolStripMenuItem.Name = "ListenersToolStripMenuItem"
		Me.ListenersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
		Me.ListenersToolStripMenuItem.Text = "Listeners"
		'
		'btn_Upload
		'
		Me.btn_Upload.AutoSize = True
		Me.btn_Upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Upload.Location = New System.Drawing.Point(65, 12)
		Me.btn_Upload.MinimumSize = New System.Drawing.Size(238, 36)
		Me.btn_Upload.Name = "btn_Upload"
		Me.btn_Upload.Size = New System.Drawing.Size(238, 36)
		Me.btn_Upload.TabIndex = 8
		Me.btn_Upload.Text = "Upload New File"
		Me.btn_Upload.UseVisualStyleBackColor = True
		'
		'btn_Cancel
		'
		Me.btn_Cancel.AutoSize = True
		Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Cancel.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Cancel.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
		Me.btn_Cancel.Location = New System.Drawing.Point(65, 180)
		Me.btn_Cancel.MinimumSize = New System.Drawing.Size(238, 36)
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.Size = New System.Drawing.Size(238, 36)
		Me.btn_Cancel.TabIndex = 11
		Me.btn_Cancel.Text = "Cancel"
		Me.btn_Cancel.UseVisualStyleBackColor = True
		'
		'EmailMinistryDialog
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(369, 254)
		Me.Controls.Add(Me.btn_Cancel)
		Me.Controls.Add(Me.btn_ViewListeners)
		Me.Controls.Add(Me.btn_Upload)
		Me.Controls.Add(Me.btn_SendEmails)
		Me.Controls.Add(Me.ss_Feedback)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "EmailMinistryDialog"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		Me.ss_Feedback.ResumeLayout(False)
		Me.ss_Feedback.PerformLayout()
		Me.mnstr_Strip.ResumeLayout(False)
		Me.mnstr_Strip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ofd_SelectAudio As OpenFileDialog
	Friend WithEvents ss_Feedback As StatusStrip
	Friend WithEvents tss_Feedback As ToolStripStatusLabel
	Friend WithEvents btn_SendEmails As Button
	Friend WithEvents btn_ViewListeners As Button
	Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
	Friend WithEvents rdo_GoingLive As RadioButton
	Friend WithEvents rdo_EmailMinistry As RadioButton
	Friend WithEvents mnstr_Strip As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListenerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As ToolStripSeparator
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListenersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btn_Upload As Button
	Friend WithEvents db As Database
	Friend WithEvents btn_Cancel As Button
End Class
