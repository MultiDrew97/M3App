using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class UploadException : Exception
    {

        public UploadException() : base()
        {
        }

        public UploadException(string message) : base(message)
        {
        }

        public UploadException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}