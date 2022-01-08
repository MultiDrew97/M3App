Imports System.Windows.Forms

Public Class SelectReceipient
	Private __dialog As ReciepientSelectionDialog = Nothing

	Function ShowDialog() As DialogResult
		If __dialog Is Nothing Then
			__dialog = New ReciepientSelectionDialog
		End If

		Return __dialog.ShowDialog()
	End Function
End Class
