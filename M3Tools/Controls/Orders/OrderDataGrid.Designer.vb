Namespace SPPBC.M3Tools.Data
    Partial Class OrderDataGrid
        Inherits Data.DataGrid(Of M3Tools.Types.Order)

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            bsOrders = New Data.OrderBindingSource()
            CType(bsOrders, ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bsOrders
            ' 
            bsOrders.DataSource = GetType(M3Tools.Types.OrderCollection)
            ' 
            ' OrderDataGrid
            ' 
            Me.DataSource = bsOrders
            Me.RowTemplate.Height = 28
            CType(bsOrders, ComponentModel.ISupportInitialize).EndInit()
            CType(Me, ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Friend bsOrders As Data.OrderBindingSource
    End Class
End Namespace
