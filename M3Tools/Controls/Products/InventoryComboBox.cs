namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class InventoryComboBox
	{
		/// <summary>
		/// The list of items to use
		/// </summary>
		public Types.InventoryCollection Inventory
		{
			set
			{
				foreach (Types.Product item in value)
				{
					_ = bsInventory.Add(item);
				}
			}
		}

		/// <summary>
		/// The currently selected inventory item
		/// </summary>
		public Types.Product SelectedItem => (Types.Product)cbx_Items.SelectedItem;

		/// <summary>
		/// The currently selected index
		/// </summary>
		public int SelectedIndex => cbx_Items.SelectedIndex;

		/// <summary>
		/// The currently selected value
		/// </summary>
		public object SelectedValue
		{
			get => cbx_Items.SelectedValue;
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
		public InventoryComboBox()
		{
			InitializeComponent();
		}
	}
}
