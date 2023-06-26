Imports System.ComponentModel
Imports System.Windows.Forms

Public Class TemplateSelector
	' TODO: Allow to add more templates later
	Private templates As New TemplateList

	<Category("Data")>
	<DesignOnly(True)>
	<RefreshProperties(RefreshProperties.Repaint)>
	<AttributeProvider(GetType(IListSource))>
	<EditorBrowsable(EditorBrowsableState.Always)>
	Public Property DataSource As TemplateList
		Get
			Return templates
		End Get
		Set(value As TemplateList)
			templates = value
		End Set
	End Property

	<[ReadOnly](True)>
	Public ReadOnly Property TemplateName As String
		Get
			Return cbx_TemplateSelection.SelectedText
		End Get
	End Property

	<[ReadOnly](True)>
	Public ReadOnly Property TemplateValue As String
		Get
			Return CStr(cbx_TemplateSelection.SelectedValue)
		End Get
	End Property

	Private Sub SelectorLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsTemplates.DataSource = DataSource
		cbx_TemplateSelection.DisplayMember = "Name"
		cbx_TemplateSelection.ValueMember = "Text"
	End Sub

	Sub Reload()
		bsTemplates.Add(New Template() With {.Name = "Sermon", .Text = My.Resources.DefaultSermonEmail})
		bsTemplates.Add(New Template() With {.Name = "Reciept", .Text = My.Resources.DefaultReceiptEmail})
		cbx_TemplateSelection.SelectedIndex = -1
	End Sub

	Private Sub TemplateSelectionChanged(sender As Object, e As EventArgs) Handles cbx_TemplateSelection.SelectedIndexChanged
		If cbx_TemplateSelection.SelectedIndex < 0 Then
			cbx_TemplateSelection.Text = "Select Template..."
			Return
		End If

		'wb_TemplateDisplay.Navigate("about:blank")
		wb_TemplateDisplay.DocumentText = CStr(cbx_TemplateSelection.SelectedValue)
	End Sub

	Private Sub TemplateListUpdated(sender As Object, e As ListChangedEventArgs) Handles bsTemplates.ListChanged
		If Not e.ListChangedType = ListChangedType.ItemAdded Then
			Return
		End If

		'BindingSource1.ResetBindings(False)
	End Sub

	Public Class Template
		Property Name As String
		Property Text As String
	End Class
	Public Class TemplateList
		Inherits List(Of Template)
	End Class
End Class
