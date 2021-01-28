﻿Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.Types.Listener

Public Class Frm_ViewListeners
    Private ListenersTable As New CustomData.ListenersDataTable
    Private FiltersTable As New DataTable

    ReadOnly totalListeners As String = "Total Listeners: {0}"
    Private ListenersData As ObjectModel.Collection(Of Types.Listener)

    Structure Sizes
        'window sizes
        Shared normal As New Size(1094, 566)

        'dgv sizes
        Shared DefaultDGV As New Size(737, 503)

        Shared dgvMax As New Size(957, 705)
    End Structure

    Structure Locations

        'add button locations
        Shared AddDefault As New Point(792, 344)
        Shared AddMax As New Point(1093, 555)

        'count label locations
        Shared CountDefault As New Point(787, 386)
        Shared CountMax As New Point(1088, 616)

        'Search Group box locations
        Shared SearchNormal As New Point(743, 47)
        Shared SearchMax As New Point(968, 64)
    End Structure

    Private Sub Frm_ViewListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsListeners.DataSource = ListenersTable
        bsFilters.DataSource = FiltersTable
        FiltersTable.Columns.AddRange({New DataColumn("ColumnPlain", GetType(String)), New DataColumn("Column", GetType(String))})
        cbx_Column.DisplayMember = "ColumnPlain"
        Refresh()
    End Sub

    Private Shadows Sub Refresh()
        GetData()
        LoadData()
        dgv_Listeners.Sort(dgv_Listeners.Columns(0), ListSortDirection.Ascending)
        cbx_Column.SelectedIndex = 0
        UpdateTotal()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If AddListenerDialog.ShowDialog() = DialogResult.OK Then
            Refresh()
        End If
    End Sub

    Private Sub Frm_ViewListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main
        frm.Show()
    End Sub

    Private Sub Dgv_Listeners_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
        Using db = New Database
            db.RemoveListener(CInt(CType(e.Row.DataBoundItem, DataRowView)("ListenerID")))
        End Using
    End Sub

    Private Sub Dgv_Listeners_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellEndEdit
        Dim column As String = CStr(dgv_Listeners.Columns(e.ColumnIndex).DataPropertyName)
        Dim value As String = CStr(dgv_Listeners.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Dim listenerID As Integer = CInt(CType(dgv_Listeners.Rows(e.RowIndex).DataBoundItem, DataRowView)("ListenerID"))

        Using db As New Database
            db.UpdateListener(listenerID, column, value)
        End Using
    End Sub

    Private Sub UpdateTotal()
        lbl_Total.Text = String.Format(totalListeners, dgv_Listeners.RowCount())
    End Sub

    Private Sub Dgv_Listeners_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgv_Listeners.UserDeletedRow
        UpdateTotal()
    End Sub

    Private Sub Frm_ViewListeners_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'If Not Me.Size.Equals(Sizes.normal) Then
        '    MaxChanges()
        'Else
        '    DefaultChanges()
        'End If
    End Sub

    Private Sub Btn_Advanced_Click(sender As Object, e As EventArgs) Handles btn_Advanced.Click
        gbx_AdvancedSearch.Show()
        gbx_Search.Hide()

        txt_SearchBox.Text = ""
    End Sub

    Private Sub MaxChanges()
        'Change Locations
        gbx_Search.Location = Locations.SearchMax
        lbl_Total.Location = Locations.CountMax
        btn_Add.Location = Locations.AddMax

        'Change Visibilities
        btn_Advanced.Show()

        'Change Sizes
        dgv_Listeners.Size = Sizes.dgvMax
    End Sub

    Private Sub DefaultChanges()
        'Change Locations
        gbx_Search.Location = Locations.SearchNormal
        lbl_Total.Location = Locations.CountDefault
        btn_Add.Location = Locations.AddDefault

        'Change Visibilities
        txt_SearchBox.Show()
        cbx_Column.Show()
        btn_Advanced.Hide()
        gbx_AdvancedSearch.Hide()

        'Change Sizes
        dgv_Listeners.Size = Sizes.DefaultDGV
    End Sub

    Private Sub Btn_AdvancedCancel_Click(sender As Object, e As EventArgs) Handles btn_AdvancedCancel.Click
        gbx_AdvancedSearch.Hide()
        gbx_Search.Show()

        txt_NameSearch.Text = ""
        txt_EmailSearch.Text = ""
    End Sub

    Private Sub GetData()
        Using db As New Database
            ListenersData = db.GetListeners
        End Using
    End Sub

    Private Sub LoadData()
        Dim row As DataRow

        For Each listener As Types.Listener In ListenersData
            row = ListenersTable.NewRow
            row("ListenerID") = listener.Id
            row("Name") = listener.Name
            row("EmailAddress") = listener.EmailAddress.Address
            ListenersTable.Rows.Add(row)
        Next

        row = FiltersTable.NewRow
        row("ColumnPlain") = "Name"
        row("Column") = "Name"
        FiltersTable.Rows.Add(row)
        row = FiltersTable.NewRow
        row("ColumnPlain") = "Email Address"
        row("Column") = "EmailAddress"
        FiltersTable.Rows.Add(row)
    End Sub

    Private Sub Txt_SearchBox_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchBox.TextChanged
        If Not String.IsNullOrWhiteSpace(txt_SearchBox.Text) Then
            bsListeners.Filter = String.Format("{0} like '%{1}%'", CType(cbx_Column.SelectedItem, DataRowView)("Column"), txt_SearchBox.Text)
        End If
    End Sub

    Private Sub Txt_NameSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_NameSearch.TextChanged
        If Not String.IsNullOrWhiteSpace(txt_NameSearch.Text) Then
            If String.IsNullOrWhiteSpace(txt_EmailSearch.Text) Then
                bsListeners.Filter = String.Format("Name like '%{1}%'", "Name", txt_NameSearch.Text)
            Else
                bsListeners.Filter = String.Format("Name like '%{1}%' AND EmailAddress like '%{1}%'", txt_NameSearch.Text, txt_EmailSearch.Text)
            End If
        End If
    End Sub

    Private Sub Txt_EmailSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_EmailSearch.TextChanged
        If Not String.IsNullOrWhiteSpace(txt_EmailSearch.Text) Then
            If String.IsNullOrWhiteSpace(txt_NameSearch.Text) Then
                bsListeners.Filter = String.Format("EmailAddress like '%{0}%'", txt_EmailSearch.Text)
            Else
                bsListeners.Filter = String.Format("Name like '%{0}%' AND EmailAddress like '%{1}%'", txt_NameSearch.Text, txt_EmailSearch.Text)
            End If
        End If
    End Sub
End Class
