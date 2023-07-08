Namespace DataTables
    Public Class ItemsRowChangeEvent
        Inherits EventArgs

        Private eventRow As ItemsDataRow

        Private eventAction As DataRowAction

        Public Sub New(row As ItemsDataRow, action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        Public ReadOnly Property Row() As ItemsDataRow
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
