Imports System.Windows.Forms

Namespace Dialogs
	Public Class EditProductDialog
		' TODO: Figure out better way to manage state of editted value for all edit dialogs
		Private _product As Types.Product
		' Private _newInfo As Types.Customer

		Private Event ProductChanged()

		Public Property Product As Types.Product
			Get
				Return _product
			End Get
			Set(value As Types.Product)
				_product = value
				RaiseEvent ProductChanged()
			End Set
		End Property

		Public ReadOnly Property NewInfo As Types.Product
			Get
				Return New Types.Product(Product.Id, ProductName, ProductStock, ProductPrice, Available)
			End Get
		End Property

		Private Overloads Property ProductName As String
			Get
				Return gi_Name.Text
			End Get
			Set(value As String)
				gi_Name.Text = value
			End Set
		End Property

		Private Property ProductStock As Integer
			Get
				Return qn_Stock.Quantity
			End Get
			Set(value As Integer)
				qn_Stock.Quantity = value
			End Set
		End Property

		Private Property ProductPrice As Decimal
			Get
				Return pi_Price.Price
			End Get
			Set(value As Decimal)
				pi_Price.Price = value
			End Set
		End Property

		Private Property Available As Boolean
			Get
				Return chk_Available.Checked
			End Get
			Set(value As Boolean)
				chk_Available.Checked = value
			End Set
		End Property

		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles btn_Done.Click
			If Not ValidChangesDetected() Then
				MessageBox.Show("There were errors in your edits. Please review And try again.", "Editting Errors", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ProductUpdated() Handles Me.ProductChanged
			'_newInfo = Product.Clone()
			ProductName = Product.Name
			ProductStock = Product.Stock
			ProductPrice = Product.Price
			Available = Product.Available
			Text = String.Format(Text, Name)
		End Sub

		Private Function ValidChangesDetected() As Boolean
			If Name <> Product.Name Then
				Return True
			End If

			If ProductStock <> Product.Stock AndAlso ProductStock >= 0 Then
				Return True
			End If

			If ProductPrice <> Product.Price AndAlso ProductPrice >= 0 Then
				Return True
			End If

			If Available <> Product.Available Then
				Return True
			End If

			Return False
		End Function

		'Private Sub CustomersLoaded(sender As Object, e As RunWorkerCompletedEventArgs)
		'	If e.Cancelled Then
		'		Dim answer = MessageBox.Show("Unable to retrieve customer. Would you Like to try again?", "Customer Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

		'		If answer = DialogResult.Yes Then
		'			While bw_LoadCustomer.IsBusy
		'				Console.WriteLine("LoadCustomers Background worker Not finished...")
		'				Utils.Wait()
		'			End While

		'			bw_LoadCustomer.RunWorkerAsync()
		'		End If
		'		Return
		'	End If

		'	FirstName = _customer.FirstName
		'	LastName = _customer.LastName
		'	Phone = _customer.PhoneNumber
		'	Email = _customer.Email
		'	Address = _customer.Address
		'End Sub

		'Private Sub Reload()
		'	bw_LoadCustomer.RunWorkerAsync()
		'End Sub
	End Class
End Namespace
