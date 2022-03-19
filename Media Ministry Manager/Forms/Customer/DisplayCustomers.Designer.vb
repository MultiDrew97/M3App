<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DisplayCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DisplayCustomers))
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.db_Customers = New SPPBC.M3Tools.Database.CustomerDatabase(Me.components)
        Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
        Me.dc_Customers = New SPPBC.M3Tools.DisplayCustomers()
        Me.ss_CustomerView.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss_CustomerView
        '
        Me.ss_CustomerView.BackColor = System.Drawing.SystemColors.Control
        Me.ss_CustomerView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_CustomerView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_CustomersView})
        Me.ss_CustomerView.Location = New System.Drawing.Point(0, 518)
        Me.ss_CustomerView.Name = "ss_CustomerView"
        Me.ss_CustomerView.Size = New System.Drawing.Size(888, 22)
        Me.ss_CustomerView.TabIndex = 3
        '
        'tss_CustomersView
        '
        Me.tss_CustomersView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss_CustomersView.Name = "tss_CustomersView"
        Me.tss_CustomersView.Size = New System.Drawing.Size(170, 17)
        Me.tss_CustomersView.Text = "Here are the current customers"
        '
        'db_Customers
        '
        Me.db_Customers.InitialCatalog = Global.MediaMinistry.MySettings.Default.DefaultCatalog
        Me.db_Customers.Password = Global.MediaMinistry.MySettings.Default.DefaultPassword
        Me.db_Customers.Username = Global.MediaMinistry.MySettings.Default.DefaultUsername
        '
        'mms_Main
        '
        Me.mms_Main.Location = New System.Drawing.Point(0, 0)
        Me.mms_Main.Name = "mms_Main"
        Me.mms_Main.Size = New System.Drawing.Size(888, 24)
        Me.mms_Main.TabIndex = 6
        Me.mms_Main.Text = "MainMenuStrip1"
        '
        'dc_Customers
        '
        Me.dc_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dc_Customers.Location = New System.Drawing.Point(0, 24)
        Me.dc_Customers.Name = "dc_Customers"
        Me.dc_Customers.Size = New System.Drawing.Size(888, 494)
        Me.dc_Customers.TabIndex = 7
        '
        'Frm_DisplayCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(888, 540)
        Me.Controls.Add(Me.dc_Customers)
        Me.Controls.Add(Me.ss_CustomerView)
        Me.Controls.Add(Me.mms_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mms_Main
        Me.MaximizeBox = False
        Me.Name = "Frm_DisplayCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_CustomerView.ResumeLayout(False)
        Me.ss_CustomerView.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ss_CustomerView As StatusStrip
	Friend WithEvents tss_CustomersView As ToolStripStatusLabel
    Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
	Friend WithEvents Last_Name As DataGridViewTextBoxColumn
	Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
	Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
	Friend WithEvents JoinDate As DataGridViewTextBoxColumn
    Friend WithEvents db_Customers As SPPBC.M3Tools.Database.CustomerDatabase
    Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
    Friend WithEvents dc_Customers As SPPBC.M3Tools.DisplayCustomers
End Class
