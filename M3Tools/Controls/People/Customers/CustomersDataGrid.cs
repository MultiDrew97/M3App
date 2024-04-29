using System;
using System.Collections;
using System.ComponentModel;
using SPPBC.M3Tools.Events;

namespace SPPBC.M3Tools.Data
{

    // TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
    public partial class CustomerDataGrid : DataGrid<Types.Customer>
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

			if (DesignMode)
			{
				return;
			}

			this.dgc_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgc_Join = new System.Windows.Forms.DataGridViewTextBoxColumn();

			LoadColumns();

			AddEntry += new DataEventHandler<Types.Customer>(ParseEvents);
			UpdateEntry += new DataEventHandler<Types.Customer>(ParseEvents);
			RemoveEntry += new DataEventHandler<Types.Customer>(ParseEvents);
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Customer> e)
		{
			Console.WriteLine("Parsing DataGrid Event");
			Console.WriteLine("Sender: {0}\nEvent Type: {1}\nValue: {2}", sender, e.EventType, e.Value);
			switch (e.EventType)
			{
				case EventType.Added: { AddCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break; }
				case EventType.Removed: { RemoveCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break; }
				case EventType.Updated: { UpdateCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break; }
				default: { throw new ArgumentException($"'{e.EventType}' is not a valid EventType value"); }
			}
		}

		private new void LoadColumns()
		{
			base.LoadColumns();
			// 
			// dgc_CustomerID
			// 
			this.dgc_CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_CustomerID.DataPropertyName = "Id";
			this.dgc_CustomerID.FillWeight = 5F;
			this.dgc_CustomerID.Frozen = true;
			this.dgc_CustomerID.HeaderText = "CustomerID";
			this.dgc_CustomerID.MinimumWidth = 10;
			this.dgc_CustomerID.Name = "dgc_CustomerID";
			this.dgc_CustomerID.ReadOnly = true;
			this.dgc_CustomerID.Visible = false;
			// 
			// dgc_Name
			// 
			this.dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dgc_Name.DataPropertyName = "Name";
			this.dgc_Name.FillWeight = 25F;
			this.dgc_Name.Frozen = true;
			this.dgc_Name.HeaderText = "Name";
			this.dgc_Name.MinimumWidth = 10;
			this.dgc_Name.Name = "dgc_Name";
			this.dgc_Name.ReadOnly = true;
			// 
			// dgc_Address
			// 
			this.dgc_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_Address.DataPropertyName = "Address";
			this.dgc_Address.FillWeight = 25F;
			this.dgc_Address.HeaderText = "Address";
			this.dgc_Address.MinimumWidth = 10;
			this.dgc_Address.Name = "dgc_Address";
			this.dgc_Address.ReadOnly = true;
			// 
			// dgc_Phone
			// 
			this.dgc_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_Phone.DataPropertyName = "Phone";
			this.dgc_Phone.FillWeight = 25F;
			this.dgc_Phone.HeaderText = "Phone";
			this.dgc_Phone.MinimumWidth = 10;
			this.dgc_Phone.Name = "dgc_Phone";
			this.dgc_Phone.ReadOnly = true;
			// 
			// dgc_Email
			// 
			this.dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgc_Email.DataPropertyName = "Email";
			this.dgc_Email.FillWeight = 25F;
			this.dgc_Email.HeaderText = "Email";
			this.dgc_Email.MinimumWidth = 10;
			this.dgc_Email.Name = "dgc_Email";
			this.dgc_Email.ReadOnly = true;
			// 
			// dgc_Join
			//
			this.dgc_Join.HeaderText = "Joined";
			this.dgc_Join.DataPropertyName = "Joined";
			this.dgc_Join.MinimumWidth = 10;
			this.dgc_Join.ReadOnly = true;
			this.dgc_Join.Name = "dgc_Join";

			Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.dgc_Selection,
				this.dgc_CustomerID,
				this.dgc_Name, this.dgc_Address,
				this.dgc_Phone, this.dgc_Email,
				this.dgc_Join,
				this.dgc_Edit, this.dgc_Remove
			});
		}

		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_CustomerID;
		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_Address;
		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_Phone;
		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
		private readonly System.Windows.Forms.DataGridViewTextBoxColumn dgc_Join;
	}

}
