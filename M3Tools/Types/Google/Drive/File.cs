using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SPPBC.M3Tools.Types.GTools
{
	/// <summary>
	/// A file that was found in the user's google drive
	/// </summary>
	public class File
	{
		/// <summary>
		/// The ID of the file
		/// </summary>
		public readonly string Id;

		/// <summary>
		/// The name of the file
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The type of the file
		/// </summary>
		public string FileType { get; set; }

		/// <summary>
		/// The list of folder IDs that the file is contained in
		/// </summary>
		public IList<string> Parents { get; set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public new string ToString => $"Name: {Name} ({Id}): FileType: {FileType} > Parent Count: {Parents.Count}";

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="id"></param>
		public File(string id) : this(id, "Temp File", "txt")
		{
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="filetype"></param>
		/// <param name="parents"></param>
		public File(string id, string name, string filetype = "", string[] parents = null)
		{
			Id = id;
			Name = name;
			FileType = filetype;
			Parents = parents ?? [];
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(File left, File right) => (left.Id ?? "") == (right.Id ?? ""); // AndAlso left.Name = right.Name AndAlso left.Parents.Equals(right.Parents) AndAlso left.FileType = right.FileType

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(File left, File right) => !(left == right);

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) => this == (obj as File) || base.Equals(obj);

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() => base.GetHashCode();
	}

	/// <summary>
	/// A folder found in the user's google drive. Since Files and Folders share the same functionality
	/// and are classified as files on their API, this inherits from File as well
	/// </summary>
	public class Folder : File
	{
		/// <summary>
		/// The list of children within the folder
		/// </summary>
		public FileCollection Children { get; set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="id"></param>
		public Folder(string id) : this(id, "Temp Folder")
		{
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="parents"></param>
		/// <param name="children"></param>
		public Folder(string id, string name, string[] parents = null, FileCollection children = null) : base(id, name, "folder", parents) => Children = children ?? [];
	}

	/// <summary>
	/// A collection of Google Drive files
	/// </summary>
	public class FileCollection : Collection<File>
	{
		/// <summary>
		/// Gets an item based on its ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public File this[string id]
		{
			get
			{
				try
				{
					return Items.Single(f => f.Id == id);
				}
				catch (InvalidOperationException)
				{
					return null;
				}
			}
		}

		// TODO: Clean this up later
		/// <summary>
		/// Whether a file is contained in the collection
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool Contains(string id)
		{
			try
			{
				return Items.Any(f => f.Id == id);
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="fileSearch"></param>
		/// <returns></returns>
		public new bool Contains(File fileSearch)
		{
			try
			{
				return Items.Any(f => f == fileSearch);
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Add a list of files to the collection
		/// </summary>
		/// <param name="files"></param>
		public void AddRange(IList<File> files)
		{
			foreach (File @file in files)
				Add(@file);
		}

		/// <summary>
		/// Removes files based on the provided predicate
		/// </summary>
		/// <param name="pred"></param>
		public void RemoveAll(Predicate<File> pred)
		{
			for (int i = 0; i < Count; i++)
			{
				if (!pred(Items[i]))
				{
					continue;
				}

				_ = Remove(Items[i]);
			}
		}

		/// <summary>
		/// Removes folders based on the provided predicate
		/// </summary>
		/// <param name="pred"></param>
		public void RemoveAll(Predicate<Folder> pred)
		{
			for (int i = Count - 1; i >= 0; i--)
			{
				if (!pred((Folder)Items[i]))
				{
					continue;
				}

				_ = Remove(Items[i]);
			}
		}

	}
}
