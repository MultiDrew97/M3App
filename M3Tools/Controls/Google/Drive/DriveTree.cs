using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DriveTree
	{
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
		public TreeNode SelectedNode => tv_DriveFiles.SelectedNode;

		/// <summary>
		/// The username of the user currently logged into the app
		/// </summary>
		[SettingsBindable(true)]
		public string Username
		{
			get => gdt_GDrive.Username;
			set => gdt_GDrive.Username = value;
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

			gdt_GDrive.Authorize();
		}

		/// <summary>
		/// Fills the table with the provided files
		/// </summary>
		/// <param name="treeNodes"></param>
		public void FillTable(FileCollection treeNodes)
		{
			// TODO: Figure out best way to utilize background worker for filling table instead of doing it all on main thread
			UseWaitCursor = true;
			tv_DriveFiles.Nodes[0].Nodes.Clear();
			tv_DriveFiles.Nodes[0].Nodes.AddRange(ParseTree(treeNodes));
			tv_DriveFiles.Nodes[0].Expand();
			UseWaitCursor = false;
		}

		/// <summary>
		/// 	Parses the File Collection into a TreeNode array with proper child node nesting.
		///	</summary>
		/// <param name="folders">The collections of files that hold the file heirarchy information.</param>
		/// <returns>An array of tree nodes, based on the file heirarchy in the file collection.</returns>
		private TreeNode[] ParseTree(FileCollection folders)
		{
			Collection<TreeNode> nodes = [];

			foreach (File curr in folders)
			{
				if (curr.GetType() != typeof(Folder) || ((Folder)curr).Children.Count == 0)
				{
					nodes.Add(new TreeNode(curr.Name) { Name = curr.Id });
					continue;
				}

				nodes.Add(new TreeNode(curr.Name, ParseTree(((Folder)curr).Children)) { Name = curr.Id });
			}

			return [.. nodes];
		}

		private TreeNode GetSelectedNode(TreeNodeCollection nodes)
		{
			if (nodes.Count > 0)
			{
				foreach (TreeNode node in nodes)
				{
					if (node.IsSelected || node.Checked)
					{
						return node;
					}

					TreeNode recNode = GetSelectedNode(node.Nodes);

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
			Collection<TreeNode> treeNodes = [];

			foreach (TreeNode node in nodes ?? tv_DriveFiles.Nodes)
			{
				if (node.Checked)
				{
					treeNodes.Add(node);
				}

				if (node.Nodes.Count > 0)
				{
					Collection<TreeNode> innerNodes = GetSelectedNodes(node.Nodes);
					foreach (TreeNode innerNode in innerNodes)
						treeNodes.Add(innerNode);
				}
			}

			return treeNodes;
		}

		/// <summary>
		/// Reloads the control
		/// </summary>
		public void Reload() => FillTable((WithChildren ? gdt_GDrive.GetFoldersWithChildren() : gdt_GDrive.GetFolders()).Result);

		private void NewFolder(object sender, EventArgs e)
		{
			using CreateFolderDialog newFolder = new();

			if (newFolder.ShowDialog() != DialogResult.OK)
				return;

			Reload();
		}
	}
}
