Imports SPPBC.M3Tools

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
        Me.tp_GDrive = New System.Windows.Forms.TabPage()
        Me.gdt_Files = New SPPBC.M3Tools.DriveTree()
        Me.tp_LocalFiles = New System.Windows.Forms.TabPage()
        Me.fu_Receipts = New SPPBC.M3Tools.FileUpload()
        Me.bw_GatherFiles = New System.ComponentModel.BackgroundWorker()
        Me.bw_PrepEmails = New System.ComponentModel.BackgroundWorker()
        Me.bw_GatherReceipients = New System.ComponentModel.BackgroundWorker()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ss_StatusBar = New System.Windows.Forms.StatusStrip()
        Me.tsl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.gmt_Gmail = New SPPBC.M3Tools.GTools.GmailTool(Me.components)
        Me.rsd_Selection = New SPPBC.M3Tools.RecipientSelectionDialog(Me.components)
        Me.dbListeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tc_EmailTypes.SuspendLayout()
        Me.tp_GDrive.SuspendLayout()
        Me.tp_LocalFiles.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ss_StatusBar.SuspendLayout()
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
        Me.tc_EmailTypes.Controls.Add(Me.tp_GDrive)
        Me.tc_EmailTypes.Controls.Add(Me.tp_LocalFiles)
        Me.tc_EmailTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_EmailTypes.Location = New System.Drawing.Point(0, 0)
        Me.tc_EmailTypes.Name = "tc_EmailTypes"
        Me.tc_EmailTypes.SelectedIndex = 0
		Me.tc_EmailTypes.Size = New System.Drawing.Size(411, 298)
		Me.tc_EmailTypes.TabIndex = 0
		'
		'tp_GDrive
		'
		Me.tp_GDrive.Controls.Add(Me.gdt_Files)
        Me.tp_GDrive.Location = New System.Drawing.Point(4, 22)
        Me.tp_GDrive.Name = "tp_GDrive"
		Me.tp_GDrive.Size = New System.Drawing.Size(403, 272)
		Me.tp_GDrive.TabIndex = 0
		Me.tp_GDrive.Text = "Google Drive"
        Me.tp_GDrive.UseVisualStyleBackColor = True
        '
        'gdt_Files
        '
        Me.gdt_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdt_Files.Location = New System.Drawing.Point(0, 0)
        Me.gdt_Files.Name = "gdt_Files"
		Me.gdt_Files.Size = New System.Drawing.Size(403, 272)
		Me.gdt_Files.TabIndex = 4
		Me.gdt_Files.WithChildren = False
        '
        'tp_LocalFiles
        '
        Me.tp_LocalFiles.Controls.Add(Me.fu_Receipts)
        Me.tp_LocalFiles.Location = New System.Drawing.Point(4, 22)
        Me.tp_LocalFiles.Name = "tp_LocalFiles"
		Me.tp_LocalFiles.Size = New System.Drawing.Size(403, 272)
		Me.tp_LocalFiles.TabIndex = 0
		Me.tp_LocalFiles.Text = "Local Files"
        Me.tp_LocalFiles.UseVisualStyleBackColor = True
        '
        'fu_Receipts
        '
        Me.fu_Receipts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fu_Receipts.Location = New System.Drawing.Point(0, 0)
        Me.fu_Receipts.Name = "fu_Receipts"
		Me.fu_Receipts.Size = New System.Drawing.Size(403, 272)
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
		'ToolStripContainer1
		'
		'
		'ToolStripContainer1.BottomToolStripPanel
		'
		Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ss_StatusBar)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tc_EmailTypes)
		Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(411, 298)
		Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top
		Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
		Me.ToolStripContainer1.Size = New System.Drawing.Size(411, 320)
		Me.ToolStripContainer1.TabIndex = 1
		Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ss_StatusBar
        '
        Me.ss_StatusBar.Dock = System.Windows.Forms.DockStyle.None
		Me.ss_StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Status, Me.tsp_Progress})
		Me.ss_StatusBar.Location = New System.Drawing.Point(0, 0)
        Me.ss_StatusBar.Name = "ss_StatusBar"
		Me.ss_StatusBar.Size = New System.Drawing.Size(411, 22)
		Me.ss_StatusBar.TabIndex = 0
		'
		'tsl_Status
		'
		Me.tsl_Status.Name = "tsl_Status"
        Me.tsl_Status.Size = New System.Drawing.Size(141, 17)
        Me.tsl_Status.Text = "Select the files to attach..."
        '
        'tsp_Progress
        '
        Me.tsp_Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsp_Progress.Name = "tsp_Progress"
        Me.tsp_Progress.Size = New System.Drawing.Size(100, 16)
        '
        'gmt_Gmail
        '
        Me.gmt_Gmail.Username = "arandlemiller97"
        '
        'dbListeners
        '
        Me.dbListeners.InitialCatalog = "Media Ministry Test"
        Me.dbListeners.Password = "M3AppPassword2499"
        Me.dbListeners.Username = "M3App"
        '
        'SendEmailsDialog
        '
        Me.AcceptButton = Me.btn_Send
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
		Me.ClientSize = New System.Drawing.Size(411, 364)
		Me.Controls.Add(Me.ToolStripContainer1)
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
        Me.tp_GDrive.ResumeLayout(False)
        Me.tp_LocalFiles.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ss_StatusBar.ResumeLayout(False)
        Me.ss_StatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Send As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents gmt_Gmail As GTools.GmailTool
    Friend WithEvents gdt_Files As DriveTree
    Friend WithEvents tc_EmailTypes As Windows.Forms.TabControl
    Friend WithEvents tp_GDrive As Windows.Forms.TabPage
    Friend WithEvents tp_LocalFiles As Windows.Forms.TabPage
    Friend WithEvents bw_GatherFiles As ComponentModel.BackgroundWorker
    Friend WithEvents bw_PrepEmails As ComponentModel.BackgroundWorker
    Friend WithEvents bw_GatherReceipients As ComponentModel.BackgroundWorker
    Friend WithEvents bw_SendEmails As ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents ss_StatusBar As Windows.Forms.StatusStrip
    Friend WithEvents tsl_Status As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsp_Progress As Windows.Forms.ToolStripProgressBar
    Friend WithEvents fu_Receipts As FileUpload
    Friend WithEvents rsd_Selection As RecipientSelectionDialog
	Friend WithEvents dbListeners As SPPBC.M3Tools.Database.ListenerDatabase
End Class
