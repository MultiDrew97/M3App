Imports SPPBC.M3Tools.Events.Customers
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class CustomersDataGrid
	Public Event EditCustomer As CustomerEventHandler
	Public Event RemoveCustomer As CustomerEventHandler

	Public ReadOnly Property SelectedRowsCount As Integer
		Get
			Return SelectedCustomers.Count
		End Get
	End Property

	Public ReadOnly Property Customers As IList
		Get
			Return DataSource.List '_customers.Customers
		End Get
	End Property

	Public Property DataSource As BindingSource
		Get
			Return CType(dgv_Customers.DataSource, BindingSource)
		End Get
		Set(value As BindingSource)
			dgv_Customers.DataSource = value
		End Set
	End Property

	Public ReadOnly Property SelectedCustomers As IList
		Get
			Dim list As New Types.CustomerCollection

			If chk_SelectAll.Checked Then
				Return bsCustomers.List
			End If

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
			Return dgc_Selection.Visible
		End Get
		Set(value As Boolean)
			dgc_Selection.Visible = value
			chk_SelectAll.Visible = value
		End Set
	End Property

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellContentClick
		If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
			Return
		End If

		Dim row = dgv_Customers.Rows(e.RowIndex)
		Dim customer = CType(row.DataBoundItem, Types.Customer)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				RaiseEvent EditCustomer(Me, New CustomerEventArgs(customer))
			Case dgc_Remove.DisplayIndex
				ClearSelectedRows()
				DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub

	Private Sub DeleteCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
		'Dim row As DataRowView = CType(e.Row.DataBoundItem, DataRowView)
		'Dim deletedCustomer As DataTables.CustomersDataRow = CType(row.Row, DataTables.CustomersDataRow)
		'Console.WriteLine(deletedCustomer)

		'Dim res = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		'If Not res = DialogResult.Yes Then
		'	e.Cancel = True
		'	Return
		'End If

		e.Row.Selected = True
		RemoveSelectedRows()
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
			row.Selected = False
		Next
	End Sub

	Public Sub RemoveSelectedRows()
		'Dim id As Integer = My.Settings.MinID - 1
		Dim customer As Types.Customer
		Dim failed As Integer = 0
		Dim total As Integer = dgv_Customers.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
			Try
				customer = CType(row.DataBoundItem, Types.Customer)
				RaiseEvent RemoveCustomer(Me, New CustomerEventArgs(customer))
				'dgv_Customers.Rows.Remove(row)
			Catch ex As Exception
				failed += 1
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub SelectAllCustomers(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
		For Each row As DataGridViewRow In dgv_Customers.Rows
			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
		Next
		dgv_Customers.Invalidate()
	End Sub
End Class
