using System;
using System.Data.SqlClient;
using System.Drawing;
using static System.Text.RegularExpressions.Regex;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
    public partial class AddProductDialog
    {
		private decimal ItemPrice { get => pi_Price.Price; set => pi_Price.Price = value; }
		private string ItemName { get => gi_Name.Text; set => gi_Name.Text = value; }
		private int ItemStock { get => qnc_Stock.Quantity; set => qnc_Stock.Quantity = value; }

		/// <summary>
		/// The product being added
		/// </summary>
		public SPPBC.M3Tools.Types.Product Product => new(-1, ItemName, ItemStock, ItemPrice, true);

		/// <summary>
		/// 
		/// </summary>
        public AddProductDialog()
        {
            InitializeComponent();
        }

        private void Reload(object sender, EventArgs e)
        {
            ItemName = "";
            ItemStock = 0;
            ItemPrice = 0;
        }

        private void Add(object sender, EventArgs e)
        {
			DialogResult = DialogResult.OK;
			Close();
		}
        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
