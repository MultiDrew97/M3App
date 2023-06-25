Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FileUpload

	Public ReadOnly Property Files As GTools.Types.FileCollection
		Get
			Return CType(bsFiles.List, GTools.Types.FileCollection)
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

	Private Sub LoadFiles(sender As Object, e As CancelEventArgs) Handles ofd_FileDialog.FileOk
		For Each file In ofd_FileDialog.FileNames
			If Duplicate(file) Then
				Continue For
			End If
			bsFiles.Add(New GTools.Types.File("", file, file.Split("."c)(1)))
		Next
	End Sub

	Private Function Duplicate(fileName As String) As Boolean
		' TODO: Find how to simplify
		For Each file As GTools.Types.File In bsFiles.List
			If file.Name = fileName Then
				Return True
			End If
		Next

		Return False
	End Function

	Private Sub SelectFiles(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
		UseWaitCursor = True
		Dim res = ofd_FileDialog.ShowDialog()
		If res = DialogResult.OK Then
			UseWaitCursor = False
		End If
	End Sub

	Private Sub FormLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsFiles.DataSource = New GTools.Types.FileCollection()
		bsFiles.Clear()
	End Sub

	Private Sub DataSourceUpdated(sender As Object, e As ListChangedEventArgs) Handles bsFiles.ListChanged
		If e.ListChangedType = ListChangedType.ItemAdded OrElse e.ListChangedType = ListChangedType.ItemDeleted Then
			bsFiles.ResetBindings(False)
		End If
	End Sub
End Class
