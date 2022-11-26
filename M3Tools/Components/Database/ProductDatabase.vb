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

		Public Function GetProduct(ParamArray param As SqlParameter()) As Product
			Using _cmd = db_Connection.Connect()
				_cmd.Parameters.AddRange(param)
				_cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[Items] WHERE ItemID=@ItemID"

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
				_cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[Items]"

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

				_cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddProduct]"
				_cmd.CommandType = CommandType.StoredProcedure

				_cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub UpdateInventory(itemID As Integer, column As String, value As String)
			' TODO: Figure out a better way to perform row updates
			If Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must greater than or equal to {My.Settings.MinID}")
			End If

			Dim command As String

			If column <> "Stock" And column <> "Price" Then
				command = $"{column} = '{value}'"
			Else
				command = $"{column} = {value}"
			End If

			Me.UpdateInventory(command, New SqlParameter("ItemID", itemID))
			'myCmd.Parameters.AddWithValue("ItemID", itemID)
			'If Not (column.Equals("Stock") Or column.Equals("Price")) Then
			'    command = String.Format("{0} = '{1}'", column, value)
			'Else
			'    command = String.Format("{0} = {1}", column, value)
			'End If

			'myCmd.CommandText = String.Format("UPDATE INVENTORY SET {0} WHERE ItemID = @ItemID", command)

			'myCmd.ExecuteNonQuery()
		End Sub

		Private Sub UpdateInventory(command As String, ParamArray param As SqlParameter())
			Using cmd = db_Connection.Connect
				cmd.Parameters.AddRange(param)
				' TODO: Verify I can do this
				Console.WriteLine(cmd.Parameters("Command"))
				cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[Items] SET {command} WHERE ItemID=@ItemID"

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub RemoveProduct(itemID As Integer)
			If Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			RemoveProduct(New SqlParameter("ItemID", itemID))
		End Sub

		Private Sub RemoveProduct(ParamArray param As SqlParameter())
			' TODO: Verify this works
			ChangeAvailability(param.Append(New SqlParameter("Available", 0)).ToArray)
		End Sub

		Public Sub ChangeAvailability(itemID As Integer, value As Boolean)
			If Not Utils.ValidID(itemID) Then
				Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
			End If

			ChangeAvailability(New SqlParameter("ItemID", itemID), New SqlParameter("Available", If(value, 1, 0)))
		End Sub

		Private Sub ChangeAvailability(ParamArray params As SqlParameter())
			Console.WriteLine(params.Length)
			Using _cmd = db_Connection.Connect
				_cmd.Parameters.AddRange(params)

				_cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[Items] SET Available = @Available WHERE ItemID = @ItemID"

				_cmd.ExecuteNonQueryAsync()
			End Using
		End Sub
	End Class
End Namespace