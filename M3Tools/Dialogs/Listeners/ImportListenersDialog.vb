Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO

Namespace Dialogs
	Public Class ImportListenersDialog
		Public ReadOnly Property Listeners As Types.DBEntryCollection(Of Types.Listener)
			Get
				Return CType(ldg_Listeners.Listeners, Types.DBEntryCollection(Of Types.Listener))
			End Get
		End Property

		Private Sub BeginImport(sender As Object, e As EventArgs) Handles btn_Import.Click
			If Listeners.Count = 0 Then
				MessageBox.Show("No listeners have been selected", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Return
			End If

			DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub RetrieveFile(sender As Object, e As EventArgs) Handles btn_Browse.Click
			ofd_ImportFile.ShowDialog()
		End Sub

		Private Sub FilesSelected(sender As Object, e As CancelEventArgs) Handles ofd_ImportFile.FileOk
			gi_FileName.Text = String.Join(",", ofd_ImportFile.SafeFileNames)

			bw_ParseFiles.RunWorkerAsync(ofd_ImportFile.FileNames)
		End Sub

		Private Function ParseHeaders(ParamArray headers As String()) As Dictionary(Of String, Integer)
			Dim dict As New Dictionary(Of String, Integer)
			Dim validHeaderValues As String() = {"Name", "Email"}

			For Each validHeader In validHeaderValues
				Dim index = Array.IndexOf(headers, validHeader.ToLower)

				If index < 0 Then
					Throw New ArgumentException($"Unable to find column '{validHeader}'. Please update file and try again.")
				End If

				dict.Add(validHeader, index)
			Next

			Return dict
		End Function

		Private Sub ClearList(sender As Object, e As EventArgs) Handles btn_Clear.Click
			Dim res = MessageBox.Show("Are you sure you want to clear the list of imports?", "Clear Import List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If Not res = DialogResult.Yes Then
				Return
			End If

			' TODO: Verify that this works still
			bsListeners.Clear()
		End Sub

		Private Sub ParseFiles(sender As Object, e As DoWorkEventArgs) Handles bw_ParseFiles.DoWork
			Dim files = CType(e.Argument, String())
			Dim colDict As New Dictionary(Of String, Integer) From {{"Name", 0}, {"Email", 1}}
			Dim csvReader As TextFieldParser
			'Dim listeners As New Types.DBEntryCollection(Of Types.Listener)

			For Each file In ofd_ImportFile.FileNames
				csvReader = New TextFieldParser(file) With {
					.Delimiters = {","},
					.TextFieldType = FieldType.Delimited
				}

				If chk_Headers.Checked Then
					Try
						colDict = ParseHeaders(String.Join(";", csvReader.ReadFields).ToLower().Split(";"c))
					Catch ex As ArgumentException
						Throw New NotImplementedException("Import Fields Error")
					End Try
				End If

				While Not csvReader.EndOfData
					Dim fields = csvReader.ReadFields()
					Dim listener = New Types.Listener(-1, fields(colDict("Name")), fields(colDict("Email")))

					If bsListeners.Contains(listener) Then
						Continue While
					End If

					bsListeners.Add(listener)
				End While
			Next

			' e.Result = listeners
		End Sub

		Private Sub FilesParsed(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ParseFiles.RunWorkerCompleted
			If e.Error IsNot Nothing Then
				Throw e.Error
			End If

			If e.Cancelled Then
				Return
			End If

			bsListeners.DataSource = CType(e.Result, Types.DBEntryCollection(Of Types.Listener))
		End Sub
	End Class
End Namespace

