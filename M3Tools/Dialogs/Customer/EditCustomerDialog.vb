Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Dialogs
	Public Class EditCustomerDialog
		Private _customer As Types.Customer
		' Private _newInfo As Types.Customer

		Private Event CustomerChanged()

		Public Property Customer As Types.Customer
			Get
				Return _customer
			End Get
			Set(value As Types.Customer)
				_customer = value
				RaiseEvent CustomerChanged()
			End Set
		End Property

		Public Property FirstName As String
			Get
				Return gi_FirstName.Text
			End Get
			Set(value As String)
				gi_FirstName.Text = value
			End Set
		End Property

		Public Property LastName As String
			Get
				Return gi_LastName.Text
			End Get
			Set(value As String)
				gi_LastName.Text = value
			End Set
		End Property
		Public Property Phone As String
			Get
				Return PhoneNumberField1.PhoneNumber
			End Get
			Set(value As String)
				PhoneNumberField1.PhoneNumber = value
			End Set
		End Property
		Public Property Email As String
			Get
				Return gi_Email.Text
			End Get
			Set(value As String)
				gi_Email.Text = value
			End Set
		End Property
		Public Property Address As Types.Address
			Get
				Return Types.Address.Parse(af_Address.Street, af_Address.City, af_Address.State, af_Address.ZipCode)
			End Get
			Set(value As Types.Address)
				af_Address.Street = If(value?.Street, "")
				af_Address.City = If(value?.City, "")
				af_Address.State = If(value?.State, "")
				af_Address.ZipCode = If(value?.ZipCode, "")
			End Set
		End Property

		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles OK_Button.Click
			If Not ChangeDetected() Then
				Return
			End If

			db_Customers.UpdateCustomer(Customer.Id, FirstName, LastName, Address, Phone, Email)

			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles Cancel_Button.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ListenerUpdated() Handles Me.CustomerChanged
			'_newInfo = Customer.Clone()
			FirstName = Customer.FirstName
			LastName = Customer.LastName
			Address = Customer.Address
			Phone = Customer.PhoneNumber
			Email = Customer.Email
		End Sub

		Private Function ChangeDetected() As Boolean
			If FirstName <> Customer.FirstName Then
				Return True
			End If

			If Email <> Customer.Email Then
				Return True
			End If

			Return False
		End Function

		Private Sub DialogLoading(sender As Object, e As EventArgs) Handles Me.Load
			' Reload()
		End Sub

		Private Sub LoadCustomer(sender As Object, e As DoWorkEventArgs)
			If Customer.Id < 0 Then
				e.Cancel = True
				Return
			End If

			Try
				_customer = db_Customers.GetCustomer(Customer.Id)
			Catch ex As Exception
				Console.WriteLine(ex.Message)
				e.Cancel = True
			End Try
		End Sub

		'Private Sub CustomersLoaded(sender As Object, e As RunWorkerCompletedEventArgs)
		'	If e.Cancelled Then
		'		Dim answer = MessageBox.Show("Unable to retrieve customer. Would you like to try again?", "Customer Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

		'		If answer = DialogResult.Yes Then
		'			While bw_LoadCustomer.IsBusy
		'				Console.WriteLine("LoadCustomers Background worker not finished...")
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

		Private Function CheckChangedValues() As Boolean
			' TODO: Check to allow empty Nullable fields
			If Not FirstName.Equals(_customer.FirstName) Or Not LastName.Equals(_customer.LastName) AndAlso IsValidName() Then
				Return True
			End If

			If IsValidAddress() AndAlso Not Address.ToString.Equals(_customer.Address.ToString) Then
				Return True
			End If

			If Not Email.Equals(_customer.Email) AndAlso IsValidEmail() Then
				Return True
			End If

			Dim phoneStr = String.Join("", Phone.Where(Function(currentChar As Char) As Boolean
														   Return Not Regex.IsMatch(currentChar, "[\s()-]")
													   End Function))
			Dim currentStr = String.Join("", _customer.PhoneNumber.Where(Function(currentChar As Char) As Boolean
																			 Return Not Regex.IsMatch(currentChar, "[\s()-]")
																		 End Function))

			If Not phoneStr.Equals(currentStr) AndAlso IsValidPhone() Then
				Return True
			End If

			Return False
		End Function

		Private Function IsValidName() As Boolean
			Return FirstName <> "" AndAlso LastName <> ""
		End Function

		Private Function IsValidEmail() As Boolean
			Return Regex.IsMatch(Email, My.Resources.EmailRegex2)
		End Function

		Private Function IsValidPhone() As Boolean
			Return Phone <> "" AndAlso Regex.IsMatch(Phone, "\(\d{3}\)\s\d{3}-\d{4}")
		End Function

		Private Function IsValidAddress() As Boolean
			Return af_Address.IsValidAddress
		End Function
	End Class
End Namespace