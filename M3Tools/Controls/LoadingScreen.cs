using System;

namespace SPPBC.M3Tools
{

	/// <summary>
	/// 
	/// </summary>
	public sealed partial class LoadingScreen
	{

		// NOTE: This form can easily be set as the splash screen for the application by going to the "Application" tab
		// of the Project Designer ("Properties" under the "Project" menu).
		/// <summary>
		/// Event fired when text is changed
		/// </summary>
		public event EventHandler TextChange;

		/// <summary>
		/// Event fired when the loading screen is closable
		/// </summary>
		public event EventHandler ClosableChanged;
		internal event EventHandler DialogClosing;

		private bool __closable = false;
		// Private __gifBitmap As GifBitmap

		/// <summary>
		/// The text to display in the loading screen
		/// </summary>
		public string LoadText
		{
			get => lbl_LoadText.Text;
			set
			{
				lbl_LoadText.Text = value;
				TextChange?.Invoke(this, new EventArgs());
			}
		}

		/// <summary>
		/// Whether the loading screen is closable
		/// </summary>
		public bool Closable
		{
			get => __closable;
			set
			{
				__closable = value;
				ClosableChanged?.Invoke(this, new EventArgs());
			}
		}

		/// <summary>
		/// The image to show in the loading screen
		/// </summary>
		public System.Drawing.Bitmap Image
		{
			get => (System.Drawing.Bitmap)pic_Load.Image;
			set => pic_Load.Image = value;// If value.RawFormat.Guid = Drawing.Imaging.ImageFormat.Gif.Guid Then// tmr_Timer.Enabled = True// __gifBitmap.ClearGifFrames()// __gifBitmap.LoadGif()// Else// tmr_Timer.Enabled = False// End If
		}

		/// <summary>
		/// 
		/// </summary>
		public LoadingScreen()
		{
			InitializeComponent();
		}

		private void LoadingScreen_ClosableChanged(object sender, EventArgs e)
		{
			Opacity = 100d;
			btn_Close.Enabled = __closable;
			btn_Close.Visible = __closable;
			UseWaitCursor = !__closable;
			// __gifBitmap.Toggle()
		}

		private void TimerTicking(object sender, EventArgs e)
		{
			// __gifBitmap.Tick()
		}

		// Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
		// '__gifBitmap = New GifBitmap(tmr_Timer, pic_Loading) ', Properties.Loading_Loop_3)
		// End Sub

		/// <summary>
		/// Close the loading screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void CloseScreen(object sender, EventArgs e)
		{
			Close();
			DialogClosing?.Invoke(this, new EventArgs());
		}

		internal void Reset()
		{
			LoadText = "";
			Closable = false;
			Image = Properties.Resources.Loading_Loop_3;
		}
	}
}
