Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CreateAccountDialog
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
            Me.cpf_Confirm = New M3Tools.ConfirmPasswordField()
            Me.pf_Password = New M3Tools.PasswordField()
            Me.uf_Username = New M3Tools.UsernameField()
            Me.db_Users = New M3Tools.Database.UserDatabase(Me.components)
            Me.ep_FieldError = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.ep_FieldError, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(261, 274)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 3
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
            'cpf_Confirm
            '
            Me.cpf_Confirm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cpf_Confirm.AutoSize = True
            Me.cpf_Confirm.BackColor = System.Drawing.SystemColors.Control
            Me.cpf_Confirm.Location = New System.Drawing.Point(60, 165)
            Me.cpf_Confirm.Name = "cpf_Confirm"
            Me.cpf_Confirm.Size = New System.Drawing.Size(288, 72)
            Me.cpf_Confirm.TabIndex = 2
            '
            'pf_Password
            '
            Me.pf_Password.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pf_Password.AutoSize = True
            Me.pf_Password.BackColor = System.Drawing.SystemColors.Control
            Me.pf_Password.Location = New System.Drawing.Point(60, 87)
            Me.pf_Password.Name = "pf_Password"
            Me.pf_Password.Size = New System.Drawing.Size(288, 72)
            Me.pf_Password.TabIndex = 1
            '
            'uf_Username
            '
            Me.uf_Username.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.uf_Username.AutoSize = True
            Me.uf_Username.BackColor = System.Drawing.SystemColors.Control
            Me.uf_Username.Location = New System.Drawing.Point(60, 17)
            Me.uf_Username.Name = "uf_Username"
            Me.uf_Username.Size = New System.Drawing.Size(288, 52)
            Me.uf_Username.TabIndex = 0
            '
            'ep_FieldError
            '
            Me.ep_FieldError.ContainerControl = Me
            '
            'CreateAccountDialog
            '
            Me.AcceptButton = Me.btn_Create
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btn_Cancel
            Me.ClientSize = New System.Drawing.Size(419, 315)
            Me.Controls.Add(Me.cpf_Confirm)
            Me.Controls.Add(Me.pf_Password)
            Me.Controls.Add(Me.uf_Username)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "CreateAccountDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Create Account"
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.ep_FieldError, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btn_Cancel As System.Windows.Forms.Button
        Friend WithEvents btn_Create As System.Windows.Forms.Button
        Friend WithEvents uf_Username As UsernameField
        Friend WithEvents pf_Password As PasswordField
        Friend WithEvents cpf_Confirm As ConfirmPasswordField
        Friend WithEvents db_Users As Database.UserDatabase
        Friend WithEvents ep_FieldError As Windows.Forms.ErrorProvider
    End Class
End Namespace