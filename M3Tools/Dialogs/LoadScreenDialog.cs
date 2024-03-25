using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class LoadScreenDialog
    {
        private event EventHandler DataChanging;

        private LoadingScreen _loadScreen;

		public void Dispose()
		{
			if (!Closable) { return; }
			LoadingScreen.Close();
			_loadScreen = null;
		}

        private LoadingScreen LoadingScreen
        {
            get
            {
                if (_loadScreen is null || _loadScreen.IsDisposed)
                {
                    _loadScreen = new LoadingScreen();
                }

                return _loadScreen;
            }
        }

        public string LoadText
        {
            get
            {
                return LoadingScreen.LoadText;
            }
            set
            {
                LoadingScreen.LoadText = value;
            }
        }

        public System.Drawing.Bitmap Image
        {
            get
            {
                return LoadingScreen.Image;
            }
            set
            {
                LoadingScreen.Image = value;
            }
        }

        [DefaultValue(false)]
        public bool Closable
        {
            get
            {
                return LoadingScreen.Closable;
            }
            set
            {
                LoadingScreen.Closable = value;
            }
        }

        [DefaultValue(false)]
        public bool TopMost
        {
            get
            {
                return LoadingScreen.TopMost;
            }
            set
            {
                LoadingScreen.TopMost = value;
            }
        }

        public LoadScreenDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog()
        {
            LoadingScreen.Show();
            return default;
        }

        private void DialogDisposed(object sender, EventArgs e)
        {
            if (LoadingScreen is not null)
            {
                LoadingScreen.Close();
                LoadingScreen.Dispose();
            }
        }

        public void ShowError(string message)
        {
            Image = My.Resources.Resources.ErrorImage;
            LoadText = message;
        }
    }
}
