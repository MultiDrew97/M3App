using System;
using System.Collections.Generic;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// A bitmap for a GIF file
	/// </summary>
	public class GifBitmap
	{
		private readonly List<GifFrame> GifFrames = [];
		private int PlayIndex = 0;
		private readonly System.Windows.Forms.PictureBox __picBox;
		private readonly System.Windows.Forms.Timer __timer;
		private System.Drawing.Bitmap __image;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="timer"></param>
		/// <param name="picBox"></param>
		/// <param name="image"></param>
		public GifBitmap(ref System.Windows.Forms.Timer timer, ref System.Windows.Forms.PictureBox picBox, System.Drawing.Bitmap image)
		{
			__timer = timer;
			__picBox = picBox;
			__image = image;
			ClearGifFrames();
			LoadGif();
		}

		internal void LoadGif()
		{
			ClearGifFrames();
			StripGifFramesFromBitmap();
			__timer.Start();
		}

		internal void ClearGifFrames()
		{
			__timer.Stop();
			for (int i = GifFrames.Count - 1; i >= 0; i -= 1)
				GifFrames[i].Frame.Dispose();
			GifFrames.Clear();
			PlayIndex = 0;
		}

		/// <summary>
		/// Tick the internal timer to step through the frames
		/// </summary>
		public void Tick()
		{
			__timer.Interval = GifFrames[PlayIndex].Delay;
			__image = GifFrames[PlayIndex].Frame;
			PlayIndex += 1;
			if (PlayIndex == GifFrames.Count)
				PlayIndex = 0;
		}

		/// <summary>
		/// Toggle pausing the GIF
		/// </summary>
		public void Toggle() => __timer.Enabled = !__timer.Enabled;

		private void StripGifFramesFromBitmap()
		{
			const int PIID_FRAMEDELAY = 0x5100;
			System.Drawing.Imaging.FrameDimension fd = new(__image.FrameDimensionsList[0]);
			int framecount = __image.GetFrameCount(fd);
			if (framecount <= 1)
			{
				throw new Exceptions.GifException("The Gif file is not an animated type gif image.");
			}

			byte[] fdv = __image.GetPropertyItem(PIID_FRAMEDELAY).Value;
			for (int i = 0, loopTo = framecount - 1; i <= loopTo; i++)
			{
				int framedelay = BitConverter.ToInt32(fdv, 4 * i) * 10;
				if (framedelay == 0)
					framedelay = 90;
				try
				{
					_ = __picBox.Image.SelectActiveFrame(fd, i);
					GifFrames.Add(new GifFrame(__image, framedelay));
				}
				catch
				{
					ClearGifFrames();
					throw new Exceptions.GifException("An Unexpected Error Occurred Stripping Frame (" + i.ToString() + "}");
				}
			}

		}

		private class GifFrame
		{
			public System.Drawing.Bitmap Frame { get; set; }
			public int Delay { get; set; }

			public GifFrame(System.Drawing.Bitmap frm, int dly)
			{
				Frame = new System.Drawing.Bitmap(frm);
				Delay = dly;
			}
		}
	}
}
