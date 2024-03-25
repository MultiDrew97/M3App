using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using SPPBC.M3Tools.Exceptions;

namespace MediaMinistry
{

    public partial class CreateFolderDialog
    {
        private string __folderName;
        private readonly Collection<string> __parents = new Collection<string>();
        public string FolderName
        {
            get
            {
                return __folderName;
            }
            set
            {
                __folderName = value;
            }
        }

        public IList<string> Parents
        {
            get
            {
                return __parents.Count == 0 ? null : __parents;
            }
        }

        public CreateFolderDialog()
        {
            InitializeComponent();
        }

        // Public Property Username As String
        // Get
        // Return gdt_GDrive.Username
        // End Get
        // Set(value As String)
        // gdt_GDrive.Username = value
        // dt_DriveHeirarchy.Username = value
        // End Set
        // End Property

        private void Create(object sender, EventArgs e)
        {
            bw_GatherInfo.RunWorkerAsync(dt_DriveHeirarchy.SelectedNode);
            try
            {
                gdt_GDrive.CreateFolder(FolderName, Parents);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FolderException ex)
            {
                MessageBox.Show(this, ex.Message, "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FolderNameTextChanged(object sender, EventArgs e)
        {
            FolderName = ip_FolderName.Text;
        }

        private void LoadDialog(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            gdt_GDrive.Authorize(My.MySettingsProperty.Settings.Username);

            dt_DriveHeirarchy.Reload();

            UseWaitCursor = false;
        }

        private void GatherInfo(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            __parents.Clear();
            TreeNode nodeSelected = (TreeNode)e.Argument;

            if (nodeSelected is not null)
            {
                // A node is selected
                if (!nodeSelected.Name.ToLower().Equals("main"))
                {
                    // Selected node was not the My Drive Folder node
                    __parents.Add(nodeSelected.Name);
                }
            }
            else
            {
                MessageBox.Show("You must select a folder for the new one to go in.", "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}