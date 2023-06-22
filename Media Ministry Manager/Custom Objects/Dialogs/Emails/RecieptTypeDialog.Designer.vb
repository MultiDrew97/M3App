<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieptTypeDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_Other = New System.Windows.Forms.TextBox()
        Me.lbl_Other = New System.Windows.Forms.Label()
        Me.gbx_RecieptOptions = New System.Windows.Forms.GroupBox()
        Me.rdo_Tithes = New System.Windows.Forms.RadioButton()
        Me.rdo_Other = New System.Windows.Forms.RadioButton()
        Me.rdo_LoveOffering = New System.Windows.Forms.RadioButton()
        Me.rdo_Offering = New System.Windows.Forms.RadioButton()
        Me.nud_Amount = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Amount = New System.Windows.Forms.Label()
        Me.gbx_RecieptOptions.SuspendLayout()
        CType(Me.nud_Amount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Ok
        '
        Me.btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Ok.AutoSize = True
        Me.btn_Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Ok.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Ok.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_Ok.Location = New System.Drawing.Point(239, 266)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(51, 35)
        Me.btn_Ok.TabIndex = 0
        Me.btn_Ok.Text = "Ok"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Cancel.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_Cancel.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.btn_Cancel.Location = New System.Drawing.Point(111, 266)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(95, 35)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'txt_Other
        '
        Me.txt_Other.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txt_Other.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txt_Other.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.txt_Other.Location = New System.Drawing.Point(61, 257)
        Me.txt_Other.Name = "txt_Other"
        Me.txt_Other.Size = New System.Drawing.Size(310, 31)
        Me.txt_Other.TabIndex = 1
        Me.txt_Other.Visible = False
        '
        'lbl_Other
        '
        Me.lbl_Other.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Other.AutoSize = True
		Me.lbl_Other.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_Other.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_Other.Location = New System.Drawing.Point(56, 229)
        Me.lbl_Other.Name = "lbl_Other"
        Me.lbl_Other.Size = New System.Drawing.Size(70, 25)
        Me.lbl_Other.TabIndex = 2
        Me.lbl_Other.Text = "Other"
        Me.lbl_Other.Visible = False
        '
        'gbx_RecieptOptions
        '
        Me.gbx_RecieptOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RecieptOptions.Controls.Add(Me.rdo_Tithes)
        Me.gbx_RecieptOptions.Controls.Add(Me.rdo_Other)
        Me.gbx_RecieptOptions.Controls.Add(Me.rdo_LoveOffering)
        Me.gbx_RecieptOptions.Controls.Add(Me.rdo_Offering)
		Me.gbx_RecieptOptions.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.gbx_RecieptOptions.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.gbx_RecieptOptions.Location = New System.Drawing.Point(70, 12)
        Me.gbx_RecieptOptions.Name = "gbx_RecieptOptions"
        Me.gbx_RecieptOptions.Size = New System.Drawing.Size(301, 164)
        Me.gbx_RecieptOptions.TabIndex = 28
        Me.gbx_RecieptOptions.TabStop = False
        Me.gbx_RecieptOptions.Text = "Type"
        '
        'rdo_Tithes
        '
        Me.rdo_Tithes.AutoSize = True
        Me.rdo_Tithes.Checked = True
        Me.rdo_Tithes.Location = New System.Drawing.Point(69, 19)
        Me.rdo_Tithes.Name = "rdo_Tithes"
        Me.rdo_Tithes.Size = New System.Drawing.Size(95, 29)
        Me.rdo_Tithes.TabIndex = 0
        Me.rdo_Tithes.TabStop = True
        Me.rdo_Tithes.Text = "Tithes"
        Me.rdo_Tithes.UseVisualStyleBackColor = True
        '
        'rdo_Other
        '
        Me.rdo_Other.AutoSize = True
        Me.rdo_Other.Location = New System.Drawing.Point(69, 124)
        Me.rdo_Other.Name = "rdo_Other"
        Me.rdo_Other.Size = New System.Drawing.Size(88, 29)
        Me.rdo_Other.TabIndex = 0
        Me.rdo_Other.Text = "Other"
        Me.rdo_Other.UseVisualStyleBackColor = True
        '
        'rdo_LoveOffering
        '
        Me.rdo_LoveOffering.AutoSize = True
        Me.rdo_LoveOffering.Location = New System.Drawing.Point(69, 89)
        Me.rdo_LoveOffering.Name = "rdo_LoveOffering"
        Me.rdo_LoveOffering.Size = New System.Drawing.Size(172, 29)
        Me.rdo_LoveOffering.TabIndex = 0
        Me.rdo_LoveOffering.Text = "Love Offering"
        Me.rdo_LoveOffering.UseVisualStyleBackColor = True
        '
        'rdo_Offering
        '
        Me.rdo_Offering.AutoSize = True
        Me.rdo_Offering.Location = New System.Drawing.Point(69, 54)
        Me.rdo_Offering.Name = "rdo_Offering"
        Me.rdo_Offering.Size = New System.Drawing.Size(114, 29)
        Me.rdo_Offering.TabIndex = 0
        Me.rdo_Offering.Text = "Offering"
        Me.rdo_Offering.UseVisualStyleBackColor = True
		'
		'nud_Amount
		'
		Me.nud_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.nud_Amount.DecimalPlaces = 2
		Me.nud_Amount.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.nud_Amount.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_Amount.Location = New System.Drawing.Point(154, 217)
        Me.nud_Amount.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.nud_Amount.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_Amount.Name = "nud_Amount"
        Me.nud_Amount.Size = New System.Drawing.Size(120, 31)
        Me.nud_Amount.TabIndex = 29
        Me.nud_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_Amount.ThousandsSeparator = True
        Me.nud_Amount.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'lbl_Amount
        '
        Me.lbl_Amount.AutoSize = True
		Me.lbl_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.My.Settings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_Amount.Font = Global.MediaMinistry.My.Settings.Default.CurrentFont
		Me.lbl_Amount.Location = New System.Drawing.Point(149, 189)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(98, 25)
        Me.lbl_Amount.TabIndex = 30
        Me.lbl_Amount.Text = "Amount:"
        '
        'RecieptTypeDialog
        '
        Me.AcceptButton = Me.btn_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(424, 329)
        Me.Controls.Add(Me.lbl_Amount)
        Me.Controls.Add(Me.nud_Amount)
        Me.Controls.Add(Me.gbx_RecieptOptions)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.lbl_Other)
        Me.Controls.Add(Me.txt_Other)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecieptTypeDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RecieptTypeDialog"
        Me.gbx_RecieptOptions.ResumeLayout(False)
        Me.gbx_RecieptOptions.PerformLayout()
        CType(Me.nud_Amount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Ok As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_Other As TextBox
    Friend WithEvents lbl_Other As Label
    Friend WithEvents gbx_RecieptOptions As GroupBox
    Friend WithEvents rdo_Tithes As RadioButton
    Friend WithEvents rdo_Other As RadioButton
    Friend WithEvents rdo_LoveOffering As RadioButton
    Friend WithEvents rdo_Offering As RadioButton
    Friend WithEvents nud_Amount As NumericUpDown
    Friend WithEvents lbl_Amount As Label
End Class
