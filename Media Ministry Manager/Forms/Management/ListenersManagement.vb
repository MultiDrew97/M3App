Imports System.ComponentModel
Imports SPPBC.M3Tools.Events.Listeners

Public Class ListenersManagement

	Private Event ListenerAdded As ListenerEventHandler
	Private Event ListenerDBModified As ListenerEventHandler
	Private Tooled As Boolean = False

	Private Sub Loading(sender As Object, e As EventArgs) Handles Me.Load
		mms_Main.ToggleViewItem("Listeners")
		gt_Email.Authorize(My.Settings.Username)
		gd_Drive.Authorize(My.Settings.Username)
		Reload()
	End Sub

	Private Sub ClosingForm(sender As Object, e As CancelEventArgs) Handles Me.Closing
		' TODO: Find easier way
		If Tooled Then
			Return
		End If

		MainForm.Show()
	End Sub

	Private Sub Logout() Handles mms_Main.Logout
		Helpers.Utils.LogOff()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ExitApplication() Handles mms_Main.ExitApplication, mms_Main.UpdateAvailable
		Helpers.Utils.CloseOpenForms()
	End Sub

	Private Sub ManageCustomers(sender As Object, e As EventArgs) Handles mms_Main.ManageCustomers
		Dim customers As New CustomersManagement()
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageOrders(sender As Object, e As EventArgs) Handles mms_Main.ManageOrders
		Dim orders As New OrderManagement()
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ManageProducts(sender As Object, e As EventArgs) Handles mms_Main.ManageProducts
		Dim products As New InventoryManagement()
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ViewSettings() Handles mms_Main.ViewSettings
		Dim settings As New SettingsForm()
		settings.ShowDialog()
	End Sub

	Private Sub SendEmails() Handles dlc_Listeners.SendEmails
		Using emails As New SendEmailsDialog()
			UseWaitCursor = True
			emails.ShowDialog()
			UseWaitCursor = False
		End Using
	End Sub

	Private Sub RemoveListener(sender As Object, e As ListenerEventArgs) Handles dlc_Listeners.RemoveListener
		UseWaitCursor = True
		dbListeners.RemoveListener(e.Listener.Id)
		RaiseEvent ListenerDBModified(Me, e)
	End Sub

	Private Sub AddListener(sender As Object, e As ListenerEventArgs) Handles mms_Main.AddListener, dlc_Listeners.AddListener
		UseWaitCursor = True
		dbListeners.AddListener(e.Listener.Name, e.Listener.Email)
		RaiseEvent ListenerAdded(Me, e)
	End Sub

	Private Sub SendWelcom(sender As Object, e As ListenerEventArgs) Handles Me.ListenerAdded
		UseWaitCursor = True
		Dim subject = "Welcome to the Ministry"
		Dim body = String.Format(newListener, e.Listener.Name.Trim)
		Dim message = gt_Email.Create(e.Listener, subject, body)
#If Not DEBUG Then
		gt_Email.Send(message)
#End If
		RaiseEvent ListenerDBModified(Me, e)
	End Sub

	Private Sub UpdateListener(sender As Object, e As ListenerEventArgs) Handles dlc_Listeners.UpdateListener
		UseWaitCursor = True
		dbListeners.UpdateListener(e.Listener)
		RaiseEvent ListenerDBModified(Me, e)
	End Sub

	Private Sub Reload() Handles dlc_Listeners.RefreshDisplay, Me.ListenerDBModified
		UseWaitCursor = True
		bsListeners.Clear()
		For Each listener In dbListeners.GetListeners()
			bsListeners.Add(listener)
		Next
		dlc_Listeners.Reload()
		UseWaitCursor = False
	End Sub
End Class
