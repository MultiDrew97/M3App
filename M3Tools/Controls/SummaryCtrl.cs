
namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class SummaryCtrl
    {
		/// <summary>
		/// The data to display in the summary
		/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
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
