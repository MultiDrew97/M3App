Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Windows.Forms

Public Class MainMenuStrip
	Private ReadOnly toolStripPrefix As String = "tsmi_"

	''' <summary>
	''' Occurs when the Logout menu item is clicked
	''' </summary>
	Public Event Logout As EventHandler

	''' <summary>
	''' Occurs when the ViewCustomer menu item is clicked
	''' </summary>
	Public Event OpenCustomers As EventHandler

	''' <summary>
	''' Occurs when the ViewListener menu item is clicked
	''' </summary>
	Public Event OpenListeners As EventHandler

	''' <summary>
	''' Occurs when the ViewProducts menu item is clicked
	''' </summary>
	Public Event OpenProducts As EventHandler

	''' <summary>
	''' Occurs when the ViewOrders menu item is clicked
	''' </summary>
	Public Event OpenOrders As EventHandler

	''' <summary>
	''' Occurs when the Settings menu item is clicked
	''' </summary>
	Public Event OpenSettings As EventHandler

	''' <summary>
	''' Occurs when the Exit menu item is clicked
	''' </summary>
	Public Event ExitApplication As EventHandler

	''' <summary>
	''' Occurs when the Update menu item is clicked, and an update is available
	''' </summary>
	Public Event UpdateAvailable As EventHandler

	''' <summary>
	''' The location to save the installer for the application when updating
	''' </summary>
	Private ReadOnly _DownloadLocation As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", "M3")

	Private ReadOnly _VersionUri As New Uri(My.Resources.LatestAppVersionUri)
	Private ReadOnly _UpdateUri As New Uri(My.Resources.AppUpdateUri)

	Private Sub LogoutApplication(sender As Object, e As EventArgs) Handles tsmi_Logout.Click
		RaiseEvent Logout(Me, e)
	End Sub

	Private Sub [Exit](sender As Object, e As EventArgs) Handles tsmi_Exit.Click
		RaiseEvent ExitApplication(Me, e)
	End Sub

	Private Sub CreateCustomer(sender As Object, e As EventArgs) Handles tsmi_NewCustomer.Click
		Using newCustomer As New Dialogs.AddCustomerDialog
			newCustomer.ShowDialog()
		End Using
	End Sub

	Private Sub CreateProduct(sender As Object, e As EventArgs) Handles tsmi_NewProduct.Click
		Using newProduct As New AddProductDialog()
			newProduct.ShowDialog()
		End Using
	End Sub

	Private Sub CreateListener(sender As Object, e As EventArgs) Handles tsmi_NewListeners.Click
		Using newListener As New AddListenerDialog()
			newListener.ShowDialog()
		End Using
	End Sub

	Private Sub UpdateApp(sender As Object, e As EventArgs) Handles tsmi_Update.Click
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
		'lsd_Loading.LoadText = "Checking for updates..."
		'lsd_Loading.ShowDialog()

		'If IsUpdateAvailable() Then
		'	'RaiseEvent UpdateAvailable(sender, e)
		'	'wb_Updater.Url = New Uri(My.Resources.AppUpdateUri)
		'	bw_Update.RunWorkerAsync(wb_Updater)
		'Else
		'	'MessageBox.Show("Software is up to date", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
		'	lsd_Loading.LoadText = "Software is up to date"
		'End If
	End Sub

	Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles tsmi_ViewCustomers.Click
		RaiseEvent OpenCustomers(Me, e)
		'ToggleViewItem("ViewCustomers")
	End Sub

	Private Sub ViewProducts(sender As Object, e As EventArgs) Handles tsmi_ViewProducts.Click
		RaiseEvent OpenProducts(Me, e)
	End Sub

	Private Sub ViewOrders(sender As Object, e As EventArgs) Handles tsmi_ViewOrders.Click
		RaiseEvent OpenOrders(Me, e)
	End Sub

	Private Sub ViewListeners(sender As Object, e As EventArgs) Handles tsmi_ViewListeners.Click
		RaiseEvent OpenListeners(Me, e)
	End Sub

	Private Sub ViewSettings(sender As Object, e As EventArgs) Handles tsmi_Settings.Click
		RaiseEvent OpenSettings(Me, e)
	End Sub

	Private Sub UpdateAppBW(sender As Object, e As DoWorkEventArgs) Handles bw_Update.DoWork
		'Dim wb = CType(e.Argument, WebBrowser)
		'wb.Url = _UpdateUri
		Dim setupFileLocation = Path.Combine(_DownloadLocation, "M3Setup.exe")
		If File.Exists(setupFileLocation) Then
			File.Delete(setupFileLocation)
		End If

		My.Computer.Network.DownloadFile(My.Resources.AppUpdateUri, setupFileLocation)
		Try
			Process.Start(setupFileLocation)
			RaiseEvent UpdateAvailable(Me, New EventArgs)
		Catch
			e.Cancel = True
		End Try
	End Sub

	Private Function IsUpdateAvailable() As Boolean
		'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
		Dim versionFileLocation = Path.Combine(_DownloadLocation, "version.txt")
		Dim versionString As String = ""
		'Dim latestVersion As Version = Nothing
		'While latestVersion Is Nothing
		'	wb_Updater.Url = New Uri(My.Resources.LatestAppVersionUri)
		'	wb_Updater.Refresh()
		'	versionString = wb_Updater.DocumentText.Replace("Version", String.Empty).Replace(vbCrLf, String.Empty).Trim
		'	Try
		'		latestVersion = New Version(versionString)
		'	Catch
		'		Continue While
		'	End Try
		'End While
		If File.Exists(versionFileLocation) Then
			File.Delete(versionFileLocation)
		End If

		While Not File.Exists(versionFileLocation)
			Try
				My.Computer.Network.DownloadFile(My.Resources.LatestAppVersionUri, versionFileLocation)

				Dim latestVersion = New Version(My.Computer.FileSystem.ReadAllText(versionFileLocation).Replace("Version", String.Empty).Replace(vbCrLf, String.Empty).Trim)
				'
				' CompareTo
				'		-1 = Referenced Version is older
				'		0 = Referenced Version is the same
				'		1 = Referenced Version is newer
				'
				Console.WriteLine("Latest: {0}", latestVersion)
				Console.WriteLine("Current: {0}", My.Application.Info.Version)
				Console.WriteLine("Comparison: {0}", My.Application.Info.Version.CompareTo(latestVersion))

				Return My.Application.Info.Version.CompareTo(latestVersion) = -1
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit While
			Finally
				lsd_Loading.Closable = True
			End Try
		End While

		Return False
	End Function

	' TODO: Test that these 3 functions work properly
	Private Sub ToggleItem(parent As String, ParamArray path As String())
		Dim parentItemName = If(parent.Contains(toolStripPrefix), parent, String.Concat(toolStripPrefix, parent))
		Dim parentItem As ToolStripMenuItem = CType(Items(parentItemName), ToolStripMenuItem)

		If parentItem Is Nothing Then
			Throw New Exceptions.MenuException(String.Format("Menu item with name {0} not found", parent))
		End If

		ToggleItem(parentItem, path)
	End Sub

	Private Sub ToggleItem(parent As ToolStripMenuItem, ParamArray path As String())
		Dim currentItem As ToolStripMenuItem = parent

		Select Case path.Length
			Case 1
				currentItem = GetChildItem(parent, path(0))
			Case Else
				currentItem = parent
				For Each child As String In path
					currentItem = GetChildItem(currentItem, child)
				Next
		End Select

		currentItem.Available = Not currentItem.Available
	End Sub

	Private Function GetChildItem(parent As ToolStripMenuItem, name As String) As ToolStripMenuItem
		For Each item As ToolStripMenuItem In parent.DropDownItems
			If item.AccessibleName.Equals(name) Or item.Name.Contains(name) Then
				' The current child has the name that is being looked for
				Return item
			End If
		Next

		Throw New Exceptions.MenuException(String.Format("Menu item {0} under the parent of {1} not found", name, parent.AccessibleName))
	End Function

	Public Sub ToggleViewItem(itemName As String)
		'Dim viewName As String = String.Concat(toolStripPrefix, "View")
		'Dim viewCol As ToolStripMenuItem = CType(Items(viewName), ToolStripMenuItem)

		'' Iterates through the View tool strip item's children to try to find the specified name
		'For Each item As ToolStripItem In viewCol.DropDownItems
		'	If item.Name.Contains(itemName) Then
		'		' The current child has the name that is being looked for
		'		item.Available = (Not item.Available)
		'		Exit For
		'	End If
		'Next
		ToggleItem("view", (itemName))
	End Sub
End Class
