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
			Me.pi_Price = New SPPBC.M3Tools.PriceInput()
			Me.gi_Name = New SPPBC.M3Tools.GenericInputPair()
			Me.nud_Stock = New SPPBC.M3Tools.QuantityNudCtrl()
			Me.chk_Available = New System.Windows.Forms.CheckBox()
			Me.tp_Description = New System.Windows.Forms.TabPage()
			Me.rtb_Description = New System.Windows.Forms.RichTextBox()
			Me.tp_Summary = New System.Windows.Forms.TabPage()
			Me.sc_Summary = New SPPBC.M3Tools.SummaryCtrl()
			Me.hp_Info = New System.Windows.Forms.HelpProvider()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.tc_Creation.SuspendLayout()
			Me.tp_Basics.SuspendLayout()
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
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(210, 302)
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
			Me.tc_Creation.Size = New System.Drawing.Size(368, 271)
			Me.tc_Creation.TabIndex = 0
			'
			'tp_Basics
			'
			Me.tp_Basics.Controls.Add(Me.pi_Price)
			Me.tp_Basics.Controls.Add(Me.gi_Name)
			Me.tp_Basics.Controls.Add(Me.nud_Stock)
			Me.tp_Basics.Controls.Add(Me.chk_Available)
			Me.tp_Basics.Location = New System.Drawing.Point(4, 22)
			Me.tp_Basics.Name = "tp_Basics"
			Me.tp_Basics.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Basics.Size = New System.Drawing.Size(360, 245)
			Me.tp_Basics.TabIndex = 0
			Me.tp_Basics.Text = "Basics"
			Me.tp_Basics.UseVisualStyleBackColor = True
			'
			'pi_Price
			'
			Me.pi_Price.AutoSize = True
			Me.pi_Price.Location = New System.Drawing.Point(100, 130)
			Me.pi_Price.MaximumSize = New System.Drawing.Size(0, 45)
			Me.pi_Price.MinimumSize = New System.Drawing.Size(150, 45)
			Me.pi_Price.Name = "pi_Price"
			Me.pi_Price.Price = New Decimal(New Integer() {0, 0, 0, 131072})
			Me.pi_Price.Size = New System.Drawing.Size(150, 45)
			Me.pi_Price.TabIndex = 2
			'
			'gi_Name
			'
			Me.gi_Name.AutoSize = True
			Me.gi_Name.Label = "Name"
			Me.gi_Name.Location = New System.Drawing.Point(30, 21)
			Me.gi_Name.Mask = ""
			Me.gi_Name.MaximumSize = New System.Drawing.Size(0, 45)
			Me.gi_Name.MinimumSize = New System.Drawing.Size(300, 45)
			Me.gi_Name.Name = "gi_Name"
			Me.gi_Name.Placeholder = "Product Name"
			Me.gi_Name.Size = New System.Drawing.Size(300, 45)
			Me.gi_Name.TabIndex = 0
			Me.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'nud_Stock
			'
			Me.nud_Stock.Label = "Stock"
			Me.nud_Stock.Location = New System.Drawing.Point(130, 82)
			Me.nud_Stock.MaximumSize = New System.Drawing.Size(0, 42)
			Me.nud_Stock.MinimumSize = New System.Drawing.Size(100, 42)
			Me.nud_Stock.Name = "nud_Stock"
			Me.nud_Stock.Size = New System.Drawing.Size(100, 42)
			Me.nud_Stock.TabIndex = 1
			'
			'chk_Available
			'
			Me.chk_Available.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.chk_Available.AutoSize = True
			Me.hp_Info.SetHelpKeyword(Me.chk_Available, "availability")
			Me.hp_Info.SetHelpString(Me.chk_Available, "Whether the new item will be available upon creation")
			Me.chk_Available.Location = New System.Drawing.Point(143, 201)
			Me.chk_Available.Name = "chk_Available"
			Me.hp_Info.SetShowHelp(Me.chk_Available, True)
			Me.chk_Available.Size = New System.Drawing.Size(75, 17)
			Me.chk_Available.TabIndex = 3
			Me.chk_Available.Text = "Available?"
			Me.chk_Available.UseVisualStyleBackColor = True
			'
			'tp_Description
			'
			Me.tp_Description.Controls.Add(Me.rtb_Description)
			Me.tp_Description.Location = New System.Drawing.Point(4, 22)
			Me.tp_Description.Name = "tp_Description"
			Me.tp_Description.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Description.Size = New System.Drawing.Size(360, 245)
			Me.tp_Description.TabIndex = 1
			Me.tp_Description.Text = "Product Description"
			Me.tp_Description.UseVisualStyleBackColor = True
			'
			'rtb_Description
			'
			Me.rtb_Description.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rtb_Description.Location = New System.Drawing.Point(3, 3)
			Me.rtb_Description.Name = "rtb_Description"
			Me.rtb_Description.Size = New System.Drawing.Size(354, 239)
			Me.rtb_Description.TabIndex = 0
			Me.rtb_Description.Text = ""
			'
			'tp_Summary
			'
			Me.tp_Summary.Controls.Add(Me.sc_Summary)
			Me.tp_Summary.Location = New System.Drawing.Point(4, 22)
			Me.tp_Summary.Name = "tp_Summary"
			Me.tp_Summary.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Summary.Size = New System.Drawing.Size(360, 245)
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
			Me.sc_Summary.Size = New System.Drawing.Size(354, 239)
			Me.sc_Summary.TabIndex = 0
			'
			'AddProductDialog
			'
			Me.AcceptButton = Me.btn_Create
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(368, 343)
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
		Friend WithEvents rtb_Description As Windows.Forms.RichTextBox
		Friend WithEvents chk_Available As Windows.Forms.CheckBox
		Friend WithEvents hp_Info As Windows.Forms.HelpProvider
		Friend WithEvents nud_Stock As QuantityNudCtrl
		Friend WithEvents gi_Name As GenericInputPair
		Friend WithEvents pi_Price As PriceInput
	End Class
End Namespace
