Imports System.ComponentModel
Imports System.Windows.Forms

Namespace SPPBC.M3Tools.Data
    ''' <summary>
    ''' Custom data grid to use for displaying order information
    ''' </summary>
    Public Partial Class OrderDataGrid
        ' Columns for the data grid
        Private ReadOnly dgc_CustomerName As DataGridViewTextBoxColumn
        Private ReadOnly dgc_ItemName As DataGridViewTextBoxColumn
        Private ReadOnly dgc_OrderTotal As DataGridViewTextBoxColumn
        Private ReadOnly dgc_Quantity As DataGridViewTextBoxColumn
        Private ReadOnly dgc_OrderDate As DataGridViewTextBoxColumn
        Private ReadOnly dgc_CompletedDate As DataGridViewTextBoxColumn

        ''' <summary>
        ''' Event that occurs when a order is being added to the database
        ''' </summary>
        Public Event AddOrder As M3Tools.Events.Orders.OrderEventHandler

        ''' <summary>
        ''' Event that occurs when a order is being removed from the database
        ''' </summary>
        Public Event RemoveOrder As M3Tools.Events.Orders.OrderEventHandler

        ''' <summary>
        ''' Event that occurs when a order is being updated in the database
        ''' </summary>
        Public Event UpdateOrder As M3Tools.Events.Orders.OrderEventHandler

        ''' <summary>
        ''' The list of orders currently in the data grid
        ''' </summary>
        <Browsable(False)>
        Public Property Orders As M3Tools.Types.OrderCollection
            Get
                Return M3Tools.Types.OrderCollection.Cast(bsOrders.List)
            End Get
            Set(value As M3Tools.Types.OrderCollection)
                If MyBase.DesignMode Then
                    Return
                End If

                bsOrders.DataSource = value
            End Set
        End Property

        ''' <summary>
        ''' The filter to place on the data in the grid
        ''' </summary>
        Public Property Filter As String
            Get
                Return bsOrders.Filter
            End Get
            Set(value As String)
                bsOrders.Filter = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        <Browsable(False)>
        Public ReadOnly Property SelectedOrders As M3Tools.Types.OrderCollection
            Get
                Return M3Tools.Types.OrderCollection.Cast(MyBase.SelectedRows)
            End Get
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub New()
            MyBase.New()
            InitializeComponent()

            dgc_CustomerName = New DataGridViewTextBoxColumn()
            dgc_ItemName = New DataGridViewTextBoxColumn()
            dgc_OrderTotal = New DataGridViewTextBoxColumn()
            dgc_Quantity = New DataGridViewTextBoxColumn()
            dgc_OrderDate = New DataGridViewTextBoxColumn()
            dgc_CompletedDate = New DataGridViewTextBoxColumn()

            LoadColumns()

            AddHandler AddEntry, Sub(sender, e)             ''' Cannot convert ConditionalAccessExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.TryCreateRaiseEventStatement(ExpressionSyntax invokedCsExpression, ArgumentListSyntax argumentListSyntax, VisualBasicSyntaxNode& visitInvocationExpression)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AddOrder?.Invoke(sender, new(e.Value, e.EventType))
''' 
            AddHandler UpdateEntry, Sub(sender, e)             ''' Cannot convert ConditionalAccessExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.TryCreateRaiseEventStatement(ExpressionSyntax invokedCsExpression, ArgumentListSyntax argumentListSyntax, VisualBasicSyntaxNode& visitInvocationExpression)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' UpdateOrder?.Invoke(sender, new(e.Value, e.EventType))
''' 
            AddHandler RemoveEntry, Sub(sender, e)             ''' Cannot convert ConditionalAccessExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.TryCreateRaiseEventStatement(ExpressionSyntax invokedCsExpression, ArgumentListSyntax argumentListSyntax, VisualBasicSyntaxNode& visitInvocationExpression)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' RemoveOrder?.Invoke(sender, new(e.Value, e.EventType))
''' 
        End Sub

        ''' <summary>
        ''' <inheritdoc/>
        ''' </summary>
        Protected Overrides Sub LoadColumns()
            MyBase.LoadColumns()

            MyBase.dgc_ID.HeaderText = "OrderID"

            ' Customer Column
            dgc_CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgc_CustomerName.DataPropertyName = "Customer.Name"
            dgc_CustomerName.FillWeight = 25F
            dgc_CustomerName.HeaderText = "Customer"
            dgc_CustomerName.MinimumWidth = 10
            dgc_CustomerName.Name = "dgc_CustomerName"

            ' Item Column
            dgc_ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgc_ItemName.DataPropertyName = "Item.Name"
            dgc_ItemName.FillWeight = 25F
            dgc_ItemName.HeaderText = "Item"
            dgc_ItemName.MinimumWidth = 10
            dgc_ItemName.Name = "dgc_ItemName"

            ' Quantity Column
            dgc_Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgc_Quantity.DataPropertyName = "Quantity"
            dgc_Quantity.FillWeight = 25F
            dgc_Quantity.HeaderText = "Quantity"
            dgc_Quantity.MinimumWidth = 10
            dgc_Quantity.Name = "dgc_Quantity"

            ' Order Total Column
            dgc_OrderTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgc_OrderTotal.DataPropertyName = "Total"
                        ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 			this.dgc_OrderTotal.DefaultCellStyle = new() { Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter, Format = "C2", NullValue = "$0.00" }
''' 
            dgc_OrderTotal.FillWeight = 25F
            dgc_OrderTotal.HeaderText = "Total"
            dgc_OrderTotal.MinimumWidth = 50
            dgc_OrderTotal.Name = "dgc_OrderTotal"

            ' Order Placed Date Column
            dgc_OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgc_OrderDate.DataPropertyName = "OrderDate"
                        ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 			this.dgc_OrderDate.DefaultCellStyle = new() { Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" }
''' 
            dgc_OrderDate.FillWeight = 25F
            dgc_OrderDate.HeaderText = "Ordered"
            dgc_OrderDate.MinimumWidth = 10
            dgc_OrderDate.Name = "dgc_OrderDate"

            ' Order Completed Date Column
            dgc_CompletedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgc_CompletedDate.DataPropertyName = "CompletedDate"
                        ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 			this.dgc_CompletedDate.DefaultCellStyle = new() { Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" }
''' 
            dgc_CompletedDate.FillWeight = 25F
            dgc_CompletedDate.HeaderText = "Completed"
            dgc_CompletedDate.MinimumWidth = 10
            dgc_CompletedDate.Name = "dgc_CompletedDate"

            MyBase.Columns.AddRange(New DataGridViewColumn() {MyBase.dgc_Selection, MyBase.dgc_ID, dgc_CustomerName, dgc_ItemName, dgc_Quantity, dgc_OrderTotal, dgc_OrderDate, dgc_CompletedDate, MyBase.dgc_Edit, MyBase.dgc_Remove})
        End Sub
    End Class
End Namespace
