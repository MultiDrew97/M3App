Imports System.Windows.Forms

Public Class SelectReceipient
	Private __dialog As ReciepientSelection

	Private ReadOnly Property RecipientSelection As ReciepientSelection
		Get
			If __dialog Is Nothing Then
				__dialog = New ReciepientSelection
			ElseIf __dialog.IsDisposed Then
				__dialog = New ReciepientSelection
			End If

			Return __dialog
		End Get
	End Property

	Function ShowDialog() As DialogResult
		Return RecipientSelection.ShowDialog()
	End Function
End Class
