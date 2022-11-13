Imports System.Collections.ObjectModel
Imports SPPBC.M3Tools.Types
Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace Database
    Public NotInheritable Class ProductDatabase
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
        Public Function GetProduct(itemID As Integer) As Product
            Return GetProduct(New SqlParameter("ItemID", itemID))
        End Function

        Public Function GetProduct(param As SqlParameter) As Product
            Using _cmd = db_Connection.Connect()
                _cmd.Parameters.Add(param)
                _cmd.CommandText = "SELECT * FROM Inventory WHERE ItemID = @ItemID"

                Using reader = _cmd.ExecuteReaderAsync().Result
                    Do While reader.Read()
                        Return New Product() With {
                            .Id = reader.GetInt32(0),
                            .Name = reader.GetString(1),
                            .Stock = reader.GetInt32(2),
                            .Price = reader.GetDecimal(3),
                            .Available = reader.GetBoolean(4)
                        }
                    Loop
                End Using
            End Using

            Return Nothing
        End Function

        Public Function GetProducts() As Product()
            Dim products() As Product = {}

            Using _cmd = db_Connection.Connect
                _cmd.CommandText = "SELECT * FROM Inventory"

                Using reader = _cmd.ExecuteReaderAsync().Result
                    Do While reader.Read
                        products.Append(
                            New Product() With {
                                .Id = reader.GetInt32(0),
                                .Name = reader.GetString(1),
                                .Stock = reader.GetInt32(2),
                                .Price = reader.GetDecimal(3),
                                .Available = reader.GetBoolean(4)
                            }
                        )
                    Loop
                End Using
            End Using

            Return products
        End Function

        Public Sub AddNewProduct(product As Product)
            AddNewProduct(product.Name, product.Stock, product.Price)
        End Sub

        Public Sub AddNewProduct(itemName As String, stock As Integer, price As Double)
            AddNewProduct({
                New SqlParameter("ItemName", itemName),
                New SqlParameter("Stock", stock),
                New SqlParameter("Price", price)
            })
        End Sub

        Private Sub AddNewProduct(params As SqlParameter())
            Using _cmd = db_Connection.Connect
                _cmd.Parameters.AddRange(params)

                _cmd.CommandText = "AddProduct"
                _cmd.CommandType = CommandType.StoredProcedure

                _cmd.ExecuteNonQueryAsync()
            End Using
        End Sub

        Public Sub UpdateInventory(itemID As Integer, column As String, value As String)
            Dim command As String

            Using _cmd = db_Connection.Connect
                _cmd.Parameters.AddWithValue("ItemID", itemID)

                If column <> "Stock" And column <> "Price" Then
					command = $"{column} = '{value}'"
				Else
					command = $"{column} = {value}"
				End If

				_cmd.CommandText = $"UPDATE Inventory SET {command} WHERE ItemID = @ItemID"

				_cmd.ExecuteNonQueryAsync()
            End Using
            'myCmd.Parameters.AddWithValue("ItemID", itemID)
            'If Not (column.Equals("Stock") Or column.Equals("Price")) Then
            '    command = String.Format("{0} = '{1}'", column, value)
            'Else
            '    command = String.Format("{0} = {1}", column, value)
            'End If

            'myCmd.CommandText = String.Format("UPDATE INVENTORY SET {0} WHERE ItemID = @ItemID", command)

            'myCmd.ExecuteNonQuery()
        End Sub

        Public Sub RemoveProduct(itemID As Integer)
            RemoveProduct(New SqlParameter("ItemID", itemID))
        End Sub

        Private Sub RemoveProduct(param As SqlParameter)
            ChangeAvailability({param, New SqlParameter("Available", 0)})
        End Sub

        Public Sub ChangeAvailability(itemID As Integer, value As Boolean)
            ChangeAvailability({New SqlParameter("ItemID", itemID), New SqlParameter("Available", If(value, 1, 0))})
        End Sub

        Private Sub ChangeAvailability(params As SqlParameter())
            Using _cmd = db_Connection.Connect
                _cmd.Parameters.AddRange(params)

                _cmd.CommandText = "UPDATE Inventory SET Available = @Available WHERE ItemID = @ItemID"

                _cmd.ExecuteNonQueryAsync()
            End Using
        End Sub
    End Class
End Namespace