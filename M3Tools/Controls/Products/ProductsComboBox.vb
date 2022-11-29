Imports System.ComponentModel

Public Class ProductsComboBox
	Public Event LoadBegin()
	Public Event LoadEnd()

	Public Property SelectedItem As Object
		Get
			Return cbx_Items.SelectedItem
		End Get
		Set(value As Object)
			If value Is Nothing Then
				Return
			End If

			cbx_Items.SelectedItem = value
		End Set
	End Property

	Public Property SelectedIndex As Integer
		Get
			Return cbx_Items.SelectedIndex
		End Get
		Set(value As Integer)
			If value < 0 Then
				Return
			End If

			cbx_Items.SelectedIndex = value
		End Set
	End Property

	Public Property SelectedValue As Object
		Get
			Return cbx_Items.SelectedValue
		End Get
		Set(value As Object)
			If value Is Nothing Then
				Return
			End If

			cbx_Items.SelectedValue = value
		End Set
	End Property

	Private Sub LoadItems(sender As Object, e As DoWorkEventArgs) Handles bw_LoadItems.DoWork
		RaiseEvent LoadBegin()
		'Dim items = db_Products.GetProducts()
		'_items.Clear()
		Try
			bsItems.Clear()
		Catch

		End Try

		For Each item In db_Products.GetProducts()
			'Dim var As DataTables.ItemsDataRow = CType(CType(bsItems.AddNew(), DataRowView).Row, DataTables.ItemsDataRow)
			'var.ItemArray = {item.Id, item.Name, item.Stock, item.Price, item.Available}
			'Console.WriteLine(var.ItemArray)
			bsItems.Add(item)
			'bsItems.Add(DataTables.ItemsDataRow())
			'_items.AddItemsRow(item.Id, item.Name, item.Stock, item.Price, item.Available)
		Next
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		'bsItems.DataSource = _items
	End Sub

	Private Sub ItemsLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadItems.RunWorkerCompleted
		'cbx_Items.DataSource = bsItems
		'cbx_Items.DisplayMember = "ItemName"
		'cbx_Items.ValueMember = "ItemID"
		'cbx_Items.Refresh()
		bsItems.ResetBindings(False)
		RaiseEvent LoadEnd()
	End Sub

	Public Sub Reload()
		bw_LoadItems.RunWorkerAsync()
	End Sub

	Private Sub IndexChanged(sender As Object, e As EventArgs) Handles cbx_Items.SelectedIndexChanged

	End Sub
End Class
