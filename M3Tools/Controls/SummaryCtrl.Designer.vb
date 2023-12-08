<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryCtrl
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.pg_Summary = New System.Windows.Forms.PropertyGrid()
        Me.SuspendLayout()
        '
        'pg_Summary
        '
        Me.pg_Summary.CanShowVisualStyleGlyphs = False
        Me.pg_Summary.CommandsVisibleIfAvailable = False
        Me.pg_Summary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg_Summary.Enabled = False
        Me.pg_Summary.HelpVisible = False
        Me.pg_Summary.Location = New System.Drawing.Point(0, 0)
        Me.pg_Summary.Name = "pg_Summary"
        Me.pg_Summary.Size = New System.Drawing.Size(150, 150)
        Me.pg_Summary.TabIndex = 1
        Me.pg_Summary.ToolbarVisible = False
        '
        'SummaryCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pg_Summary)
        Me.Name = "SummaryCtrl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pg_Summary As Windows.Forms.PropertyGrid
End Class
