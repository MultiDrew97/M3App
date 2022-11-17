Namespace DataTables
    <Serializable>
    Public Class ItemsDataTable
        Inherits TypedTableBase(Of ItemsDataRow)

        Public Delegate Sub ItemsDataRowChangeEventHandler(sender As Object, e As ItemsRowChangeEvent)

        Private ItemID As DataColumn
        Private ItemName As DataColumn
        Private Stock As DataColumn
        Private Price As DataColumn
        Private Available As DataColumn

        <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
        Public Sub New()
            MyBase.New
            Me.TableName = "Items"
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        Friend Sub New(table As DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        Protected Sub New(info As Runtime.Serialization.SerializationInfo, context As Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars()
        End Sub

        Public Overridable Shadows Sub GetObjectData(info As Runtime.Serialization.SerializationInfo, context As Runtime.Serialization.StreamingContext)
            MyBase.GetObjectData(info, context)
        End Sub

        Public ReadOnly Property ItemIdColumn() As DataColumn
            Get
                Return Me.ItemID
            End Get
        End Property

        Public ReadOnly Property ItemNameColumn() As DataColumn
            Get
                Return Me.ItemName
            End Get
        End Property

        Public ReadOnly Property StockColumn() As DataColumn
            Get
                Return Me.Stock
            End Get
        End Property

        Public ReadOnly Property PriceColumn As DataColumn
            Get
                Return Me.Price
            End Get
        End Property

        Public ReadOnly Property AvailableColumn() As DataColumn
            Get
                Return Me.Available
            End Get
        End Property

        Public ReadOnly Property CompletedDateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.CompletedDate
            End Get
        End Property

        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        Default Public ReadOnly Property Item(index As Integer) As ItemsDataRow
            Get
                Return CType(Me.Rows(index), ItemsDataRow)
            End Get
        End Property

        Public Event ItemsDataRowChanging As ItemsDataRowChangeEventHandler

        Public Event ItemsDataRowChanged As ItemsDataRowChangeEventHandler

        Public Event ItemsDataRowDeleting As ItemsDataRowChangeEventHandler

        Public Event ItemsDataRowDeleted As ItemsDataRowChangeEventHandler

        Public Sub AddOrdersRow(ByVal row As Rows.OrdersDataRow)
            AddOrdersRow(CInt(row("OrderID")), CStr(row("CustomerName")), CStr(row("ItemName")), CInt(row("Quantity")), CDec(row("OrderTotal")), CDate(row("OrderDate")))
        End Sub

        Public Function AddOrdersRow(OrderID As Integer, CustomerName As String, ItemName As String, Quantity As Integer, OrderTotal As Double, OrderDate As Date) As Rows.OrdersDataRow
            Dim OrdersDataRow As Rows.OrdersDataRow = CType(Me.NewRow, Rows.OrdersDataRow)
            OrdersDataRow.ItemArray = {OrderID, CustomerName, ItemName, Quantity, OrderTotal, OrderDate}
            Me.Rows.Add(ItemsDataRow)
            Return ItemsDataRow
        End Function

        Public Function FindByID(ID As Integer) As ItemsDataRow
            Return CType(Me.Rows.Find(New Object() {ID}), ItemsDataRow)
        End Function

        Public Overrides Function Clone() As DataTable
            Dim cln As ItemsDataTable = CType(MyBase.Clone, ItemsDataTable)
            cln.InitVars()
            Return cln
        End Function

        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ItemsDataTable()
        End Function

        Friend Sub InitVars()
            Me.ItemID = MyBase.Columns("OrderID")
            Me.ItemName = MyBase.Columns("ItemName")
            Me.Quantity = MyBase.Columns("Quantity")
            Me.OrderTotal = MyBase.Columns("OrderTotal")
            Me.OrderDate = MyBase.Columns("OrderDate")
        End Sub

        Private Sub InitClass()
            Me.ItemID = New DataColumn("ItemID", GetType(Integer), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.ItemID)
            Me.ItemName = New DataColumn("ItemName", GetType(String), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.ItemName)
            Me.Quantity = New DataColumn("Quantity", GetType(Integer), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.Quantity)
            Me.OrderTotal = New DataColumn("OrderTotal", GetType(Double), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.OrderTotal)
            Me.OrderDate = New DataColumn("OrderDate", GetType(Date), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.OrderDate)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.OrderID}, True))
            Me.OrderID.AllowDBNull = False
            Me.OrderID.ReadOnly = True
            Me.ItemID.Unique = True
            Me.ItemName.AllowDBNull = False
            Me.ItemName.MaxLength = 100
            Me.Stock.AllowDBNull = False
            Me.Available.AllowDBNull = False
        End Sub

        Public Function NewItemsDataRow() As ItemsDataRow
            Return CType(Me.NewRow, ItemsDataRow)
        End Function
        Return CType(Me.NewRow, ItemsDataRow)
        End Function

        Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
            Return New ItemsDataRow(builder)
        End Function

        Protected Overrides Function GetRowType() As Type
            Return GetType(ItemsDataRow)
        End Function

        Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            End If
        End Sub

        Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If ((Me.ItemsDataRowChangingEvent) IsNot Nothing) Then
                RaiseEvent ItemsDataRowChanging(Me, New ItemsRowChangeEvent(CType(e.Row, ItemsDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If ((Me.ItemsDataRowDeletedEvent) IsNot Nothing) Then
                RaiseEvent ItemsDataRowDeleted(Me, New ItemsRowChangeEvent(CType(e.Row, ItemsDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If ((Me.ItemsDataRowDeletingEvent) IsNot Nothing) Then
                RaiseEvent ItemsDataRowDeleting(Me, New ItemsRowChangeEvent(CType(e.Row, ItemsDataRow), e.Action))
            End If
        End Sub

        Public Sub RemoveItemsRow(row As ItemsDataRow)
            Me.Rows.Remove(row)
        End Sub

        'Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        '    Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        '    Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        '    Dim ds As MediaMinistryDataSet = New MediaMinistryDataSet()
        '    Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        '    any1.Namespace = "http://www.w3.org/2001/XMLSchema"
        '    any1.MinOccurs = New Decimal(0)
        '    any1.MaxOccurs = Decimal.MaxValue
        '    any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
        '    sequence.Items.Add(any1)
        '    Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        '    any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
        '    any2.MinOccurs = New Decimal(1)
        '    any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
        '    sequence.Items.Add(any2)
        '    Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
        '    attribute1.Name = "namespace"
        '    attribute1.FixedValue = ds.Namespace
        '    type.Attributes.Add(attribute1)
        '    Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
        '    attribute2.Name = "tableTypeName"
        '    attribute2.FixedValue = "InventoryDataTable"
        '    type.Attributes.Add(attribute2)
        '    type.Particle = sequence
        '    Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        '    If xs.Contains(dsSchema.TargetNamespace) Then
        '        Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        '        Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        '        Try
        '            Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
        '            dsSchema.Write(s1)
        '            Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
        '            Do While schemas.MoveNext
        '                schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
        '                s2.SetLength(0)
        '                schema.Write(s2)
        '                If (s1.Length = s2.Length) Then
        '                    s1.Position = 0
        '                    s2.Position = 0

        '                    Do While ((s1.Position <> s1.Length) _
        '                            AndAlso (s1.ReadByte = s2.ReadByte))


        '                    Loop
        '                    If (s1.Position = s1.Length) Then
        '                        Return type
        '                    End If
        '                End If

        '            Loop
        '        Finally
        '            If ((s1) IsNot Nothing) Then
        '                s1.Close()
        '            End If
        '            If ((s2) IsNot Nothing) Then
        '                s2.Close()
        '            End If
        '        End Try
        '    End If
        '    xs.Add(dsSchema)
        '    Return type
        'End Function
    End Class
End Namespace
