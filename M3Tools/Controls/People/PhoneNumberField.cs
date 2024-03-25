using System.Text.RegularExpressions;

namespace SPPBC.M3Tools
{

    public partial class PhoneNumberField
    {
        public override string Text
        {
            get
            {
                return txt_PhoneNumber.Text;
            }
            set
            {
                txt_PhoneNumber.Text = value;
            }
        }

        public bool ValidPhone
        {
            get
            {
                return ValidatePhone();
            }
        }

        public PhoneNumberField()
        {
            InitializeComponent();
        }

        private bool ValidatePhone()
        {
            if (!(string.IsNullOrWhiteSpace(Text) || Regex.IsMatch(Text, @"\d{7,10}") || !txt_PhoneNumber.MaskCompleted))
            {
                // Set error provider for phone number control
                ep_InvalidPhone.SetError(txt_PhoneNumber, "Invalid phone number");
                return false;
            }

            return true;
        }
    }
}
