Imports System.ComponentModel
Imports System.Windows.Forms

Public Class TemplateSelector
	' TODO: Create template management system for this later

	Private ReadOnly Property SelectedTemplate As Types.Template
		Get
			Return CType(cbx_TemplateSelection.SelectedItem, Types.Template)
		End Get
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
	Public ReadOnly Property TemplateSubject As String
		Get
			Return If(SelectedTemplate?.Subject, "")
		End Get
	End Property


	Sub Reload()
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

	End Sub

	Public Sub AddTemplate(template As Types.Template)
		bsTemplates.Add(template)
	End Sub

	Public Sub AddRange(templates As IList(Of Types.Template))
		For Each template In templates
			AddTemplate(template)
		Next
	End Sub
End Class
