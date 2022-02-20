Imports System.Windows.Forms

Public Class SelectReceipient
	Private __dialog As ReciepientSelectionDialog

	Private ReadOnly Property RecipientSelection As ReciepientSelectionDialog
		Get
			If __dialog Is Nothing Then
				__dialog = New ReciepientSelectionDialog
			ElseIf __dialog.IsDisposed Then
				__dialog = New ReciepientSelectionDialog
			End If

			Return __dialog
		End Get
	End Property

	Function ShowDialog() As DialogResult
		Return RecipientSelection.ShowDialog()
	End Function
End Class
