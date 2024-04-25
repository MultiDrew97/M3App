using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// A control that displays a list of customers in a combo box
	/// </summary>
    public partial class CustomersComboBox
    {
		/// <summary>
		/// The event that occurs when loading has begun
		/// </summary>
        public event LoadBeginEventHandler LoadBegin;
		/// <summary>
		/// The handler for when the control begins to load
		/// </summary>
        public delegate void LoadBeginEventHandler();

		/// <summary>
		/// The event that occurs when loading has completed
		/// </summary>
        public event LoadEndEventHandler LoadEnd;
		/// <summary>
		/// The handler for when the control finishes loading
		/// </summary>
        public delegate void LoadEndEventHandler();

		/// <summary>
		/// The event that occurs when the selected customer changes
		/// </summary>
        public event SelectedItemChangedEventHandler SelectedItemChanged;

		/// <summary>
		/// The handler for when a customer selection has changed
		/// </summary>
		/// <param name="newValue"></param>
        public delegate void SelectedItemChangedEventHandler(int newValue);

		/// <summary>
		/// The currently selected customer
		/// </summary>
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

		/// <summary>
		/// The index in the list for the currently selected customer
		/// </summary>
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

		/// <summary>
		/// <inheritdoc/>
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
		/// <inheritdoc/>
		/// </summary>
        public CustomersComboBox()
        {
            InitializeComponent();
        }

        private void LoadItems(object sender, DoWorkEventArgs e)
        {
            LoadBegin?.Invoke();
            try
            {
                bsCustomers.Clear();
            }
            catch
            {

            }

            foreach (var customer in db_Customers.GetCustomers())
                bsCustomers.Add(customer);
        }

        private void ControlLoaded(object sender, EventArgs e)
        {
            // bsItems.DataSource = _items
        }

        private void ItemsLoaded(object sender, RunWorkerCompletedEventArgs e)
        {
            bsCustomers.ResetBindings(false);
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
