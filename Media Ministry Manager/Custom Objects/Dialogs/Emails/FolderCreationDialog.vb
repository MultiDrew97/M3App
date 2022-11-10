Option Strict On

'TODO: Add GDrive Tool

Public Class FolderCreationDialog
    Private Sub Btn_CreateFolder_Click(sender As Object, e As EventArgs) Handles btn_CreateFolder.Click
		'Using uploader As New GoogleAPI.DriveUploader()
		'    If uploader.CreateFolder(txt_FolderName.Text) IsNot Nothing Then
		'        MessageBox.Show("Folder has been created.", "Folder Creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
		'        DialogResult = DialogResult.OK
		'        Me.Close()
		'    Else
		'        MessageBox.Show("Failed to create a folder with that name. Please try again.", "Folder Creation", MessageBoxButtons.OK, MessageBoxIcon.Error)
		'    End If
		'End Using
	End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub ReloadFolders()
    '    For Each form As Form In My.Application.OpenForms
    '        If form.Name.Equals("frm_sendemails", StringComparison.OrdinalIgnoreCase) Then
    '            CType(form, frm_SendEmails).LoadFolders()
    '            Exit For
    '        End If
    '    Next
    'End Sub
End Class
