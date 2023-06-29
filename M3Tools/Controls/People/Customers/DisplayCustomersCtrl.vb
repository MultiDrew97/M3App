Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Customers

Public Class DisplayCustomersCtrl
	ReadOnly countTemplate As String = "Count: {0}"
	Public Event AddCustomer As AddCustomerEventHandler
	Public Event EditCustomer As EditCustomerEventHandler

	Public Sub Reload() Handles ts_Refresh.Click, tbtn_Refresh.Click
		cdg_Customers.Reload()
		tsl_Count.Text = String.Format(countTemplate, cdg_Customers.Customers.Count)
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
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

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
		ts_Remove.Enabled = cdg_Customers.SelectedCustomers.Count > 0
	End Sub

	Private Sub ToolsClosed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cms_Tools.Closed
		ts_Remove.Enabled = False
	End Sub

	Private Sub NewCustomer(sender As Object, e As EventArgs) Handles tbtn_AddCustomer.Click
		RaiseEvent AddCustomer(Me)
		'Using newCustomer As New Dialogs.AddCustomerDialog()
		'	If newCustomer.ShowDialog() = DialogResult.OK Then
		'		Reload()
		'	End If
		'End Using
	End Sub

	Private Sub ImportCustomers(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Throw New Exceptions.NotYetImplementedException("Import Customers")
	End Sub

	Private Sub SendEdit(sender As Object, e As Events.Customers.CustomerEventArgs) Handles cdg_Customers.EditCustomer
		RaiseEvent EditCustomer(Me, e)
	End Sub
End Class
