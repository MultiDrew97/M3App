using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception associated with a customer not being found
	/// </summary>
    [Serializable]
    public class CustomerNotFoundException : Exception
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public CustomerNotFoundException() : base()
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
        public CustomerNotFoundException(string message) : base(message)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public CustomerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
