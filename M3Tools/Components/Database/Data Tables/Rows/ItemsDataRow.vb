Namespace CustomData
	Public Class ItemsDataRow
		Inherits DataRow

		Private ReadOnly tableItems As ItemsDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
			MyBase.New(rb)
			Me.tableItems = CType(Me.Table, ItemsDataTable)
		End Sub

		Public ReadOnly Property ItemID As Integer
			Get
				Return CInt(Me(Me.tableItems.ItemIdColumn))
			End Get
		End Property

		Public Property ItemName() As String
			Get
				Return CStr(Me(Me.tableItems.ItemNameColumn))
			End Get
			Set
				Me(Me.tableItems.ItemNameColumn) = Value
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

		Public Property Price() As Double
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
    End Class
End Namespace