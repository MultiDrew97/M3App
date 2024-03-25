using System;
using System.Runtime.Serialization;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class InvalidStateCodeException : Exception
    {

        public InvalidStateCodeException() : base()
        {
        }

        public InvalidStateCodeException(string message) : base(message)
        {
        }

        public InvalidStateCodeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidStateCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}