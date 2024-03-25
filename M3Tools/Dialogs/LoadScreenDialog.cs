using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class LoadScreenDialog
    {
        private event EventHandler DataChanging;

        private LoadingScreen _LoadScreen;

        private LoadingScreen LoadScreen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LoadScreen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LoadScreen != null)
                {
                    _LoadScreen.DialogClosing -= DialogClosed;
                }

                _LoadScreen = value;
                if (_LoadScreen != null)
                {
                    _LoadScreen.DialogClosing += DialogClosed;
                }
            }
        }

        private LoadingScreen LoadingScreen
        {
            get
            {
                if (LoadScreen is null || LoadScreen.IsDisposed)
                {
                    LoadScreen = new LoadingScreen();
                }

                return LoadScreen;
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

        private void DialogClosed(object sender, EventArgs e)
        {
            // LoadScreen.Close()
            // __loadScreen = Nothing
        }

        public DialogResult ShowDialog()
        {
            LoadingScreen.Show();
            return default;
        }

        private void DialogDisposed(object sender, EventArgs e)
        {
            if (LoadScreen is not null)
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