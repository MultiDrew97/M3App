using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// General utils struct for general application function.
	/// Was made partial to encourage extending the struct for other potential uses
	/// </summary>
	public readonly partial struct Utils
	{
		/// <summary>
		/// Dictionary of states to sift through for state code conversions
		/// </summary>
		public static readonly System.Collections.Generic.Dictionary<string, string> States = new(comparer: StringComparer.OrdinalIgnoreCase)
		{
			// TODO: Find better way to do this
			{ "AL", "Alabama" },
			{ "AK", "Alaska" },
			{ "AZ","Arizona" },
				{ "AR","Arkansas"
},
{ "CA",  "California"
},
				{ "CO", "Colorado"
},
				{ "CT", "Connecticut"
},
				{ "DE",  "Delaware"
},
				{ "FL",  "Florida"
},
				{ "GA", "Georgia"
},
				{ "HI", "Hawaii"
},
				{ "ID",  "Idaho"
},
				{ "IL", "Illinois"
},
				{ "IN",  "Indiana"
},
				{ "IA",  "Iowa"
},
				{ "KS", "Kansas"
},
				{ "KY", "Kentucky"
},
				{ "LA", "Louisiana"
},
				{ "ME", "Maine"
},
				{ "MD", "Maryland"
},
				{ "MA", "Massachusetts"
},
				{ "MI", "Michigan"
},
				{ "MN", "Minnesota"
},
				{ "MS", "Mississippi"
},
				{ "MO", "Missouri"
},
				{ "MT", "Montana"
},
				{ "NE",  "Nebraska"
},
				{ "NV", "Nevada"
},
				{ "NH", "New Hampshire"
},
				{ "NJ", "New Jersey"
},
				{ "NM", "New Mexico"
},
				{ "NY", "New York"
},
				{ "NC", "North Carolina"
},
				{ "ND", "North Dakota"
},
				{ "OH", "Ohio"
},
				{ "OK", "Oklahoma"
},
				{ "OR", "Oregon"
},
				{ "PA", "Pennsylvania"
},
				{ "RI", "Rhode Island"
},
				{ "SC", "South Carolina"
},
				{ "SD", "South Dakota"
},
				{ "TN",  "Tennessee"
},
				{ "TX",  "Texas"
},
				{ "UT", "Utah"
},
				{ "VT", "Vermont"
},
				{ "VA", "Virgina"
},
				{ "WA", "Washington"
},
				{ "WV", "West Virgina"
},
				{ "WI", "Wisconsin"
},
				{ "WY", "Wyoming"
},

			};

		/// <summary>
		/// Converts a normal unsecure string to a secure string
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		public static SecureString ToSecureString(string password)
		{
			SecureString secureString = new();

			foreach (char ch in password)
			{
				secureString.AppendChar(ch);
			}

			secureString.MakeReadOnly();

			return secureString;
		}

		/// <summary>
		/// Parses for a file's default upload name
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public static string DefaultFileName(string fileName)
		{
			return fileName.Split(@"\\".ToCharArray())[fileName.Split(@"\\".ToCharArray()).Length - 1].Split(".".ToCharArray())[0] + " " + System.DateTime.UtcNow.ToString("MM/dd/yyyy");
		}

		/// <summary>
		/// Waits for executions for a given amount of seconds
		/// </summary>
		/// <param name="seconds">The number of seconds to wait. Defaults to 5 seconds.</param>
		public static void Wait(int seconds = 5)
		{
			// found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

			for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
			{
				System.Threading.Thread.Sleep(10);
				Application.DoEvents();
			}
		}

		/// <summary>
		/// Converts a secure strin to an unsecure string
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		public static string ToUnsecureString(SecureString password)
		{
			System.IntPtr returnValue = System.IntPtr.Zero;
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

		/// <summary>
		/// Converts 2 character state code to it's full state name
		/// </summary>
		/// <param name="stateCode"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static string StateCodeToState(string stateCode)
		{
			try
			{
				return States[stateCode.Trim()];
			}
			catch
			{
				throw new ArgumentException($"'{stateCode}' not a valid state code");
			}
		}

		/// <summary>
		/// Converts a state's full name to it's 2 character state code
		/// </summary>
		/// <param name="state"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static string StateToStateCode(string state)
		{
			foreach (System.Collections.Generic.KeyValuePair<string, string> statePair in States)
			{
				if (StringComparer.OrdinalIgnoreCase.Compare(state, statePair.Value) != 0)
				{ continue; }

				return statePair.Key;
			}

			throw new ArgumentException($"'{state}' not a valid state");
		}

		/// <summary>
		/// Checks whether the provided value is a valid email address
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public static bool ValidEmail(string email)
		{
			try
			{
				return System.Text.RegularExpressions.Regex.IsMatch(email, Properties.Resources.EmailRegex2);
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Checks whether the provided value is a valid database entry ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static bool ValidID(int id)
		{
			return id >= 1;
		}

		/// <summary>
		/// Tries to cast the provided value as an instance of a DateTime object
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="title"></param>
		/// <param name="value"></param>
		public static void PrintConsole(string title, object value)
		{
			Console.WriteLine($"------------------------ {title} ------------------------");
			Console.WriteLine(value);
			Console.WriteLine($"---------------------------------------------------------");
		}
	}
}
