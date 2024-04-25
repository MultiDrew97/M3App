using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// Columns for creating button cells with a image on them
	/// </summary>
    public abstract class DataGridViewImageButtonColumn : DataGridViewButtonColumn
    {
		/// <summary>
		/// The image to display
		/// </summary>
        [Bindable(true)]
        public System.Drawing.Bitmap ButtonImage { get; set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="cellTemplate"></param>
        protected DataGridViewImageButtonColumn(DataGridViewCell cellTemplate)
        {
            CellTemplate = cellTemplate;
            MinimumWidth = 25;
            Width = 25;
            FillWeight = 5f;
            Resizable = DataGridViewTriState.False;
        }
    }

	/// <summary>
	/// Columns for displaying a delete icon over the button
	/// </summary>
    public class DataGridViewImageButtonDeleteColumn : DataGridViewImageButtonColumn
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public DataGridViewImageButtonDeleteColumn() : base(new DataGridViewImageButtonDeleteCell())
        {
        }
    }

	/// <summary>
	/// Columns for displaying an edit icon over the button
	/// </summary>
    public class DataGridViewImageButtonEditColumn : DataGridViewImageButtonColumn
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public DataGridViewImageButtonEditColumn() : base(new DataGridViewImageButtonEditCell())
        {
        }
    }
}
