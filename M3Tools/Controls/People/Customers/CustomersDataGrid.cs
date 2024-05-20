using System.Collections;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{

	// TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
	public partial class CustomerDataGrid
	{
		/*private readonly System.Collections.Generic.Dictionary<string, Tuple<string, int>> columns = new() {
			{ "ID", new("CustomerID", 1) },
			{ "Name", new("Name", 2) },
			{ "Address", new("Address", 3) },
			{ "Phone", new("Phone", 4)},
			{ "Email", new("Email", 5) },
			{ "Join", new("Join", 6) }
		};*/
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
		/// <inheritdoc/>
		/// </summary>
		public new object DataSource
		{
			get
			{
				if (DesignMode)
				{
					return typeof(CustomerBindingSource);
				}

				return (CustomerBindingSource)base.DataSource;
			}
			set => base.DataSource = value;
		}

		/// <summary>
		/// The list of customers currently in the data grid
		/// </summary>
		[Browsable(false)]
		public IList Customers
		{
			get
			{
				return base.Rows;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public CustomerDataGrid() : base()
		{
			InitializeComponent();

			LoadColumns();

			AddEntry += (sender, e) => AddCustomer?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateCustomer?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveCustomer?.Invoke(sender, new(e.Value, e.EventType));
		}

		public new void LoadColumns()
		{
			base.LoadColumns();

			dgc_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Join = new System.Windows.Forms.DataGridViewTextBoxColumn();

			// 
			// dgc_CustomerID
			// 
			dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_CustomerID.DataPropertyName = "Id";
			dgc_CustomerID.FillWeight = 5F;
			dgc_CustomerID.Frozen = true;
			dgc_CustomerID.HeaderText = "CustomerID";
			dgc_CustomerID.MinimumWidth = 10;
			dgc_CustomerID.Name = "dgc_CustomerID";
			dgc_CustomerID.ReadOnly = true;
			dgc_CustomerID.Visible = false;

			// 
			// dgc_Name
			// 
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 25F;
			dgc_Name.Frozen = true;
			dgc_Name.HeaderText = "Name";
			dgc_Name.MinimumWidth = 10;
			dgc_Name.Name = "dgc_Name";
			dgc_Name.ReadOnly = true;

			// 
			// dgc_Address
			// 
			dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Address.DataPropertyName = "Address";
			dgc_Address.FillWeight = 25F;
			dgc_Address.HeaderText = "Address";
			dgc_Address.MinimumWidth = 10;
			dgc_Address.Name = "dgc_Address";
			dgc_Address.ReadOnly = true;

			// 
			// dgc_Phone
			// 
			dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Phone.DataPropertyName = "Phone";
			dgc_Phone.FillWeight = 25F;
			dgc_Phone.HeaderText = "Phone";
			dgc_Phone.MinimumWidth = 10;
			dgc_Phone.Name = "dgc_Phone";
			dgc_Phone.ReadOnly = true;

			// 
			// dgc_Email
			// 
			dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Email.DataPropertyName = "Email";
			dgc_Email.FillWeight = 25F;
			dgc_Email.HeaderText = "Email";
			dgc_Email.MinimumWidth = 10;
			dgc_Email.Name = "dgc_Email";
			dgc_Email.ReadOnly = true;

			// 
			// dgc_Join
			//
			dgc_Join.HeaderText = "Joined";
			dgc_Join.DataPropertyName = "Joined";
			dgc_Join.MinimumWidth = 10;
			dgc_Join.ReadOnly = true;
			dgc_Join.Name = "dgc_Join";

			Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				dgc_Selection,
				dgc_CustomerID,
				dgc_Name, dgc_Address,
				dgc_Phone, dgc_Email,
				dgc_Join,
				dgc_Edit, dgc_Remove
			});
		}
	}

}
