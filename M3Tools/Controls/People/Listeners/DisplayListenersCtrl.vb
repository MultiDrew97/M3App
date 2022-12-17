Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayListenersCtrl
	Private Confirmed As Boolean = False

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

	Private Sub Reload(sender As Object, e As EventArgs)
		UseWaitCursor = True
		bw_LoadListeners.RunWorkerAsync()
	End Sub

	Private Sub LoadListeners(sender As Object, e As DoWorkEventArgs) Handles bw_LoadListeners.DoWork
		Dim listeners = db_Listeners.GetListeners()
		bsListeners.Clear()

		For Each listener In listeners
			bsListeners.Add(listener)
		Next
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load

	End Sub

	Private Sub ListenersLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadListeners.RunWorkerCompleted
		UseWaitCursor = False
	End Sub

	Private Sub RemoveListener(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
		Dim deletedListener = CType(e.Row.DataBoundItem, Types.Listener)
		Console.WriteLine(deletedListener.ToString)

		Confirmed = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed Or dgv_Listeners.SelectedRows.Count < 1 Then
			e.Cancel = True
			Return
		End If

		ClearSelectedRows()
		e.Row.Selected = True
		RemoveSelectedRows()
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			row.Selected = False
		Next
	End Sub

	Private Sub RemoveSelectedRows()
		Dim id As Integer
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Listeners.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Listeners.SelectedRows
			Try
				id = DirectCast(row.Cells.Item("CustomerID").Value, Integer)
				db_Listeners.RemoveListener(id)
			Catch
				failed += 1
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub
End Class
