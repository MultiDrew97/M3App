using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to an upload error in the Google Drive API
	/// </summary>
    [Serializable]
    public class UploadException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public UploadException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public UploadException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public UploadException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
