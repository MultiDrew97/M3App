Namespace DataTables
    Public Class CustomersDataRow
        Inherits DataRow

        Private ReadOnly tableCustomers As CustomersDataTable

        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCustomers = CType(Me.Table, CustomersDataTable)
        End Sub

        Public ReadOnly Property CustomerID As Integer
            Get
                Return CInt(Me(Me.tableCustomers.CustomerIdColumn))
            End Get
        End Property

        Public Property FirstName() As String
            Get
                Return CStr(Me(Me.tableCustomers.FirstNameColumn))
            End Get
            Set
                Me(Me.tableCustomers.FirstNameColumn) = Value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return CStr(Me(Me.tableCustomers.LastNameColumn))
            End Get
            Set
                Me(Me.tableCustomers.LastNameColumn) = Value
            End Set
        End Property

        Public Property Address() As String
            Get
                Return CStr(Me(Me.tableCustomers.AddressColumn))
            End Get
            Set(value As String)
                Me(Me.tableCustomers.AddressColumn) = value
            End Set
        End Property

        Public Property PhoneNumber() As String
            Get
                Return CStr(Me(Me.tableCustomers.PhoneNumberColumn))
            End Get
            Set
                Me(Me.tableCustomers.PhoneNumberColumn) = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return CStr(Me(Me.tableCustomers.EmailColumn))
            End Get
            Set
                Me(Me.tableCustomers.EmailColumn) = Value
            End Set
        End Property

		Public ReadOnly Property JoinDate() As Date
			Get
				Return CDate(Me(Me.tableCustomers.JoinDateColumn))
			End Get
		End Property

		Public ReadOnly Property Customer As Types.Customer
			Get
				Return New Types.Customer(CustomerID, FirstName, LastName, Types.Address.Parse(Address), PhoneNumber, Email, JoinDate.ToLongDateString)
			End Get
		End Property

	End Class
End Namespace
