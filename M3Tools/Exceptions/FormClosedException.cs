using System;
using System.Runtime.Serialization;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class FormClosedException : Exception
    {

        public FormClosedException() : base()
        {
        }

        public FormClosedException(string message) : base(message)
        {
        }

        public FormClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FormClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}