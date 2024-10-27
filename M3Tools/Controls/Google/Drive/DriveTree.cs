using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DriveTree
	{
		private readonly string _rootName = "tn_root";

		// TODO: Make sure that when a file is checked, as long as not all values are selected, the folder will have the intermediate check

		/// <summary>
		/// The nodes on the tree
		/// </summary>
		public TreeNodeCollection Nodes => tv_DriveFiles.Nodes;

		/// <summary>
		/// Whether to display checkboxes
		/// </summary>
		[DefaultValue(true)]
		public bool Checkboxes
		{
			get => tv_DriveFiles.CheckBoxes;
			set => tv_DriveFiles.CheckBoxes = value;
		}

		/// <summary>
		/// The currently selected node
		/// </summary>
		[Browsable(false)]
		public TreeNode SelectedNode => tv_DriveFiles.SelectedNode;

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

			cms_Tools.RefreshView += new EventHandler(Reload);
		}

		/// <summary>
		/// Parses the File Collection into a TreeNode array with proper child node nesting.
		///	</summary>
		/// <param name="folders">The collections of files that hold the file hierarchy information.</param>
		/// <returns>An array of tree nodes, based on the file hierarchy in the file collection.</returns>
		private TreeNode[] ParseTree(FileCollection folders)
		{
			// FIXME: Figure out how to not need recursion for this problem
			return folders.Select<File, TreeNode>(f =>
			{
				return true switch
				{
					var _ when f.GetType() == typeof(Folder) => new(f.Name, ParseTree(((Folder)f).Children)),
					_ => new(f.Name, [])
				};
			}).ToArray();
			/*Collection<TreeNode> nodes = [];

			foreach (File curr in folders)
			{
				if (curr.GetType() != typeof(Folder) || ((Folder)curr).Children.Count == 0)
				{
					nodes.Add(new TreeNode(curr.Name) { Name = curr.Id });
					continue;
				}

				nodes.Add(new TreeNode(curr.Name, children: ParseTree(((Folder)curr).Children).ToArray()) { Name = curr.Id });
			}

			return nodes.ToArray();*/
		}

		private TreeNode GetSelectedNode(TreeNodeCollection nodes)
		{
			TreeNode selectedNode = null;

			foreach (TreeNode node in nodes)
			{
				if (node.IsSelected || node.Checked)
				{
					return node;
				}

				selectedNode = GetSelectedNode(node.Nodes);

				if (selectedNode is null)
				{
					continue;
				}

				break;
			}

			return selectedNode;
		}

		/// <summary>
		/// Gets all selected nodes in the tree
		/// </summary>
		/// <param name="nodes"></param>
		/// <returns></returns>
		public Collection<TreeNode> GetSelectedNodes(TreeNodeCollection nodes = null)
		{
			Collection<TreeNode> selected = [];

			foreach (TreeNode node in nodes ?? tv_DriveFiles.Nodes)
			{
				if (node.Checked)
				{
					selected.Add(node);
				}

				if (node.Nodes.Count <= 0)
					continue;

				foreach (TreeNode child in GetSelectedNodes(node.Nodes))
					selected.Add(child);
			}

			return selected;
		}

		/// <summary>
		/// Reloads the control
		/// </summary>
		public async void Reload(object sender, EventArgs e)
		{
			try
			{
				UseWaitCursor = true;

				FileCollection folders = await (WithChildren ? gdt_GDrive.GetFoldersWithChildren() : gdt_GDrive.GetFolders());

				tv_DriveFiles.Nodes[_rootName].Nodes.Clear();
				tv_DriveFiles.Nodes[_rootName].Nodes.AddRange(ParseTree(folders));
				tv_DriveFiles.Nodes[_rootName].Expand();
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		private void NewFolder(object sender, EventArgs e)
		{
			using CreateFolderDialog newFolder = new();

			if (newFolder.ShowDialog() != DialogResult.OK)
				return;

			Reload(sender, e);
		}
	}
}
