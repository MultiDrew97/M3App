Option Strict On

Public Class EmailMinistryDialog
    Shared Property SelectedItem As String

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        If DriveUploadDialog.ShowDialog() = DialogResult.OK Then
            DialogResult = DialogResult.Ignore
        End If
    End Sub

    Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
		Using dialog As New SPPBC.M3Tools.SendEmailsDialog()
			If dialog.ShowDialog() = DialogResult.OK Then
				DialogResult = DialogResult.Ignore
			End If
		End Using
	End Sub

    Private Sub Btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        SelectedItem = "View"
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EmailListenersDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectedItem = ""
    End Sub
End Class
