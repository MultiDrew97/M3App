Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class AddProductDialog
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
			Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.btn_Create = New System.Windows.Forms.Button()
			Me.btn_Cancel = New System.Windows.Forms.Button()
			Me.tc_Creation = New System.Windows.Forms.TabControl()
			Me.tp_Basics = New System.Windows.Forms.TabPage()
			Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
			Me.lbl_Price = New System.Windows.Forms.Label()
			Me.txt_Price = New System.Windows.Forms.MaskedTextBox()
			Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
			Me.lbl_Stock = New System.Windows.Forms.Label()
			Me.nud_Stock = New System.Windows.Forms.NumericUpDown()
			Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.lbl_Name = New System.Windows.Forms.Label()
			Me.txt_Name = New System.Windows.Forms.TextBox()
			Me.chk_Available = New System.Windows.Forms.CheckBox()
			Me.tp_Description = New System.Windows.Forms.TabPage()
			Me.rtb_Description = New System.Windows.Forms.RichTextBox()
			Me.tp_Summary = New System.Windows.Forms.TabPage()
			Me.sc_Summary = New SPPBC.M3Tools.SummaryCtrl()
			Me.hp_Info = New System.Windows.Forms.HelpProvider()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.tc_Creation.SuspendLayout()
			Me.tp_Basics.SuspendLayout()
			CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SplitContainer3.Panel1.SuspendLayout()
			Me.SplitContainer3.Panel2.SuspendLayout()
			Me.SplitContainer3.SuspendLayout()
			CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SplitContainer2.Panel1.SuspendLayout()
			Me.SplitContainer2.Panel2.SuspendLayout()
			Me.SplitContainer2.SuspendLayout()
			CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			Me.tp_Description.SuspendLayout()
			Me.tp_Summary.SuspendLayout()
			Me.SuspendLayout()
			'
			'TableLayoutPanel1
			'
			Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Create, 1, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(582, 464)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
			Me.TableLayoutPanel1.TabIndex = 1
			'
			'btn_Create
			'
			Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Create.Location = New System.Drawing.Point(76, 3)
			Me.btn_Create.Name = "btn_Create"
			Me.btn_Create.Size = New System.Drawing.Size(67, 23)
			Me.btn_Create.TabIndex = 1
			Me.btn_Create.Text = "Next"
			'
			'btn_Cancel
			'
			Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
			Me.btn_Cancel.Name = "btn_Cancel"
			Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
			Me.btn_Cancel.TabIndex = 0
			Me.btn_Cancel.Text = "Cancel"
			'
			'tc_Creation
			'
			Me.tc_Creation.Controls.Add(Me.tp_Basics)
			Me.tc_Creation.Controls.Add(Me.tp_Description)
			Me.tc_Creation.Controls.Add(Me.tp_Summary)
			Me.tc_Creation.Dock = System.Windows.Forms.DockStyle.Top
			Me.tc_Creation.Location = New System.Drawing.Point(0, 0)
			Me.tc_Creation.Name = "tc_Creation"
			Me.tc_Creation.SelectedIndex = 0
			Me.tc_Creation.Size = New System.Drawing.Size(740, 458)
			Me.tc_Creation.TabIndex = 0
			'
			'tp_Basics
			'
			Me.tp_Basics.Controls.Add(Me.SplitContainer3)
			Me.tp_Basics.Controls.Add(Me.SplitContainer2)
			Me.tp_Basics.Controls.Add(Me.SplitContainer1)
			Me.tp_Basics.Controls.Add(Me.chk_Available)
			Me.tp_Basics.Location = New System.Drawing.Point(4, 22)
			Me.tp_Basics.Name = "tp_Basics"
			Me.tp_Basics.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Basics.Size = New System.Drawing.Size(732, 432)
			Me.tp_Basics.TabIndex = 0
			Me.tp_Basics.Text = "Basics"
			Me.tp_Basics.UseVisualStyleBackColor = True
			'
			'SplitContainer3
			'
			Me.SplitContainer3.Location = New System.Drawing.Point(113, 174)
			Me.SplitContainer3.Name = "SplitContainer3"
			Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
			'
			'SplitContainer3.Panel1
			'
			Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_Price)
			'
			'SplitContainer3.Panel2
			'
			Me.SplitContainer3.Panel2.Controls.Add(Me.txt_Price)
			Me.SplitContainer3.Size = New System.Drawing.Size(143, 63)
			Me.SplitContainer3.SplitterDistance = 28
			Me.SplitContainer3.TabIndex = 8
			'
			'lbl_Price
			'
			Me.lbl_Price.AutoSize = True
			Me.lbl_Price.Location = New System.Drawing.Point(3, 0)
			Me.lbl_Price.Name = "lbl_Price"
			Me.lbl_Price.Size = New System.Drawing.Size(31, 13)
			Me.lbl_Price.TabIndex = 4
			Me.lbl_Price.Text = "Price"
			'
			'txt_Price
			'
			Me.txt_Price.Dock = System.Windows.Forms.DockStyle.Fill
			Me.txt_Price.Location = New System.Drawing.Point(0, 0)
			Me.txt_Price.Mask = "$00000.99"
			Me.txt_Price.Name = "txt_Price"
			Me.txt_Price.Size = New System.Drawing.Size(143, 20)
			Me.txt_Price.TabIndex = 5
			Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			'
			'SplitContainer2
			'
			Me.SplitContainer2.Location = New System.Drawing.Point(113, 114)
			Me.SplitContainer2.Name = "SplitContainer2"
			Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
			'
			'SplitContainer2.Panel1
			'
			Me.SplitContainer2.Panel1.Controls.Add(Me.lbl_Stock)
			'
			'SplitContainer2.Panel2
			'
			Me.SplitContainer2.Panel2.Controls.Add(Me.nud_Stock)
			Me.SplitContainer2.Size = New System.Drawing.Size(143, 54)
			Me.SplitContainer2.SplitterDistance = 25
			Me.SplitContainer2.TabIndex = 7
			'
			'lbl_Stock
			'
			Me.lbl_Stock.AutoSize = True
			Me.lbl_Stock.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbl_Stock.Location = New System.Drawing.Point(0, 0)
			Me.lbl_Stock.Name = "lbl_Stock"
			Me.lbl_Stock.Size = New System.Drawing.Size(35, 13)
			Me.lbl_Stock.TabIndex = 2
			Me.lbl_Stock.Text = "Stock"
			'
			'nud_Stock
			'
			Me.nud_Stock.Dock = System.Windows.Forms.DockStyle.Fill
			Me.nud_Stock.Location = New System.Drawing.Point(0, 0)
			Me.nud_Stock.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
			Me.nud_Stock.Name = "nud_Stock"
			Me.nud_Stock.Size = New System.Drawing.Size(143, 20)
			Me.nud_Stock.TabIndex = 3
			Me.nud_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.nud_Stock.ThousandsSeparator = True
			'
			'SplitContainer1
			'
			Me.SplitContainer1.Location = New System.Drawing.Point(48, 39)
			Me.SplitContainer1.Name = "SplitContainer1"
			Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			'
			'SplitContainer1.Panel1
			'
			Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_Name)
			'
			'SplitContainer1.Panel2
			'
			Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Name)
			Me.SplitContainer1.Size = New System.Drawing.Size(280, 69)
			Me.SplitContainer1.SplitterDistance = 36
			Me.SplitContainer1.TabIndex = 6
			'
			'lbl_Name
			'
			Me.lbl_Name.AutoSize = True
			Me.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbl_Name.Location = New System.Drawing.Point(0, 0)
			Me.lbl_Name.Name = "lbl_Name"
			Me.lbl_Name.Size = New System.Drawing.Size(35, 13)
			Me.lbl_Name.TabIndex = 0
			Me.lbl_Name.Text = "Name"
			'
			'txt_Name
			'
			Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Top
			Me.txt_Name.Location = New System.Drawing.Point(0, 0)
			Me.txt_Name.Multiline = True
			Me.txt_Name.Name = "txt_Name"
			Me.txt_Name.Size = New System.Drawing.Size(280, 29)
			Me.txt_Name.TabIndex = 1
			'
			'chk_Available
			'
			Me.chk_Available.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.chk_Available.AutoSize = True
			Me.hp_Info.SetHelpKeyword(Me.chk_Available, "availability")
			Me.hp_Info.SetHelpString(Me.chk_Available, "Whether the new item will be available upon creation")
			Me.chk_Available.Location = New System.Drawing.Point(143, 243)
			Me.chk_Available.Name = "chk_Available"
			Me.hp_Info.SetShowHelp(Me.chk_Available, True)
			Me.chk_Available.Size = New System.Drawing.Size(75, 17)
			Me.chk_Available.TabIndex = 1
			Me.chk_Available.Text = "Available?"
			Me.chk_Available.UseVisualStyleBackColor = True
			'
			'tp_Description
			'
			Me.tp_Description.Controls.Add(Me.rtb_Description)
			Me.tp_Description.Location = New System.Drawing.Point(4, 22)
			Me.tp_Description.Name = "tp_Description"
			Me.tp_Description.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Description.Size = New System.Drawing.Size(732, 432)
			Me.tp_Description.TabIndex = 1
			Me.tp_Description.Text = "Product Description"
			Me.tp_Description.UseVisualStyleBackColor = True
			'
			'rtb_Description
			'
			Me.rtb_Description.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rtb_Description.Location = New System.Drawing.Point(3, 3)
			Me.rtb_Description.Name = "rtb_Description"
			Me.rtb_Description.Size = New System.Drawing.Size(726, 426)
			Me.rtb_Description.TabIndex = 0
			Me.rtb_Description.Text = ""
			'
			'tp_Summary
			'
			Me.tp_Summary.Controls.Add(Me.sc_Summary)
			Me.tp_Summary.Location = New System.Drawing.Point(4, 22)
			Me.tp_Summary.Name = "tp_Summary"
			Me.tp_Summary.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Summary.Size = New System.Drawing.Size(732, 432)
			Me.tp_Summary.TabIndex = 2
			Me.tp_Summary.Text = "Summary"
			Me.tp_Summary.UseVisualStyleBackColor = True
			'
			'sc_Summary
			'
			Me.sc_Summary.Display = Nothing
			Me.sc_Summary.Dock = System.Windows.Forms.DockStyle.Fill
			Me.sc_Summary.Location = New System.Drawing.Point(3, 3)
			Me.sc_Summary.Name = "sc_Summary"
			Me.sc_Summary.Size = New System.Drawing.Size(726, 426)
			Me.sc_Summary.TabIndex = 0
			'
			'AddProductDialog
			'
			Me.AcceptButton = Me.btn_Create
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(740, 505)
			Me.Controls.Add(Me.tc_Creation)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AddProductDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "New Product"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.tc_Creation.ResumeLayout(False)
			Me.tp_Basics.ResumeLayout(False)
			Me.tp_Basics.PerformLayout()
			Me.SplitContainer3.Panel1.ResumeLayout(False)
			Me.SplitContainer3.Panel1.PerformLayout()
			Me.SplitContainer3.Panel2.ResumeLayout(False)
			Me.SplitContainer3.Panel2.PerformLayout()
			CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SplitContainer3.ResumeLayout(False)
			Me.SplitContainer2.Panel1.ResumeLayout(False)
			Me.SplitContainer2.Panel1.PerformLayout()
			Me.SplitContainer2.Panel2.ResumeLayout(False)
			CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SplitContainer2.ResumeLayout(False)
			CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel1.PerformLayout()
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			Me.SplitContainer1.Panel2.PerformLayout()
			CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SplitContainer1.ResumeLayout(False)
			Me.tp_Description.ResumeLayout(False)
			Me.tp_Summary.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Create As System.Windows.Forms.Button
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents tc_Creation As Windows.Forms.TabControl
		Friend WithEvents tp_Basics As Windows.Forms.TabPage
		Friend WithEvents tp_Description As Windows.Forms.TabPage
		Friend WithEvents tp_Summary As Windows.Forms.TabPage
		Friend WithEvents sc_Summary As SummaryCtrl
		Friend WithEvents nud_Stock As Windows.Forms.NumericUpDown
		Friend WithEvents txt_Name As Windows.Forms.TextBox
		Friend WithEvents lbl_Stock As Windows.Forms.Label
		Friend WithEvents lbl_Name As Windows.Forms.Label
		Friend WithEvents rtb_Description As Windows.Forms.RichTextBox
		Friend WithEvents lbl_Price As Windows.Forms.Label
		Friend WithEvents txt_Price As Windows.Forms.MaskedTextBox
		Friend WithEvents chk_Available As Windows.Forms.CheckBox
		Friend WithEvents hp_Info As Windows.Forms.HelpProvider
		Friend WithEvents SplitContainer3 As Windows.Forms.SplitContainer
		Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
		Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
	End Class
End Namespace
