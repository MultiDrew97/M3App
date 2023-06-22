﻿Imports System.Windows.Forms

Public Class ReciepientSelectionDialog

	ReadOnly Property Selection As Types.ListenerCollection
		Get
			Return ldg_Listeners.SelectedListeners
		End Get
	End Property

	Private Sub ConfirmSelection(sender As Object, e As EventArgs) Handles btn_Select.Click
		If Selection.Count < 1 Then
			MessageBox.Show("You didn't select a listener. If you wish to cancel, please click the cancel button", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub DialogShown(sender As Object, e As EventArgs) Handles Me.Shown
		ldg_Listeners.Reload()
	End Sub
End Class
