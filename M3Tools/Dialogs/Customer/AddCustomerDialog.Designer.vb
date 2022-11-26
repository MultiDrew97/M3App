Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class AddCustomerDialog
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
			Me.btn_Cancel = New System.Windows.Forms.Button()
			Me.btn_Create = New System.Windows.Forms.Button()
			Me.ep_InputError = New System.Windows.Forms.ErrorProvider(Me.components)
			Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
			Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
			Me.tc_Creation = New System.Windows.Forms.TabControl()
			Me.tp_Basic = New System.Windows.Forms.TabPage()
			Me.gi_FirstName = New SPPBC.M3Tools.GenericInputPair()
			Me.gi_LastName = New SPPBC.M3Tools.GenericInputPair()
			Me.pn_PhoneNumber = New SPPBC.M3Tools.PhoneNumberField()
			Me.gi_EmailAddress = New SPPBC.M3Tools.GenericInputPair()
			Me.tp_Address = New System.Windows.Forms.TabPage()
			Me.af_Address = New SPPBC.M3Tools.AddressField()
			Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.ep_InputError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.StatusStrip1.SuspendLayout()
			Me.tc_Creation.SuspendLayout()
			Me.tp_Basic.SuspendLayout()
			Me.tp_Address.SuspendLayout()
			Me.SuspendLayout()
			'
			'TableLayoutPanel1
			'
			Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Create, 1, 0)
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(494, 283)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
			Me.TableLayoutPanel1.TabIndex = 0
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
			'btn_Create
			'
			Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Create.Location = New System.Drawing.Point(76, 3)
			Me.btn_Create.Name = "btn_Create"
			Me.btn_Create.Size = New System.Drawing.Size(67, 23)
			Me.btn_Create.TabIndex = 1
			Me.btn_Create.Text = "Next"
			'
			'ep_InputError
			'
			Me.ep_InputError.ContainerControl = Me
			'
			'StatusStrip1
			'
			Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
			Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
			Me.StatusStrip1.Location = New System.Drawing.Point(0, 315)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
			Me.StatusStrip1.TabIndex = 6
			Me.StatusStrip1.Text = "StatusStrip1"
			'
			'tss_Feedback
			'
			Me.tss_Feedback.Name = "tss_Feedback"
			Me.tss_Feedback.Size = New System.Drawing.Size(271, 17)
			Me.tss_Feedback.Text = "Please enter the infomation for the new customer."
			'
			'tc_Creation
			'
			Me.tc_Creation.Controls.Add(Me.tp_Basic)
			Me.tc_Creation.Controls.Add(Me.tp_Address)
			Me.tc_Creation.Dock = System.Windows.Forms.DockStyle.Top
			Me.tc_Creation.Location = New System.Drawing.Point(0, 0)
			Me.tc_Creation.Name = "tc_Creation"
			Me.tc_Creation.SelectedIndex = 0
			Me.tc_Creation.Size = New System.Drawing.Size(652, 277)
			Me.tc_Creation.TabIndex = 7
			'
			'tp_Basic
			'
			Me.tp_Basic.BackColor = System.Drawing.Color.LightGray
			Me.tp_Basic.Controls.Add(Me.gi_FirstName)
			Me.tp_Basic.Controls.Add(Me.gi_LastName)
			Me.tp_Basic.Controls.Add(Me.pn_PhoneNumber)
			Me.tp_Basic.Controls.Add(Me.gi_EmailAddress)
			Me.tp_Basic.Location = New System.Drawing.Point(4, 22)
			Me.tp_Basic.Name = "tp_Basic"
			Me.tp_Basic.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Basic.Size = New System.Drawing.Size(644, 251)
			Me.tp_Basic.TabIndex = 0
			Me.tp_Basic.Text = "Basics"
			'
			'gi_FirstName
			'
			Me.gi_FirstName.AutoSize = True
			Me.gi_FirstName.LabelText = "* First Name"
			Me.gi_FirstName.Location = New System.Drawing.Point(85, 61)
			Me.gi_FirstName.Mask = ""
			Me.gi_FirstName.Name = "gi_FirstName"
			Me.gi_FirstName.Size = New System.Drawing.Size(244, 62)
			Me.gi_FirstName.TabIndex = 1
			Me.gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.gi_FirstName.UseSystemPasswordChar = False
			'
			'gi_LastName
			'
			Me.gi_LastName.AutoSize = True
			Me.gi_LastName.LabelText = "* Last Name"
			Me.gi_LastName.Location = New System.Drawing.Point(346, 61)
			Me.gi_LastName.Mask = ""
			Me.gi_LastName.Name = "gi_LastName"
			Me.gi_LastName.Size = New System.Drawing.Size(244, 62)
			Me.gi_LastName.TabIndex = 2
			Me.gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.gi_LastName.UseSystemPasswordChar = False
			'
			'pn_PhoneNumber
			'
			Me.pn_PhoneNumber.AutoSize = True
			Me.pn_PhoneNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.pn_PhoneNumber.Location = New System.Drawing.Point(123, 129)
			Me.pn_PhoneNumber.Name = "pn_PhoneNumber"
			Me.pn_PhoneNumber.PhoneNumber = "(   )    -"
			Me.pn_PhoneNumber.Size = New System.Drawing.Size(107, 55)
			Me.pn_PhoneNumber.TabIndex = 3
			'
			'gi_EmailAddress
			'
			Me.gi_EmailAddress.AutoSize = True
			Me.gi_EmailAddress.LabelText = "Email Address"
			Me.gi_EmailAddress.Location = New System.Drawing.Point(267, 129)
			Me.gi_EmailAddress.Mask = ""
			Me.gi_EmailAddress.Name = "gi_EmailAddress"
			Me.gi_EmailAddress.Size = New System.Drawing.Size(258, 40)
			Me.gi_EmailAddress.TabIndex = 4
			Me.gi_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.gi_EmailAddress.UseSystemPasswordChar = False
			'
			'tp_Address
			'
			Me.tp_Address.Controls.Add(Me.af_Address)
			Me.tp_Address.Location = New System.Drawing.Point(4, 22)
			Me.tp_Address.Name = "tp_Address"
			Me.tp_Address.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Address.Size = New System.Drawing.Size(644, 251)
			Me.tp_Address.TabIndex = 1
			Me.tp_Address.Text = "Address"
			Me.tp_Address.UseVisualStyleBackColor = True
			'
			'af_Address
			'
			Me.af_Address.AutoSize = True
			Me.af_Address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.af_Address.BackColor = System.Drawing.Color.LightGray
			Me.af_Address.City = ""
			Me.af_Address.Dock = System.Windows.Forms.DockStyle.Fill
			Me.af_Address.Location = New System.Drawing.Point(3, 3)
			Me.af_Address.Name = "af_Address"
			Me.af_Address.Size = New System.Drawing.Size(638, 245)
			Me.af_Address.State = Nothing
			Me.af_Address.Street = ""
			Me.af_Address.TabIndex = 5
			Me.af_Address.ZipCode = ""
			'
			'db_Customers
			'
			Me.db_Customers.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
			Me.db_Customers.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
			Me.db_Customers.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
			'
			'AddCustomerDialog
			'
			Me.AcceptButton = Me.btn_Create
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(652, 337)
			Me.Controls.Add(Me.tc_Creation)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AddCustomerDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "New Customer"
			Me.TableLayoutPanel1.ResumeLayout(False)
			CType(Me.ep_InputError, System.ComponentModel.ISupportInitialize).EndInit()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.tc_Creation.ResumeLayout(False)
			Me.tp_Basic.ResumeLayout(False)
			Me.tp_Basic.PerformLayout()
			Me.tp_Address.ResumeLayout(False)
			Me.tp_Address.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents btn_Create As System.Windows.Forms.Button
		Friend WithEvents ep_InputError As Windows.Forms.ErrorProvider
		Friend WithEvents af_Address As AddressField
		Friend WithEvents db_Customers As Database.CustomerDatabase
		Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
		Friend WithEvents tss_Feedback As Windows.Forms.ToolStripStatusLabel
		Friend WithEvents tc_Creation As Windows.Forms.TabControl
		Friend WithEvents tp_Basic As Windows.Forms.TabPage
		Friend WithEvents gi_FirstName As GenericInputPair
		Friend WithEvents gi_LastName As GenericInputPair
		Friend WithEvents pn_PhoneNumber As PhoneNumberField
		Friend WithEvents gi_EmailAddress As GenericInputPair
		Friend WithEvents tp_Address As Windows.Forms.TabPage
	End Class
End Namespace