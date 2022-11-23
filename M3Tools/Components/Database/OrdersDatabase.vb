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

        Public Sub UpdateOrder(orderID As Integer, quantity As Integer)
            If Not Utils.ValidID(orderID) Then
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
            End If

            If quantity < 1 Then
                Throw New ArgumentException($"Quantity values must be greater than or equal to 1")
            End If

            UpdateOrder(New SqlParameter("OrderID", orderID), New SqlParameter("Quantity", quantity))
        End Sub

        Private Sub UpdateOrder(ParamArray params As SqlParameter())
            Throw New Exception("Update Order not implemented yet")
        End Sub
        Public Sub CancelOrder(orderID As Integer)
            CancelOrder(New SqlParameter("OrderID", orderID))
        End Sub

        Private Sub CancelOrder(ParamArray params As SqlParameter())
            Throw New Exception("CancelOrder Not Yet Implemented")
        End Sub

        Public Sub CompleteOrder(orderID As Integer)
            CompleteOrder(New SqlParameter("OrderID", orderID))
        End Sub

        Private Sub CompleteOrder(ParamArray params As SqlParameter())
            Throw New Exception("CompleteOrder Not Yet Implemented")
        End Sub

        Public Function GetOrderById(id As Integer) As Order
            Throw New Exception("GetOrderById Not Yet Implemented")
        End Function

        Public Function GetOrderByCustomerId(id As Integer) As DBEntryCollection(Of Order)
            Throw New Exception("GetOrderById Not Yet Implemented")
        End Function
    End Class
End Namespace
