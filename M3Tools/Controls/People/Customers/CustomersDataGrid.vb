Imports SPPBC.M3Tools.Events
Imports SPPBC.M3Tools.Events.Customers
Imports System.ComponentModel
Imports System.Windows.Forms

' TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
Public Class CustomersDataGrid
	Inherits DataGridView
	Public Event EditCustomer As CustomerEventHandler
	Public Event RemoveCustomer As CustomerEventHandler
	Public Event RefreshDisplay()

	'<Browsable(False)>
	'Public ReadOnly Property SelectedRowsCount As Integer
	'	Get
	'		Return SelectedRows.Count
	'	End Get
	'End Property

	<Browsable(False)>
	Public ReadOnly Property Customers As IList
		Get
			Return Rows
		End Get
	End Property

	'<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	'<DefaultValue(GetType(BindingSource))>
	<RefreshProperties(RefreshProperties.Repaint)>
	<AttributeProvider(GetType(IListSource))>
	<Description("Data Source to use for data grid.")>
	Public Shadows Property DataSource As BindingSource
		Get
			Return bsCustomers
		End Get
		Set(value As BindingSource)
			AutoGenerateColumns = False
			bsCustomers = CType(value, Types.CustomersBindingSource)
		End Set
	End Property

	<Browsable(False)>
	Public Shadows ReadOnly Property SelectedRows As IList
		Get
			If CustomersSelectable Then
				If chk_SelectAll.Checked Then
					Return Rows
				End If

				For Each row As DataGridViewRow In Rows
					row.Selected = CBool(row.Cells(dgc_Selection.DisplayIndex).Value)
				Next
			End If



			Return MyBase.SelectedRows
		End Get
	End Property

	'<DefaultValue("")>
	'Property Filter As String
	'	Get
	'		Return DataSource?.Filter
	'	End Get
	'	Set(value As String)
	'		DataSource.Filter = value
	'	End Set
	'End Property

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
			Return AllowUserToAddRows
		End Get
		Set(value As Boolean)
			AllowUserToAddRows = value
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
			Return AllowUserToOrderColumns
		End Get
		Set(value As Boolean)
			AllowUserToOrderColumns = value
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

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles Me.CellContentClick
		If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
			Return
		End If

		Dim row = Rows(e.RowIndex)
		Dim customer = CType(row.DataBoundItem, Types.Customer)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				RaiseEvent EditCustomer(Me, New CustomerEventArgs(customer, EventType.Updated))
			Case dgc_Remove.DisplayIndex
				DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub

	Private Sub DeleteCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles Me.UserDeletingRow
		Dim customer = CType(e.Row.DataBoundItem, Types.Customer)

		RaiseEvent RemoveCustomer(Me, New CustomerEventArgs(customer, EventType.Deleted))
	End Sub

	Public Sub RemoveSelectedRows() Handles cms_Tools.RemoveRows
		If SelectedRows.Count < 1 Then
			Return
		End If

		Dim failed As Integer = 0
		Dim total As Integer = SelectedRows.Count

		For Each row As DataGridViewRow In SelectedRows
			Try
				DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
				failed += 1
				Continue For
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
		For Each row As DataGridViewRow In Rows
			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
		Next
		Invalidate()
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		cms_Tools.ToggleRemove(SelectedRows.Count > 0)
		cms_Tools.ToggleEdit(SelectedRows.Count > 0)
	End Sub

	Private Sub EditPerson() Handles cms_Tools.EditSelected
		If SelectedRows.Count < 1 Then
			Return
		End If

		For Each row As DataGridViewRow In SelectedRows
			CellClicked(Me, New DataGridViewCellEventArgs(dgc_Edit.Index, row.Index))
		Next
	End Sub

	Private Sub RefreshView() Handles cms_Tools.RefreshView
		Refresh()
	End Sub
End Class
'Public Class CustomersDataGrid
'	Inherits DataGridView
'	Public Event EditCustomer As CustomerEventHandler
'	Public Event RemoveCustomer As CustomerEventHandler
'	Public Event RefreshDisplay()

'	<Browsable(False)>
'	Public ReadOnly Property SelectedRowsCount As Integer
'		Get
'			Return SelectedCustomers.Count
'		End Get
'	End Property

'	<Browsable(False)>
'	Public ReadOnly Property Customers As IList
'		Get
'			Return Rows
'		End Get
'	End Property

'	'<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
'	'<DefaultValue(GetType(BindingSource))>
'	<RefreshProperties(RefreshProperties.Repaint)>
'	<AttributeProvider(GetType(IListSource))>
'	<Description("Data Source to use for data grid.")>
'	Public Shadows Property DataSource As BindingSource
'		Get
'			Return CType(dgv_Customers.DataSource, BindingSource)
'		End Get
'		Set(value As BindingSource)
'			Me.AutoGenerateColumns = False
'			MyBase.DataSource = value
'			'dgv_Customers.Refresh()
'		End Set
'	End Property

