'Option Strict On

'Imports System.Collections.ObjectModel
'Imports System.ComponentModel
'Imports System.IO
'Imports System.Threading
'Imports Google.Apis.Auth.OAuth2
'Imports Google.Apis.Drive.v3
'Imports Google.Apis.Drive.v3.Data
'Imports Google.Apis.Services
'Imports Google.Apis.Util.Store

'Namespace GoogleAPI
'    Public Class DriveUploader
'        Inherits Service
'        Implements IDisposable

'        Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}
'        Private ReadOnly ApplicationName As String = "Media Ministry Manager"

'        Private Property Service As DriveService
'        Private Property Credential As UserCredential
'        Overrides ReadOnly Property Info As Object
'            Get
'                Dim getAbout = Service.About.Get()
'                getAbout.Fields = "user(displayName, emailAddress)"
'                Return getAbout.Execute().User
'            End Get
'        End Property

'        Sub New(Optional ct As CancellationToken = Nothing)
'            If IsNothing(ct) Then
'                ct = CancellationToken.None
'            End If

'            Dim credPath = "Drive Token"

'			Using stream As New MemoryStream(My.Resources.credentials)
'				Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", ct, New FileDataStore(credPath, True)).Result
'			End Using

'			'Create Drive API service.
'			Service = New DriveService(New BaseClientService.Initializer() With {
'                .HttpClientInitializer = Credential,
'                .ApplicationName = ApplicationName
'            })
'        End Sub

'        Sub Dispose() Implements IDisposable.Dispose
'            Dispose(True)
'            GC.SuppressFinalize(Me)
'        End Sub

'        Protected Overridable Sub Dispose(ByVal disposing As Boolean)

'        End Sub

'        Function Upload(fileLocation As String, parents As List(Of String), Optional uploadName As String = Nothing) As String
'            Dim fileName As String = CType(IIf(String.IsNullOrEmpty(uploadName), fileLocation.Split(CType("\\", Char()))(fileLocation.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy"), uploadName), String)
'            Dim fileMetadata As New Data.File() With {
'                .Name = fileName,
'                .Parents = parents
'            }

'            Dim request As FilesResource.CreateMediaUpload

'            Using reader As New FileStream(fileLocation, FileMode.Open)
'                request = Service.Files.Create(fileMetadata, reader, MimeKit.MimeTypes.GetMimeType(fileLocation))
'                request.Fields = "id"
'                request.Upload()
'            End Using

'            If (request.ResponseBody IsNot Nothing) Then
'                SetPermissions(request.ResponseBody.Id)
'                Return request.ResponseBody.Id
'            Else
'                Return Nothing
'            End If
'        End Function

'        Function CreateFolder(folderName As String) As String
'            Dim folderID = GetFolderID(folderName)

'            If (Not String.IsNullOrEmpty(folderID)) Then
'                Return folderID
'            Else
'                Console.WriteLine("No folder found with that name")
'                Dim fileMetadata As New Data.File With {
'                    .Name = folderName,
'                    .MimeType = "application/vnd.google-apps.folder"
'                }

'                Dim request = Service.Files.Create(fileMetadata)

'                request.Fields = "id"
'                Dim folder As Data.File = request.Execute()

'                Console.WriteLine("Folder ID: " + folder.Id)
'                Return folder.Id
'            End If
'        End Function

'        Function GetFolderID(name As String) As String
'            If name IsNot Nothing Then
'                Dim pageToken As String = Nothing
'                Dim request As FilesResource.ListRequest = Service.Files.List()
'                Do

'                    request.Q = "mimeType='application/vnd.google-apps.folder'"
'                    request.Spaces = "drive"
'                    request.Fields = "nextPageToken, files(id, name)"
'                    request.PageToken = pageToken

'                    Dim result As FileList = request.Execute()

'                    For Each folder As Data.File In result.Files
'                        If (folder.Name.Equals(name)) Then
'                            Return folder.Id
'                        End If
'                    Next
'                    pageToken = result.NextPageToken
'                Loop While (pageToken IsNot Nothing)
'            End If

'            Return Nothing
'        End Function

