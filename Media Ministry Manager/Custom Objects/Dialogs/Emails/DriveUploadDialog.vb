Imports System.ComponentModel
Imports MediaMinistry.GoogleAPI

' TODO: Add GDrive Tool
Public Class DriveUploadDialog
    'TODO: Make this look better when uploading files

    Private Structure Locations
        Shared CustomNameFolder As Point() = {New Point(328, 38), New Point(338, 68)}
        Shared CustomNameFile As Point() = {New Point(328, 180), New Point(338, 211)}
        Shared CustomNameCheck As New Point(518, 294)
        Shared CustomNameAdd As New Point(818, 68)
        Shared CustomNameBrowse As New Point(818, 211)
        Shared DefaultNameFolder As Point() = {New Point(328, 71), New Point(338, 101)}
        Shared DefaultNameFile As Point() = {New Point(328, 213), New Point(338, 244)}
        Shared DefaultNameCheck As New Point(518, 327)
        Shared DefaultNameAdd As New Point(818, 101)
        Shared DefaultNameBrowse As New Point(818, 244)
    End Structure

    Private Sub Frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectAudio.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_SelectAudio.CheckFileExists Then
                Ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
            End If
        End If
    End Sub

    Private Sub Frm_EmailListeners_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk
        txt_FileLocation.Text = ofd_SelectAudio.SafeFileName
    End Sub

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_SelectAudio.ShowDialog()
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        If FolderCreationDialog.ShowDialog() = DialogResult.OK Then
            LoadFolders()
        End If
    End Sub

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
		'Using uploader As New DriveUploader()
		'    Dim parents As New List(Of String) From {uploader.GetFolderID(CType(cbx_Folders.SelectedItem, String))}

		'    If chk_Custom.Checked And Not String.IsNullOrWhiteSpace(txt_CustomName.Text) Then
		'        uploader.Upload(ofd_SelectAudio.FileName, parents, txt_CustomName.Text)
		'    Else
		'        uploader.Upload(ofd_SelectAudio.FileName, parents)
		'    End If
		'End Using

		MessageBox.Show("File has been uploaded.", "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Chk_Custom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Custom.CheckedChanged
        bw_MovePairs.RunWorkerAsync()

        txt_CustomName.Visible = chk_Custom.Checked
        lbl_CustomName.Visible = chk_Custom.Checked
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Frm_Upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFolders()
    End Sub

    Private Sub Bw_MovePairs_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_MovePairs.DoWork
        'move the pairs according to the status of the custom name check box
        Invoke(
            Sub()
                If chk_Custom.Checked Then
                    lbl_Folder.Location = Locations.CustomNameFolder(0)
                    cbx_Folders.Location = Locations.CustomNameFolder(1)
                    chk_Custom.Location = Locations.CustomNameCheck
                    btn_AddFolder.Location = Locations.CustomNameAdd
                    lbl_FileLocation.Location = Locations.CustomNameFile(0)
                    txt_FileLocation.Location = Locations.CustomNameFile(1)
                    btn_Browse.Location = Locations.CustomNameBrowse
                Else
                    lbl_Folder.Location = Locations.DefaultNameFolder(0)
                    cbx_Folders.Location = Locations.DefaultNameFolder(1)
                    chk_Custom.Location = Locations.DefaultNameCheck
                    btn_AddFolder.Location = Locations.DefaultNameAdd
                    lbl_FileLocation.Location = Locations.DefaultNameFile(0)
                    txt_FileLocation.Location = Locations.DefaultNameFile(1)
                    btn_Browse.Location = Locations.DefaultNameBrowse
                End If
            End Sub
        )
    End Sub

    Private Sub LoadFolders()
		'Using uploader As New DriveUploader
		'    cbx_Folders.DataSource = uploader.GetFolders()
		'End Using
	End Sub
End Class