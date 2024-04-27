using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to user errors
	/// </summary>
    [Serializable]
    public class UserException : Exception
    {

		/// <summary>
		/// 
		/// </summary>
        public UserException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public UserException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public UserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
