using System;

namespace SPPBC.M3Tools.Attributes
{
	/// <summary>
	/// Set a property or variable to return a predetermined value at runtime for debugging purposes
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <param name="value"></param>
	public class DebugCustomValueAttribute(string value) : Attribute
	{
		/// <summary>
		/// The value to return
		/// </summary>
		public string Value = value;
	}
}
