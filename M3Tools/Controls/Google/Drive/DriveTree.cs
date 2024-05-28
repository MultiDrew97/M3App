using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools
{
	// FIXME: Resolve node nesting bug with not removing the node from the list after nesting it
    public partial class DriveTree
    {
		// TODO: Make sure that when a file is checked, as long as not all values are selected, the folder will have the intermediate check
        // Private __username As String

		/// <summary>
		/// The nodes on the tree
		/// </summary>
        public TreeNodeCollection Nodes
        {
            get
            {
                return tv_DriveFiles.Nodes;
            }
        }

		/// <summary>
		/// Whether to display checkboxes
		/// </summary>
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

		/// <summary>
		/// The currently selected node
		/// </summary>
        public TreeNode SelectedNode
        {
            get
            {
                return tv_DriveFiles.SelectedNode;
            }
        }

		/// <summary>
		/// The username of the user currently logged into the app
		/// </summary>
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

		/// <summary>
		/// Whether the tree should include the children of the folders
		/// </summary>
        [DefaultValue(true)]
        [Description("Whether the tree should include the children of folders")]
        public bool WithChildren { get; set; } = true;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public DriveTree()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Fills the table with the provided files
		/// </summary>
		/// <param name="treeNodes"></param>
        public void FillTable(FileCollection treeNodes)
        {
            UseWaitCursor = true;
            tv_DriveFiles.Nodes[0].Nodes.Clear();
            tv_DriveFiles.Nodes[0].Nodes.AddRange(ParseNodes(treeNodes));
            tv_DriveFiles.Nodes[0].Expand();
            UseWaitCursor = false;
        }

        /// <summary>
		/// Takes the file collection and filters out duplicates and places sub files and folders under their proper parent folders.
		/// </summary>
		/// <param name="folders">The collection of files and folders to filter.</param>
		/// <returns>The filtered file collection as a tree node array.</returns>
        private TreeNode[] ParseNodes(FileCollection folders)
        {
			folders.RemoveAll((Folder folder) =>
			{
				if (folder.Parents is null || folder.Parents.Count < 1) return false;

				foreach (string parentID in folder.Parents)
				{
					Folder parent = (Folder)folders[parentID];
					if (parent is null) continue;
					if (parent.Children[folder.Id] is null)
					{
						parent.Children.Add(folder);
						continue;
					}

					((Folder)parent.Children[folder.Id]).Children.AddRange(folder.Children);
				}

				return true;
			});

			/*foreach (Folder folder in folders.Cast<Folder>())
			{
				if (folder.Parents is null || folder.Parents.Count < 1)
				{
					// Instance has no parent, thus is standalone
					continue;
				}

				foreach (string parentID in folder.Parents)
				{
					if (((Folder)folders[parentID]).Children[folder.Id] is null)
					{
						((Folder)folders[parentID]).Children.Add(folder);
						continue;
					}

					((Folder)(((Folder)folders[parentID]).Children[folder.Id])).Children.AddRange(folder.Children);
				}

				*//*foreach (Folder parent in folder.Parents.Cast<Folder>())
				{
					if (parent.Children[folder.Id] is null)
					{
						// folder not added to child list yet
						parent.Children.Add(folder);
						continue;
					}
					
					((Folder)parent.Children[folder.Id]).Children.AddRange(folder.Children);
				}*//*

				folders.Remove(folder);
			}*/
            /*do
            {
                if (folders[i].Parents is null)
                {
					// Current folder has no parents to nest under
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
            while (i < folders.Count);*/

            return ParseTree(folders);
        }

        /// <summary>
	/// 	Parses the File Collection into a TreeNode array with proper child node nesting.
	/// 	</summary>
	/// 	<param name="folders">The collections of files that hold the file heirarchy information.</param>
	/// 	<returns>An array of tree nodes, based on the file heirarchy in the file collection.</returns>
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

		/// <summary>
		/// Gets all selected nodes in the tree
		/// </summary>
		/// <param name="nodes"></param>
		/// <returns></returns>
        public Collection<TreeNode> GetSelectedNodes(TreeNodeCollection nodes = null)
        {
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

		/// <summary>
		/// Reloads the control
		/// </summary>
        public void Reload()
        {
            UseWaitCursor = true;
            FillTable((WithChildren ? gdt_GDrive.GetFoldersWithChildren() : gdt_GDrive.GetFolders()).Result);
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

		/// <summary>
		/// When the control is loaded
		/// </summary>
		/// <param name="username"></param>
        public new void Load(string username)
        {
            gdt_GDrive.Authorize(username);
        }
    }
}
