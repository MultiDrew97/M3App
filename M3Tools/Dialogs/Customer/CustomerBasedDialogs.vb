Imports System.Windows.Forms

Public Class CustomerBasedDialogs
	Public Function AddCustomer() As DialogResult
		Return (New Dialogs.AddCustomerDialog()).ShowDialog
	End Function

	Public Function EditCustomer(customer As Types.Customer) As DialogResult
		Return (New Dialogs.EditCustomerDialog() With {.Customer = customer}).ShowDialog
	End Function
End Class
