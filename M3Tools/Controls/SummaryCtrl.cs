
namespace SPPBC.M3Tools
{
    public partial class SummaryCtrl
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.Category("Data")]
        public object Display
        {
            get
            {
                return pg_Summary.SelectedObject;
            }
            set
            {
                pg_Summary.SelectedObject = value;

                if (!(value == null))
                {
                    pg_Summary.ExpandAllGridItems();
                }
            }
        }

        public SummaryCtrl()
        {
            InitializeComponent();
        }

        // TODO: Create custom summary page for this. No controls provide desired look and feel

        // ' Summary
        // '	* Basics
        // '		- Name:	Customer Name
        // '		- Email: Customer Email
        // ' * Address
        // '		- Street: Customer Street Address
        // '		- City: Customer City
        // '		- State: Customer State
        // '		- Zip Code: Customer Zip Code
    }
}