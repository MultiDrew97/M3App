Imports System.Windows.Forms

Public Class ReciepientSelectionDialog

	Private Sub ConfirmSelection(sender As Object, e As EventArgs) Handles OK_Button.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub
End Class
