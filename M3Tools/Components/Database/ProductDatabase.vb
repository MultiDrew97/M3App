﻿Imports System.Collections.ObjectModel
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

		Public Function GetProduct(ParamArray param As SqlParameter()) As Product
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(param)
				_cmd.CommandText = "SELECT * FROM Inventory WHERE ItemID = @ItemID"

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						Return New Product(CInt(reader("ItemID")), CStr(reader("ItemName")),
												 CInt(reader("Stock")), CDec(reader("Price")),
												 CBool(reader("Available")))
					Loop
				End Using
			End Using

			Return Nothing
		End Function

		Public Function GetProducts() As Collection(Of Product)
			Dim products As New Collection(Of Product)

			Using _cmd = db_Connection.Connect
				_cmd.CommandText = "SELECT * FROM Inventory"

				Using reader = _cmd.ExecuteReaderAsync().Result
					Do While reader.Read
						products.Add(New Product(CInt(reader("ItemID")), CStr(reader("ItemName")),
												 CInt(reader("Stock")), CDec(reader("Price")),
												 CBool(reader("Available"))))
					Loop
				End Using
			End Using

			Return products
		End Function

		Public Sub AddNewProduct(product As Product)
            AddNewProduct(product.Name, product.Stock, product.Price)
        End Sub

        Public Sub AddNewProduct(itemName As String, stock As Integer, price As Double)
			AddNewProduct(
				New SqlParameter("ItemName", itemName),
				New SqlParameter("Stock", stock),
				New SqlParameter("Price", price)
			)
		End Sub

		Private Sub AddNewProduct(ParamArray params As SqlParameter())
			Using _cmd = db_Connection.Connect
				_cmd.Parameters.AddRange(params)

				_cmd.CommandText = "AddProduct"
				_cmd.CommandType = CommandType.StoredProcedure

				_cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub UpdateInventory(itemID As Integer, column As String, value As String)
			' TODO: Figure out a better way to perform row updates
			Dim command As New SqlParameter("Command", SqlDbType.VarChar)

			If column <> "Stock" And column <> "Price" Then
				command.Value = $"{column} = '{value}'"
			Else
				command.Value = $"{column} = {value}"
			End If

			Me.UpdateInventory(New SqlParameter("ItemID", itemID), command)
			'myCmd.Parameters.AddWithValue("ItemID", itemID)
			'If Not (column.Equals("Stock") Or column.Equals("Price")) Then
			'    command = String.Format("{0} = '{1}'", column, value)
			'Else
			'    command = String.Format("{0} = {1}", column, value)
			'End If

			'myCmd.CommandText = String.Format("UPDATE INVENTORY SET {0} WHERE ItemID = @ItemID", command)

			'myCmd.ExecuteNonQuery()
		End Sub

		Private Sub UpdateInventory(ParamArray param As SqlParameter())
			Using cmd = db_Connection.Connect
				cmd.Parameters.AddRange(param)
				' TODO: Verify I can do this
				Console.WriteLine(cmd.Parameters("Command"))
				cmd.CommandText = $"UPDATE Inventory SET {cmd.Parameters("Command")} WHERE ItemID = @ItemID"

				cmd.ExecuteNonQueryAsync()
			End Using
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