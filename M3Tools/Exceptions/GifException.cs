using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class GifException : Exception
    {

        public GifException() : base()
        {
        }

        public GifException(string message) : base(message)
        {
        }

        public GifException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}