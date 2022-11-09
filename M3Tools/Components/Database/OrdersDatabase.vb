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
            'myCmd.CommandType = CommandType.StoredProcedure

            'Using myReader = myCmd.ExecuteReader()
            '    Do While myReader.Read()
            '        orders.Add(New CurrentOrder() With {
            '                   .Id = myReader.GetInt32(0),
            '                   .Customer = New Customer() With {
            '                        .Id = myReader.GetInt32(1),
            '                        .FirstName = myReader.GetString(2),
            '                        .LastName = myReader.GetString(3)
            '                   },
            '                   .Item = New Product() With {
            '                        .Id = myReader.GetInt32(4),
            '                        .Name = myReader.GetString(5)
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

            'myCmd.CommandText = "UPDATE Orders SET QUANTITY = @Quantity WHERE OrderID = @OrderID"

            'myCmd.ExecuteNonQuery()
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