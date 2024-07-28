using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
	public partial class CustomerDataGrid
	{
		// The columns used in this datagrid
		private readonly DataGridViewTextBoxColumn dgc_Name = new();
		private readonly DataGridViewTextBoxColumn dgc_Address = new();
		private readonly DataGridViewTextBoxColumn dgc_Phone = new();
		private readonly DataGridViewTextBoxColumn dgc_Email = new();
		private readonly DataGridViewTextBoxColumn dgc_Join = new();

		/// <summary>
		/// Event that occurs when a customer is being added to the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler AddCustomer;

		/// <summary>
		/// Event that occurs when a customer is being removed from the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler RemoveCustomer;

		/// <summary>
		/// Event that occurs when a customer is being updated in the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler UpdateCustomer;

		/// <summary>
		/// The list of customers currently in the data grid
		/// </summary>
		[Browsable(false)]
		public Types.CustomerCollection Customers
		{
			get => Types.CustomerCollection.Cast(bsCustomers.List);
			set
			{
				if (DesignMode)
				{
					return;
				}

				bsCustomers.DataSource = value;
			}
		}

		/// <summary>
		/// The filter to place on the data in the grid
		/// </summary>
		public string Filter
		{
			get => bsCustomers.Filter;
			set => bsCustomers.Filter = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public Types.CustomerCollection SelectedCustomers => Types.CustomerCollection.Cast(base.SelectedRows);

		/// <summary>
		/// 
		/// </summary>
		public CustomerDataGrid() : base()
		{
			InitializeComponent();

			LoadColumns();

			AddEntry += (sender, e) => AddCustomer?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateCustomer?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveCustomer?.Invoke(sender, new(e.Value, e.EventType));
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected override void LoadColumns()
		{
			base.LoadColumns();

			dgc_ID.HeaderText = "CustomerID";

			// Name Column
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 25F;
			dgc_Name.HeaderText = "Name";
			dgc_Name.MinimumWidth = 10;
			dgc_Name.Name = "dgc_Name";

			// Address Column
			dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Address.DataPropertyName = "Address";
			dgc_Address.FillWeight = 25F;
			dgc_Address.HeaderText = "Address";
			dgc_Address.MinimumWidth = 10;
			dgc_Address.Name = "dgc_Address";

			// Phone Column
			dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Phone.DataPropertyName = "Phone";
			dgc_Phone.FillWeight = 25F;
			dgc_Phone.HeaderText = "Phone";
			dgc_Phone.MinimumWidth = 10;
			dgc_Phone.Name = "dgc_Phone";

			// Email Column
			dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Email.DataPropertyName = "Email";
			dgc_Email.FillWeight = 25F;
			dgc_Email.HeaderText = "Email";
			dgc_Email.MinimumWidth = 10;
			dgc_Email.Name = "dgc_Email";

			// Join Date Column
			dgc_Join.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dgc_Join.DataPropertyName = "Joined";
			dgc_Join.DefaultCellStyle = new() { Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A", WrapMode = System.Windows.Forms.DataGridViewTriState.False };
			dgc_Join.HeaderText = "Joined";
			dgc_Join.MinimumWidth = 10;
			dgc_Join.Name = "dgc_Join";

			Columns.AddRange(
			[
				dgc_Selection, dgc_ID,
				dgc_Name, dgc_Address, dgc_Phone, dgc_Email,
				dgc_Join, dgc_Edit, dgc_Remove

			]);
		}
	}

}
