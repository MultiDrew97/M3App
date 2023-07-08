<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolsContextMenu
	Inherits System.Windows.Forms.ContextMenuStrip

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
        Me.ts_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Send = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendLayout()
        '
        'ts_Refresh
        '
        Me.ts_Refresh.Name = "ts_Refresh"
        Me.ts_Refresh.Size = New System.Drawing.Size(132, 22)
        Me.ts_Refresh.Text = "Refresh"
        '
        'ts_Remove
        '
        Me.ts_Remove.Enabled = False
        Me.ts_Remove.Name = "ts_Remove"
        Me.ts_Remove.Size = New System.Drawing.Size(132, 22)
        Me.ts_Remove.Text = "Remove"
        '
        'ts_Send
        '
        Me.ts_Send.Name = "ts_Send"
        Me.ts_Send.Size = New System.Drawing.Size(132, 22)
        Me.ts_Send.Text = "Send Email"
        Me.ts_Send.Visible = False
        '
        'ts_Edit
        '
        Me.ts_Edit.Enabled = False
        Me.ts_Edit.Name = "ts_Edit"
        Me.ts_Edit.Size = New System.Drawing.Size(132, 22)
        Me.ts_Edit.Text = "Edit"
        '
        'ToolsContextMenu
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Refresh, Me.ts_Remove, Me.ts_Edit, Me.ts_Send})
        Me.Size = New System.Drawing.Size(133, 92)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ts_Refresh As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_Remove As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ts_Send As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Edit As Windows.Forms.ToolStripMenuItem
End Class
