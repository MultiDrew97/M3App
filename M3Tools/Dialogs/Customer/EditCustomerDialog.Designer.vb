Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class EditCustomerDialog
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
            Me.OK_Button = New System.Windows.Forms.Button()
            Me.Cancel_Button = New System.Windows.Forms.Button()
            Me.af_Address = New SPPBC.M3Tools.AddressField()
            Me.gi_Email = New SPPBC.M3Tools.GenericInputPair()
            Me.PhoneNumberField1 = New SPPBC.M3Tools.PhoneNumberField()
            Me.gi_LastName = New SPPBC.M3Tools.GenericInputPair()
            Me.gi_FirstName = New SPPBC.M3Tools.GenericInputPair()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(387, 274)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 5
            '
            'OK_Button
            '
            Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.OK_Button.Location = New System.Drawing.Point(76, 3)
            Me.OK_Button.Name = "OK_Button"
            Me.OK_Button.Size = New System.Drawing.Size(67, 23)
            Me.OK_Button.TabIndex = 1
            Me.OK_Button.Text = "OK"
            '
            'Cancel_Button
            '
            Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
            Me.Cancel_Button.Name = "Cancel_Button"
            Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
            Me.Cancel_Button.TabIndex = 0
            Me.Cancel_Button.Text = "Cancel"
            '
            'af_Address
            '
            Me.af_Address.Address = Nothing
            Me.af_Address.AutoSize = True
            Me.af_Address.City = ""
            Me.af_Address.Location = New System.Drawing.Point(12, 138)
            Me.af_Address.MinimumSize = New System.Drawing.Size(500, 100)
            Me.af_Address.Name = "af_Address"
            Me.af_Address.Size = New System.Drawing.Size(518, 100)
            Me.af_Address.State = ""
            Me.af_Address.Street = ""
            Me.af_Address.TabIndex = 4
            Me.af_Address.ZipCode = ""
            '
            'gi_Email
            '
            Me.gi_Email.AutoSize = True
            Me.gi_Email.Label = "Email"
            Me.gi_Email.Location = New System.Drawing.Point(257, 64)
            Me.gi_Email.Mask = ""
            Me.gi_Email.Name = "gi_Email"
            Me.gi_Email.Placeholder = Nothing
            Me.gi_Email.Size = New System.Drawing.Size(273, 46)
            Me.gi_Email.TabIndex = 3
            Me.gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'PhoneNumberField1
            '
            Me.PhoneNumberField1.AutoSize = True
            Me.PhoneNumberField1.Location = New System.Drawing.Point(12, 64)
            Me.PhoneNumberField1.MaximumSize = New System.Drawing.Size(0, 50)
            Me.PhoneNumberField1.MinimumSize = New System.Drawing.Size(100, 50)
            Me.PhoneNumberField1.Name = "PhoneNumberField1"
            Me.PhoneNumberField1.Size = New System.Drawing.Size(100, 50)
            Me.PhoneNumberField1.TabIndex = 2
            '
            'gi_LastName
            '
            Me.gi_LastName.AutoSize = True
            Me.gi_LastName.Label = "Last Name"
            Me.gi_LastName.Location = New System.Drawing.Point(257, 12)
            Me.gi_LastName.Mask = ""
            Me.gi_LastName.Name = "gi_LastName"
            Me.gi_LastName.Placeholder = Nothing
            Me.gi_LastName.Size = New System.Drawing.Size(276, 46)
            Me.gi_LastName.TabIndex = 1
            Me.gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'gi_FirstName
            '
            Me.gi_FirstName.AutoSize = True
            Me.gi_FirstName.Label = "First Name"
            Me.gi_FirstName.Location = New System.Drawing.Point(12, 12)
            Me.gi_FirstName.Mask = ""
            Me.gi_FirstName.Name = "gi_FirstName"
            Me.gi_FirstName.Placeholder = Nothing
            Me.gi_FirstName.Size = New System.Drawing.Size(229, 46)
            Me.gi_FirstName.TabIndex = 0
            Me.gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'EditCustomerDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(545, 315)
            Me.Controls.Add(Me.af_Address)
            Me.Controls.Add(Me.gi_Email)
            Me.Controls.Add(Me.PhoneNumberField1)
            Me.Controls.Add(Me.gi_LastName)
            Me.Controls.Add(Me.gi_FirstName)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditCustomerDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Edit {0}"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents OK_Button As System.Windows.Forms.Button
		Friend WithEvents Cancel_Button As System.Windows.Forms.Button
        Friend WithEvents gi_FirstName As GenericInputPair
        Friend WithEvents gi_LastName As GenericInputPair
		Friend WithEvents PhoneNumberField1 As PhoneNumberField
		Friend WithEvents gi_Email As GenericInputPair
		Friend WithEvents af_Address As AddressField
	End Class
End Namespace