Namespace CustomData
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

            End Set
        End Property

        Public Property NAME() As String
            Get
                Return CStr(Me(Me.tableEmailListeners.NAMEColumn))
            End Get
            Set
                Me(Me.tableEmailListeners.NAMEColumn) = Value
            End Set
        End Property

        Public Property EMAIL() As String
            Get
                Return CStr(Me(Me.tableEmailListeners.EMAILColumn))
            End Get
            Set
                Me(Me.tableEmailListeners.EMAILColumn) = Value
            End Set
        End Property
    End Class
End Namespace