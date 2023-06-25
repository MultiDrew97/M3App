Imports SPPBC.M3Tools.Events
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class CustomersDataGrid
	Private ReadOnly _customers As New DataTables.CustomersDataTable
	Private ReadOnly dgcPrefix As String = "dgc_"

	Public ReadOnly Property SelectedRowsCount As Integer
		Get
			Dim count = 0

			For Each row As DataGridViewRow In dgv_Customers.Rows
				If Not CBool(row.Cells(dgc_Selection.Index).Value) Then
					Continue For
				End If

				count += 1
			Next

			Return count
		End Get
	End Property

	Public ReadOnly Property Customers As Types.CustomerCollection
		Get
			Return _customers.Customers
		End Get
	End Property

	Public ReadOnly Property SelectedCustomers As Types.CustomerCollection
		Get
			Dim list As New Types.CustomerCollection

			For Each row As DataGridViewRow In dgv_Customers.Rows
				If Not CBool(row.Cells(dgc_Selection.DisplayIndex).Value) Then
					Continue For
				End If

				Dim drv = CType(row.DataBoundItem, DataRowView)
				Dim ldr = CType(drv.Row, DataTables.CustomersDataRow)

				list.Add(ldr.Customer)
			Next

			Return list
		End Get
	End Property

	Property Filter As String
		Get
			Return bsCustomers.Filter
		End Get
		Set(value As String)
			If value <> "" Then
				bsCustomers.Filter = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
				Return
			End If

			bsCustomers.Filter = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowEditting As Boolean
		Get
			Return dgv_Customers.Columns(dgc_Edit.DisplayIndex).Visible
		End Get
		Set(value As Boolean)
			dgv_Customers.Columns(dgc_Edit.DisplayIndex).Visible = value
		End Set
	End Property

	<DefaultValue(False)>
	Property AllowAdding As Boolean
		Get
			Return dgv_Customers.AllowUserToAddRows
		End Get
		Set(value As Boolean)
			dgv_Customers.AllowUserToAddRows = value
		End Set
	End Property

	<DefaultValue(True)>
	Property AllowDeleting As Boolean
		Get
			Return dgv_Customers.Columns(dgc_Remove.DisplayIndex).Visible
		End Get
		Set(value As Boolean)
			dgv_Customers.Columns(dgc_Remove.DisplayIndex).Visible = value
		End Set
	End Property

	<DefaultValue(False)>
	Property AllowColumnReordering As Boolean
		Get
			Return dgv_Customers.AllowUserToOrderColumns
		End Get
		Set(value As Boolean)
			dgv_Customers.AllowUserToOrderColumns = value
		End Set
	End Property

	<DefaultValue(True)>
	Property CustomersSelectable As Boolean
		Get
			Return dgv_Customers.Columns(dgc_Selection.DisplayIndex).Visible
		End Get
		Set(value As Boolean)
			dgv_Customers.Columns(dgc_Selection.DisplayIndex).Visible = value
			chk_SelectAll.Visible = value
		End Set
	End Property

	Public Sub Reload()
		UseWaitCursor = True
		' TODO: Immitate FileUpload structure and do to ListenersDataGrid
		_customers.Clear()
		_customers.AddRange(db_Customers.GetCustomers())
		UseWaitCursor = False
	End Sub

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellContentClick
		If e.ColumnIndex <> dgc_Edit.DisplayIndex AndAlso e.ColumnIndex <> dgc_Remove.DisplayIndex Then
			Return
		End If

		Dim row = dgv_Customers.Rows(e.RowIndex)
		Dim cRow = CType(row.DataBoundItem, DataRowView)
		Dim customerRow = CType(cRow.Row, DataTables.CustomersDataRow)
		Dim customer = Types.Customer.Parse(customerRow.ItemArray)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				Using edit As New Dialogs.EditCustomerDialog() With {.Customer = customer}
					If edit.ShowDialog = DialogResult.OK Then
						Reload()
					End If
				End Using
			Case dgc_Remove.Index
				ClearSelectedRows()
				RemoveCustomer(sender, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub
	Private Sub RemoveCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
		Dim row As DataRowView = CType(e.Row.DataBoundItem, DataRowView)
		Dim deletedCustomer As DataTables.CustomersDataRow = CType(row.Row, DataTables.CustomersDataRow)
		Console.WriteLine(deletedCustomer)

		Dim res = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
			e.Cancel = True
			Return
		End If

		e.Row.Selected = True
		RemoveSelectedRows()
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
			row.Selected = False
		Next
	End Sub

	Public Sub RemoveSelectedRows()
		Dim id As Integer = My.Settings.MinID - 1
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Customers.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
			Try
				id = DirectCast(row.Cells($"{dgcPrefix}ListenerID").Value, Integer)
				db_Customers.RemoveCustomer(id)
				dgv_Customers.Rows.Remove(row)
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

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsCustomers.DataSource = _customers
	End Sub

	Private Sub SelectAllCustomers(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
		For Each row As DataGridViewRow In dgv_Customers.Rows
			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
		Next
		dgv_Customers.Invalidate()
	End Sub
End Class
