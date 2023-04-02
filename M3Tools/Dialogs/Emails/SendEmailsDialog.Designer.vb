<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendEmailsDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Send = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.tc_EmailTypes = New System.Windows.Forms.TabControl()
        Me.sermon = New System.Windows.Forms.TabPage()
        Me.tsc_DriveFilesContainer = New System.Windows.Forms.ToolStripContainer()
        Me.gdt_Files = New SPPBC.M3Tools.DriveTree()
        Me.ts_Tools = New System.Windows.Forms.ToolStrip()
        Me.tss_NewItem = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsmi_NewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_NewUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.receipt = New System.Windows.Forms.TabPage()
        Me.fu_Receipts = New SPPBC.M3Tools.FileUpload()
        Me.bw_GatherFiles = New System.ComponentModel.BackgroundWorker()
        Me.bw_PrepEmails = New System.ComponentModel.BackgroundWorker()
        Me.bw_GatherReceipients = New System.ComponentModel.BackgroundWorker()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.gmt_Gmail = New SPPBC.M3Tools.GTools.GmailTool(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tc_EmailTypes.SuspendLayout()
        Me.sermon.SuspendLayout()
        Me.tsc_DriveFilesContainer.ContentPanel.SuspendLayout()
        Me.tsc_DriveFilesContainer.TopToolStripPanel.SuspendLayout()
        Me.tsc_DriveFilesContainer.SuspendLayout()
        Me.ts_Tools.SuspendLayout()
        Me.receipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Send, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(253, 323)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Send
        '
        Me.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Send.Location = New System.Drawing.Point(76, 3)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(67, 23)
        Me.btn_Send.TabIndex = 0
        Me.btn_Send.Text = "Send"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'tc_EmailTypes
        '
        Me.tc_EmailTypes.Controls.Add(Me.sermon)
        Me.tc_EmailTypes.Controls.Add(Me.receipt)
        Me.tc_EmailTypes.Dock = System.Windows.Forms.DockStyle.Top
        Me.tc_EmailTypes.Location = New System.Drawing.Point(0, 0)
        Me.tc_EmailTypes.Name = "tc_EmailTypes"
        Me.tc_EmailTypes.SelectedIndex = 0
        Me.tc_EmailTypes.Size = New System.Drawing.Size(411, 317)
        Me.tc_EmailTypes.TabIndex = 0
        '
        'sermon
        '
        Me.sermon.Controls.Add(Me.tsc_DriveFilesContainer)
        Me.sermon.Location = New System.Drawing.Point(4, 22)
        Me.sermon.Name = "sermon"
        Me.sermon.Size = New System.Drawing.Size(403, 291)
        Me.sermon.TabIndex = 0
        Me.sermon.Text = "New Sermon(s)"
        Me.sermon.UseVisualStyleBackColor = True
        '
        'tsc_DriveFilesContainer
        '
        Me.tsc_DriveFilesContainer.BottomToolStripPanelVisible = False
        '
        'tsc_DriveFilesContainer.ContentPanel
        '
        Me.tsc_DriveFilesContainer.ContentPanel.Controls.Add(Me.gdt_Files)
        Me.tsc_DriveFilesContainer.ContentPanel.Size = New System.Drawing.Size(403, 291)
        Me.tsc_DriveFilesContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsc_DriveFilesContainer.LeftToolStripPanelVisible = False
        Me.tsc_DriveFilesContainer.Location = New System.Drawing.Point(0, 0)
        Me.tsc_DriveFilesContainer.Name = "tsc_DriveFilesContainer"
        Me.tsc_DriveFilesContainer.RightToolStripPanelVisible = False
        Me.tsc_DriveFilesContainer.Size = New System.Drawing.Size(403, 291)
        Me.tsc_DriveFilesContainer.TabIndex = 7
        Me.tsc_DriveFilesContainer.Text = "ToolStripContainer1"
        '
        'tsc_DriveFilesContainer.TopToolStripPanel
        '
        Me.tsc_DriveFilesContainer.TopToolStripPanel.Controls.Add(Me.ts_Tools)
        '
        'gdt_Files
        '
        Me.gdt_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdt_Files.Location = New System.Drawing.Point(0, 0)
        Me.gdt_Files.Name = "gdt_Files"
        Me.gdt_Files.Size = New System.Drawing.Size(403, 291)
        Me.gdt_Files.TabIndex = 4
        Me.gdt_Files.WithChildren = False
        '
        'ts_Tools
        '
        Me.ts_Tools.Dock = System.Windows.Forms.DockStyle.None
        Me.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_Tools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ts_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_NewItem})
        Me.ts_Tools.Location = New System.Drawing.Point(0, 0)
        Me.ts_Tools.Name = "ts_Tools"
        Me.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ts_Tools.Size = New System.Drawing.Size(51, 39)
        Me.ts_Tools.Stretch = True
        Me.ts_Tools.TabIndex = 1
        Me.ts_Tools.Visible = False
        '
        'tss_NewItem
        '
        Me.tss_NewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tss_NewItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_NewFolder, Me.tsmi_NewUpload})
        Me.tss_NewItem.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tss_NewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tss_NewItem.Name = "tss_NewItem"
        Me.tss_NewItem.Size = New System.Drawing.Size(48, 36)
        Me.tss_NewItem.Text = "New"
        '
        'tsmi_NewFolder
        '
        Me.tsmi_NewFolder.Name = "tsmi_NewFolder"
        Me.tsmi_NewFolder.Size = New System.Drawing.Size(139, 22)
        Me.tsmi_NewFolder.Text = "New Folder"
        '
        'tsmi_NewUpload
        '
        Me.tsmi_NewUpload.Name = "tsmi_NewUpload"
        Me.tsmi_NewUpload.Size = New System.Drawing.Size(139, 22)
        Me.tsmi_NewUpload.Text = "New Upload"
        '
        'receipt
        '
        Me.receipt.Controls.Add(Me.fu_Receipts)
        Me.receipt.Location = New System.Drawing.Point(4, 22)
        Me.receipt.Name = "receipt"
        Me.receipt.Size = New System.Drawing.Size(403, 291)
        Me.receipt.TabIndex = 0
        Me.receipt.Text = "Receipts"
        Me.receipt.UseVisualStyleBackColor = True
        '
        'fu_Receipts
        '
        Me.fu_Receipts.Location = New System.Drawing.Point(61, 3)
        Me.fu_Receipts.MultiSelect = True
        Me.fu_Receipts.Name = "fu_Receipts"
        Me.fu_Receipts.Size = New System.Drawing.Size(283, 68)
        Me.fu_Receipts.TabIndex = 1
        '
        'bw_GatherFiles
        '
        '
        'bw_PrepEmails
        '
        '
        'bw_GatherReceipients
        '
        '
        'bw_SendEmails
        '
        '
        'gmt_Gmail
        '
        Me.gmt_Gmail.Username = Global.SPPBC.M3Tools.My.MySettings.Default.CurrentUser
        '
        'SendEmailsDialog
        '
        Me.AcceptButton = Me.btn_Send
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(411, 364)
        Me.Controls.Add(Me.tc_EmailTypes)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendEmailsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Email"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tc_EmailTypes.ResumeLayout(False)
        Me.sermon.ResumeLayout(False)
        Me.tsc_DriveFilesContainer.ContentPanel.ResumeLayout(False)
        Me.tsc_DriveFilesContainer.TopToolStripPanel.ResumeLayout(False)
        Me.tsc_DriveFilesContainer.TopToolStripPanel.PerformLayout()
        Me.tsc_DriveFilesContainer.ResumeLayout(False)
        Me.tsc_DriveFilesContainer.PerformLayout()
        Me.ts_Tools.ResumeLayout(False)
        Me.ts_Tools.PerformLayout()
        Me.receipt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Send As System.Windows.Forms.Button
	Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents gmt_Gmail As GTools.GmailTool
    Friend WithEvents gdt_Files As DriveTree
	Friend WithEvents tsc_DriveFilesContainer As Windows.Forms.ToolStripContainer
    Friend WithEvents tc_EmailTypes As Windows.Forms.TabControl
    Friend WithEvents sermon As Windows.Forms.TabPage
    Friend WithEvents receipt As Windows.Forms.TabPage
    Friend WithEvents fu_Receipts As FileUpload
    Friend WithEvents bw_GatherFiles As ComponentModel.BackgroundWorker
    Friend WithEvents bw_PrepEmails As ComponentModel.BackgroundWorker
    Friend WithEvents bw_GatherReceipients As ComponentModel.BackgroundWorker
    Friend WithEvents bw_SendEmails As ComponentModel.BackgroundWorker
    Friend WithEvents ts_Tools As Windows.Forms.ToolStrip
    Friend WithEvents tss_NewItem As Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsmi_NewFolder As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_NewUpload As Windows.Forms.ToolStripMenuItem
End Class
