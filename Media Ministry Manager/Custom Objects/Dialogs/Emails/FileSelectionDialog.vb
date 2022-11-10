Option Strict On

Imports MediaMinistry.GoogleAPI

' TODO: Add Gmail and GDrive Tools

Public Class FileSelectionDialog
    Shared Property FileName As String
    Shared Property FileID As String

    Private Sub Btn_Select_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Ok.Click
        If tcl_Options.SelectedIndex = 0 Then
            If cbx_File.SelectedIndex > -1 Then

				'Using uploader As New DriveUploader
				'    Dim file = uploader.GetFileInfo(CType(cbx_File.SelectedItem, String), CType(cbx_Folder.SelectedItem, String))
				'    FileID = file.Id
				'End Using

				Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("A file must be selected. Please try again.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If flf_FileSelection.ofdFileSelection.FileName <> "" Then
                FileName = flf_FileSelection.ofdFileSelection.FileName
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("A file must be selected. Please try again.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancel.Click
        FileName = Nothing
        FileID = Nothing
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Cbx_Folder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folder.SelectedIndexChanged
		'Using uploader As New DriveUploader()
		'    cbx_File.DataSource = uploader.GetFiles(CType(cbx_Folder.SelectedItem, String))
		'End Using
	End Sub

    Private Sub FileSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileName = Nothing
        FileID = Nothing
		'Using uploader As New DriveUploader()
		'    cbx_Folder.DataSource = uploader.GetFolders
		'End Using
	End Sub
End Class
