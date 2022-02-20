Imports System.ServiceProcess

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateService
	Inherits ServiceBase

	'UserService overrides dispose to clean up the component list.
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

	'Required by the Component Designer
	Private components As System.ComponentModel.IContainer

	' NOTE: The following procedure is required by the Component Designer
	' It can be modified using the Component Designer.  Do not modify it
	' using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.wb_Updater = New System.Windows.Forms.WebBrowser()
		'
		'wb_Updater
		'
		Me.wb_Updater.Location = New System.Drawing.Point(332, 324)
		Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wb_Updater.Name = "wb_Updater"
		Me.wb_Updater.Size = New System.Drawing.Size(45, 36)
		Me.wb_Updater.TabIndex = 6
		Me.wb_Updater.Visible = False
		'
		'UpdateService
		'
		Me.ServiceName = "UpdateService"

	End Sub

	Friend WithEvents wb_Updater As Windows.Forms.WebBrowser
End Class
