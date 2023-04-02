Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Listeners

Public Class DisplayListenersCtrl
	Private ReadOnly dgcPrefix As String = "dgc_"
	Private Confirmed As Boolean = False
	Private ReadOnly _listeners As New DataTables.ListenersDataTable
	Private WithEvents ImportDialog As Dialogs.ImportListenersDialog
	Private WithEvents AddDialog As Dialogs.AddListenerDialog

	Public Event ListenerAdded As Events.Listeners.ListenerAddedEventHandler

	Property Filter As String
		Get
			Return bsListeners.Filter
		End Get
		Set(value As String)
			If value <> "" Then
				bsListeners.Filter = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
				Return
			End If

			bsListeners.Filter = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowEditting As Boolean
		Get
			Return Not dgv_Listeners.ReadOnly
		End Get
		Set(value As Boolean)
			dgv_Listeners.ReadOnly = Not value
		End Set
	End Property

	<DefaultValue(False)>
	Property AllowAdding As Boolean
		Get
			Return dgv_Listeners.AllowUserToAddRows
		End Get
		Set(value As Boolean)
			dgv_Listeners.AllowUserToAddRows = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowDeleting As Boolean
		Get
			Return dgv_Listeners.AllowUserToDeleteRows
		End Get
		Set(value As Boolean)
			dgv_Listeners.AllowUserToDeleteRows = value
		End Set
	End Property

	<DefaultValue(False)>
	Property AllowColumnReordering As Boolean
		Get
			Return dgv_Listeners.AllowUserToOrderColumns
		End Get
		Set(value As Boolean)
			dgv_Listeners.AllowUserToOrderColumns = value
		End Set
	End Property

	<DefaultValue(True)>
	Property ListenersSelectable As Boolean
		' TODO: Verify if I need this
		Get
			Return dgv_Listeners.Columns(1).Visible
		End Get
		Set(value As Boolean)
			dgv_Listeners.Columns(1).Visible = value
		End Set
	End Property

	Public Sub Reload() Handles cms_Tools.RefreshView
		If bw_LoadListeners.IsBusy Then
			Return
		End If

		UseWaitCursor = True
		bw_LoadListeners.RunWorkerAsync()
	End Sub

	Private Sub LoadListeners(sender As Object, e As DoWorkEventArgs) Handles bw_LoadListeners.DoWork
		Dim listeners = db_Listeners.GetListeners()
		_listeners.Clear()

		For Each listener In listeners
			_listeners.AddListenersRow(listener.Id, listener.Name, listener.Email)
		Next
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsListeners.DataSource = _listeners
	End Sub

	Private Sub ListenersLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadListeners.RunWorkerCompleted
		UseWaitCursor = False
		dgv_Listeners.Refresh()
	End Sub

	Private Sub RemoveListener(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
		Dim row As System.Data.DataRowView = CType(e.Row.DataBoundItem, System.Data.DataRowView)
		Dim deletedListener As DataTables.ListenersDataRow = CType(row.Row, DataTables.ListenersDataRow)
		Console.WriteLine(deletedListener)

		Confirmed = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed Then
			e.Cancel = True
			Return
		End If

		e.Row.Selected = True
		RemoveSelectedRows()
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			row.Selected = False
		Next
	End Sub

	Private Sub RemoveSelectedRows()
		Dim id As Integer = My.Settings.MinID - 1
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Listeners.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			Try
				id = DirectCast(row.Cells($"{dgcPrefix}ListenerID").Value, Integer)
				db_Listeners.RemoveListener(id)
				dgv_Listeners.Rows.Remove(row)
			Catch ex As Exception
				failed += 1
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} listener{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} listener{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		Reload()
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs)
		cms_Tools.ToggleRemove(dgv_Listeners.SelectedRows.Count > 0)
		cms_Tools.ToggleSend(dgv_Listeners.SelectedRows.Count > 0)
	End Sub

	Private Sub RemoveRowByToolStrip() Handles cms_Tools.RemoveRows
		If dgv_Listeners.SelectedRows.Count < 1 Then
			Return
		End If

		RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub

	Private Sub AddListener(sender As Object, e As EventArgs) Handles tbtn_AddListener.Click
		Using add = New Dialogs.AddListenerDialog
			If add.ShowDialog() = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub FilterChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
		Filter = txt_Filter.Text
	End Sub

	Private Sub ImportListeners(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Using import = New Dialogs.ImportListenersDialog()
			import.ShowDialog()

			If import.DialogResult = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellContentClick
		If e.ColumnIndex <> dgc_Edit.DisplayIndex AndAlso e.ColumnIndex <> dgc_Remove.DisplayIndex Then
			Return
		End If

		Dim row = dgv_Listeners.Rows(e.RowIndex)
		Dim cRow = CType(row.DataBoundItem, System.Data.DataRowView)
		Dim listenerRow = CType(cRow.Row, DataTables.ListenersDataRow)
		Dim listener = Types.Listener.Parse(listenerRow.ItemArray)

		Select Case e.ColumnIndex
			Case dgc_Edit.DisplayIndex
				Using edit As New Dialogs.EditListenerDialog() With {.Listener = listener}
					If edit.ShowDialog = DialogResult.OK Then
						Reload()
					End If
				End Using
			Case dgc_Remove.DisplayIndex
				ClearSelectedRows()
				RemoveListener(sender, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub

	Private Sub NewListenerAdded(sender As Object, e As ListenerAddedEvent) Handles AddDialog.ListenerAdded, ImportDialog.ListenerAdded
		RaiseEvent ListenerAdded(Me, e)
	End Sub

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles tbtn_Email.Click
		Using emails As New SendEmailsDialog
			Dim res = emails.ShowDialog()
		End Using
	End Sub
End Class
