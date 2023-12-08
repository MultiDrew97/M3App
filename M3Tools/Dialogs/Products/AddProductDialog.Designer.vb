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
            Me.btn_Next = New System.Windows.Forms.Button()
            Me.btn_Cancel = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tp_Basics = New System.Windows.Forms.TabPage()
            Me.tp_Description = New System.Windows.Forms.TabPage()
            Me.tp_Summary = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Next, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'btn_Next
            '
            Me.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_Next.Location = New System.Drawing.Point(76, 3)
            Me.btn_Next.Name = "btn_Next"
            Me.btn_Next.Size = New System.Drawing.Size(67, 23)
            Me.btn_Next.TabIndex = 0
            Me.btn_Next.Text = "Next"
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
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tp_Basics)
            Me.TabControl1.Controls.Add(Me.tp_Description)
            Me.TabControl1.Controls.Add(Me.tp_Summary)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(435, 268)
            Me.TabControl1.TabIndex = 1
            '
            'tp_Basics
            '
            Me.tp_Basics.Location = New System.Drawing.Point(4, 22)
            Me.tp_Basics.Name = "tp_Basics"
            Me.tp_Basics.Padding = New System.Windows.Forms.Padding(3)
            Me.tp_Basics.Size = New System.Drawing.Size(427, 242)
            Me.tp_Basics.TabIndex = 0
            Me.tp_Basics.Text = "Basics"
            Me.tp_Basics.UseVisualStyleBackColor = True
            '
            'tp_Description
            '
            Me.tp_Description.Location = New System.Drawing.Point(4, 22)
            Me.tp_Description.Name = "tp_Description"
            Me.tp_Description.Padding = New System.Windows.Forms.Padding(3)
            Me.tp_Description.Size = New System.Drawing.Size(427, 242)
            Me.tp_Description.TabIndex = 1
            Me.tp_Description.Text = "Product Description"
            Me.tp_Description.UseVisualStyleBackColor = True
            '
            'tp_Summary
            '
            Me.tp_Summary.Location = New System.Drawing.Point(4, 22)
            Me.tp_Summary.Name = "tp_Summary"
            Me.tp_Summary.Padding = New System.Windows.Forms.Padding(3)
            Me.tp_Summary.Size = New System.Drawing.Size(427, 242)
            Me.tp_Summary.TabIndex = 2
            Me.tp_Summary.Text = "Summary"
            Me.tp_Summary.UseVisualStyleBackColor = True
            '
            'AddProductDialog
            '
            Me.AcceptButton = Me.btn_Next
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btn_Cancel
            Me.ClientSize = New System.Drawing.Size(435, 315)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AddProductDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "New Product"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Next As System.Windows.Forms.Button
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
        Friend WithEvents TabControl1 As Windows.Forms.TabControl
        Friend WithEvents tp_Basics As Windows.Forms.TabPage
        Friend WithEvents tp_Description As Windows.Forms.TabPage
        Friend WithEvents tp_Summary As Windows.Forms.TabPage
    End Class
End Namespace