<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                cts.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Default = New System.Windows.Forms.Button()
        Me.tc_Settings = New System.Windows.Forms.TabControl()
        Me.tp_Fonts = New System.Windows.Forms.TabPage()
        Me.lbl_Bold = New System.Windows.Forms.Label()
        Me.btn_ChangeFont = New System.Windows.Forms.Button()
        Me.lbl_CurrentFont = New System.Windows.Forms.Label()
        Me.lbl_FontSize = New System.Windows.Forms.Label()
        Me.tp_LinkedAccounts = New System.Windows.Forms.TabPage()
        Me.lbl_CurrentGmail = New System.Windows.Forms.Label()
        Me.lbl_CurrentDrive = New System.Windows.Forms.Label()
        Me.btn_Gmail = New System.Windows.Forms.Button()
        Me.btn_GoogleDrive = New System.Windows.Forms.Button()
        Me.fd_FontSelector = New System.Windows.Forms.FontDialog()
        Me.bw_Settings = New System.ComponentModel.BackgroundWorker()
        Me.bw_Service = New System.ComponentModel.BackgroundWorker()
        Me.bw_CheckServices = New System.ComponentModel.BackgroundWorker()
        Me.tc_Settings.SuspendLayout()
        Me.tp_Fonts.SuspendLayout()
        Me.tp_LinkedAccounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(325, 382)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(72, 36)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Default
        '
        Me.btn_Default.AutoSize = True
        Me.btn_Default.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Default.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Default.Location = New System.Drawing.Point(39, 382)
        Me.btn_Default.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(208, 36)
        Me.btn_Default.TabIndex = 1
        Me.btn_Default.Text = "Restore to Defaults"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'tc_Settings
        '
        Me.tc_Settings.Controls.Add(Me.tp_Fonts)
        Me.tc_Settings.Controls.Add(Me.tp_LinkedAccounts)
        Me.tc_Settings.Dock = System.Windows.Forms.DockStyle.Top
        Me.tc_Settings.HotTrack = True
        Me.tc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.tc_Settings.Name = "tc_Settings"
        Me.tc_Settings.SelectedIndex = 0
        Me.tc_Settings.Size = New System.Drawing.Size(484, 330)
        Me.tc_Settings.TabIndex = 2
        '
        'tp_Fonts
        '
        Me.tp_Fonts.BackColor = System.Drawing.Color.Transparent
        Me.tp_Fonts.Controls.Add(Me.lbl_Bold)
        Me.tp_Fonts.Controls.Add(Me.btn_ChangeFont)
        Me.tp_Fonts.Controls.Add(Me.lbl_CurrentFont)
        Me.tp_Fonts.Controls.Add(Me.lbl_FontSize)
        Me.tp_Fonts.Location = New System.Drawing.Point(4, 34)
        Me.tp_Fonts.Name = "tp_Fonts"
        Me.tp_Fonts.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Fonts.Size = New System.Drawing.Size(476, 292)
        Me.tp_Fonts.TabIndex = 0
        Me.tp_Fonts.Text = "Font Selection"
        '
        'lbl_Bold
        '
        Me.lbl_Bold.AutoSize = True
        Me.lbl_Bold.Location = New System.Drawing.Point(316, 131)
        Me.lbl_Bold.Name = "lbl_Bold"
        Me.lbl_Bold.Size = New System.Drawing.Size(92, 26)
        Me.lbl_Bold.TabIndex = 5
        Me.lbl_Bold.Text = "Bolded?"
        '
        'btn_ChangeFont
        '
        Me.btn_ChangeFont.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_ChangeFont.AutoSize = True
        Me.btn_ChangeFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ChangeFont.Location = New System.Drawing.Point(122, 225)
        Me.btn_ChangeFont.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ChangeFont.Name = "btn_ChangeFont"
        Me.btn_ChangeFont.Size = New System.Drawing.Size(232, 36)
        Me.btn_ChangeFont.TabIndex = 4
        Me.btn_ChangeFont.Text = "Change Font Settings"
        Me.btn_ChangeFont.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ChangeFont.UseVisualStyleBackColor = True
        '
        'lbl_CurrentFont
        '
        Me.lbl_CurrentFont.AutoSize = True
        Me.lbl_CurrentFont.Location = New System.Drawing.Point(69, 42)
        Me.lbl_CurrentFont.Name = "lbl_CurrentFont"
        Me.lbl_CurrentFont.Size = New System.Drawing.Size(61, 26)
        Me.lbl_CurrentFont.TabIndex = 2
        Me.lbl_CurrentFont.Text = "Font:"
        '
        'lbl_FontSize
        '
        Me.lbl_FontSize.AutoSize = True
        Me.lbl_FontSize.Location = New System.Drawing.Point(69, 131)
        Me.lbl_FontSize.Name = "lbl_FontSize"
        Me.lbl_FontSize.Size = New System.Drawing.Size(110, 26)
        Me.lbl_FontSize.TabIndex = 1
        Me.lbl_FontSize.Text = "Font Size:"
        '
        'tp_LinkedAccounts
        '
        Me.tp_LinkedAccounts.BackColor = System.Drawing.Color.Transparent
        Me.tp_LinkedAccounts.Controls.Add(Me.lbl_CurrentGmail)
        Me.tp_LinkedAccounts.Controls.Add(Me.lbl_CurrentDrive)
        Me.tp_LinkedAccounts.Controls.Add(Me.btn_Gmail)
        Me.tp_LinkedAccounts.Controls.Add(Me.btn_GoogleDrive)
        Me.tp_LinkedAccounts.Location = New System.Drawing.Point(4, 34)
        Me.tp_LinkedAccounts.Name = "tp_LinkedAccounts"
        Me.tp_LinkedAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_LinkedAccounts.Size = New System.Drawing.Size(476, 292)
        Me.tp_LinkedAccounts.TabIndex = 1
        Me.tp_LinkedAccounts.Text = "Linked Accounts"
        '
        'lbl_CurrentGmail
        '
        Me.lbl_CurrentGmail.AutoSize = True
        Me.lbl_CurrentGmail.Location = New System.Drawing.Point(36, 198)
        Me.lbl_CurrentGmail.Name = "lbl_CurrentGmail"
        Me.lbl_CurrentGmail.Size = New System.Drawing.Size(142, 26)
        Me.lbl_CurrentGmail.TabIndex = 3
        Me.lbl_CurrentGmail.Text = "Current User:"
        '
        'lbl_CurrentDrive
        '
        Me.lbl_CurrentDrive.AutoSize = True
        Me.lbl_CurrentDrive.Location = New System.Drawing.Point(31, 32)
        Me.lbl_CurrentDrive.Name = "lbl_CurrentDrive"
        Me.lbl_CurrentDrive.Size = New System.Drawing.Size(142, 26)
        Me.lbl_CurrentDrive.TabIndex = 2
        Me.lbl_CurrentDrive.Text = "Current User:"
        '
        'btn_Gmail
        '
        Me.btn_Gmail.AutoSize = True
        Me.btn_Gmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Gmail.Location = New System.Drawing.Point(36, 227)
        Me.btn_Gmail.Name = "btn_Gmail"
        Me.btn_Gmail.Size = New System.Drawing.Size(126, 36)
        Me.btn_Gmail.TabIndex = 1
        Me.btn_Gmail.Text = "Link Gmail"
        Me.btn_Gmail.UseVisualStyleBackColor = True
        '
        'btn_GoogleDrive
        '
        Me.btn_GoogleDrive.AutoSize = True
        Me.btn_GoogleDrive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_GoogleDrive.Location = New System.Drawing.Point(36, 75)
        Me.btn_GoogleDrive.Name = "btn_GoogleDrive"
        Me.btn_GoogleDrive.Size = New System.Drawing.Size(195, 36)
        Me.btn_GoogleDrive.TabIndex = 0
        Me.btn_GoogleDrive.Text = "Link Google Drive"
        Me.btn_GoogleDrive.UseVisualStyleBackColor = True
        '
        'fd_FontSelector
        '
        Me.fd_FontSelector.AllowVerticalFonts = False
        Me.fd_FontSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fd_FontSelector.FontMustExist = True
        Me.fd_FontSelector.MaxSize = 24
        Me.fd_FontSelector.MinSize = 12
        Me.fd_FontSelector.ScriptsOnly = True
        '
        'bw_Settings
        '
        '
        'bw_Service
        '
        Me.bw_Service.WorkerSupportsCancellation = True
        '
        'bw_CheckServices
        '
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.tc_Settings)
        Me.Controls.Add(Me.btn_Default)
        Me.Controls.Add(Me.btn_Save)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.tc_Settings.ResumeLayout(False)
        Me.tp_Fonts.ResumeLayout(False)
        Me.tp_Fonts.PerformLayout()
        Me.tp_LinkedAccounts.ResumeLayout(False)
        Me.tp_LinkedAccounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Default As Button
    Friend WithEvents tc_Settings As TabControl
    Friend WithEvents tp_Fonts As TabPage
    Friend WithEvents tp_LinkedAccounts As TabPage
    Friend WithEvents fd_FontSelector As FontDialog
    Friend WithEvents btn_ChangeFont As Button
    Friend WithEvents lbl_CurrentFont As Label
    Friend WithEvents lbl_FontSize As Label
    Friend WithEvents bw_Settings As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Gmail As Button
    Friend WithEvents btn_GoogleDrive As Button
    Friend WithEvents lbl_CurrentDrive As Label
    Friend WithEvents lbl_CurrentGmail As Label
    Friend WithEvents bw_Service As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_CheckServices As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_Bold As Label
End Class
