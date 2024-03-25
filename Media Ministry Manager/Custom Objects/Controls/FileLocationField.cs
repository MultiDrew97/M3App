using System;

namespace MediaMinistry
{
    public partial class FileLocationField
    {
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