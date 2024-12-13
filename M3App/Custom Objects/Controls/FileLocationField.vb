Public Class FileLocationField
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofdFileSelection.ShowDialog()
    End Sub

    Private Sub OfdFileSelection_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdFileSelection.FileOk
        txtFileLocation.Text = ofdFileSelection.SafeFileName
    End Sub

    Private Sub FileLocationField_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtFileLocation.Text = ""
        ofdFileSelection.Reset()
    End Sub
End Class
