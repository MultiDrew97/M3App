<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListenersManagement
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
		Dim MySettings3 As MediaMinistry.My.MySettings = New MediaMinistry.My.MySettings()
		Dim MySettings1 As MediaMinistry.My.MySettings = New MediaMinistry.My.MySettings()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListenersManagement))
		Me.mms_Main = New SPPBC.M3Tools.MainMenuStrip()
		Me.dlc_Listeners = New SPPBC.M3Tools.DisplayListenersCtrl()
		Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
		Me.gt_Email = New SPPBC.M3Tools.GTools.GmailTool(Me.components)
		Me.dbListeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'mms_Main
		'
		Me.mms_Main.Location = New System.Drawing.Point(0, 0)
		Me.mms_Main.Name = "mms_Main"
		Me.mms_Main.Size = New System.Drawing.Size(784, 24)
		Me.mms_Main.TabIndex = 0
		Me.mms_Main.Text = "MainMenuStrip1"
		'
		'dlc_Listeners
		'
		MySettings3.CurrentFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		MySettings3.debugConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry Test"";Connect Timeout" &
	"=30;Encrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
		MySettings3.KeepLoggedIn = True
		MySettings3.Password = "JasmineLove2697"
		MySettings3.releaseConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry"";Connect Timeout=30;E" &
	"ncrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
		MySettings3.SettingsKey = ""
		MySettings3.UpgradeRequired = True
		MySettings3.Username = "arandlemiller97"
		Me.dlc_Listeners.CountTemplate = MySettings3.CountTemplate
		Me.dlc_Listeners.DataSource = Me.bsListeners
		Me.dlc_Listeners.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dlc_Listeners.Location = New System.Drawing.Point(0, 24)
		Me.dlc_Listeners.Name = "dlc_Listeners"
		Me.dlc_Listeners.Size = New System.Drawing.Size(784, 437)
		Me.dlc_Listeners.TabIndex = 1
		'
		'bsListeners
		'
		Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.Types.ListenerCollection)
		'
		'gt_Email
		'
		MySettings1.CurrentFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
		MySettings1.debugConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry Test"";Connect Timeout" &
	"=30;Encrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
		MySettings1.KeepLoggedIn = True
		MySettings1.Password = "JasmineLove2697"
		MySettings1.releaseConnection = "Data Source=sppbc.hopto.org;Initial Catalog=""Media Ministry"";Connect Timeout=30;E" &
	"ncrypt=True;Authentication=""Sql Password"";TrustServerCertificate=True;"
		MySettings1.SettingsKey = ""
		MySettings1.UpgradeRequired = True
		MySettings1.Username = "arandlemiller97"
		Me.gt_Email.Username = MySettings1.Username
		'
		'dbListeners
		'
		Me.dbListeners.InitialCatalog = "Media Ministry Test"
		Me.dbListeners.Password = "M3AppPassword2499"
		Me.dbListeners.Username = "M3App"
		'
		'ListenersManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 461)
		Me.Controls.Add(Me.dlc_Listeners)
		Me.Controls.Add(Me.mms_Main)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mms_Main
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(800, 500)
		Me.Name = "ListenersManagement"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Media Ministry Manager"
		CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mms_Main As SPPBC.M3Tools.MainMenuStrip
	Friend WithEvents dlc_Listeners As SPPBC.M3Tools.DisplayListenersCtrl
	Friend WithEvents gt_Email As SPPBC.M3Tools.GTools.GmailTool
	Friend WithEvents bsListeners As BindingSource
	Friend WithEvents dbListeners As SPPBC.M3Tools.Database.ListenerDatabase
End Class
