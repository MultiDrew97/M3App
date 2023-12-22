Namespace DataTables
    Public Class ProductsRowChangeEvent
        Inherits EventArgs

        Private eventRow As ProductsDataRow

        Private eventAction As DataRowAction

        Public Sub New(row As ProductsDataRow, action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        Public ReadOnly Property Row() As ProductsDataRow
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
