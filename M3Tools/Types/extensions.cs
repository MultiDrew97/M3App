using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
		public static readonly string[] Document = ["<html><body><p>Greetings {0},</p><br/><br/>", "<br/><br/>{1}</body></html>"];

		/// <summary>
		/// The bold tags
		/// </summary>
		public static readonly string[] Bold = ["<strong>", "</strong>"];

		/// <summary>
		/// The italic tags
		/// </summary>
		public static readonly string[] Italic = ["<em>", "</em>"];

		/// <summary>
		/// The strikethrough tags
		/// </summary>
		public static readonly string[] Striketrough = ["<s>", "</s>"];

		/// <summary>
		/// The underline tags
		/// </summary>
		public static readonly string[] Underline = ["<u>", "</u>"];

		/// <summary>
		/// The paragraph tags
		/// </summary>
		public static readonly string[] Paragraph = ["<p>", "</p>"];

		/// <summary>
		/// The line break tag
		/// </summary>
		public static readonly string LineBreak = "<br />";
	}

	/// <summary>
	/// 
	/// </summary>
	public static class SecureStringExtensions
	{
		/// <summary>
		/// Converts a secure string to an unsecure string
		/// </summary>
		/// <returns></returns>
		public static string ToUnsecureString(this SecureString value)
		{
			IntPtr returnValue = IntPtr.Zero;
			try
			{
				returnValue = Marshal.SecureStringToGlobalAllocUnicode(value);
				return Marshal.PtrToStringUni(returnValue);
			}
			catch
			{
				Marshal.ZeroFreeGlobalAllocUnicode(returnValue);
				return $"Error: {value.Length}";
			}
		}
	}

	/// <summary>
	/// The extensions used by string values within the application
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static SecureString ToSecureString(this string value)
		{
			SecureString secureString = new();

			foreach (char ch in value)
			{
				secureString.AppendChar(ch);
			}

			secureString.MakeReadOnly();

			return secureString;
		}

		/// <summary>
		/// Format a string as a phone number
		/// </summary>
		/// <param name="value">The value to be formatted</param>
		/// <param name="format">The format to be used</param>
		/// <returns></returns>
		public static string FormatPhone(this string value, string format = "($1) $2-$3") => Regex.Replace(value, $@"{Properties.Settings.Default.PhoneRegex}", format);

		/// <summary>
		/// Convert the string to a base64 encoded string
		/// </summary>
		/// <param name="value">The value to be converted</param>
		/// <returns></returns>
		public static string ToBase64String(this string value) => string.IsNullOrWhiteSpace(value) ? string.Empty : Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

		/// <summary>
		/// Convert a base64 encoded string to a normal string
		/// </summary>
		/// <param name="value">The value to be converted</param>
		/// <returns></returns>
		public static string FromBase64String(this string value) => string.IsNullOrWhiteSpace(value) ? string.Empty : Encoding.UTF8.GetString(Convert.FromBase64String(value));

		/// <summary>
		/// Converts the string be hashed for security
		/// </summary>
		/// <param name="value">The value to be hashed</param>
		/// <param name="salt">The salt to use for the hashing</param>
		/// <returns></returns>
		public static string Hash(this string value, string salt) => Hash(value, new Guid(salt));

		/// <summary>
		/// Converts the string to be hashed for security
		/// </summary>
		/// <param name="value">The value to hash</param>
		/// <param name="salt">THe salt to use for the hash</param>
		/// <returns></returns>
		public static string Hash(this string value, Guid salt)
		{
			using System.Security.Cryptography.SHA256 hasher = System.Security.Cryptography.SHA256.Create();
			byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(string.Join("", value, salt)));
			return Convert.ToBase64String(bytes);
		}

		/// <summary>
		/// Encrypt a value
		/// </summary>
		/// <param name="value"></param>
		/// <param name="salt"></param>
		/// <returns></returns>
		public static string Encrypt(this string value, Guid salt = default)
		{
			if (string.IsNullOrWhiteSpace(value))
				return value;

			byte[] bytes = Encoding.UTF8.GetBytes(value);

			byte[] encrypted = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);

			return Convert.ToBase64String(encrypted);
		}

		/// <summary>
		/// Decrypt a value
		/// </summary>
		/// <param name="value"></param>
		/// <param name="salt"></param>
		/// <returns></returns>
		public static string Decrypt(this string value, Guid salt = default)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;

			byte[] bytes = Convert.FromBase64String(value);

			byte[] decrypted = ProtectedData.Unprotect(bytes, null, DataProtectionScope.CurrentUser);

			return Encoding.UTF8.GetString(decrypted);
		}

		/// <summary>
		/// Converts a string to HTML format
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string ToHTML(this string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return string.Empty;
			}

			string encodedText = System.Web.HttpUtility.HtmlEncode(value);
			string lineBreaks = encodedText.Replace("\n", "<br />");
			string paragraphs = "<p>" + string.Join("</p><p>", lineBreaks.Split(new[] { "<br><br>" }, StringSplitOptions.None)) + "</p>";

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
			if (rtf)
			{
				richTextBox.Rtf = value;
			}
			else
			{
				richTextBox.Text = value;
			}

			// Extract the plain text
			//string plainText = richTextBox.Text;

			// Initialize a StringBuilder to build the HTML
			StringBuilder htmlBuilder = new();

			_ = htmlBuilder.Append(HTMLTags.Document[(int)TagEnd.Open]);

			// Iterate through the text and apply formatting
			foreach (string line in richTextBox.Lines)
			{
				if (line == string.Empty)
				{
					_ = htmlBuilder.Append(HTMLTags.LineBreak);
					continue;
				}

				_ = htmlBuilder.Append(HTMLTags.Paragraph[(int)TagEnd.Open]);
				int offset = 0;
				while (offset < line.Length)
				{
					richTextBox.SelectionStart = richTextBox.Text.IndexOf(line) + offset; //Select(start, 1);
					richTextBox.SelectionLength = 1;

					// Handle bold
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
					{
						_ = htmlBuilder.Append(HTMLTags.Bold[(int)TagEnd.Open]);
					}

					// Handle italic
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
					{
						_ = htmlBuilder.Append(HTMLTags.Italic[(int)TagEnd.Open]);
					}

					// Handle underline
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
					{
						_ = htmlBuilder.Append(HTMLTags.Underline[(int)TagEnd.Open]);
					}

					// Add the character
					_ = htmlBuilder.Append(richTextBox.SelectedText);

					// Close the tags
					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Underline)
					{
						_ = htmlBuilder.Append(HTMLTags.Underline[(int)TagEnd.Close]);
					}

					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Italic)
					{
						_ = htmlBuilder.Append(HTMLTags.Italic[(int)TagEnd.Close]);
					}

					if (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Bold)
					{
						_ = htmlBuilder.Append(HTMLTags.Bold[(int)TagEnd.Close]);
					}

					offset++;
				}

				_ = htmlBuilder.Append(HTMLTags.Paragraph[(int)TagEnd.Close]);
			}

			_ = htmlBuilder.Append(HTMLTags.Document[(int)TagEnd.Close]);

			return htmlBuilder.ToString();
		}
	}

	/// <summary>
	/// Extensions used for variables of type Double
	/// </summary>
	public static class DoubleExtensions
	{
		/// <summary>
		/// Convert the value to be formated as a price
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string FormatPrice(this double value) => $"{value:C2}";
	}

	/// <summary>
	/// Extensions used for variables of type Decimal
	/// </summary>
	public static class DecimalExtensions
	{
		/// <summary>
		/// Convert the value to be formated as a price
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string FormatPrice(this decimal value) => $"{value:C2}";
	}
}
