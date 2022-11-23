Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Namespace Database
    Public NotInheritable Class OrdersDatabase
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
            End Get
            Set(value As String)
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
        Public Function GetCurrentOrders() As DBEntryCollection(Of Order)
            Dim orders As New DBEntryCollection(Of Order)

            Using cmd = db_Connection.Connect
                cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[Orders] WHERE CompletedDate IS NULL" '$"[{My.Settings.Schema}].[sp_GetOrders]"
                cmd.CommandType = CommandType.Text

                Using reader = cmd.ExecuteReader
                    Do While reader.Read()
                        orders.Add(New Order(
                                   CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
                                    CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate"))))
                    Loop
                End Using
            End Using
            Return orders
        End Function

        Public Function GetCompletedOrders() As DBEntryCollection(Of Order)
            Dim orders As New DBEntryCollection(Of Order)

            Using cmd = db_Connection.Connect
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_GetCompletedOrders"

                Using reader = cmd.ExecuteReader
                    Do While reader.Read
                        orders.Add(New Order(
                                   CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
                                    CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")), CDate(reader("CompletedDate"))))
                        '			With {
                        '	.Id = reader.GetInt32(reader.GetOrdinal("OrderID")),
                        '	.Customer = New Customer() With {
                        '		.Id = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                        '		.FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        '		.LastName = reader.GetString(reader.GetOrdinal("LastName"))
                        '	},
                        '	.Product = New Item() With {
                        '		.Id = reader.GetInt32(reader.GetOrdinal("ItemID")),
                        '		.Name = reader.GetString(reader.GetOrdinal("ItemName"))
                        '	},
                        '	.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        '	.OrderTotal = reader.GetDecimal(reader.GetOrdinal("OrderTotal")),
                        '	.OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"))
                        Throw New ArgumentException("Quantity values must be greater than or equal to 1")
                        End If
                End Using
            End Using
            AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})
            End Sub
            Return orders
        End Function

        Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
            'insert the order into the ORDERS table
            AddOrder(New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity))
        End Sub

        Public Sub AddOrder(ParamArray parameters As SqlParameter())
            Using cmd = db_Connection.Connect
                cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddRange(parameters)

                ' TODO: Verify if a return should happen
                cmd.ExecuteNonQueryAsync()
            End Using
        End Sub
        Public Sub CancelOrder(orderID As Integer)
            CancelOrder(New SqlParameter("OrderID", orderID))
        End Sub

        Private Sub CancelOrder(ParamArray params As SqlParameter())
            Throw New Exception("CancelOrder Not Yet Implemented")
        End Sub

                cmd.ExecuteNonQueryAsync()
				Throw New ArgumentException("ID values must be greater than Or equal to 0")
        End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
            If orderID < 0 Then
        Throw New ArgumentException("ID values must be greater than or equal to 0")
        End If

        Private Sub CompleteOrder(ParamArray params As SqlParameter())
            Throw New Exception("CompleteOrder Not Yet Implemented")

            cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Sub CompleteOrder(orderID As Integer)
            If orderID < 0 Then
                Throw New Exception("GetOrderById Not Yet Implemented")
                End Function
    End Class
    End If

    Using cmd = db_Connection.Connect()
                cmd.CommandText = "sp_GetOrder"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("OrderID", orderID)

                Using reader = cmd.ExecuteReader()
    While reader.Read()
    Dim compDate As Date = CDate(reader("CompletedDate"))
    If CDate(reader("CompletedDate")).Year < 1901 Then
                            orders.Add(New Order(
                            CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
                            CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate"))))
					While reader.Read()
    Dim compDate As Date = CDate(reader("CompletedDate"))
    If CDate(reader("CompletedDate")).Year < 1901 Then
							orders.Add(New Order(
							CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
							CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate"))))
						Else
							orders.Add(New Order(CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
							CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")), CDate(reader("CompletedDate"))))
						End If
    End While

                    ' TODO: Explore this later
                    Console.WriteLine(reader("CompletedDate"))
                End Using
    End Using
    End Function
    End Class
End Namespace