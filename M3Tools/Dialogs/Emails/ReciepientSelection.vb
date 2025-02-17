﻿Imports System.Windows.Forms

Public Class ReciepientSelection

	ReadOnly Property Selection As Types.DBEntryCollection(Of Types.Listener)
		Get
			Dim list As New Types.DBEntryCollection(Of Types.Listener)()

			For Each listener As DataGridViewRow In ldg_Listeners.SelectedListeners
				list.Add(CType(listener.DataBoundItem, Types.Listener))
			Next

			Return list
		End Get
	End Property

	Public Property DataSource As BindingSource
		Get
			Return ldg_Listeners.DataSource
		End Get
		Set(value As BindingSource)
			ldg_Listeners.DataSource = value
		End Set
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
End Class
