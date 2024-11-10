using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// 
	/// </summary>
	public class UpdateException : Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public UpdateException() : base() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UpdateException(string message) : base(message) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="source"></param>
		public UpdateException(string message, Exception source) : base(message, source) { }
	}
}
