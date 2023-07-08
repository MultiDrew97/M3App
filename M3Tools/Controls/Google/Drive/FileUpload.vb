Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.GTools.Types

Public Class FileUpload

	Public ReadOnly Property Files As IList
		Get
			Return bsFiles.List
		End Get
	End Property

	<DefaultValue(True)>
	Public Property MultiSelect As Boolean
		Get
			Return ofd_FileDialog.Multiselect
		End Get
		Set(value As Boolean)
			ofd_FileDialog.Multiselect = value
		End Set
	End Property

	Public Property DataSource As BindingSource
		Get
			Return bsFiles 'CType(dgv_Files.DataSource, BindingSource)
		End Get
		Set(value As BindingSource)
			'dgv_Files.AutoGenerateColumns = False
			'dgv_Files.DataSource = value
			bsFiles = value
		End Set
	End Property

	Private Sub LoadFiles(sender As Object, e As CancelEventArgs) Handles ofd_FileDialog.FileOk
		For Each file In ofd_FileDialog.FileNames
			If Duplicate(file) Then
				Continue For
			End If
			bsFiles.Add(New File("", file, file.Split("."c)(1)))
		Next
	End Sub

	Private Function Duplicate(fileName As String) As Boolean
		' TODO: Find how to simplify
		For Each file As File In bsFiles.List
			If file.Name = fileName Then
				Return True
			End If
		Next

		Return False
	End Function

	Private Sub SelectFiles(sender As Object, e As ToolStripItemClickedEventArgs) Handles ts_Tools.ItemClicked
		UseWaitCursor = True
		Dim res = ofd_FileDialog.ShowDialog()
		If res = DialogResult.OK Then
			UseWaitCursor = False
		End If
	End Sub

	Private Sub DataSourceUpdated(sender As Object, e As ListChangedEventArgs) Handles bsFiles.ListChanged
		If e.ListChangedType = ListChangedType.ItemAdded OrElse e.ListChangedType = ListChangedType.ItemDeleted Then
			bsFiles.ResetBindings(False)
		End If
	End Sub
End Class
