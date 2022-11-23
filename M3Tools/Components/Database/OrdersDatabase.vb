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

            ' TODO: Investigate how to make this async easier
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

        Public Function GetCompletedOrders() As Collection(Of Order)
            Dim orders As New Collection(Of Order)

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


            Using cmd = db_Connection.Connect
                cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
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
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
                End If

                CancelOrder(New SqlParameter("OrderID", orderID))
                cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

				cmd.CommandText = $"[{My.Settings.Schema}].[sp_CancelOrder]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)
            End If
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_CompleteOrder"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("OrderID", orderID)

                cmd.ExecuteNonQueryAsync()
				Throw New ArgumentException("ID values must be greater than Or equal to 0")
			End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than Or equal to 0")
            End If

            Using cmd = db_Connection.Connect()
                cmd.CommandText = "SELECT * FROM tf_GetOrder(@OrderID)"
                cmd.Parameters.AddWithValue("OrderID", orderID)

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub


                    'If CDate(reader("CompletedDate")).Year < 1901 Then
                    '	Return New Order(
                    '		CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),

			Using cmd = db_Connection.Connect()
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[tf_GetOrder](@OrderID)"
                    Dim completedDate As Date

                    Try
					If Not reader.Read() Then
						Throw New Exceptions.OrderNotFoundException($"No order with OrderID '{orderID}' was found")
                        End If
        Catch
                        completedDate = Nothing
					'	Return New Order(
					'		CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
					'		CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")))

					' TODO: Verify NULL from tf won't break this
					Dim typing = GetType(Date)
        Dim completedDate As Date

        Try
        'End If
        End Using
        '	completedDate = Nothing
        'End If
        Catch
						completedDate = Nothing
					End Try

        Return New Order(CInt(reader("OrderID")), CInt(reader("CustomerID")), CInt(reader("ItemID")),
                CInt(reader("Quantity")), CDec(reader("OrderTotal")), CDate(reader("OrderDate")), completedDate)
        'End If
        End Using
        End Using

        Throw New Exceptions.ConnectionException("Failed to connect to database")
        End If

        Using cmd = db_Connection.Connect()
                cmd.CommandText = "SELECT * FROM tf_GetOrder(@OrderID)"
                cmd.Parameters.AddWithValue("CustomerID", customerID)

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

        End Using
        End Using
        End Using
        End Function
    End Class
End Namespace