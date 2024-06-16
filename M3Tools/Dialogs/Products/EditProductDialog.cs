using System;
using System.Windows.Forms;

// TODO: Create a base class for these edit dialogs and other components I use for easier updating

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EditProductDialog
	{
		private event EventHandler ProductChanged;

		/// <summary>
		/// 
		/// </summary>
		public Types.Product Original
		{
			get;
			private set;
		}

		/// <summary>
		/// 
		/// </summary>
		public Types.Product Product
		{
			get => new(Original.Id, ItemName, ItemStock, ItemPrice, ItemAvailable);
		}

		private string ItemName
		{
			get
			{
				return gi_Name.Text;
			}
			set
			{
				gi_Name.Text = value;
			}
		}

		private int ItemStock
		{
			get
			{
				return qn_Stock.Quantity;
			}
			set
			{
				qn_Stock.Quantity = value;
			}
		}

		private decimal ItemPrice
		{
			get
			{
				return pi_Price.Price;
			}
			set
			{
				pi_Price.Price = value;
			}
		}

		private bool ItemAvailable
		{
			get
			{
				return chk_Available.Checked;
			}
			set
			{
				chk_Available.Checked = value;
			}
		}

		private EditProductDialog()
		{
			InitializeComponent();

			ProductChanged += new EventHandler(ProductUpdated);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="product"></param>
		public EditProductDialog(Types.Product product) : this()
		{
			Original = product;
			ProductChanged?.Invoke(this, EventArgs.Empty);
		}

		private void FinishDialog(object sender, EventArgs e)
		{
			if (Product == Original)
			{
				MessageBox.Show("There were errors in your edits. Please review And try again.", "Editting Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelDialog(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void ProductUpdated(object sender, EventArgs e)
		{
			ItemName = Original.Name;
			ItemStock = Original.Stock;
			ItemPrice = Original.Price;
			ItemAvailable = Original.Available;
			Text = string.Format(Text, ProductName);
		}
	}
}
