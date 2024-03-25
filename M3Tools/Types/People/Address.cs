using System;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;

namespace SPPBC.M3Tools.Types
{
    public class Address
    {

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("street")]
        public string Street { get; set; }

        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string City { get; set; }

        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; }

        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }

        public static Address None
        {
            get
            {
                return new Address();
            }
        }

        [System.Text.Json.Serialization.JsonConstructor]
        public Address(string street = null, string city = null, string state = null, string zipCode = null)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public static Address Parse(string addrStr)
        {
            string[] addrParts = addrStr.Split(',');

            if (addrParts.Count() < 4)
            {
                throw new ArgumentException($"Unable to parse an address from '{addrStr}'");
            }

            return Parse(addrParts[0], addrParts[1], addrParts[2], addrParts[3]);
        }

        public static Address Parse(object street, object city, object state, object zipCode)
        {
            string streetStr, cityStr, stateStr, zipStr;

            streetStr = street as string;
            cityStr = city as string;
            stateStr = state as string;
            zipStr = zipCode as string;

            if (!(!string.IsNullOrEmpty(streetStr) || !string.IsNullOrEmpty(cityStr) || !string.IsNullOrEmpty(stateStr) || !string.IsNullOrEmpty(zipStr)))
            {
                return null;
            }

            return new Address(streetStr, cityStr, stateStr, zipStr);
        }

        public override string ToString()
        {
            return string.Join(My.MySettingsProperty.Settings.ObjectDelimiter, Street, City, State, ZipCode);
        }

        public string Display()
        {
            // If there was not an address supplied, it doesn't apply the formating
            return string.IsNullOrEmpty(Street) | string.IsNullOrEmpty(City) | string.IsNullOrEmpty(State) | string.IsNullOrEmpty(ZipCode) ? "" : $"{string.Join(Constants.vbCrLf, Street.Split(',').Where((currentString) => !string.IsNullOrWhiteSpace(currentString)))}{Constants.vbCrLf}{City}, {State} {ZipCode}";
        }

        public static bool operator ==(Address left, Address right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null & right is not null || left is not null & right is null)
            {
                return false;
            }

            if ((left.Street ?? "") != (right.Street ?? ""))
            {
                return false;
            }

            if ((left.City ?? "") != (right.City ?? ""))
            {
                return false;
            }

            if ((left.State ?? "") != (right.State ?? ""))
            {
                return false;
            }

            if ((left.ZipCode ?? "") != (right.ZipCode ?? ""))
            {
                return false;
            }

            return true;
        }

        public static bool operator !=(Address left, Address right)
        {
            return !(left == right);
        }
    }
}