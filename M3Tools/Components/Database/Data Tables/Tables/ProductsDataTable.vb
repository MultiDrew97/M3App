Namespace DataTables
	<Serializable>
	<Obsolete("No longer needed. Use ProductsDataGrid Component instead for designer and DBEntryCollection in Types namespace for collections.")>
	Public Class ProductsDataTable
		Inherits TypedTableBase(Of ProductsDataRow)

		Public Delegate Sub ProductsDataRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductsRowChangeEvent)

		Private ItemID As DataColumn
		Private Name As DataColumn
		Private Stock As DataColumn
		Private Price As DataColumn
		Private Available As DataColumn

		Public Sub New()
			MyBase.New
			Me.TableName = "Products"
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

		Public ReadOnly Property NameColumn() As DataColumn
			Get
				Return Me.Name
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

		Public ReadOnly Property Count() As Integer
			Get
				Return Me.Rows.Count
			End Get
		End Property

		Default Public ReadOnly Property Item(index As Integer) As ProductsDataRow
			Get
				Return CType(Me.Rows(index), ProductsDataRow)
			End Get
		End Property

		Public ReadOnly Property Products As Types.DBEntryCollection(Of Types.Product)
			Get
				Dim col As New Types.DBEntryCollection(Of Types.Product)

				For Each row As ProductsDataRow In Rows
					col.Add(row.Product)
				Next

				Return col
			End Get
		End Property

		Public Event ProductsDataRowChanging As ProductsDataRowChangeEventHandler

		Public Event ProductsDataRowChanged As ProductsDataRowChangeEventHandler

		Public Event ProductsDataRowDeleting As ProductsDataRowChangeEventHandler

		Public Event ProductsDataRowDeleted As ProductsDataRowChangeEventHandler

		Public Sub AddRange(list As Types.DBEntryCollection(Of Types.Product))
			For Each product In list
				AddProductsRow(product)
			Next
		End Sub

		Public Sub AddProductsRow(ByVal product As Types.Product)
			AddProductsRow(product.Id, product.Name, product.Stock, product.Price, product.Available)
		End Sub

		Public Sub AddProductsRow(ByVal row As ProductsDataRow)
			Throw New NotImplementedException("AddItemsRow(row)")
			'AddItemsRow(CInt(row("ItemID")), CStr(row("Name")), CInt(row("Stock")), CDec(row("Price")), CBool(row("Available")))
		End Sub

		Public Function AddProductsRow(ItemID As Integer, Name As String, Stock As Integer, Price As Double, Available As Boolean) As ProductsDataRow
			Dim ProductsDataRow As ProductsDataRow = CType(Me.NewRow, ProductsDataRow)
			ProductsDataRow.ItemArray = {ItemID, Name, Stock, Price, Available}
			Me.Rows.Add(ProductsDataRow)
			Return ProductsDataRow
		End Function

		Public Function FindByID(ID As Integer) As ProductsDataRow
			Return CType(Me.Rows.Find(New Object() {ID}), ProductsDataRow)
		End Function

		Public Overrides Function Clone() As DataTable
			Dim cln As ProductsDataTable = CType(MyBase.Clone, ProductsDataTable)
			cln.InitVars()
			Return cln
		End Function

		Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
			Return New ProductsDataTable()
		End Function

		Friend Sub InitVars()
			Me.ItemID = MyBase.Columns("OrderID")
			Me.Name = MyBase.Columns("Name")
			Me.Stock = MyBase.Columns("Stock")
			Me.Price = MyBase.Columns("Price")
			Me.Available = MyBase.Columns("Available")
		End Sub

		Private Sub InitClass()
			Me.ItemID = New DataColumn("ItemID", GetType(Integer), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.ItemID)
			Me.Name = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Name)
			Me.Stock = New DataColumn("Stock", GetType(Integer), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Stock)
			Me.Price = New DataColumn("Price", GetType(Double), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Price)
			Me.Available = New DataColumn("Available", GetType(Boolean), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Available)
			Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.ItemID}, True))
			Me.ItemID.AllowDBNull = False
			Me.ItemID.ReadOnly = True
			Me.ItemID.Unique = True
			Me.Name.AllowDBNull = False
			Me.Name.MaxLength = 100
			Me.Stock.AllowDBNull = False
			Me.Available.AllowDBNull = False
		End Sub

		Public Function NewProductsDataRow() As ProductsDataRow
			Return CType(Me.NewRow, ProductsDataRow)
		End Function

		Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
			Return New ProductsDataRow(builder)
		End Function

		Protected Overrides Function GetRowType() As Type
			Return GetType(ProductsDataRow)
		End Function

		Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
			MyBase.OnRowChanged(e)
			'If ((Me.ProductsDataRowChanged) IsNot Nothing) Then
			RaiseEvent ProductsDataRowChanged(Me, New ProductsRowChangeEvent(CType(e.Row, ProductsDataRow), e.Action))
			'End If
		End Sub

		Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
			MyBase.OnRowChanging(e)
			'If ((Me.ProductsDataRowChanging) IsNot Nothing) Then
			RaiseEvent ProductsDataRowChanging(Me, New ProductsRowChangeEvent(CType(e.Row, ProductsDataRow), e.Action))
			'End If
		End Sub

		Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
			MyBase.OnRowDeleted(e)
			'If ((Me.ProductsDataRowDeleted) IsNot Nothing) Then
			RaiseEvent ProductsDataRowDeleted(Me, New ProductsRowChangeEvent(CType(e.Row, ProductsDataRow), e.Action))
			'End If
		End Sub

		Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
			MyBase.OnRowDeleting(e)
			'If ((Me.ProductsDataRowDeleting) IsNot Nothing) Then
			RaiseEvent ProductsDataRowDeleting(Me, New ProductsRowChangeEvent(CType(e.Row, ProductsDataRow), e.Action))
			'End If
		End Sub

		Public Sub RemoveItemsRow(row As ProductsDataRow)
			Me.Rows.Remove(row)
		End Sub

		'Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
		'	Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
		'	Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
		'	Dim ds As New MediaMinistryDataSet()
		'	Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
		'	any1.Namespace = "http://www.w3.org/2001/XMLSchema"
		'	any1.MinOccurs = New Decimal(0)
		'	any1.MaxOccurs = Decimal.MaxValue
		'	any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
		'	sequence.Items.Add(any1)
		'	Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
		'	any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
		'	any2.MinOccurs = New Decimal(1)
		'	any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
		'	sequence.Items.Add(any2)
		'	Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
		'	attribute1.Name = "namespace"
		'	attribute1.FixedValue = ds.Namespace
		'	type.Attributes.Add(attribute1)
		'	Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
		'	attribute2.Name = "tableTypeName"
		'	attribute2.FixedValue = "InventoryDataTable"
		'	type.Attributes.Add(attribute2)
		'	type.Particle = sequence
		'	Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
		'	If xs.Contains(dsSchema.TargetNamespace) Then
		'		Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
		'		Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
		'		Try
		'			Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
		'			dsSchema.Write(s1)
		'			Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
		'			Do While schemas.MoveNext
		'				schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
		'				s2.SetLength(0)
		'				schema.Write(s2)
		'				If (s1.Length = s2.Length) Then
		'					s1.Position = 0
		'					s2.Position = 0

		'					Do While ((s1.Position <> s1.Length) _
		'							AndAlso (s1.ReadByte = s2.ReadByte))


		'					Loop
		'					If (s1.Position = s1.Length) Then
		'						Return type
		'					End If
		'				End If

		'			Loop
		'		Finally
		'			If ((s1) IsNot Nothing) Then
		'				s1.Close()
		'			End If
		'			If ((s2) IsNot Nothing) Then
		'				s2.Close()
		'			End If
		'		End Try
		'	End If
		'	xs.Add(dsSchema)
		'	Return type
		'End Function
	End Class
End Namespace
