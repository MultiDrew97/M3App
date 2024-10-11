using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
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

			_ = gdt_GDrive.Authorize();
		}

		/// <summary>
		/// Fills the table with the provided files
		/// </summary>
		/// <param name="treeNodes"></param>
		public async void FillTable(FileCollection treeNodes)
		{
			// TODO: Figure out best way to utilize background worker for filling table instead of doing it all on main thread
			tv_DriveFiles.Nodes[0].Nodes.Clear();
			tv_DriveFiles.Nodes[0].Nodes.AddRange(await ParseTree(treeNodes));
			tv_DriveFiles.Nodes[0].Expand();
		}

		/// <summary>
		/// 	Parses the File Collection into a TreeNode array with proper child node nesting.
		///	</summary>
		/// <param name="folders">The collections of files that hold the file hierarchy information.</param>
		/// <returns>An array of tree nodes, based on the file hierarchy in the file collection.</returns>
		private async Task<TreeNode[]> ParseTree(FileCollection folders)
		{
			Collection<TreeNode> nodes = [];

			foreach (File curr in folders)
			{
				if (curr.GetType() != typeof(Folder) || ((Folder)curr).Children.Count == 0)
				{
					nodes.Add(new TreeNode(curr.Name) { Name = curr.Id });
					continue;
				}

				nodes.Add(new TreeNode(curr.Name, await ParseTree(((Folder)curr).Children)) { Name = curr.Id });
			}

			return [.. nodes];
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
		public async void Reload()
		{
			UseWaitCursor = true;
			FillTable(await (WithChildren ? gdt_GDrive.GetFoldersWithChildren() : gdt_GDrive.GetFolders()));
			UseWaitCursor = false;
		}

		private void NewFolder(object sender, EventArgs e)
		{
			using CreateFolderDialog newFolder = new();

			if (newFolder.ShowDialog() != DialogResult.OK)
				return;

			Reload();
		}
	}
}
