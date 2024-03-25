using System;

namespace SPPBC.M3Tools
{
    public partial class StateSelectorField
    {
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

        public StateSelectorField()
        {
            InitializeComponent();
        }

        private void cbx_States_TextChanged(object sender, EventArgs e)
        {

        }
    }
}