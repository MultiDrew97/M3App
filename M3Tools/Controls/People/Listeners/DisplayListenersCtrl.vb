Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Listeners

Public Class DisplayListenersCtrl
	Public Event ListenerAdded As ListenerEventHandler
	Public Event RemoveListener As ListenerEventHandler
	Public Event UpdateListener As ListenerEventHandler
	Public Event Emails()
	Private WithEvents ImportDialog As Dialogs.ImportListenersDialog
	Private WithEvents AddDialog As Dialogs.AddListenerDialog
	Private ReadOnly countTemplate As String = "Count: {0}"

	Public Property DataSource As BindingSource
		Get
			Return ldg_Listeners.DataSource
		End Get
		Set(value As BindingSource)
			ldg_Listeners.DataSource = value
		End Set
	End Property

	Public Sub Reload() Handles cms_Tools.RefreshView
		tsl_Count.Text = String.Format(countTemplate, ldg_Listeners.Listeners.Count)
	End Sub

	Private Sub NewListener(sender As Object, e As EventArgs) Handles tbtn_AddListener.Click
		Using add = New Dialogs.AddListenerDialog
			If add.ShowDialog() = DialogResult.OK Then
				RaiseEvent ListenerAdded(Me, New ListenerEventArgs(add.Listener))
			End If
		End Using
	End Sub

	Private Sub FilterChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
		ldg_Listeners.Filter = txt_Filter.Text
	End Sub

	Private Sub ImportListeners(sender As Object, e As EventArgs) Handles tbtn_Import.Click
		Using import = New Dialogs.ImportListenersDialog()
			Dim res = import.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			For Each listener As Types.Listener In import.Listeners
				RaiseEvent ListenerAdded(Me, New ListenerEventArgs(listener, M3Tools.Events.EventType.Added))
			Next
		End Using
	End Sub

	Private Sub ToolsOpened(sender As Object, e As EventArgs) Handles cms_Tools.Opened
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

	Private Sub DeleteListener(sender As Object, e As ListenerEventArgs) Handles ldg_Listeners.RemoveListener
		RaiseEvent RemoveListener(sender, e)
	End Sub

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles tbtn_Email.Click
		RaiseEvent Emails()
	End Sub

	Private Sub ldg_Listeners_EditListener(sender As Object, e As ListenerEventArgs) Handles ldg_Listeners.EditListener
		Using edit As New Dialogs.EditListenerDialog(e.Listener)
			Dim res = edit.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent UpdateListener(Me, New ListenerEventArgs(edit.Listener))
		End Using
	End Sub
End Class
