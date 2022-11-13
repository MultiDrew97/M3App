<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DisplayOrders
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
		Me.btn_Complete = New System.Windows.Forms.Button()
		Me.btn_ShowCompleted = New System.Windows.Forms.Button()
		Me.lbl_NoOrders = New System.Windows.Forms.Label()
		Me.doc_Orders = New SPPBC.M3Tools.DisplayOrdersCtrl()
		Me.db_Orders = New SPPBC.M3Tools.Database.OrdersDatabase(Me.components)
		Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
		Me.mms_Strip = New SPPBC.M3Tools.MainMenuStrip()
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn_Complete
		'
		Me.btn_Complete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_Complete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Complete.Location = New System.Drawing.Point(12, 55)
		Me.btn_Complete.Name = "btn_Complete"
		Me.btn_Complete.Size = New System.Drawing.Size(128, 63)
		Me.btn_Complete.TabIndex = 1
		Me.btn_Complete.Text = "Complete Order(s)"
		Me.btn_Complete.UseVisualStyleBackColor = True
		'
		'btn_ShowCompleted
		'
		Me.btn_ShowCompleted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btn_ShowCompleted.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_ShowCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ShowCompleted.Location = New System.Drawing.Point(12, 188)
		Me.btn_ShowCompleted.Name = "btn_ShowCompleted"
		Me.btn_ShowCompleted.Size = New System.Drawing.Size(128, 87)
		Me.btn_ShowCompleted.TabIndex = 1
		Me.btn_ShowCompleted.Text = "View Completed Orders"
		Me.btn_ShowCompleted.UseVisualStyleBackColor = True
		Me.btn_ShowCompleted.Visible = False
		'
		'lbl_NoOrders
		'
		Me.lbl_NoOrders.AutoSize = True
		Me.lbl_NoOrders.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lbl_NoOrders.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
		Me.lbl_NoOrders.Location = New System.Drawing.Point(274, 219)
		Me.lbl_NoOrders.Name = "lbl_NoOrders"
		Me.lbl_NoOrders.Size = New System.Drawing.Size(397, 25)
		Me.lbl_NoOrders.TabIndex = 3
		Me.lbl_NoOrders.Text = "There are currently no orders placed"
		Me.lbl_NoOrders.Visible = False
		'
		'doc_Orders
		'
		Me.doc_Orders.Dock = System.Windows.Forms.DockStyle.Right
		Me.doc_Orders.Filter = Nothing
		Me.doc_Orders.Location = New System.Drawing.Point(172, 24)
		Me.doc_Orders.Margin = New System.Windows.Forms.Padding(1)
		Me.doc_Orders.Name = "doc_Orders"
		Me.doc_Orders.ShowCompleted = False
		Me.doc_Orders.Size = New System.Drawing.Size(628, 426)
		Me.doc_Orders.TabIndex = 5
		'
		'db_Orders
		'
		Me.db_Orders.InitialCatalog = "Media Ministry"
		Me.db_Orders.Password = "M3AppPassword2499"
		Me.db_Orders.Username = "M3App"
		'
		'mms_Strip
		'
		Me.mms_Strip.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.mms_Strip.Location = New System.Drawing.Point(0, 0)
		Me.mms_Strip.Name = "mms_Strip"
		Me.mms_Strip.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
		Me.mms_Strip.Size = New System.Drawing.Size(800, 24)
		Me.mms_Strip.TabIndex = 6
		Me.mms_Strip.Text = "Menu"
		'
		'Frm_DisplayOrders
		'
		Me.AcceptButton = Me.btn_Complete
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.doc_Orders)
		Me.Controls.Add(Me.lbl_NoOrders)
		Me.Controls.Add(Me.btn_Complete)
		Me.Controls.Add(Me.btn_ShowCompleted)
		Me.Controls.Add(Me.mms_Strip)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.mms_Strip
		Me.MaximizeBox = False
		Me.Name = "Frm_DisplayOrders"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btn_Complete As Button
	Friend WithEvents btn_ShowCompleted As Button
	Friend WithEvents CustomerName As DataGridViewTextBoxColumn
	Friend WithEvents ItemName As DataGridViewTextBoxColumn
	Friend WithEvents Quantity As DataGridViewTextBoxColumn
	Friend WithEvents OrderTotal As DataGridViewTextBoxColumn
	Friend WithEvents lbl_NoOrders As Label
	Friend WithEvents doc_Orders As SPPBC.M3Tools.DisplayOrdersCtrl
	Friend WithEvents db_Orders As SPPBC.M3Tools.Database.OrdersDatabase
	Friend WithEvents bsOrders As BindingSource
	Friend WithEvents mms_Strip As SPPBC.M3Tools.MainMenuStrip
End Class
