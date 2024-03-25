using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

    public struct Utils
    {
        public static SecureString ToSecureString(string password)
        {
            var secureString = new SecureString();

            foreach (char ch in password)
                secureString.AppendChar(ch);

            secureString.MakeReadOnly();

            return secureString;
        }

        public static string DefaultFileName(string fileName)
        {
            return fileName.Split(@"\\".ToCharArray())[fileName.Split(@"\\".ToCharArray()).Length - 1].Split(".".ToCharArray())[0] + " " + DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        public static void Wait(int seconds = 5)
        {
            // found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

            for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        public static string ToUnsecureString(SecureString password)
        {
            var returnValue = IntPtr.Zero;
            try
            {
                returnValue = Marshal.SecureStringToGlobalAllocUnicode(password);
                return Marshal.PtrToStringUni(returnValue);
            }
            catch
            {
                Marshal.ZeroFreeGlobalAllocUnicode(returnValue);
                return $"Error: {password.Length}";
            }
        }

        public static string StateCodeToState(string stateCode)
        {
            // MAYBE: Convert to use a dictionary
            switch (stateCode.ToUpper() ?? "")
            {
                case "AL":
                    {
                        return "Alabama";
                    }
                case "AK":
                    {
                        return "Alaska";
                    }
                case "AZ":
                    {
                        return "Arizona";
                    }
                case "AR":
                    {
                        return "Arkansas";
                    }
                case "CA":
                    {
                        return "California";
                    }
                case "CO":
                    {
                        return "Colorado";
                    }
                case "CT":
                    {
                        return "Connecticut";
                    }
                case "DE":
                    {
                        return "Delaware";
                    }
                case "FL":
                    {
                        return "Florida";
                    }
                case "GA":
                    {
                        return "Georgia";
                    }
                case "HI":
                    {
                        return "Hawaii";
                    }
                case "ID":
                    {
                        return "Idaho";
                    }
                case "IL":
                    {
                        return "Illinois";
                    }
                case "IN":
                    {
                        return "Indiana";
                    }
                case "IA":
                    {
                        return "Iowa";
                    }
                case "KS":
                    {
                        return "Kansas";
                    }
                case "KY":
                    {
                        return "Kentucky";
                    }
                case "LA":
                    {
                        return "Louisiana";
                    }
                case "ME":
                    {
                        return "Maine";
                    }
                case "MD":
                    {
                        return "Maryland";
                    }
                case "MA":
                    {
                        return "Massachusetts";
                    }
                case "MI":
                    {
                        return "Michigan";
                    }
                case "MN":
                    {
                        return "Minnesota";
                    }
                case "MS":
                    {
                        return "Mississippi";
                    }
                case "MO":
                    {
                        return "Missouri";
                    }
                case "MT":
                    {
                        return "Montana";
                    }
                case "NE":
                    {
                        return "Nebraska";
                    }
                case "NV":
                    {
                        return "Nevada";
                    }
                case "NH":
                    {
                        return "New Hampshire";
                    }
                case "NJ":
                    {
                        return "New Jersey";
                    }
                case "NM":
                    {
                        return "New Mexico";
                    }
                case "NY":
                    {
                        return "New York";
                    }
                case "NC":
                    {
                        return "North Carolina";
                    }
                case "ND":
                    {
                        return "North Dakota";
                    }
                case "OH":
                    {
                        return "Ohio";
                    }
                case "OK":
                    {
                        return "Oklahoma";
                    }
                case "OR":
                    {
                        return "Oregon";
                    }
                case "PA":
                    {
                        return "Pennsylvania";
                    }
                case "RI":
                    {
                        return "Rhode Island";
                    }
                case "SC":
                    {
                        return "South Carolina";
                    }
                case "SD":
                    {
                        return "South Dakota";
                    }
                case "TN":
                    {
                        return "Tennessee";
                    }
                case "TX":
                    {
                        return "Texas";
                    }
                case "UT":
                    {
                        return "Utah";
                    }
                case "VT":
                    {
                        return "Vermont";
                    }
                case "VA":
                    {
                        return "Virgina";
                    }
                case "WA":
                    {
                        return "Washington";
                    }
                case "WV":
                    {
                        return "West Virgina";
                    }
                case "WI":
                    {
                        return "Wisconsin";
                    }
                case "WY":
                    {
                        return "Wyoming";
                    }

                default:
                    {
                        throw new Exceptions.InvalidStateCodeException("The provided state code is invalid.");
                    }
            }
        }

        public static string StateToStateCode(string state)
        {
            switch (state ?? "")
            {
                case "alabama":
                    {
                        return "AL";
                    }
                case "alaska":
                    {
                        return "AK";
                    }
                case "arizona":
                    {
                        return "AZ";
                    }
                case "arkansas":
                    {
                        return "AR";
                    }
                case "california":
                    {
                        return "CA";
                    }
                case "colorado":
                    {
                        return "CO";
                    }
                case "connecticut":
                    {
                        return "CT";
                    }
                case "delaware":
                    {
                        return "DE";
                    }
                case "florida":
                    {
                        return "FL";
                    }
                case "georgia":
                    {
                        return "GA";
                    }
                case "hawaii":
                    {
                        return "HI";
                    }
                case "idaho":
                    {
                        return "ID";
                    }
                case "illinois":
                    {
                        return "IL";
                    }
                case "indiana":
                    {
                        return "IN";
                    }
                case "iowa":
                    {
                        return "IA";
                    }
                case "kansas":
                    {
                        return "KS";
                    }
                case "kentucky":
                    {
                        return "KY";
                    }
                case "louisiana":
                    {
                        return "LA";
                    }
                case "maine":
                    {
                        return "ME";
                    }
                case "maryland":
                    {
                        return "MD";
                    }
                case "massachusetts":
                    {
                        return "MA";
                    }
                case "michigan":
                    {
                        return "MI";
                    }
                case "minnesota":
                    {
                        return "MN";
                    }
                case "mississippi":
                    {
                        return "MS";
                    }
                case "missouri":
                    {
                        return "MO";
                    }
                case "montana":
                    {
                        return "MT";
                    }
                case "nebraska":
                    {
                        return "NE";
                    }
                case "nevada":
                    {
                        return "NV";
                    }
                case "new hampshire":
                    {
                        return "NH";
                    }
                case "new jersey":
                    {
                        return "NJ";
                    }
                case "new mexico":
                    {
                        return "NM";
                    }
                case "new york":
                    {
                        return "NY";
                    }
                case "north carolina":
                    {
                        return "NC";
                    }
                case "north dakota":
                    {
                        return "ND";
                    }
                case "ohio":
                    {
                        return "OH";
                    }
                case "oklahoma":
                    {
                        return "OK";
                    }
                case "oregon":
                    {
                        return "OR";
                    }
                case "pennsylvania":
                    {
                        return "PA";
                    }
                case "rhode island":
                    {
                        return "RI";
                    }
                case "south carolina":
                    {
                        return "SC";
                    }
                case "south dakota":
                    {
                        return "SD";
                    }
                case "tennessee":
                    {
                        return "TN";
                    }
                case "texas":
                    {
                        return "TX";
                    }
                case "utah":
                    {
                        return "UT";
                    }
                case "vermont":
                    {
                        return "VT";
                    }
                case "virgina":
                    {
                        return "VA";
                    }
                case "washington":
                    {
                        return "WA";
                    }
                case "west virgina":
                    {
                        return "WV";
                    }
                case "wisconsin":
                    {
                        return "WI";
                    }
                case "wyoming":
                    {
                        return "WY";
                    }

                default:
                    {
                        throw new Exceptions.InvalidStateCodeException("The provided state is invalid");
                    }
            }
        }

        public static bool ValidEmail(string email)
        {
            try
            {
                return System.Text.RegularExpressions.Regex.IsMatch(email, My.Resources.Resources.EmailRegex2);
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidID(int id)
        {
            return id >= 1;
        }

        public static DateTime TryDateCast(object value)
        {
            try
            {
                return Conversions.ToDate(value);
            }
            catch
            {
                return default;
            }
        }

        public static void PrintConsole(string title, object value)
        {
            Console.WriteLine($"------------------------ {title} ------------------------");
            Console.WriteLine(value);
            Console.WriteLine($"---------------------------------------------------------");
        }
    }
}
