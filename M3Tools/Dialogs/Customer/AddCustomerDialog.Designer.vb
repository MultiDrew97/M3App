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
			Me.af_Address = New SPPBC.M3Tools.AddressField()
			Me.if_EmailAddress = New SPPBC.M3Tools.GenericInputPair()
			Me.pnf_PhoneNumber = New SPPBC.M3Tools.PhoneNumberField()
			Me.if_LastName = New SPPBC.M3Tools.GenericInputPair()
			Me.if_FirstName = New SPPBC.M3Tools.GenericInputPair()
			Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.ep_InputError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.StatusStrip1.SuspendLayout()
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
			Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
			Me.btn_Cancel.Name = "btn_Cancel"
			Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
			Me.btn_Cancel.TabIndex = 0
			Me.btn_Cancel.Text = "Cancel"
			'
			'btn_Create
			'
			Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Create.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btn_Create.Location = New System.Drawing.Point(76, 3)
			Me.btn_Create.Name = "btn_Create"
			Me.btn_Create.Size = New System.Drawing.Size(67, 23)
			Me.btn_Create.TabIndex = 1
			Me.btn_Create.Text = "Create"
			'
			'ep_InputError
			'
			Me.ep_InputError.ContainerControl = Me
			'
			'StatusStrip1
			'
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
			'af_Address
			'
			Me.af_Address.AutoSize = True
			Me.af_Address.City = ""
			Me.af_Address.Location = New System.Drawing.Point(26, 139)
			Me.af_Address.Name = "af_Address"
			Me.af_Address.Size = New System.Drawing.Size(611, 141)
			Me.af_Address.State = ""
			Me.af_Address.Street = ","
			Me.af_Address.TabIndex = 5
			Me.af_Address.ZipCode = ""
			'
			'if_EmailAddress
			'
			Me.if_EmailAddress.AutoSize = True
			Me.if_EmailAddress.LabelText = "* Email Address"
			Me.if_EmailAddress.Location = New System.Drawing.Point(344, 82)
			Me.if_EmailAddress.Mask = ""
			Me.if_EmailAddress.Name = "if_EmailAddress"
			Me.if_EmailAddress.Size = New System.Drawing.Size(258, 40)
			Me.if_EmailAddress.TabIndex = 4
			Me.if_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.if_EmailAddress.UseSystemPasswordChar = False
			'
			'pnf_PhoneNumber
			'
			Me.pnf_PhoneNumber.AutoSize = True
			Me.pnf_PhoneNumber.Location = New System.Drawing.Point(124, 78)
			Me.pnf_PhoneNumber.Name = "pnf_PhoneNumber"
			Me.pnf_PhoneNumber.PhoneNumber = "(   )    -"
			Me.pnf_PhoneNumber.Size = New System.Drawing.Size(107, 55)
			Me.pnf_PhoneNumber.TabIndex = 3
			'
			'if_LastName
			'
			Me.if_LastName.AutoSize = True
			Me.if_LastName.LabelText = "Last Name"
			Me.if_LastName.Location = New System.Drawing.Point(344, 14)
			Me.if_LastName.Mask = ""
			Me.if_LastName.Name = "if_LastName"
			Me.if_LastName.Size = New System.Drawing.Size(244, 62)
			Me.if_LastName.TabIndex = 2
			Me.if_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.if_LastName.UseSystemPasswordChar = False
			'
			'if_FirstName
			'
			Me.if_FirstName.AutoSize = True
			Me.if_FirstName.LabelText = "* First Name"
			Me.if_FirstName.Location = New System.Drawing.Point(28, 14)
			Me.if_FirstName.Mask = ""
			Me.if_FirstName.Name = "if_FirstName"
			Me.if_FirstName.Size = New System.Drawing.Size(244, 62)
			Me.if_FirstName.TabIndex = 1
			Me.if_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.if_FirstName.UseSystemPasswordChar = False
			'
			'db_Customers
			'
			Me.db_Customers.InitialCatalog = "Media Ministry"
			Me.db_Customers.Password = "M3AppPassword2499"
			Me.db_Customers.Username = "M3App"
			'
			'AddCustomerDialog
			'
			Me.AcceptButton = Me.btn_Create
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btn_Cancel
			Me.ClientSize = New System.Drawing.Size(652, 337)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Controls.Add(Me.af_Address)
			Me.Controls.Add(Me.if_EmailAddress)
			Me.Controls.Add(Me.pnf_PhoneNumber)
			Me.Controls.Add(Me.if_LastName)
			Me.Controls.Add(Me.if_FirstName)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AddCustomerDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "New Customer Info"
			Me.TableLayoutPanel1.ResumeLayout(False)
			CType(Me.ep_InputError, System.ComponentModel.ISupportInitialize).EndInit()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents btn_Create As System.Windows.Forms.Button
		Friend WithEvents if_FirstName As GenericInputPair
		Friend WithEvents if_LastName As GenericInputPair
		Friend WithEvents pnf_PhoneNumber As PhoneNumberField
		Friend WithEvents if_EmailAddress As GenericInputPair
		Friend WithEvents ep_InputError As Windows.Forms.ErrorProvider
		Friend WithEvents af_Address As AddressField
		Friend WithEvents db_Customers As Database.CustomerDatabase
		Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
		Friend WithEvents tss_Feedback As Windows.Forms.ToolStripStatusLabel
	End Class
End Namespace