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

            'create view to use with
            'myCmd.CommandText = "GetOrders"
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
            '                   },
            Return orders
        End Function
        Return orders
        End Function
        '               })
        Public Function GetCompletedOrders() As DBEntryCollection(Of Order)
            Dim orders As New DBEntryCollection(Of Order)

            Using cmd = db_Connection.Connect
        Public Function GetCompletedOrders() As Collection(Of Order)
            Dim orders As New Collection(Of Order)

            Using cmd = db_Connection.Connect
                Return orders
        End Function



        Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
            'insert the order into the ORDERS table
            AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})
        End Sub

        Public Sub AddOrder(parameters As SqlParameter())
            'myCmd.CommandText = "AddOrder"
            'myCmd.CommandType = CommandType.StoredProcedure

            'myCmd.Parameters.AddRange(parameters)
            'myCmd.ExecuteNonQuery()
        End Sub

        Public Sub UpdateOrder(orderID As Integer, quantity As Integer)
            End If

            If quantity < 1 Then
                Throw New ArgumentException("Quantity values must be greater than or equal to 1")
            End If

            'insert the order into the ORDERS table
            AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})
        End Sub

        Public Sub AddOrder(parameters As SqlParameter())
            '	.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
            '	.OrderTotal = reader.GetDecimal(reader.GetOrdinal("OrderTotal")),
            '	.OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"))
            Throw New ArgumentException("Quantity values must be greater than or equal to 1")
            End If
            End Using
            End Using
            AddOrder({New SqlParameter("CustomerID", customerID), New SqlParameter("ItemID", itemID), New SqlParameter("Quantity", quantity)})

            cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddRange(parameters)

            ' TODO: Verify if a return should happen
            cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Sub UpdateOrder(orderID As Integer, quantity As Integer)
            If Not Utils.ValidID(orderID) Then
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
            End If

            If quantity < 1 Then
                Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
            End If



        End Sub
        End Sub

        Private Sub UpdateOrder(ParamArray params As SqlParameter())
            Using cmd = db_Connection.Connect
                cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddOrder]"
                cmd.CommandType = CommandType.StoredProcedure


                cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[Orders] SET QUANTITY = @Quantity WHERE OrderID = @OrderID"
                Throw New Exceptions.DatabaseException("Update Order not implemented yet")
                cmd.Parameters.AddRange(parameters)

                ' TODO: Verify if a return should happen
                cmd.Parameters.AddRange(parameters)
            End Using
        End Sub

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
        ' TODO: Verify if a return should happen
        Public Sub CancelOrder(orderID As Integer)
            'myCmd.CommandText = "CancelOrder"
            'myCmd.CommandType = CommandType.StoredProcedure

            CancelOrder(New SqlParameter("OrderID", orderID))
        End Sub

            cmd.ExecuteNonQueryAsync()
            End Using
        End Sub
            End Using
        End Sub

				cmd.CommandText = $"[{My.Settings.Schema}].[sp_CancelOrder]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)
            End If
            Using cmd = db_Connection.Connect
                cmd.CommandText = "sp_CompleteOrder"
                cmd.CommandType = CommandType.StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub
        'myCmd.CommandText = "CompleteOrder"

        'myCmd.Parameters.AddWithValue("OrderID", orderID)
				Throw New ArgumentException("ID values must be greater than or equal to 0")
			End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
				Throw New ArgumentException("ID values must be greater than Or equal to 0")
			End If

			CompleteOrder(New SqlParameter("OrderID", orderID))
            If orderID < 0 Then
                Throw New ArgumentException("ID values must be greater than Or equal to 0")
            End If

            Using cmd = db_Connection.Connect()
                cmd.CommandText = "SELECT * FROM tf_GetOrder(@OrderID)"
                cmd.Parameters.AddWithValue("OrderID", orderID)

    End Class
End Namespace