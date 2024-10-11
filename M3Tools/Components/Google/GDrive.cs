using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google;
using Google.Apis.Drive.v3;

using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools.GTools
{
	/// <summary>
	/// The permission to apply
	/// </summary>
	public enum Permission
	{
		/// <summary>
		/// 
		/// </summary>
		Owner,

		/// <summary>
		/// 
		/// </summary>
		Organizer,

		/// <summary>
		/// 
		/// </summary>
		FileOrganizer,

		/// <summary>
		/// 
		/// </summary>
		Writer,

		/// <summary>
		/// 
		/// </summary>
		Commenter,

		/// <summary>
		/// 
		/// </summary>
		Reader,
	}

	/// <summary>
	/// How the file/folders should be shared
	/// </summary>
	public enum ShareScope
	{
		/// <summary>
		/// 
		/// </summary>
		User,

		/// <summary>
		/// 
		/// </summary>
		Group,

		/// <summary>
		/// 
		/// </summary>
		Domain,

		/// <summary>
		/// 
		/// </summary>
		Anyone,
	}

	/// <summary>
	/// The class that handles all Google Drive API calls
	/// </summary>
	public partial class GDrive : API.GTools.GoogleBase, IGoogleService<Google.Apis.Drive.v3.Data.User>
	{

		private DriveService __service;

		private Google.Apis.Drive.v3.Data.Permission DEFAULT_PERMISSIONS => new()
		{
			Role = Permission.Reader.ToString().ToLower(),
			Type = ShareScope.Anyone.ToString().ToLower()
		};

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		Google.Apis.Drive.v3.Data.User IGoogleService<Google.Apis.Drive.v3.Data.User>.UserAccount => __service.About.Get().Execute().User;

		private string DriveID => __service.Files.Get("root").Execute().Id;

		/// <summary>
		/// 
		/// </summary>
		public GDrive() : base("user", [DriveService.Scope.Drive]) => InitializeComponent();

		/// <summary>
		/// Authorizes the application to use their account in the API calls
		/// </summary>
		/// <param name="ct"></param>
		public override async Task<bool> Authorize(CancellationToken ct = default)
		{
			try
			{
				_ = await base.Authorize(ct);

				ct.ThrowIfCancellationRequested();

				__service = new DriveService(__init);

				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(__service);
				Debug.WriteLine(__init);
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
			}

			return false;
		}

		/// <summary>
		/// Upload a new file to the drive
		/// </summary>
		/// <param name="file">The file to be uploaded. Contains folder information</param>
		/// <param name="uploadName">The desired name to name the file when uploaded</param>
		/// <param name="permissions">The permissions to apply to the file</param>
		/// <param name="ct">The cancellation token to use</param>
		/// <exception cref="Exceptions.UploadException"></exception>
		public async Task<bool> UploadFile(File @file, string uploadName, Google.Apis.Drive.v3.Data.Permission permissions = null, CancellationToken ct = default)
		{
			Google.Apis.Drive.v3.Data.File fileMetadata = new()
			{
				Name = uploadName,
				Parents = @file.Parents
			};

			FilesResource.CreateMediaUpload request;

			using System.IO.FileStream reader = new(@file.Name, System.IO.FileMode.Open);

			request = __service.Files.Create(fileMetadata, reader, MimeKit.MimeTypes.GetMimeType(@file.Name));
			request.Fields = "id";
			Google.Apis.Upload.IUploadProgress status = await request.UploadAsync(ct);

			// TODO: Does this even do anything since it's async?
			while (status.Status is Google.Apis.Upload.UploadStatus.Uploading or Google.Apis.Upload.UploadStatus.Starting)
			{
				Console.WriteLine("Uploading file...", status);
				Utils.Wait();
			}

			if (request.ResponseBody is null)
			{
				throw new Exceptions.UploadException("Something went wrong uploading the file.");
			}

			try
			{
				SetPermissions(request.ResponseBody.Id, permissions, ct);
			}
			catch
			{
				throw new Exceptions.UploadException("File Uploaded Successfully. Failed to set permissions on file.");
			}

			return true;
		}

		/// <summary>
		/// Create a new folder based on information passed
		/// </summary>
		/// <param name="folderName">The name of the new folder</param>
		/// <param name="parents">The parent folders, if any, for the new folder to be in</param>
		/// <param name="ct"></param>
		/// <exception cref="Exceptions.FolderExistsException"></exception>
		public async Task<bool> CreateFolder(string folderName, IList<string> parents = null, CancellationToken ct = default)
		{
			if (await FolderExists(folderName))
			{
				throw new Exceptions.FolderExistsException();
			}

			Google.Apis.Drive.v3.Data.File fileMetadata = new()
			{
				Name = folderName,
				MimeType = "application/vnd.google-apps.folder",
				Parents = parents
			};

			// TODO: Verify this is desired functionality
			FilesResource.CreateRequest request = __service.Files.Create(fileMetadata);
			request.Fields = "id, parents";
			Google.Apis.Drive.v3.Data.File result = await request.ExecuteAsync(ct);
			Console.WriteLine(result.Parents);
			return true;
		}

		/// <summary>
		/// Gets the ID of the desired folder
		/// </summary>
		/// <param name="name">The name of the folder to find the ID of</param>
		/// <param name="ct"></param>
		/// <returns>The id of the desired the folder, if it exists</returns>
		/// <exception cref="Exceptions.FolderException"></exception>
		public async Task<string> GetFolderID(string name, CancellationToken ct = default)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new Exceptions.FolderException("Folder name was empty");
			}

			string pageToken = null;
			FilesResource.ListRequest request = __service.Files.List();

			do
			{

				request.Q = "mimeType='application/vnd.google-apps.folder'";
				request.Spaces = "drive";
				request.Fields = "nextPageToken, files(id, name)";
				request.PageToken = pageToken;

				Google.Apis.Drive.v3.Data.FileList result = await request.ExecuteAsync(ct);

				foreach (Google.Apis.Drive.v3.Data.File folder in result.Files)
				{
					if (folder.Name.Equals(name))
					{
						return folder.Id;
					}
				}

				pageToken = result.NextPageToken;
			}
			while (pageToken is not null);

			throw new Exceptions.FolderNotFoundException();
		}

		/// <summary>
		/// Sets the permissions for the specified file</summary>
		/// <param name="fileID">The ID of the file to set permissions for</param>
		/// <param name="permissions"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		private async void SetPermissions(string fileID, Google.Apis.Drive.v3.Data.Permission permissions = null, CancellationToken ct = default) =>
			// Dim request As PermissionsResource.CreateRequest = __service.Permissions.Create(__permissions, fileID)
			_ = await __service.Permissions.Create(permissions ?? DEFAULT_PERMISSIONS, fileID).ExecuteAsync(ct);

		/// <summary>
		/// Gets the ID of the desired file if it exists
		/// </summary>
		/// <param name="fileName">The name of the desired file</param>
		/// <param name="ct"></param>
		/// <returns>The ID of the desired file</returns>
		/// <exception cref="Exceptions.FileException"></exception>
		public async Task<string> GetFileID(string fileName, CancellationToken ct = default)
		{
			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;

			do
			{
				request.Q = "mimeType!='application/vnd.google-apps.folder'";
				request.Spaces = "drive";
				request.Fields = "nextPageToken, files(id, name)";
				request.PageToken = pageToken;

				Google.Apis.Drive.v3.Data.FileList results = await request.ExecuteAsync(ct);

				foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
				{
					if (@file.Name != fileName)
					{
						continue;
					}

					return @file.Id;
				}

				pageToken = results.NextPageToken;
			}
			while (pageToken is not null);

			throw new Exceptions.FileNotFoundException();
		}

		/// <summary>
		/// Gets the desired file based on the provided information.
		/// </summary>
		/// <param name="fileName">The name of the file to get</param>
		/// <param name="folderName">The name of the folder that holds the desired file</param>
		/// <param name="ct"></param>
		/// <returns>All file information for the desired file</returns>
		/// <exception cref="Exceptions.FolderException"></exception>
		/// <exception cref="Exceptions.FileException"></exception>
		public async Task<Google.Apis.Drive.v3.Data.File> GetFile(string fileName, string folderName = null, CancellationToken ct = default)
		{
			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;
			//string folderID;
			string query = "mimeType!='application/vnd.google-apps.folder'";

			try
			{
				//string folderID = await GetFolderID(folderName);
				query = $"{query} and '{await GetFolderID(folderName)}' in parents";
			}
			catch
			{

			}

			do
			{
				request.Q = query;
				request.Spaces = "drive";
				request.Fields = "nextPageToken, files(id, name, parents)";
				request.PageToken = pageToken;

				Google.Apis.Drive.v3.Data.FileList results = await request.ExecuteAsync(ct);

				foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
				{
					if (!@file.Name.Equals(fileName))
					{
						continue;
					}

					return @file;
				}

				pageToken = results.NextPageToken;
			}
			while (pageToken is not null);

			throw new Exceptions.FileNotFoundException();
		}

		/// <summary>
		/// Gets all files in a given folder
		/// </summary>
		/// <param name="folderName">The name of the folder to pull the files from</param>
		/// <param name="ct"></param>
		/// <returns>A collection of all files contained in the given folder</returns>
		/// <exception cref="Exceptions.FolderException"></exception>
		public async Task<FileCollection> GetFiles(string folderName, CancellationToken ct = default)
		{
			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;
			FileCollection files = [];
			string folderID = await GetFolderID(folderName, ct);

			do
			{
				request.Q = $"mimeType!='application/vnd.google-apps.folder' and '{folderID}' in parents";
				request.Spaces = "drive";
				request.Fields = "nextPageToken, files(id, name, mimeType, parents, fileExtension, fullFileExtension)";
				request.PageToken = pageToken;

				Google.Apis.Drive.v3.Data.FileList results = await request.ExecuteAsync(ct);

				foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
				{
					Console.WriteLine(@file.FileExtension);
					Console.WriteLine(@file.FullFileExtension);
					files.Add(new File(@file.Id)
					{
						Name = @file.Name,
						FileType = @file.MimeType,
						Parents = @file.Parents as string[]
					});
				}

				pageToken = results.NextPageToken;
			}
			while (pageToken is not null);

			return files;
		}

		/// <summary>
		/// Gets all folders in the users drive folder
		/// </summary>
		/// <returns>A collection of folders</returns>
		public async Task<FileCollection> GetFolders(CancellationToken ct = default)
		{
			FileCollection folders = [];
			try
			{

				string pageToken = null;
				FilesResource.ListRequest request = __service.Files.List();

				do
				{
					request.Q = "mimeType='application/vnd.google-apps.folder'";
					request.Spaces = "drive";
					request.Fields = "nextPageToken, files(id, name, parents, mimeType)";
					request.PageToken = pageToken;

					Google.Apis.Drive.v3.Data.FileList result = await request.ExecuteAsync(ct);

					foreach (Google.Apis.Drive.v3.Data.File folder in result.Files)
					{
						folders.Add(new Folder(folder.Id)
						{
							Name = folder.Name,
							FileType = folder.MimeType,
							Parents = folder.Parents is not null ? new List<string>(folder.Parents) : null
						});
					}

					pageToken = result.NextPageToken;
				}
				while (pageToken is not null);

			}
			catch (GoogleApiException ex)
			{
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
				Console.Error.WriteLine("Unable to retrieve files from Google Drive");
			}

			return folders;
		}

		/// <summary>
		/// Gets all folders and the children folders and files under them
		/// </summary>
		/// <returns>A collection of folders that contains their child files and folders</returns>
		public async Task<FileCollection> GetFoldersWithChildren(CancellationToken ct = default)
		{
			FileCollection folders = await GetFolders(ct);
			foreach (Folder folder in folders.Cast<Folder>())
				folder.Children.AddRange(await GetChildren(folder.Id, ct));

			folders.RemoveAll((Folder folder) =>
			{
				if (folder.Parents is null || folder.Parents.Count < 1)
					return false;

				foreach (string parentID in folder.Parents)
				{
					if (parentID == DriveID)
						return false;
					Folder parent = (Folder)folders[parentID];

					if (parent is null)
						continue;
					if (parent.Children[folder.Id] is null)
					{
						parent.Children.Add(folder);
						continue;
					}

					((Folder)parent.Children[folder.Id]).Children.AddRange(folder.Children);
				}

				return true;
			});

			return folders;
		}

		/// <summary>
		/// Gets the children of a certain folder using its ID
		/// </summary>
		/// <param name="parentID">The ID of the folder to get the children from</param>
		/// <param name="ct"></param>
		/// <returns>A collection of files that are contained in the specified folder</returns>
		public async Task<FileCollection> GetChildren(string parentID, CancellationToken ct = default)
		{
			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;
			FileCollection files = [];

			do
			{
				request.Q = $"'{parentID}' in parents";
				request.Spaces = "drive";
				request.Fields = "nextPageToken, files(id, name, mimeType, parents)";
				request.PageToken = pageToken;

				Google.Apis.Drive.v3.Data.FileList results = await request.ExecuteAsync(ct);

				foreach (Google.Apis.Drive.v3.Data.File @file in results.Files)
				{
					switch (@file.MimeType)
					{
						case "application/vnd.google-apps.folder":
						{
							files.Add(new Folder(@file.Id)
							{
								Name = @file.Name,
								FileType = @file.MimeType,
								Parents = @file.Parents as string[]
							});
							break;
						}

						default:
						{
							files.Add(new File(@file.Id)
							{
								Name = @file.Name,
								FileType = @file.MimeType,
								Parents = @file.Parents as string[]
							});
							break;
						}
					}

				}

				pageToken = results.NextPageToken;
			}
			while (pageToken is not null);

			return files;
		}

		/// <summary>
		/// Gets whether a certain folder exists based on the given name
		/// </summary>
		/// <param name="folderName">The name of the folder to find</param>
		/// <param name="ct"></param>
		/// <returns>Returns True if the folder exists, otherwise False</returns>
		private async Task<bool> FolderExists(string folderName, CancellationToken ct = default)
		{
			try
			{
				_ = await GetFolderID(folderName, ct);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
