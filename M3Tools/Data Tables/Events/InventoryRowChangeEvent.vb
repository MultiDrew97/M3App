Namespace DataTables.Events
	Public Class InventoryRowChangeEvent
		Inherits EventArgs

		Private ReadOnly eventRow As Rows.InventoryDataRow

		Private ReadOnly eventAction As DataRowAction

		Public Sub New(row As Rows.InventoryDataRow, action As DataRowAction)
			MyBase.New
			Me.eventRow = row
			Me.eventAction = action
		End Sub

		Public ReadOnly Property Row() As Rows.InventoryDataRow
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
