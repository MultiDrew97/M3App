<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaceOrderDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceOrderDialog))
        Me.cbx_ItemName = New System.Windows.Forms.ComboBox()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.ss_AddOrder = New System.Windows.Forms.StatusStrip()
        Me.tss_AddOrder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbx_Name = New System.Windows.Forms.ComboBox()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.nud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.bw_LoadingData = New System.ComponentModel.BackgroundWorker()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddOrder.SuspendLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_ItemName
        '
        Me.cbx_ItemName.DataSource = Me.bsProducts
        Me.cbx_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_ItemName.FormattingEnabled = True
        Me.cbx_ItemName.Location = New System.Drawing.Point(43, 158)
        Me.cbx_ItemName.Name = "cbx_ItemName"
        Me.cbx_ItemName.Size = New System.Drawing.Size(323, 33)
        Me.cbx_ItemName.TabIndex = 5
        '
        'bsProducts
        '
        Me.bsProducts.Filter = "Available=True"
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_ItemName.Location = New System.Drawing.Point(40, 140)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(49, 15)
        Me.lbl_ItemName.TabIndex = 4
        Me.lbl_ItemName.Text = "Product"
        '
        'ss_AddOrder
        '
        Me.ss_AddOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddOrder})
        Me.ss_AddOrder.Location = New System.Drawing.Point(0, 306)
        Me.ss_AddOrder.Name = "ss_AddOrder"
        Me.ss_AddOrder.Size = New System.Drawing.Size(503, 22)
        Me.ss_AddOrder.TabIndex = 10
        '
        'tss_AddOrder
        '
        Me.tss_AddOrder.Name = "tss_AddOrder"
        Me.tss_AddOrder.Size = New System.Drawing.Size(187, 17)
        Me.tss_AddOrder.Text = "Add the information for the order."
        '
        'cbx_Name
        '
        Me.cbx_Name.DataSource = Me.bsCustomers
        Me.cbx_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_Name.FormattingEnabled = True
        Me.cbx_Name.Location = New System.Drawing.Point(102, 71)
        Me.cbx_Name.Name = "cbx_Name"
        Me.cbx_Name.Size = New System.Drawing.Size(302, 33)
        Me.cbx_Name.TabIndex = 1
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Name.Location = New System.Drawing.Point(99, 54)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Name"
        '
        'nud_Quantity
        '
        Me.nud_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Quantity.Location = New System.Drawing.Point(414, 159)
        Me.nud_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Quantity.Name = "nud_Quantity"
        Me.nud_Quantity.Size = New System.Drawing.Size(48, 32)
        Me.nud_Quantity.TabIndex = 7
        Me.nud_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Quantity.Location = New System.Drawing.Point(411, 141)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Quantity.TabIndex = 6
        Me.lbl_Quantity.Text = "Quantity"
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.AutoSize = True
        Me.btn_AddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_AddOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_AddOrder.Location = New System.Drawing.Point(284, 239)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(122, 36)
        Me.btn_AddOrder.TabIndex = 8
        Me.btn_AddOrder.Text = "Add Order"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(96, 239)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(90, 36)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'PlaceOrderDialog
        '
        Me.AcceptButton = Me.btn_AddOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(503, 328)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.nud_Quantity)
        Me.Controls.Add(Me.ss_AddOrder)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.lbl_ItemName)
        Me.Controls.Add(Me.cbx_Name)
        Me.Controls.Add(Me.cbx_ItemName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PlaceOrderDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddOrder.ResumeLayout(False)
        Me.ss_AddOrder.PerformLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_ItemName As ComboBox
    Friend WithEvents lbl_ItemName As Label
    Friend WithEvents ss_AddOrder As StatusStrip
    Friend WithEvents tss_AddOrder As ToolStripStatusLabel
    Friend WithEvents cbx_Name As ComboBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents nud_Quantity As NumericUpDown
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents bw_LoadingData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bsProducts As BindingSource
    Friend WithEvents bsCustomers As BindingSource
End Class
