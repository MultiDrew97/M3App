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

        Public Function GetCurrentOrders() As Collection(Of CurrentOrder)
            Dim orders As New Collection(Of CurrentOrder)

            ' TODO: Investigate how to make this async easier
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_GetOrders"
                cmd.CommandType = CommandType.StoredProcedure

                Using reader = cmd.ExecuteReader
                    Do While reader.Read()
                        orders.Add(New CurrentOrder() With {
                            .Id = reader.GetInt32(reader.GetOrdinal("OrderID")),
                            .Customer = New Customer() With {
                                .Id = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                .FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                .LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            },
                            .Item = New Item() With {
                                .Id = reader.GetInt32(reader.GetOrdinal("ItemID")),
                                .Name = reader.GetString(reader.GetOrdinal("ItemName"))
                            },
                            .Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            .OrderTotal = reader.GetDecimal(reader.GetOrdinal("OrderTotal")),
                            .OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"))
                        })
                    Loop
                End Using
            End Using

            Return orders
        End Function

        Public Function GetCompletedOrders() As Collection(Of CompletedOrder)
            Dim orders As New Collection(Of CompletedOrder)

            Using cmd = db_Connection.Connect
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_GetCompletedOrders"

                Using reader = cmd.ExecuteReader
                    Do While reader.Read
                        orders.Add(New CompletedOrder() With {
                            .Id = reader.GetInt32(reader.GetOrdinal("OrderID")),
                            .Customer = New Customer() With {
                                .Id = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                .FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                .LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            },
                            .Item = New Item() With {
                                .Id = reader.GetInt32(reader.GetOrdinal("ItemID")),
                                .Name = reader.GetString(reader.GetOrdinal("ItemName"))
                            },
                            .Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            .OrderTotal = reader.GetDecimal(reader.GetOrdinal("OrderTotal")),
                            .OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                            .CompletedDate = reader.GetDateTime(reader.GetOrdinal("CompletedDate"))
                        })
                    Loop
                End Using
            End Using

            Return orders
        End Function

        Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
            If customerID < 0 Or itemID < 0 Then
                Throw New ArgumentException("ID values must be greater than or equal to 0")
            End If

            If quantity < 0 Then
                Throw New ArgumentException("Quantity values must be greater than or equal to 0")
            End If

            'insert the order into the ORDERS table
            AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})
        End Sub

        Public Sub AddOrder(parameters As SqlParameter())
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_AddOrder"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddRange(parameters)

                ' TODO: Verify if a return should happen
                cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Sub UpdateOrder(orderID As Integer, quantity As Integer)
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than or equal to 0")
            End If

            If quantity < 0 Then
                Throw New ArgumentException("Quantity values must be greater than or equal to 0")
            End If

            Throw New Exceptions.DatabaseException("Update Order not implemented yet")
            'myCmd.Parameters.AddWithValue("OrderID", orderID)
            'myCmd.Parameters.AddWithValue("Quantity", quantity)

            'myCmd.CommandText = "UPDATE Orders SET QUANTITY = @Quantity WHERE OrderID = @OrderID"

            'myCmd.ExecuteNonQuery()
        End Sub

        Public Sub CancelOrder(orderID As Integer)
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than or equal to 0")
            End If
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_CancelOrder"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("OrderID", orderID)

                cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Sub CompleteOrder(orderID As Integer)
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than or equal to 0")
            End If
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_CompleteOrder"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("OrderID", orderID)

                cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Function GetOrder(orderID As Integer) As CurrentOrder
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than or equal to 0")
            End If

            Using cmd = db_Connection.Connect()
                cmd.CommandText = "sp_GetOrder"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("OrderID", orderID)

                Using reader = cmd.ExecuteReader()
                    If Not reader.Read() Then
                        Throw New Exceptions.DatabaseException($"No order with OrderID={orderID} was found")
                    End If

                    ' TODO: Explore this later
                    Console.WriteLine(reader("CompletedDate"))
                End Using
            End Using
        End Function
    End Class
End Namespace