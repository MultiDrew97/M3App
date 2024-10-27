using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// TODO: Clean this up better
namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class UploadFileDialog
	{
		// Private ReadOnly __files As New GTools.Types.FileCollection
		private Google.Apis.Drive.v3.Data.Permission __permission;

		/// <summary>
		/// The list of files to be uploaded
		/// </summary>
		public IList Files // GTools.Types.FileCollection
=> bsFiles.List; // __files

		/// <summary>
		/// 
		/// </summary>
		public UploadFileDialog() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void Loading(object sender, EventArgs e) => dt_DriveHeirarchy.Reload(this, e);

		private void Upload(object sender, EventArgs e)
		{
			if (dt_DriveHeirarchy.SelectedNode == null)
			{
				_ = MessageBox.Show("You must select a parent folder.", "New Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (chk_DefaultPermissions.Checked)
			{
				__permission = null;
			}
			else
			{
				using PermissionsDialog permissions = new();

				if (permissions.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				Console.WriteLine(permissions.Permission.Role);
				Console.WriteLine(permissions.Permission.Type);
				__permission = permissions.Permission;
			}

			// bw_LoadFiles.RunWorkerAsync()
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void DialogLoad(object sender, DoWorkEventArgs e)
		{

		}

		private void DialogLoadFinished(object sender, RunWorkerCompletedEventArgs e) => dt_DriveHeirarchy.Reload(this, e);

		private void Finish()
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void LoadFiles(object sender, DoWorkEventArgs e)
		{
			string[] fileParts;
			string fileExt;
			Files.Clear();
			foreach (Types.GTools.File @file in bsFiles.List) // fu_FileUpload.Files
			{
				fileParts = @file.Name.Split('.');
				fileExt = fileParts[fileParts.Length - 1];
				_ = Files.Add(new Types.GTools.File("", @file.Name, fileExt));
			}
		}

		private void SetParents(object sender, RunWorkerCompletedEventArgs e)
		{
			string selectedParentId = dt_DriveHeirarchy.SelectedNode.Name;
			foreach (Types.GTools.File @file in Files)
			{
				if (@file.Parents is null)
				{
					@file.Parents = selectedParentId.Equals("main") ? null : new string[] { selectedParentId };
				}
				else if (selectedParentId.Equals("main"))
				{
					@file.Parents = null;
				}
				else
				{
					@file.Parents.Add(dt_DriveHeirarchy.SelectedNode.Name);
				}
			}

			bw_UploadFiles.RunWorkerAsync();
		}

		private async void UploadFiles(object sender, DoWorkEventArgs e)
		{
			string fileName;
			try
			{
				foreach (Types.GTools.File @file in Files)
				{
					fileName = Interaction.InputBox($"What would you like to call this file? (default: {Utils.DefaultFileName(@file.Name)})", "File Name", Utils.DefaultFileName(@file.Name));
					_ = await gdt_GDrive.UploadFile(@file, fileName, __permission);
				}

				e.Result = true;
				Finish();
			}
			catch (Exceptions.UploadException ex)
			{
				_ = MessageBox.Show(this, ex.Message, "New Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Result = false;
			}
		}

		private void UploadCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (Conversions.ToBoolean(e.Result))
			{
				Finish();
			}
		}
	}
}
