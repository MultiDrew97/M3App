Imports System.ComponentModel

Public Class FileUpload
	Private ReadOnly __files As New GoogleAPI.Types.FileCollection()
	Public ReadOnly Property Files As GoogleAPI.Types.FileCollection
		Get
			Return __files
		End Get
	End Property

	Public Property MultiSelect As Boolean
		Get
			Return ofd_FileDialog.Multiselect
		End Get
		Set(value As Boolean)
			ofd_FileDialog.Multiselect = value
		End Set
	End Property

	Private Sub SelectFiles(sender As Object, e As EventArgs) Handles btn_Select.Click
		ofd_FileDialog.ShowDialog()
	End Sub

	Private Sub FilesSelected(sender As Object, e As CancelEventArgs) Handles ofd_FileDialog.FileOk
		txt_FileName.Text = String.Join(",", ofd_FileDialog.SafeFileNames)
		LoadFiles()
	End Sub

	Private Sub LoadFiles()
		Files.Clear()
		For Each file In ofd_FileDialog.FileNames
			Files.Add(New GoogleAPI.Types.File("", file, file.Split("."c)(1)))
		Next
	End Sub
End Class
