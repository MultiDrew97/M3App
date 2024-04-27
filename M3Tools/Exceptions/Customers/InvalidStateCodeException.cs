using System;
using System.Runtime.Serialization;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to having an invalid state code
	/// </summary>
    [Serializable]
    public class InvalidStateCodeException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public InvalidStateCodeException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public InvalidStateCodeException(string message) : base(message)
        {
        }

        /// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public InvalidStateCodeException(string message, Exception innerException) : base(message, innerException)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
        protected InvalidStateCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
