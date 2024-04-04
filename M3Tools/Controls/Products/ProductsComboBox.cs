using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

	public partial class ProductsComboBox
	{
		public event LoadBeginEventHandler LoadBegin;

		public delegate void LoadBeginEventHandler();
		public event LoadEndEventHandler LoadEnd;

		public delegate void LoadEndEventHandler();
		public event SelectedItemChangedEventHandler SelectedItemChanged;

		public delegate void SelectedItemChangedEventHandler(int newValue);

		public object SelectedItem
		{
			get
			{
				return cbx_Items.SelectedItem;
			}
			set
			{
				if (value is null)
				{
					return;
				}

				cbx_Items.SelectedItem = value;
			}
		}

		public int SelectedIndex
		{
			get
			{
				return cbx_Items.SelectedIndex;
			}
			set
			{
				if (value < 0)
				{
					return;
				}

				cbx_Items.SelectedIndex = value;
			}
		}

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
