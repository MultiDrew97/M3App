Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types.GoogleAPI

Public Class UploadFileDialog
	Private ReadOnly __username As String
	Private ReadOnly __files As New FileCollection
	Private __permission As Google.Apis.Drive.v3.Data.Permission
	Public Property Files As FileCollection
		Get
			Return __files
		End Get
		Set(value As FileCollection)
			__files.Clear()
			__files.AddRange(value)
		End Set
	End Property

	Sub New(username As String)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		__username = username
		dt_DriveHeirarchy.Username = __username

		bw_LoadDialog.RunWorkerAsync()
	End Sub

	Private Sub Upload(sender As Object, e As EventArgs) Handles btn_Upload.Click
		If dt_DriveHeirarchy.SelectedNode IsNot Nothing Then
			If chk_DefaultPermissions.Checked Then
				__permission = Nothing
			Else
				Using permissions As New PermissionsDialog()
					If permissions.ShowDialog() = DialogResult.OK Then
						Console.WriteLine(permissions.Permission.Role)
						Console.WriteLine(permissions.Permission.Type)
						__permission = permissions.Permission
					End If
				End Using
			End If

			'bw_LoadFiles.RunWorkerAsync()
		Else
			MessageBox.Show("You must select a parent folder.", "New Upload", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Async Sub DialogLoad(sender As Object, e As DoWorkEventArgs) Handles bw_LoadDialog.DoWork
		Await gdt_GDrive.Authorize(__username)
	End Sub

	Private Sub DialogLoadFinished(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadDialog.RunWorkerCompleted
		dt_DriveHeirarchy.RefreshTree()
	End Sub

	Private Sub Finish()
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub LoadFiles(sender As Object, e As DoWorkEventArgs) Handles bw_LoadFiles.DoWork
		Dim fileParts() As String
		Dim fileExt As String
		Files.Clear()
		For Each file In fu_FileUpload.Files
			fileParts = file.Name.Split("."c)
			fileExt = fileParts(fileParts.Length - 1)
			Files.Add(New File("", file.Name, fileExt))
		Next
	End Sub

	Private Sub SetParents(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadFiles.RunWorkerCompleted
		Dim selectedParentId = dt_DriveHeirarchy.SelectedNode.Name
		For Each file In Files
			If file.Parents Is Nothing Then
				file.Parents = If(selectedParentId.Equals("main"), Nothing, New Collection(Of String)({selectedParentId}))
			Else
				If selectedParentId.Equals("main") Then
					file.Parents = Nothing
				Else
					file.Parents.Add(dt_DriveHeirarchy.SelectedNode.Name)
				End If
			End If
		Next
		bw_UploadFiles.RunWorkerAsync()
	End Sub

	Private Sub UploadFiles(sender As Object, e As DoWorkEventArgs) Handles bw_UploadFiles.DoWork
		Dim fileName As String
		Try
			For Each file In Files
				fileName = InputBox(String.Format("What would you like to call this file? (default: {0})", Utils.DefaultFileName(file.Name)), "File Name", Utils.DefaultFileName(file.Name))
				gdt_GDrive.UploadFile(file, fileName, __permission)
			Next

			e.Result = True
			Finish()
		Catch ex As Exceptions.UploadException
			MessageBox.Show(Me, ex.Message, "New Upload", MessageBoxButtons.OK, MessageBoxIcon.Error)
			e.Result = False
		End Try
	End Sub

	Private Sub UploadCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_UploadFiles.RunWorkerCompleted
		If CBool(e.Result) Then
			Finish()
		End If
	End Sub
End Class
