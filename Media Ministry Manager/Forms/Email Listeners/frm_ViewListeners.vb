Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.Helpers
Imports SPPBC.M3Tools.Types

Public Class Frm_ViewListeners
	Private ReadOnly ListenersTable As New CustomData.ListenersDataTable
	Private ReadOnly FiltersTable As New DataTable
	ReadOnly totalListeners As String = "Total Listeners: {0}"
	Private ListenersData As ObjectModel.Collection(Of Listener)

	Private Tooled As Boolean = False

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
		If Not Tooled Then
			Dim frm As New Frm_Main
			frm.Show()
		End If
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
		bsListeners.Filter = ""
	End Sub

	'Private Sub MaxChanges()
	'    'Change Locations
	'    gbx_Search.Location = Locations.SearchMax
	'    lbl_Total.Location = Locations.CountMax
	'    btn_Add.Location = Locations.AddMax

	'    'Change Visibilities
	'    btn_Advanced.Show()

	'    'Change Sizes
	'    dgv_Listeners.Size = Sizes.dgvMax
	'End Sub

	'Private Sub DefaultChanges()
	'    'Change Locations
	'    gbx_Search.Location = Locations.SearchNormal
	'    lbl_Total.Location = Locations.CountDefault
	'    btn_Add.Location = Locations.AddDefault

	'    'Change Visibilities
	'    txt_SearchBox.Show()
	'    cbx_Column.Show()
	'    btn_Advanced.Hide()
	'    gbx_AdvancedSearch.Hide()

	'    'Change Sizes
	'    dgv_Listeners.Size = Sizes.DefaultDGV
	'End Sub

	Private Sub Btn_AdvancedCancel_Click(sender As Object, e As EventArgs) Handles btn_AdvancedCancel.Click
		gbx_AdvancedSearch.Hide()
		gbx_Search.Show()

		txt_NameSearch.Text = ""
		txt_EmailSearch.Text = ""
		bsListeners.Filter = ""
	End Sub

	Private Sub GetData()
		Using db As New Database
			ListenersData = db.GetListeners()
		End Using
	End Sub

	Private Sub LoadData()
		Dim row As DataRow

		For Each listener As Listener In ListenersData
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
		Else
			bsListeners.Filter = ""
		End If
	End Sub

	Private Sub Txt_NameSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_NameSearch.TextChanged
		If Not String.IsNullOrWhiteSpace(txt_NameSearch.Text) Then
			If String.IsNullOrWhiteSpace(txt_EmailSearch.Text) Then
				bsListeners.Filter = String.Format("Name like '%{0}%'", txt_NameSearch.Text)
			Else
				bsListeners.Filter = String.Format("Name like '%{0}%' AND EmailAddress like '%{1}%'", txt_NameSearch.Text, txt_EmailSearch.Text)
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

	Private Sub Cbx_Column_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Column.SelectedIndexChanged
		txt_SearchBox.Text = ""
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		My.Settings.Username = ""
		My.Settings.Password = ""
		My.Settings.KeepLoggedIn = False
		My.Settings.Save()
		Me.Close()
	End Sub

	Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Utils.CloseOpenForms()
	End Sub

	Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
		AddCustomerDialog.ShowDialog()
	End Sub

	Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
		AddProductDialog.ShowDialog()
	End Sub

	Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewListenerToolStripMenuItem.Click
		AddListenerDialog.Show()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
		'Dim updateLocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
		'Dim updateCheck As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

		'Dim request As HttpWebRequest = WebRequest.CreateHttp(updateCheck)
		'Dim responce As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

		'Dim sr As StreamReader = New StreamReader(responce.GetResponseStream)

		'Dim latestVersion As String = sr.ReadToEnd()
		'Dim currentVersion As String = Application.ProductVersion

		'If Not latestVersion.Contains(currentVersion) Then
		'    wb_Updater.Navigate(updateLocation)
		'End If
		MessageBox.Show("This feature is currently under construction.", "Out of Order", MessageBoxButtons.OK, MessageBoxIcon.Hand)
	End Sub

	Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
		Dim customers As New Frm_DisplayCustomers(Me)
		customers.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
		Dim products As New Frm_DisplayInventory
		products.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrdersToolStripMenuItem.Click
		Dim orders As New Frm_DisplayOrders
		orders.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim listeners As New Frm_ViewListeners
		listeners.Show()
		Tooled = True
		Me.Close()
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
		Dim settings As New Frm_Settings()
		settings.Show()
	End Sub
End Class
