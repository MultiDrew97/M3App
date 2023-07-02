Imports System.Windows.Forms

Public Class ToolsContextMenu
	Event RefreshView()
	Event RemoveRows()
	Event SendEmails()

	Private ReadOnly prefix As String = "ts"
	Private Confirmed As Boolean = False

	Private Sub NewItemAdded(sender As Object, e As ToolStripItemEventArgs) Handles Me.ItemAdded
		Console.WriteLine(e.Item)
	End Sub

	Private Sub RemoveRowByToolStrip(sender As Object, e As EventArgs) Handles ts_Remove.Click
		Confirmed = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

		If Not Confirmed Then
			Return
		End If
		' TODO: Flesh out rest of tool context menu
		RaiseEvent RemoveRows()
	End Sub

	Private Sub Reload(sender As Object, e As EventArgs) Handles ts_Refresh.Click
		RaiseEvent RefreshView()
	End Sub

	Private Sub MenuClosed(sender As Object, e As EventArgs) Handles Me.Closed
		ts_Remove.Enabled = False
	End Sub

	Public Sub ToggleRemove(rowsSelected As Boolean)
		ts_Remove.Enabled = rowsSelected
	End Sub

	Public Sub ToggleSend(rowsSelected As Boolean)
		Dim send As ToolStripItem = Me.Items.Item($"{prefix}_Send")

		If send Is Nothing Then
			Return
		End If

		send.Enabled = rowsSelected
	End Sub

	Private Sub Send(sender As Object, e As EventArgs) Handles ts_Send.Click
		RaiseEvent SendEmails()
	End Sub
End Class
