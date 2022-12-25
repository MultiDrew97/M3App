Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayCustomersCtrl
	Private ReadOnly _customers As New DataTables.CustomersDataTable()
	Dim Confirmed As Boolean = False

	''' <summary>
	'''		Allow the user to add new customers from the datagrid view
	''' </summary>
	''' <returns></returns>
	<DefaultValue(False)>
	Public Property AllowUserAdd As Boolean
		Get
			Return dgv_CustomerTable.AllowUserToAddRows
		End Get
		Set(value As Boolean)
			dgv_CustomerTable.AllowUserToAddRows = value
		End Set
	End Property

	''' <summary>
	'''		Allow the user to delete customers from the datagrid view
	''' </summary>
	''' <returns></returns>
	<DefaultValue(True)>
	Public Property AllowUserDelete As Boolean
		Get
			Return dgv_CustomerTable.AllowUserToDeleteRows
		End Get
		Set(value As Boolean)
			dgv_CustomerTable.AllowUserToDeleteRows = value
		End Set
	End Property

	''' <summary>
	''' 
	''' </summary>
	''' <returns></returns>
	<DefaultValue(False)>
	Public Property AllowUserEdit As Boolean
		Get
			Return Not dgv_CustomerTable.ReadOnly
		End Get
		Set(value As Boolean)
			dgv_CustomerTable.ReadOnly = Not value
		End Set
	End Property

	Private Sub DisplayCustomersLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bs_Customers.DataSource = _customers
	End Sub

	Public Sub Reload() Handles ts_Refresh.Click, tbtn_Refresh.Click
		UseWaitCursor = True
		_customers.Clear()
		bw_LoadCustomers.RunWorkerAsync()
	End Sub

	Private Sub LoadCustomers(sender As Object, e As DoWorkEventArgs) Handles bw_LoadCustomers.DoWork
		Try
			Dim data As Types.DBEntryCollection(Of Types.Customer) = db_Customers.GetCustomers()

			For Each customer In data
				_customers.AddCustomersRow(customer.Id, customer.FirstName, customer.LastName, customer.Address?.ToString, customer.PhoneNumber, customer.Email, CDate(customer.Joined))
			Next
		Catch ex As Exception
			Console.Error.WriteLine(ex.Message)
		End Try
	End Sub

	Private Sub CustomersLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadCustomers.RunWorkerCompleted
		' TODO: Figure out why highlighted cell doesn't change properly
		UseWaitCursor = False
		dgv_CustomerTable.Refresh()
	End Sub

	Private Sub UserDeletingCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_CustomerTable.UserDeletingRow
		Confirmed = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed Or dgv_CustomerTable.SelectedRows.Count < 1 Then
			e.Cancel = True
			Return
		End If

		RemoveSelectedRows()
	End Sub

	Private Sub UserEditedCustomer(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CustomerTable.CellValueChanged
		' TODO: Check if still necessary

		If (e.RowIndex < 0) Then
			Return
		End If

		'get values from table
		Dim id As Integer = CInt(_customers.Rows(e.RowIndex)("CustomerID"))
		Dim column As String = dgv_CustomerTable.Columns(e.ColumnIndex).DataPropertyName
		Dim value As Object = dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

		Dim tableRow = _customers.Rows(e.RowIndex)

		If value.Equals(tableRow(column)) Then
			Return
		End If

		MessageBox.Show("A change has been detected", "Change Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		'Select Case column
		'	Case "FirstName", "LastName", "PhoneNumber"
		'		If Not String.IsNullOrWhiteSpace(value) Then
		'			db_Customers.UpdateCustomer(customerID, column, value)
		'		Else
		'			MessageBox.Show($"You must enter a value for {column}", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
		'		End If
		'	Case Else
		'		db_Customers.UpdateCustomer(customerID, column, value)
		'End Select

	End Sub

	Private Sub RemoveSelectedRows()
		Dim id As Integer
		Dim failed As Integer = 0
		Dim total As Integer = dgv_CustomerTable.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_CustomerTable.SelectedRows
			Try
				id = DirectCast(row.Cells.Item("CustomerID").Value, Integer)
				'_customers.RemoveCustomersRow(CType(CType(row.DataBoundItem, DataRowView).Row, DataTables.CustomersDataRow))
				db_Customers.RemoveCustomer(id)
			Catch
				failed += 1
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		Reload()
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		Confirmed = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed OrElse dgv_CustomerTable.SelectedRows.Count < 1 Then
			Return
		End If

		RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_CustomerTable.SelectedRows
			row.Selected = False
		Next
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		ts_Remove.Enabled = dgv_CustomerTable.SelectedRows.Count > 0
	End Sub

	Private Sub ToolsClosed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cms_Tools.Closed
		ts_Remove.Enabled = False
	End Sub

	Private Sub AddCustomer(sender As Object, e As EventArgs) Handles tbtn_AddCustomer.Click
		Using newCustomer As New Dialogs.AddCustomerDialog()
			If newCustomer.ShowDialog() = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub TableButtonClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CustomerTable.CellContentClick
		If Not e.ColumnIndex = btn_Edit.Index AndAlso Not e.ColumnIndex = btn_Delete.Index Then
			Return
		End If

		Dim row = dgv_CustomerTable.Rows(e.RowIndex)

		Select Case e.ColumnIndex
			Case btn_Edit.Index
				Dim customerID As Integer = CInt(row.Cells("CustomerID").Value)
				Console.WriteLine("Edit Pressed")
				Using editCustomer As New Dialogs.EditCustomerDialog() With {.CustomerID = customerID}
					If editCustomer.ShowDialog() = DialogResult.OK Then
						Reload()
					End If
				End Using
			Case btn_Delete.Index
				Console.WriteLine("Delete Pressed")
				ClearSelectedRows()
				row.Selected = True
				UserDeletingCustomer(sender, New DataGridViewRowCancelEventArgs(dgv_CustomerTable.Rows(e.RowIndex)))
		End Select
	End Sub
End Class
