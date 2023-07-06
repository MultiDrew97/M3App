Imports System.Collections.ObjectModel
Imports SPPBC.M3Tools.Types
Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace Database
	' TODO: Rename to ItemsDatabase
	Public NotInheritable Class ProductDatabase
		' TODO: Create a dictionary for mapping proper column names to make it easier to manage
		Private Const TableName As String = "Items"

		<EditorBrowsable()>
		<Description("The username to use for the database connection")>
		<SettingsBindable(True)>
		Public Property Username As String
			Get
				Return dbConnection.Username
			End Get
			Set(value As String)
				dbConnection.Username = value
			End Set
		End Property

		'The password to use for the database connection
		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<Description("The password to use for the database connection")>
		Public Property Password As String
			Get
				Return dbConnection.Password
				'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
			End Get
			Set(value As String)
				'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
				'Console.WriteLine(temp)
				'__connectionString.Password = temp
				dbConnection.Password = value
			End Set
		End Property

		'The initial catalog to use for the database connection
		<Bindable(True)>
		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Public Property InitialCatalog As String
			Get
				Return dbConnection.InitialCatalog
			End Get
			Set(value As String)
				dbConnection.InitialCatalog = value
			End Set
		End Property
		Public Function GetProduct(itemID As Integer) As Product
			Return GetProduct(New SqlParameter("ItemID", itemID))
		End Function

		Public Function GetProduct(ParamArray param As SqlParameter()) As Product
			Using cmd = dbConnection.Connect()
				cmd.Parameters.AddRange(param)
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{TableName}] WHERE ItemID = @ItemID"

				Using reader = cmd.ExecuteReaderAsync().Result
					Do While reader.Read()
						Return New Product(CInt(reader(ColumnNames.ID)), CStr(reader(ColumnNames.Name)),
												 CInt(reader(ColumnNames.Stock)), CDec(reader(ColumnNames.Price)),
												 CBool(reader(ColumnNames.Available)))
					Loop
				End Using
			End Using

			Return Nothing
		End Function

		Public Function GetProducts() As ProductCollection
			Dim products As New ProductCollection()

			Using cmd = dbConnection.Connect
				cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{TableName}]"

				Using reader = cmd.ExecuteReader()
					Do While reader.Read
						products.Add(New Product(CInt(reader(ColumnNames.ID)), CStr(reader(ColumnNames.Name)),
												 CInt(reader(ColumnNames.Stock)), CDec(reader(ColumnNames.Price)),
												 CBool(reader(ColumnNames.Available))))
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
				New SqlParameter("Price", price),
				New SqlParameter("Available", If(stock > 0, 1, 0))
			)
		End Sub

		Private Sub AddNewProduct(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect
				cmd.Parameters.AddRange(params)

				cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddItem]"
				cmd.CommandType = CommandType.StoredProcedure

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub UpdateInventory(itemID As Integer, itemName As String, stock As Integer, price As Double, available As Boolean)
			UpdateInventory(New SqlParameter("ItemID", itemID), New SqlParameter("ItemName", itemName),
							New SqlParameter("Stock", stock), New SqlParameter("Price", price),
							New SqlParameter("Available", If(available, 1, 0)))
		End Sub

		Public Sub UpdateInventory(item As Product)
			UpdateInventory(item.Id, item.Name, item.Stock, item.Price, item.Available)
		End Sub

		Private Sub UpdateInventory(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_UpdateItem]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub

		Public Sub RemoveProduct(itemID As Integer)
			RemoveProduct(New SqlParameter("ItemID", itemID))
		End Sub

		Private Sub RemoveProduct(ParamArray params As SqlParameter())
			Using cmd = dbConnection.Connect
				cmd.CommandText = $"[{My.Settings.Schema}].[sp_RemoveItem]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddRange(params)

				cmd.ExecuteNonQuery()
			End Using
		End Sub

		Private Sub ChangeAvailability(ParamArray params As SqlParameter())

			Using cmd = dbConnection.Connect
				cmd.Parameters.AddRange(params)

				cmd.CommandText = $"UPDATE [{My.Settings.Schema}].[{TableName}] SET Available = @Available WHERE ItemID = @ItemID"
				cmd.ExecuteNonQueryAsync()
			End Using
		End Sub



		Private Structure ColumnNames
			Shared ReadOnly Property ID As String = "ItemID"
			Shared ReadOnly Property Name As String = "ItemName"
			Shared ReadOnly Property Stock As String = "Stock"
			Shared ReadOnly Property Price As String = "Price"
			Shared ReadOnly Property Available As String = "Available"

			Shared ReadOnly Property Message As String = "Message"
		End Structure
	End Class
End Namespace