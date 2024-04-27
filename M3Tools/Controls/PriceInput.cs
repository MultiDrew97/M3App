using System;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools
{
    public partial class PriceInput
    {

		/// <summary>
		/// What the label should say
		/// </summary>
        [System.ComponentModel.DefaultValue("Price")]
        public string Label
        {
            get
            {
                return lbl_Price.Text;
            }
            set
            {
                lbl_Price.Text = value;
            }
        }

		/// <summary>
		/// The price to display
		/// </summary>
        [System.ComponentModel.DefaultValue(0)]
        public decimal Price
        {
            get
            {
                return Conversions.ToDecimal(txt_Price.Text);
            }
            set
            {
                txt_Price.Text = value.FormatPrice();
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public PriceInput()
        {
            InitializeComponent();
        }

        private void FormatText()
        {
            txt_Price.Text = Price.FormatPrice();
        }

        private void FormatText(object sender, EventArgs e) => FormatText();
    }
}
