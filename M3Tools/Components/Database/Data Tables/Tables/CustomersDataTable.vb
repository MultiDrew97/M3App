﻿Imports System.Text.RegularExpressions
Imports SPPBC.M3Tools.Types

Namespace DataTables
	<Serializable>
	Public Class CustomersDataTable
		Inherits TypedTableBase(Of CustomersDataRow)

		Public Delegate Sub CustomersDataRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomersRowChangeEvent)

		Private CustomerID As DataColumn
		Private FirstName As DataColumn
		Private LastName As DataColumn
		Private Address As DataColumn
		Private PhoneNumber As DataColumn
		Private Email As DataColumn
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

		Public ReadOnly Property PhoneNumberColumn() As DataColumn
			Get
				Return Me.PhoneNumber
			End Get
		End Property

		Public ReadOnly Property EmailColumn() As Global.System.Data.DataColumn
			Get
				Return Me.Email
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

		Default Public ReadOnly Property Item(ByVal index As Integer) As CustomersDataRow
			Get
				Return CType(Me.Rows(index), CustomersDataRow)
			End Get
		End Property

		Public ReadOnly Property Customers As Types.DBEntryCollection(Of Types.Customer)
			Get
				Dim col As New Types.DBEntryCollection(Of Types.Customer)

				For Each row As CustomersDataRow In Rows
					col.Add(row.Customer)
				Next

				Return col
			End Get
		End Property

		Public Event CustomersDataRowChanging As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowChanged As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowDeleting As CustomersDataRowChangeEventHandler

		Public Event CustomersDataRowDeleted As CustomersDataRowChangeEventHandler

		Public Sub AddRange(list As Types.DBEntryCollection(Of Types.Customer))
			For Each customer In list
				AddCustomersRow(customer)
			Next
		End Sub

		Public Sub AddCustomersRow(ByVal row As CustomersDataRow)
			Throw New NotImplementedException("AddCustomer(row)")
			' AddCustomersRow(CInt(row("CustomerID")), CStr(row("FirstName")), CStr(row("LastName")), CStr(row("Address")), CStr(row("PhoneNumber")), CStr(row("Email")), CDate(row("JoinDate")))
		End Sub

		Public Sub AddCustomersRow(ByVal customer As Types.Customer)
			AddCustomersRow(customer.Id, customer.FirstName, customer.LastName, customer.Address?.Street,
							customer.Address?.City, customer.Address?.State, customer.Address?.ZipCode,
							customer.PhoneNumber, customer.Email, customer.Joined)
		End Sub

		Public Function AddCustomersRow(CustomerID As Integer, FirstName As String, LastName As String, Address As Address, PhoneNumber As String, Email As String, JoinDate As Date) As CustomersDataRow
			Dim CustomersDataRow As CustomersDataRow = CType(Me.NewRow, CustomersDataRow)
			CustomersDataRow.ItemArray = {CustomerID, FirstName, LastName, Address, PhoneNumber.FormatPhone, Email, JoinDate}
			Me.Rows.Add(CustomersDataRow)
			Return CustomersDataRow
		End Function

		Private Function AddCustomersRow(CustomerID As Integer, FirstName As String, LastName As String, Street As String, City As String, State As String, ZipCode As String, PhoneNumber As String, Email As String, JoinDate As Date) As CustomersDataRow
			Return AddCustomersRow(CustomerID, FirstName, LastName, New Address(Street, City, State, ZipCode), PhoneNumber, Email, JoinDate)
		End Function

		Private Function ParseDate(value As Date) As Object
			If value.Year < 1950 Then
				Return Nothing
			End If

			Return value
		End Function

		Private Function ParsePhone(value As String) As Object
			Dim phoneInt As Long = Nothing
			If value Is Nothing Then
				Return Nothing
			End If

			Dim filteredPhone = value.Where(Function(currentChar As Char) As Boolean
												Return Not Regex.IsMatch(currentChar, "[\s()-]")
											End Function)

			Dim phoneStr = String.Join("", filteredPhone)

			If phoneStr.Length > 10 Then
				phoneStr.Remove(10)
			End If

			Try
				phoneInt = Long.Parse(phoneStr)
			Catch ex As Exception
				Return Nothing
			End Try

			Dim result As Object = Nothing
			If Not (phoneInt > 999999999 AndAlso phoneInt <= 9999999999) Then
				Return Nothing
			End If

			Return phoneInt
		End Function

		Public Function FindByID(ByVal ID As Integer) As CustomersDataRow
			Return CType(Me.Rows.Find(New Object() {ID}), CustomersDataRow)
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
			Me.PhoneNumber = MyBase.Columns("PhoneNumber")
			Me.Email = MyBase.Columns("Email")
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
			'         MyBase.Columns.Add(Me.Street)
			'         Me.City = New DataColumn("City", GetType(String), Nothing, MappingType.Element)
			'         MyBase.Columns.Add(Me.City)
			'         Me.State = New DataColumn("State", GetType(String), Nothing, MappingType.Element)
			'         MyBase.Columns.Add(Me.State)
			'         Me.ZipCode = New DataColumn("ZipCode", GetType(String), Nothing, MappingType.Element)
			'         MyBase.Columns.Add(Me.ZipCode)
			Me.PhoneNumber = New DataColumn("PhoneNumber", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.PhoneNumber)
			Me.Email = New DataColumn("Email", GetType(String), Nothing, MappingType.Element)
			MyBase.Columns.Add(Me.Email)
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
			Me.Address.MaxLength = 10000
			'Me.Street.AllowDBNull = True
			'         Me.Street.MaxLength = 50
			'         Me.City.AllowDBNull = True
			'         Me.City.MaxLength = 50
			'         Me.State.AllowDBNull = True
			'         Me.State.MaxLength = 50
			'         Me.ZipCode.AllowDBNull = True
			'         Me.ZipCode.MaxLength = 50
			Me.PhoneNumber.MaxLength = 15
			Me.PhoneNumber.AllowDBNull = False
			Me.Email.AllowDBNull = True
			Me.Email.MaxLength = 100
			Me.JoinDate.AllowDBNull = False
		End Sub

		Public Function NewCustomersDataRow() As CustomersDataRow
			Return CType(Me.NewRow, CustomersDataRow)
		End Function

		Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
			Return New CustomersDataRow(builder)
		End Function

		Protected Overrides Function GetRowType() As Global.System.Type
			Return GetType(CustomersDataRow)
		End Function

		Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
			MyBase.OnRowChanged(e)
			If ((Me.CustomersDataRowChangedEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowChanged(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowChanging(e)
			If ((Me.CustomersDataRowChangingEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowChanging(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowDeleted(e)
			If ((Me.CustomersDataRowDeletedEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowDeleted(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersDataRow), e.Action))
			End If
		End Sub

		Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
			MyBase.OnRowDeleting(e)
			If ((Me.CustomersDataRowDeletingEvent) IsNot Nothing) Then
				RaiseEvent CustomersDataRowDeleting(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersDataRow), e.Action))
			End If
		End Sub

		Public Sub RemoveCustomersRow(ByVal row As CustomersDataRow)
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
