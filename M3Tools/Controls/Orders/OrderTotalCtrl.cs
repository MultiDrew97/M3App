using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
    public partial class OrderTotalCtrl
    {
        private event TotalChangedEventHandler TotalChanged;

        private delegate void TotalChangedEventHandler();
        public double Total
        {
            get
            {
                return Conversions.ToDouble(txt_Total.Text.Replace("$", ""));
            }
            set
            {
                txt_Total.Text = $"{value}";
                TotalChanged?.Invoke();
            }
        }

        public OrderTotalCtrl()
        {
            InitializeComponent();
        }

        private void UpdateTotal()
        {
            txt_Total.Text = $"{Conversions.ToDecimal($"0{Total}"):C2}";
        }
    }
}