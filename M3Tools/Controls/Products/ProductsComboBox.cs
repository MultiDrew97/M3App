using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

	/// <summary>
	/// 
	/// </summary>
	public partial class ProductsComboBox
	{
		/// <summary>
		/// 
		/// </summary>
		public event LoadBeginEventHandler LoadBegin;

		/// <summary>
		/// 
		/// </summary>
		public delegate void LoadBeginEventHandler();
		/// <summary>
		/// 
		/// </summary>
		public event LoadEndEventHandler LoadEnd;

		/// <summary>
		/// 
		/// </summary>
		public delegate void LoadEndEventHandler();
		/// <summary>
		/// 
		/// </summary>
		public event SelectedItemChangedEventHandler SelectedItemChanged;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="newValue"></param>
		public delegate void SelectedItemChangedEventHandler(int newValue);

		/// <summary>
		/// The currently selected inventory item
		/// </summary>
		public Types.Product SelectedItem
		{
			get
			{
				return cbx_Items.SelectedItem as Types.Product;
			}
		}

		/// <summary>
		/// The currently selected index
		/// </summary>
		public int SelectedIndex
		{
			get
			{
				return cbx_Items.SelectedIndex;
			}
			set
			{
				if (value < 0 || value > cbx_Items.Items.Count)
				{
					throw new ArgumentException();
				}

				cbx_Items.SelectedIndex = value;
			}
		}

		/// <summary>
		/// The currently selected value
		/// </summary>
		public object SelectedValue
		{
			get
			{
				return cbx_Items.SelectedValue;
			}
			set
			{
				if (value is null)
				{
					return;
				}

				cbx_Items.SelectedValue = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public ProductsComboBox()
		{
			InitializeComponent();
		}

		private void LoadItems(object sender, DoWorkEventArgs e)
		{
			LoadBegin?.Invoke();
			// Dim items = db_Products.GetProducts()
			// _items.Clear()
			try
			{
				bsItems.Clear();
			}
			catch
			{

			}

			foreach (var item in db_Products.GetProducts())
				// Dim var As DataTables.ItemsDataRow = CType(CType(bsItems.AddNew(), DataRowView).Row, DataTables.ItemsDataRow)
				// var.ItemArray = {item.Id, item.Name, item.Stock, item.Price, item.Available}
				// Console.WriteLine(var.ItemArray)
				// bsItems.Add(DataTables.ItemsDataRow())
				// _items.AddItemsRow(item.Id, item.Name, item.Stock, item.Price, item.Available)
				bsItems.Add(item);
		}

		private void ControlLoaded(object sender, EventArgs e)
		{
			// bsItems.DataSource = _items
		}

		private void ItemsLoaded(object sender, RunWorkerCompletedEventArgs e)
		{
			// cbx_Items.DataSource = bsItems
			// cbx_Items.DisplayMember = "ItemName"
			// cbx_Items.ValueMember = "ItemID"
			// cbx_Items.Refresh()
			bsItems.ResetBindings(false);
			LoadEnd?.Invoke();
		}

		/// <summary>
		/// Reloads the control
		/// </summary>
		public void Reload()
		{
			bw_LoadItems.RunWorkerAsync();
		}

		private void IndexChanged(object sender, EventArgs e)
		{
			SelectedItemChanged?.Invoke(Conversions.ToInteger(SelectedValue));
		}
	}
}
