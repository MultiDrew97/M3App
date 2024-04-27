using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// A control to upload files to Google Drive
	/// </summary>
    public partial class FileUpload
    {
		/// <summary>
		/// The list of files being uploaded
		/// </summary>
        public IList Files
        {
            get
            {
                return bsFiles.List;
            }
        }

		/// <summary>
		/// Whether mulitple files can be uploaded at once
		/// </summary>
        [DefaultValue(true)]
        public bool MultiSelect
        {
            get
            {
                return ofd_FileDialog.Multiselect;
            }
            set
            {
                ofd_FileDialog.Multiselect = value;
            }
        }

		/// <summary>
		/// The datasource to bind to the control
		/// </summary>
        public BindingSource DataSource
        {
            get
            {
                return bsFiles; // CType(dgv_Files.DataSource, BindingSource)
            }
            set
            {
                // dgv_Files.AutoGenerateColumns = False
                // dgv_Files.DataSource = value
                bsFiles = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public FileUpload()
        {
            InitializeComponent();
        }

        private void LoadFiles(object sender, CancelEventArgs e)
        {
            foreach (var @file in ofd_FileDialog.FileNames)
            {
                if (Duplicate(@file))
                {
                    continue;
                }
                bsFiles.Add(new Types.GTools.File("", @file, @file.Split('.')[1]));
            }
        }

        private bool Duplicate(string fileName)
        {
            // TODO: Find how to simplify
            foreach (Types.GTools.File @file in bsFiles.List)
            {
                if ((@file.Name ?? "") == (fileName ?? ""))
                {
                    return true;
                }
            }

            return false;
        }

        private void SelectFiles(object sender, ToolStripItemClickedEventArgs e)
        {
            UseWaitCursor = true;
            var res = ofd_FileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                UseWaitCursor = false;
            }
        }

        private void DataSourceUpdated(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                bsFiles.ResetBindings(false);
            }
        }
    }
}
