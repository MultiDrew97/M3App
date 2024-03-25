using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public abstract class DataGridViewImageButtonColumn : DataGridViewButtonColumn
    {

        [Bindable(true)]
        public System.Drawing.Bitmap ButtonImage { get; set; }

        protected DataGridViewImageButtonColumn(DataGridViewCell cellTemplate)
        {
            CellTemplate = cellTemplate;
            MinimumWidth = 25;
            Width = 25;
            FillWeight = 5f;
            Resizable = DataGridViewTriState.False;
        }
    }

    public class DataGridViewImageButtonDeleteColumn : DataGridViewImageButtonColumn
    {

        public DataGridViewImageButtonDeleteColumn() : base(new DataGridViewImageButtonDeleteCell())
        {
        }
    }

    public class DataGridViewImageButtonEditColumn : DataGridViewImageButtonColumn
    {

        public DataGridViewImageButtonEditColumn() : base(new DataGridViewImageButtonEditCell())
        {
        }
    }
}