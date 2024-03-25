using System;

namespace SPPBC.M3Tools
{
    public partial class QuantityNudCtrl
    {
        public event QuantityChangedEventHandler QuantityChanged;

        public delegate void QuantityChangedEventHandler(int newQuantity);

        [System.ComponentModel.DefaultValue(0)]
        public int MinimumValue
        {
            get
            {
                return (int)Math.Round(nud_Quantity.Minimum);
            }
            set
            {
                nud_Quantity.Minimum = value < 0 ? 0 : value;
            }
        }

        [System.ComponentModel.DefaultValue(int.MaxValue)]
        public int MaximumValue
        {
            get
            {
                return (int)Math.Round(nud_Quantity.Maximum);
            }
            set
            {
                nud_Quantity.Maximum = value > int.MaxValue ? int.MaxValue : value;
            }
        }

        [System.ComponentModel.DefaultValue("Quantity")]
        public string Label
        {
            get
            {
                return lbl_Quantity.Text;
            }
            set
            {
                lbl_Quantity.Text = value;
            }
        }

        [System.ComponentModel.DefaultValue(0)]
        public int Quantity
        {
            get
            {
                return (int)Math.Round(nud_Quantity.Value);
            }
            set
            {
                nud_Quantity.Value = value;
            }
        }

        public QuantityNudCtrl()
        {
            InitializeComponent();
        }

        private void QuantityValueChanged(object sender, EventArgs e)
        {
            QuantityChanged?.Invoke(Quantity);
        }
    }
}