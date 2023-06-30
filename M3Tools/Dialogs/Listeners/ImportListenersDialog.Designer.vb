Namespace Dialogs
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Class ImportListenersDialog
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
			Me.btn_Import = New System.Windows.Forms.Button()
			Me.btn_Cancel = New System.Windows.Forms.Button()
			Me.ofd_ImportFile = New System.Windows.Forms.OpenFileDialog()
			Me.btn_Browse = New System.Windows.Forms.Button()
			Me.chk_Headers = New System.Windows.Forms.CheckBox()
			Me.bsListeners = New System.Windows.Forms.BindingSource(Me.components)
			Me.gi_FileName = New SPPBC.M3Tools.GenericInputPair()
			Me.bw_ImportListeners = New System.ComponentModel.BackgroundWorker()
			Me.db_Listeners = New SPPBC.M3Tools.Database.ListenerDatabase(Me.components)
			Me.btn_Clear = New System.Windows.Forms.Button()
			Me.ldg_Listeners = New SPPBC.M3Tools.ListenersDataGrid()
			Me.bw_ParseFiles = New System.ComponentModel.BackgroundWorker()
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'TableLayoutPanel1
			'
			Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Import, 1, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.btn_Cancel, 0, 0)
			Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
			Me.TableLayoutPanel1.TabIndex = 0
			'
			'btn_Import
			'
			Me.btn_Import.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Import.Location = New System.Drawing.Point(76, 3)
			Me.btn_Import.Name = "btn_Import"
			Me.btn_Import.Size = New System.Drawing.Size(67, 23)
			Me.btn_Import.TabIndex = 0
			Me.btn_Import.Text = "OK"
			'
			'btn_Cancel
			'
			Me.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
			Me.btn_Cancel.Name = "btn_Cancel"
			Me.btn_Cancel.Size = New System.Drawing.Size(67, 23)
			Me.btn_Cancel.TabIndex = 1
			Me.btn_Cancel.Text = "Cancel"
			'
			'ofd_ImportFile
			'
			Me.ofd_ImportFile.DefaultExt = "csv"
			Me.ofd_ImportFile.Filter = "CSV files|*.csv"
			Me.ofd_ImportFile.Multiselect = True
			Me.ofd_ImportFile.ShowHelp = True
			Me.ofd_ImportFile.Title = "Import File"
			'
			'btn_Browse
			'
			Me.btn_Browse.Location = New System.Drawing.Point(345, 44)
			Me.btn_Browse.Name = "btn_Browse"
			Me.btn_Browse.Size = New System.Drawing.Size(27, 23)
			Me.btn_Browse.TabIndex = 2
			Me.btn_Browse.Text = "..."
			Me.btn_Browse.UseVisualStyleBackColor = True
			'
			'chk_Headers
			'
			Me.chk_Headers.AutoSize = True
			Me.chk_Headers.Checked = True
			Me.chk_Headers.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chk_Headers.Location = New System.Drawing.Point(66, 81)
			Me.chk_Headers.Name = "chk_Headers"
			Me.chk_Headers.Size = New System.Drawing.Size(110, 17)
			Me.chk_Headers.TabIndex = 3
			Me.chk_Headers.Text = "Contains Headers"
			Me.chk_Headers.UseVisualStyleBackColor = True
			'
			'bsListeners
			'
			Me.bsListeners.DataSource = GetType(SPPBC.M3Tools.Types.ListenerCollection)
			'
			'gi_FileName
			'
			Me.gi_FileName.AutoSize = True
			Me.gi_FileName.Enabled = False
			Me.gi_FileName.LabelText = "Import File:"
			Me.gi_FileName.Location = New System.Drawing.Point(39, 29)
			Me.gi_FileName.Mask = ""
			Me.gi_FileName.Name = "gi_FileName"
			Me.gi_FileName.Placeholder = "Select Files..."
			Me.gi_FileName.Size = New System.Drawing.Size(308, 46)
			Me.gi_FileName.TabIndex = 1
			Me.gi_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			'
			'bw_ImportListeners
			'
			'
			'db_Listeners
			'
			Me.db_Listeners.InitialCatalog = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultCatalog
			Me.db_Listeners.Password = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultPassword
			Me.db_Listeners.Username = Global.SPPBC.M3Tools.My.MySettings.Default.DefaultUsername
			'
			'btn_Clear
			'
			Me.btn_Clear.Location = New System.Drawing.Point(384, 128)
			Me.btn_Clear.Name = "btn_Clear"
			Me.btn_Clear.Size = New System.Drawing.Size(39, 24)
			Me.btn_Clear.TabIndex = 5
			Me.btn_Clear.Text = "Clear"
			Me.btn_Clear.UseVisualStyleBackColor = True
			'
			'ldg_Listeners
			'
			Me.ldg_Listeners.AllowColumnReordering = True
			Me.ldg_Listeners.AllowDeleting = False
			Me.ldg_Listeners.AllowEditting = False
			Me.ldg_Listeners.Filter = ""
			Me.ldg_Listeners.ListenersSelectable = False
			Me.ldg_Listeners.Location = New System.Drawing.Point(28, 128)
			Me.ldg_Listeners.MinimumSize = New System.Drawing.Size(350, 100)
			Me.ldg_Listeners.Name = "ldg_Listeners"
			Me.ldg_Listeners.Size = New System.Drawing.Size(350, 100)
			Me.ldg_Listeners.TabIndex = 6
			'
			'bw_ParseFiles
			'
			'
			'ImportListenersDialog
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(435, 315)
			Me.Controls.Add(Me.ldg_Listeners)
			Me.Controls.Add(Me.btn_Clear)
			Me.Controls.Add(Me.chk_Headers)
			Me.Controls.Add(Me.btn_Browse)
			Me.Controls.Add(Me.gi_FileName)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ImportListenersDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Import Listeners"
			Me.TableLayoutPanel1.ResumeLayout(False)
			CType(Me.bsListeners, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Friend WithEvents btn_Import As System.Windows.Forms.Button
		Friend WithEvents btn_Cancel As System.Windows.Forms.Button
		Friend WithEvents ofd_ImportFile As Windows.Forms.OpenFileDialog
		Friend WithEvents gi_FileName As GenericInputPair
		Friend WithEvents btn_Browse As Windows.Forms.Button
		Friend WithEvents chk_Headers As Windows.Forms.CheckBox
		Friend WithEvents bsListeners As Windows.Forms.BindingSource
		Friend WithEvents bw_ImportListeners As ComponentModel.BackgroundWorker
		Friend WithEvents db_Listeners As Database.ListenerDatabase
		Friend WithEvents dgc_Name As Windows.Forms.DataGridViewTextBoxColumn
		Friend WithEvents dgc_Email As Windows.Forms.DataGridViewTextBoxColumn
		Friend WithEvents btn_Clear As Windows.Forms.Button
		Friend WithEvents ldg_Listeners As ListenersDataGrid
		Friend WithEvents bw_ParseFiles As ComponentModel.BackgroundWorker
	End Class
End Namespace