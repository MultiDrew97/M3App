using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools
{

    public partial class DriveTree
    {
        // Private __username As String

        public TreeNodeCollection Nodes
        {
            get
            {
                return tv_DriveFiles.Nodes;
            }
        }

        [DefaultValue(true)]
        public bool Checkboxes
        {
            get
            {
                return tv_DriveFiles.CheckBoxes;
            }
            set
            {
                tv_DriveFiles.CheckBoxes = value;
            }
        }

        public TreeNode SelectedNode
        {
            get
            {
                return tv_DriveFiles.SelectedNode;
            }
        }

        [SettingsBindable(true)]
        public string Username
        {
            get
            {
                return gdt_GDrive.Username;
            }
            set
            {
                gdt_GDrive.Username = value;
            }
        }

        [DefaultValue(true)]
        [Description("Whether the tree should include the children of folders")]
        public bool WithChildren { get; set; } = true;

        public DriveTree()
        {
            InitializeComponent();
        }

        public void FillTable(FileCollection treeNodes)
        {
            UseWaitCursor = true;
            tv_DriveFiles.Nodes[0].Nodes.Clear();
            tv_DriveFiles.Nodes[0].Nodes.AddRange(ParseNodes(treeNodes));
            tv_DriveFiles.Nodes[0].Expand();
            UseWaitCursor = false;
        }

        /// <summary>
	/// 	''' Takes the file collection and filters out duplicates and places sub files and folders under their proper parent folders.
	/// 	''' </summary>
	/// 	''' <param name="folders">The collection of files and folders to filter.</param>
	/// 	''' <returns>The filtered file collection as a tree node array.</returns>
        private TreeNode[] ParseNodes(FileCollection folders)
        {
            int i = 0;

            // TODO: Convert to for each?
            do
            {
                if (folders[i].Parents is null)
                {
                    i += 1;
                    continue;
                }

                if (folders.Contains(folders[i].Parents[0]))
                {
                    Folder parentFolder = (Folder)folders[folders[i].Parents[0]];

                    if (parentFolder.Children.Count == 0)
                    {
                        parentFolder.Children.Add(folders[i]);
                    }
                    else
                    {
                        Folder folderUnderParent = (Folder)parentFolder.Children[folders[i].Id];

                        if (folderUnderParent is null)
                        {
                            parentFolder.Children.Add(folders[i]);
                        }
                        else
                        {
                            folderUnderParent.Children.AddRange(((Folder)folders[i]).Children);
                        }

                    }


                    folders.Remove(folders[i]);
                }
                else
                {
                    i += 1;
                }
            }
            while (i < folders.Count);

            return ParseTree(folders);
        }

        /// <summary>
	/// 	''' Parses the File Collection into a TreeNode array with proper child node nesting.
	/// 	''' </summary>
	/// 	''' <param name="folders">The collections of files that hold the file heirarchy information.</param>
	/// 	''' <returns>An array of tree nodes, based on the file heirarchy in the file collection.</returns>
        private TreeNode[] ParseTree(FileCollection folders)
        {
            var nodes = new Collection<TreeNode>();

            foreach (var folder in folders)
            {
                if (folder.GetType() == typeof(Folder))
                {
                    if (((Folder)folder).Children.Count == 0)
                    {
                        // Add This folder to the collection as is
                        nodes.Add(new TreeNode(folder.Name) { Name = folder.Id });
                    }
                    else
                    {
                        nodes.Add(new TreeNode(folder.Name, ParseTree(((Folder)folder).Children)) { Name = folder.Id });
                    }
                }
                else
                {
                    nodes.Add(new TreeNode(folder.Name) { Name = folder.Id });
                }
            }

            return nodes.ToArray();
        }

        private TreeNode GetSelectedNode(TreeNodeCollection nodes)
        {
            if (nodes.Count > 0)
            {
                foreach (TreeNode node in nodes)
                {
                    if (node.IsSelected | node.Checked)
                    {
                        return node;
                    }

                    var recNode = GetSelectedNode(node.Nodes);

                    if (recNode is not null)
                    {
                        return recNode;
                    }
                }
            }

            return null;
        }

        public Collection<TreeNode> GetSelectedNodes(TreeNodeCollection nodes = null)
        {
            // TODO: When checking a folder, check child files and folders as well
            var treeNodes = new Collection<TreeNode>();

            foreach (TreeNode node in nodes ?? tv_DriveFiles.Nodes)
            {
                if (node.Checked)
                {
                    treeNodes.Add(node);
                }

                if (node.Nodes.Count > 0)
                {
                    var innerNodes = GetSelectedNodes(node.Nodes);
                    foreach (var innerNode in innerNodes)
                        treeNodes.Add(innerNode);
                }
            }

            return treeNodes;
        }

        private async void RefreshTree()
        {
            if (WithChildren)
            {
                FillTable(await gdt_GDrive.GetFoldersWithChildren());
            }
            else
            {
                FillTable(await gdt_GDrive.GetFolders());
            }
        }

        public void Reload()
        {
            UseWaitCursor = true;
            RefreshTree();
            UseWaitCursor = false;
        }

        private void NewFolder(object sender, EventArgs e)
        {
			using var newFolder = new CreateFolderDialog();

			if (newFolder.ShowDialog() == DialogResult.OK)
			{
				Reload();
			}
		}

        public new void Load(string username)
        {
            gdt_GDrive.Authorize(username);
        }
    }
}
