using System;

namespace SPPBC.M3Tools.Exceptions
{
    /// <summary>
	/// An exception related to the menu strip
	/// </summary>
	[Serializable]
    public class MenuException : Exception
    {

		/// <summary>
		/// 
		/// </summary>
        public MenuException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public MenuException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public MenuException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
