Imports SPPBC.M3Tools.Events.Listeners
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ListenersDataGrid
	Public Event EditListener As ListenerEventHandler
	Public Event RemoveListener As ListenerEventHandler

	Public ReadOnly Property SelectedRowsCount As Integer
		Get
			Return SelectedListeners.Count
		End Get
	End Property

	Public ReadOnly Property Listeners As IList
		Get
			Return DataSource.List '_listeners.Listeners
		End Get
	End Property

	<Description("Data Source to use for Data Grid")>
	Public Property DataSource As BindingSource
		Get
			Return CType(dgv_Listeners.DataSource, BindingSource)
		End Get
		Set(value As BindingSource)
			dgv_Listeners.DataSource = value
		End Set
	End Property

	Public ReadOnly Property SelectedListeners As Types.ListenerCollection
		Get
			Dim list As New Types.ListenerCollection

			For Each row As DataGridViewRow In dgv_Listeners.Rows
				If Not CBool(row.Cells(dgc_Selection.DisplayIndex).Value) Then
					Continue For
				End If

				Dim drv = CType(row.DataBoundItem, DataRowView)
				Dim ldr = CType(drv.Row, DataTables.ListenersDataRow)

				list.Add(ldr.Listener)
			Next

			Return list
		End Get
	End Property

	Property Filter As String
		Get
			Return bsListeners.Filter
		End Get
		Set(value As String)
			'TODO: Figure out how I want to do this
			If value <> "" AndAlso Not (value.Contains("[") OrElse value.Contains("]")) Then
				bsListeners.Filter = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
				Return
			End If

			bsListeners.Filter = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowEditting As Boolean
		Get
			Return dgv_Listeners.Columns(dgc_Edit.DisplayIndex).Visible
		End Get
		Set(value As Boolean)
			dgv_Listeners.Columns(dgc_Edit.DisplayIndex).Visible = value
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
			Return dgv_Listeners.Columns(dgc_Remove.DisplayIndex).Visible
		End Get
		Set(value As Boolean)
			dgv_Listeners.Columns(dgc_Remove.DisplayIndex).Visible = value
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
		Get
			Return dgc_Selection.Visible
		End Get
		Set(value As Boolean)
			'dgv_Listeners.Columns(dgc_Selection.Index).Visible = value
			dgc_Selection.Visible = value
			chk_SelectAll.Visible = value
		End Set
	End Property

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellContentClick
		If e.ColumnIndex <> dgc_Edit.DisplayIndex AndAlso e.ColumnIndex <> dgc_Remove.DisplayIndex Then
			Return
		End If

		Dim row = dgv_Listeners.Rows(e.RowIndex)
		Dim listener = CType(row.DataBoundItem, Types.Listener)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				RaiseEvent EditListener(Me, New ListenerEventArgs(listener))
				'Using edit As New Dialogs.EditListenerDialog() With {.Listener = listener}
				'	If edit.ShowDialog = DialogResult.OK Then
				'		Reload()
				'	End If
				'End Using
			Case dgc_Remove.Index
				ClearSelectedRows()
				DeleteListener(sender, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub
	Private Sub DeleteListener(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
		'Dim row As DataRowView = CType(e.Row.DataBoundItem, DataRowView)
		'Dim deletedListener As DataTables.ListenersDataRow = CType(row.Row, DataTables.ListenersDataRow)
		'Console.WriteLine(deletedListener)

		Dim res = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
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

	Public Sub RemoveSelectedRows()
		'Dim id As Integer = My.Settings.MinID - 1
		Dim listener As Types.Listener
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Listeners.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			Try
				listener = CType(row.DataBoundItem, Types.Listener)
				RaiseEvent RemoveListener(Me, New ListenerEventArgs(listener)) 'db_Listeners.RemoveListener(id)
				'DataSource.Remove(listener)
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
	End Sub

	Private Sub SelectAllListeners(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
		For Each row As DataGridViewRow In dgv_Listeners.Rows
			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
		Next
		dgv_Listeners.Invalidate()
	End Sub
End Class
