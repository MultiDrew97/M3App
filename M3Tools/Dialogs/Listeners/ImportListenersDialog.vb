Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO

Namespace Dialogs
	Public Class ImportListenersDialog

		Private ReadOnly newListenersList As New Collection(Of NewListener)

		Private Sub BeginImport(sender As Object, e As EventArgs) Handles btn_Import.Click
			If bsListeners.Count = 0 Then
				MessageBox.Show("No listeners have been selected", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Return
			End If

			If bw_ImportListeners.IsBusy Then
				Return
			End If

			UseWaitCursor = True
			bw_ImportListeners.RunWorkerAsync()
		End Sub

		Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub RetrieveFile(sender As Object, e As EventArgs) Handles btn_Browse.Click
			ofd_ImportFile.ShowDialog()
		End Sub

		Private Sub ImportListenersDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
			'bsListeners.DataSource = New Collection(Of NewListener)
		End Sub

		Private Sub FilesSelected(sender As Object, e As CancelEventArgs) Handles ofd_ImportFile.FileOk
			Dim colDict As New Dictionary(Of String, Integer) From {{"Name", 0}, {"Email", 1}}
			gi_FileName.Text = String.Join(",", ofd_ImportFile.SafeFileNames)

			Dim csvReader As TextFieldParser

			For Each file In ofd_ImportFile.FileNames
				csvReader = New TextFieldParser(file) With {
					.Delimiters = {","},
					.TextFieldType = FieldType.Delimited
				}

				If chk_Headers.Checked Then
					Try
						VerifyHeaders(csvReader.ReadFields, colDict)
					Catch ex As Exception
					End Try
				End If

				While Not csvReader.EndOfData
					Dim fields = csvReader.ReadFields()
					bsListeners.Add(New NewListener(fields(colDict("Name")), fields(colDict("Email"))))
				End While
			Next

			bsListeners.Filter = "[Name] IS UNIQUE AND [Email] IS UNIQUE"

			dgv_ImportedListeners.Select()
		End Sub

		Private Sub VerifyHeaders(headers As String(), ByRef colDict As Dictionary(Of String, Integer))
			Dim validHeaderValues As String() = {"Name", "Email"}

			For Each validHeader In validHeaderValues
				Dim index = Array.IndexOf(headers, validHeader)

				If index < 0 Then
					Throw New ArgumentException($"Unable to find column '{validHeader}'. Please update file and try again.")
				End If

				colDict(validHeader) = index
			Next
		End Sub

		Private Sub Import(sender As Object, e As DoWorkEventArgs) Handles bw_ImportListeners.DoWork
			Dim list = bsListeners.List

			For Each listener As NewListener In list
				Try
					db_Listeners.AddListener(listener.Name, listener.Email)
					bsListeners.Remove(listener)
				Catch ex As Exception
					Console.Error.WriteLine(ex.Message)
				End Try
			Next
		End Sub

		Private Sub ListenersImported(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ImportListeners.RunWorkerCompleted
			UseWaitCursor = False
			If bsListeners.Count > 0 Then
				MessageBox.Show("Some listeners couldn't be imported. Please check list for failed additions", "Failed Imports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If

			Dim res = MessageBox.Show("Would you like to import more listeners?", "Additional Imports", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If res = DialogResult.No Then
				Me.DialogResult = DialogResult.OK
				Me.Close()
				Return
			End If
		End Sub

		Private Sub ClearList(sender As Object, e As EventArgs) Handles btn_Clear.Click
			Dim res = MessageBox.Show("Are you sure you want to clear the list of imports?", "Clear Import List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If res = DialogResult.No Then
				Return
			End If

			bsListeners.Clear()
		End Sub

		Friend Class NewListener
			Property Name As String
			Property Email As String

			Sub New()
				Me.New("John Doe", "johndoe@domain.ext")
			End Sub

			Sub New(name As String, email As String)
				Me.Name = name
				Me.Email = email
			End Sub
		End Class
	End Class
End Namespace

