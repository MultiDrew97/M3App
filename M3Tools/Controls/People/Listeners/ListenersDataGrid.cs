using System.ComponentModel;
using SPPBC.M3Tools.Events.Listeners;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ListenersDataGrid
	{
		// Columns for listeners data grid
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name = new();
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email = new();

		/// <summary>
		/// An event fired when a listener is added
		/// </summary>
		public event ListenerEventHandler AddListener;

		/// <summary>
		/// An event fired when a listener is updated
		/// </summary>
		public event ListenerEventHandler UpdateListener;

		/// <summary>
		/// An event fired when a listener is removed
		/// </summary>
		public event ListenerEventHandler RemoveListener;

		/// <summary>
		/// 
		/// </summary>
		public delegate void RefreshDisplayEventHandler();

		/// <summary>
		/// The complete list of listeners being shown
		/// </summary>
		[Browsable(false)]
		public Types.ListenerCollection Listeners
		{
			get => Types.ListenerCollection.Cast(bsListeners.List);
			set
			{
				if (DesignMode)
				{
					return;
				}

				bsListeners.DataSource = value;
			}
		}

		/// <summary>
		/// The filter to apply to the data grid
		/// </summary>
		public string Filter
		{
			get => bsListeners.Filter;
			set => bsListeners.Filter = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public Types.ListenerCollection SelectedListeners => Types.ListenerCollection.Cast(base.SelectedRows);

		/// <summary>
		/// 
		/// </summary>
		public ListenersDataGrid() : base()
		{
			InitializeComponent();

			LoadColumns();

			AddEntry += (sender, e) => AddListener?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateListener?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveListener?.Invoke(sender, new(e.Value, e.EventType));
		}
		/// <inheritdoc/>

		protected override void LoadColumns()
		{
			base.LoadColumns();


			dgc_ID.HeaderText = "ListenerID";

			// Email Column
			dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Email.DataPropertyName = "Email";
			dgc_Email.FillWeight = 50F;
			dgc_Email.HeaderText = "Email";
			dgc_Email.Name = "dgc_Email";

			// Name Column
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 50F;
			dgc_Name.HeaderText = "Name";
			dgc_Name.Name = "dgc_Name";


			Columns.AddRange([
				dgc_Selection, dgc_ID,
				dgc_Name, dgc_Email,
				dgc_Edit, dgc_Remove
			]);
		}
	}
}
