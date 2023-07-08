Imports System.IO
Imports System.Threading
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Gmail.v1.Data
Imports MediaMinistry.GoogleAPI
Imports MediaMinistry.Helpers

' TODO: Incorporate Gmail and GDrive tools in this page
Public Class Frm_Settings
    Private Const currentUser = "Current User: {0}"
    Private cts As CancellationTokenSource
    Private ReadOnly bold As String = "Bolded? {0}"
    Private ReadOnly fontSize As String = "Font Size: {0}pt"
    Private ReadOnly textFont As String = "Font: {0}"
    Private result As DialogResult

    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings from settings file to display to user
        Me.Font = My.Settings.CurrentFont
        bw_Settings.RunWorkerAsync("l")
        bw_CheckServices.RunWorkerAsync()
    End Sub

    Private Sub Btn_Default_Click(sender As Object, e As EventArgs) Handles btn_Default.Click
        bw_Settings.RunWorkerAsync("d")
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        bw_Settings.RunWorkerAsync("s")
    End Sub

    Private Sub Btn_SelectFont_Click(sender As Object, e As EventArgs) Handles btn_ChangeFont.Click
        result = fd_FontSelector.ShowDialog()

        If result = DialogResult.OK Then
            ChangeFont()
        Else
            fd_FontSelector.Font = My.Settings.CurrentFont
        End If
    End Sub

    Private Sub ChangeFont()
        lbl_CurrentFont.Text = String.Format(textFont, fd_FontSelector.Font.Name)
        lbl_FontSize.Text = String.Format(fontSize, fd_FontSelector.Font.Size)
        lbl_Bold.Text = String.Format(bold, IIf(fd_FontSelector.Font.Bold, "Yes", "No"))
    End Sub

    Private Sub Bw_Settings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Settings.DoWork
        Select Case CType(e.Argument, String)
            Case "l"
                'Load the settings of the application
                Me.Invoke(
                    Sub()
                        fd_FontSelector.Font = My.Settings.CurrentFont
                        ChangeFont()
                    End Sub
                )
            Case "s"
                'Save the settings that have been changed by the user
                My.Settings.CurrentFont = fd_FontSelector.Font
                My.Settings.Save()
            Case "d"
                'Restore the defaults of the application
                My.Settings.CurrentFont = My.Settings.DefaultFont
                Invoke(
                    Sub()
                        fd_FontSelector.Font = My.Settings.CurrentFont
                        ChangeFont()
                    End Sub
                )
                My.Settings.Save()
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Utils.CloseOpenForms()
    End Sub

    Private Sub Btn_GoogleDrive_Click(sender As Object, e As EventArgs) Handles btn_GoogleDrive.Click
        If btn_GoogleDrive.Text = "Unlink Google Drive" Then
            Try
                Directory.Delete(Application.StartupPath & "\Drive Token", True)
                btn_GoogleDrive.Text = "Link Google Drive"
                lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
            Catch ex As DirectoryNotFoundException

            Catch ex As UnauthorizedAccessException

            Catch ex As PathTooLongException

            End Try
        ElseIf btn_GoogleDrive.Text = "Cancel" Then
            If cts IsNot Nothing Then
                cts.Cancel()
                bw_Service.CancelAsync()
                btn_GoogleDrive.Text = "Link Google Drive"
            End If
        ElseIf btn_GoogleDrive.Text = "Link Google Drive" Then
            btn_GoogleDrive.Text = "Cancel"
            bw_Service.RunWorkerAsync("d")
        End If
    End Sub

    Private Sub Btn_Gmail_Click(sender As Object, e As EventArgs) Handles btn_Gmail.Click
        If btn_Gmail.Text = "Unlink Gmail" Then
            Try
                Directory.Delete(Application.StartupPath & "\Gmail Token", True)
                btn_Gmail.Text = "Link Gmail"
                lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
            Catch ex As DirectoryNotFoundException

            Catch ex As UnauthorizedAccessException

            Catch ex As PathTooLongException

            End Try
        ElseIf btn_Gmail.Text = "Cancel" Then
            If cts IsNot Nothing Then
                cts.Cancel()
                bw_Service.CancelAsync()
                btn_Gmail.Text = "Link Gmail"
            End If
        ElseIf btn_Gmail.Text = "Link Gmail" Then
            btn_Gmail.Text = "Cancel"
            bw_Service.RunWorkerAsync("m")
        End If
    End Sub

    Private Sub Bw_Service_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Service.DoWork
        cts = New CancellationTokenSource()
		'Dim service As Service
		Select Case CType(e.Argument, String)
            Case "d"
                Try
					'service = New DriveUploader(cts.Token)
					Invoke(
                        Sub()
                            btn_GoogleDrive.Text = "Unlink Google Drive"
							'lbl_CurrentDrive.Text = String.Format(currentUser, CType(service.Info, User).EmailAddress)
						End Sub
                    )
                Catch ex As OperationCanceledException
                    Console.WriteLine("Canceled Exception")
                Catch ex As AggregateException
                    Console.WriteLine("Aggregate Exception")
                End Try

            Case "m"
                Try
                    Invoke(
                        Sub()
							'service = New Sender(cts.Token)
							btn_Gmail.Text = "Unlink Gmail"
							'lbl_CurrentGmail.Text = String.Format(currentUser, CType(service.Info, Profile).EmailAddress)
						End Sub
                    )
                Catch ex As OperationCanceledException
                    Console.WriteLine("Canceled Exception")
                Catch ex As AggregateException
                    Console.WriteLine("Aggregate Exception")
                End Try
        End Select
    End Sub

    Private Sub Bw_CheckServices_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_CheckServices.DoWork
        Invoke(
            Sub()
                'Retrieve the Google Drive Info being used by the user
                If Directory.Exists(Application.StartupPath & "\Drive Token") Then
					'Using uploader As New DriveUploader()
					'    Dim user As User = CType(uploader.Info, User)

					'    If user IsNot Nothing Then
					'        lbl_CurrentDrive.Text = String.Format(currentUser, user.EmailAddress)
					'        btn_GoogleDrive.Text = "Unlink Google Drive"
					'    Else
					'        lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
					'        btn_GoogleDrive.Text = "Link Google Drive"
					'    End If
					'End Using
				Else
                    lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
                    btn_GoogleDrive.Text = "Link Google Drive"
                End If

                'Retrieve the Google Drive Info being used by the user
                If Directory.Exists(Application.StartupPath & "\Gmail Token") Then
					'Using emailer As New Sender()
					'    Dim profile As Profile = CType(emailer.Info, Profile)

					'    If profile IsNot Nothing Then
					'        lbl_CurrentGmail.Text = String.Format(currentUser, profile.EmailAddress)
					'        btn_Gmail.Text = "Unlink Gmail"
					'    Else
					'        lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
					'        btn_Gmail.Text = "Link Gmail"
					'    End If
					'End Using
				Else
                    lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
                    btn_Gmail.Text = "Link Gmail"
                End If
            End Sub
            )
    End Sub

    Private Sub Frm_Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If My.Application.OpenForms.Count > 1 Then
            For Each form As Form In My.Application.OpenForms
                If form.Name.Equals("Frm_Main", StringComparison.OrdinalIgnoreCase) Then
                    form.Show()
                    Exit For
                End If
            Next
        End If
    End Sub
End Class