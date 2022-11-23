Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayCustomersCtrl
	Private ReadOnly _customers As New DataTables.CustomersDataTable()

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
	<DefaultValue(True)>
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

	Public Sub Reload() Handles ts_Refresh.Click
		UseWaitCursor = True
		bw_LoadCustomers.RunWorkerAsync()
	End Sub

	Private Sub LoadCustomers(sender As Object, e As DoWorkEventArgs) Handles bw_LoadCustomers.DoWork
		Try
			Dim customers = db_Customers.GetCustomers()
			_customers.Clear()

			For Each customer In customers
				_customers.AddCustomersRow(customer.Id, customer.FirstName, customer.LastName, customer.Address, customer.PhoneNumber, customer.Email, customer.Joined)
			Next
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
	End Sub

	Private Sub UserDeletingCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_CustomerTable.UserDeletingRow
		If MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			Dim id As Integer = CInt(CType(dgv_CustomerTable.Rows(e.Row.Index).DataBoundItem, DataRowView)("CustomerID"))

			RemoveCustomer()
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub UserEditedCustomer(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CustomerTable.CellValueChanged
		If (e.RowIndex < 0) Then
			Return
		End If
		Console.WriteLine(dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
		' TODO: Improve for customer data modifications
		'get values from table
		Dim column As String = dgv_CustomerTable.Columns(e.ColumnIndex).DataPropertyName
		Dim value As String = If(dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).FormattedValue IsNot DBNull.Value, dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString()
		Dim customerID As Integer = CInt(_customers.Rows(e.RowIndex)("CustomerID"))

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

	Private Sub RemoveCustomer()
		' TODO: Flesh this out
		Try
			'db_Customers.RemoveCustomer()
		Catch
			MessageBox.Show("Failed to remove customer", "Couldn't Remove", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		For Each row As DataGridViewRow In dgv_CustomerTable.SelectedRows
			If row.Selected Then
				UserDeletingCustomer(sender, New DataGridViewRowCancelEventArgs(row))
			End If
		Next
	End Sub

	Private Sub DoneLoadingCustomers(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadCustomers.RunWorkerCompleted
		UseWaitCursor = False
		dgv_CustomerTable.Refresh()
	End Sub

	Private Sub ClearSelectedRows()
		For Each row As DataGridViewRow In dgv_CustomerTable.SelectedRows
			row.Selected = False
		Next
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		ts_Remove.Enabled = dgv_CustomerTable.SelectedRows.Count > 0
	End Sub
End Class
