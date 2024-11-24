using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	public partial class OrderTotalCtrl
	{
		/// <summary>
		/// The total cost of the order
		/// </summary>
		public double Total
		{
			get => Conversions.ToDouble(txt_Total.Text.Replace("$", ""));
			set => txt_Total.Text = $"{Conversions.ToDecimal($"0{value}"):C2}";
		}

		/// <summary>
		/// 
		/// </summary>
		public OrderTotalCtrl() => InitializeComponent();
	}
}
