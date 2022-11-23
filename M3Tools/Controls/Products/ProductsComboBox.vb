Imports System.ComponentModel

Public Class ProductsComboBox
	Private ReadOnly _items As New DataTables.ItemsDataTable
	Public Event LoadBegin()
	Public Event LoadEnd()

	Public Property SelectedItem As Object
		Get
			Return cbx_Items.SelectedItem
		End Get
		Set(value As Object)
			cbx_Items.SelectedItem = value
		End Set
	End Property

	Public Property SelectedIndex As Integer
		Get
			Return cbx_Items.SelectedIndex
		End Get
		Set(value As Integer)
			cbx_Items.SelectedIndex = value
		End Set
	End Property

	Public Property SelectedValue As Object
		Get
			Return cbx_Items.SelectedValue
		End Get
		Set(value As Object)
			cbx_Items.SelectedValue = value
		End Set
	End Property

	Private Sub LoadItems(sender As Object, e As DoWorkEventArgs) Handles bw_LoadItems.DoWork
		RaiseEvent LoadBegin()
		Dim items = db_Products.GetProducts()
		_items.Clear()

		For Each item In items
			_items.AddItemsRow(item.Id, item.Name, item.Stock, item.Price, item.Available)
		Next
	End Sub

	Private Sub ControlLoaded(sender As Object, e As EventArgs) Handles Me.Load
		bsItems.DataSource = _items
	End Sub

	Private Sub ItemsLoaded(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadItems.RunWorkerCompleted
		cbx_Items.DataSource = bsItems
		cbx_Items.DisplayMember = "ItemName"
		cbx_Items.ValueMember = "ItemID"
		RaiseEvent LoadEnd()
	End Sub

	Public Sub Reload()
		bw_LoadItems.RunWorkerAsync()
	End Sub
End Class
