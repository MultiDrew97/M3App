using System;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXmlFormats.Wordprocessing;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types.Extensions
{
	static class StringExtensions
	{
		public static string FormatPhone(this string value)
		{
			return Regex.Replace(value, $@"{My.Settings.Default.PhoneRegex}", "($1) $2-$3");
		}

		public static string ToBase64String(this string value)
		{
			return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
		}

		public static string FromBase64String(this string value)
		{
			return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value));
		}

		public static string ToHTML(this string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return string.Empty;
			var encodedText = System.Web.HttpUtility.HtmlEncode(value);
			var lineBreaks = encodedText.Replace("\n", "<br />");
			var paragraphs = "<p>" + string.Join("</p><p>", lineBreaks.Split(new[] { "<br><br>" }, StringSplitOptions.None)) + "</p>";

			return paragraphs;
		}

		public static string FromRtfToHtml(this string value)
		{
			using RichTextBox richTextBox = new();

			// Load the RTF text into the RichTextBox
			richTextBox.Rtf = value;

			// Extract the plain text
			string plainText = richTextBox.Text;

			// Initialize a StringBuilder to build the HTML
			StringBuilder htmlBuilder = new();

			htmlBuilder.Append("<html><body>");

			// Iterate through the text and apply formatting
			int start = 0;
			while (start < richTextBox.TextLength)
			{
				richTextBox.Select(start, 1);

				// Handle bold
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
				{
					htmlBuilder.Append("<b>");
				}

				// Handle italic
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
				{
					htmlBuilder.Append("<i>");
				}

				// Handle underline
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
				{
					htmlBuilder.Append("<u>");
				}

				// Add the character
				htmlBuilder.Append(richTextBox.SelectedText);

				// Close the tags
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
				{
					htmlBuilder.Append("</u>");
				}
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
				{
					htmlBuilder.Append("</i>");
				}
				if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
				{
					htmlBuilder.Append("</b>");
				}

				start++;
			}

			htmlBuilder.Append("</body></html>");

			return htmlBuilder.ToString();
		}
	}

	static class DoubleExtensions
	{
		public static string FormatPrice(this double value)
		{
			return $"{value:C2}";
		}
	}

	static class DecimalExtensions
	{
		public static string FormatPrice(this decimal value)
		{
			return $"{value:C2}";
		}
	}
}
