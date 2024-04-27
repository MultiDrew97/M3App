using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Drive.v3;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools.GTools
{
	/// <summary>
	/// The permission to apply to files/folders
	/// </summary>
    public struct Roles
    {
		/// <summary>
		/// Grants READ access permissions
		/// </summary>
        public static string Reader = "reader";
    }

	/// <summary>
	/// How the file/folders should be shared
	/// </summary>
    public struct ShareType
    {
		/// <summary>
		/// Anyone can access the files/folders
		/// </summary>
        public static string Anyone = "anyone";
    }

	/// <summary>
	/// The class that handles all Google Drive API calls
	/// </summary>
    public partial class GdriveTool : API, IDisposable, IGoogleService<Google.Apis.Drive.v3.Data.User>
    {

        private readonly string[] __scopes = new[] { DriveService.Scope.Drive };
        private DriveService __service;

        private readonly Google.Apis.Drive.v3.Data.Permission __defaultPermissions = new()
        {
            Role = Roles.Reader,
            Type = ShareType.Anyone
        };

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        protected Google.Apis.Drive.v3.Data.User UserAccount
        {
            get
            {
                return __service.About.Get().Execute().User;
            }
        }

        Google.Apis.Drive.v3.Data.User IGoogleService<Google.Apis.Drive.v3.Data.User>.UserAccount { get => UserAccount; }

		/// <summary>
		/// Authorizes the application to use their account in the API calls
		/// </summary>
		/// <param name="username"></param>
		/// <param name="ct"></param>
        public override void Authorize(string username, CancellationToken ct = default)
        {
            base.Authorize(username, ct);
            // Create Drive API service.
            LoadCreds("user", __scopes, ct == null ? CancellationToken.None : ct);

            __service = new DriveService(__init);

        }

        /// <summary>
		/// 		''' Closes the connection to Google Drive
		/// 		''' </summary>
        public void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void IDisposable.Dispose() => Close();

		/// <summary>
		/// 		''' Upload a new file to the drive
		/// 		''' </summary>
		/// 		''' <param name="file">The file to be uploaded. Contains folder information</param>
		/// 		''' <param name="uploadName">The desired name to name the file when uploaded</param>
		/// <param name="permissions"></param>
		/// 		''' <exception cref="Exceptions.UploadException"></exception>
		public Task UploadFile(File @file, string uploadName, Google.Apis.Drive.v3.Data.Permission permissions = null)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = uploadName, // If(uploadName, Utils.DefaultFileName(file.Name)),
                Parents = @file.Parents
            };

            FilesResource.CreateMediaUpload request;

            using (var reader = new System.IO.FileStream(@file.Name, System.IO.FileMode.Open))
            {
                request = __service.Files.Create(fileMetadata, reader, MimeKit.MimeTypes.GetMimeType(@file.Name));
                request.Fields = "id";
                request.Upload();
            }

            if (request.ResponseBody is null)
            {
                throw new Exceptions.UploadException("Something went wrong uploading the file.");
            }

            try
            {
                SetPermissions(request.ResponseBody.Id, permissions);
            }
            catch
            {
                throw new Exceptions.UploadException("File Uploaded Successfully. Failed to set permissions on file.");
            }

            return default;
        }

        /// <summary>
		/// 		''' Create a new folder based on information passed
		/// 		''' </summary>
		/// 		''' <param name="folderName">The name of the new folder</param>
		/// 		''' <param name="parents">The parent folders, if any, for the new folder to be in</param>
        public Task<object> CreateFolder(string folderName, IList<string> parents = null)
        {
            try
            {
                if (FolderExists(folderName).Result)
                {
                    throw new Exceptions.FolderException("Folder exists.");
                }

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = folderName,
                    MimeType = "application/vnd.google-apps.folder",
                    Parents = parents
                };

                var request = __service.Files.Create(fileMetadata);
                request.Fields = "id, parents";
                var result = request.Execute();
                Console.WriteLine(result.Parents);
                // TODO: Verify this is desired functionality
                return Task.FromResult((object)null);
            }
            catch (Exceptions.FolderException ex)
            {
                throw new Exceptions.FolderException($"Folder with the name {folderName} already exists.", ex);
            }
        }

        /// <summary>
		/// 		''' Gets the ID of the desired folder
		/// 		''' </summary>
		/// 		''' <param name="name">The name of the folder to find the ID of</param>
		/// 		''' <returns>The id of the desired the folder, if it exists</returns>
		/// 		''' <exception cref="Exceptions.FolderException"></exception>
        public Task<string> GetFolderID(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exceptions.FolderException("Folder name was empty");
            }

            string pageToken = null;
            var request = __service.Files.List();

            do
            {

                request.Q = "mimeType='application/vnd.google-apps.folder'";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name)";
                request.PageToken = pageToken;

                var result = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File folder in result.Files)
                {
                    if (folder.Name.Equals(name))
                    {
                        return Task.FromResult(folder.Id);
                    }
                }

                pageToken = result.NextPageToken;
            }
            while (pageToken is not null);

            throw new Exceptions.FolderException("Folder not found");
        }

		/// <summary>
		/// Sets the permissions for the specified file</summary>
		/// <param name="fileID">The ID of the file to set permissions for</param>
		/// <param name="permissions"></param>
		/// <returns></returns>
		private Task SetPermissions(string fileID, Google.Apis.Drive.v3.Data.Permission permissions = null)
        {
            // Dim request As PermissionsResource.CreateRequest = __service.Permissions.Create(__permissions, fileID)
            __service.Permissions.Create(permissions ?? __defaultPermissions, fileID).Execute();
            return default;
        }


        /// <summary>
		/// Gets the ID of the desired file if it exists
		/// </summary>
		/// <param name="fileName">The name of the desired file</param>
		/// <returns>The ID of the desired file</returns>
		/// <exception cref="Exceptions.FileException"></exception>
        public Task<string> GetFileID(string fileName)
        {
            var request = __service.Files.List();
            string pageToken = null;

            do
            {
                request.Q = "mimeType!='application/vnd.google-apps.folder'";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name)";
                request.PageToken = pageToken;

                var results = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
                {
                    if ((@file.Name ?? "") == (fileName ?? ""))
                    {
                        return Task.FromResult(@file.Id);
                    }
                }

                pageToken = results.NextPageToken;
            }
            while (pageToken is not null);

            throw new Exceptions.FileException($"File with file name {fileName} could not be found.");
        }

        /// <summary>
		/// 		''' Gets the desired file based on the provided information.
		/// 		''' </summary>
		/// 		''' <param name="fileName">The name of the file to get</param>
		/// 		''' <param name="folderName">The name of the folder that holds the desired file</param>
		/// 		''' <returns>All file information for the desired file</returns>
		/// 		''' <exception cref="Exceptions.FolderException"></exception>
		/// 		''' <exception cref="Exceptions.FileException"></exception>
        public Task<Google.Apis.Drive.v3.Data.File> GetFile(string fileName, string folderName = null)
        {
            var request = __service.Files.List();
            string pageToken = null;
            string folderID;

            try
            {
                folderID = GetFolderID(folderName).Result;
            }
            catch 
			{
                folderID = null;
            }

            do
            {
                request.Q = "mimeType!='application/vnd.google-apps.folder'";
                if (folderID is not null)
                {
                    request.Q += $" and '{folderID}' in parents";
                }

                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name, parents)";
                request.PageToken = pageToken;

                var results = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
                {
                    if (@file.Name.Equals(fileName))
                    {
                        return Task.FromResult(@file);
                    }
                }

                pageToken = results.NextPageToken;
            }
            while (pageToken is not null);

            throw new Exceptions.FileException($"File with name {fileName} could not be found.");
        }

        /// <summary>
		/// 		''' Gets all files in a given folder
		/// 		''' </summary>
		/// 		''' <param name="folderName">The name of the folder to pull the files from</param>
		/// 		''' <returns>A collection of all files contained in the given folder</returns>
		/// 		''' <exception cref="Exceptions.FolderException"></exception>
        public Task<FileCollection> GetFiles(string folderName)
        {
            var request = __service.Files.List();
            string pageToken = null;
            var files = new FileCollection();
            string folderID = GetFolderID(folderName).Result;

            do
            {
                request.Q = $"mimeType!='application/vnd.google-apps.folder' and '{folderID}' in parents";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name, mimeType, parents, fileExtension, fullFileExtension)";
                request.PageToken = pageToken;

                var results = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
                {
                    Console.WriteLine(@file.FileExtension);
                    Console.WriteLine(@file.FullFileExtension);
                    files.Add(new File(@file.Id)
                    {
                        Name = @file.Name,
                        FileType = @file.MimeType,
                        Parents = new System.Collections.ObjectModel.Collection<string>(@file.Parents)
                    });
                }

                pageToken = results.NextPageToken;
            }
            while (pageToken is not null);

            return Task.FromResult(files);
        }

        /// <summary>
		/// 		''' Gets all folders in the users drive folder
		/// 		''' </summary>
		/// 		''' <returns>A collection of folders</returns>
        public Task<FileCollection> GetFolders()
        {
            var folders = new FileCollection();
            string pageToken = null;
            var request = __service.Files.List();

            do
            {
                request.Q = "mimeType='application/vnd.google-apps.folder'";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name, parents, mimeType)";
                request.PageToken = pageToken;

                var result = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File folder in result.Files)
                    folders.Add(new Folder(folder.Id)
                    {
                        Name = folder.Name,
                        FileType = folder.MimeType,
                        Parents = folder.Parents is null ? null : new System.Collections.ObjectModel.Collection<string>(folder.Parents)
                    });

                pageToken = result.NextPageToken;
            }
            while (pageToken is not null);

            return Task.FromResult(folders);
        }

        /// <summary>
		/// 		''' Gets all folders and the children folders and files under them
		/// 		''' </summary>
		/// 		''' <returns>A collection of folders that contains their child files and folders</returns>
        public async Task<FileCollection> GetFoldersWithChildren()
        {
            var folders = await GetFolders();
            foreach (Folder folder in folders.Cast<Folder>())
                folder.Children.AddRange(await GetChildren(folder.Id));

            return folders;
        }

        /// <summary>
		/// 		''' Gets the children of a certain folder using its ID
		/// 		''' </summary>
		/// 		''' <param name="parentID">The ID of the folder to get the children from</param>
		/// 		''' <returns>A collection of files that are contained in the specified folder</returns>
        public Task<FileCollection> GetChildren(string parentID)
        {
            var request = __service.Files.List();
            string pageToken = null;
            var files = new FileCollection();

            do
            {
                request.Q = $"'{parentID}' in parents";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name, mimeType, parents)";
                request.PageToken = pageToken;

                var results = request.Execute();

                foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
                {
                    switch (@file.MimeType ?? "")
                    {
                        case "application/vnd.google-apps.folder":
                            {
                                files.Add(new Folder(@file.Id)
                                {
                                    Name = @file.Name,
                                    FileType = @file.MimeType,
                                    Parents = new System.Collections.ObjectModel.Collection<string>(@file.Parents)
                                });
                                break;
                            }

                        default:
                            {
                                files.Add(new File(@file.Id)
                                {
                                    Name = @file.Name,
                                    FileType = @file.MimeType,
                                    Parents = new System.Collections.ObjectModel.Collection<string>(@file.Parents)
                                });
                                break;
                            }
                    }

                }

                pageToken = results.NextPageToken;
            }
            while (pageToken is not null);

            return Task.FromResult(files);
        }

        /// <summary>
		/// 		''' Gets whether a certain folder exists based on the given name
		/// 		''' </summary>
		/// 		''' <param name="folderName">The name of the folder to find</param>
		/// 		''' <returns>Returns True if the folder exists, otherwise False</returns>
        private Task<bool> FolderExists(string folderName)
        {
            try
            {
                GetFolderID(folderName);
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
    }
}
