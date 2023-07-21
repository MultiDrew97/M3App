Imports System.ComponentModel
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Util.Store

Namespace GTools
	Public Class API
		Inherits Component

		<Category("User")>
		<SettingsBindable(True)>
		<Description("The username of the currently logged in user")>
		Friend Property Username As String

		Friend __init As New BaseClientService.Initializer() With {
			.ApplicationName = "Media Ministry Manager"
		}

		'Friend ReadOnly Property SaveLocation As String
		'	Get
		'		'TODO: Change saving folder. Requires admin permissions to save here
		'		Dim folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
		'		Return IO.Path.Combine(folder, $"SPPBC\{CurrentUser}\Tokens")
		'	End Get
		'End Property

		Friend ReadOnly Property SaveLocation As FileDataStore
			Get
				'TODO: Change saving folder. Requires admin permissions to save here
				Dim folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Dim path = IO.Path.Combine(folder, $"SPPBC\{Username}\Tokens")

				Return New FileDataStore(path)
			End Get
		End Property

		Friend Sub LoadCreds(user As String, scopes As String(), ct As Threading.CancellationToken)
			Dim stream As New IO.MemoryStream(My.Resources.credentials)

			__init.HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.FromStream(stream).Secrets, scopes,
					user, ct, SaveLocation).Result
		End Sub

		''' <summary>
		''' Authorize with Google Drive based on the username passed
		''' </summary>
		''' <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		Public Overridable Sub Authorize(username As String, Optional ct As Threading.CancellationToken = Nothing)
			' Place general authorization logic here
			Me.Username = username
		End Sub
	End Class
End Namespace