'	<Browsable(False)>
'	Public ReadOnly Property SelectedCustomers As IList
'		Get
'			If CustomersSelectable Then
'				If chk_SelectAll.Checked Then
'					Return dgv_Customers.Rows
'				End If

'				For Each row As DataGridViewRow In dgv_Customers.Rows
'					row.Selected = CBool(row.Cells(dgc_Selection.DisplayIndex).Value)
'				Next
'			End If

'			Return dgv_Customers.SelectedRows
'		End Get
'	End Property

'	'<DefaultValue("")>
'	'Property Filter As String
'	'	Get
'	'		Return DataSource?.Filter
'	'	End Get
'	'	Set(value As String)
'	'		DataSource.Filter = value
'	'	End Set
'	'End Property

'	<DefaultValue(True)>
'	Property AllowEditting As Boolean
'		Get
'			Return dgc_Edit.Visible
'		End Get
'		Set(value As Boolean)
'			dgc_Edit.Visible = value
'		End Set
'	End Property

'	<DefaultValue(False)>
'	Property AllowAdding As Boolean
'		Get
'			Return dgv_Customers.AllowUserToAddRows
'		End Get
'		Set(value As Boolean)
'			dgv_Customers.AllowUserToAddRows = value
'		End Set
'	End Property

'	<DefaultValue(True)>
'	Property AllowDeleting As Boolean
'		Get
'			Return dgc_Remove.Visible
'		End Get
'		Set(value As Boolean)
'			dgc_Remove.Visible = value
'		End Set
'	End Property

'	<DefaultValue(False)>
'	Property AllowColumnReordering As Boolean
'		Get
'			Return dgv_Customers.AllowUserToOrderColumns
'		End Get
'		Set(value As Boolean)
'			dgv_Customers.AllowUserToOrderColumns = value
'		End Set
'	End Property

'	<DefaultValue(True)>
'	Property CustomersSelectable As Boolean
'		Get
'			Return dgc_Selection.Visible
'		End Get
'		Set(value As Boolean)
'			dgc_Selection.Visible = value
'			chk_SelectAll.Visible = value
'		End Set
'	End Property

'	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellContentClick
'		If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
'			Return
'		End If

'		Dim row = dgv_Customers.Rows(e.RowIndex)
'		Dim customer = CType(row.DataBoundItem, Types.Customer)

'		Select Case e.ColumnIndex
'			Case dgc_Edit.Index
'				RaiseEvent EditCustomer(Me, New CustomerEventArgs(customer, EventType.Updated))
'			Case dgc_Remove.DisplayIndex
'				DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
'		End Select
'	End Sub

'	Private Sub DeleteCustomer(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
'		Dim customer = CType(e.Row.DataBoundItem, Types.Customer)

'		RaiseEvent RemoveCustomer(Me, New CustomerEventArgs(customer, EventType.Deleted))
'	End Sub

'	Public Sub RemoveSelectedRows() Handles cms_Tools.RemoveRows
'		If SelectedRowsCount < 1 Then
'			Return
'		End If

'		Dim failed As Integer = 0
'		Dim total As Integer = dgv_Customers.SelectedRows.Count

'		For Each row As DataGridViewRow In dgv_Customers.SelectedRows
'			Try
'				DeleteCustomer(Me, New DataGridViewRowCancelEventArgs(row))
'			Catch ex As Exception
'				Console.WriteLine(ex.Message)
'				failed += 1
'				Continue For
'			End Try
'		Next

'		If failed > 0 Then
'			MessageBox.Show($"Failed to remove {failed} customer{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
'		End If

'		If total - failed > 0 Then
'			MessageBox.Show($"Successfully removed {total - failed} customer{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
'		End If
'	End Sub

'	Private Sub SelectAllCustomers(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
'		For Each row As DataGridViewRow In dgv_Customers.Rows
'			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
'		Next
'		dgv_Customers.Invalidate()
'	End Sub

'	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
'		cms_Tools.ToggleRemove(SelectedRowsCount > 0)
'		cms_Tools.ToggleEdit(SelectedRowsCount > 0)
'	End Sub

'	Private Sub EditPerson() Handles cms_Tools.EditSelected
'		If SelectedRowsCount < 1 Then
'			Return
'		End If

'		For Each row As DataGridViewRow In SelectedCustomers
'			CellClicked(Me, New DataGridViewCellEventArgs(dgc_Edit.Index, row.Index))
'		Next
'	End Sub

'	Private Sub RefreshView() Handles cms_Tools.RefreshView
'		RaiseEvent RefreshDisplay()
'	End Sub
'End Class
