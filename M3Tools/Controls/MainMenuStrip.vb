Imports System.Windows.Forms

Public Class MainMenuStrip
	''' <summary>
	''' Occurs when the Logout menu item is clicked
	''' </summary>
	Public Event Logout As EventHandler
	'Public Event Close As EventHandler
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
	Public Event [Exit] As EventHandler

	Public Sub New()
		MyBase.New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub LogoutApplication(sender As Object, e As EventArgs) Handles tsmi_Logout.Click
		RaiseEvent Logout(Me, e)
	End Sub

	Private Sub ExitApplication(sender As Object, e As EventArgs) Handles tsmi_Exit.Click
		RaiseEvent [Exit](Me, e)
	End Sub

	Private Sub CreateCustomer(sender As Object, e As EventArgs) Handles tsmi_NewCustomer.Click
		Using newCustomer As New AddCustomerDialog
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

	Private Sub UpdateApplication(sender As Object, e As EventArgs) Handles tsmi_Update.Click
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

	Private Sub ViewCustomers(sender As Object, e As EventArgs) Handles tsmi_ViewCustomers.Click
		RaiseEvent OpenCustomers(Me, e)
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
End Class
