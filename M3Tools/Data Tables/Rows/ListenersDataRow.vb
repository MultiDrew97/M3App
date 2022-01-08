Namespace DataTables.Rows
	Public Class ListenersDataRow
		Inherits DataRow

		Private ReadOnly tableEmailListeners As ListenersDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
			MyBase.New(rb)
			Me.tableEmailListeners = CType(Me.Table, ListenersDataTable)
		End Sub

		Public Property ListenerID As Integer
			Get
				Return CInt(Me(Me.tableEmailListeners.ListenerIdColumn))
			End Get
			Set
				Me(Me.tableEmailListeners.ListenerIdColumn) = Value
			End Set
		End Property

		Public Property Name As String
			Get
				Return CStr(Me(Me.tableEmailListeners.NameColumn))
			End Get
			Set
				Me(Me.tableEmailListeners.NameColumn) = Value
			End Set
		End Property

		Public Property Email As String
			Get
				Return CStr(Me(Me.tableEmailListeners.EmailColumn))
			End Get
			Set
				Me(Me.tableEmailListeners.EmailColumn) = Value
			End Set
		End Property
	End Class
End Namespace