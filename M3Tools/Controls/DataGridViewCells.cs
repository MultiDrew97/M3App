using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public abstract class DataGridViewImageButtonCell : DataGridViewButtonCell
    {

        protected readonly System.Drawing.Bitmap _ButtonImage;

        protected DataGridViewImageButtonCell(System.Drawing.Bitmap image)
        {
            FlatStyle = FlatStyle.System;
            _ButtonImage = image;
        }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            // MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

            // Draw the cell background, if specified.
            if ((paintParts & DataGridViewPaintParts.Background).Equals(DataGridViewPaintParts.Background))
            {
                using (var CellBackground = new System.Drawing.SolidBrush(cellStyle.BackColor))
                {
                    graphics.FillRectangle(CellBackground, cellBounds);
                }
            }

            // Draw the cell borders, if specified.
            if ((paintParts & DataGridViewPaintParts.Border).Equals(DataGridViewPaintParts.Border))
            {
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }

            // Because the area in which to draw the button needs to be known,
            // start with the current bounds of the cell and the rectangle
            // representing the borders (DataGridViewAdvancedBorderStyle)
            var ButtonArea = cellBounds;
            var ButtonBorderAllowance = BorderWidths(advancedBorderStyle);

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
            var ImageArea = new System.Drawing.Rectangle(ButtonArea.X + WidthDiff, ButtonArea.Y + HeightDiff, ImageWidth, ImageHeight);

            // Because the last step is to paint the button image
            ButtonRenderer.DrawButton(graphics, ButtonArea, _ButtonImage, ImageArea, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal); // ButtonState)
        }


        // MustOverride Sub LoadImages()
    }
    public class DataGridViewImageButtonEditCell : DataGridViewImageButtonCell
    {

        public DataGridViewImageButtonEditCell() : base(My.Resources.Resources.edit)
        {
        }
    }

    public class DataGridViewImageButtonDeleteCell : DataGridViewImageButtonCell
    {

        public DataGridViewImageButtonDeleteCell() : base(My.Resources.Resources.delete)
        {
        }
    }
}