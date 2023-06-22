Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayCustomersCtrl
	Dim Confirmed As Boolean = False

	Public Sub Reload() Handles ts_Refresh.Click, tbtn_Refresh.Click
		cdg_Customers.Reload()
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		Confirmed = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed OrElse cdg_Customers.SelectedCustomers.Count < 1 Then
			Return
		End If

		cdg_Customers.RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		ts_Remove.Enabled = cdg_Customers.SelectedCustomers.Count > 0
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
End Class
