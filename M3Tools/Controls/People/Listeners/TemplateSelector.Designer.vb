<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TemplateSelector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.wb_TemplateDisplay = New System.Windows.Forms.WebBrowser()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbx_TemplateSelection = New System.Windows.Forms.ComboBox()
        Me.bsTemplates = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.bsTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wb_TemplateDisplay
        '
        Me.wb_TemplateDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb_TemplateDisplay.IsWebBrowserContextMenuEnabled = False
        Me.wb_TemplateDisplay.Location = New System.Drawing.Point(0, 0)
        Me.wb_TemplateDisplay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_TemplateDisplay.Name = "wb_TemplateDisplay"
        Me.wb_TemplateDisplay.Size = New System.Drawing.Size(200, 174)
        Me.wb_TemplateDisplay.TabIndex = 0
        Me.wb_TemplateDisplay.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.wb_TemplateDisplay.WebBrowserShortcutsEnabled = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbx_TemplateSelection)
        Me.SplitContainer1.Panel1MinSize = 21
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.wb_TemplateDisplay)
        Me.SplitContainer1.Size = New System.Drawing.Size(200, 200)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.TabStop = False
        '
        'cbx_TemplateSelection
        '
        Me.cbx_TemplateSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_TemplateSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_TemplateSelection.DataSource = Me.bsTemplates
        Me.cbx_TemplateSelection.DisplayMember = "Name"
        Me.cbx_TemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbx_TemplateSelection.FormattingEnabled = True
        Me.cbx_TemplateSelection.Location = New System.Drawing.Point(0, 0)
        Me.cbx_TemplateSelection.Name = "cbx_TemplateSelection"
        Me.cbx_TemplateSelection.Size = New System.Drawing.Size(200, 21)
        Me.cbx_TemplateSelection.TabIndex = 0
        Me.cbx_TemplateSelection.ValueMember = "Text"
        '
        'bsTemplates
        '
        Me.bsTemplates.DataSource = GetType(SPPBC.M3Tools.Types.TemplateList)
        '
        'TemplateSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "TemplateSelector"
        Me.Size = New System.Drawing.Size(200, 200)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.bsTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wb_TemplateDisplay As Windows.Forms.WebBrowser
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents cbx_TemplateSelection As Windows.Forms.ComboBox
    Friend WithEvents bsTemplates As Windows.Forms.BindingSource
End Class
