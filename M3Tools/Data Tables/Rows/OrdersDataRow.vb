Namespace DataTables.Rows
	Public Class OrdersDataRow
		Inherits DataRow

		Private ReadOnly tableOrders As OrdersDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
			MyBase.New(rb)
			Me.tableOrders = CType(Me.Table, OrdersDataTable)
		End Sub

		Public ReadOnly Property OrderID As Integer
			Get
				Return CInt(Me(Me.tableOrders.OrderIdColumn))
			End Get
		End Property

		Public Property CustomerName() As String
			Get
				Return CStr(Me(Me.tableOrders.CustomerNameColumn))
			End Get
			Set
				Me(Me.tableOrders.CustomerNameColumn) = Value
			End Set
		End Property

		Public Property ItemName() As String
			Get
				Return CStr(Me(Me.tableOrders.ItemNameColumn))
			End Get
			Set
				Me(Me.tableOrders.ItemNameColumn) = Value
			End Set
		End Property
		Public Property Quantity() As String
			Get
				Return CStr(Me(Me.tableOrders.QuantityColumn))
			End Get
			Set
				Me(Me.tableOrders.QuantityColumn) = Value
			End Set
		End Property

		Public Property OrderTotal() As Double
			Get
				Return CDec(Me(Me.tableOrders.OrderTotalColumn))
			End Get
			Set
				Me(Me.tableOrders.OrderTotalColumn) = Value
			End Set
		End Property

		Public ReadOnly Property OrderDate() As Date
			Get
				Return CDate(Me(Me.tableOrders.OrderDateColumn))
			End Get
		End Property
	End Class
End Namespace