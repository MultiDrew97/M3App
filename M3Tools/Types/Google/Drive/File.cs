using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types.GTools
{
    public class File
    {
        public readonly string Id;
        public string Name { get; set; }
        public string FileType { get; set; }
        public IList<string> Parents { get; set; }

        public new string ToString
        {
            get
            {
                return $"Name: {Name} ({Id}): FileType: {FileType} > Parent Count: {Parents.Count}";
            }
        }

        public File(string id) : this(id, "Temp File", "txt")
        {
        }

        public File(string id, string name, string filetype, IList<string> parents = null)
        {
            Id = id;
            Name = name;
            FileType = filetype;
            Parents = parents ?? new Collection<string>();
        }

        public static bool operator ==(File left, File right)
        {
            return (left.Id ?? "") == (right.Id ?? ""); // AndAlso left.Name = right.Name AndAlso left.Parents.Equals(right.Parents) AndAlso left.FileType = right.FileType
        }

        public static bool operator !=(File left, File right)
        {
            return !(left == right);
        }

		public override bool Equals(object obj)
		{
			return this == obj as File || base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

    public class Folder : File
    {
        public FileCollection Children { get; set; }

        public Folder(string id) : this(id, "Temp Folder")
        {
        }

        public Folder(string id, string name, string[] parents = null, FileCollection children = null) : base(id, name, "folder", parents)
        {
            Children = children ?? new FileCollection();
        }
    }

    public class FileCollection : Collection<File>
    {

        public File this[string fileID]
        {
            get
            {
                return GetItem(fileID);
            }
        }

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

        public File GetItem(string id)
        {
            foreach (var @file in Items)
            {
                if ((@file.Id ?? "") == (id ?? ""))
                {
                    return @file;
                }
            }

            return null;
        }

        public void AddRange(IList<File> files)
        {
            foreach (var @file in files)
                Add(@file);
        }
    }
}
