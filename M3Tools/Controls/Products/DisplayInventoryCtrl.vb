Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Inventory

Public Class DisplayInventoryCtrl
	Public Event AddProduct As InventoryEventHandler
	Public Event UpdateProduct As InventoryEventHandler
	Public Event RemoveProduct As InventoryEventHandler
	Public Event RefreshDisplay()

	Public Property CountTemplate As String

	Public Property DataSource As BindingSource
		Get
			Return idg_Inventory.DataSource
		End Get
		Set(value As BindingSource)
			idg_Inventory.DataSource = value
		End Set
	End Property

	Public Sub Reload()
		tsl_Count.Text = String.Format(CountTemplate, idg_Inventory.Products.Count)
	End Sub

	Private Sub RefreshView() Handles idg_Inventory.RefreshDisplay
		RaiseEvent RefreshDisplay()
	End Sub

	Private Sub FilterChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
		idg_Inventory.Filter = txt_Filter.Text
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs)
		Dim res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If idg_Inventory.SelectedProducts.Count < 1 OrElse Not res = DialogResult.Yes Then
			Return
		End If

		idg_Inventory.RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub

	Private Sub EditProduct(sender As Object, e As InventoryEventArgs) Handles idg_Inventory.EditProduct
		Using edit As New Dialogs.EditProductDialog() With {.Product = e.Product}
			Dim res = edit.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent UpdateProduct(Me, New InventoryEventArgs(edit.NewInfo))
		End Using
	End Sub

	Private Sub DeleteProduct(sender As Object, e As InventoryEventArgs) Handles idg_Inventory.RemoveProduct
		Dim res = MessageBox.Show("Are you sure you want to remove this product?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
			Return
		End If

		RaiseEvent RemoveProduct(Me, e)
	End Sub
	Private Sub NewItem(sender As Object, e As EventArgs) Handles tbtn_AddCustomer.Click
		Using add As New Dialogs.AddProductDialog()
			Dim res = add.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent AddProduct(Me, New InventoryEventArgs(add.Product))
		End Using
	End Sub

	Private Sub ImportItem(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Throw New NotImplementedException("ImportItem")
	End Sub
End Class
