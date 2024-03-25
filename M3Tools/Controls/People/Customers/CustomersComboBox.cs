using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

    public partial class CustomersComboBox
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