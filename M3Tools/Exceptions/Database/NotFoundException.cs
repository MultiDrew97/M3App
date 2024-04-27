using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to when an entry is not found
	/// </summary>
    public class NotFoundException : Exception
    {

		/// <summary>
		/// 
		/// </summary>
        public NotFoundException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public NotFoundException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
