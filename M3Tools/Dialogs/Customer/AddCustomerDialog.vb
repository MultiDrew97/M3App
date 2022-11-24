Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types

' TODO: Cleanup this dialog box
Namespace Dialogs
	Public Class AddCustomerDialog
		Private ReadOnly __emailPattern As New Regex(My.Resources.EmailRegex)

		Private ReadOnly Property CustomerName As String
			Get
				Return $"{FirstName} {LastName}"
			End Get
		End Property

		Private Property FirstName As String
			Get
				Return gi_FirstName.Text
			End Get
			Set(value As String)
				gi_FirstName.Text = value
			End Set
		End Property

		Private Property LastName As String
			Get
				Return gi_LastName.Text
			End Get
			Set(value As String)
				gi_LastName.Text = value
			End Set
		End Property

		Private Property CustomerAddress As Address
			Get
				Return New Address(af_Address.Street, af_Address.City, af_Address.State, af_Address.ZipCode)
			End Get
			Set(value As Address)
				af_Address.Street = value.Street
				af_Address.City = value.City
				af_Address.State = value.State
				af_Address.ZipCode = value.ZipCode

				If Not af_Address.IsValidAddress Then
					af_Address.Street = ""
					af_Address.City = ""
					af_Address.State = ""
					af_Address.ZipCode = ""
				End If
			End Set
		End Property

		Private Property Phone As String
			Get
				Return pn_PhoneNumber.PhoneNumber
			End Get
			Set(value As String)
				pn_PhoneNumber.PhoneNumber = value
			End Set
		End Property

		Private Property Email As String
			Get
				Return gi_EmailAddress.Text
			End Get
			Set(value As String)
				gi_EmailAddress.Text = value
			End Set
		End Property


		Private Sub Btn_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
			Select Case btn_Cancel.Text
				Case "Back"
					tc_Creation.SelectedIndex = tc_Creation.SelectedIndex - 1
					If tc_Creation.SelectedIndex <= 0 Then
						btn_Create.Text = "Cancel"
					End If
				Case "Cancel"
					DialogResult = DialogResult.Cancel
					Close()
			End Select
		End Sub

		Private Sub CreateCustomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create.Click
			Select Case btn_Create.Text
				Case "Next"
					tc_Creation.SelectedIndex = tc_Creation.SelectedIndex + 1
					btn_Cancel.Text = "Back"
					If tc_Creation.SelectedIndex >= tc_Creation.TabCount Then
						btn_Create.Text = "Create"
					End If
				Case "Create"
					Try
						TryCreate()
						DialogResult = DialogResult.OK
						Close()
					Catch ex As Exception
						tss_Feedback.ForeColor = Color.Red
						tss_Feedback.Text = ex.Message
					End Try
			End Select
		End Sub

		Private Function ValidName() As Boolean
			Return ValidFirstName() And ValidLastName()
		End Function

		Private Function ValidFirstName() As Boolean
			Return gi_FirstName.Text <> ""
		End Function

		Private Function ValidLastName() As Boolean
			Return gi_LastName.Text <> "" '(gi_LastName.Text <> "" And Not String.IsNullOrWhiteSpace(gi_LastName.Text)) Or String.IsNullOrEmpty(gi_LastName.Text)
		End Function

		Private Function ValidEmail() As Boolean
			Return gi_EmailAddress.Text <> "" '(gi_EmailAddress.Text <> "" And __emailPattern.IsMatch(gi_EmailAddress.Text)) Or String.IsNullOrWhiteSpace(gi_EmailAddress.Text)
		End Function

		Private Function ValidAddress() As Boolean
			Return af_Address.IsValidAddress()
		End Function

		Private Sub ValidateLastName(sender As Object, e As EventArgs) Handles gi_LastName.TextChanged
			If Not ValidLastName() Then
				ep_InputError.SetError(gi_LastName, "The entered last name is invalid")
			Else
				ep_InputError.SetError(gi_LastName, "")
			End If
		End Sub

		Private Sub ValidateFirstName(sender As Object, e As EventArgs) Handles gi_FirstName.TextChanged
			If Not ValidFirstName() Then
				ep_InputError.SetError(gi_FirstName, "You must enter a first name")
			Else
				ep_InputError.SetError(gi_FirstName, "")
			End If
		End Sub

		Private Sub ValidateEmail(sender As Object, e As EventArgs) Handles gi_EmailAddress.TextChanged
			If Not ValidEmail() Then
				ep_InputError.SetError(gi_EmailAddress, "The email address isn't in the correct format (i.e. johndoe@domain.ext)")
			Else
				ep_InputError.SetError(gi_EmailAddress, "")
			End If
		End Sub

		Private Sub ValidateAddress(sender As Object, e As EventArgs) Handles af_Address.TextChanged
			If Not ValidAddress() Then
				ep_InputError.SetError(af_Address, "You either have to enter a complete address, or none at all")
			Else
				ep_InputError.SetError(af_Address, "")
			End If
		End Sub

		Private Sub TryCreate()
			Try
				Dim customer As New Customer(-1, FirstName, LastName, CustomerAddress, Phone, Email)
				If Not (ValidName() AndAlso ValidEmail() AndAlso ValidAddress()) Then
					Throw New Exception("Invalid Inputs")
				End If

				db_Customers.AddCustomer(customer)
			Catch ex As Exception
				Throw New Exceptions.CreationException("Failed to create the customer. Please try again.")
			End Try
		End Sub
	End Class
End Namespace