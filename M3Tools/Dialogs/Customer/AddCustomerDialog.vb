Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types
Imports SPPBC.M3Tools.Events.Customers

' TODO: Cleanup this dialog box
Namespace Dialogs
	Public Class AddCustomerDialog
		Public Event CustomerAdded As CustomerEventHandler
		Private Event PageChangedEvent As EventHandler

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
				Return pn_PhoneNumber.Text
			End Get
		End Property

		Private ReadOnly Property Email As String
			Get
				Return gi_EmailAddress.Text
			End Get
		End Property

		ReadOnly Property Customer As Customer
			Get
				Return New Customer(-1, FirstName, LastName, Address, Email, Phone)
			End Get
		End Property

		Private ReadOnly Property ValidName As Boolean
			Get
				Return ValidFirstName() And ValidLastName()
			End Get
		End Property

		Private ReadOnly Property ValidFirstName As Boolean
			Get
				If String.IsNullOrWhiteSpace(FirstName) Then
					ep_InputError.SetError(gi_FirstName, "A first name is required")
					Return False
				End If

				Return True
			End Get
		End Property

		Private ReadOnly Property ValidLastName As Boolean
			Get
				If String.IsNullOrWhiteSpace(LastName) Then
					ep_InputError.SetError(gi_LastName, "A last name is required")
					Return False
				End If

				Return True
			End Get
		End Property

		Private ReadOnly Property ValidEmail As Boolean
			Get
				If String.IsNullOrWhiteSpace(Email) OrElse Not Regex.IsMatch(Email, My.Resources.EmailRegex2) Then
					ep_InputError.SetError(gi_EmailAddress, "No valid email address provided")
					Return False
				End If

				Return True
			End Get
		End Property

		Private ReadOnly Property ValidCustomer As Boolean
			Get
				Return ValidName() AndAlso ValidEmail() AndAlso af_Address.IsValidAddress() AndAlso pn_PhoneNumber.ValidPhone()
			End Get
		End Property

		Private Sub PreviousStep(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Select Case tc_Creation.SelectedIndex
				Case tp_Basics.TabIndex
					Dim res = MessageBox.Show("Are you sure you want to cancel customer creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

					If Not res = DialogResult.Yes Then
						Exit Sub
					End If

					DialogResult = DialogResult.Cancel
					Close()
				Case Else
					tc_Creation.SelectedIndex -= 1
					RaiseEvent PageChangedEvent(Me, e)
			End Select
		End Sub

		Private Sub NextStep(sender As Object, e As EventArgs) Handles btn_Create.Click
			Select Case tc_Creation.SelectedIndex
				Case tp_Summary.TabIndex
					If Not ValidCustomer Then
						MessageBox.Show("There were errors in your customer submission. Please try again.", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If

					RaiseEvent CustomerAdded(Me, New CustomerEventArgs(Customer, M3Tools.Events.EventType.Added))

					DialogResult = DialogResult.OK
					Close()
				Case Else
					tc_Creation.SelectedIndex += 1
					RaiseEvent PageChangedEvent(Me, e)
			End Select
		End Sub

		Private Sub PageChanged(sender As Object, e As EventArgs) Handles Me.PageChangedEvent, tc_Creation.SelectedIndexChanged
			btn_Cancel.Text = If(tc_Creation.SelectedIndex <= tp_Basics.TabIndex, "Cancel", "Back")
			btn_Create.Text = If(tc_Creation.SelectedIndex >= tp_Summary.TabIndex, "Create", "Next")
			sc_Summary.Display = If(tc_Creation.SelectedIndex = tp_Summary.TabIndex, Customer, Nothing)
		End Sub
	End Class
End Namespace
