Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types

Public Class AddCustomerDialog
	Private ReadOnly __emailPattern As New Regex(My.Resources.EmailRegex)
	Private Sub Btn_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Btn_Create_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create.Click
        Try
            TryCreate()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            tss_Feedback.ForeColor = Color.Red
            tss_Feedback.Text = ex.Message
        End Try
    End Sub

    Private Function ValidName() As Boolean
        Return ValidFirstName() And ValidLastName()
    End Function

    Private Function ValidFirstName() As Boolean
        Return if_FirstName.Text <> ""
    End Function

    Private Function ValidLastName() As Boolean
        Return (if_LastName.Text <> "" And Not String.IsNullOrWhiteSpace(if_LastName.Text)) Or String.IsNullOrEmpty(if_LastName.Text)
    End Function

    Private Function ValidEmail() As Boolean
        Return (if_EmailAddress.Text <> "" And __emailPattern.IsMatch(if_EmailAddress.Text)) Or String.IsNullOrWhiteSpace(if_EmailAddress.Text)
    End Function

    Private Function ValidAddress() As Boolean
        Return af_Address.IsValidAddress()
    End Function

    Private Sub ValidateLastName(sender As Object, e As EventArgs) Handles if_LastName.TextChanged
        If Not ValidLastName() Then
            ep_InputError.SetError(if_LastName, "The entered last name is invalid")
        Else
            ep_InputError.SetError(if_LastName, "")
        End If
    End Sub

    Private Sub ValidateFirstName(sender As Object, e As EventArgs) Handles if_FirstName.TextChanged
        If Not ValidFirstName() Then
            ep_InputError.SetError(if_FirstName, "You must enter a first name")
        Else
            ep_InputError.SetError(if_FirstName, "")
        End If
    End Sub

    Private Sub ValidateEmail(sender As Object, e As EventArgs) Handles if_EmailAddress.TextChanged
        If Not ValidEmail() Then
            ep_InputError.SetError(if_EmailAddress, "The email address isn't in the correct format (i.e. johndoe@domain.ext)")
        Else
            ep_InputError.SetError(if_EmailAddress, "")
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
            If ValidName() And ValidEmail() And ValidAddress() Then
                Dim customer As New Customer() With {
                .FirstName = if_FirstName.Text,
                .LastName = if_LastName.Text,
                .Address = New Address() With {
                    .Street = af_Address.Street,
                    .City = af_Address.City,
                    .State = af_Address.State,
                    .ZipCode = af_Address.ZipCode
                },
                .PhoneNumber = pnf_PhoneNumber.PhoneNumber,
                .EmailAddress = if_EmailAddress.Text
                }
                db_Customers.AddCustomer(customer)
            End If
        Catch ex As Exception
            Throw New Exceptions.CreationException("Failed to create the customer. Please try again.")
        End Try
    End Sub
End Class
