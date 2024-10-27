using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Drive.v3;

using SPPBC.M3Tools.API.GTools;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools.GTools
{
	/// <summary>
	/// The permission to apply
	/// </summary>
	public readonly struct Permission
	{
		/// <summary>
		/// 
		/// </summary>
		public static readonly string Owner = "owner";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Organizer = "organizer";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string FileOrganizer = "fileOrganizer";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Writer = "writer";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Commenter = "commenter";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Reader = "reader";
	}

	/// <summary>
	/// How the file/folders should be shared
	/// </summary>
	public readonly struct ShareScope
	{
		/// <summary>
		/// 
		/// </summary>
		public static readonly string User = "user";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Group = "group";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Domain = "domain";

		/// <summary>
		/// 
		/// </summary>
		public static readonly string Anyone = "anyone";
	}

	/// <summary>
	/// The class that handles all Google Drive API calls
	/// </summary>
	public partial class GDrive : GoogleBase, IGoogleService<Google.Apis.Drive.v3.Data.User>
	{

		private DriveService __service;

		private Google.Apis.Drive.v3.Data.Permission DEFAULT_PERMISSIONS => new()
		{
			Role = Permission.Reader,
			Type = ShareScope.Anyone
		};

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public Google.Apis.Drive.v3.Data.User GetUser() => __service?.About.Get().Execute().User ?? null;
		//Google.Apis.Drive.v3.Data.User IGoogleService<Google.Apis.Drive.v3.Data.User>.UserAccount => __service.About.Get().Execute().User;

		private string DriveID => __service.Files.Get("root").Execute().Id;

		/// <summary>
		/// 
		/// </summary>
		public GDrive() : base(GoogleUserType.DRIVE, [DriveService.Scope.Drive]) => InitializeComponent();

		/// <summary>
		/// Authorizes the application to use their account in the API calls
		/// </summary>
		/// <param name="ct"></param>
		protected override async Task Authorize(CancellationToken ct = default)
		{
			try
			{
				await base.Authorize(ct);

				if (ct.IsCancellationRequested)
					return;

				__service = new DriveService(__init);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				throw ex;
			}
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

			await Authorize(ct);
			System.IO.FileStream reader = new(@file.Name, System.IO.FileMode.Open);
			FilesResource.CreateMediaUpload request = __service.Files.Create(fileMetadata, reader, MimeKit.MimeTypes.GetMimeType(@file.Name));

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
				throw new Exceptions.UploadException($"Unable to upload file {@file.Name}");
			}

			try
			{
				SetPermissions(request.ResponseBody.Id, permissions, ct);
			}
			catch
			{
				throw new Exceptions.UploadException("Failed to set permissions on file");
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
			await Authorize(ct);

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
				throw new ArgumentNullException("Name");
			}

			await Authorize(ct);

			string pageToken = null;
			FilesResource.ListRequest request = __service.Files.List();

			request.Q = "trashed=false and mimeType='application/vnd.google-apps.folder'";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name)";

			do
			{
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
		private async void SetPermissions(string fileID, Google.Apis.Drive.v3.Data.Permission permissions = null, CancellationToken ct = default)
		{
			await Authorize(ct);

			_ = await __service.Permissions.Create(permissions ?? DEFAULT_PERMISSIONS, fileID).ExecuteAsync(ct);
		}

		/// <summary>
		/// Gets the ID of the desired file if it exists
		/// </summary>
		/// <param name="fileName">The name of the desired file</param>
		/// <param name="ct"></param>
		/// <returns>The ID of the desired file</returns>
		/// <exception cref="Exceptions.FileException"></exception>
		public async Task<string> GetFileID(string fileName, CancellationToken ct = default)
		{
			await Authorize(ct);

			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;

			request.Q = "trashed=false and mimeType!='application/vnd.google-apps.folder'";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name)";

			do
			{
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
			await Authorize(ct);

			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;

			request.Q = $"trashed=false and mimeType!='application/vnd.google-apps.folder'{(!string.IsNullOrWhiteSpace(folderName) ? $" and '{await GetFolderID(folderName)}' in parents" : "")}";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name, parents)";

			do
			{
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
			await Authorize(ct);

			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;
			FileCollection files = [];

			request.Q = $"trashed=false and mimeType!='application/vnd.google-apps.folder' and '{await GetFolderID(folderName, ct)}' in parents";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name, mimeType, parents, fileExtension, fullFileExtension)";

			do
			{
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
			await Authorize(ct);

			FileCollection folders = [];

			string pageToken = null;
			FilesResource.ListRequest request = __service.Files.List();

			request.Q = "trashed=false and mimeType='application/vnd.google-apps.folder'";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name, parents, mimeType)";

			do
			{
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

			return folders;
		}

		/// <summary>
		/// Gets all folders and the children folders and files under them
		/// </summary>
		/// <returns>A collection of folders that contains their child files and folders</returns>
		public async Task<FileCollection> GetFoldersWithChildren(CancellationToken ct = default)
		{
			await Authorize(ct);

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
			await Authorize(ct);

			FilesResource.ListRequest request = __service.Files.List();
			string pageToken = null;
			FileCollection files = [];

			request.Q = $"'{parentID}' in parents";
			request.Spaces = "drive";
			request.Fields = "nextPageToken, files(id, name, mimeType, parents)";

			do
			{
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
				return !string.IsNullOrEmpty(await GetFolderID(folderName, ct));
			}
			catch
			{
				return false;
			}
		}
	}
}