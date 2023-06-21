Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class AddListenerDialog
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
            Me.btn_Create = New System.Windows.Forms.Button()
            Me.btn_Cancel = New System.Windows.Forms.Button()
            Me.gi_Name = New SPPBC.M3Tools.GenericInputPair()
            Me.gi_Email = New SPPBC.M3Tools.GenericInputPair()
            Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Create, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 1, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(174, 149)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'btn_Create
            '
            Me.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Create.Location = New System.Drawing.Point(3, 3)
            Me.btn_Create.Name = "btn_Create"
            Me.btn_Create.Size = New System.Drawing.Size(67, 23)
            Me.btn_Create.TabIndex = 0
            Me.btn_Create.Text = "OK"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btn_Cancel.Location = New System.Drawing.Point(76, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
            Me.btn_Cancel.TabIndex = 1
            Me.btn_Cancel.Text = "Cancel"
            '
            'gi_Name
            '
            Me.gi_Name.AutoSize = True
            Me.gi_Name.LabelText = "Name"
            Me.gi_Name.Location = New System.Drawing.Point(12, 35)
            Me.gi_Name.Mask = ""
            Me.gi_Name.Name = "gi_Name"
            Me.gi_Name.Placeholder = "John Doe"
            Me.gi_Name.Size = New System.Drawing.Size(308, 46)
            Me.gi_Name.TabIndex = 1
            Me.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'gi_Email
            '
            Me.gi_Email.AutoSize = True
            Me.gi_Email.LabelText = "Email Address"
            Me.gi_Email.Location = New System.Drawing.Point(12, 87)
            Me.gi_Email.Mask = ""
            Me.gi_Email.Name = "gi_Email"
            Me.gi_Email.Placeholder = "johndoe@domain.ext"
            Me.gi_Email.Size = New System.Drawing.Size(308, 46)
            Me.gi_Email.TabIndex = 2
            Me.gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            '
            'db_Listeners
            '
            Me.db_Listeners.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
            Me.db_Listeners.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
            Me.db_Listeners.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
            '
            'AddListenerDialog
            '
            Me.AcceptButton = Me.btn_Create
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btn_Cancel
            Me.ClientSize = New System.Drawing.Size(332, 190)
            Me.Controls.Add(Me.gi_Email)
            Me.Controls.Add(Me.gi_Name)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AddListenerDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "AddListenerDialog"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Create As System.Windows.Forms.Button
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents gi_Name As GenericInputPair
		Friend WithEvents gi_Email As GenericInputPair
		Friend WithEvents db_Listeners As Database.ListenerDatabase
	End Class
End Namespace