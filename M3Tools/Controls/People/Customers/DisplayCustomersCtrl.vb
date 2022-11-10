Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayCustomersCtrl
	Private ReadOnly _customers As New DataTables.CustomersDataTable()

	''' <summary>
	'''		Allow the user to add new customers from the datagrid view
	''' </summary>
	''' <returns></returns>
	<DefaultValue(True)>
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

	'Sub New()
	'	' This call is required by the designer.
	'	InitializeComponent()

	'	' Add any initialization after the InitializeComponent() call.

	'End Sub

	Sub Reload()
		UseWaitCursor = True
		bw_LoadCustomers.RunWorkerAsync()
	End Sub

	Private Sub RefreshToolClicked(sender As Object, e As EventArgs) Handles ts_Refresh.Click
		Reload()
	End Sub

	Private Sub LoadCustomers(sender As Object, e As DoWorkEventArgs) Handles bw_LoadCustomers.DoWork
		Dim customers = db_Customers.GetCustomers()
		_customers.Clear()

		For Each customer In customers
			_customers.AddCustomersRow(customer.Id, customer.FirstName, customer.LastName, customer.Address.Street, customer.Address.City,
						customer.Address.State, customer.Address.ZipCode, customer.PhoneNumber, customer.EmailAddress, Date.Parse(customer.JoinDate))
		Next
	End Sub

	Private Sub UserDeletingCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_CustomerTable.UserDeletingRow
		If MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			Dim id As Integer = CInt(CType(dgv_CustomerTable.Rows(e.Row.Index).DataBoundItem, DataRowView)("CustomerID"))
			Try
				db_Customers.RemoveCustomer(id)
			Catch
				MessageBox.Show("Failed to remove customer", "Couldn't Remove", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub UserEditedCustomer(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CustomerTable.CellEndEdit
		'get values from table
		Dim column As String = dgv_CustomerTable.Columns(e.ColumnIndex).DataPropertyName
		Dim value As String = If(dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot DBNull.Value, dgv_CustomerTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString()
		Dim customerID As Integer = CInt(_customers.Rows(e.RowIndex)("CustomerID"))

		Select Case column
			Case "FirstName", "LastName", "PhoneNumber"
				If Not String.IsNullOrWhiteSpace(value) Then
					db_Customers.UpdateCustomer(customerID, column, value)
				Else
					MessageBox.Show("You must enter AddressOf value for this field", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			Case Else
				db_Customers.UpdateCustomer(customerID, column, value)
		End Select

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
	End Sub
	'Private Sub Dgv_Customers_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_CustomerTable.MouseClick
	'	ClearSelectedRows()

	'	If e.Button = MouseButtons.Right Then
	'		Dim info As DataGridView.HitTestInfo = dgv_CustomerTable.HitTest(e.X, e.Y)
	'		ts_Remove.Enabled = info.RowIndex > -1

	'		If info.RowIndex > -1 Then
	'			dgv_CustomerTable.Rows(info.RowIndex).Selected = True
	'		End If
	'	End If
	'End Sub

	Private Sub ClearSelectedRows()
		For Each cell As DataGridViewCell In dgv_CustomerTable.SelectedCells
			cell.Selected = False
		Next
	End Sub

	Private Sub DisplayCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
		bs_Customers.DataSource = _customers
		Reload()
	End Sub

	Private Sub dgv_CustomerTable_DataMemberChanged(sender As Object, e As EventArgs) Handles dgv_CustomerTable.DataMemberChanged
		Console.WriteLine("Data Member Changed")
	End Sub

	Private Sub dgv_CustomerTable_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_CustomerTable.DataSourceChanged
		Console.WriteLine("Data Source Changed")
	End Sub
End Class
