using System.Text.RegularExpressions;

namespace M3App.Types.Extensions
{
    static class StringExtensions
    {
        private readonly static Regex phone = new Regex(@"(\d{3})(\d{3})(\d{4})");

        public static string FormatPhone(this string value)
        {
            return phone.Replace(value, "({0}) {1}-{2}");
        }
    }
}