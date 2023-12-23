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
			Me.tp_Basics = New System.Windows.Forms.TabPage()
			Me.tp_Address = New System.Windows.Forms.TabPage()
			Me.tp_Summary = New System.Windows.Forms.TabPage()
			Me.gi_FirstName = New SPPBC.M3Tools.GenericInputPair()
			Me.gi_LastName = New SPPBC.M3Tools.GenericInputPair()
			Me.pn_PhoneNumber = New SPPBC.M3Tools.PhoneNumberField()
			Me.gi_EmailAddress = New SPPBC.M3Tools.GenericInputPair()
			Me.af_Address = New SPPBC.M3Tools.AddressField()
			Me.sc_Summary = New SPPBC.M3Tools.SummaryCtrl()
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.ep_InputError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.StatusStrip1.SuspendLayout()
			Me.tc_Creation.SuspendLayout()
			Me.tp_Basics.SuspendLayout()
			Me.tp_Address.SuspendLayout()
			Me.tp_Summary.SuspendLayout()
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
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(291, 310)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
			Me.TableLayoutPanel1.TabIndex = 0
			'
			'btn_Cancel
			'
			Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Cancel.Location = New System.Drawing.Point(6, 6)
			Me.btn_Cancel.Name = "btn_Cancel"
			Me.btn_Cancel.Size = New System.Drawing.Size(134, 44)
			Me.btn_Cancel.TabIndex = 0
			Me.btn_Cancel.Text = "Cancel"
			'
			'btn_Create
			'
			Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Create.Location = New System.Drawing.Point(152, 6)
			Me.btn_Create.Name = "btn_Create"
			Me.btn_Create.Size = New System.Drawing.Size(134, 44)
			Me.btn_Create.TabIndex = 1
			Me.btn_Create.Text = "Next"
			'
			'ep_InputError
			'
			Me.ep_InputError.ContainerControl = Me
			'
			'StatusStrip1
			'
			Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
			Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.Size = New System.Drawing.Size(595, 22)
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
			Me.tc_Creation.Controls.Add(Me.tp_Basics)
			Me.tc_Creation.Controls.Add(Me.tp_Address)
			Me.tc_Creation.Controls.Add(Me.tp_Summary)
			Me.tc_Creation.Dock = System.Windows.Forms.DockStyle.Top
			Me.tc_Creation.Location = New System.Drawing.Point(0, 0)
			Me.tc_Creation.Multiline = True
			Me.tc_Creation.Name = "tc_Creation"
			Me.tc_Creation.SelectedIndex = 0
			Me.tc_Creation.Size = New System.Drawing.Size(595, 304)
			Me.tc_Creation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
			Me.tc_Creation.TabIndex = 7
			'
			'tp_Basic
			'
			Me.tp_Basics.BackColor = System.Drawing.Color.LightGray
			Me.tp_Basics.Controls.Add(Me.gi_FirstName)
			Me.tp_Basics.Controls.Add(Me.gi_LastName)
			Me.tp_Basics.Controls.Add(Me.pn_PhoneNumber)
			Me.tp_Basics.Controls.Add(Me.gi_EmailAddress)
			Me.tp_Basics.Location = New System.Drawing.Point(4, 22)
			Me.tp_Basics.Name = "tp_Basic"
			Me.tp_Basics.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Basics.Size = New System.Drawing.Size(587, 278)
			Me.tp_Basics.TabIndex = 0
			Me.tp_Basics.Text = "Basics"
			'
			'tp_Address
			'
			Me.tp_Address.Controls.Add(Me.af_Address)
			Me.tp_Address.Location = New System.Drawing.Point(4, 22)
			Me.tp_Address.Name = "tp_Address"
			Me.tp_Address.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Address.Size = New System.Drawing.Size(587, 278)
			Me.tp_Address.TabIndex = 1
			Me.tp_Address.Text = "Address"
			Me.tp_Address.UseVisualStyleBackColor = True
			'
			'tp_Summary
			'
			Me.tp_Summary.Controls.Add(Me.sc_Summary)
			Me.tp_Summary.Location = New System.Drawing.Point(4, 22)
			Me.tp_Summary.Name = "tp_Summary"
			Me.tp_Summary.Padding = New System.Windows.Forms.Padding(3)
			Me.tp_Summary.Size = New System.Drawing.Size(587, 278)
			Me.tp_Summary.TabIndex = 2
			Me.tp_Summary.Text = "Summary"
			Me.tp_Summary.UseVisualStyleBackColor = True
			'
			'gi_FirstName
			'
			Me.gi_FirstName.AutoSize = True
			Me.gi_FirstName.Label = "* First Name"
			Me.gi_FirstName.Location = New System.Drawing.Point(43, 79)
			Me.gi_FirstName.Margin = New System.Windows.Forms.Padding(6)
			Me.gi_FirstName.Mask = ""
			Me.gi_FirstName.Name = "gi_FirstName"
			Me.gi_FirstName.Placeholder = Nothing
			Me.gi_FirstName.Size = New System.Drawing.Size(244, 62)
			Me.gi_FirstName.TabIndex = 1
			Me.gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'gi_LastName
			'
			Me.gi_LastName.AutoSize = True
			Me.gi_LastName.Label = "* Last Name"
			Me.gi_LastName.Location = New System.Drawing.Point(299, 79)
			Me.gi_LastName.Margin = New System.Windows.Forms.Padding(6)
			Me.gi_LastName.Mask = ""
			Me.gi_LastName.Name = "gi_LastName"
			Me.gi_LastName.Placeholder = Nothing
			Me.gi_LastName.Size = New System.Drawing.Size(244, 62)
			Me.gi_LastName.TabIndex = 2
			Me.gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'pn_PhoneNumber
			'
			Me.pn_PhoneNumber.AutoSize = True
			Me.pn_PhoneNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.pn_PhoneNumber.Location = New System.Drawing.Point(43, 153)
			Me.pn_PhoneNumber.Margin = New System.Windows.Forms.Padding(6)
			Me.pn_PhoneNumber.MaximumSize = New System.Drawing.Size(0, 50)
			Me.pn_PhoneNumber.MinimumSize = New System.Drawing.Size(100, 50)
			Me.pn_PhoneNumber.Name = "pn_PhoneNumber"
			Me.pn_PhoneNumber.Size = New System.Drawing.Size(100, 50)
			Me.pn_PhoneNumber.TabIndex = 3
			'
			'gi_EmailAddress
			'
			Me.gi_EmailAddress.AutoSize = True
			Me.gi_EmailAddress.Label = "Email Address"
			Me.gi_EmailAddress.Location = New System.Drawing.Point(285, 153)
			Me.gi_EmailAddress.Margin = New System.Windows.Forms.Padding(6)
			Me.gi_EmailAddress.Mask = ""
			Me.gi_EmailAddress.Name = "gi_EmailAddress"
			Me.gi_EmailAddress.Placeholder = Nothing
			Me.gi_EmailAddress.Size = New System.Drawing.Size(258, 40)
			Me.gi_EmailAddress.TabIndex = 4
			Me.gi_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'af_Address
			'
			Me.af_Address.Address = Nothing
			Me.af_Address.AutoSize = True
			Me.af_Address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.af_Address.BackColor = System.Drawing.Color.LightGray
			Me.af_Address.City = ""
			Me.af_Address.Dock = System.Windows.Forms.DockStyle.Fill
			Me.af_Address.Location = New System.Drawing.Point(3, 3)
			Me.af_Address.Margin = New System.Windows.Forms.Padding(6)
			Me.af_Address.MinimumSize = New System.Drawing.Size(500, 100)
			Me.af_Address.Name = "af_Address"
			Me.af_Address.Size = New System.Drawing.Size(581, 272)
			Me.af_Address.State = ""
			Me.af_Address.Street = ""
			Me.af_Address.TabIndex = 5
			Me.af_Address.ZipCode = ""
			'
			'sc_Summary
			'
			Me.sc_Summary.Display = Nothing
			Me.sc_Summary.Dock = System.Windows.Forms.DockStyle.Fill
			Me.sc_Summary.Location = New System.Drawing.Point(3, 3)
			Me.sc_Summary.Name = "sc_Summary"
			Me.sc_Summary.Size = New System.Drawing.Size(581, 272)
			Me.sc_Summary.TabIndex = 0
			'
			'AddCustomerDialog
			'
			Me.AcceptButton = Me.btn_Create
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(595, 404)
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
			Me.tp_Basics.ResumeLayout(False)
			Me.tp_Basics.PerformLayout()
			Me.tp_Address.ResumeLayout(False)
			Me.tp_Address.PerformLayout()
			Me.tp_Summary.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btn_Cancel As System.Windows.Forms.Button
        Friend WithEvents btn_Create As System.Windows.Forms.Button
        Friend WithEvents ep_InputError As Windows.Forms.ErrorProvider
        Friend WithEvents af_Address As AddressField
        Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
        Friend WithEvents tss_Feedback As Windows.Forms.ToolStripStatusLabel
        Friend WithEvents tc_Creation As Windows.Forms.TabControl
        Friend WithEvents tp_Basics As Windows.Forms.TabPage
        Friend WithEvents gi_FirstName As GenericInputPair
        Friend WithEvents gi_LastName As GenericInputPair
        Friend WithEvents pn_PhoneNumber As PhoneNumberField
        Friend WithEvents gi_EmailAddress As GenericInputPair
        Friend WithEvents tp_Address As Windows.Forms.TabPage
        Friend WithEvents tp_Summary As Windows.Forms.TabPage
		Friend WithEvents sc_Summary As SummaryCtrl
	End Class
End Namespace
