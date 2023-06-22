Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Listeners

Public Class DisplayListenersCtrl
	Public Event ListenerAdded As Events.Listeners.ListenerAddedEventHandler
	Private WithEvents ImportDialog As Dialogs.ImportListenersDialog
	Private WithEvents AddDialog As Dialogs.AddListenerDialog

	Public Sub Reload() Handles cms_Tools.RefreshView
		ldg_Listeners.Reload()
	End Sub

	Private Sub AddListener(sender As Object, e As EventArgs) Handles tbtn_AddListener.Click
		Using add = New Dialogs.AddListenerDialog
			If add.ShowDialog() = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub FilterChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
		ldg_Listeners.Filter = txt_Filter.Text
	End Sub

	Private Sub ImportListeners(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Using import = New Dialogs.ImportListenersDialog()
			import.ShowDialog()

			If import.DialogResult = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs)
		cms_Tools.ToggleRemove(ldg_Listeners.SelectedRowsCount > 0)
		cms_Tools.ToggleSend(ldg_Listeners.SelectedRowsCount > 0)
	End Sub

	Private Sub RemoveRowByToolStrip() Handles cms_Tools.RemoveRows
		If ldg_Listeners.SelectedRowsCount < 1 Then
			Return
		End If

		ldg_Listeners.RemoveSelectedRows()

		' TODO: Open a dialog for bulk deletion
		'Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
		'	bulk.ShowDialog()
		'End Using
	End Sub
	Private Sub NewListenerAdded(sender As Object, e As ListenerAddedEvent) Handles AddDialog.ListenerAdded, ImportDialog.ListenerAdded
		RaiseEvent ListenerAdded(Me, e)
		ldg_Listeners.Reload()
	End Sub

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles tbtn_Email.Click
		Using emails As New SendEmailsDialog
			Dim res = emails.ShowDialog()
		End Using
	End Sub
End Class
