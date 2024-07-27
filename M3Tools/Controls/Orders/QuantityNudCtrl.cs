using System;

namespace SPPBC.M3Tools
{
	public partial class QuantityNudCtrl
	{
		/// <summary>
		/// The minimum value allowed
		/// </summary>
		[System.ComponentModel.DefaultValue(0)]
		public int MinimumValue
		{
			get => (int)Math.Round(nud_Quantity.Minimum);
			set => nud_Quantity.Minimum = value < 0 ? 0 : value;
		}

		/// <summary>
		/// The maximum value allowed
		/// </summary>
		[System.ComponentModel.DefaultValue(int.MaxValue)]
		public int MaximumValue
		{
			get => (int)Math.Round(nud_Quantity.Maximum);
			set => nud_Quantity.Maximum = value > int.MaxValue ? int.MaxValue : value;
		}

		/// <summary>
		/// The label shown with the control
		/// </summary>
		[System.ComponentModel.DefaultValue("Quantity")]
		public string Label
		{
			get => lbl_Quantity.Text;
			set => lbl_Quantity.Text = value;
		}

		/// <summary>
		/// The quantity value selected
		/// </summary>
		[System.ComponentModel.DefaultValue(0)]
		public int Quantity
		{
			get => (int)Math.Round(nud_Quantity.Value);
			set => nud_Quantity.Value = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public QuantityNudCtrl()
		{
			InitializeComponent();
		}
	}
}
