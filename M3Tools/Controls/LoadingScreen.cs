using System;

namespace SPPBC.M3Tools
{

    public sealed partial class LoadingScreen
    {

        // NOTE: This form can easily be set as the splash screen for the application by going to the "Application" tab
        // of the Project Designer ("Properties" under the "Project" menu).
        public event EventHandler TextChange;
        public event EventHandler ClosableChanged;
        internal event EventHandler DialogClosing;

        private bool __closable = false;
        // Private __gifBitmap As GifBitmap

        public string LoadText
        {
            get
            {
                return lbl_LoadText.Text;
            }
            set
            {
                lbl_LoadText.Text = value;
                TextChange?.Invoke(this, new EventArgs());
            }
        }

        public bool Closable
        {
            get
            {
                return __closable;
            }
            set
            {
                __closable = value;
                ClosableChanged?.Invoke(this, new EventArgs());
            }
        }

        public System.Drawing.Bitmap Image
        {
            get
            {
                return (System.Drawing.Bitmap)pic_Load.Image;
            }
            set
            {
                pic_Load.Image = value;
                // If value.RawFormat.Guid = Drawing.Imaging.ImageFormat.Gif.Guid Then
                // tmr_Timer.Enabled = True
                // __gifBitmap.ClearGifFrames()
                // __gifBitmap.LoadGif()
                // Else
                // tmr_Timer.Enabled = False
                // End If
            }
        }

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
        // '__gifBitmap = New GifBitmap(tmr_Timer, pic_Loading) ', My.Resources.Loading_Loop_3)
        // End Sub

        public void CloseScreen(object sender, EventArgs e)
        {
            Close();
            DialogClosing?.Invoke(this, new EventArgs());
        }

        internal void Reset()
        {
            LoadText = "";
            Closable = false;
            Image = My.Resources.Resources.Loading_Loop_3;
        }
    }
}
