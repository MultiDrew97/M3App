Imports System.ComponentModel

Public Class CustomersComboBox
	Public Event LoadBegin()
	Public Event LoadEnd()
	Public Event SelectedItemChanged(newValue As Integer)

	Public Property SelectedItem As Object
		Get
			Return cbx_Items.SelectedItem
		End Get
		Set(value As Object)
			If value Is Nothing Then
				Return
			End If

			cbx_Items.SelectedItem = value
		End Set
	End Property

	Public Property SelectedIndex As Integer
		Get
			Return cbx_Items.SelectedIndex
		End Get
		Set(value As Integer)
			If value < 0 Then
				Return
			End If

			cbx_Items.SelectedIndex = value
		End Set
	End Property

	Public Property SelectedValue As Object
		Get
			Return cbx_Items.SelectedValue
		End Get
		Set(value As Object)
			If value Is Nothing Then
				Return
			End If

			cbx_Items.SelectedValue = value
		End Set
	End Property

	Private Sub LoadItems(sender As Object, e As DoWorkEventArgs) Handles bw_LoadItems.DoWork
		RaiseEvent LoadBegin()
		Try
			bsCustomers.Clear()
		Catch

		End Try

		For Each customer In db_Customers.GetCustomers
			bsCustomers.Add(customer)
		Next
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		'bsItems.DataSource = _items
	End Sub

	Private Sub ItemsLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadItems.RunWorkerCompleted
		bsCustomers.ResetBindings(False)
		RaiseEvent LoadEnd()
	End Sub

	Public Sub Reload()
		bw_LoadItems.RunWorkerAsync()
	End Sub

	Private Sub IndexChanged(sender As Object, e As EventArgs) Handles cbx_Items.SelectedIndexChanged
		RaiseEvent SelectedItemChanged(CInt(SelectedValue))
	End Sub
End Class
