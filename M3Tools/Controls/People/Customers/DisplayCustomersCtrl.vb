Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Customers

Public Class DisplayCustomersCtrl
	Public Event AddCustomer As CustomerEventHandler
	Public Event UpdateCustomer As CustomerEventHandler
	Public Event RemoveCustomer As CustomerEventHandler
	Public Event RefreshDisplay()

	Public Property CountTemplate As String

	Public Property DataSource As BindingSource
		Get
			Return cdg_Customers.DataSource
		End Get
		Set(value As BindingSource)
			cdg_Customers.DataSource = value
		End Set
	End Property

	Public Sub Reload()
		tsl_Count.Text = String.Format(CountTemplate, cdg_Customers.Customers.Count)
	End Sub

	Private Sub RefreshView() Handles cdg_Customers.RefreshDisplay
		RaiseEvent RefreshDisplay()
	End Sub

	Private Sub NewCustomer(sender As Object, e As EventArgs) Handles tbtn_AddCustomer.Click
		Using add As New Dialogs.AddCustomerDialog()
			Dim res = add.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent AddCustomer(Me, New CustomerEventArgs(add.Customer))
		End Using
	End Sub

	Private Sub FilterChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
		cdg_Customers.Filter = txt_Filter.Text
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs)
		Dim res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes OrElse cdg_Customers.SelectedCustomers.Count < 1 Then
			Return
		End If

		cdg_Customers.RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub



	Private Sub ImportCustomers(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Throw New NotImplementedException("Import Customers")
	End Sub

	Private Sub EditCustomer(sender As Object, e As CustomerEventArgs) Handles cdg_Customers.EditCustomer
		Using edit As New Dialogs.EditCustomerDialog() With {.Customer = e.Customer}
			Dim res = edit.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent UpdateCustomer(Me, New CustomerEventArgs(edit.NewInfo))
		End Using
	End Sub

	Private Sub DeleteCustomer(sender As Object, e As CustomerEventArgs) Handles cdg_Customers.RemoveCustomer
		Dim res = MessageBox.Show("Are you sure you want to remove this Customer?", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
			Return
		End If

		RaiseEvent RemoveCustomer(Me, New CustomerEventArgs(e.Customer))
	End Sub
End Class
