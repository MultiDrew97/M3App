Imports System.Windows.Forms
Imports SPPBC.M3Tools.Types

Public Class ReciepientSelectionDialog
	Private __listeners As ListenerCollection

	Private Sub ConfirmSelection(sender As Object, e As EventArgs) Handles OK_Button.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Overloads Function ShowDialog(listeners As ListenerCollection) As DialogResult
		__listeners = listeners
		Return ShowDialog()
	End Function
End Class
