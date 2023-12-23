Namespace DataTables
	Public Class InventoryDataRow
		Inherits DataRow

		Private ReadOnly tableItems As InventoryDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
			MyBase.New(rb)
			Me.tableItems = CType(Me.Table, InventoryDataTable)
		End Sub

		Public ReadOnly Property ItemID As Integer
			Get
				Return CInt(Me(Me.tableItems.ItemIdColumn))
			End Get
		End Property

		Public Property Name() As String
			Get
				Return CStr(Me(Me.tableItems.NameColumn))
			End Get
			Set
				Me(Me.tableItems.NameColumn) = Value
			End Set
		End Property
		Public Property Stock() As Integer
			Get
				Return CInt(Me(Me.tableItems.StockColumn))
			End Get
			Set
				Me(Me.tableItems.StockColumn) = Value
			End Set
		End Property

		Public Property Price() As Decimal
			Get
				Return CDec(Me(Me.tableItems.PriceColumn))
			End Get
			Set
				Me(Me.tableItems.PriceColumn) = Value
			End Set
		End Property
		Public ReadOnly Property Available() As Boolean
			Get
				Return CBool(Me(Me.tableItems.AvailableColumn))
			End Get
		End Property

		Public ReadOnly Property Product As Types.Product
			Get
				Return New Types.Product(ItemID, Name, Stock, Price, Available)
			End Get
		End Property
	End Class
End Namespace
