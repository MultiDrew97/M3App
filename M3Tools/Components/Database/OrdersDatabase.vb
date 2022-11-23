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
                        '			With {
        '	.Id = reader.GetInt32(reader.GetOrdinal("OrderID")),
        '	.Customer = New Customer() With {
        Public Function GetCurrentOrders() As Collection(Of CurrentOrder)
            Dim orders As New Collection(Of CurrentOrder)
            '                   },
            '                   .Quantity = myReader.GetInt32(6),
            '                   .OrderTotal = CDec(myReader.GetSqlMoney(7)),
            '                   .OrderDate = myReader.GetDateTime(8)
            '               })
            '    Loop
            'End Using

            Return orders
        End Function

        Public Function GetCompletedOrders() As Collection(Of CompletedOrder)
            Dim orders As New Collection(Of CompletedOrder)

            'create view to use with
            'myCmd.CommandText = "GetCompletedOrders"
            'myCmd.CommandType = CommandType.StoredProcedure

            'Using myReader = myCmd.ExecuteReader()
            '    Do While myReader.Read()
            '        orders.Add(New CompletedOrder(myReader.GetInt32(0), myReader.GetInt32(1), {myReader.GetString(2), myReader.GetString(3)}, myReader.GetInt32(4), myReader.GetString(5), myReader.GetInt32(6), CDec(myReader.GetSqlMoney(7)), myReader.GetDateTime(8), myReader.GetDateTime(9)))
            '    Loop
            'End Using

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
            'myCmd.Parameters.AddWithValue("OrderID", orderID)
            'myCmd.Parameters.AddWithValue("Quantity", quantity)

            If quantity < 1 Then
                Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
            End If

            UpdateOrder(New SqlParameter("OrderID", orderID), New SqlParameter("Quantity", quantity))
        End Sub

        Private Sub UpdateOrder(ParamArray params As SqlParameter())
            Using cmd = db_Connection.Connect
                cmd.Parameters.AddRange(params)

                cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[Orders] SET QUANTITY = @Quantity WHERE OrderID = @OrderID"
                Throw New Exceptions.DatabaseException("Update Order not implemented yet")
                'myCmd.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub CancelOrder(orderID As Integer)
            'myCmd.CommandText = "CancelOrder"
            'myCmd.CommandType = CommandType.StoredProcedure

            'myCmd.Parameters.AddWithValue("OrderID", orderID)

            'myCmd.ExecuteNonQuery()
        End Sub

        Public Sub CompleteOrder(orderID As Integer)
            'myCmd.CommandType = CommandType.StoredProcedure
            'myCmd.CommandText = "CompleteOrder"

            'myCmd.Parameters.AddWithValue("OrderID", orderID)

            'myCmd.ExecuteNonQuery()
        End Sub
    End Class
End Namespace