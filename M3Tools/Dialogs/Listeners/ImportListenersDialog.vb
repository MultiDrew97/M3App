Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO
Imports SPPBC.M3Tools.Events.Listeners

Namespace Dialogs
	Public Class ImportListenersDialog
		Public Event ListenerAdded As ListenerEventHandler

		Private ReadOnly Property DataSource As Types.ListenerCollection
			Get
				' TODO: Fix this to properly manage list contents
				Return ldg_Listeners.Listeners
			End Get
		End Property

		Private Sub BeginImport(sender As Object, e As EventArgs) Handles btn_Import.Click
			If DataSource.Count = 0 Then
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

		Private Sub ImportListeners(sender As Object, e As DoWorkEventArgs) Handles bw_ImportListeners.DoWork
			Dim list = DataSource

			For Each listener In DataSource
				Try
					db_Listeners.AddListener(listener)
					RaiseEvent ListenerAdded(Me, New ListenerEventArgs(listener, M3Tools.Events.EventType.Added))
					DataSource.Remove(listener)
				Catch ex As Exception
					Console.Error.WriteLine(ex.Message)
					Throw New Exceptions.NotYetImplementedException("ImportListeners exception block")
				End Try
			Next
		End Sub

		Private Sub ListenersImported(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ImportListeners.RunWorkerCompleted
			UseWaitCursor = False
			If DataSource.Count > 0 Then
				MessageBox.Show("Some listeners couldn't be imported. Please check list for failed additions", "Failed Imports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If

			Dim res = MessageBox.Show("Would you like to import more listeners?", "Additional Imports", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If Not res = DialogResult.Yes Then
				Me.DialogResult = DialogResult.OK
				Me.Close()
				Return
			End If
		End Sub

		Private Sub ClearList(sender As Object, e As EventArgs) Handles btn_Clear.Click
			Dim res = MessageBox.Show("Are you sure you want to clear the list of imports?", "Clear Import List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If Not res = DialogResult.Yes Then
				Return
			End If

			DataSource.Clear()
		End Sub

		Private Sub ParseFiles(sender As Object, e As DoWorkEventArgs) Handles bw_ParseFiles.DoWork
			Dim files = CType(e.Argument, String())
			Dim colDict As New Dictionary(Of String, Integer) From {{"Name", 0}, {"Email", 1}}
			Dim csvReader As TextFieldParser

			For Each file In ofd_ImportFile.FileNames
				csvReader = New TextFieldParser(file) With {
					.Delimiters = {","},
					.TextFieldType = FieldType.Delimited
				}

				If chk_Headers.Checked Then
					Try
						colDict = ParseHeaders(String.Join(";", csvReader.ReadFields).ToLower().Split(";"c))
					Catch ex As ArgumentException
						Throw New Exceptions.NotYetImplementedException("Import Fields Error")
					End Try
				End If

				While Not csvReader.EndOfData
					Dim fields = csvReader.ReadFields()
					Dim listener = New Types.Listener() With {
									.Name = fields(colDict("Name")),
									.Email = fields(colDict("Email"))
									}

					If DataSource.Contains(listener) Then
						Continue While
					End If

					DataSource.Add(listener)
				End While
			Next
		End Sub

		Private Sub FilesParsed(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ParseFiles.RunWorkerCompleted
			ldg_Listeners.Invalidate()
			ldg_Listeners.Select()
		End Sub
	End Class
End Namespace

