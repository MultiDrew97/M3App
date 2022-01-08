Namespace CustomData
    <Serializable>
    Public Class ListenersDataTable
        Inherits TypedTableBase(Of ListenersDataRow)

        Public Delegate Sub ListenersDataRowChangeEventHandler(ByVal sender As Object, ByVal e As ListenersRowChangeEvent)

        Private ListenerID As DataColumn
        Private Name As DataColumn
        Private EmailAddress As DataColumn

        <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
        Public Sub New()
            MyBase.New
            Me.TableName = "EmailListeners"
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

        Public ReadOnly Property ListenerIdColumn() As DataColumn
            Get
                Return Me.ListenerID
            End Get
        End Property

        Public ReadOnly Property NameColumn() As DataColumn
            Get
                Return Me.Name
            End Get
        End Property

        Public ReadOnly Property EmailColumn() As Global.System.Data.DataColumn
            Get
                Return Me.EmailAddress
            End Get
        End Property

        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal index As Integer) As ListenersDataRow
            Get
                Return CType(Me.Rows(index), ListenersDataRow)
            End Get
        End Property

        Public Event ListenersDataRowChanging As ListenersDataRowChangeEventHandler

        Public Event ListenersDataRowChanged As ListenersDataRowChangeEventHandler

        Public Event ListenersDataRowDeleting As ListenersDataRowChangeEventHandler

        Public Event ListenersDataRowDeleted As ListenersDataRowChangeEventHandler

        Public Sub AddEmailListenersRow(ByVal row As ListenersDataRow)
            AddEmailListenersRow(CInt(row("ListenerID")), CStr(row("Name")), CStr(row("EmailAddress")))
        End Sub

        Public Function AddEmailListenersRow(ListenerID As Integer, ByVal Name As String, ByVal EmailAddress As String) As ListenersDataRow
            Dim ListenersDataRow As ListenersDataRow = CType(Me.NewRow, ListenersDataRow)
            ListenersDataRow.ItemArray = {ListenerID, Name, EmailAddress}
            Me.Rows.Add(ListenersDataRow)
            Return ListenersDataRow
        End Function

        Public Function FindByID(ByVal ID As Integer) As ListenersDataRow
            Return CType(Me.Rows.Find(New Object() {ID}), ListenersDataRow)
        End Function

        Public Overrides Function Clone() As DataTable
            Dim cln As ListenersDataTable = CType(MyBase.Clone, ListenersDataTable)
            cln.InitVars()
            Return cln
        End Function

        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ListenersDataTable()
        End Function

        Friend Sub InitVars()
            Me.ListenerID = MyBase.Columns("ListenerID")
            Me.Name = MyBase.Columns("Name")
            Me.EmailAddress = MyBase.Columns("EmailAddress")
        End Sub

        Private Sub InitClass()
            Me.ListenerID = New DataColumn("ListenerID", GetType(Integer), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.ListenerID)
            Me.Name = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.Name)
            Me.EmailAddress = New DataColumn("EmailAddress", GetType(String), Nothing, MappingType.Element)
            MyBase.Columns.Add(Me.EmailAddress)
            Me.Constraints.Add(New UniqueConstraint("ListenerID", New DataColumn() {Me.ListenerID}, True))
            Me.ListenerID.AllowDBNull = False
            Me.ListenerID.ReadOnly = True
            Me.ListenerID.Unique = True
            Me.Name.AllowDBNull = False
            Me.Name.MaxLength = 50
            Me.EmailAddress.AllowDBNull = False
            Me.EmailAddress.MaxLength = 100
        End Sub

        Public Function NewListenersDataRow() As ListenersDataRow
            Return CType(Me.NewRow, ListenersDataRow)
        End Function

        Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
            Return New ListenersDataRow(builder)
        End Function

        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ListenersDataRow)
        End Function

        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If ((Me.ListenersDataRowChangedEvent) IsNot Nothing) Then
                RaiseEvent ListenersDataRowChanged(Me, New ListenersRowChangeEvent(CType(e.Row, ListenersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If ((Me.ListenersDataRowChangingEvent) IsNot Nothing) Then
                RaiseEvent ListenersDataRowChanging(Me, New ListenersRowChangeEvent(CType(e.Row, ListenersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If ((Me.ListenersDataRowDeletedEvent) IsNot Nothing) Then
                RaiseEvent ListenersDataRowDeleted(Me, New ListenersRowChangeEvent(CType(e.Row, ListenersDataRow), e.Action))
            End If
        End Sub

        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If ((Me.ListenersDataRowDeletingEvent) IsNot Nothing) Then
                RaiseEvent ListenersDataRowDeleting(Me, New ListenersRowChangeEvent(CType(e.Row, ListenersDataRow), e.Action))
            End If
        End Sub

        Public Sub RemoveEmailListenersRow(ByVal row As ListenersDataRow)
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
        '    attribute2.FixedValue = "ListenersDataTable"
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
