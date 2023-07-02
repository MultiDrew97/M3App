<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReciepientSelectionDialog
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
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.ldg_Listeners = New SPPBC.M3Tools.ListenersDataGrid()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Select, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(366, 368)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Select
        '
        Me.btn_Select.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Select.Location = New System.Drawing.Point(76, 3)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(67, 23)
        Me.btn_Select.TabIndex = 0
        Me.btn_Select.Text = "Select"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'ldg_Listeners
        '
        Me.ldg_Listeners.AllowColumnReordering = True
        Me.ldg_Listeners.AllowDeleting = False
        Me.ldg_Listeners.AllowEditting = False
        Me.ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Top
        Me.ldg_Listeners.Filter = Nothing
        Me.ldg_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.ldg_Listeners.MinimumSize = New System.Drawing.Size(400, 200)
        Me.ldg_Listeners.Name = "ldg_Listeners"
        Me.ldg_Listeners.Size = New System.Drawing.Size(524, 362)
        Me.ldg_Listeners.TabIndex = 1
        '
        'ReciepientSelectionDialog
        '
        Me.AcceptButton = Me.btn_Select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(524, 409)
        Me.Controls.Add(Me.ldg_Listeners)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReciepientSelectionDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Which Listener(s)?"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btn_Select As System.Windows.Forms.Button
	Friend WithEvents btn_Cancel As System.Windows.Forms.Button
	Friend WithEvents ldg_Listeners As ListenersDataGrid
End Class
