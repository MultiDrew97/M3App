Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports SPPBC.M3Tools.Types

Public Class ListenerSelectionDialog
    Shared Property Listeners As New Collection(Of Listener)
	Private ListenerList As Collection(Of Listener)
	Private ReadOnly ListenersTable As New CustomData.ListenersDataTable
    Private column As String

    Private Sub ListenerSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Add a search function to easily find specific listeners
        bsListeners.DataSource = ListenersTable
        cbx_Column.SelectedIndex = 0
        bw_RetrieveListeners.RunWorkerAsync()
    End Sub

    Public Overrides Sub Refresh()
        Listeners.Clear()
        ClearSelections()
    End Sub

    Private Sub Btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            If CBool(row.Cells(0).Value) = True Then
                Listeners.Add(Listener.Parse(ListenersTable.Rows(row.Index).ItemArray()))
            End If
        Next

        If Listeners.Count >= 1 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = DialogResult.Retry
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chk_AllListeners_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AllListeners.CheckedChanged
        If chk_AllListeners.Checked Then
            bw_AllListeners.RunWorkerAsync()
        Else
            Refresh()
        End If
    End Sub

    Private Sub Bw_RetrieveListeners_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_RetrieveListeners.DoWork
		'Using db As New Database()
		'    ListenerList = db.GetListeners()
		'End Using
	End Sub

    Private Sub FillTable()
        Try
            Dim row As DataRow

            For Each listener In ListenerList
                row = ListenersTable.NewRow
                row("ListenerID") = listener.Id
                row("Name") = listener.Name
				row("EmailAddress") = listener.Email
				ListenersTable.Rows.Add(row)
            Next
        Catch ex As ConstraintException

        End Try
    End Sub

    Private Sub Bw_RetrieveListeners_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_RetrieveListeners.RunWorkerCompleted
        FillTable()
        Refresh()
    End Sub

    Private Sub Cbx_Column_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Column.SelectedIndexChanged
        txt_Search.Text = ""
        column = If(cbx_Column.SelectedItem.ToString.Equals("Email Address"), "EmailAddress", "Name")
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        bsListeners.Filter = String.Format("{0} like '%{1}%'", column, txt_Search.Text)
    End Sub

    Private Sub Bw_AllListeners_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_AllListeners.DoWork
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            row.Cells(0).Value = True
        Next
    End Sub

    Private Sub ClearSelections()
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            If CBool(row.Cells(0).Value) = True Then
                row.Cells(0).Value = False
            End If
        Next
    End Sub
End Class
