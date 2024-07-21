using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public partial class LoadScreenDialog
	{
		private LoadingScreen _loadScreen;

		/// <summary>
		/// 
		/// </summary>
		public new void Dispose()
		{
			LoadingScreen.Close();
			_loadScreen = null;
			base.Dispose(true);
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

		/// <summary>
		/// The text to dispaly
		/// </summary>
		public string LoadText
		{
			get => LoadingScreen.LoadText;
			set => LoadingScreen.LoadText = value;
		}

		/// <summary>
		/// The image to display
		/// </summary>
		public System.Drawing.Bitmap Image
		{
			get => LoadingScreen.Image;
			set => LoadingScreen.Image = value;
		}

		/// <summary>
		/// Whether the loading screen is closable yet
		/// </summary>
		[DefaultValue(false)]
		public bool Closable
		{
			get => LoadingScreen.Closable;
			set => LoadingScreen.Closable = value;
		}

		/// <summary>
		/// Whether it should be the top most form in the application
		/// </summary>
		[DefaultValue(false)]
		public bool TopMost
		{
			get => LoadingScreen.TopMost;
			set => LoadingScreen.TopMost = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public LoadScreenDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Show the loading screen
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		/// Update the loading screen to show the error image and message
		/// </summary>
		/// <param name="message"></param>
		public void ShowError(string message)
		{
			Image = Properties.Resources.ErrorImage;
			LoadText = message;
		}
	}
}
