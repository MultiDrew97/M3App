Namespace DataTables
	<Serializable>
	Public Class CustomersDataTable
		Inherits TypedTableBase(Of Rows.CustomersDataRow)

		Public Delegate Sub CustomersDataRowChangeEventHandler(ByVal sender As Object, ByVal e As Events.CustomersRowChangeEvent)

		Private CustomerID As DataColumn
		Private FirstName As DataColumn
		Private LastName As DataColumn
		Private Address As DataColumn
		'Private Street As DataColumn
		'Private City As DataColumn
		'Private State As DataColumn
		'Private ZipCode As DataColumn
		Private PhoneNumber As DataColumn
		Private EmailAddress As DataColumn
		Private JoinDate As DataColumn

		Public Sub New()
			MyBase.New
			Me.TableName = "Customers"
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

		Public ReadOnly Property CustomerIdColumn() As DataColumn
			Get
				Return Me.CustomerID
			End Get
		End Property

		Public ReadOnly Property FirstNameColumn() As DataColumn
			Get
				Return Me.FirstName
			End Get
		End Property

		Public ReadOnly Property LastNameColumn() As DataColumn
			Get
				Return Me.LastName
			End Get
		End Property

		Public ReadOnly Property AddressColumn() As DataColumn
			Get
				Return Me.Address
			End Get
		End Property

		'Public ReadOnly Property StreetColumn() As DataColumn
		'	Get
		'		Return Me.Street
		'	End Get
		'End Property

		'Public ReadOnly Property CityColumn() As DataColumn
		'	Get
		'		Return Me.City
		'	End Get
		'End Property

		'Public ReadOnly Property StateColumn() As DataColumn
		'	Get
		'		Return Me.State
		'	End Get
		'End Property

		'Public ReadOnly Property ZipCodeColumn() As DataColumn
		'	Get
		'		Return Me.ZipCode
		'	End Get
		'End Property

		Public ReadOnly Property PhoneNumberColumn() As DataColumn
			Get
				Return Me.PhoneNumber
			End Get
		End Property

		Public ReadOnly Property EmailColumn() As Global.System.Data.DataColumn
			Get
				Return Me.EmailAddress
			End Get
		End Property

		Public ReadOnly Property JoinDateColumn() As DataColumn
			Get
				Return Me.JoinDate
			End Get
		End Property

		Public ReadOnly Property Count() As Integer
			Get
				Return Me.Rows.Count
			End Get
		End Property

		Default Public ReadOnly Property Item(ByVal index As Integer) As Rows.CustomersDataRow
			Get
				Return CType(Me.Rows(index), Rows.CustomersDataRow)
			End Get
		End Property

		Public Event CustomersDataRowChanging As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowChanged As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowDeleting As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowDeleted As CustomersDataRowChangeEventHandler

		Public Sub AddCustomersRow(ByVal row As Rows.CustomersDataRow)
			AddCustomersRow(CInt(row("CustomerID")), CStr(row("FirstName")), CStr(row("LastName")), CStr(row("Street")), CStr(row("City")), CStr(row("State")), CStr(row("ZipCode")), CStr(row("PhoneNumber")), CStr(row("EmailAddress")), CDate(row("JoinDate")))
		End Sub

		Public Function AddCustomersRow(CustomerID As Integer, FirstName As String, LastName As String, Address As Types.Address, PhoneNumber As String, EmailAddress As String, JoinDate As Date) As Rows.CustomersDataRow
			Dim CustomersDataRow As Rows.CustomersDataRow = CType(Me.NewRow, Rows.CustomersDataRow)
			CustomersDataRow.ItemArray = {CustomerID, FirstName, LastName, ParseAddress(Address), PhoneNumber, EmailAddress, JoinDate}
			Me.Rows.Add(CustomersDataRow)
			Return CustomersDataRow
		End Function

		Public Function AddCustomersRow(CustomerID As Integer, FirstName As String, LastName As String, Street As String, City As String, State As String, ZipCode As String, PhoneNumber As String, EmailAddress As String, JoinDate As Date) As Rows.CustomersDataRow
			Dim CustomersDataRow As Rows.CustomersDataRow = CType(Me.NewRow, Rows.CustomersDataRow)
			CustomersDataRow.ItemArray = {CustomerID, FirstName, LastName, ParseAddress(Street, City, State, ZipCode), PhoneNumber, EmailAddress, JoinDate}
			Me.Rows.Add(CustomersDataRow)
			Return CustomersDataRow
		End Function

		Private Function ParseAddress(Street As String, City As String, State As String, ZipCode As String) As Object
			Return ParseAddress(Types.Address.Parse(Street, City, State, ZipCode))
		End Function

		Private Function ParseAddress(address As Types.Address) As Object
			If address Is Nothing Then
				Return DBNull.Value
			Else
				Return address.ToString()
			End If
		End Function

		Public Function FindByID(ByVal ID As Integer) As Rows.CustomersDataRow
			Return CType(Me.Rows.Find(New Object() {ID}), Rows.CustomersDataRow)
		End Function

		Public Overrides Function Clone() As DataTable
			Dim cln As CustomersDataTable = CType(MyBase.Clone, CustomersDataTable)
			cln.InitVars()
			Return cln
		End Function

		Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
			Return New CustomersDataTable()
		End Function

		Friend Sub InitVars()
			Me.CustomerID = MyBase.Columns("CustomerID")
			Me.FirstName = MyBase.Columns("FirstName")
			Me.LastName = MyBase.Columns("LastName")
			Me.Address = MyBase.Columns("Address")
			'Me.Street = MyBase.Columns("Street")
			'Me.City = MyBase.Columns("City")
			'Me.State = MyBase.Columns("State")
			'Me.ZipCode = MyBase.Columns("ZipCode")
			Me.PhoneNumber = MyBase.Columns("PhoneNumber")
			Me.EmailAddress = MyBase.Columns("EmailAddress")
			Me.JoinDate = MyBase.Columns("JoinDate")
		End Sub

		Private Sub InitClass()
			Me.CustomerID = New DataColumn("CustomerID", GetType(Integer), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.CustomerID)
			Me.FirstName = New DataColumn("FirstName", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.FirstName)
			Me.LastName = New DataColumn("LastName", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.LastName)
			Me.Address = New DataColumn("Address", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Address)
			'Me.Street = New DataColumn("Street", GetType(String), Nothing, MappingType.Element)
			'MyBase.Columns.Add(Me.Street)
			'Me.City = New DataColumn("City", GetType(String), Nothing, MappingType.Element)
			'MyBase.Columns.Add(Me.City)
			'Me.State = New DataColumn("State", GetType(String), Nothing, MappingType.Element)
			'MyBase.Columns.Add(Me.State)
			'Me.ZipCode = New DataColumn("ZipCode", GetType(String), Nothing, MappingType.Element)
			'MyBase.Columns.Add(Me.ZipCode)
			Me.PhoneNumber = New DataColumn("PhoneNumber", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.PhoneNumber)
			Me.EmailAddress = New DataColumn("EmailAddress", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.EmailAddress)
			Me.JoinDate = New DataColumn("JoinDate", GetType(Date), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.JoinDate)
			Me.Constraints.Add(New UniqueConstraint("CustomerID", New DataColumn() {Me.CustomerID}, True))
			Me.CustomerID.AllowDBNull = False
			Me.CustomerID.ReadOnly = True
			Me.CustomerID.Unique = True
			Me.FirstName.AllowDBNull = False
			Me.FirstName.MaxLength = 50
			Me.FirstName.AllowDBNull = False
			Me.FirstName.MaxLength = 50
			Me.LastName.AllowDBNull = False
			Me.LastName.MaxLength = 50
			Me.Address.AllowDBNull = True
			Me.Address.MaxLength = 400
			'Me.Street.AllowDBNull = True
			'Me.Street.MaxLength = 50
			'Me.City.AllowDBNull = True
			'Me.City.MaxLength = 50
			'Me.State.AllowDBNull = True
			'Me.State.MaxLength = 50
			'Me.ZipCode.AllowDBNull = True
			'Me.ZipCode.MaxLength = 50
			Me.PhoneNumber.MaxLength = 15
			Me.PhoneNumber.AllowDBNull = True
			Me.EmailAddress.AllowDBNull = True
			Me.EmailAddress.MaxLength = 100
			Me.JoinDate.AllowDBNull = False
		End Sub

		Public Function NewCustomersDataRow() As Rows.CustomersDataRow
			Return CType(Me.NewRow, Rows.CustomersDataRow)
		End Function

		Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
			Return New Rows.CustomersDataRow(builder)
		End Function

		Protected Overrides Function GetRowType() As Global.System.Type
			Return GetType(Rows.CustomersDataRow)
		End Function

		Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
			MyBase.OnRowChanged(e)
			If ((Me.CustomersDataRowChangedEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowChanged(Me, New Events.CustomersRowChangeEvent(CType(e.Row, Rows.CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowChanging(e)
			If ((Me.CustomersDataRowChangingEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowChanging(Me, New Events.CustomersRowChangeEvent(CType(e.Row, Rows.CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowDeleted(e)
			If ((Me.CustomersDataRowDeletedEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowDeleted(Me, New Events.CustomersRowChangeEvent(CType(e.Row, Rows.CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowDeleting(e)
			If ((Me.CustomersDataRowDeletingEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowDeleting(Me, New Events.CustomersRowChangeEvent(CType(e.Row, Rows.CustomersDataRow), e.Action))
			End If
		End Sub

		Public Sub RemoveCustomersRow(ByVal row As Rows.CustomersDataRow)
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
		'    attribute2.FixedValue = "CustomersDataTable"
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
