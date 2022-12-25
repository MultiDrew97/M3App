Imports System.ComponentModel

Public Class frm_EmailListeners
	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		dlc_Listeners.Reload()
	End Sub

	Private Sub ClosingForm(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Frm_Main.Show()
	End Sub
End Class