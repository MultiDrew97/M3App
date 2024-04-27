using System;
using System.Runtime.Serialization;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to when a form is closed unexpectedly
	/// </summary>
    [Serializable]
    public class FormClosedException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public FormClosedException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public FormClosedException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public FormClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
        protected FormClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
