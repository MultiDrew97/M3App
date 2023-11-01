Option Strict On

Imports System.Data.SqlClient
Imports SPPBC.M3Tools.Types

Public Class PlaceOrderDialog
    Private CustomersTable As DataTable
	Private ReadOnly Customers As ObjectModel.Collection(Of Customer)
	Private ProductsTable As DataTable
	Private ReadOnly Products As ObjectModel.Collection(Of Item)

	Private Sub Frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        bsCustomers.DataSource = CustomersTable
        bsProducts.DataSource = ProductsTable

        cbx_Name.DisplayMember = "Name"
        cbx_ItemName.DisplayMember = "Name"
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

	Private Sub Btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
		Try
			' TODO: Add new order

			tss_AddOrder.ForeColor = SystemColors.WindowText
			tss_AddOrder.Text = "The order was successfully added for " & cbx_Name.Text

			DialogResult = DialogResult.OK
			Me.Close()
		Catch ex As SqlException
			tss_AddOrder.Text = "The order could not be added. Please try again"
			tss_AddOrder.ForeColor = Color.Red
		End Try
	End Sub

	Private Sub GenerateTables()
        CustomersTable = New DataTable
        ProductsTable = New DataTable

        GenerateColumns()
    End Sub

    Private Sub GenerateColumns()
        CustomersTable.Columns.AddRange({New DataColumn("CustomerID", GetType(Integer)), New DataColumn("Name", GetType(String))})

        ProductsTable.Columns.AddRange({New DataColumn("ProductID", GetType(Integer)), New DataColumn("Name", GetType(String)), New DataColumn("Available", GetType(Boolean))})

        FillTables()
    End Sub

    Private Sub FillTables()
        Dim row As DataRow

        For Each customer As Customer In Customers
            row = CustomersTable.NewRow
            row("CustomerID") = customer.Id
            row("Name") = customer.Name
            CustomersTable.Rows.Add(row)
        Next

        For Each product As Item In Products
            row = ProductsTable.NewRow
            row("ProductID") = product.Id
            row("Name") = product.Name
            row("Available") = product.Available
            ProductsTable.Rows.Add(row)
        Next
    End Sub

    'Private Sub cbx_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Name.SelectedIndexChanged
    '    Using db As New Database
    '        Customer = db.GetCustomerInfo(CInt(CustomersTable.Rows(cbx_Name.SelectedIndex)("CustomerID")))
    '    End Using
    'End Sub

    'Private Sub cbx_ItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ItemName.SelectedIndexChanged
    '    Using db As New Database
    '        Product = db.GetProductInfo(CInt(ProductsTable.Rows(cbx_ItemName.SelectedIndex)("ProductID")))
    '    End Using
    'End Sub

    Private Sub LoadData()
		' TODO: Load orders

		GenerateTables()
    End Sub


    'Private Sub wait(ByVal seconds As Integer)
    '    'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

    '    For i As Integer = 0 To seconds * 100
    '        System.Threading.Thread.Sleep(10)
    '        Application.DoEvents()
    '    Next
    'End Sub
End Class