// MAYBE: Use the Address.Display function here instead?
namespace SPPBC.M3Tools
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
    public partial class AddressField
    {
		/// <summary>
		/// The address being displayed
		/// </summary>
        public Types.Address Address
        {
            get
            {
                return Types.Address.Parse(Street, City, State, ZipCode);
            }
            set
            {
                Street = (value?.Street) ?? "";
                City = (value?.City) ?? "";
                State = (value?.State) ?? "";
                ZipCode = (value?.ZipCode) ?? "";
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public string Street
        {
            get
            {
                if (string.IsNullOrWhiteSpace(if_Address1.Text))
                {
                    // No values present
                    return "";
                }

                if (string.IsNullOrWhiteSpace(if_Address2.Text))
                {
                    // Only Address1 is filled
                    return if_Address1.Text;
                }

                // Both fields present
                return string.Join(",", if_Address1.Text, if_Address2.Text);
            }
            set
            {
                if (value.Contains(","))
                {
                    string[] parts = value.Split(',');
                    if_Address1.Text = parts[0];
                    if_Address2.Text = parts[1];
                    return;
                }

                if_Address1.Text = value;
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public string City
        {
            get
            {
                return if_City.Text;
            }
            set
            {
                if_City.Text = value;
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public string State
        {
            get
            {
                return ssf_State.StateCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                if ((value?.Length) is { } arg1 && arg1 > 2)
                {
                    value = Utils.StateCodeToState(value);
                }

                ssf_State.StateCode = value;
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public string ZipCode
        {
            get
            {
                return if_ZipCode.Text;
            }
            set
            {
                if ((value?.Length) is { } arg2 && arg2 > 5)
                {
                    value = value.Substring(0, 5);
                }

                if_ZipCode.Text = value;
            }
        }

		/// <summary>
		/// Whether the address is valid
		/// </summary>
        public bool IsValidAddress
        {
            get
            {
                return ValidStreet & ValidCity & ValidState & ValidZip;
                // Return (Street <> "" AndAlso City <> "" AndAlso State <> "" AndAlso ZipCode <> "") OrElse (String.IsNullOrEmpty(Street) AndAlso String.IsNullOrEmpty(City) AndAlso String.IsNullOrEmpty(State) AndAlso String.IsNullOrEmpty(ZipCode))
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public AddressField()
        {
            InitializeComponent();
        }

        private bool ValidateValue(string text)
        {
            if (!AllEmpty && string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            return true;
        }

        private bool ValidStreet
        {
            get
            {
                if (!ValidateValue(Street))
                {
                    ep_InvalidAddress.SetError(if_Address1, "A valid street address is required, or you can enter an empty address");
                    return false;
                }

                ep_InvalidAddress.SetError(if_Address1, string.Empty);
                return true;
            }
        }

        private bool ValidCity
        {
            get
            {
                if (!ValidateValue(City))
                {
                    ep_InvalidAddress.SetError(if_City, "A valid city is required, or you can enter an empty address");
                    return false;
                }

                ep_InvalidAddress.SetError(if_City, string.Empty);
                return true;
            }
        }

        private bool ValidState
        {
            get
            {
                if (!ValidateValue(State))
                {
                    ep_InvalidAddress.SetError(ssf_State, "A valid state code is required, or you can enter an empty address");
                    return false;
                }

                ep_InvalidAddress.SetError(ssf_State, string.Empty);
                return true;
            }
        }

        private bool ValidZip
        {
            get
            {
                if (!ValidateValue(ZipCode))
                {
                    ep_InvalidAddress.SetError(if_ZipCode, "A valid zip code is required, or you can enter an empty address");
                    return false;
                }

                ep_InvalidAddress.SetError(if_ZipCode, string.Empty);
                return true;
            }
        }

        private bool AllEmpty
        {
            get
            {
                return !(!string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(State) && !string.IsNullOrEmpty(ZipCode));
            }
        }
	}
}
