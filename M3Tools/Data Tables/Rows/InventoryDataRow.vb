Namespace DataTables.Rows
	Public Class InventoryDataRow
		Inherits DataRow

		Private ReadOnly tableInventory As InventoryDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
			MyBase.New(rb)
			Me.tableInventory = CType(Me.Table, InventoryDataTable)
		End Sub

		Public ReadOnly Property ItemID As Integer
			Get
				Return CInt(Me(Me.tableInventory.ItemIdColumn))
			End Get
		End Property

		Public Property ItemName() As String
			Get
				Return CStr(Me(Me.tableInventory.ItemNameColumn))
			End Get
			Set
				Me(Me.tableInventory.ItemNameColumn) = Value
			End Set
		End Property
		Public Property Stock() As Integer
			Get
				Return CInt(Me(Me.tableInventory.StockColumn))
			End Get
			Set
				Me(Me.tableInventory.StockColumn) = Value
			End Set
		End Property

		Public Property Price() As Double
			Get
				Return CDec(Me(Me.tableInventory.PriceColumn))
			End Get
			Set
				Me(Me.tableInventory.PriceColumn) = Value
			End Set
		End Property
		Public ReadOnly Property Available() As Boolean
			Get
				Return CBool(Me(Me.tableInventory.AvailableColumn))
			End Get
		End Property
	End Class
End Namespace