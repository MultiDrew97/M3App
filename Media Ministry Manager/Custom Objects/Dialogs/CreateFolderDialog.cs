using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SPPBC.M3Tools.Exceptions;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CreateFolderDialog
	{
		/// <summary>
		/// The name of the folder to create
		/// </summary>
		public string FolderName { get; private set; }

		/// <summary>
		/// The list of parents for the folder being created
		/// </summary>
		public IList<string> Parents { get; private set; } = [];

		/// <summary>
		/// 
		/// </summary>
		public CreateFolderDialog() => InitializeComponent();

		private void Create(object sender, EventArgs e)
		{
			bw_GatherInfo.RunWorkerAsync(dt_DriveHeirarchy.SelectedNode);
			try
			{
				_ = gdt_GDrive.CreateFolder(FolderName, Parents);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (FolderException ex)
			{
				_ = MessageBox.Show(ex.Message, "New Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FolderNameTextChanged(object sender, EventArgs e) => FolderName = ip_FolderName.Text;

		private void LoadDialog(object sender, EventArgs e)
		{
			UseWaitCursor = true;

			gdt_GDrive.Authorize();

			dt_DriveHeirarchy.Reload();

			UseWaitCursor = false;
		}

		private void GatherInfo(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Parents.Clear();
			TreeNode nodeSelected = (TreeNode)e.Argument;

			if (nodeSelected is not null)
			{
				// A node is selected
				if (!nodeSelected.Name.ToLower().Equals("main"))
				{
					// Selected node was not the My Drive Folder node
					Parents.Add(nodeSelected.Name);
				}
			}
			else
			{
				_ = MessageBox.Show("You must select a folder for the new one to go in.", "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
