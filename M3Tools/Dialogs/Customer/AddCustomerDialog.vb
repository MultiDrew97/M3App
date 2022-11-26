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

		Private ReadOnly Property FirstName As String
			Get
				Return gi_FirstName.Text
			End Get
		End Property

		Private ReadOnly Property LastName As String
			Get
				Return gi_LastName.Text
			End Get
		End Property

		Private ReadOnly Property Address As Address
			Get
				Return af_Address.Address
			End Get
		End Property

		Private ReadOnly Property Phone As String
			Get
				Dim phoneArr = pn_PhoneNumber.PhoneNumber.Where(Function(currentChar As Char) As Boolean
																	Return Not Regex.IsMatch(currentChar, "[\s()-]")
																End Function)
				Return String.Join("", phoneArr)
			End Get
		End Property

		Private ReadOnly Property Email As String
			Get
				Return gi_EmailAddress.Text
			End Get
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
					RaiseEvent PageChangedEvent(tc_Creation.SelectedIndex)
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
			Return String.IsNullOrEmpty(Email) OrElse Regex.IsMatch(Email, My.Resources.EmailRegex2)
		End Function

		Private Function ValidAddress() As Boolean
			Return af_Address.IsValidAddress()
		End Function

		Private Sub TryCreate()
			Try
				Dim customer As New Customer(-1, FirstName, LastName, Address, Phone, Email)
				If Not (ValidName() AndAlso ValidEmail() AndAlso ValidAddress()) Then
					Throw New ArgumentException("Invalid Customer Information")
				End If

				db_Customers.AddCustomer(customer)
			Catch ex As Exception
				Throw New Exceptions.CreationException("Failed to create the customer. Please try again.", ex)
			End Try
		End Sub
	End Class
End Namespace