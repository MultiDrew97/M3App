using System;

namespace SPPBC.M3Tools
{
    public partial class QuantityNudCtrl
    {
		/// <summary>
		/// 
		/// </summary>
        public event QuantityChangedEventHandler QuantityChanged;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="newQuantity"></param>
        public delegate void QuantityChangedEventHandler(int newQuantity);

		/// <summary>
		/// The minimum value allowed
		/// </summary>
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

		/// <summary>
		/// The maximum value allowed
		/// </summary>
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

		/// <summary>
		/// The label shown with the control
		/// </summary>
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

		/// <summary>
		/// The quantity value selected
		/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
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
