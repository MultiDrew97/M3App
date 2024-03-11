Imports System.ComponentModel
Imports SPPBC.M3Tools.Events
Imports SPPBC.M3Tools.Types

Namespace Database
	Public NotInheritable Class CustomerDatabase
		Private Const path As String = "customers"

		<SettingsBindable(True)>
		<Description("The username to use for the database connection")>
		Public Property Username As String
			Get
				Return dbConnection.Username
			End Get
			Set(value As String)
				dbConnection.Username = value
			End Set
		End Property

		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return dbConnection.Password
			End Get
			Set(value As String)
				dbConnection.Password = value
			End Set
		End Property

		<Bindable(True)>
		<SettingsBindable(True)>
		<Description("The initial catalog to use for the database connection")>
		Public Property BaseUrl As String
			Get
				Return dbConnection.BaseUrl
			End Get
			Set(value As String)
				dbConnection.BaseUrl = value
			End Set
		End Property

		Public Sub AddCustomer(
				   fName As String, lName As String,
				   Optional addrStreet As String = Nothing, Optional addrCity As String = Nothing,
				   Optional addrState As String = Nothing, Optional addrZip As String = Nothing,
				   Optional phone As String = Nothing, Optional email As String = Nothing)
			AddCustomer(fName, lName, New Address(addrStreet, addrCity, addrState, addrZip), phone, email)
		End Sub


		Public Sub AddCustomer(
				   fName As String, lName As String,
				   Optional address As Address = Nothing,
				   Optional phone As String = Nothing, Optional email As String = Nothing)
			AddCustomer(New Customer(-1, fName, lName, address, phone, email))
		End Sub

		Public Sub AddCustomer(customer As Customer)
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(customer))
		End Sub

		Public Function GetCustomers() As CustomersCollection
			Return dbConnection.Consume(Of CustomersCollection)(Method.Get, $"/{path}").Result
		End Function

		Public Function GetCustomer(customerID As Integer) As Customer
			If Not Utils.ValidID(customerID) Then
				Throw New ArgumentException($"Invalid CustomerID provided")
			End If

			Return dbConnection.Consume(Of Customer)(Method.Get, $"/{path}/{customerID}").Result
		End Function

		Public Sub UpdateCustomer(customerID As Integer, fName As String, lName As String, street As String, city As String, state As String, zipCode As String, email As String, phone As String)
			UpdateCustomer(customerID, fName, lName, New Address(street, city, state, zipCode), email, phone)
		End Sub

		Public Sub UpdateCustomer(customerID As Integer, fName As String, lName As String, addr As Address, email As String, phone As String)
			UpdateCustomer(New Customer(customerID, fName, lName, addr, email, phone))
		End Sub

		Private Sub UpdateCustomer(customer As Customer)
			If Not Utils.ValidID(customer.Id) Then
				Throw New ArgumentException($"Invalid CustomerID provided")
			End If

			dbConnection.Consume(Method.Put, $"/{path}/{customer.Id}", JSON.ConvertToJSON(customer))
		End Sub

		Public Sub RemoveCustomer(customerID As Integer)
			If Not Utils.ValidID(customerID) Then
				Throw New ArgumentException($"Invalid CustomerID provided")
			End If

			dbConnection.Consume(Method.Delete, $"/{path}/{customerID}")
		End Sub
	End Class
End Namespace
