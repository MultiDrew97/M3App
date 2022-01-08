Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports SPPBC.M3Tools.Types.GoogleAPI

Namespace GoogleAPI
	Public Class GoogleDriveTool
		Implements IDisposable, IGoogleService(Of Data.User)

		Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}
		Private ReadOnly ApplicationName As String = "Media Ministry Manager"
		Private __credential As UserCredential
		Private __service As DriveService
		Private ReadOnly __defaultPermissions As New Data.Permission With {
			.Role = "reader",
			.Type = "anyone"
		}

		''' <summary>
		''' Gets the account information for the current user.
		''' </summary>
		''' <returns>The user account info for the current user</returns>
		ReadOnly Property UserAccount As Data.User Implements IGoogleService(Of Data.User).UserAccount
			Get
				Return __service.About.Get().Execute().User
			End Get
		End Property

		''' <summary>
		''' Authorize with Google Drive based on the username passed
		''' </summary>
		''' <param name="username">Username of the currently logged in user</param>
		''' <param name="ct">The cancellation token in case the authorization needs to be canceled</param>
		Public Async Function Authorize(username As String, Optional ct As Threading.CancellationToken = Nothing) As Task
			Dim credPath = String.Format("SPPBC\{0}\Tokens", username)

			Using stream As New IO.MemoryStream(My.Resources.credentials)
				__credential = Await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", If(IsNothing(ct), Threading.CancellationToken.None, ct), New FileDataStore(credPath))
			End Using

			'Create Drive API service.
			__service = New DriveService(New BaseClientService.Initializer() With {
				.HttpClientInitializer = __credential,
				.ApplicationName = ApplicationName
			})
		End Function

		''' <summary>
		''' Closes the connection to Google Drive
		''' </summary>
		Sub Close() Implements IDisposable.Dispose
			GC.SuppressFinalize(Me)
		End Sub

		''' <summary>
		''' Upload a new file to the drive
		''' </summary>
		''' <param name="file">The file to be uploaded. Contains folder information</param>
		''' <param name="uploadName">The desired name to name the file when uploaded</param>
		''' <exception cref="Exceptions.UploadException"></exception>
		Function UploadFile(file As File, uploadName As String, Optional permissions As Data.Permission = Nothing) As Task
			Dim fileMetadata As New Data.File() With {
				.Name = uploadName, 'If(uploadName, Utils.DefaultFileName(file.Name)),
				.Parents = file.Parents
			}

			Dim request As FilesResource.CreateMediaUpload

			Using reader As New IO.FileStream(file.Name, IO.FileMode.Open)
				request = __service.Files.Create(fileMetadata, reader, MimeKit.MimeTypes.GetMimeType(file.Name))
				request.Fields = "id"
				request.Upload()
			End Using

			If request.ResponseBody Is Nothing Then
				Throw New Exceptions.UploadException("Something went wrong uploading the file.")
			End If

			Try
				SetPermissions(request.ResponseBody.Id, permissions)
			Catch ex As Exception
				Throw New Exceptions.UploadException("File Uploaded Successfully. Failed to set permissions on file.")
			End Try
		End Function

		''' <summary>
		''' Create a new folder based on information passed
		''' </summary>
		''' <param name="folderName">The name of the new folder</param>
		''' <param name="parents">The parent folders, if any, for the new folder to be in</param>
		Function CreateFolder(folderName As String, Optional parents As IList(Of String) = Nothing) As Task(Of Object)
			Try
				If FolderExists(folderName).Result Then
					Throw New Exceptions.FolderException("Folder exists.")
				End If

				Dim fileMetadata As New Data.File With {
					.Name = folderName,
					.MimeType = "application/vnd.google-apps.folder",
					.Parents = parents
				}

				Dim request = __service.Files.Create(fileMetadata)
				request.Fields = "id, parents"
				Dim result = request.Execute()
				Console.WriteLine(result.Parents)
				Return Task.FromResult(Of Object)(Nothing)
			Catch ex As Exceptions.FolderException
				Throw New Exceptions.FolderException(String.Format("Folder with the name {0} already exists.", folderName), ex)
			End Try
		End Function

		''' <summary>
		''' Gets the ID of the desired folder
		''' </summary>
		''' <param name="name">The name of the folder to find the ID of</param>
		''' <returns>The id of the desired the folder, if it exists</returns>
		''' <exception cref="Exceptions.FolderException"></exception>
		Function GetFolderID(name As String) As Task(Of String)
			If String.IsNullOrWhiteSpace(name) Then
				Throw New Exceptions.FolderException("Folder name was empty")
			End If

			Dim pageToken As String = Nothing
			Dim request As FilesResource.ListRequest = __service.Files.List()

			Do

				request.Q = "mimeType='application/vnd.google-apps.folder'"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name)"
				request.PageToken = pageToken

				Dim result As Data.FileList = request.Execute()

				For Each folder As Data.File In result.Files
					If (folder.Name.Equals(name)) Then
						Return Task.FromResult(folder.Id)
					End If
				Next

				pageToken = result.NextPageToken
			Loop While pageToken IsNot Nothing

			Throw New Exceptions.FolderException("Folder not found")
		End Function

		''' <summary>
		''' Sets the permissions for the specified file
		''' </summary>
		''' <param name="fileID">The ID of the file to set permissions for</param>
		''' <returns></returns>
		Private Function SetPermissions(fileID As String, Optional permissions As Data.Permission = Nothing) As Task
			'Dim request As PermissionsResource.CreateRequest = __service.Permissions.Create(__permissions, fileID)
			__service.Permissions.Create(If(permissions, __defaultPermissions), fileID).Execute()
		End Function


		''' <summary>
		''' Gets the ID of the desired file if it exists
		''' </summary>
		''' <param name="fileName">The name of the desired file</param>
		''' <returns>The ID of the desired file</returns>
		''' <exception cref="Exceptions.FileException"></exception>
		Public Function GetFileID(fileName As String) As Task(Of String)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing

			Do
				request.Q = "mimeType!='application/vnd.google-apps.folder'"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					If file.Name = fileName Then
						Return Task.FromResult(file.Id)
					End If
				Next

				pageToken = results.NextPageToken
			Loop While pageToken IsNot Nothing

			Throw New Exceptions.FileException(String.Format("File with file name {0} could not be found.", fileName))
		End Function

		''' <summary>
		''' Gets the desired file based on the provided information.
		''' </summary>
		''' <param name="fileName">The name of the file to get</param>
		''' <param name="folderName">The name of the folder that holds the desired file</param>
		''' <returns>All file information for the desired file</returns>
		''' <exception cref="Exceptions.FolderException"></exception>
		''' <exception cref="Exceptions.FileException"></exception>
		Public Function GetFile(fileName As String, Optional folderName As String = Nothing) As Task(Of Data.File)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing, folderID As String

			Try
				folderID = GetFolderID(folderName).Result
			Catch ex As Exceptions.FolderException
				folderID = Nothing
			End Try

			Do
				request.Q = "mimeType!='application/vnd.google-apps.folder'"
				If folderID IsNot Nothing Then
					request.Q &= String.Format(" and '{0}' in parents", folderID)
				End If

				'request.Q = If(folderID Is Nothing, "mimeType!='application/vnd.google-apps.folder'", String.Format("mimeType!='application/vnd.google-apps.folder' and '{0}' in parents", folderID))
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, parents)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					If file.Name.Equals(fileName) Then
						Return Task.FromResult(file)
					End If
				Next

				pageToken = results.NextPageToken
			Loop While pageToken IsNot Nothing

			Throw New Exceptions.FileException(String.Format("File with name {0} could not be found.", fileName))
		End Function

		''' <summary>
		''' Gets all files in a given folder
		''' </summary>
		''' <param name="folderName">The name of the folder to pull the files from</param>
		''' <returns>A collection of all files contained in the given folder</returns>
		''' <exception cref="Exceptions.FolderException"></exception>
		Public Function GetFiles(folderName As String) As Task(Of FileCollection)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing
			Dim files As New FileCollection()
			Dim folderID As String = GetFolderID(folderName).Result

			Do
				request.Q = String.Format("mimeType!='application/vnd.google-apps.folder' and '{0}' in parents", folderID)
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, mimeType, parents, fileExtension, fullFileExtension)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					Console.WriteLine(file.FileExtension)
					Console.WriteLine(file.FullFileExtension)
					files.Add(New File(file.Id) With {
								.Name = file.Name,
								.FileType = file.MimeType,
								.Parents = New ObjectModel.Collection(Of String)(file.Parents)
							  })
				Next

				pageToken = results.NextPageToken
			Loop While pageToken IsNot Nothing

			Return Task.FromResult(files)
		End Function

		''' <summary>
		''' Gets all folders in the users drive folder
		''' </summary>
		''' <returns>A collection of folders</returns>
		Public Function GetFolders() As Task(Of FileCollection)
			Dim folders As New FileCollection
			Dim pageToken As String = Nothing
			Dim request As FilesResource.ListRequest = __service.Files.List()

			Do
				request.Q = "mimeType='application/vnd.google-apps.folder'"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, parents, mimeType)"
				request.PageToken = pageToken

				Dim result As Data.FileList = request.Execute()

				For Each folder As Data.File In result.Files
					folders.Add(New Folder(folder.Id) With {
									.Name = folder.Name,
									.FileType = folder.MimeType,
									.Parents = If(folder.Parents Is Nothing, Nothing, New ObjectModel.Collection(Of String)(folder.Parents))
								})
				Next

				pageToken = result.NextPageToken
			Loop While pageToken IsNot Nothing

			Return Task.FromResult(folders)
		End Function

		''' <summary>
		''' Gets all folders and the children folders and files under them
		''' </summary>
		''' <returns>A collection of folders that contains their child files and folders</returns>
		Function GetFoldersWithChildren() As Task(Of FileCollection)
			Dim folders = GetFolders()
			For Each folder As Folder In folders.Result
				folder.Children.AddRange(GetChildren(folder.Id).Result)
			Next

			Return Task.FromResult(folders.Result)
		End Function

		''' <summary>
		''' Gets the children of a certain folder using its ID
		''' </summary>
		''' <param name="parentID">The ID of the folder to get the children from</param>
		''' <returns>A collection of files that are contained in the specified folder</returns>
		Public Function GetChildren(parentID As String) As Task(Of FileCollection)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing
			Dim files As New FileCollection

			Do
				request.Q = String.Format("'{0}' in parents", parentID)
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, mimeType, parents)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					Select Case file.MimeType
						Case "application/vnd.google-apps.folder"
							files.Add(New Folder(file.Id) With {
								.Name = file.Name,
								.FileType = file.MimeType,
								.Parents = New ObjectModel.Collection(Of String)(file.Parents)
							  })
						Case Else
							files.Add(New Types.GoogleAPI.File(file.Id) With {
								.Name = file.Name,
								.FileType = file.MimeType,
								.Parents = New ObjectModel.Collection(Of String)(file.Parents)
							  })
					End Select

				Next

				pageToken = results.NextPageToken
			Loop While pageToken IsNot Nothing

			Return Task.FromResult(files)
		End Function

		''' <summary>
		''' Gets whether a certain folder exists based on the given name
		''' </summary>
		''' <param name="folderName">The name of the folder to find</param>
		''' <returns>Returns True if the folder exists, otherwise False</returns>
		Private Function FolderExists(folderName As String) As Task(Of Boolean)
			Try
				GetFolderID(folderName)
				Return Task.FromResult(True)
			Catch ex As Exceptions.FileException
				Return Task.FromResult(False)
			End Try
		End Function
	End Class
End Namespace