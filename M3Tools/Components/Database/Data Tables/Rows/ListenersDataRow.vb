Namespace DataTables
    Public Class ListenersDataRow
        Inherits DataRow

		Private ReadOnly tableListeners As ListenersDataTable

		Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
			Me.tableListeners = CType(Me.Table, ListenersDataTable)
		End Sub

        Public Property ListenerID As Integer
            Get
				Return CInt(Me(Me.tableListeners.ListenerIdColumn))
			End Get
            Set

            End Set
        End Property

        Public Property NAME() As String
            Get
				Return CStr(Me(Me.tableListeners.NameColumn))
			End Get
            Set
				Me(Me.tableListeners.NameColumn) = Value
			End Set
        End Property

        Public Property EMAIL() As String
            Get
				Return CStr(Me(Me.tableListeners.EmailColumn))
			End Get
            Set
				Me(Me.tableListeners.EmailColumn) = Value
			End Set
        End Property
    End Class
End Namespace