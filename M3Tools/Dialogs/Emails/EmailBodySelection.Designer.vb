Imports System.Windows.Forms
Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class EmailBodySelection
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
            Me.OK_Button = New System.Windows.Forms.Button()
            Me.Cancel_Button = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tp_Templates = New System.Windows.Forms.TabPage()
            Me.ts_Templates = New SPPBC.M3Tools.TemplateSelector()
            Me.bsTemplates = New System.Windows.Forms.BindingSource(Me.components)
            Me.tp_Custom = New System.Windows.Forms.TabPage()
            Me.CustomEmail1 = New SPPBC.M3Tools.CustomEmail()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tp_Templates.SuspendLayout()
            CType(Me.bsTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tp_Custom.SuspendLayout()
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
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(175, 267)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'OK_Button
            '
            Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.OK_Button.Location = New System.Drawing.Point(76, 3)
            Me.OK_Button.Name = "OK_Button"
            Me.OK_Button.Size = New System.Drawing.Size(67, 23)
            Me.OK_Button.TabIndex = 0
            Me.OK_Button.Text = "OK"
            '
            'Cancel_Button
            '
            Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
            Me.Cancel_Button.Name = "Cancel_Button"
            Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
            Me.Cancel_Button.TabIndex = 1
            Me.Cancel_Button.Text = "Cancel"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tp_Templates)
            Me.TabControl1.Controls.Add(Me.tp_Custom)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(333, 261)
            Me.TabControl1.TabIndex = 1
            '
            'tp_Templates
            '
            Me.tp_Templates.Controls.Add(Me.ts_Templates)
            Me.tp_Templates.Location = New System.Drawing.Point(4, 22)
            Me.tp_Templates.Name = "tp_Templates"
            Me.tp_Templates.Size = New System.Drawing.Size(325, 235)
            Me.tp_Templates.TabIndex = 2
            Me.tp_Templates.Text = "Templates"
            Me.tp_Templates.UseVisualStyleBackColor = True
			'
			'ts_Templates
			'
			Me.ts_Templates.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ts_Templates.Location = New System.Drawing.Point(0, 0)
            Me.ts_Templates.MinimumSize = New System.Drawing.Size(200, 200)
            Me.ts_Templates.Name = "ts_Templates"
            Me.ts_Templates.Padding = New System.Windows.Forms.Padding(5)
            Me.ts_Templates.Size = New System.Drawing.Size(325, 235)
            Me.ts_Templates.TabIndex = 0
            '
            'bsTemplates
            '
            Me.bsTemplates.DataSource = GetType(SPPBC.M3Tools.Types.TemplateList)
            '
            'tp_Custom
            '
            Me.tp_Custom.Controls.Add(Me.CustomEmail1)
            Me.tp_Custom.Location = New System.Drawing.Point(4, 22)
            Me.tp_Custom.Name = "tp_Custom"
            Me.tp_Custom.Padding = New System.Windows.Forms.Padding(3)
            Me.tp_Custom.Size = New System.Drawing.Size(325, 235)
            Me.tp_Custom.TabIndex = 1
            Me.tp_Custom.Text = "Custom Email"
            Me.tp_Custom.UseVisualStyleBackColor = True
            '
            'CustomEmail1
            '
            Me.CustomEmail1.AutoSize = True
            Me.CustomEmail1.Body = "Email Body..."
            Me.CustomEmail1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CustomEmail1.Location = New System.Drawing.Point(3, 3)
            Me.CustomEmail1.Margin = New System.Windows.Forms.Padding(0)
            Me.CustomEmail1.MaximumSize = New System.Drawing.Size(400, 300)
            Me.CustomEmail1.MinimumSize = New System.Drawing.Size(200, 200)
            Me.CustomEmail1.Name = "CustomEmail1"
            Me.CustomEmail1.Size = New System.Drawing.Size(319, 229)
            Me.CustomEmail1.Subject = "Subject..."
            Me.CustomEmail1.TabIndex = 0
            '
            'EmailBodySelection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(333, 308)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EmailBodySelection"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Email Body"
            Me.TopMost = True
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tp_Templates.ResumeLayout(False)
            CType(Me.bsTemplates, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tp_Custom.ResumeLayout(False)
            Me.tp_Custom.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents OK_Button As System.Windows.Forms.Button
		Friend WithEvents Cancel_Button As System.Windows.Forms.Button
		Friend WithEvents TabControl1 As TabControl
		Friend WithEvents bsTemplates As BindingSource
		Friend WithEvents tp_Custom As TabPage
		Friend WithEvents tp_Templates As TabPage
		Friend WithEvents ts_Templates As SPPBC.M3Tools.TemplateSelector
		Friend WithEvents CustomEmail1 As SPPBC.M3Tools.CustomEmail
	End Class
End Namespace