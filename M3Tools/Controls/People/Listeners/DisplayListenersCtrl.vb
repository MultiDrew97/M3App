Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DisplayListenersCtrl
	Public Event ListenerAdded As Events.Listeners.ListenerEventHandler
	Public Event Emails()
	Private WithEvents ImportDialog As Dialogs.ImportListenersDialog
	Private WithEvents AddDialog As Dialogs.AddListenerDialog
	Private ReadOnly countTemplate As String = "Count: {0}"

	Public Property DataSource As BindingSource
		Get
			Return bsListeners
		End Get
		Set(value As BindingSource)
			bsListeners = value
		End Set
	End Property

	Public Sub Reload() Handles cms_Tools.RefreshView
		ldg_Listeners.Reload()
		tsl_Count.Text = String.Format(countTemplate, ldg_Listeners.Listeners.Count)
	End Sub

	Private Sub NewListener(sender As Object, e As EventArgs) Handles tbtn_AddListener.Click
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

	Private Sub AddNewListener(sender As Object, e As Events.Listeners.ListenerEventArgs) Handles AddDialog.ListenerAdded, ImportDialog.ListenerAdded
		RaiseEvent ListenerAdded(Me, e)
	End Sub

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles tbtn_Email.Click
		RaiseEvent Emails()
	End Sub
End Class
