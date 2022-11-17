Option Strict On
Imports MediaMinistry.Helpers

Public Class Frm_DisplayOrders
    ' TODO: Add eventhandler for when data is updated to show/hide empty message
    Private Sub ViewLoading(sender As Object, e As EventArgs) Handles Me.Load
        doc_Orders.Reload()
        mms_Strip.ToggleViewItem("Orders")
        lbl_NoOrders.Visible = doc_Orders.IsEmpty
    End Sub

    Private Sub ViewClosed(sender As Object, e As EventArgs) Handles Me.Closed
        mms_Strip.ToggleViewItem("Orders")
        Frm_Main.Show()
    End Sub

    Private Sub CompleteOrder(sender As Object, e As EventArgs) Handles btn_Complete.Click
        doc_Orders.FulfilOrder()
    End Sub

    Private Sub ShowCompleted(sender As Object, e As EventArgs) Handles btn_ShowCompleted.Click
        'TODO: Create a new form or dialog box to show completed orders
        doc_Orders.ShowCompleted = Not doc_Orders.ShowCompleted
    End Sub

    Private Sub Logout() Handles mms_Strip.Logout
        Utils.Logout()
        Me.Close()
    End Sub

    Private Sub ExitApplication() Handles mms_Strip.ExitApplication, mms_Strip.UpdateAvailable
        Utils.CloseOpenForms()
    End Sub

    Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles mms_Strip.OpenCustomers
        Dim customers As New Frm_DisplayCustomers()
        customers.Show()
        Utils.SpecialClose(sender)
        Me.Close()
    End Sub

    Private Sub ViewProducts(sender As Object, e As EventArgs) Handles mms_Strip.OpenProducts
        Dim products As New Frm_DisplayInventory()
        products.Show()
        Utils.SpecialClose(sender)
        Me.Close()
    End Sub

    Private Sub ViewListeners(sender As Object, e As EventArgs) Handles mms_Strip.OpenListeners
        Dim listeners As New Frm_ViewListeners()
        listeners.Show()
        Utils.SpecialClose(sender)
        Me.Close()
    End Sub

    Private Sub ViewSettings() Handles mms_Strip.OpenSettings
        Dim settings As New Frm_Settings()
        settings.Show()
    End Sub

    Private Sub DataUpdated() Handles doc_Orders.DataChanged
        lbl_NoOrders.Visible = doc_Orders.IsEmpty
    End Sub
End Class