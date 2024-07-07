using System;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXmlFormats.Wordprocessing;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types.Extensions
{
	// TODO: Flesh out this functionality at some point
	//			Need to find a better way to convert RTF to HTML effectively effeciently
	/// <summary>
	/// Which end of the tag to use
	/// </summary>
	public enum TagEnd
	{
		/// <summary>
		/// The open end of the tag
		/// </summary>
		Open,

		/// <summary>
		/// The close end of the tag
		/// </summary>
		Close
	}

	/// <summary>
	/// The tags used in creating HTML documents
	/// </summary>
	public readonly struct HTMLTags
	{
		/// <summary>
		/// The document tags
		/// </summary>
		public static readonly string[] Document = { "<html><body><p>Greetings {0},</p><br/><br/>", "<br/><br/>{1}</body></html>" };

		/// <summary>
		/// The bold tags
		/// </summary>
		public static readonly string[] Bold = { "<strong>", "</strong>" };

		/// <summary>
		/// The italic tags
		/// </summary>
		public static readonly string[] Italic = { "<em>", "</em>" };

		/// <summary>
		/// The strikethrough tags
		/// </summary>
		public static readonly string[] Striketrough = { "<s>", "</s>" };

		/// <summary>
		/// The underline tags
		/// </summary>
		public static readonly string[] Underline = { "<u>", "</u>" };

		/// <summary>
		/// The paragraph tags
		/// </summary>
		public static readonly string[] Paragraph = { "<p>", "</p>" };

		/// <summary>
		/// The line break tag
		/// </summary>
		public static readonly string LineBreak = "<br />";
	}
	static class StringExtensions
	{
		public static string FormatPhone(this string value)
		{
			return Regex.Replace(value, $@"{My.Settings.Default.PhoneRegex}", "($1) $2-$3");
		}

		public static string ToBase64String(this string value)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
		}

		public static string FromBase64String(this string value)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(value));
		}

		public static string ToHTML(this string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return string.Empty;
			var encodedText = System.Web.HttpUtility.HtmlEncode(value);
			var lineBreaks = encodedText.Replace("\n", "<br />");
			var paragraphs = "<p>" + string.Join("</p><p>", lineBreaks.Split(new[] { "<br><br>" }, StringSplitOptions.None)) + "</p>";

			return paragraphs;
		}

		/// <summary>
		/// Converts RTF formatted string into HTML formated string
		/// </summary>
		/// <param name="value">The string to convert. Assumed to always be in RTF format unless specified</param>
		/// <param name="rtf">Whether the string is in RTF format</param>
		/// <returns></returns>
		public static string FromRtfToHtml(this string value, bool rtf = true)
		{
			using RichTextBox richTextBox = new();

			// Load the RTF text into the RichTextBox
			if (rtf) richTextBox.Rtf = value;
			else richTextBox.Text = value;

			// Extract the plain text
			//string plainText = richTextBox.Text;

			// Initialize a StringBuilder to build the HTML
			StringBuilder htmlBuilder = new();

			htmlBuilder.Append(HTMLTags.Document[(int)TagEnd.Open]);

			// Iterate through the text and apply formatting
			foreach (var line in richTextBox.Lines)
			{
				if (line == string.Empty)
				{
					htmlBuilder.Append(HTMLTags.LineBreak);
					continue;
				}

				htmlBuilder.Append(HTMLTags.Paragraph[(int)TagEnd.Open]);
				int offset = 0;
				while (offset < line.Length)
				{
					richTextBox.SelectionStart = richTextBox.Text.IndexOf(line) + offset; //Select(start, 1);
					richTextBox.SelectionLength = 1;

					// Handle bold
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
					{
						htmlBuilder.Append(HTMLTags.Bold[(int)TagEnd.Open]);
					}

					// Handle italic
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
					{
						htmlBuilder.Append(HTMLTags.Italic[(int)TagEnd.Open]);
					}

					// Handle underline
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
					{
						htmlBuilder.Append(HTMLTags.Underline[(int)TagEnd.Open]);
					}

					// Add the character
					htmlBuilder.Append(richTextBox.SelectedText);

					// Close the tags
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
					{
						htmlBuilder.Append(HTMLTags.Underline[(int)TagEnd.Close]);
					}
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
					{
						htmlBuilder.Append(HTMLTags.Italic[(int)TagEnd.Close]);
					}
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
					{
						htmlBuilder.Append(HTMLTags.Bold[(int)TagEnd.Close]);
					}

					offset++;
				}

				htmlBuilder.Append(HTMLTags.Paragraph[(int)TagEnd.Close]);
			}

			htmlBuilder.Append(HTMLTags.Document[(int)TagEnd.Close]);

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
