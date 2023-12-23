Imports SPPBC.M3Tools.Events.Inventory
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class InventoryDataGrid
	Public Event EditProduct As InventoryEventHandler
	Public Event RemoveProduct As InventoryEventHandler
	Public Event RefreshDisplay()

	Public ReadOnly Property SelectedRowsCount As Integer
		Get
			Return SelectedProducts.Count
		End Get
	End Property

	Public ReadOnly Property Products As IList
		Get
			Return DataSource.List
		End Get
	End Property

	Public Property DataSource As BindingSource
		Get
			Return CType(dgv_Inventory.DataSource, BindingSource)
		End Get
		Set(value As BindingSource)
			dgv_Inventory.AutoGenerateColumns = False
			dgv_Inventory.DataSource = value
		End Set
	End Property

	Public ReadOnly Property SelectedProducts As IList
		Get
			If InventorySelectable Then
				If chk_SelectAll.Checked Then
					Return dgv_Inventory.Rows
				End If

				For Each row As DataGridViewRow In dgv_Inventory.Rows
					If Not CBool(row.Cells(dgc_Selection.DisplayIndex).Value) Then
						row.Selected = False
						Continue For
					End If

					row.Selected = True
				Next
			End If

			Return dgv_Inventory.SelectedRows
		End Get
	End Property

	<DefaultValue("")>
	Property Filter As String
		Get
			Return DataSource.Filter
		End Get
		Set(value As String)
			' TODO: Fix bug and flesh out
			If value <> "" Then
				DataSource.Filter = $"([FirstName] like '%{value}%') OR ([LastName] like '%${value}%') OR ([Email] like '%{value}%')"
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
			Return dgv_Inventory.AllowUserToAddRows
		End Get
		Set(value As Boolean)
			dgv_Inventory.AllowUserToAddRows = value
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
			Return dgv_Inventory.AllowUserToOrderColumns
		End Get
		Set(value As Boolean)
			dgv_Inventory.AllowUserToOrderColumns = value
		End Set
	End Property

	<DefaultValue(True)>
	Property InventorySelectable As Boolean
		Get
			Return dgc_Selection.Visible
		End Get
		Set(value As Boolean)
			dgc_Selection.Visible = value
			chk_SelectAll.Visible = value
		End Set
	End Property

	Private Sub CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellContentClick
		If e.ColumnIndex <> dgc_Edit.Index AndAlso e.ColumnIndex <> dgc_Remove.Index Then
			Return
		End If

		Dim row = dgv_Inventory.Rows(e.RowIndex)
		Dim product = CType(row.DataBoundItem, Types.Product)

		Select Case e.ColumnIndex
			Case dgc_Edit.Index
				RaiseEvent EditProduct(Me, New InventoryEventArgs(product))
			Case dgc_Remove.Index
				DeleteProduct(Me, New DataGridViewRowCancelEventArgs(row))
		End Select
	End Sub

	Private Sub DeleteProduct(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
		Dim product = CType(e.Row.DataBoundItem, Types.Product)

		RaiseEvent RemoveProduct(Me, New InventoryEventArgs(product))
	End Sub

	Public Sub RemoveSelectedRows() Handles cms_Tools.RemoveRows
		If SelectedRowsCount < 1 Then
			Return
		End If

		Dim failed As Integer = 0
		Dim total As Integer = dgv_Inventory.SelectedRows.Count

		For Each row As DataGridViewRow In dgv_Inventory.SelectedRows
			Try
				DeleteProduct(Me, New DataGridViewRowCancelEventArgs(row))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
				failed += 1
				Continue For
			End Try
		Next

		If failed > 0 Then
			MessageBox.Show($"Failed to remove {failed} product{If(failed > 1, "s", "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If total - failed > 0 Then
			MessageBox.Show($"Successfully removed {total - failed} product{If(total - failed > 1, "s", "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub SelectAllProducts(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
		For Each row As DataGridViewRow In dgv_Inventory.Rows
			row.Cells(dgc_Selection.DisplayIndex).Value = chk_SelectAll.Checked
		Next

		dgv_Inventory.Invalidate()
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		cms_Tools.ToggleRemove(SelectedRowsCount > 0)
		cms_Tools.ToggleEdit(SelectedRowsCount > 0)
	End Sub

	Private Sub EditPerson() Handles cms_Tools.EditSelected
		If SelectedRowsCount < 1 Then
			Return
		End If

		For Each row As DataGridViewRow In SelectedProducts
			CellClicked(Me, New DataGridViewCellEventArgs(dgc_Edit.Index, row.Index))
		Next
	End Sub

	Private Sub RefreshView() Handles cms_Tools.RefreshView
		RaiseEvent RefreshDisplay()
	End Sub
End Class
