using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to the API
	/// </summary>
    public class ApiException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public ApiException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public ApiException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