'        Function FindFile(fileName As String) As String
'            Dim pageToken As String = Nothing
'            Do

'                Service.Files.List().Q = "mimeType='text/plain'"
'                Service.Files.List().Spaces = "drive"
'                Service.Files.List().Fields = "nextPageToken, files(id, name)"
'                Service.Files.List().PageToken = pageToken

'                Dim result As FileList = Service.Files.List().Execute()

'                For Each files As Data.File In result.Files
'                    If (files.Name.Equals(fileName)) Then
'                        Return files.Id
'                    End If
'                Next
'                pageToken = result.NextPageToken
'            Loop While (pageToken IsNot Nothing)

'            Return Nothing
'        End Function

'        Sub SetPermissions(fileID As String)
'            Dim request As PermissionsResource.CreateRequest = Service.Permissions.Create(CreatePermission(), fileID)
'            request.Execute()
'        End Sub

'        Shared Function CreatePermission() As Permission
'            Return New Permission With {
'                .Role = "reader",
'                .Type = "anyone"
'            }
'        End Function

'        Public Function GetFileID(fileName As String) As String
'            Dim request As FilesResource.ListRequest = Service.Files.List()
'            Dim pageToken As String = Nothing

'            Do
'                request.Q = "mimeType!='application/vnd.google-apps.folder'"
'                request.Spaces = "drive"
'                request.Fields = "nextPageToken, files(id, name)"
'                request.PageToken = pageToken

'                Dim results As FileList = request.Execute()

'                For Each file As Data.File In results.Files
'                    If file.Name = fileName Then
'                        Return file.Id
'                    End If
'                Next
'            Loop While pageToken IsNot Nothing

'            Return Nothing
'        End Function

'        Friend Function GetFileInfo(fileName As String, Optional folder As String = Nothing) As Data.File
'            Dim request As FilesResource.ListRequest = Service.Files.List()
'            Dim pageToken As String = Nothing
'            Dim folderID As String = GetFolderID(folder)

'            Do
'                request.Q = "mimeType!='application/vnd.google-apps.folder'"
'                If folderID IsNot Nothing Then
'                    request.Q &= String.Format(" and '{0}' in parents", folderID)
'                End If

'                request.Spaces = "drive"
'                request.Fields = "nextPageToken, files(id, name, parents)"
'                request.PageToken = pageToken

'                Dim results As FileList = request.Execute()

'                For Each file As Data.File In results.Files
'                    If file.Name.Equals(fileName) Then
'                        Return file
'                    End If
'                Next
'            Loop While pageToken IsNot Nothing

'            Return Nothing
'        End Function

'        Public Function GetFiles(folderName As String) As Collection(Of String)
'            Dim request As FilesResource.ListRequest = Service.Files.List()
'            Dim pageToken As String = Nothing
'            Dim files As New Collection(Of String)
'            Dim folderID As String = GetFolderID(folderName)
'            Do
'                request.Q = String.Format("mimeType!='application/vnd.google-apps.folder' and '{0}' in parents", folderID)
'                request.Spaces = "drive"
'                request.Fields = "nextPageToken, files(name)"
'                request.PageToken = pageToken

'                Dim results As FileList = request.Execute()

'                For Each file As Data.File In results.Files
'                    files.Add(file.Name)
'                Next
'            Loop While pageToken IsNot Nothing

'            Return files
'        End Function

'        Public Function GetFolders() As Collection(Of String)
'            Dim folders As New Collection(Of String)
'            Dim pageToken As String = Nothing
'            Dim request As FilesResource.ListRequest = Service.Files.List()

'            Do

'                request.Q = "mimeType='application/vnd.google-apps.folder'"
'                request.Spaces = "drive"
'                request.Fields = "nextPageToken, files(id, name)"
'                request.PageToken = pageToken

'                Dim result As FileList = request.Execute()

'                For Each folder As Data.File In result.Files
'                    folders.Add(folder.Name)
'                Next

'                pageToken = result.NextPageToken
'            Loop While (pageToken IsNot Nothing)

'            'folders.Sort()

'            Return folders
'        End Function

'    End Class

'End Namespace