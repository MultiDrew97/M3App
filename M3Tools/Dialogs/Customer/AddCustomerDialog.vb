Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types

' TODO: Cleanup this dialog box
Namespace Dialogs
	Public Class AddCustomerDialog
		Private Event PageChangedEvent(currentPage As Integer)
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
				Return String.Join("", pn_PhoneNumber.PhoneNumber.Where(Function(currentChar As Char) As Boolean
																			Return Not Regex.IsMatch(currentChar, "[\s()-]")
																		End Function))
			End Get
			Set(value As String)
				pn_PhoneNumber.PhoneNumber = String.Join("", value.Where(Function(currentChar As Char) As Boolean
																			 Return Not Regex.IsMatch(currentChar, "[\s()-]")
																		 End Function))
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


		Private Sub PreviousStep(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Select Case btn_Cancel.Text
				Case "Back"
					tc_Creation.SelectedIndex = tc_Creation.SelectedIndex - 1
					RaiseEvent PageChangedEvent(tc_Creation.SelectedIndex)
				Case "Cancel"
					DialogResult = DialogResult.Cancel
					Close()
			End Select
		End Sub

		Private Sub NextStep(sender As Object, e As EventArgs) Handles btn_Create.Click
			Select Case btn_Create.Text
				Case "Next"
					tc_Creation.SelectedIndex = tc_Creation.SelectedIndex + 1
					btn_Cancel.Text = "Back"
					RaiseEvent PageChangedEvent(tc_Creation.SelectedIndex)
				Case "Create"
					Try
						TryCreate()
						'DialogResult = DialogResult.OK
						'Close()
					Catch ex As Exception
						tss_Feedback.ForeColor = Color.Red
						tss_Feedback.Text = ex.Message
					End Try
			End Select
		End Sub

		Private Sub PageChanged(currentPage As Integer) Handles Me.PageChangedEvent
			btn_Cancel.Text = If(currentPage <= 0, "Cancel", "Back")
			btn_Create.Text = If(currentPage >= tc_Creation.TabCount - 1, "Create", "Next")
		End Sub

		Private Function ValidName() As Boolean
			Return ValidFirstName() And ValidLastName()
		End Function

		Private Function ValidFirstName() As Boolean
			Return gi_FirstName.Text <> ""
		End Function

		Private Function ValidLastName() As Boolean
			Return gi_LastName.Text <> ""
		End Function

		Private Function ValidEmail() As Boolean
			Return Email <> "" AndAlso Regex.IsMatch(Email, My.Resources.EmailRegex2)
		End Function

		Private Function ValidAddress() As Boolean
			Return af_Address.IsValidAddress()
		End Function

		Private Sub TryCreate()
			Try
				Dim customer As New Customer(-1, FirstName, LastName, CustomerAddress, Phone, Email)
				If Not (ValidName() AndAlso ValidEmail() AndAlso ValidAddress()) Then
					Throw New Exception("Invalid Inputs")
				End If

				Console.WriteLine("---------- Customer -----------")
				Console.WriteLine(customer.Display())
				Console.WriteLine("-------------------------------")

				Console.WriteLine("---------- Address -----------")
				Console.WriteLine(CustomerAddress.Display())
				Console.WriteLine("-------------------------------")
				MessageBox.Show(customer.Display, "New Customer", MessageBoxButtons.OK)
				'db_Customers.AddCustomer(customer)
			Catch ex As Exception
				Throw New Exceptions.CreationException("Failed to create the customer. Please try again.")
			End Try
		End Sub
	End Class
End Namespace