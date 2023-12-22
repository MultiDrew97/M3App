Namespace DataTables
	<Serializable>
	<Obsolete("No longer needed. Use OrdersDataGrid Component instead for designer and DBEntryCollection in Types namespace for collections.")>
	Public Class OrdersDataTable
        Inherits TypedTableBase(Of OrdersDataRow)

        Public Delegate Sub OrdersDataRowChangeEventHandler(ByVal sender As Object, ByVal e As OrdersRowChangeEvent)

        Private OrderID As DataColumn
        Private CustomerName As DataColumn
        Private ItemName As DataColumn
        Private Quantity As DataColumn
        Private OrderTotal As DataColumn
		Private OrderDate As DataColumn
		Private CompletedDate As DataColumn

		Public Sub New()
            MyBase.New
            Me.TableName = "Orders"
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

        Public ReadOnly Property OrderIdColumn() As DataColumn
            Get
                Return Me.OrderID
            End Get
        End Property

        Public ReadOnly Property CustomerNameColumn() As DataColumn
            Get
                Return Me.CustomerName
            End Get
        End Property

        Public ReadOnly Property ItemNameColumn() As Global.System.Data.DataColumn
            Get
                Return Me.ItemName
            End Get
        End Property

        Public ReadOnly Property QuantityColumn() As Global.System.Data.DataColumn
            Get
                Return Me.Quantity
            End Get
        End Property

        Public ReadOnly Property OrderTotalColumn As DataColumn
            Get
                Return Me.OrderTotal
            End Get
        End Property

		Public ReadOnly Property OrderDateColumn() As Global.System.Data.DataColumn
			Get
				Return Me.OrderDate
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

        Default Public ReadOnly Property Item(ByVal index As Integer) As OrdersDataRow
            Get
                Return CType(Me.Rows(index), OrdersDataRow)
            End Get
        End Property

        Public Event OrdersDataRowChanging As OrdersDataRowChangeEventHandler

        Public Event OrdersDataRowChanged As OrdersDataRowChangeEventHandler

        Public Event OrdersDataRowDeleting As OrdersDataRowChangeEventHandler

        Public Event OrdersDataRowDeleted As OrdersDataRowChangeEventHandler

        Public Sub AddOrdersRow(ByVal row As OrdersDataRow)
			AddOrdersRow(CInt(row("OrderID")), CStr(row("CustomerName")), CStr(row("ItemName")), CInt(row("Quantity")), CDec(row("OrderTotal")), CDate(row("OrderDate")), CDate(row("CompletedDate")))
		End Sub

		Public Function AddOrdersRow(OrderID As Integer, CustomerName As String, ItemName As String, Quantity As Integer, OrderTotal As Double, OrderDate As Date, Optional CompletedDate As Date = Nothing) As OrdersDataRow
			Dim OrdersDataRow As OrdersDataRow = CType(Me.NewRow, OrdersDataRow)
			OrdersDataRow.ItemArray = {OrderID, CustomerName, ItemName, Quantity, OrderTotal, ParseDate(OrderDate), ParseDate(CompletedDate)}
			Me.Rows.Add(OrdersDataRow)
			Return OrdersDataRow
		End Function

		Private Function ParseDate(value As Date) As Object
			If value.Year < 1950 Then
				Return Nothing
			End If

			Return value
		End Function

		Public Function FindByID(ByVal ID As Integer) As OrdersDataRow
            Return CType(Me.Rows.Find(New Object() {ID}), OrdersDataRow)
        End Function

        Public Overrides Function Clone() As DataTable
            Dim cln As OrdersDataTable = CType(MyBase.Clone, OrdersDataTable)
            cln.InitVars()
            Return cln
        End Function

        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New OrdersDataTable()
        End Function

        Friend Sub InitVars()
            Me.OrderID = MyBase.Columns("OrderID")
            Me.CustomerName = MyBase.Columns("CustomerName")
            Me.ItemName = MyBase.Columns("ItemName")
            Me.Quantity = MyBase.Columns("Quantity")
            Me.OrderTotal = MyBase.Columns("OrderTotal")
			Me.OrderDate = MyBase.Columns("OrderDate")
			Me.CompletedDate = MyBase.Columns("CompletedDate")
		End Sub

        Private Sub InitClass()
            Me.OrderID = New DataColumn("OrderID", GetType(Integer), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.OrderID)
            Me.CustomerName = New DataColumn("CustomerName", GetType(String), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.CustomerName)
            Me.ItemName = New DataColumn("ItemName", GetType(String), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.ItemName)
            Me.Quantity = New DataColumn("Quantity", GetType(Integer), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.Quantity)
            Me.OrderTotal = New DataColumn("OrderTotal", GetType(Double), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.OrderTotal)
            Me.OrderDate = New DataColumn("OrderDate", GetType(Date), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.OrderDate)
			Me.CompletedDate = New DataColumn("CompletedDate", GetType(Date), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.CompletedDate)
			Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.OrderID}, True))
            Me.OrderID.AllowDBNull = False
            Me.OrderID.ReadOnly = True
            Me.OrderID.Unique = True
            Me.CustomerName.AllowDBNull = False
            Me.CustomerName.MaxLength = 50
            Me.ItemName.AllowDBNull = False
            Me.ItemName.MaxLength = 100
            Me.Quantity.AllowDBNull = False
            Me.OrderTotal.ReadOnly = True
            Me.OrderDate.AllowDBNull = False
			Me.OrderDate.ReadOnly = True
			Me.CompletedDate.AllowDBNull = True
			Me.CompletedDate.ReadOnly = True
			Me.CompletedDate.DefaultValue = DBNull.Value
		End Sub

        Public Function NewOrdersDataRow() As OrdersDataRow
            Return CType(Me.NewRow, OrdersDataRow)
        End Function

        Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
            Return New OrdersDataRow(builder)
        End Function

        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(OrdersDataRow)
        End Function

        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If ((Me.OrdersDataRowChangedEvent) IsNot Nothing) Then
                RaiseEvent OrdersDataRowChanged(Me, New OrdersRowChangeEvent(CType(e.Row, OrdersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If ((Me.OrdersDataRowChangingEvent) IsNot Nothing) Then
                RaiseEvent OrdersDataRowChanging(Me, New OrdersRowChangeEvent(CType(e.Row, OrdersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If ((Me.OrdersDataRowDeletedEvent) IsNot Nothing) Then
                RaiseEvent OrdersDataRowDeleted(Me, New OrdersRowChangeEvent(CType(e.Row, OrdersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If ((Me.OrdersDataRowDeletingEvent) IsNot Nothing) Then
                RaiseEvent OrdersDataRowDeleting(Me, New OrdersRowChangeEvent(CType(e.Row, OrdersDataRow), e.Action))
            End If
        End Sub

        Public Sub RemoveOrdersRow(ByVal row As OrdersDataRow)
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
        '    attribute2.FixedValue = "OrdersDataTable"
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
