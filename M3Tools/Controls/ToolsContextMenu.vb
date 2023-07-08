Imports System.Windows.Forms

Public Class ToolsContextMenu
	Event RefreshView()
	Event RemoveRows()
	Event SendEmails()
	Event EditPerson()

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		Dim res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
			Return
		End If

		RaiseEvent RemoveRows()
	End Sub

	Private Sub Reload(sender As Object, e As EventArgs) Handles ts_Refresh.Click
		RaiseEvent RefreshView()
	End Sub

	Private Sub MenuClosed(sender As Object, e As EventArgs) Handles Me.Closed
		ts_Remove.Enabled = False
	End Sub

	Public Sub ToggleRemove(enable As Boolean)
		ts_Remove.Enabled = enable
	End Sub

	Public Sub ToggleSend(enable As Boolean)
		If Not ts_Send.Visible Then
			Return
		End If

		ts_Send.Enabled = enable
	End Sub

	Public Sub ToggleEdit(enable As Boolean)
		ts_Edit.Enabled = enable
	End Sub

	Private Sub EmailFunctions(sender As Object, e As EventArgs) Handles ts_Send.Click
		RaiseEvent SendEmails()
	End Sub

	Private Sub EditClicked(sender As Object, e As EventArgs) Handles ts_Edit.Click
		RaiseEvent EditPerson()
	End Sub
End Class
