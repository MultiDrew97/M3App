Partial Class ToolsToolStrip
	Inherits System.Windows.Forms.ToolStrip

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New(ByVal container As System.ComponentModel.IContainer)
		MyClass.New()

		'Required for Windows.Forms Class Composition Designer support
		If (container IsNot Nothing) Then
			container.Add(Me)
		End If

	End Sub

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()

	End Sub

	'Component overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Component Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Component Designer
	'It can be modified using the Component Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.tsb_New = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Import = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.tsb_Emails = New System.Windows.Forms.ToolStripButton()
        Me.tsl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuspendLayout()
        '
        'tsb_New
        '
        Me.tsb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_New.Image = Global.SPPBC.M3Tools.My.Resources.Resources.NewDocumentOption
        Me.tsb_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_New.Name = "tsb_New"
        Me.tsb_New.Size = New System.Drawing.Size(23, 22)
        Me.tsb_New.Text = "New"
        Me.tsb_New.ToolTipText = "Add {0}"
        '
        'tsb_Import
        '
        Me.tsb_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Import.Image = Global.SPPBC.M3Tools.My.Resources.Resources.import
        Me.tsb_Import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Import.Name = "tsb_Import"
        Me.tsb_Import.Size = New System.Drawing.Size(23, 22)
        Me.tsb_Import.Text = "Import"
        Me.tsb_Import.ToolTipText = "Import {0}"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tst_Filter
        '
        Me.tst_Filter.Name = "tst_Filter"
        Me.tst_Filter.Size = New System.Drawing.Size(100, 23)
        Me.tst_Filter.ToolTipText = "Filter {0}"
        '
        'tsb_Emails
        '
        Me.tsb_Emails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Emails.Image = Global.SPPBC.M3Tools.My.Resources.Resources.send_email
        Me.tsb_Emails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Emails.Name = "tsb_Emails"
        Me.tsb_Emails.Size = New System.Drawing.Size(23, 22)
        Me.tsb_Emails.Text = "Send Emails"
        '
        'tsl_Count
        '
        Me.tsl_Count.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsl_Count.Name = "tsl_Count"
        Me.tsl_Count.Size = New System.Drawing.Size(0, 0)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ToolsToolStrip
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_New, Me.tsb_Import, Me.tsb_Emails, Me.ToolStripSeparator1, Me.tst_Filter, Me.ToolStripSeparator2, Me.tsl_Count})
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tsb_New As Windows.Forms.ToolStripButton
	Friend WithEvents tsb_Import As Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
	Friend WithEvents tst_Filter As Windows.Forms.ToolStripTextBox
	Friend WithEvents tsb_Emails As Windows.Forms.ToolStripButton
	Friend WithEvents tsl_Count As Windows.Forms.ToolStripLabel
	Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
End Class
