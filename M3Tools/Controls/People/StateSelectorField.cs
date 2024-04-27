using System;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class StateSelectorField
    {
		/// <summary>
		/// The selected state code
		/// </summary>
        public string StateCode
        {
            get
            {
                return cbx_States.Text;
            }
            set
            {
                if ((value?.Length) is { } arg1 && arg1 >= 2)
                {
                    value = value.Substring(0, 2);
                }

                cbx_States.Text = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public StateSelectorField()
        {
            InitializeComponent();
        }

        private void cbx_States_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
