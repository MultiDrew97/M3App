Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ListenerViewPanel
    Event ListenersUpdated As EventHandler
    Private __listeners As New Types.DBEntryCollection(Of Types.Listener)
    Private ReadOnly __listenerTable As New DataTables.ListenersDataTable

    Property Listeners As Types.DBEntryCollection(Of Types.Listener)
        Get
            Return __listeners
        End Get
        Set(value As Types.DBEntryCollection(Of Types.Listener))
            __listeners = value
            RaiseEvent ListenersUpdated(Me, New EventArgs())
        End Set
    End Property

    ReadOnly Property ListenerTable As DataTables.ListenersDataTable
        Get
            Return __listenerTable
        End Get
    End Property

    <DefaultValue(False)>
    Property AllowEditting As Boolean
        Get
            Return Not dgv_Listeners.ReadOnly
        End Get
        Set(value As Boolean)
            dgv_Listeners.ReadOnly = Not value
        End Set
    End Property

    <DefaultValue(False)>
    Property AllowAdding As Boolean
        Get
            Return dgv_Listeners.AllowUserToAddRows
        End Get
        Set(value As Boolean)
            dgv_Listeners.AllowUserToAddRows = value
        End Set
    End Property

    <DefaultValue(False)>
    Property AllowDeleting As Boolean
        Get
            Return dgv_Listeners.AllowUserToDeleteRows
        End Get
        Set(value As Boolean)
            dgv_Listeners.AllowUserToDeleteRows = value
        End Set
    End Property

    <DefaultValue(False)>
    Property AllowColumnReordering As Boolean
        Get
            Return dgv_Listeners.AllowUserToOrderColumns
        End Get
        Set(value As Boolean)
            dgv_Listeners.AllowUserToOrderColumns = value
        End Set
    End Property

    <DefaultValue(True)>
    Property ListenersSelectable As Boolean
        Get
            Return dgv_Listeners.Columns(1).Visible
        End Get
        Set(value As Boolean)
            dgv_Listeners.Columns(1).Visible = value
        End Set
    End Property

    Private Sub RefreshListeners(sender As Object, e As EventArgs) Handles Me.ListenersUpdated
        UseWaitCursor = True
        bw_LoadListenersTable.RunWorkerAsync()
    End Sub

    Private Sub LoadListenersTable(sender As Object, e As DoWorkEventArgs) Handles bw_LoadListenersTable.DoWork
        'Dim row As DataRow
        ListenerTable.Clear()
        Dim listenersArgument = CType(e.Argument, Types.DBEntryCollection(Of Types.Listener))
        For Each listener In If(listenersArgument, Listeners)
            ListenerTable.AddListenersRow(listener.Id, listener.Name, listener.Email)
            'row = ListenerTable.NewListenersDataRow

            'row("ListenerID") = listener.Id
            'row("Name") = listener.Name
            'row("EmailAddress") = listener.EmailAddress.Address

            '__listenerTable.Rows.Add(row)
        Next
    End Sub

    Private Sub ListenerSelectionPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Listeners = db_Listeners.GetListeners()
        bsListeners.DataSource = ListenerTable
    End Sub

    Private Sub LoadListenersFinished(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadListenersTable.RunWorkerCompleted
        UseWaitCursor = False
    End Sub

    Private Sub RemoveListener(sender As Object, e As DataGridViewRowEventArgs) Handles dgv_Listeners.UserDeletedRow
        Dim deletedListener = CType(e.Row.DataBoundItem, Types.Listener)
        Console.WriteLine(deletedListener.ToString)
    End Sub
End Class
