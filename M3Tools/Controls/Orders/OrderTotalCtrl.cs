using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	public partial class OrderTotalCtrl
	{
		private event TotalChangedEventHandler TotalChanged;

		private delegate void TotalChangedEventHandler();

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
		public OrderTotalCtrl()
		{
			InitializeComponent();
		}
	}
}
