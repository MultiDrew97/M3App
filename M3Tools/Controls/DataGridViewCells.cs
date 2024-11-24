using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public abstract class DataGridViewImageButtonCell : DataGridViewButtonCell
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected readonly System.Drawing.Bitmap _ButtonImage;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="image">The image to use for the cell</param>
		protected DataGridViewImageButtonCell(System.Drawing.Bitmap image)
		{
			FlatStyle = FlatStyle.System;
			_ButtonImage = image;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="graphics"></param>
		/// <param name="clipBounds"></param>
		/// <param name="cellBounds"></param>
		/// <param name="rowIndex"></param>
		/// <param name="elementState"></param>
		/// <param name="value"></param>
		/// <param name="formattedValue"></param>
		/// <param name="errorText"></param>
		/// <param name="cellStyle"></param>
		/// <param name="advancedBorderStyle"></param>
		/// <param name="paintParts"></param>
		protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			// MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

			// Draw the cell background, if specified.
			if ((paintParts & DataGridViewPaintParts.Background).Equals(DataGridViewPaintParts.Background))
			{
				using System.Drawing.SolidBrush CellBackground = new(cellStyle.BackColor);
				graphics.FillRectangle(CellBackground, cellBounds);
			}

			// Draw the cell borders, if specified.
			if ((paintParts & DataGridViewPaintParts.Border).Equals(DataGridViewPaintParts.Border))
			{
				PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
			}

			// Because the area in which to draw the button needs to be known,
			// start with the current bounds of the cell and the rectangle
			// representing the borders (DataGridViewAdvancedBorderStyle)
			System.Drawing.Rectangle ButtonArea = cellBounds;
			System.Drawing.Rectangle ButtonBorderAllowance = BorderWidths(advancedBorderStyle);

			// Because there are some adjustments to be made
			int ImageHeight = Math.Min(ButtonArea.Height, _ButtonImage is null ? 9999 : _ButtonImage.Size.Height);
			int ImageWidth = Math.Min(ButtonArea.Width, _ButtonImage is null ? 9999 : _ButtonImage.Width);
			int WidthDiff = (int)Math.Round((cellBounds.Width - Math.Min(32, ImageWidth)) / 2d) - ButtonBorderAllowance.Width;
			int HeightDiff = (int)Math.Round((cellBounds.Height - Math.Min(32, ImageHeight)) / 2d) - ButtonBorderAllowance.Height;

			// Because, now the borders are known, the area needs to be amended. Moving the
			// (X,Y) in and down allows for the top and left borders while shrinking height
			// and width allows for bottom and right
			ButtonArea.X += ButtonBorderAllowance.X;
			ButtonArea.Y += ButtonBorderAllowance.Y;
			ButtonArea.Height -= ButtonBorderAllowance.Height * 2;
			ButtonArea.Width -= ButtonBorderAllowance.Width * 2;

			// Because this is where the image will be drawn
			System.Drawing.Rectangle ImageArea = new(ButtonArea.X + WidthDiff, ButtonArea.Y + HeightDiff, ImageWidth, ImageHeight);

			// Because the last step is to paint the button image
			ButtonRenderer.DrawButton(graphics, ButtonArea, _ButtonImage, ImageArea, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal); // ButtonState)
		}

		// MustOverride Sub LoadImages()
	}
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public class DataGridViewImageButtonEditCell : DataGridViewImageButtonCell
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public DataGridViewImageButtonEditCell() : base(Properties.Resources.Edit)
		{
		}
	}

	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public class DataGridViewImageButtonDeleteCell : DataGridViewImageButtonCell
	{

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public DataGridViewImageButtonDeleteCell() : base(Properties.Resources.Delete)
		{
		}
	}
}
