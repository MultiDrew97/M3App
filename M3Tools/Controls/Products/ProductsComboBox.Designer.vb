<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsComboBox
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.components = New System.ComponentModel.Container()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbx_Items = New System.Windows.Forms.ComboBox()
		Me.bsItems = New System.Windows.Forms.BindingSource(Me.components)
		Me.lbl_Items = New System.Windows.Forms.Label()
		Me.bw_LoadItems = New System.ComponentModel.BackgroundWorker()
		Me.db_Products = New SPPBC.M3Tools.Database.ProductDatabase(Me.components)
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.bsItems, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.cbx_Items, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.lbl_Items, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 42)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'cbx_Items
		'
		Me.cbx_Items.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsItems, "ItemID", True))
		Me.cbx_Items.DataSource = Me.bsItems
		Me.cbx_Items.DisplayMember = "ItemName"
		Me.cbx_Items.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cbx_Items.FormattingEnabled = True
		Me.cbx_Items.Location = New System.Drawing.Point(3, 16)
		Me.cbx_Items.Name = "cbx_Items"
		Me.cbx_Items.Size = New System.Drawing.Size(194, 21)
		Me.cbx_Items.TabIndex = 2
		Me.cbx_Items.ValueMember = "ItemID"
		'
		'bsItems
		'
		Me.bsItems.DataSource = GetType(SPPBC.M3Tools.DataTables.ItemsDataTable)
		'
		'lbl_Items
		'
		Me.lbl_Items.AutoSize = True
		Me.lbl_Items.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbl_Items.Location = New System.Drawing.Point(3, 0)
		Me.lbl_Items.Name = "lbl_Items"
		Me.lbl_Items.Size = New System.Drawing.Size(194, 13)
		Me.lbl_Items.TabIndex = 0
		Me.lbl_Items.Text = "Items"
		'
		'bw_LoadItems
		'
		'
		'db_Products
		'
		Me.db_Products.InitialCatalog = "Media Ministry"
		Me.db_Products.Password = "M3AppPassword2499"
		Me.db_Products.Username = "M3App"
		'
		'ProductsComboBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.MaximumSize = New System.Drawing.Size(0, 42)
		Me.MinimumSize = New System.Drawing.Size(200, 42)
		Me.Name = "ProductsComboBox"
		Me.Size = New System.Drawing.Size(200, 42)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me.bsItems, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
	Friend WithEvents lbl_Items As Windows.Forms.Label
	Friend WithEvents cbx_Items As Windows.Forms.ComboBox
	Friend WithEvents bw_LoadItems As ComponentModel.BackgroundWorker
	Friend WithEvents db_Products As Database.ProductDatabase
	Friend WithEvents bsItems As Windows.Forms.BindingSource
End Class
