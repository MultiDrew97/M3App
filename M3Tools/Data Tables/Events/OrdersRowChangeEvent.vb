Namespace DataTables.Events
	Public Class OrdersRowChangeEvent
		Inherits EventArgs

		Private ReadOnly eventRow As Rows.OrdersDataRow

		Private ReadOnly eventAction As DataRowAction

		Public Sub New(row As Rows.OrdersDataRow, action As DataRowAction)
			MyBase.New
			Me.eventRow = row
			Me.eventAction = action
		End Sub

		Public ReadOnly Property Row() As Rows.OrdersDataRow
			Get
				Return Me.eventRow
			End Get
		End Property

		Public ReadOnly Property Action() As DataRowAction
			Get
				Return Me.eventAction
			End Get
		End Property
	End Class
End Namespace
