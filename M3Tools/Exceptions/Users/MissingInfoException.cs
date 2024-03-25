using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class MissingInfoException : Exception
    {

        public MissingInfoException() : base()
        {
        }

        public MissingInfoException(string message) : base(message)
        {
        }

        public MissingInfoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}