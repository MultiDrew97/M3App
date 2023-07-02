Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class EditListenerDialog
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
            Me.btn_Save = New System.Windows.Forms.Button()
            Me.btn_Cancel = New System.Windows.Forms.Button()
            Me.gi_Email = New SPPBC.M3Tools.GenericInputPair()
            Me.gi_Name = New SPPBC.M3Tools.GenericInputPair()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Save, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(217, 162)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'btn_Save
            '
            Me.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Save.Location = New System.Drawing.Point(76, 3)
            Me.btn_Save.Name = "btn_Save"
            Me.btn_Save.Size = New System.Drawing.Size(67, 23)
            Me.btn_Save.TabIndex = 0
            Me.btn_Save.Text = "OK"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
            Me.btn_Cancel.TabIndex = 1
            Me.btn_Cancel.Text = "Cancel"
            '
            'gi_Email
            '
            Me.gi_Email.AutoSize = True
            Me.gi_Email.LabelText = "Email Address"
            Me.gi_Email.Location = New System.Drawing.Point(33, 100)
            Me.gi_Email.Mask = ""
            Me.gi_Email.Name = "gi_Email"
            Me.gi_Email.Placeholder = "Email"
            Me.gi_Email.Size = New System.Drawing.Size(308, 46)
            Me.gi_Email.TabIndex = 2
            Me.gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'gi_Name
            '
            Me.gi_Name.AutoSize = True
            Me.gi_Name.LabelText = "Name"
            Me.gi_Name.Location = New System.Drawing.Point(33, 39)
            Me.gi_Name.Mask = ""
            Me.gi_Name.Name = "gi_Name"
            Me.gi_Name.Placeholder = "Name"
            Me.gi_Name.Size = New System.Drawing.Size(308, 46)
            Me.gi_Name.TabIndex = 1
            Me.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'EditListenerDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(375, 203)
            Me.Controls.Add(Me.gi_Email)
            Me.Controls.Add(Me.gi_Name)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditListenerDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "EditListenerDialog"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Save As System.Windows.Forms.Button
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents gi_Name As GenericInputPair
		Friend WithEvents gi_Email As GenericInputPair
	End Class
End Namespace