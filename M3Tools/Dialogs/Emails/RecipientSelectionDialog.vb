Imports System.Windows.Forms

Public Class RecipientSelectionDialog
	Private _dialog As ReciepientSelection

	Private ReadOnly Property Dialog As ReciepientSelection
		Get
			If _dialog Is Nothing Then
				_dialog = New ReciepientSelection With {
					.DataSource = bsListeners
				}
			End If

			Return _dialog
		End Get
	End Property

	Public ReadOnly Property List As Types.ListenerCollection
		Get
			Return _dialog.Selection
		End Get
	End Property

	'Public Property DataSource As BindingSource
	'	Get
	'		Return Dialog.DataSource
	'	End Get
	'	Set(value As BindingSource)
	'		Dialog.DataSource = value
	'	End Set
	'End Property

	Function ShowDialog(list As Types.ListenerCollection) As DialogResult
		bsListeners.Clear()
		For Each item In list
			bsListeners.Add(item)
		Next
		Return Dialog.ShowDialog()
	End Function
End Class
