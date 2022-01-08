Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
    Public NotInheritable Class CustomerDatabase
        'The username to use for the database connection
        <EditorBrowsable()>
        <Description("The username to use for the database connection")>
        <SettingsBindable(True)>
        Public Property Username As String
            Get
                Return db_Connection.Username
            End Get
            Set(value As String)
                db_Connection.Username = value
            End Set
        End Property

        'The password to use for the database connection
        <PasswordPropertyText(True)>
        <SettingsBindable(True)>
        <Description("The password to use for the database connection")>
        Public Property Password As String
            Get
                Return db_Connection.Password
                'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
            End Get
            Set(value As String)
                'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
                'Console.WriteLine(temp)
                '__connectionString.Password = temp
                db_Connection.Password = value
            End Set
        End Property

        'The initial catalog to use for the database connection
        <Bindable(True)>
        <Description("The initial catalog to use for the database connection")>
        <SettingsBindable(True)>
        Public Property InitialCatalog As String
            Get
                Return db_Connection.InitialCatalog
            End Get
            Set(value As String)
                db_Connection.InitialCatalog = value
            End Set
        End Property

        Public Sub AddCustomer(customer As Customer)
            AddCustomer(customer.FirstName, customer.LastName, customer.Address.Street, customer.Address.City, customer.Address.State, customer.Address.ZipCode, customer.PhoneNumber, customer.EmailAddress)
        End Sub

        Public Sub AddCustomer(
                   fName As String, lName As String,
                   addrStreet As String, addrCity As String, addrState As String, addrZip As String,
                   phoneNumber As String, email As String)

            'used string.format due to enormous query strings and concatination, allowing for easy expansion
            'SELECT CONVERT(VARCHAR(10), getdate(), 101) is a query found online that gets just the date of getdate().
            'source = https://tableplus.io/blog/2018/09/ms-sql-server-how-to-get-date-only-from-datetime-value.html

            'Style	How it’s displayed
            '101    mm/dd/yyyy
            '102    yyyy.mm.dd
            '103    dd/mm/yyyy
            '104    dd.mm.yyyy
            '105    dd-mm-yyyy
            '110    mm-dd-yyyy
            '111    yyyy/mm/dd
            '106    dd mon yyyy
            '107    Mon dd, yyyy

            'date string that holds the command to get the date for when the person joined
            'Dim dateString = "SELECT CONVERT(VARCHAR(10), GETDATE(), 111)"
            AddCustomer({New SqlParameter("FirstName", fName), New SqlParameter("LastName", lName), New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity), New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip), New SqlParameter("Phone", phoneNumber), New SqlParameter("Email", email)})
        End Sub

        Private Sub AddCustomer(parameters As SqlParameter())
            Using _conn = db_Connection.Connect()
                _conn.Parameters.AddRange(parameters)

                _conn.CommandType = CommandType.StoredProcedure
                _conn.CommandText = "AddCustomer"

                _conn.ExecuteNonQuery()
            End Using
        End Sub

        Public Function GetCustomers() As Collection(Of Customer)
            Using _conn = db_Connection.Connect
                _conn.CommandText = "SELECT * FROM CUSTOMERS"

                Using reader = _conn.ExecuteReader
                    Dim customers As New Collection(Of Customer)
                    Do While reader.Read()
                        customers.Add(New Customer() With {
                                    .Id = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                    .FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    .LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    .Address = New Address() With {
                                        .Street = reader.GetString(reader.GetOrdinal("Street")),
                                        .City = reader.GetString(reader.GetOrdinal("City")),
                                        .State = reader.GetString(reader.GetOrdinal("State")),
                                        .ZipCode = reader.GetString(reader.GetOrdinal("ZipCode"))
                                    },
                                    .PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    .EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")),
                                    .JoinDate = reader.GetString(reader.GetOrdinal("JoinDate"))
                                  })
                    Loop

                    Return customers
                End Using
            End Using
        End Function

        Public Function GetCustomer(customerID As Integer) As Customer
            Using _conn = db_Connection.Connect()
                _conn.Parameters.AddWithValue("CustomerID", customerID)

                _conn.CommandText = "SELECT * FROM CUSTOMERS WHERE CustomerID = @CustomerID"

                Using reader = _conn.ExecuteReader()
                    If reader.Read() Then
                        Return New Customer() With {
                            .Id = customerID,
                            .FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            .LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            .Address = New Address() With {
                                .Street = reader.GetString(reader.GetOrdinal("Street")),
                                .City = reader.GetString(reader.GetOrdinal("City")),
                                .State = reader.GetString(reader.GetOrdinal("State")),
                                .ZipCode = reader.GetString(reader.GetOrdinal("ZipCode"))
                            },
                            .PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            .EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")),
                            .JoinDate = reader.GetString(reader.GetOrdinal("JoinDate"))
                        }
                    Else
                        Throw New Exceptions.CustomerNotFoundException()
                    End If
                End Using
            End Using
        End Function

        Public Sub UpdateCustomer(customerID As Integer, column As String, value As String)
            Using _conn = db_Connection.Connect()
                Dim command As String

				' If using an empty string, set the database value to null
				'TODO: Figure out if N/A counts as null or empty
				If Not (String.IsNullOrEmpty(value) Or value.Equals("N/A")) Then
					command = String.Format("{0} = '{1}'", column, value)
				Else
					command = String.Format("{0} = NULL", column)
                End If

                _conn.Parameters.AddWithValue("CustomerID", customerID)

                _conn.CommandText = String.Format("UPDATE CUSTOMERS
                                            SET {0}
                                            WHERE CustomerID = @CustomerID", command)

                _conn.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub RemoveCustomer(customerID As Integer)
            Using _conn = db_Connection.Connect()
                _conn.Parameters.AddWithValue("CustomerID", customerID)

                _conn.CommandText = "DELETE FROM CUSTOMERS WHERE CustomerID = @CustomerID"

                _conn.ExecuteNonQuery()
            End Using
        End Sub
    End Class
End Namespace