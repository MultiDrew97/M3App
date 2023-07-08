Imports System.ComponentModel
Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Listeners

Public Class DisplayListenersCtrl
	Public Event ListenerAdded As ListenerEventHandler
	Public Event RemoveListener As ListenerEventHandler
	Public Event UpdateListener As ListenerEventHandler
	Public Event AddListener As ListenerEventHandler
	Public Event FilterChanged(value As String)
	Public Event RefreshDisplay()
	Public Event SendEmails()

	Public Property CountTemplate As String

	Public Property DataSource As BindingSource
		Get
			Return ldg_Listeners.DataSource
		End Get
		Set(value As BindingSource)
			ldg_Listeners.DataSource = value
		End Set
	End Property

	Public Sub Reload()
		tsl_Count.Text = String.Format(CountTemplate, ldg_Listeners.Listeners.Count)
	End Sub

	Private Sub RefreshView() Handles ldg_Listeners.RefreshDisplay
		RaiseEvent RefreshDisplay()
	End Sub

	Private Sub NewListener(sender As Object, e As EventArgs) Handles tbtn_AddListener.Click
		Using add As New Dialogs.AddListenerDialog
			Dim res = add.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent AddListener(Me, New ListenerEventArgs(add.Listener))
		End Using
	End Sub

	Private Sub FilterUpdated(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
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

	Private Sub DeleteListener(sender As Object, e As ListenerEventArgs) Handles ldg_Listeners.RemoveListener
		Dim res = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If Not res = DialogResult.Yes Then
			Return
		End If

		RaiseEvent RemoveListener(sender, e)
	End Sub

	Private Sub OpenEmails(sender As Object, e As EventArgs) Handles tbtn_Email.Click
		RaiseEvent SendEmails()
	End Sub

	Private Sub EditListener(sender As Object, e As ListenerEventArgs) Handles ldg_Listeners.EditListener
		Using edit As New Dialogs.EditListenerDialog(e.Listener)
			Dim res = edit.ShowDialog()

			If Not res = DialogResult.OK Then
				Return
			End If

			RaiseEvent UpdateListener(Me, New ListenerEventArgs(edit.Listener))
		End Using
	End Sub
End Class
