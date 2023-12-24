Imports SPPBC.M3Tools.Events
Imports SPPBC.M3Tools.Events.Listeners
Imports SPPBC.M3Tools.Types
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ListenersDataGrid
	Public Event EditListener As ListenerEventHandler
	Public Event RemoveListener As ListenerEventHandler
	Public Event RefreshDisplay()

	Public ReadOnly Property SelectedRowsCount As Integer
		Get
			Return SelectedListeners.Count
		End Get
	End Property

	Public ReadOnly Property Listeners As IList
		Get
			Return DataSource.List
		End Get
	End Property

	<Description("Data Source to use for data grid.")>
	Public Property DataSource As BindingSource
		Get
			Return CType(bsListeners.DataSource, BindingSource)
		End Get
		Set(value As BindingSource)
			bsListeners.DataSource = value
		End Set
	End Property

	Public ReadOnly Property SelectedListeners As IList
		Get
			' TODO: Simplify this later
			If ListenersSelectable Then
				If chk_SelectAll.Checked Then
					Return dgv_Listeners.Rows
				End If

				For Each row As DataGridViewRow In dgv_Listeners.Rows
					row.Selected = CBool(row.Cells(dgc_Selection.DisplayIndex).Value)
				Next
			End If

			Return dgv_Listeners.SelectedRows
		End Get
	End Property

	Property Filter As String
		Get
			Return DataSource.Filter
		End Get
		Set(value As String)
			'TODO: Fix bug and flesh out
			If value <> "" AndAlso Not (value.Contains("[") OrElse value.Contains("]")) Then
				DataSource.Filter = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
				Return
			End If

			DataSource.Filter = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowEditting As Boolean
		Get
			Return dgc_Edit.Visible
		End Get
		Set(value As Boolean)
			dgc_Edit.Visible = value
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
			Return dgc_Remove.Visible
		End Get
		Set(value As Boolean)
			dgc_Remove.Visible = value
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
			dgc_Selection.Visible = value
			chk_SelectAll.Visible = value
		End Set
	End Property

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellContentClick
		If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
			Return
		End If

		Dim row = dgv_Listeners.Rows(e.RowIndex)
		Dim listener = CType(row.DataBoundItem, Types.Listener)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				RaiseEvent EditListener(Me, New ListenerEventArgs(listener))
			Case dgc_Remove.Index
				DeleteListener(Me, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub

	Private Sub DeleteListener(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
		Dim listener = CType(e.Row.DataBoundItem, Types.Listener)

		RaiseEvent RemoveListener(Me, New ListenerEventArgs(listener, EventType.Deleted))
		MessageBox.Show($"Successfully removed listener", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Public Sub RemoveSelectedListeners() Handles cms_Tools.RemoveRows
		If SelectedRowsCount < 1 Then
			Return
		End If

		Dim failed As Integer = 0
		Dim total As Integer = dgv_Listeners.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			Try
				DeleteListener(Me, New DataGridViewRowCancelEventArgs(row))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
				failed += 1
				Exit Sub
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

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		cms_Tools.ToggleRemove(SelectedRowsCount > 0)
		cms_Tools.ToggleEdit(SelectedRowsCount > 0)
	End Sub

	Private Sub EditPerson() Handles cms_Tools.EditSelected
		If SelectedRowsCount < 1 Then
			Return
		End If

		For Each row As DataGridViewRow In SelectedListeners
			CellClicked(Me, New DataGridViewCellEventArgs(dgc_Edit.Index, row.Index))
		Next
	End Sub

	Private Sub RefreshView() Handles cms_Tools.RefreshView
		RaiseEvent RefreshDisplay()
	End Sub
End Class
