using System;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// A field for selecting the location for a file
	/// </summary>
    public partial class FileLocationField
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public FileLocationField()
        {
            InitializeComponent();
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            ofdFileSelection.ShowDialog();
        }

        private void OfdFileSelection_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtFileLocation.Text = ofdFileSelection.SafeFileName;
        }

        private void FileLocationField_Load(object sender, EventArgs e)
        {
            txtFileLocation.Text = "";
            ofdFileSelection.Reset();
        }
    }
}
