Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Services
Namespace GTools

	Public Structure Roles
		Shared Reader As String = "reader"
	End Structure

	Public Structure ShareType
		Shared Anyone As String = "anyone"
	End Structure

	Public Class GdriveTool
		Inherits API
		Implements IDisposable, IGoogleService(Of Data.User)

		Private ReadOnly __scopes As String() = {DriveService.Scope.Drive}
		Private __service As DriveService

		Private ReadOnly __defaultPermissions As New Data.Permission With {
			.Role = Roles.Reader,
			.Type = ShareType.Anyone
		}

		Protected ReadOnly Property UserAccount As Data.User Implements IGoogleService(Of Data.User).UserAccount
			Get
				Return __service.About.Get().Execute().User
			End Get
		End Property

		Overrides Sub Authorize(Optional ct As CancellationToken = Nothing)
			' Create Drive API service.
			LoadCreds("user", __scopes, If(IsNothing(ct), CancellationToken.None, ct))

			__service = New DriveService(__init)

			MyBase.Authorize(ct)
		End Sub

		''' <summary>
		''' Closes the connection to Google Drive
		''' </summary>
		Sub Close() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		''' <summary>
		''' Upload a new file to the drive
		''' </summary>
		''' <param name="file">The file to be uploaded. Contains folder information</param>
		''' <param name="uploadName">The desired name to name the file when uploaded</param>
		''' <exception cref="Exceptions.UploadException"></exception>
		Function UploadFile(file As Types.File, uploadName As String, Optional permissions As Data.Permission = Nothing) As Task
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
				' TODO: Verify this is desired functionality
				Return Task.FromResult(Of Object)(Nothing)
			Catch ex As Exceptions.FolderException
				Throw New Exceptions.FolderException($"Folder with the name {folderName} already exists.", ex)
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

			Throw New Exceptions.FileException($"File with file name {fileName} could not be found.")
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
					request.Q &= $" and '{folderID}' in parents"
				End If

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

			Throw New Exceptions.FileException($"File with name {fileName} could not be found.")
		End Function

		''' <summary>
		''' Gets all files in a given folder
		''' </summary>
		''' <param name="folderName">The name of the folder to pull the files from</param>
		''' <returns>A collection of all files contained in the given folder</returns>
		''' <exception cref="Exceptions.FolderException"></exception>
		Public Function GetFiles(folderName As String) As Task(Of Types.FileCollection)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing
			Dim files As New Types.FileCollection()
			Dim folderID As String = GetFolderID(folderName).Result

			Do
				request.Q = $"mimeType!='application/vnd.google-apps.folder' and '{folderID}' in parents"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, mimeType, parents, fileExtension, fullFileExtension)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					Console.WriteLine(file.FileExtension)
					Console.WriteLine(file.FullFileExtension)
					files.Add(New Types.File(file.Id) With {
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
		Public Function GetFolders() As Task(Of Types.FileCollection)
			Dim folders As New Types.FileCollection
			Dim pageToken As String = Nothing
			Dim request As FilesResource.ListRequest = __service.Files.List()

			Do
				request.Q = "mimeType='application/vnd.google-apps.folder'"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, parents, mimeType)"
				request.PageToken = pageToken

				Dim result As Data.FileList = request.Execute()

				For Each folder As Data.File In result.Files
					folders.Add(New Types.Folder(folder.Id) With {
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
		Async Function GetFoldersWithChildren() As Task(Of Types.FileCollection)
			Dim folders = Await GetFolders()
			For Each folder As Types.Folder In folders
				folder.Children.AddRange(Await GetChildren(folder.Id))
			Next

			Return folders
		End Function

		''' <summary>
		''' Gets the children of a certain folder using its ID
		''' </summary>
		''' <param name="parentID">The ID of the folder to get the children from</param>
		''' <returns>A collection of files that are contained in the specified folder</returns>
		Public Function GetChildren(parentID As String) As Task(Of Types.FileCollection)
			Dim request As FilesResource.ListRequest = __service.Files.List()
			Dim pageToken As String = Nothing
			Dim files As New Types.FileCollection

			Do
				request.Q = $"'{parentID}' in parents"
				request.Spaces = "drive"
				request.Fields = "nextPageToken, files(id, name, mimeType, parents)"
				request.PageToken = pageToken

				Dim results As Data.FileList = request.Execute()

				For Each file As Data.File In results.Files
					Select Case file.MimeType
						Case "application/vnd.google-apps.folder"
							files.Add(New Types.Folder(file.Id) With {
								.Name = file.Name,
								.FileType = file.MimeType,
								.Parents = New ObjectModel.Collection(Of String)(file.Parents)
							  })
						Case Else
							files.Add(New Types.File(file.Id) With {
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