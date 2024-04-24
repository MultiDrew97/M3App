using System.ComponentModel;
using System.Text.RegularExpressions;

namespace SPPBC.M3Tools
{

    public partial class PhoneNumberField
    {
		/// <summary>
		/// The phone number entered
		/// </summary>
        public string PhoneNumber
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

		/// <summary>
		/// Whether the phone number is valid
		/// </summary>
		[Browsable(false)]
		public bool ValidPhone { get; private set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public PhoneNumberField()
        {
            InitializeComponent();

			Validating += new CancelEventHandler(ValidatePhone);
        }

        private void ValidatePhone(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(Text) || Regex.IsMatch(Text, @"\d{7,10}") || !txt_PhoneNumber.MaskCompleted))
            {
                // Set error provider for phone number control
                ep_InvalidPhone.SetError(txt_PhoneNumber, "Invalid phone number");
                ValidPhone = false;
				e.Cancel = true;
				return;
            }

            ValidPhone = true;
        }
	}
}
