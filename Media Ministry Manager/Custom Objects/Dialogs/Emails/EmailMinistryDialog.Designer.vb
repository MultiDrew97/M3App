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
		Me.btn_Upload = New System.Windows.Forms.Button()
		Me.btn_Cancel = New System.Windows.Forms.Button()
		Me.ss_Feedback.SuspendLayout()
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
	Friend WithEvents btn_Upload As Button
	Friend WithEvents db As Database
	Friend WithEvents btn_Cancel As Button
End Class
