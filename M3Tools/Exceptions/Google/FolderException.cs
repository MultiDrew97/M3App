using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to folder operations
	/// </summary>
	[Serializable]
    public class FolderException : FileException
    {
		/// <summary>
		/// 
		/// </summary>
        public FolderException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public FolderException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public FolderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
