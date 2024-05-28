using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        public new string ToString
        {
            get
            {
                return $"Name: {Name} ({Id}): FileType: {FileType} > Parent Count: {Parents.Count}";
            }
        }

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
        public File(string id, string name, string filetype, string[] parents = null)
        {
            Id = id;
            Name = name;
            FileType = filetype;
			Parents = parents ?? new string[] { };
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
        public static bool operator ==(File left, File right)
        {
            return (left.Id ?? "") == (right.Id ?? ""); // AndAlso left.Name = right.Name AndAlso left.Parents.Equals(right.Parents) AndAlso left.FileType = right.FileType
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
        public static bool operator !=(File left, File right)
        {
            return !(left == right);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return this == obj as File || base.Equals(obj);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
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
        public Folder(string id, string name, string[] parents = null, FileCollection children = null) : base(id, name, "folder", parents)
        {
            Children = children ?? new FileCollection();
        }
    }

	/// <summary>
	/// A collection of Google Drive files
	/// </summary>
	public class FileCollection : Collection<File>
	{
		/// <summary>
		/// Gets an item based on its ID
		/// </summary>
		/// <param name="fileID"></param>
		/// <returns></returns>
		public File this[string fileID]
		{
			get
			{
				foreach (var @file in Items)
				{
					if (@file.Id == fileID)
					{
						return @file;
					}
				}

				return null;
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
			foreach (var @file in Items)
			{
				if ((@file.Id ?? "") == (id ?? ""))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="fileSearch"></param>
		/// <returns></returns>
		public new bool Contains(File fileSearch)
		{
			foreach (var @file in Items)
			{
				if (@file == fileSearch)
				{
					return true;
				}
			}

			return false;
		}


		/// <summary>
		/// Add a list of files to the collection
		/// </summary>
		/// <param name="files"></param>
		public void AddRange(IList<File> files)
		{
			foreach (var @file in files)
				Add(@file);
		}

		/// <summary>
		/// Removes files based on the provided predecate
		/// </summary>
		/// <param name="pred"></param>
		public void RemoveAll(Predicate<File> pred) 
		{
			for (var i = 0; i < this.Count; i++)
			{
				if (!pred(this.Items[i]))
				{
					continue;
				}

				this.Remove(this.Items[i]);
			}
		}

		/// <summary>
		/// Removes folders based on the provided predicate
		/// </summary>
		/// <param name="pred"></param>
		public void RemoveAll(Predicate<Folder> pred)
		{
			// FIXME: Figure out why the entries are being removed erroniously
			for (var i = 0; i < this.Count; i++)
			{
				if (!pred((Folder)this.Items[i]))
				{
					continue;
				}

				this.Remove(this.Items[i]);
			}
		}

	}
}
