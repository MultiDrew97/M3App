using System;
using System.Collections;
using System.ComponentModel;
using SPPBC.M3Tools.Data;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace SPPBC.M3Tools
{

    public partial class ListenersDataGrid
    {
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
        public IList Listeners
        {
            get
            {
                return base.Rows;
            }
        }

		/// <summary>
		/// The data source used for the control
		/// </summary>
        [Description("Data Source to use for data grid.")]
		public new object DataSource
		{
			get
			{
				if (DesignMode)
				{
					return typeof(ListenerBindingSource);
				}

				return (ListenerBindingSource)base.DataSource;
			}
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
        public ListenersDataGrid()
        {
            InitializeComponent();

			dgc_ListenerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();

			LoadColumns();

			//AddEntry += new DataEventHandler<Types.Listener>(ParseEvents);
			UpdateEntry += new DataEventHandler<Types.Listener>(ParseEvents);
			RemoveEntry += new DataEventHandler<Types.Listener>(ParseEvents);
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Listener> e)
		{
			Console.WriteLine("Parsing DataGrid Event");
			Console.WriteLine("Sender: {0}\nEvent Type: {1}\nValue: {2}", sender, e.EventType, e.Value);
			switch (e.EventType)
			{
				case EventType.Added: { AddListener?.Invoke(sender, (ListenerEventArgs)e); break; }
				case EventType.Removed: { UpdateListener?.Invoke(sender, (ListenerEventArgs)e); break; }
				case EventType.Updated: { RemoveListener?.Invoke(sender, (ListenerEventArgs)e); break; }
				default: { throw new ArgumentException($"'{e.EventType}' is not a valid EventType value"); }
			}
		}

		private new void LoadColumns()
		{
			base.LoadColumns();

			// 
			// dgc_Email
			// 
			dgc_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Email.DataPropertyName = "Email";
			dgc_Email.FillWeight = 50.0f;
			dgc_Email.HeaderText = "Email";
			dgc_Email.Name = "dgc_Email";
			// 
			// dgc_Name
			// 
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 50.0f;
			dgc_Name.HeaderText = "Name";
			dgc_Name.Name = "dgc_Name";
			// 
			// dgc_ListenerID
			// 
			dgc_ListenerID.DataPropertyName = "Id";
			dgc_ListenerID.FillWeight = 5.0f;
			dgc_ListenerID.Frozen = true;
			dgc_ListenerID.HeaderText = "ListenerID";
			dgc_ListenerID.Name = "dgc_ListenerID";
			dgc_ListenerID.ReadOnly = true;
			dgc_ListenerID.Visible = false;

			Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				dgc_Selection,
				dgc_ListenerID, dgc_Name, dgc_Email,
				dgc_Edit, dgc_Remove
			});
		}

		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_ListenerID;
	}
}
