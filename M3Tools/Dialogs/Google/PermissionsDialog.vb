Imports System.Windows.Forms
Imports Google.Apis.Drive.v3.Data

Public Class PermissionsDialog
	Public Property Permission As New Permission

	Private ReadOnly __roles As String() = {"Owner", "Organizer", "File Organizer", "Writer", "Commenter", "Reader"}
	Private ReadOnly __types As String() = {"User", "Group", "Domain", "Anyone"}

	Private Sub SetPermission(sender As Object, e As EventArgs) Handles OK_Button.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub PermissionsDialogLoaded(sender As Object, e As EventArgs) Handles MyBase.Load
		bsRoles.DataSource = __roles
		bsTypes.DataSource = __types
		cbx_Role.SelectedItem = "Reader"
		cbx_Type.SelectedItem = "Anyone"
	End Sub

	Private Sub RoleChanged(sender As Object, e As EventArgs) Handles cbx_Role.SelectedIndexChanged
		Permission.Role = CStr(cbx_Role.SelectedItem).Replace(" "c, "")
	End Sub

	Private Sub TypeChanged(sender As Object, e As EventArgs) Handles cbx_Type.SelectedIndexChanged
		Permission.Type = CStr(cbx_Type.SelectedItem).Replace(" "c, "")
	End Sub
End Class
